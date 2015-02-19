Imports System.Data.SqlClient

Public Class usuario

    '--Cadastro--'
    Private email_valido As Boolean = False
    Private tipo_usuario As String = ""
    Private cd_usuario As Integer = 0

    '--Menus--'
    Private mode As String = ""

    '----ALteração e Consulta---'

    Private excluido As Boolean = False

    Private Sub mnu_novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        limpar2()
        grb_tipo_usuario.Enabled = True
    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        grb_tipo_usuario.Enabled = False
    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        carregar_dados_consulta()
        rad_usuario.Checked = True
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        limpar2()
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        excluido = deletar_cadastro("tb_usuario", "cd_usuario", cd_usuario)
        If excluido = True Then
            limpar2()
        End If
        carregar_dados_consulta()
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        email_valido = valida_email(txt_email)
        If txt_novasenha.Text = "" Or txt_novasenha2.Text = "" Or txt_usuario.Text = "" Or email_valido = False Or (rad_administrativo.Checked = False And rad_secretaria.Checked = False) Then
            MessageBox.Show("Preencha Corretamente Todos os Campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txt_novasenha.Text <> txt_novasenha2.Text Then
            MessageBox.Show("As Senhas não Batem!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If mode = "Novo" Then
                sql = "INSERT INTO tb_usuario (nm_usuario,ds_senha,ds_email,ds_dica_senha,ds_tipo_usuario,ds_caminho_papel_parede,cor_tema,ds_estado) values(@nm_usuario,@ds_senha,@ds_email,@ds_dica_senha,@ds_tipo_usuario,@ds_caminho_papel_parede,@cor_tema,@ds_estado)"
            Else
                sql = "UPDATE tb_usuario SET nm_usuario = @nm_usuario,ds_senha=@ds_senha,ds_email=@ds_email,ds_dica_senha = @ds_dica_senha,ds_tipo_usuario =@ds_tipo_usuario,  ds_estado = @ds_estado WHERE cd_usuario =" & cd_usuario
            End If

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@nm_usuario", txt_usuario.Text))
            comando.Parameters.Add(New SqlParameter("@ds_senha", txt_novasenha.Text))
            comando.Parameters.Add(New SqlParameter("@ds_email", txt_email.Text))
            comando.Parameters.Add(New SqlParameter("@ds_dica_senha", txt_dica_senha.Text))
            comando.Parameters.Add(New SqlParameter("@ds_tipo_usuario", tipo_usuario))
            comando.Parameters.Add(New SqlParameter("@ds_caminho_papel_parede", "fundo_padrao.jpg"))
            comando.Parameters.Add(New SqlParameter("@cor_tema", -15420550))
            comando.Parameters.Add(New SqlParameter("@ds_estado", "offline"))


            conexao.Open()
            cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
            conexao.Close()
            carregar_dados_consulta()

        End If

    End Sub
    Private Sub rad_administrativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_administrativo.CheckedChanged
        tipo_usuario = "Administrativo"
    End Sub

    Private Sub rad_secretaria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_secretaria.CheckedChanged
        tipo_usuario = "Secretaria"
    End Sub

    Private Sub usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        If rad_usuario.Checked = False And rad_tipo.Checked = False Then
            MessageBox.Show("Selecione o tipo de Consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rad_usuario.Focus()
        Else
            carregar_dados_consulta()
        End If
    End Sub

    Private Sub lst_consulta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta.MouseClick

        If lst_consulta.SelectedIndex >= 0 Then

            Dim seleciona As String = "SELECT cd_usuario,nm_usuario,ds_email,ds_senha,ds_dica_senha,ds_tipo_usuario FROM tb_usuario Where cd_usuario = " & lst_consulta.SelectedValue
            Dim drUsuario As SqlDataReader
            Dim cmdUsuario As SqlCommand
            cmdUsuario = New SqlCommand(seleciona, conexao)

            conexao.Open()
            drUsuario = cmdUsuario.ExecuteReader

            If drUsuario.Read() Then

                cd_usuario = drUsuario.Item("cd_usuario")
                txt_usuario.Text = drUsuario.Item("nm_usuario").ToString
                txt_novasenha.Text = drUsuario.Item("ds_senha").ToString
                txt_email.Text = drUsuario.Item("ds_email").ToString
                txt_novasenha2.Text = drUsuario.Item("ds_senha").ToString
                txt_dica_senha.Text = drUsuario.Item("ds_dica_senha").ToString
                tipo_usuario = drUsuario.Item("ds_tipo_usuario")

                If tipo_usuario = "Administrativo" Then
                    rad_administrativo.Checked = True
                ElseIf tipo_usuario = "Secretaria" Then
                    rad_secretaria.Checked = True
                End If

                mnu_alterar.Enabled = True
                mnu_excluir.Enabled = True

            End If

            drUsuario.Close()
            conexao.Close()
            cmdUsuario.Dispose()
        End If
    End Sub


    Sub carregar_dados_consulta()
        Dim seleciona As String = "SELECT cd_usuario, nm_usuario FROM tb_usuario WHERE nm_usuario Like @pesquisa AND nm_usuario<>'Etech'"
        If rad_usuario.Checked = True Then
            seleciona = "SELECT cd_usuario, nm_usuario FROM tb_usuario WHERE nm_usuario Like @pesquisa AND nm_usuario<>'Etech'"
        ElseIf rad_tipo.Checked = True Then
            seleciona = "SELECT cd_usuario, nm_usuario FROM tb_usuario WHERE ds_tipo_usuario Like @pesquisa AND nm_usuario<>'Etech'"

        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsUsuario As New DataSet()
        Dim daUsuario As New SqlDataAdapter(comando)
        conexao.Open()
        daUsuario.Fill(dsUsuario, "Usuario")
        conexao.Close()
        With Me.lst_consulta
            .DisplayMember = "nm_usuario"
            .ValueMember = "cd_usuario"
            .DataSource = dsUsuario.Tables("Usuario").DefaultView
        End With
    End Sub

    Private Sub limpar2()
        Limpar(Me)
        rad_secretaria.Checked = False
        rad_administrativo.Checked = False
        tipo_usuario = ""
        cd_usuario = 0
        excluido = False
    End Sub
End Class