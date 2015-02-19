Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Module relatorio_mensal

    '-----------Dados-------
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0
    Private nm_turma As String = ""
    Private nm_curso As String = ""
    Private semestre() As String
    Private cd_periodo As Integer = 0
    Private ds_modulo As String = ""

    '-----------Excel--------------------'
    Private excelApp As New Excel.Application

    '----------Unidade escolar-----------'
    Private nm_unidade As String = ""
    Private caminho_logo_unidade As String = Application.StartupPath & "\unidade_escolar\"
    Private imagem As String = ""
    Private logo As String = ""

    '-------------Data---------------'
    Private mes As String = ""
    Private ano As String = ""

    Public Sub gerar_relatorio_mensal()
        Try
            Select Case Relatorios_Aluno.cmb_mes.Text
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

            cd_turma = Relatorios_Aluno.cmb_turma.SelectedValue

            conexao.Open()
            carrega_unidade_escolar()
            carrega_turmas()
            carregar_curso()
            carregar_ano()
            conexao.Close()

            Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            excelApp.Visible = False
            excelWorksheet.DisplayPageBreaks = True
            excelWorksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait

            Dim t1 As New Threading.Thread(AddressOf relatorio_mensal)
            t1.Priority = Threading.ThreadPriority.Highest
            t1.IsBackground = True
            t1.Start(excelWorksheet)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub relatorio_mensal(ByVal excelWorksheet As Excel.Worksheet)
        Try
            Dim t2 As New Threading.Thread(AddressOf relatorio_mensal_1)
            t2.Priority = Threading.ThreadPriority.Highest
            t2.IsBackground = True
            t2.Start(excelWorksheet)

            Dim t3 As New Threading.Thread(AddressOf relatorio_mensal_2)
            t3.Priority = Threading.ThreadPriority.Highest
            t3.IsBackground = True
            t3.Start(excelWorksheet)

            Dim t4 As New Threading.Thread(AddressOf relatorio_mensal_3)
            t4.Priority = Threading.ThreadPriority.Highest
            t4.IsBackground = True
            t4.Start(excelWorksheet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub relatorio_mensal_1(ByVal excelWorksheet As Excel.Worksheet)
        Dim cn1 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
        Dim cd_aluno(0), cd_materia(0), a, b, c As Integer
        Dim nmaterias As Integer = 0
        Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}
        With excelWorksheet

            'Preenche o nome e o numero do aluno no relatório
            Try
                cn1.Open()
                sql = "SELECT tb_aluno.cd_aluno,tb_aluno.nm_aluno FROM tb_aluno " & _
                "INNER JOIN tb_juncao_turma_aluno ON tb_aluno.cd_aluno = tb_juncao_turma_aluno.cd_aluno " & _
                "WHERE cd_turma=" & cd_turma & "ORDER BY nm_aluno"

                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                Dim cont As Integer = 1
                Dim cel As Integer = 12
                If Not dr.HasRows = True Then ReDim cd_aluno(0)
                While dr.Read
                    ReDim Preserve cd_aluno(cont - 1)
                    cd_aluno(cont - 1) = dr.GetInt32(0)
                    .Range("A" & cel & ":B" & cel).Merge()
                    .Range("A" & cel & ":B" & cel).BorderAround()
                    .Range("C" & cel & ":Q" & cel).Merge()
                    .Range("C" & cel & ":Q" & cel).BorderAround()
                    .Range(alfa(0) & cel).Font.Size = 12
                    .Range(alfa(0) & cel).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(0) & cel).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(alfa(0) & cel).Value = cont
                    .Range(alfa(2) & cel).Value = dr.GetString(1)
                    .Range(alfa(2) & cel).Font.Size = 12
                    .Range(alfa(2) & cel).RowHeight = 27
                    .Range(alfa(2) & cel).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    cont += 1
                    cel += 1
                End While
                cn1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            End Try

            'Pega a quantidade de materias da turma selecionada
            Try
                cn1.Open()
                sql = "SELECT COUNT(*) AS Materias  FROM tb_disciplina " & _
                "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
                "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
                "INNER JOIN tb_turma ON tb_juncao_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
                "WHERE tb_turma.cd_turma=" & cd_turma
                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                dr.Read()
                ReDim cd_materia(dr.GetInt32(0))
                nmaterias = dr.GetInt32(0)
                cn1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            End Try

            a = 17
            b = 18
            c = 19
            'Insere as colunas das materias
            Try
                cn1.Open()
                sql = "SELECT tb_disciplina.cd_disciplina, tb_disciplina.nm_disciplina FROM tb_disciplina " & _
                "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
                "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
                "INNER JOIN tb_turma ON tb_juncao_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
                "WHERE tb_turma.cd_turma =" & cd_turma
                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                Dim cont As Integer = 0
                While dr.Read
                    cd_materia(cont) = dr.GetInt32(0)
                    .Range(alfa(a) & "11:" & alfa(c) & "11").Merge()
                    .Range(alfa(a) & "11:" & alfa(c) & "11").BorderAround()
                    .Range(alfa(a) + "11").Font.Size = 11
                    .Range(alfa(a) + "11").Value = dr.GetString(1)
                    .Range(alfa(a) + "11").Orientation = 90
                    .Range(alfa(a) + "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(a) + "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignJustify
                    cont += 1
                    If cont = nmaterias Then Exit While
                    a = c + 1
                    b = a + 1
                    c = a + 2
                End While
                cn1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            End Try

            'Componentes Curriculares
            .Range("R10:" & alfa(c) & "10").Merge()
            .Range("R10:" & alfa(c) & "10").Value = "Componentes Curriculares"
            .Range("R10:" & alfa(c) & "10").BorderAround()
            .Range("R10:" & alfa(c) & "10").Font.Bold = True
            .Range("R10:" & alfa(c) & "10").Font.Size = 12
            .Range("R10:" & alfa(c) & "10").Cells.Interior.ColorIndex = 15
            .Range("R10:" & alfa(c) & "10").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("R10:" & alfa(c) & "10").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            a = c + 1
            b = a + 1
            c = a + 2

            .Range(alfa(a) & "10:" & alfa(b) & "11").Merge()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Value = "Nº de aulas"
            .Range(alfa(a) & "10:" & alfa(b) & "11").BorderAround()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Bold = True
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Size = 12
            .Range(alfa(a) & "10:" & alfa(b) & "11").Orientation = 90
            .Range(alfa(a) & "10:" & alfa(b) & "11").Interior.ColorIndex = 15
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            a = b + 1
            b = a + 1


            .Range(alfa(a) & "10:" & alfa(b) & "11").Merge()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Value = "Faltas"
            .Range(alfa(a) & "10:" & alfa(b) & "11").BorderAround()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Bold = True
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Size = 12
            .Range(alfa(a) & "10:" & alfa(b) & "11").Orientation = 90
            .Range(alfa(a) & "10:" & alfa(b) & "11").Interior.ColorIndex = 15
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            a = b + 1
            b = a + 1


            .Range(alfa(a) & "10:" & alfa(b) & "11").Merge()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Value = "Total de Faltas"
            .Range(alfa(a) & "10:" & alfa(b) & "11").BorderAround()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Bold = True
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Size = 12
            .Range(alfa(a) & "10:" & alfa(b) & "11").Orientation = 90
            .Range(alfa(a) & "10:" & alfa(b) & "11").Interior.ColorIndex = 15
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


            a = b + 1
            b = a + 1


            .Range(alfa(a) & "10:" & alfa(b) & "11").Merge()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Value = "Frequência %"
            .Range(alfa(a) & "10:" & alfa(b) & "11").BorderAround()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Bold = True
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Size = 12
            .Range(alfa(a) & "10:" & alfa(b) & "11").Orientation = 90
            .Range(alfa(a) & "10:" & alfa(b) & "11").Interior.ColorIndex = 15
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            a = b + 1
            b = a + 8


            .Range(alfa(a) & "10:" & alfa(b) & "11").Merge()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Value = "Ciência do Aluno"
            .Range(alfa(a) & "10:" & alfa(b) & "11").BorderAround()
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Bold = True
            .Range(alfa(a) & "10:" & alfa(b) & "11").Font.Size = 12
            .Range(alfa(a) & "10:" & alfa(b) & "11").Interior.ColorIndex = 15
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range(alfa(a) & "10:" & alfa(b) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


            .Range("Q3:" & alfa(b) & "4").Merge()
            .Range("Q3:" & alfa(b) & "4").Value = "Acompanhamento Mensal da Frequência dos Alunos"
            .Range("Q3:" & alfa(b) & "4").Font.Bold = True
            .Range("Q3:" & alfa(b) & "4").Font.Size = 20
            .Range("Q3:" & alfa(b) & "4").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("Q3:" & alfa(b) & "4").Cells.Interior.ColorIndex = 15

            'Preenche os dados
            Try
                Dim cel As Integer = 12
                Dim cd_dispensa(0) As Integer
                Dim finalpagina As Integer = 0
                Dim total As Integer = 0
                Dim total_dispensa As Integer = 0
                Dim n_aulas As Integer = 0
                Dim total_faltas As Integer = 0
                Dim frequencia As Double = 0.0
                a = 17
                b = 18
                c = 19

                For d As Integer = 0 To UBound(cd_aluno)
                    For e As Integer = 0 To UBound(cd_materia) - 1
                        'Preenche as faltas individuais de todas as materias
                        Try
                            cn1.Open()
                            sql = "SELECT  COUNT(*) AS Faltas  FROM tb_faltas_aluno " & _
                            "WHERE DATEPART(month, dt_falta)=" & mes & " AND cd_aluno =" & cd_aluno(d) & _
                            " AND cd_disciplina =" & cd_materia(e) & " AND cd_turma=" & cd_turma
                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).Merge()
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).Value = dr.GetInt32(0)
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).BorderAround()
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                            .Range(alfa(a) & cel & ":" & alfa(c) & cel).Font.Size = 12
                            total += dr.GetInt32(0)
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                        a = c + 1
                        b = a + 1
                        c = a + 2
                    Next

                    'Preenche o numero de aulas dadas
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Expr1 FROM tb_aula_dada WHERE cd_turma=" & cd_turma
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Merge()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Value = dr.GetInt32(0)
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).BorderAround()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Font.Size = 12
                        n_aulas = dr.GetInt32(0)
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try

                    a = b + 1
                    b = a + 1

                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Merge()
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Value = total
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).BorderAround()
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Font.Size = 12


                    a = b + 1
                    b = a + 1


                    'Preencha o numero total de faltas do aluno
                    Try
                        cn1.Open()
                        sql = "SELECT  COUNT(*) AS Faltas  FROM tb_faltas_aluno " & _
                        "WHERE cd_aluno =" & cd_aluno(d) & " AND cd_turma=" & cd_turma
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Merge()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Value = dr.GetInt32(0)
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).BorderAround()
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .Range(alfa(a) & cel & ":" & alfa(b) & cel).Font.Size = 12
                        total_faltas = dr.GetInt32(0)
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try

                    'Verifica se o aluno foi dispensado,se sim subtrai a 
                    'carga horaria das aulas dadas e preenche a frequencia
                    'senão preenche a frequencia

                    Try
                        cn1.Open()
                        sql = "SELECT cd_disciplina FROM tb_dispensa WHERE cd_aluno=" & cd_aluno(d)
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        Dim f As Integer = 0
                        If Not dr.HasRows = True Then
                            ReDim Preserve cd_dispensa(0)
                            cn1.Close()
                            Exit Try
                        End If
                        While dr.Read()
                            ReDim Preserve cd_dispensa(f)
                            cd_dispensa(f) = dr.GetInt32(0)
                            f += 1
                        End While
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try

                    Try
                        For f As Integer = 0 To UBound(cd_dispensa)
                            If cd_dispensa(f) <> 0 Then
                                sql = "SELECT COUNT(cd_falta) FROM tb_faltas_aluno " & _
                                "INNER JOIN tb_dispensa on tb_faltas_aluno.cd_disciplina = tb_dispensa.cd_disciplina " & _
                                "WHERE tb_faltas_aluno.cd_aluno = " & cd_aluno(d) & _
                                " AND tb_faltas_aluno.cd_disciplina = " & cd_dispensa(f) & _
                                " AND tb_dispensa.cd_aluno = " & cd_aluno(d) & _
                                " AND tb_dispensa.cd_disciplina = " & cd_dispensa(f)

                                Dim comando As New SqlCommand(sql, cn1)
                                cn1.Open()
                                Dim dr As SqlDataReader = comando.ExecuteReader
                                While dr.Read
                                    total_dispensa += dr.GetInt32(0)
                                End While
                                cn1.Close()
                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try

                    a = b + 1
                    b = a + 1

                    frequencia = Math.Round(((100 - (((total_faltas - total_dispensa) / n_aulas) * 100))), 0)

                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Merge()
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Value = frequencia
                    If frequencia < 75 Then .Range(alfa(a) & cel & ":" & alfa(b) & cel).Font.ColorIndex = 3
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).BorderAround()
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Font.Size = 12


                    a = b + 1
                    b = a + 8

                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).Merge()
                    .Range(alfa(a) & cel & ":" & alfa(b) & cel).BorderAround()

                    ReDim cd_dispensa(0)
                    total_dispensa = 0
                    frequencia = 0
                    total = 0
                    finalpagina = b
                    a = 17
                    b = 18
                    c = 19
                    cel += 1

                Next
                excelWorksheet.PageSetup.Zoom = 60
                excelWorksheet.PageSetup.TopMargin = 0
                excelWorksheet.PageSetup.BottomMargin = 0
                excelWorksheet.PageSetup.RightMargin = 0
                excelWorksheet.PageSetup.LeftMargin += 1
                excelWorksheet.PageSetup.HeaderMargin = 0
                excelWorksheet.PageSetup.FooterMargin = 0.3
                excelWorksheet.PageSetup.CenterHorizontally = True
                excelWorksheet.PageSetup.CenterVertically = True
                excelWorksheet.PageSetup.PrintArea = ("A1:" & alfa(finalpagina) & cel - 1)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            Finally
                excelApp.Visible = True
            End Try
        End With
    End Sub

    Private Sub relatorio_mensal_2(ByVal excelWorksheet As Excel.Worksheet)
        Try
            Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}

            With excelWorksheet

                'Formatação das Celulas
                .Range("A7:D7").Merge()
                .Range("A7:D7").Value = "Mês/Ano:"
                .Range("A7:D7").Font.Size = 12
                .Range("A7:D7").Font.Bold = True
                .Range("A7:D7").BorderAround()

                .Range("E7:O7").Merge()
                .Range("E7:O7").Value = mes & "/" & ano
                .Range("E7:O7").Font.Size = 14
                .Range("E7:O7").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .Range("E7:O7").BorderAround()

                .Range("A8:D8").Merge()
                .Range("A8:D8").Value = "Curso:"
                .Range("A8:D8").Font.Bold = True
                .Range("A8:D8").Font.Size = 12
                .Range("A8:D8").BorderAround()

                .Range("E8:V8").Merge()
                .Range("E8:V8").Value = nm_curso
                .Range("E8:V8").BorderAround()
                .Range("E8:V8").Font.Size = 14

                .Range("W8:AB8").Merge()
                .Range("W8:AB8").Value = "Modúlo/Série:"
                .Range("W8:AB8").BorderAround()
                .Range("W8:AB8").Font.Bold = True
                .Range("W8:AB8").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                .Range("AC8:AH8").Merge()
                .Range("AC8:AH8").Value = ds_modulo
                .Range("AC8:AH8").BorderAround()
                .Range("AC8:AH8").Font.Size = 14

                .Range("AI8:AL8").Merge()
                .Range("AI8:AL8").Value = "Período:"
                .Range("AI8:AL8").Font.Bold = True
                .Range("AI8:AL8").BorderAround()


                .Range("AM8:AQ8").Merge()
                .Range("AM8:AQ8").BorderAround()
                .Range("AM8:AQ8").Font.Size = 14
                If cd_periodo = 1 Then
                    .Range("AM8:AQ8").Value = "Manhã"
                ElseIf cd_periodo = 2 Then
                    .Range("AM8:AQ8").Value = "Tarde"
                Else
                    .Range("AM8:AQ8").Value = "Noite"
                End If
             

                .Range("A10:B11").Merge()
                .Range("A10:B11").Value = "Nº"
                .Range("A10:B11").BorderAround()
                .Range("A10:B11").Font.Bold = True
                .Range("A10:B11").Cells.Interior.ColorIndex = 15
                .Range("A10:B11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A10:B11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                .Range("C10:Q11").Merge()
                .Range("C10:Q11").Value = "Nome do Aluno"
                .Range("C10:Q11").BorderAround()
                .Range("C10:Q11").Font.Bold = True
                .Range("C10:Q11").Cells.Interior.ColorIndex = 15
                .Range("C10:Q11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("C10:Q11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Range("Q11").RowHeight = 147

            End With
        Catch ex As Exception
            relatorio_mensal_2(excelWorksheet)
        End Try

    End Sub

    Private Sub relatorio_mensal_3(ByVal excelWorksheet As Excel.Worksheet)
        Try
            Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}
            With excelWorksheet
                excelWorksheet.Shapes.AddPicture(logo, True, True, 0, 0, 240, 70)
                For d As Integer = 0 To UBound(alfa)
                    .Range(alfa(d) & 1).ColumnWidth = 2
                Next
            End With
        Catch ex As Exception
            relatorio_mensal_3(excelWorksheet)
        End Try
    End Sub

    Private Sub carrega_unidade_escolar()
        sql = "SELECT nm_unidade,im_logo FROM tb_unidade_escolar Where cd_unidade = 1"
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            nm_unidade = dr.GetString(0)
            imagem = dr.GetString(1)
        End While
        logo = caminho_logo_unidade & imagem
        dr.Close()
    End Sub

    Private Sub carregar_curso()
        sql = "SELECT tb_turma.cd_curso, tb_curso.nm_curso FROM tb_turma " & _
        "INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso " & _
        "WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            cd_curso = dr.GetInt32(0)
            nm_curso = dr.GetString(1)
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

    Private Sub carrega_turmas()
        sql = "SELECT cd_periodo, tb_juncao_modulo_curso.ds_modulo FROM tb_turma " & _
        "INNER JOIN tb_juncao_modulo_curso on tb_turma.cd_curso = tb_juncao_modulo_curso.cd_curso " & _
        "WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            cd_periodo = dr.GetInt32(0)
            ds_modulo = dr.GetString(1)
        End While
        dr.Close()
    End Sub
End Module
