Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Module relatorio_controle_aulas

    '-----------Dados-------
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0
    Private nm_turma As String = ""
    Private nm_curso As String = ""
    Private cd_semestre As String = ""
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
    Private data_completa As Date

    Public Sub gerar_relatorio_controle_aulas()
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
            carrega_turmas()
            carrega_unidade_escolar()
            carregar_curso()
            carregar_ano()
            conexao.Close()

            Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            excelApp.Visible = False
            excelWorksheet.DisplayPageBreaks = True
            excelWorksheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait

            Dim t1 As New Threading.Thread(AddressOf relatorio_aulas)
            t1.Priority = Threading.ThreadPriority.Highest
            t1.IsBackground = True
            t1.Start(excelWorksheet)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub relatorio_aulas(ByVal excelWorksheet_aulas As Excel.Worksheet)
        Try
            Dim t2 As New Threading.Thread(AddressOf relatorio_aulas_1)
            t2.Priority = Threading.ThreadPriority.Highest
            t2.IsBackground = True
            t2.Start(excelWorksheet_aulas)

            Dim t3 As New Threading.Thread(AddressOf relatorio_aulas_2)
            t3.Priority = Threading.ThreadPriority.Highest
            t3.IsBackground = True
            t3.Start(excelWorksheet_aulas)

            Dim t4 As New Threading.Thread(AddressOf relatorio_aulas_3)
            t4.Priority = Threading.ThreadPriority.Highest
            t4.IsBackground = True
            t4.Start(excelWorksheet_aulas)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub relatorio_aulas_1(ByVal excelWorksheet_aulas As Excel.Worksheet)
        Dim cn1 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
        Dim cn2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
        Dim cd_materia(), nmaterias As Integer
        Dim celulas As Integer = 14
        Dim priaula As String = ""
        Dim inicio As Date = Now
        Dim fim As String = Now
        Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}
        With excelWorksheet_aulas
            'Datas do Semestre
            Try
                cn1.Open()
                sql = "SELECT dt_inisemestre,dt_fimsemestre FROM tb_turma WHERE cd_turma=" & cd_turma
                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    priaula = FormatDateTime(dr.GetDateTime(0), DateFormat.ShortDate)
                    inicio = dr.GetDateTime(0)
                    fim = FormatDateTime(dr.GetDateTime(1), DateFormat.ShortDate)
                End While
                cn1.Close()

                Dim cel As Integer = 14
                While fim >= inicio
                    If inicio.DayOfWeek = DayOfWeek.Saturday Then
                        inicio = inicio.AddDays(1)
                        Continue While
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Sunday Then
                        inicio = inicio.AddDays(1)
                        Continue While
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Friday Then
                        .Range("A" & cel).Value = inicio.Day & "/" & inicio.Month & " a "
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Monday Then
                        .Range("A" & cel).Value = inicio.Day & "/" & inicio.Month & " a "
                        inicio = inicio.AddDays(4)
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Tuesday Then
                        .Range("A" & cel).Value = inicio.Day & "/" & inicio.Month & " a "
                        inicio = inicio.AddDays(3)
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Wednesday Then
                        .Range("A" & cel).Value = inicio.Day & "/" & inicio.Month & " a "
                        inicio = inicio.AddDays(2)
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Thursday Then
                        .Range("A" & cel).Value = inicio.Day & "/" & inicio.Month & " a "
                        inicio = inicio.AddDays(1)
                    End If

                    If inicio.DayOfWeek = DayOfWeek.Friday Then
                        .Range("A" & cel).Value = .Range("A" & cel).Value & inicio.Day & "/" & inicio.Month
                        .Range("A" & cel).Font.Name = "Franklin Gothic Medium"
                        .Range("A" & cel).Font.Size = 8.5
                        .Range("A" & cel).Font.ColorIndex = 32
                        .Range("A" & cel).BorderAround()
                        .Range("A" & cel).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        celulas += 1
                        cel += 1
                    End If
                    inicio = inicio.AddDays(3)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            End Try
            'Fim das Datas do Semestre

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

            'Preenche os campos com os nomes das Aulas
            Try
                cn1.Open()
                sql = "SELECT tb_disciplina.cd_disciplina, tb_disciplina.sg_disciplina FROM tb_disciplina " & _
                "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
                "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
                "INNER JOIN tb_turma ON tb_juncao_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
                "WHERE tb_turma.cd_turma=" & cd_turma & " ORDER BY tb_disciplina.sg_disciplina"

                Dim comando As New SqlCommand(sql, cn1)
                Dim dr As SqlDataReader = comando.ExecuteReader
                Dim cont As Integer = 0
                Dim a As Integer = 1
                Dim b As Integer = 2
                Dim c As Integer = 3
                While dr.Read
                    cd_materia(cont) = dr.GetInt32(0)
                    .Range(alfa(a) & "11:" & alfa(c) & "12").Merge()
                    .Range(alfa(a) & "11").Value = dr.GetString(1)
                    .Range(alfa(a) & "11:" & alfa(c) & "12").BorderAround()
                    .Range(alfa(a) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(a) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    .Range(alfa(a) & "13").Value = "AP"
                    .Range(alfa(a) & "13").Font.Size = 6
                    .Range(alfa(a) & "13").BorderAround()
                    .Range(alfa(b) & "13").Value = "Def"
                    .Range(alfa(b) & "13").Font.ColorIndex = 3
                    .Range(alfa(b) & "13").Font.Size = 6
                    .Range(alfa(b) & "13").BorderAround()
                    .Range(alfa(c) & "13").Value = "Rep"
                    .Range(alfa(c) & "13").Font.ColorIndex = 32
                    .Range(alfa(c) & "13").Font.Size = 6
                    .Range(alfa(c) & "13").BorderAround()
                    a = c + 1
                    b = a + 1
                    c = a + 2
                    cont += 1
                    If cont > nmaterias Then Exit While
                End While
                .Range(alfa(a) & "13").Value = "AP"
                .Range(alfa(a) & "13").Font.Size = 6
                .Range(alfa(a) & "13").BorderAround()
                .Range(alfa(b) & "13").Value = "AD"
                .Range(alfa(b) & "13").Font.ColorIndex = 10
                .Range(alfa(b) & "13").Font.Size = 6
                .Range(alfa(b) & "13").BorderAround()
                .Range(alfa(c) & "13").Value = "Def"
                .Range(alfa(c) & "13").Font.ColorIndex = 3
                .Range(alfa(c) & "13").Font.Size = 6
                .Range(alfa(c) & "13").BorderAround()
                c += 1
                .Range(alfa(c) & "13").Value = "Rep"
                .Range(alfa(c) & "13").Font.ColorIndex = 32
                .Range(alfa(c) & "13").Font.Size = 6
                .Range(alfa(c) & "13").BorderAround()

                .Range(alfa(a) & "11:" & alfa(c) & "12").Merge()
                .Range(alfa(a) & "11:" & alfa(c) & "12").Value = "Total"
                .Range(alfa(a) & "11:" & alfa(c) & "12").Font.Bold = True
                .Range(alfa(a) & "11:" & alfa(c) & "12").BorderAround()
                .Range(alfa(a) & "11").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range(alfa(a) & "11").Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                cn1.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                cn1.Close()
                Exit Sub
            End Try

            'Preenche os Dados
            Try
                Dim cel As Integer = 14
                Dim cont As Integer = 0
                Dim a As Integer = 1
                Dim b As Integer = 2
                Dim c As Integer = 3
                Dim datas() As String = Split(.Range("A" & cel).Value, " a ")
                Dim data1 As Date = datas(0) & "/" & ano
                Dim data2 As Date = datas(1) & "/" & ano

                While cel < celulas
                    datas = Split(.Range("A" & cel).Value, " a ")
                    data1 = FormatDateTime(datas(0) & "/" & ano, DateFormat.ShortDate)
                    data2 = FormatDateTime(datas(1) & "/" & ano, DateFormat.ShortDate)

                    a = 1
                    b = 2
                    c = 3

                    'Aulas Previstas da Semana
                    For cont = 0 To nmaterias - 1
                        Try
                            cn1.Open()
                            sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                            "WHERE ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_dada=" & cd_materia(cont) & ")) " & _
                            "OR ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_reposta=" & cd_materia(cont) & "))"
                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(a) & cel).Value = dr.GetInt32(0)
                            .Range(alfa(a) & cel).BorderAround()
                            .Range(alfa(a) & cel).Font.Size = 8
                            a = c + 1
                            b = a + 1
                            c = a + 2
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                    Next

                    a = 1
                    b = 2
                    c = 3

                    'Aulas Não Dadas da Semana
                    For cont = 0 To nmaterias - 1
                        Try
                            cn1.Open()
                            sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                            "WHERE (cd_turma=" & cd_turma & ") " & _
                            "AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_dada=" & cd_materia(cont) & ") AND ds_aula='Reposta'"
                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(b) & cel).Value = dr.GetInt32(0)
                            .Range(alfa(b) & cel).BorderAround()
                            .Range(alfa(b) & cel).Font.ColorIndex = 3
                            .Range(alfa(b) & cel).Font.Size = 8
                            a = c + 1
                            b = a + 1
                            c = a + 2
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                    Next

                    a = 1
                    b = 2
                    c = 3

                    'Aulas Repostas da Semana
                    For cont = 0 To nmaterias - 1
                        Try
                            cn1.Open()
                            sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                            "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_reposta=" & cd_materia(cont) & ") AND ds_aula='Reposta'"
                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(c) & cel).Value = dr.GetInt32(0)
                            .Range(alfa(c) & cel).BorderAround()
                            .Range(alfa(c) & cel).Font.ColorIndex = 32
                            .Range(alfa(c) & cel).Font.Size = 8
                            a = c + 1
                            b = a + 1
                            c = a + 2
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                    Next

                    'Total de aulas previstas da Semana
                    For cont = 0 To nmaterias - 1
                        Try
                            cn1.Open()
                            sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                            "WHERE ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_dada=" & cd_materia(cont) & ")) " & _
                            "OR ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND (cd_disciplina_reposta=" & cd_materia(cont) & "))"

                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(a) & cel).Value = .Range(alfa(a) & cel).Value + dr.GetInt32(0)
                            .Range(alfa(a) & cel).BorderAround()
                            .Range(alfa(a) & cel).Font.Size = 8
                            .Range(alfa(a) & cel).Font.Bold = True
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                    Next

                    'Total de aulas Dadas da Semana
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                        "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                        "AND ds_aula='Dada'"
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(b) & cel).Value = dr.GetInt32(0)
                        .Range(alfa(b) & cel).BorderAround()
                        .Range(alfa(b) & cel).Font.ColorIndex = 10
                        .Range(alfa(b) & cel).Font.Size = 8
                        .Range(alfa(b) & cel).Font.Bold = True
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try

                    'Total de aulas não dadas da Semana
                    For cont = 0 To nmaterias - 1
                        Try
                            cn1.Open()
                            sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                            "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                            "AND cd_disciplina_dada=" & cd_materia(cont) & " AND ds_aula='Reposta'"
                            Dim comando As New SqlCommand(sql, cn1)
                            Dim dr As SqlDataReader = comando.ExecuteReader
                            dr.Read()
                            .Range(alfa(c) & cel).Value = .Range(alfa(c) & cel).Value + dr.GetInt32(0)
                            .Range(alfa(c) & cel).BorderAround()
                            .Range(alfa(c) & cel).Font.ColorIndex = 3
                            .Range(alfa(c) & cel).Font.Size = 8
                            .Range(alfa(c) & cel).Font.Bold = True
                            cn1.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            cn1.Close()
                            Exit Sub
                        End Try
                    Next

                    'Total de Aulas Repostas da Semana
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                        "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & data1 & "' AND '" & data2 & "') " & _
                        "AND ds_aula='Reposta'"
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(c + 1) & cel).Value = dr.GetInt32(0)
                        .Range(alfa(c + 1) & cel).BorderAround()
                        .Range(alfa(c + 1) & cel).Font.ColorIndex = 32
                        .Range(alfa(c + 1) & cel).Font.Size = 8
                        .Range(alfa(c + 1) & cel).Font.Bold = True
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try
                    cel += 1
                End While

                'Total do Semestre da Materia
                Dim total_previstas, total_def, total_rep, repor(UBound(cd_materia) - 1) As Integer
                .Range("A" & cel & ":" & alfa(c + 1) & cel).BorderAround()
                cel += 1
                .Range("A" & cel).Value = "Total"
                .Range("A" & cel).BorderAround()
                a = 1
                b = 2
                c = 3

                'Total de Aulas Previstas do Semestre da Materia
                For cont = 0 To nmaterias - 1
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                        " WHERE ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & priaula & "' AND '" & fim & "') " & _
                        " AND (cd_disciplina_dada=" & cd_materia(cont) & ")) " & _
                        "OR ((cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & priaula & "' AND '" & fim & "') " & _
                        "AND (cd_disciplina_reposta=" & cd_materia(cont) & "))"
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(a) & cel).Value = dr.GetInt32(0)
                        total_previstas += dr.GetInt32(0)
                        .Range(alfa(a) & cel).BorderAround()
                        .Range(alfa(a) & cel).Font.Size = 8
                        a = c + 1
                        b = a + 1
                        c = a + 2
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try
                Next

                a = 1
                b = 2
                c = 3

                'Total de Aulas Não dadas do Semestre da Materia
                For cont = 0 To nmaterias - 1
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                        "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & priaula & "' AND '" & fim & "') " & _
                        " AND (cd_disciplina_dada=" & cd_materia(cont) & ") AND ds_aula='Reposta'"
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(b) & cel).Value = dr.GetInt32(0)
                        repor(cont) = dr.GetInt32(0)
                        total_def += dr.GetInt32(0)
                        .Range(alfa(b) & cel).BorderAround()
                        .Range(alfa(b) & cel).Font.ColorIndex = 3
                        .Range(alfa(b) & cel).Font.Size = 8
                        a = c + 1
                        b = a + 1
                        c = a + 2
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try
                Next

                a = 1
                b = 2
                c = 3

                'Total de Aulas Repostas do Semestre da Materia
                For cont = 0 To nmaterias - 1
                    Try
                        cn1.Open()
                        sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                        "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & priaula & "' AND '" & fim & "') " & _
                        "AND (cd_disciplina_reposta=" & cd_materia(cont) & ") AND ds_aula='Reposta'"
                        Dim comando As New SqlCommand(sql, cn1)
                        Dim dr As SqlDataReader = comando.ExecuteReader
                        dr.Read()
                        .Range(alfa(c) & cel).Value = dr.GetInt32(0)
                        repor(cont) = repor(cont) - dr.GetInt32(0)
                        total_rep += dr.GetInt32(0)
                        .Range(alfa(c) & cel).BorderAround()
                        .Range(alfa(c) & cel).Font.ColorIndex = 32
                        .Range(alfa(c) & cel).Font.Size = 8
                        a = c + 1
                        b = a + 1
                        c = a + 2
                        cn1.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        cn1.Close()
                        Exit Sub
                    End Try
                Next

                'Total de Aulas Previstas do Semestre
                Try
                    .Range(alfa(a) & cel).Value = total_previstas
                    .Range(alfa(a) & cel).BorderAround()
                    .Range(alfa(a) & cel).Font.Size = 8
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try

                'Total de Aulas Dadas do Semestre
                Try
                    cn1.Open()
                    sql = "SELECT COUNT(*) AS Aulas FROM tb_aula_dada " & _
                    "WHERE (cd_turma=" & cd_turma & ") AND (dt_aula BETWEEN '" & priaula & "' AND '" & fim & "') " & _
                    "AND  ds_aula='Dada'"
                    Dim comando As New SqlCommand(sql, cn1)
                    Dim dr As SqlDataReader = comando.ExecuteReader
                    dr.Read()
                    .Range(alfa(b) & cel).Value = dr.GetInt32(0)
                    .Range(alfa(b) & cel).BorderAround()
                    .Range(alfa(b) & cel).Font.ColorIndex = 10
                    .Range(alfa(b) & cel).Font.Size = 8
                    cn1.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    cn1.Close()
                    Exit Sub
                End Try

                'Total de Aulas Não Dadas do Semestre
                Try
                    .Range(alfa(c) & cel).Value = total_def
                    .Range(alfa(c) & cel).BorderAround()
                    .Range(alfa(c) & cel).Font.ColorIndex = 3
                    .Range(alfa(c) & cel).Font.Size = 8
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try

                'Total de Aulas Repostas do Semestre
                Try
                    .Range(alfa(c + 1) & cel).Value = total_rep
                    .Range(alfa(c + 1) & cel).BorderAround()
                    .Range(alfa(c + 1) & cel).Font.ColorIndex = 32
                    .Range(alfa(c + 1) & cel).Font.Size = 8
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try

                'Repor
                cel += 1
                .Range("A" & cel).Value = "Repor"
                .Range("A" & cel).BorderAround()
                .Range("A" & cel).Font.Bold = True
                .Range("A" & cel).Font.ColorIndex = 3
                a = 1
                b = 2
                c = 3

                Dim total_repor As Integer = 0
                For cont = 0 To nmaterias - 1
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).Merge()
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).BorderAround()
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).Font.Bold = True
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).Font.ColorIndex = 3
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range(alfa(a) & cel & ":" & alfa(c) & cel).Value = repor(cont)
                    total_repor += repor(cont)
                    a = c + 1
                    b = a + 1
                    c = a + 2
                Next

                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).Merge()
                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).BorderAround()
                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).Font.Bold = True
                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).Font.ColorIndex = 3
                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range(alfa(a) & cel & ":" & alfa(c + 1) & cel).Value = total_repor


            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            Finally
                excelApp.Visible = True
            End Try
        End With
    End Sub

    Private Sub relatorio_aulas_2(ByVal excelWorksheet_aulas As Excel.Worksheet)
        Try
            Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}

            With excelWorksheet_aulas


                .Range("R3").Value = "ANO"
                .Range("R5").Value = "MÓDULO/SÉRIE"
                .Range("R7").Value = "PÉRIODO"
                .Range("W3").Value = "SEMESTRE"
                .Range("W5").Value = "CURSO"
                .Range("W7").Value = "TURMA"
                .Range("A8:K8").Merge()
                .Range("A8:K8").BorderAround()
                .Range("A8:K8").Value = nm_unidade
                .Range("A8:K8").Font.Bold = True
                .Range("A8:K8").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A9:Z9").Merge()
                .Range("A9:Z9").Font.Bold = True
                .Range("A9:Z9").Font.Name = "Franklin Gothic Medium"
                .Range("A9:Z9").Value = "CONTROLE DE AULAS PREVISTAS E DADAS"
                .Range("A9:Z9").BorderAround()
                .Range("A9:Z9").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("B10:Z10").Merge()
                .Range("B10:Z10").Font.Bold = True
                .Range("B10:Z10").Value = "COMPONENTES CURRICULARES"
                .Range("B10:Z10").BorderAround()
                .Range("B10:Z10").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A10:A13").Merge()
                .Range("A10:A13").BorderAround()
                .Range("A10").Font.Bold = True
                .Range("A10").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                .Range("A10").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A10").Value = "DATA"
                'Fim do cabeçalho

                'Dados do cabeçalho
                .Range("R4").Value = ano
                .Range("R6").Value = ds_modulo

                If cd_periodo = 1 Then
                    .Range("R8").Value = "Manhã"
                ElseIf cd_periodo = 2 Then
                    .Range("R8").Value = "Tarde"
                Else
                    .Range("R8").Value = "Noite"
                End If

                If cd_semestre = "1" Then
                    .Range("W4").Value = "Primeiro"
                Else
                    .Range("W4").Value = "Segundo"
                End If

                .Range("W6").Value = nm_curso

                .Range("W8").Value = nm_turma

                'Fim dados do cabeçalho
            End With
        Catch ex As Exception
            relatorio_aulas_2(excelWorksheet_aulas)
        End Try
    End Sub

    Private Sub relatorio_aulas_3(ByVal excelWorksheet_aulas As Excel.Worksheet)
        Try
            Dim alfa() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "CZ"}

            With excelWorksheet_aulas
                .Shapes.AddPicture(logo, True, True, 0, 0, 300, 90)

                'Formatação do cabeçalho
                .Range("A1").ColumnWidth = 10.29
                For a As Integer = 1 To UBound(alfa)
                    .Range(alfa(a) & "1").ColumnWidth = 2.43
                Next

                For a As Integer = 3 To 8
                    .Range("R" & a & ":U" & a).Merge()
                    If a Mod 2 = 0 Then .Range("R" & a & ":U" & a).BorderAround()
                    .Range("R" & a & ":U" & a).Font.Size = 7
                    .Range("R" & a & ":U" & a).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range("R" & a & ":U" & a).Font.Bold = True
                Next
                For a As Integer = 3 To 8
                    .Range("W" & a & ":Z" & a).Merge()
                    If a Mod 2 = 0 Then .Range("W" & a & ":Z" & a).BorderAround()
                    .Range("W" & a & ":Z" & a).Font.Size = 7
                    .Range("W" & a & ":Z" & a).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    .Range("W" & a & ":Z" & a).Font.Bold = True
                Next
            End With
        Catch ex As Exception
            relatorio_aulas_3(excelWorksheet_aulas)
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
        sql = "SELECT tb_turma.cd_periodo, tb_turma.cd_semestre, tb_turma.nm_turma, tb_juncao_modulo_curso.ds_modulo FROM tb_turma " & _
        "INNER JOIN tb_juncao_modulo_curso on tb_turma.cd_curso = tb_juncao_modulo_curso.cd_curso " & _
        "WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            cd_periodo = dr.GetInt32(0)
            cd_semestre = dr.GetInt32(1)
            nm_turma = dr.GetString(2)
            ds_modulo = dr.GetString(3)
        End While
        dr.Close()
    End Sub
End Module
