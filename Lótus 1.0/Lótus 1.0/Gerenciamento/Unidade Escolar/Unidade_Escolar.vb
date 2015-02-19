Imports System.Data.SqlClient
Public Class Unidade_Escolar
    '--Cadastro--'
    Private caminho_logo_unidade As String = Application.StartupPath & "\unidade_escolar"
    Private logo_unidade As String = ""
    Private cd_unidade As Integer = 0
    Private email_valido As Boolean = False
    Private interno_copia As Boolean = False

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub mnu_novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        limpar2()

    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)

    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        rad_nome.Checked = True
        carregar_dados_consulta()

    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = deletar_cadastro("tb_unidade_escolar", "cd_unidade", cd_unidade)
            If excluido = True Then
                limpar2()
            End If
            carregar_dados_consulta()
            excluido = False
        End If
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        limpar2()

    End Sub

    Private Sub txt_sede_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        negar_num(txt_nome_unidade)
    End Sub

    Private Sub txt_unidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_unidade.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_unidade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_unidade.TextChanged
        negar_car(txt_unidade)
    End Sub

    Private Sub btn_carregar_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregar_foto.Click
        dlg_imagens.InitialDirectory = (caminho_logo_unidade)
        If dlg_imagens.ShowDialog() = DialogResult.OK Then
            If System.IO.Path.GetDirectoryName(dlg_imagens.FileName) <> caminho_logo_unidade Then
                MessageBox.Show("A imagem deve estar na pasta 'unidade' por motivos de organização", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                logo_unidade = (System.IO.Path.GetFileName(dlg_imagens.FileName))
                ptb_foto.BackgroundImage = Image.FromFile(dlg_imagens.FileName)
            End If
        End If
    End Sub


    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        email_valido = valida_email(txt_email)
        If txt_nome_unidade.Text = Nothing Or txt_endereco.Text = Nothing Or txt_tel.MaskFull = False Or txt_unidade.Text = Nothing Or email_valido = False Or interno_copia = True Then
            MessageBox.Show("Preencha corretamente todos os campos!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sql As String
            If mode = "Novo" Then
                sql = "INSERT INTO tb_unidade_escolar (nm_unidade,ds_email_unidade,ds_endereco,cd_telefone,cd_interno,im_logo) values (@nm_unidade,@ds_email_unidade,@ds_endereco,@cd_telefone,@cd_interno,@im_logo)"
            Else
                sql = "UPDATE tb_unidade_escolar SET nm_unidade = @nm_unidade, ds_email_unidade = @ds_email_unidade, ds_endereco= @ds_endereco,cd_telefone = @cd_telefone ,cd_interno = @cd_interno, im_logo= @im_logo WHERE cd_unidade =" & cd_unidade
            End If

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@nm_unidade", txt_nome_unidade.Text))
            comando.Parameters.Add(New SqlParameter("@ds_email_unidade", txt_email.Text))
            comando.Parameters.Add(New SqlParameter("@ds_endereco", txt_endereco.Text))
            comando.Parameters.Add(New SqlParameter("@cd_telefone", txt_tel.Text))
            comando.Parameters.Add(New SqlParameter("@cd_interno", txt_unidade.Text))
            comando.Parameters.Add(New SqlParameter("@im_logo", logo_unidade))

            conexao.Open()
            cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
            conexao.Close()
            carregar_dados_consulta()
        End If
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        If rad_nome.Checked = False And rad_num.Checked = False Then
            MessageBox.Show("Selecione o tipo de Consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rad_nome.Focus()
        Else
            carregar_dados_consulta()
        End If

    End Sub

    Private Sub lst_consulta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta.MouseClick
        If lst_consulta.SelectedIndex >= 0 Then

            Dim seleciona As String = "SELECT cd_unidade,nm_unidade,ds_email_unidade,ds_endereco,cd_telefone,cd_interno,im_logo FROM tb_unidade_escolar WHERE cd_unidade Like '%" & lst_consulta.SelectedValue & "%'"
            Dim drUnidade As SqlDataReader
            Dim cmdUnidade As SqlCommand
            cmdUnidade = New SqlCommand(seleciona, conexao)
            conexao.Open()
            drUnidade = cmdUnidade.ExecuteReader

            If drUnidade.Read() Then
                cd_unidade = drUnidade.Item("cd_unidade").ToString
                txt_nome_unidade.Text = drUnidade.Item("nm_unidade").ToString
                txt_email.Text = drUnidade.Item("ds_email_unidade").ToString
                txt_endereco.Text = drUnidade.Item("ds_endereco").ToString
                txt_tel.Text = drUnidade.Item("cd_telefone").ToString
                txt_unidade.Text = drUnidade.Item("cd_interno").ToString

                logo_unidade = drUnidade.Item("im_logo").ToString

                If logo_unidade = "" Then
                    ptb_foto.BackgroundImage = My.Resources.sede
                Else
                    Try
                        ptb_foto.BackgroundImage = Image.FromFile(caminho_logo_unidade & "\" & drUnidade.Item("im_logo").ToString)
                    Catch ex As Exception
                        MessageBox.Show("A imagem não pode ser carrega por não estar na Pasta 'unidade_escolar' do programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ptb_foto.BackgroundImage = My.Resources.sede
                    End Try
                End If
            End If

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True
            drUnidade.Close()
            conexao.Close()
            cmdUnidade.Dispose()

        End If
    End Sub

    Sub carregar_dados_consulta()
        Dim seleciona As String = "SELECT cd_unidade,nm_unidade,ds_email_unidade,ds_endereco,cd_telefone,cd_interno,im_logo FROM tb_unidade_escolar WHERE nm_unidade Like @pesquisa"
        If rad_nome.Checked = True Then
            seleciona = "SELECT cd_unidade,nm_unidade,ds_email_unidade,ds_endereco,cd_telefone,cd_interno,im_logo FROM tb_unidade_escolar WHERE nm_unidade Like @pesquisa ORDER BY nm_unidade"
        ElseIf rad_num.Checked = True Then
            seleciona = "SELECT cd_unidade,nm_unidade,ds_email_unidade,ds_endereco,cd_telefone,cd_interno,im_logo FROM tb_unidade_escolar WHERE cd_interno Like @pesquisa ORDER BY nm_unidade"
        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsUnidade As New DataSet()
        Dim daUnidade As New SqlDataAdapter(comando)
        conexao.Open()
        daUnidade.Fill(dsUnidade, "Unidade")
        conexao.Close()
        With Me.lst_consulta
            .DisplayMember = "nm_unidade"
            .ValueMember = "cd_unidade"
            .DataSource = dsUnidade.Tables("Unidade").DefaultView
        End With
    End Sub
    Sub limpar2()
        Limpar(Me)

        logo_unidade = ""
        ptb_foto.BackgroundImage = My.Resources.sede

    End Sub

    Private Sub Unidade_Escolar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub
    Private Sub verifica_num_unidade()
        Try
            Dim cd_interno As Integer
            Dim sqlInterno As String
            If mode = "Novo" Then
                sqlInterno = "SELECT cd_interno FROM tb_unidade_escolar"
            Else
                sqlInterno = "SELECT cd_interno FROM tb_unidade_escolar WHERE cd_unidade <> " & cd_unidade
            End If
            Dim commando As New SqlCommand(sqlInterno, conexao2)
            Dim dr As SqlDataReader
            conexao2.Open()
            dr = commando.ExecuteReader()
            While (dr.Read())
                cd_interno = dr.GetString(0)
                If cd_interno = txt_unidade.Text Then
                    MessageBox.Show("Número da Unidade Escolar já Cadastrado!!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    interno_copia = True
                    conexao2.Close()
                    Exit Sub
                End If
            End While
            interno_copia = False
        Catch err As SqlException
            MessageBox.Show(err.Message)
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
        conexao2.Close()
    End Sub
End Class