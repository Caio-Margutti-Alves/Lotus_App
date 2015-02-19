Imports System.Data.SqlClient
Public Class Horario_Aulas

    Private cmb_seg() As ComboBox
    Private cmb_ter() As ComboBox
    Private cmb_qua() As ComboBox
    Private cmb_qui() As ComboBox
    Private cmb_sex() As ComboBox
    Private lbl_aula() As Label
    Private x As Integer = 0

    '---Validações--'
    Private numero_combobox As Integer
    Private contador_preenchidas As Integer

    '---Cadastro---'
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0
    Private cd_disciplina As Integer = 0
    Private contador_horario As Integer = 1

    Private contador_dia As Integer = 0
    Private dia As String = ""

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Horario_Aulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carrega_turmas_disponiveis()
        remove_cmb()
    End Sub

    Private Sub mnu_cadastrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        limpar2()
        cmb_turma.Enabled = True
        carrega_turmas_disponiveis()
    End Sub

    Private Sub mnu_alterar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        cmb_turma.Enabled = False
    End Sub

    Private Sub mnu_consulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        rad_nome.Checked = True
        carregar_dados_consulta()
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        limpar2()
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta_turma.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = (deletar_cadastro("tb_aula", "cd_turma", cd_turma))
            If excluido = True Then
                limpar2()
                remove_cmb()
            End If
            carregar_dados_consulta()
            excluido = False
        End If
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        conta_combobox()
        verifica_horario_completo()
        If contador_preenchidas <> numero_combobox Then
            MessageBox.Show("Preencha o Horário de Aulas Completamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            contador_preenchidas = 0
        Else
            If mode = "Novo" Then
                cadastra_aulas()
            Else
                atualiza_aulas()
            End If
            carregar_dados_consulta()
            grb_cadastro.Enabled = False
        End If
        numero_combobox = 0
        contador_preenchidas = 0
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        If mode = "Novo" Then
            remove_cmb()
            cd_turma = cmb_turma.SelectedValue
            If cd_turma <> 0 Then
                carrega_curso()
                carrega_quantidade_aulas()
                monta_horario()
            End If
        End If
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        carregar_dados_consulta()
    End Sub

    Private Sub lst_consulta_turma_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta_turma.MouseClick
        If lst_consulta_turma.SelectedIndex >= 0 Then
            remove_cmb()
            cd_turma = lst_consulta_turma.SelectedValue
            carrega_turmas()
            cmb_turma.SelectedValue = cd_turma
            carrega_curso()
            carrega_quantidade_aulas()

            monta_horario()

            contador_horario = 1
            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True
        End If
    End Sub

    Private Sub monta_horario()
        contador_horario = 1
        contador_dia = 0
        cria_cmb(cmb_seg, pnl_seg, "Segunda")
        cria_cmb(cmb_ter, pnl_ter, "Terça")
        cria_cmb(cmb_qua, pnl_qua, "Quarta")
        cria_cmb(cmb_qui, pnl_qui, "Quinta")
        cria_cmb(cmb_sex, pnl_sex, "Sexta")
        contador_horario = 1
        contador_dia = 0
    End Sub

    Private Sub cria_cmb(ByVal combobox() As ComboBox, ByVal grb As Panel, ByVal dia As String)
        Try
            ReDim Preserve combobox(x / 5)
            ReDim Preserve lbl_aula(x / 5)

            Dim y As Integer = 35

            For i As Integer = 1 To x / 5
                combobox(i) = New ComboBox
                combobox(i).Size = New Size(90, 10)
                combobox(i).Location = New Point(2, y)
                combobox(i).DropDownStyle = ComboBoxStyle.DropDownList
                combobox(i).Name = i
                carrega_disciplinas(combobox(i))

                lbl_aula(i) = New Label
                lbl_aula(i).Location = New Point(10, y + 3)
                lbl_aula(i).Font = New Font("Microsoft San Serif", 9, FontStyle.Bold)
                lbl_aula(i).Text = i & "ª Aula"
                lbl_aula(i).BackColor = Color.Transparent
                lbl_aula(i).Name = i

                pnl_aula.Controls.Add(lbl_aula(i))
                grb.Controls.Add(combobox(i))
                combobox(i).SelectedIndex = -1
                If mode = "Consulta" Then
                    carrega_aula(combobox(i))
                End If
                y += 40
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub carrega_turmas()
        Dim seleciona As String = "Select cd_turma,nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma"
        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao2.Close()
        With Me.cmb_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_turmas_disponiveis()
        Dim seleciona As String = "Select cd_turma,nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + " & _
        "CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma " & _
        "WHERE tb_turma.cd_turma NOT IN (SELECT cd_turma from tb_aula)"
        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao2.Close()
        With Me.cmb_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_curso()
        sql = "SELECT cd_curso FROM tb_turma WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao)
        conexao.Open()
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            cd_curso = dr.GetInt32(0)
        End While
        dr.Close()
        conexao.Close()
    End Sub

    Private Sub carrega_quantidade_aulas()
        Dim seleciona = "SELECT tb_curso.qt_aula_sem from tb_curso WHERE cd_curso = " & cd_curso
        Dim dr_qtde As SqlDataReader
        Dim cmd_qtde As New SqlCommand(seleciona, conexao)
        conexao.Close()
        conexao.Open()
        dr_qtde = cmd_qtde.ExecuteReader
        While dr_qtde.Read
            x = dr_qtde.Item("qt_aula_sem")
        End While
        dr_qtde.Close()
        conexao.Close()
    End Sub

    Private Sub carrega_disciplinas(ByVal combo As ComboBox)
        Dim seleciona = "SELECT tb_disciplina.cd_disciplina, tb_disciplina.sg_disciplina FROM tb_disciplina " & _
         "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
         "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
         "INNER JOIN tb_turma ON tb_juncao_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
         "WHERE tb_turma.cd_turma =" & cd_turma
        Dim dsDisciplina As New DataSet()
        Dim daDisciplina As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daDisciplina.Fill(dsDisciplina, "Disciplina")
        conexao2.Close()
        With combo
            .DisplayMember = "sg_disciplina"
            .ValueMember = "cd_disciplina"
            .DataSource = dsDisciplina.Tables("Disciplina").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_disciplinas_nome(ByVal nome As String)
        Dim seleciona = "SELECT tb_disciplina.cd_disciplina FROM tb_disciplina " & _
         "WHERE sg_disciplina = '" & nome & "'"
        Dim dr_nm_disciplina As SqlDataReader
        Dim cmd_nm_disciplina As New SqlCommand(seleciona, conexao)
        conexao.Close()
        conexao.Open()
        dr_nm_disciplina = cmd_nm_disciplina.ExecuteReader
        While dr_nm_disciplina.Read
            cd_disciplina = dr_nm_disciplina.Item("cd_disciplina")
        End While
        dr_nm_disciplina.Close()
        conexao.Close()
    End Sub

    Private Sub carrega_aula(ByVal combo As ComboBox)
        If contador_horario > x / 5 Then
            contador_dia += 1
            contador_horario = 1
        End If
        If contador_dia = 0 Then
            Me.dia = "Segunda"
        ElseIf contador_dia = 1 Then
            Me.dia = "Terça"
        ElseIf contador_dia = 2 Then
            Me.dia = "Quarta"
        ElseIf contador_dia = 3 Then
            Me.dia = "Quinta"
        ElseIf contador_dia = 4 Then
            Me.dia = "Sexta"
        End If

        Dim seleciona = "Select tb_aula.cd_disciplina FROM tb_aula " & _
        "WHERE tb_aula.cd_turma = " & cd_turma & " AND tb_aula.ds_dia ='" & dia & "' AND tb_aula.ds_aula =" & contador_horario
        Dim dr_Aula As SqlDataReader
        Dim cmd_Aula As SqlCommand
        cmd_Aula = New SqlCommand(seleciona, conexao)
        conexao.Close()
        conexao.Open()
        dr_Aula = cmd_Aula.ExecuteReader

        If dr_Aula.Read() Then
            combo.SelectedValue = dr_Aula.Item("cd_disciplina")
        End If
        dr_Aula.Close()
        conexao.Close()

        contador_horario += 1
    End Sub

    Private Sub carregar_dados_consulta()

        Dim seleciona As String = "Select Distinct tb_aula.cd_turma, tb_turma.nm_turma +  ' - ' + CAST (tb_turma.dt_ano as Varchar(15)) + ' - ' " & _
            "+ CAST(tb_turma.cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_aula " & _
            "INNER JOIN tb_turma ON tb_aula.cd_turma = tb_turma.cd_turma " & _
            "WHERE tb_turma.nm_turma Like @pesquisa"
        If rad_nome.Checked = True Then
            seleciona = "Select Distinct tb_aula.cd_turma, tb_turma.nm_turma +  ' - ' + CAST (tb_turma.dt_ano as Varchar(15)) + ' - ' " & _
            "+ CAST(tb_turma.cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_aula " & _
            "INNER JOIN tb_turma ON tb_aula.cd_turma = tb_turma.cd_turma " & _
            "WHERE tb_turma.nm_turma Like @pesquisa"
        ElseIf rad_curso.Checked = True Then
            seleciona = "Select Distinct tb_turma.cd_turma, tb_turma.nm_turma +  ' - ' + CAST (tb_turma.dt_ano as Varchar(15)) + ' - ' " & _
            "+ CAST(tb_turma.cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_aula " & _
            "INNER JOIN tb_turma ON tb_aula.cd_turma = tb_turma.cd_turma " & _
            "INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso " & _
            "WHERE tb_curso.nm_curso Like @pesquisa "
        ElseIf rad_ano.Checked = True Then
            seleciona = "Select Distinct tb_turma.cd_turma, tb_turma.nm_turma +  ' - ' + CAST (tb_turma.dt_ano as Varchar(15)) + ' - ' " & _
            "+ CAST(tb_turma.cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_aula " & _
            "INNER JOIN tb_turma ON tb_aula.cd_turma = tb_turma.cd_turma " & _
            "WHERE tb_turma.dt_ano Like @pesquisa"
        ElseIf rad_modulo.Checked = True Then
            seleciona = "Select Distinct tb_turma.cd_turma, tb_turma.nm_turma +  ' - ' + CAST (tb_turma.dt_ano as Varchar(15)) + ' - ' " & _
            "+ CAST(tb_turma.cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_aula " & _
            "INNER JOIN tb_turma ON tb_aula.cd_turma = tb_turma.cd_turma " & _
            "INNER JOIN tb_juncao_modulo_curso on tb_turma.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
            "WHERE tb_juncao_modulo_curso.ds_modulo Like @pesquisa"
        End If

        Dim comando As New SqlCommand(seleciona, conexao2)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(comando)

        conexao2.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao2.Close()
        With Me.lst_consulta_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
        End With
    End Sub

    Private Sub cadastra_aulas()
        Try
            cadastra_aulas_painel(pnl_seg, "Segunda")
            cadastra_aulas_painel(pnl_ter, "Terça")
            cadastra_aulas_painel(pnl_qua, "Quarta")
            cadastra_aulas_painel(pnl_qui, "Quinta")
            cadastra_aulas_painel(pnl_sex, "Sexta")
            MessageBox.Show("Cadastro realizado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            conexao.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cadastra_aulas_painel(ByRef painel As Panel, ByVal dia As String)
        Try
            contador_horario = 1
            sql = "INSERT INTO tb_aula (cd_turma,cd_disciplina,ds_dia,ds_aula) " & _
                "VALUES (@cd_turma,@cd_disciplina,@ds_dia,@ds_aula)"

            For Each c As Control In painel.Controls
                If TypeOf (c) Is ComboBox Then

                    carrega_disciplinas_nome(c.Text)

                    Dim comando As New SqlCommand(sql, conexao)
                    comando.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
                    comando.Parameters.Add(New SqlParameter("@cd_disciplina", cd_disciplina))
                    comando.Parameters.Add(New SqlParameter("@ds_dia", dia))
                    comando.Parameters.Add(New SqlParameter("@ds_aula", contador_horario))
                    conexao.Close()
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    conexao.Close()

                    contador_horario += 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub atualiza_aulas()
        Try
            atualiza_aulas_painel(pnl_seg, "Segunda")
            atualiza_aulas_painel(pnl_ter, "Terça")
            atualiza_aulas_painel(pnl_qua, "Quarta")
            atualiza_aulas_painel(pnl_qui, "Quinta")
            atualiza_aulas_painel(pnl_sex, "Sexta")
            MessageBox.Show("Alteração realizada com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            conexao.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub atualiza_aulas_painel(ByRef painel As Panel, ByVal dia As String)
        Try
            contador_horario = 1

            For Each c As Control In painel.Controls
                If TypeOf (c) Is ComboBox Then

                    sql = "UPDATE tb_aula SET cd_disciplina = @cd_disciplina " & _
                    "WHERE cd_turma = " & cd_turma & " AND ds_dia ='" & dia & "' AND ds_aula ='" & contador_horario & "'"

                    Dim comando As New SqlCommand(sql, conexao)

                    carrega_disciplinas_nome(c.Text)

                    comando.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
                    comando.Parameters.Add(New SqlParameter("@cd_disciplina", cd_disciplina))
                    conexao.Close()
                    conexao.Open()
                    comando.ExecuteNonQuery()
                    conexao.Close()

                    contador_horario += 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub conta_combobox()
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is GroupBox Then
                For Each ct As Control In ctl.Controls
                    If TypeOf (ct) Is Panel And ct.Name <> "pnl_aula" Then
                        For Each c As Control In ct.Controls
                            If TypeOf (c) Is ComboBox Then
                                numero_combobox += 1
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub verifica_horario_completo()
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is GroupBox Then
                For Each ct As Control In ctl.Controls
                    If TypeOf (ct) Is Panel And ct.Name <> "pnl_aula" Then
                        For Each c As Control In ct.Controls
                            If TypeOf (c) Is ComboBox And c.Text <> "" Then
                                contador_preenchidas += 1
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub remove_cmb()
        For Each ctl As Control In Me.Controls
            If TypeOf (ctl) Is GroupBox Then
                For Each ct As Control In ctl.Controls
                    If TypeOf (ct) Is Panel Then
                        ct.Controls.Clear()
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub limpar2()
        Limpar(Me)
        cmb_turma.SelectedIndex = -1
    End Sub
End Class