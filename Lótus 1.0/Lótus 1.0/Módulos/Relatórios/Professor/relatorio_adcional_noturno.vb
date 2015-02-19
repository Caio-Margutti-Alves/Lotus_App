Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Module relatorio_adcional_noturno

    Private celula() As String = {"A", "B", "C", "E", "F", "G", "H", "J"}
    Private cn2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")

    '-------------Dados-----------------'
    Private foto_professor As String = ""
    Private nm_professor As String = ""
    Private numero_adicionais As String = ""
    Private total_ad As String = ""

    '-----------Excel--------------------'
    Private excelApp As New Excel.Application

    '----------Unidade escolar-----------'
    Private nm_unidade As String = ""
    Private caminho_logo_unidade As String = Application.StartupPath & "\unidade_escolar\"
    Private imagem As String = ""
    Private logo As String = ""

    '----------Professor------------'
    Private cd_professor As Integer = 0
    Private caminho_foto_professor As String = Application.StartupPath & "\imagens_professores\"
    Private imagem2 As String = ""

    '-------------Data---------------'
    Private mes As String = ""
    Private ano As String = ""
    Private mes_data As String = ""
    Private ano_data As String = ""
    Private data_completa As Date

    Public Sub gerar_relatorio_adcional_noturno()
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
            excelWorksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait

            Dim t1 As New Threading.Thread(AddressOf relatorio_adicional)
            t1.Priority = Threading.ThreadPriority.Highest
            t1.IsBackground = True
            t1.Start(excelWorksheet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub relatorio_adicional(ByVal excelWorksheet As Excel.Worksheet)
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
        With excelWorksheet_faltas
            Try
                '--------Foto--------'
                carrega_unidade_escolar()
                .Shapes.AddPicture(logo, True, True, 90, 0, 300, 60)

                '-----Tamanho Colunas-----'
                .Range("A1").RowHeight = 60

                '---------Escola e Data------'
                .Range("A2:J2").Merge()
                .Range("A2:J2").BorderAround()
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
        Dim titulo() As String = {"Foto", "Professor", "Total Ad Noturnos", "Valor Total"}
        With excelWorksheet_faltas
            Try

                '---------Insere Titulos------'
                .Range("A3").RowHeight = 20
                Dim cont2 = 0
                For cont As Integer = 0 To 7 Step 2
                    .Range(celula(cont) & "3:" & celula(cont + 1) & "3").Merge()
                    .Range(celula(cont) & "3").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(celula(cont) & "3").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(celula(cont) & "3").BorderAround()
                    .Range(celula(cont) & "3").WrapText = True
                    .Range(celula(cont) & "3").Font.Name = "Arial"
                    .Range(celula(cont) & "3").Font.Size = 8
                    .Range(celula(cont) & "3").Value = titulo(cont2)
                    cont2 += 1
                Next
                .Range("H3").Font.ColorIndex = 3
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
                    carrega_num_adcional_noturno()
                    carrega_total_adcional_noturno()
                    cn2.Close()
                    For coluna As Integer = 0 To 7 Step 2
                        .Range(celula(coluna) & linha + 4 & ":" & celula(coluna + 1) & linha + 4).Merge()
                        .Range(celula(coluna) & linha + 4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Range(celula(coluna) & linha + 4).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .Range(celula(coluna) & linha + 4).BorderAround()
                        .Range(celula(coluna) & linha + 4).WrapText = True
                        .Range(celula(coluna) & linha + 4).Font.Name = "Arial"
                        .Range(celula(coluna) & linha + 4).Font.Size = 9
                        If coluna = 0 Then
                            .Range(celula(coluna) & linha + 4).RowHeight = 60
                            If imagem2 = "" Then
                                .Range(celula(coluna) & linha + 4).Value = "Sem Foto"
                            Else
                                foto_professor = caminho_foto_professor & imagem2
                                Try
                                    If linha = 0 Then
                                        .Shapes.AddPicture(foto_professor, True, True, 25, 107, 50, 50)
                                    Else
                                        .Shapes.AddPicture(foto_professor, True, True, 25, 107 + (linha * 60), 50, 50)
                                    End If
                                Catch ex As Exception
                                    .Range(celula(coluna) & linha + 4).Value = "Erro na Foto"
                                End Try
                            End If
                        ElseIf coluna = 2 Then
                            .Range(celula(coluna) & linha + 4).Value = nm_professor
                        ElseIf coluna = 4 Then
                            .Range(celula(coluna) & linha + 4).Value = numero_adicionais
                        ElseIf coluna = 6 Then
                            total_ad = "R$ " & total_ad
                            .Range(celula(coluna) & linha + 4).Value = total_ad
                            .Range(celula(coluna) & linha + 4).Font.ColorIndex = 3
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
        logo = caminho_logo_unidade & imagem
    End Sub
  
    Private Sub carrega_professores()
        sql = "SELECT nm_professor,im_professor FROM tb_professor WHERE cd_professor = " & cd_professor
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            nm_professor = dr.GetString(0)
            imagem2 = dr.GetString(1)
        End While
        dr.Close()
    End Sub

    Private Sub carrega_num_adcional_noturno()
        sql = "SELECT COUNT(*) FROM tb_ad_noturno WHERE cd_professor = " & cd_professor & _
        " AND DatePart(Month, tb_ad_noturno.dt_ad_noturno) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR, tb_ad_noturno.dt_ad_noturno) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            numero_adicionais = dr.GetInt32(0).ToString
        End While
        dr.Close()
    End Sub

    Private Sub carrega_total_adcional_noturno()
        sql = "SELECT isnull(SUM(vl_ad_noturno),0) FROM tb_ad_noturno WHERE cd_professor = " & cd_professor & _
        " AND DatePart(Month, tb_ad_noturno.dt_ad_noturno) = DatePart(Month,'" & data_completa & "') " & _
        "AND DatePart(YEAR, tb_ad_noturno.dt_ad_noturno) = DatePart(YEAR,'" & data_completa & "') "
        Dim comando As New SqlCommand(sql, cn2)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            total_ad = dr.GetSqlDecimal(0)
        End While
        dr.Close()
    End Sub
End Module
