Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module relatorio_faltas_professores
    Private celula() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"}
    Private cn2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")

    '----------- Dados----------------'
    Private nm_professor As String = ""
    Private faltas_just As String = ""
    Private faltas_injust As String = ""
    Private faltas_medicas As String = ""
    Private faltas_licenças As String = ""
    Private faltas_capacitacao As String = ""
    Private faltas_reuniao As String = ""
    Private faltas_atraso As String = ""
    Private num_adicionais As String = ""

    '-----------Excel--------------------'
    Private excelApp As New Excel.Application

    '----------Unidade escolar-----------'
    Private nm_unidade As String = ""
    Private caminho_logo_unidade As String = Application.StartupPath & "\unidade_escolar\"
    Private imagem As String = ""
    Private logo As String = ""

    '----------Professor------------'
    Private cd_professor As Integer = 0

    '----------Adicionais Noturnos------'
    Private numero_adicionais As Integer = 0

    '-------------Data---------------'
    Private mes As String = ""
    Private ano As String = ""
    Private mes_data As String = ""
    Private ano_data As String = ""
    Private data_completa As Date
    Public Sub gerar_relatorio_faltas_professores()
        Try
            mes = Relatorios_Professor.cmb_mes.Text
            ano = Relatorios_Professor.txt_ano.Text

            Select Case mes
                Case "Janeiro"
                    mes_data = "01/01/"
                Case "Fevereiro"
                    mes_data = "02/02/"
                Case "Março"
                    mes_data = "03/03/"
                Case "Abril"
                    mes_data = "04/04/"
                Case "Maio"
                    mes_data = "05/05/"
                Case "Junho"
                    mes_data = "06/06/"
                Case "Julho"
                    mes_data = "07/07/"
                Case "Agosto"
                    mes_data = "08/08/"
                Case "Setembro"
                    mes_data = "09/09/"
                Case "Outubro"
                    mes_data = "10/10/"
                Case "Novembro"
                    mes_data = "11/11/"
                Case "Dezembro"
                    mes_data = "12/12/"
            End Select
            data_completa = FormatDateTime(mes_data & Relatorios_Professor.txt_ano.Text, DateFormat.ShortDate)

            Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            excelApp.Visible = False
            excelWorksheet.DisplayPageBreaks = True
            excelWorksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape


            Dim t1 As New Threading.Thread(AddressOf relatorio_faltas)
            t1.Priority = Threading.ThreadPriority.Highest
            t1.IsBackground = True
            t1.Start(excelWorksheet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub relatorio_faltas(ByVal excelWorksheet As Excel.Worksheet)
        Try
            Dim t2 As New Threading.Thread(AddressOf cabeçalho)
            t2.Priority = Threading.ThreadPriority.Highest
            t2.IsBackground = True
            t2.Start(excelWorksheet)

            Dim t3 As New Threading.Thread(AddressOf titulos)
            t3.Priority = Threading.ThreadPriority.Highest
            t3.IsBackground = True
            t3.Start(excelWorksheet)

            Dim t4 As New Threading.Thread(AddressOf dados)
            t4.Priority = Threading.ThreadPriority.Highest
            t4.IsBackground = True
            t4.Start(excelWorksheet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cabeçalho(ByVal excelWorksheet_faltas As Excel.Worksheet)
        Dim celula2() As String = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K"}

        With excelWorksheet_faltas
            Try
                '--------Foto--------'
                carrega_unidade_escolar()
                .Shapes.AddPicture(logo, True, True, 150, 0, 300, 60)

                '-----Tamanho Colunas-----'
                .Range("A1").RowHeight = 60
                .Range("A1").ColumnWidth = 18
                For a As Integer = 1 To UBound(celula2)
                    .Range(celula2(a) & "1").ColumnWidth = 8
                Next
                .Range("L1").ColumnWidth = 9
                .Range("M1").ColumnWidth = 18

                '---------Escola e Data------'
                .Range("A2:M2").Merge()
                .Range("A2:M2").BorderAround()
                .Range("A2").RowHeight = 22
                .Range("A2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A2").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Range("A2").Font.Bold = True
                .Range("A2").Font.Name = "Arial"
                .Range("A2").Value = nm_unidade & " - " & mes & "/" & ano

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub

    Private Sub titulos(ByVal excelWorksheet_faltas As Excel.Worksheet)
        Dim titulo() As String = {"Professor", "Carga horária a partir de _______", "FaltaAula Injustificada /Data ", _
                                  "FaltaAula Justif/Data", "Falta Médica 1 Dia/Data", "Licença Médica/Data", _
                                  "Falta CEETEPS/Capacitação/Data", "Falta Reunião Pedagógica/Data", "Adicional Noturno", _
                                  "Falta Atraso", "Substituição/Data", "Reposição/Data", "Observações"}
        With excelWorksheet_faltas
            Try
                '---------Insere Titulos------'
                .Range("A3").RowHeight = 50
                For cont As Integer = 0 To 12
                    .Range(celula(cont) & "3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(celula(cont) & "3").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(celula(cont) & "3").BorderAround()
                    .Range(celula(cont) & "3").WrapText = True
                    .Range(celula(cont) & "3").Font.Name = "Arial"
                    .Range(celula(cont) & "3").Font.Size = 8
                    .Range(celula(cont) & "3").Value = titulo(cont)
                Next
                .Range("B3").Font.Bold = True
                .Range("I3").Font.ColorIndex = 3
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
    End Sub

    Private Sub dados(ByVal excelWorksheet_faltas As Excel.Worksheet)
            With excelWorksheet_faltas
            Try
                '---------Insere Dados-------'
                Dim cn1 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
                sql = "SELECT cd_professor FROM tb_professor ORDER BY nm_professor"
                cn1.Open()
                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                Dim linha As Integer = 0
                While dr.Read
                    cd_professor = dr.GetInt32(0)
                    cn2.Open()
                    carrega_professores()
                    carrega_faltas_aula_injust()
                    carrega_faltas_aula_just()
                    carrega_faltas_medicas()
                    carrega_faltas_licenças_medicas()
                    carrega_faltas_capacitacao()
                    carrega_faltas_reuniao()
                    carrega_adcional_noturno()
                    carrega_faltas_atraso()
                    cn2.Close()
                    For coluna As Integer = 0 To 12
                        .Range(celula(coluna) & linha + 4).Font.Name = "Arial"
                        .Range(celula(coluna) & linha + 4).Font.Size = 9
                        .Range(celula(coluna) & linha + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Range(celula(coluna) & linha + 4).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .Range(celula(coluna) & linha + 4).BorderAround()
                        .Range(celula(coluna) & linha + 4).WrapText = True
                        If coluna = 0 Then
                            .Range(celula(coluna) & linha + 4).Value = nm_professor
                        ElseIf coluna = 2 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_injust
                        ElseIf coluna = 3 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_just
                        ElseIf coluna = 4 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_medicas
                        ElseIf coluna = 5 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_licenças
                        ElseIf coluna = 6 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_capacitacao
                        ElseIf coluna = 7 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_reuniao
                        ElseIf coluna = 8 Then
                            .Range(celula(coluna) & linha + 4).Value = num_adicionais
                        ElseIf coluna = 9 Then
                            .Range(celula(coluna) & linha + 4).Value = faltas_atraso
                        Else
                            .Range(celula(coluna) & linha + 4).Value = ""
                        End If
                    Next
                    linha += 1
                End While
                cn1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                excelApp.Visible = True
            End Try
        End With
    End Sub

    Private Sub carrega_unidade_escolar()
        Dim cn1 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
        sql = "SELECT nm_unidade,im_logo FROM tb_unidade_escolar Where cd_unidade = 1"
        cn1.Open()
        Dim comando As New SqlCommand(sql, cn1)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            nm_unidade = dr.GetString(0)
            imagem = dr.GetString(1)
        End While
        cn1.Close()
        logo = caminho_logo_unidade + imagem
    End Sub

    Private Sub carrega_professores()
        sql = "SELECT nm_professor FROM tb_professor WHERE cd_professor = " & cd_professor
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            nm_professor = dr.GetString(0)
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_aula_just()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE ds_tipo_falta ='Falta Aula Justificada' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_just = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_aula_injust()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE ds_tipo_falta ='Falta Aula Injustificada' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_injust = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_medicas()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE ds_tipo_falta ='Falta Médica' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_medicas = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_licenças_medicas()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE ds_tipo_falta ='Licença Médica' " & _
        "AND cd_professor = " & cd_professor & " AND " & _
        "((DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "')) " & _
        "OR (DatePart(Month, tb_faltas_professor.dt_falta2) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(Year, tb_faltas_professor.dt_falta2) =  DatePart(YEAR,'" & data_completa & "'))) "

        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_licenças = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_capacitacao()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE ds_tipo_falta ='Capacitação' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_capacitacao = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_reuniao()
        sql = "SELECT COUNT(*) FROM tb_faltas_professor WHERE ds_tipo_falta ='Reunião' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_reuniao = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_adcional_noturno()
        sql = "SELECT COUNT(*) FROM tb_ad_noturno WHERE cd_professor = " & cd_professor & _
        " AND DatePart(Month, tb_ad_noturno.dt_ad_noturno) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR, tb_ad_noturno.dt_ad_noturno) = DatePart(YEAR,'" & data_completa & "') "

        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            num_adicionais = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_faltas_atraso()
        sql = "SELECT COUNT(ds_tipo_falta) FROM tb_faltas_professor WHERE  ds_tipo_falta ='Falta Atraso' " & _
        "AND cd_professor = " & cd_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') "

        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            faltas_atraso = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub
End Module
