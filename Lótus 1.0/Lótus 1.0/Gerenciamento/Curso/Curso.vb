Imports System.Data.SqlClient
Public Class Curso

    '--Cadastro--'
    Private cd_curso As Integer = 0
    Private tipo_curso As String = ""
    Private sufixo As String = ""

    Private cd_manha As Integer = 0
    Private pesquisa_manha As Integer = 0

    Private cd_tarde As Integer = 0
    Private pesquisa_tarde As Integer = 0

    Private cd_noite As Integer = 0
    Private pesquisa_noite As Integer = 0

    Private numero_modulos As Integer = 0
    Private numero_aulas As Integer = 0
    '--Modulo--' 

    Private num_mod As Integer = 0

    '--Menus--'
    Private mode As String = ""

    '--Alterações--'

    Private excluido As Boolean = False

    Private Sub Curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub

    Private Sub mnu_novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        Limpar2()
    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)

    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        rdbnomecurso.Checked = True
        carregar_cadastros_consulta()
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        numero_aulas = Integer.Parse(txt_qtde_aulas_sem.Text)
        If numero_aulas Mod 5 <> 0 Then
            MessageBox.Show("O Número de Aulas Semanais deve ser Múltiplo de 5!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txt_curso.Text = Nothing Or txt_sigla_curso.Text = Nothing Or txt_qtde_aulas_sem.Text = Nothing Or txt_qtde_modulo.Text = Nothing Or (rdb_anual.Checked = False And rdb_semestral.Checked = False) Then
                MessageBox.Show("Preencha todos os campos coretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim sql As String = ""

                If mode = "Novo" Then
                    sql = "INSERT INTO tb_curso (nm_curso, sg_curso, qt_modulo, ds_tipo_curso, qt_aula_sem, cd_manha, cd_tarde, cd_noite) VALUES (@nm_curso, @sg_curso, @qt_modulo, @ds_tipo_curso, @qt_aula_sem, @cd_manha,@cd_tarde, @cd_noite)"
                    num_mod = txt_qtde_modulo.Text
                    cadastra_modulo()
                Else
                    sql = "UPDATE tb_curso SET nm_curso = @nm_curso,sg_curso =@sg_curso, qt_modulo =@qt_modulo,ds_tipo_curso =@ds_tipo_curso,qt_aula_sem =@qt_aula_sem,cd_manha = @cd_manha, cd_tarde = @cd_tarde, cd_noite = @cd_noite WHERE cd_curso =" & cd_curso
                    altera_modulo()
                End If

                Dim comando As New SqlCommand(sql, conexao)

                comando.Parameters.Add(New SqlParameter("@nm_curso", txt_curso.Text))
                comando.Parameters.Add(New SqlParameter("@sg_curso", txt_sigla_curso.Text))
                comando.Parameters.Add(New SqlParameter("@qt_modulo", txt_qtde_modulo.Text))
                comando.Parameters.Add(New SqlParameter("@ds_tipo_curso", tipo_curso))
                comando.Parameters.Add(New SqlParameter("@qt_aula_sem", txt_qtde_aulas_sem.Text))
                comando.Parameters.Add(New SqlParameter("@cd_manha", chk_manha.CheckState))
                comando.Parameters.Add(New SqlParameter("@cd_tarde", chk_tarde.CheckState))
                comando.Parameters.Add(New SqlParameter("@cd_noite", chk_noite.CheckState))

                conexao.Open()
                cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
                conexao.Close()

                conexao.Close()

                limpar_variaveis()

                carregar_cadastros_consulta()
            End If
        End If
    End Sub

    Private Sub txt_curso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_curso.TextChanged
        negar_num(txt_curso)
    End Sub

    Private Sub txt_sigla_curso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sigla_curso.TextChanged
        negar_num(txt_sigla_curso)
    End Sub

    Private Sub txt_modulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qtde_modulo.TextChanged
        negar_car(txt_qtde_modulo)
    End Sub

    Private Sub txt_qtde_aulas_sem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qtde_aulas_sem.TextChanged
        negar_car(txt_qtde_aulas_sem)
    End Sub

    Private Sub rdb_anual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_anual.CheckedChanged
        tipo_curso = "Anual"
        sufixo = "º Ano"
    End Sub

    Private Sub rdb_semestral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_semestral.CheckedChanged
        tipo_curso = "Semestral"
        sufixo = "º Módulo"
    End Sub

    Private Sub txtpesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        If rdbnomecurso.Checked = False And rdbperiodo.Checked = False Then
            MessageBox.Show("Selecione o tipo de Consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rdbnomecurso.Focus()
        Else
            carrega_dados()
        End If
    End Sub

    Private Sub lstpesquisa_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta_curso.MouseClick
        If lst_consulta_curso.SelectedIndex >= 0 Then

            Limpar2()

            carrega_dados_consulta()

            mnu_alterar.Enabled = True
        End If
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta_curso.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = deletar_cadastro("tb_curso", "cd_curso", cd_curso)
            If excluido = True Then
                Limpar2()
            End If
            carregar_cadastros_consulta()
            excluido = False
        End If
    End Sub

    Private Sub chk_manha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_manha.CheckedChanged
        If chk_manha.Checked = True Then
            cd_manha = "1"
        Else
            cd_manha = 0
        End If
    End Sub


    Private Sub chk_tarde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tarde.CheckedChanged
        If chk_tarde.Checked = True Then
            cd_tarde = "1"
        Else
            cd_tarde = 0
        End If
    End Sub

    Private Sub chk_noite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_noite.CheckedChanged
        If chk_noite.Checked = True Then
            cd_noite = "1"
        Else
            cd_noite = 0
        End If
    End Sub

    Private Sub indica_periodos(ByVal chk As CheckBox, ByVal var As Integer)
        If chk.Checked = True Then
            var = 1
        Else
            var = 0
        End If
    End Sub

    Private Sub rdbnomecurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbnomecurso.CheckedChanged
        altera_pesquisa()
    End Sub

    Private Sub rdbperiodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbperiodo.CheckedChanged
        altera_pesquisa()
    End Sub

    Private Sub altera_pesquisa()

        If rdbnomecurso.Checked = True Then
            txt_pesquisa.Visible = True
            chk_pesq_manha.Visible = False
            chk_pesq_tarde.Visible = False
            chk_pesq_noite.Visible = False

        ElseIf rdbperiodo.Checked = True Then
            txt_pesquisa.Visible = False
            chk_pesq_manha.Visible = True
            chk_pesq_tarde.Visible = True
            chk_pesq_noite.Visible = True

        End If

    End Sub

    Private Sub carregar_cadastros_consulta()
        Dim seleciona As String = "Select cd_curso, nm_curso FROM tb_curso WHERE nm_curso Like '%" & txt_pesquisa.Text & "%'"
        Dim dsCurso As New DataSet()
        Dim daCurso As New SqlDataAdapter(seleciona, conexao)
        conexao.Open()
        daCurso.Fill(dsCurso, "Curso")
        conexao.Close()
        With Me.lst_consulta_curso
            .DisplayMember = "nm_curso"
            .ValueMember = "cd_curso"
            .DataSource = dsCurso.Tables("Curso").DefaultView
        End With
    End Sub
    Private Sub carrega_dados()
        Dim seleciona As String = "Select cd_curso, nm_curso FROM tb_curso WHERE nm_curso Like @pesquisa"
        If rdbnomecurso.Checked = True Then
            seleciona = "Select cd_curso, nm_curso FROM tb_curso WHERE nm_curso Like @pesquisa"
        ElseIf rdbperiodo.Checked = True Then
            seleciona = "Select cd_curso, nm_curso FROM tb_curso WHERE cd_manha = @pesquisa1 AND cd_tarde = @pesquisa2 AND cd_noite = @pesquisa3"
        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        If rdbnomecurso.Checked = True Then
            comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))
        ElseIf rdbperiodo.Checked = True Then
            comando.Parameters.Add(New SqlParameter("@pesquisa1", chk_pesq_manha.CheckState))
            comando.Parameters.Add(New SqlParameter("@pesquisa2", chk_pesq_tarde.CheckState))
            comando.Parameters.Add(New SqlParameter("@pesquisa3", chk_pesq_noite.CheckState))
        End If

        Dim dsCurso As New DataSet()
        Dim daCurso As New SqlDataAdapter(comando)

        conexao.Open()
        daCurso.Fill(dsCurso, "Curso")
        conexao.Close()
        With Me.lst_consulta_curso
            .DisplayMember = "nm_curso"
            .ValueMember = "cd_curso"
            .DataSource = dsCurso.Tables("Curso").DefaultView
        End With
    End Sub

    Private Sub carrega_dados_consulta()

        Dim seleciona As String = "Select cd_curso,nm_curso, sg_curso, qt_modulo, ds_tipo_curso, qt_aula_sem, cd_manha,cd_tarde,cd_noite FROM tb_curso Where cd_curso = " & lst_consulta_curso.SelectedValue & ""
        Dim drCurso As SqlDataReader
        Dim cmdCurso As SqlCommand
        cmdCurso = New SqlCommand(seleciona, conexao)
        conexao.Open()
        drCurso = cmdCurso.ExecuteReader

        If drCurso.Read() Then

            cd_curso = drCurso.Item("cd_curso")
            txt_curso.Text = drCurso.Item("nm_curso").ToString
            txt_sigla_curso.Text = drCurso.Item("sg_curso").ToString
            txt_qtde_modulo.Text = drCurso.Item("qt_modulo").ToString
            tipo_curso = drCurso.Item("ds_tipo_curso").ToString

            If tipo_curso = "Anual" Then
                rdb_anual.Checked = True
                sufixo = "º Ano"
            ElseIf tipo_curso = "Semestral" Then
                rdb_semestral.Checked = True
                sufixo = "º Módulo"
            End If

            txt_qtde_aulas_sem.Text = drCurso.Item("qt_aula_sem").ToString

            chk_manha.Checked = drCurso.Item("cd_manha").ToString
            chk_tarde.Checked = drCurso.Item("cd_tarde").ToString
            chk_noite.Checked = drCurso.Item("cd_noite").ToString

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True

        End If

        drCurso.Close()
        conexao.Close()
        cmdCurso.Dispose()
    End Sub

    Private Sub cadastra_modulo()

        Dim sql As String = ""

        sql = "SELECT MAX(cd_curso) FROM tb_curso"

        Dim comando As New SqlCommand(sql, conexao)
        conexao.Open()
        cd_curso = comando.ExecuteScalar + 1
        conexao.Close()

        Dim sql2 As String = ""

        For cont As Integer = 1 To num_mod
            sql2 = sql2 & " INSERT INTO tb_juncao_modulo_curso(ds_modulo,cd_curso) VALUES ('" & cont & sufixo & "'," & cd_curso & ")"
        Next

        comando = New SqlCommand(sql2, conexao)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
        carregar_cadastros_consulta()
    End Sub

    Private Sub altera_modulo()
        sql = "SELECT COUNT(*) FROM tb_juncao_modulo_curso WHERE cd_curso =" & cd_curso
        Dim comando As New SqlCommand(sql, conexao2)
        Dim dr As SqlDataReader
        conexao2.Open()
        dr = comando.ExecuteReader()
        If dr.Read() Then
            numero_modulos = dr.GetInt32(0)
        End If
        conexao2.Close()
        If numero_modulos > txt_qtde_modulo.Text Then
            deleta_modulos()
        ElseIf numero_modulos < txt_qtde_modulo.Text Then
            cadastra_modulos()
        Else
        End If
    End Sub
    Private Sub deleta_modulos()
        Try
            While txt_qtde_modulo.Text < numero_modulos
                sql = "DELETE FROM tb_juncao_modulo_curso WHERE ds_modulo = '" & numero_modulos & sufixo & "' AND cd_curso = " & cd_curso
                Dim comando As New SqlCommand(sql, conexao2)
                conexao2.Open()
                comando.ExecuteNonQuery()
                conexao2.Close()
                numero_modulos -= 1
            End While
        Catch ex As Exception
            MessageBox.Show("Erro ao Deletar do Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cadastra_modulos()
        Try
            numero_modulos += 1
            While numero_modulos <= txt_qtde_modulo.Text
                sql = "INSERT INTO tb_juncao_modulo_curso(ds_modulo,cd_curso) VALUES ('" & numero_modulos & sufixo & "'," & cd_curso & ")"
                Dim comando As New SqlCommand(sql, conexao2)
                conexao2.Open()
                comando.ExecuteNonQuery()
                conexao2.Close()
                numero_modulos += 1
            End While
        Catch ex As Exception
            MessageBox.Show("Erro ao Inserir no Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub excluir_todos_modulos()

        sql = "DELETE FROM tb_juncao_modulo_curso WHERE cd_curso = " & cd_curso

        Dim comando As New SqlCommand(sql, conexao)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()

    End Sub

    Private Sub Limpar2()
        Limpar(Me)
        rdb_anual.Checked = False
        rdb_semestral.Checked = False
    End Sub

    Private Sub limpar_variaveis()
        cd_curso = 0
        num_mod = 0
        cd_manha = 0
        cd_tarde = 0
        cd_noite = 0
    End Sub

    Private Sub chk_pesq_manha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pesq_manha.CheckedChanged
        carrega_dados()
    End Sub

    Private Sub chk_pesq_tarde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pesq_tarde.CheckedChanged
        carrega_dados()
    End Sub

    Private Sub chk_pesq_noite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pesq_noite.CheckedChanged
        carrega_dados()
    End Sub
End Class