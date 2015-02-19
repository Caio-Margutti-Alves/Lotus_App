Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graficos_aluno
    '-----------Dados-------
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0

    '-------------Data---------------'
    Private mes As String = ""
    Private ano As String = ""
    Private data_completa As Date

    Private Sub Relatorio_Ausencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        gerar_graficos_ausencia()
    End Sub

    Private Sub mnu_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_imprimir.Click
        mnu_sup.Visible = False
        Me.Height = 1100
        lbl_aluno.Location = New Point(lbl_aluno.Location.X + 25, lbl_aluno.Location.Y - 71)
        cht_aulas.Location = New Point(cht_aulas.Location.X, cht_aulas.Location.Y - 71)
        cht_componentes.Location = New Point(cht_componentes.Location.X, cht_componentes.Location.Y - 71)
        cht_semana.Location = New Point(cht_semana.Location.X, cht_semana.Location.Y - 71)
        cht_semana_aula.Location = New Point(cht_semana_aula.Location.X, cht_semana_aula.Location.Y - 71)
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        lbl_aluno.Location = New Point(lbl_aluno.Location.X - 25, lbl_aluno.Location.Y + 71)
        cht_aulas.Location = New Point(cht_aulas.Location.X, cht_aulas.Location.Y + 71)
        cht_componentes.Location = New Point(cht_componentes.Location.X, cht_componentes.Location.Y + 71)
        cht_semana.Location = New Point(cht_semana.Location.X, cht_semana.Location.Y + 71)
        cht_semana_aula.Location = New Point(cht_semana_aula.Location.X, cht_semana_aula.Location.Y + 71)
        Me.Height = 413
        mnu_sup.Visible = True
    End Sub

    Private Sub gerar_graficos_ausencia()
        cd_turma = Relatorios_Aluno.cmb_turma.SelectedValue
        Try
            carregar_requisitos_graficos()
            grafico_aulas()
            grafico_dias()
            grafico_materias()
            grafico_aulas_dias()
        Catch ex As Exception
            MessageBox.Show("Não foi possível gerar os Gráficos:" & vbNewLine & ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub grafico_aulas()
        Dim yValues() As Double = {0.0, 0.0}
        Dim total As Double = 0.0
        Dim xNames() As String = {"", ""}
        Try
            conexao.Open()
            sql = "SELECT qt_aula_sem FROM tb_curso WHERE cd_curso = " & cd_curso
            Dim comando As New SqlCommand(sql, conexao)
            Dim dr As SqlDataReader = comando.ExecuteReader
            While dr.Read
                ReDim yValues(dr.GetValue(0) / 5)
                ReDim xNames(dr.GetValue(0) / 5)
            End While

            For a As Integer = 1 To UBound(xNames)
                xNames(a) = a & "ª Aula"
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        Finally
            conexao.Close()
        End Try

        Try
            For a As Integer = 1 To UBound(yValues)
                conexao.Open()
                sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_aluno " & _
                "INNER JOIN  tb_aluno ON tb_faltas_aluno.cd_aluno = tb_aluno.cd_aluno " & _
                "INNER JOIN tb_juncao_turma_aluno ON tb_aluno.cd_aluno = tb_juncao_turma_aluno.cd_aluno " & _
                "WHERE DatePart(Month, tb_faltas_aluno.dt_falta) = DatePart(Month,'" & data_completa & "') " & _
                "And DatePart(Year, tb_faltas_aluno.dt_falta) =  DatePart(Year,'" & data_completa & "') " & _
                "And tb_faltas_aluno.ds_aula = '" & a & "' And tb_juncao_turma_aluno.cd_turma = " & cd_turma & _
                " And tb_faltas_aluno.cd_turma = " & cd_turma
                Dim comando As New SqlCommand(sql, conexao)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    yValues(a) = dr.GetValue(0)
                End While
                conexao.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
        For a As Integer = 1 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 1 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next

        With cht_aulas
            .Titles.Add("AUSÊNCIAS POR AULAS - " & Relatorios_Aluno.cmb_turma.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Series(0).Points.DataBindXY(xNames, yValues)
        End With

    End Sub

    Private Sub grafico_dias()
        Dim yValues(4), total As Double
        Dim xNames() As String = {"Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira"}
        Dim dias() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}

        Try
            For a As Integer = 1 To 5
                conexao.Open()
                sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_aluno " & _
                "WHERE DATEPART(month,tb_faltas_aluno.dt_falta)=DatePart(Month,'" & data_completa & "') " & _
                "AND DATEPART(year,tb_faltas_aluno.dt_falta)= DatePart(Year,'" & data_completa & "') " & _
                "AND DATEPART(DW, tb_faltas_aluno.dt_falta) = " & a + 1 & _
                " AND tb_faltas_aluno.cd_turma= " & cd_turma
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
        For a As Integer = 1 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 1 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next
        With cht_semana
            .Titles.Add("AUSÊNCIAS POR DIAS DA SEMANA - " & Relatorios_Aluno.cmb_turma.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Series(0).Points.DataBindXY(xNames, yValues)
        End With
    End Sub

    Private Sub grafico_materias()
        Dim yValues() As Double = {0.0, 0.0}
        Dim total As Double = 0.0
        Dim xNames() As String = {"", ""}
        Try
            conexao.Open()
            sql = "SELECT COUNT(*) AS Expr1 FROM tb_disciplina " & _
            "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
            "INNER JOIN tb_turma ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
            "WHERE tb_turma.cd_turma = " & cd_turma
            Dim comando As New SqlCommand(sql, conexao)
            Dim dr As SqlDataReader = comando.ExecuteReader
            While dr.Read
                ReDim yValues(dr.GetValue(0))
                ReDim xNames(dr.GetValue(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        Finally
            conexao.Close()
        End Try
        Try
            conexao.Open()
            sql = "SELECT DISTINCT tb_disciplina.sg_disciplina FROM tb_disciplina " & _
            "INNER JOIN tb_aula ON tb_disciplina.cd_disciplina = tb_aula.cd_disciplina " & _
            "WHERE tb_aula.cd_turma=" & cd_turma
            Dim comando As New SqlCommand(sql, conexao)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Dim b As Integer = 1
            While dr.Read
                If b > UBound(xNames) Then Exit While
                xNames(b) = dr.GetString(0)
                b += 1
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        Finally
            conexao.Close()
        End Try

        For a As Integer = 1 To UBound(xNames)
            Try
                conexao.Open()
                sql = "SELECT COUNT(*) AS Expr1 FROM tb_faltas_aluno " & _
                "INNER JOIN tb_disciplina ON tb_faltas_aluno.cd_disciplina = tb_disciplina.cd_disciplina " & _
                "INNER JOIN tb_aluno ON tb_faltas_aluno.cd_aluno = tb_aluno.cd_aluno " & _
                "INNER JOIN  tb_juncao_turma_aluno ON tb_aluno.cd_aluno = tb_juncao_turma_aluno.cd_aluno " & _
                "WHERE DATEPART(month,tb_faltas_aluno.dt_falta)= DatePart(Month,'" & data_completa & "') " & _
                "AND DATEPART(year,tb_faltas_aluno.dt_falta)=DatePart(Year,'" & data_completa & "') " & _
                "AND tb_disciplina.sg_disciplina='" & xNames(a) & "' " & _
                "AND tb_juncao_turma_aluno.cd_turma= " & cd_turma & _
                "AND tb_faltas_aluno.cd_turma=" & cd_turma
                Dim comando As New SqlCommand(sql, conexao)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    yValues(a) = dr.GetValue(0)
                End While
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conexao.Close()
                Exit Sub
            End Try
        Next
        For a As Integer = 1 To UBound(yValues)
            total = total + yValues(a)
        Next
        For a As Integer = 1 To UBound(yValues)
            yValues(a) = (yValues(a) / total) * 100
        Next
        With cht_componentes
            .Titles.Add("AUSÊNCIAS POR COMPONENTES - " & Relatorios_Aluno.cmb_turma.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .Series(0).Points.DataBindXY(xNames, yValues)
        End With
    End Sub

    Private Sub grafico_aulas_dias()
        Dim yValues() As Double = {0.0, 0.0}
        Dim xNames() As String = {"", ""}
        Dim dias() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}
        Dim xSemana() As String = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"}

        Try
            cht_semana_aula.Series.Clear()
            conexao.Open()
            sql = "SELECT qt_aula_sem FROM tb_curso WHERE cd_curso = " & cd_curso
            Dim comando As New SqlCommand(sql, conexao)
            Dim dr As SqlDataReader = comando.ExecuteReader
            While dr.Read
                ReDim yValues((dr.GetValue(0) / 5) - 1)
                ReDim xNames(dr.GetValue(0) / 5)
            End While
            For b As Integer = 1 To UBound(xNames)
                xNames(b) = b & "ª Aula"
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        Finally
            conexao.Close()
        End Try

        Try
            For a As Integer = 1 To UBound(xNames)
                For z As Integer = 1 To 5
                    sql = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tb_faltas_aluno " & _
                    "WHERE DATEPART(month,tb_faltas_aluno.dt_falta)=DatePart(Month,'" & data_completa & "') " & _
                    "AND DATEPART(year,tb_faltas_aluno.dt_falta)= DatePart(Year,'" & data_completa & "') " & _
                    "AND DATEPART(DW, tb_faltas_aluno.dt_falta) = " & z + 1 & _
                    " AND tb_faltas_aluno.ds_aula = '" & a & "' " & _
                    "AND tb_faltas_aluno.cd_turma= " & cd_turma
                    conexao.Open()
                    Dim comando As New SqlCommand(sql, conexao)
                    Dim dr As SqlDataReader = comando.ExecuteReader
                    While dr.Read
                        yValues(z - 1) = dr.GetValue(0)
                    End While
                    conexao.Close()
                Next
                cht_semana_aula.Series.Add(xNames(a)).Points.DataBindXY(xSemana, yValues)
            Next
            cht_semana_aula.Titles.Add("AUSÊNCIA POR AULA/DIA DA SEMANA - " & Relatorios_Aluno.cmb_turma.Text).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
            Exit Sub
        End Try
    End Sub
   
    Private Sub carregar_requisitos_graficos()
        Try
            conexao.Open()
            carregar_curso()
            carregar_ano()
            conexao.Close()

            Select Case Relatorios_Aluno.cmb_mes.Text
                Case "Janeiro"
                    mes = "01/01/"
                Case "Fevereiro"
                    mes = "02/02/"
                Case "Março"
                    mes = "03/03/"
                Case "Abril"
                    mes = "04/04/"
                Case "Maio"
                    mes = "05/05/"
                Case "Junho"
                    mes = "06/06/"
                Case "Julho"
                    mes = "07/07/"
                Case "Agosto"
                    mes = "08/08/"
                Case "Setembro"
                    mes = "09/09/"
                Case "Outubro"
                    mes = "10/10/"
                Case "Novembro"
                    mes = "11/11/"
                Case "Dezembro"
                    mes = "12/12/"
            End Select
            data_completa = FormatDateTime(mes & ano, DateFormat.ShortDate)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub carregar_curso()
        sql = "SELECT cd_curso FROM tb_turma WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            cd_curso = dr.GetInt32(0)
        End While
        dr.Close()
    End Sub
    Private Sub carregar_ano()
        sql = "SELECT dt_ano FROM tb_turma WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            ano = dr.GetString(0)
        End While
        dr.Close()
    End Sub
End Class