Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graficos_professor
    '-----------Dados-------
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0

    '-------------Data---------------'
    Private mes As String = ""
    Private ano As String = ""

    Private Sub Graficos_professor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        gerar_graficos_ausencia()
    End Sub

    Private Sub mnu_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_imprimir.Click
        mnu_sup.Visible = False
        Me.Height = 1100
        lbl_professor.Location = New Point(lbl_professor.Location.X + 25, lbl_professor.Location.Y - 71)
        cht_ad_noturno.Location = New Point(cht_ad_noturno.Location.X, cht_ad_noturno.Location.Y - 71)
        cht_tipo_falta.Location = New Point(cht_tipo_falta.Location.X, cht_tipo_falta.Location.Y - 71)
        cht_dias.Location = New Point(cht_dias.Location.X, cht_dias.Location.Y - 71)
        cht_semana_tipo_falta.Location = New Point(cht_semana_tipo_falta.Location.X, cht_semana_tipo_falta.Location.Y - 71)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        lbl_professor.Location = New Point(lbl_professor.Location.X - 25, lbl_professor.Location.Y + 71)
        cht_ad_noturno.Location = New Point(cht_ad_noturno.Location.X, cht_ad_noturno.Location.Y + 71)
        cht_tipo_falta.Location = New Point(cht_tipo_falta.Location.X, cht_tipo_falta.Location.Y + 71)
        cht_dias.Location = New Point(cht_dias.Location.X, cht_dias.Location.Y + 71)
        cht_semana_tipo_falta.Location = New Point(cht_semana_tipo_falta.Location.X, cht_semana_tipo_falta.Location.Y + 71)
        Me.Height = 413
        mnu_sup.Visible = True
    End Sub

    Public Sub gerar_graficos_ausencia()
        cd_turma = Relatorios_Aluno.cmb_turma.SelectedValue
        Try
            carregar_requisitos_graficos()
            grafico_ad_noturno()
            grafico_tipo_falta()
            grafico_dias()
            grafico_faltas_dias()
        Catch ex As Exception
            MessageBox.Show("Não foi possível gerar os Gráficos:" & vbNewLine & ex.ToString)
            conexao.Close()
        End Try
    End Sub
    Private Sub grafico_ad_noturno()
        Dim yValues(4), total As Double
        Dim xNames() As String = {"Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira"}
        Dim dias() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}

        Try
            For a As Integer = 1 To 5
                conexao.Open()
                sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_ad_noturno " & _
                "WHERE DatePart(Month, tb_ad_noturno.dt_ad_noturno) = " & mes & _
                "And DatePart(Year, tb_ad_noturno.dt_ad_noturno) = " & ano & _
                "AND DATEPART(DW, tb_ad_noturno.dt_ad_noturno) = " & a + 1
                Dim comando As New SqlCommand(sql, conexao)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    yValues(a - 1) = dr.GetValue(0)
                End While
                conexao.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
        For a As Integer = 0 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 0 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next
        If total = 0 Then
            lbl_cht_ad_noturno.Visible = True
            lbl_cht_ad_noturno.Text = "NENHUMA OCORRÊNCIA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano
        Else
            With cht_ad_noturno
                .Titles.Add("SOMATÓRIA POR DIAS DA SEMANA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                .Series(0).Points.DataBindXY(xNames, yValues)
            End With
        End If
    End Sub

    Private Sub grafico_tipo_falta()
        Dim yValues(6) As Double
        Dim total As Double
        Dim xNames() As String = {"Falta Atraso", "Falta Aula Justificada", "Falta Aula Injustificada", "Reunião", "Capacitação", "Falta Médica", "Licença Médica"}
        Try
            For a As Integer = 1 To 7
                conexao.Open()
                sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_professor " & _
                "WHERE ((DatePart(Month, tb_faltas_professor.dt_falta1) = " & mes & _
                "AND DatePart(Year, tb_faltas_professor.dt_falta1) =  " & ano & ") " & _
                "OR (DatePart(Month, tb_faltas_professor.dt_falta2) = " & mes & _
                " AND DatePart(Year, tb_faltas_professor.dt_falta2) =  " & ano & ")) " & _
                "AND ds_tipo_falta = '" & xNames(a - 1) & "'"
                Dim comando As New SqlCommand(sql, conexao)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    yValues(a - 1) = dr.GetValue(0)
                End While
                conexao.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
        For a As Integer = 0 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 0 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next
        If total = 0 Then
            lbl_cht_tipo_falta.visible = True
            lbl_cht_tipo_falta.text = "NENHUMA OCORRÊNCIA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano
        Else
            With cht_tipo_falta
                .Titles.Add("AUSÊNCIAS POR TIPOS DE FALTA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                .Series(0).Points.DataBindXY(xNames, yValues)
            End With
        End If
    End Sub

    Private Sub grafico_dias()
        Dim yValues(4), total As Double
        Dim xNames() As String = {"Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira"}
        Dim dias() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}

        Try
            For a As Integer = 1 To 5
                conexao.Open()
                sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_professor " & _
                "WHERE DATEPART(month,tb_faltas_professor.dt_falta1)= " & mes & _
                " AND DATEPART(year,tb_faltas_professor.dt_falta1)= " & ano & _
                " AND DATEPART(DW, tb_faltas_professor.dt_falta1) = " & a + 1 & _
                " AND ds_tipo_falta <> 'Licença Médica'"

                Dim comando As New SqlCommand(sql, conexao)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    yValues(a - 1) = dr.GetValue(0)
                End While
                conexao.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
        For a As Integer = 0 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 0 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next
        If total = 0 Then
            lbl_cht_dias.Visible = True
            lbl_cht_dias.Text = "NENHUMA OCORRÊNCIA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano
        Else
            With cht_dias
                .Titles.Add("AUSÊNCIAS POR DIAS DA SEMANA - " & Relatorios_Professor.txt_ano.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                .Series(0).Points.DataBindXY(xNames, yValues)
            End With
        End If
    End Sub

    Private Sub grafico_faltas_dias()
        Dim yValues(4) As Double
        Dim total As Double
        Dim xNames() As String = {"Falta Atraso", "Falta Aula Justificada", "Falta Aula Injustificada", "Reunião", "Capacitação", "Falta Médica"}
        Dim dias() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}
        Dim xSemana() As String = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"}

        Try
            cht_semana_tipo_falta.Series.Clear()
            For a As Integer = 1 To UBound(xNames)
                For z As Integer = 1 To 5
                    sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_professor " & _
                    "WHERE DATEPART(month,tb_faltas_professor.dt_falta1)= " & mes & _
                    " AND DATEPART(year,tb_faltas_professor.dt_falta1)= " & ano & _
                    " AND DATEPART(DW, tb_faltas_professor.dt_falta1) = " & z + 1 & _
                    " AND ds_tipo_falta = '" & xNames(a - 1) & "'"

                    conexao.Open()
                    Dim comando As New SqlCommand(sql, conexao)
                    Dim dr As SqlDataReader = comando.ExecuteReader
                    While dr.Read
                        yValues(z - 1) = dr.GetValue(0)
                    End While
                    conexao.Close()

                    total = total + yValues(z - 1)
                Next
                If total = 0 Then
                Else
                    cht_semana_tipo_falta.Series.Add(xNames(a - 1)).Points.DataBindXY(xSemana, yValues)
                    cht_semana_tipo_falta.Series(a - 1).ChartType = SeriesChartType.StackedColumn
                End If
            Next
            If total = 0 Then
                lbl_cht_faltas_dias.Visible = True
                lbl_cht_faltas_dias.Text = "NENHUMA OCORRÊNCIA - " & Relatorios_Professor.cmb_mes.Text & "/" & ano
            Else
                cht_semana_tipo_falta.Titles.Add("AUSÊNCIA POR TIPO DE FALTA/DIA DA SEMANA - " & Relatorios_Professor.txt_ano.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub carregar_requisitos_graficos()
        Try
            mes = Relatorios_Professor.cmb_mes.Text
            ano = Relatorios_Professor.txt_ano.Text
            Select Case mes
                Case "Janeiro"
                    mes = "01"
                Case "Fevereiro"
                    mes = "02"
                Case "Março"
                    mes = "03"
                Case "Abril"
                    mes = "04"
                Case "Maio"
                    mes = "05"
                Case "Junho"
                    mes = "06"
                Case "Julho"
                    mes = "07"
                Case "Agosto"
                    mes = "08"
                Case "Setembro"
                    mes = "09"
                Case "Outubro"
                    mes = "10"
                Case "Novembro"
                    mes = "11"
                Case "Dezembro"
                    mes = "12"
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub
End Class