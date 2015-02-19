Imports System.Data.SqlClient
Public Class Disciplina

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private cd_disciplina As Integer
    Private excluido As Boolean = False

    Private Sub Cadastro_Disciplina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)

    End Sub

    Private Sub mnu_novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        Limpar(Me)
    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)

    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        carregar_dados_consulta()
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        carregar_dados_consulta()
    End Sub

    Private Sub txt_qtde_aulas_sem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qtde_aulas_sem.TextChanged
        negar_car(txt_qtde_aulas_sem)
    End Sub

    Private Sub lst_consulta_disciplina_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta.MouseClick
        If lst_consulta.SelectedIndex >= 0 Then

            Limpar(Me)
            Dim seleciona As String = "Select cd_disciplina, nm_disciplina,sg_disciplina,qt_max_aulas FROM tb_disciplina Where cd_disciplina = " & lst_consulta.SelectedValue & ""

            Dim drDisciplina As SqlDataReader
            Dim cmdDisciplina As SqlCommand
            cmdDisciplina = New SqlCommand(seleciona, conexao)
            conexao.Open()
            drDisciplina = cmdDisciplina.ExecuteReader

            If drDisciplina.Read() Then
                cd_disciplina = drDisciplina.Item("cd_disciplina")
                txt_nome_disciplina.Text = drDisciplina.Item("nm_disciplina").ToString
                txt_disciplina_abrevi.Text = drDisciplina.Item("sg_disciplina").ToString
                txt_qtde_aulas_sem.Text = drDisciplina.Item("qt_max_aulas").ToString

            End If

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True
            drDisciplina.Close()
            conexao.Close()
            cmdDisciplina.Dispose()

        End If

    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = (deletar_cadastro("tb_disciplina", "cd_disciplina", cd_disciplina))
            If excluido = True Then
                Limpar(Me)
            End If
            carregar_dados_consulta()
            excluido = False
        End If
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        Limpar(Me)
    End Sub


    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        If txt_nome_disciplina.Text = "" Or txt_disciplina_abrevi.Text = "" Or txt_qtde_aulas_sem.Text = "" Then
            MessageBox.Show("Preencha os Campos Assinalados com *!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            If mode = "Novo" Then

                sql = "INSERT INTO tb_disciplina (nm_disciplina,sg_disciplina,qt_max_aulas) values(@nm_disciplina,@sg_disciplina,@qt_max_aulas)"

            Else
                sql = "UPDATE tb_disciplina SET  nm_disciplina=@nm_disciplina,sg_disciplina=@sg_disciplina,qt_max_aulas=@qt_max_aulas WHERE cd_disciplina = " & cd_disciplina

            End If
            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@nm_disciplina", txt_nome_disciplina.Text))
            comando.Parameters.Add(New SqlParameter("@sg_disciplina", txt_disciplina_abrevi.Text))
            comando.Parameters.Add(New SqlParameter("@qt_max_aulas", txt_qtde_aulas_sem.Text))


            conexao.Open()

            cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)

            conexao.Close()
            carregar_dados_consulta()
        End If
    End Sub

    Private Sub carregar_dados_consulta()

        Dim seleciona As String = "Select cd_disciplina, nm_disciplina FROM tb_disciplina WHERE sg_disciplina Like @pesquisa ORDER BY nm_disciplina"

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsDisciplina As New DataSet()
        Dim daDisciplina As New SqlDataAdapter(comando)

        conexao.Open()
        daDisciplina.Fill(dsDisciplina, "Disciplina")
        conexao.Close()
        With Me.lst_consulta
            .DisplayMember = "nm_disciplina"
            .ValueMember = "cd_disciplina"
            .DataSource = dsDisciplina.Tables("Disciplina").DefaultView
        End With
    End Sub
End Class