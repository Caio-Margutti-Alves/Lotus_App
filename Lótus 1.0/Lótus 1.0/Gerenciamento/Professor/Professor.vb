Imports System.Data.SqlClient
Public Class Professor

    '--Menus--'
    Private mode As String = ""

    '--Cadastros--'
    Private data_valida As Boolean = False
    Private cpf_valido As Boolean = False
    Private cpf_copia As Boolean = False
    Private cd_professor As Integer = 0
    Private foto_professor As String = ""
    Private caminho_imagens_professores As String = Application.StartupPath & "\imagens_professores"
    Private professor_sexo As Char = ""

    '--Alteração e Consulta--'
    Private excluido As Boolean = False


    Private Sub Professor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub

    Private Sub mnu_cadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cadastrar.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        Limpar2()
    End Sub
    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        cpf_valido = False
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)

    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        carregar_dados_consulta()
        rad_nome.Checked = True
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = deletar_cadastro("tb_professor", "cd_professor", cd_professor)
            If excluido = True Then
                Limpar2()
                carregar_dados_consulta()
                excluido = False
            End If
        End If
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        Limpar2()
    End Sub
    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        valida_geral()
        If txt_cpf.MaskFull = False Then
            MessageBox.Show("Informe um valor válido para CPF.(Formato: 999.999.999-99)", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_cpf.BackColor = Color.Red
        Else
            If txt_nome.Text = "" Or txt_rg.MaskFull = False Or txt_endereco.Text = "" Or txt_tel.MaskFull = False Or txt_cel.MaskFull = False Or cpf_valido = False Or cpf_copia = True Or txt_dtnascimento.MaskFull = False Or (rdb_f.Checked = False And rdb_m.Checked = False) Then
                MessageBox.Show("Preencha Todos os Campos Corretamente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If mode = "Novo" Then
                    sql = "INSERT INTO tb_professor (nm_professor,ds_endereco,cd_telefone,cd_celular,dt_nascimento,cd_rg,cd_cpf,ic_sexo_m,im_professor) values(@nm_professor,@ds_endereco, @cd_telefone,@cd_celular, @dt_nascimento,@cd_rg, @cd_cpf,@ic_sexo_m,@im_professor)"
                Else
                    sql = "UPDATE tb_professor SET nm_professor = @nm_professor ,ds_endereco= @ds_endereco,cd_telefone= @cd_telefone ,cd_celular= @cd_celular ,dt_nascimento= @dt_nascimento ,cd_rg= @cd_rg, cd_cpf= @cd_cpf,ic_sexo_m= @ic_sexo_m,im_professor= @im_professor WHERE cd_professor =" & cd_professor
                End If

                Dim nascimento As Date
                nascimento = FormatDateTime(txt_dtnascimento.Text, DateFormat.ShortDate)

                Dim comando As New SqlCommand(sql, conexao)
                comando.Parameters.Add(New SqlParameter("@nm_professor", txt_nome.Text))
                comando.Parameters.Add(New SqlParameter("@ds_endereco", txt_endereco.Text))
                comando.Parameters.Add(New SqlParameter("@cd_telefone", txt_tel.Text))
                comando.Parameters.Add(New SqlParameter("@cd_celular", txt_cel.Text))
                comando.Parameters.Add(New SqlParameter("@dt_nascimento", nascimento))
                comando.Parameters.Add(New SqlParameter("@cd_rg", txt_rg.Text))
                comando.Parameters.Add(New SqlParameter("@cd_cpf", txt_cpf.Text))
                comando.Parameters.Add(New SqlParameter("@ic_sexo_m", professor_sexo))
                comando.Parameters.Add(New SqlParameter("@im_professor", foto_professor))

                conexao.Open()
                cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
                conexao.Close()
                carregar_dados_consulta()
            End If
        End If
    End Sub

    Private Sub txt_nome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nome.TextChanged
        negar_num(txt_nome)
    End Sub
    Private Sub txt_dtnascimento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_dtnascimento.TextChanged
        If txt_dtnascimento.MaskFull = True Then
            data_valida = valida_data(txt_dtnascimento)
            If data_valida = False Then
                txt_dtnascimento.Clear()
            End If
        End If
    End Sub
    Private Sub txt_cpf_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cpf.TextChanged
        valida_geral()
    End Sub

    Private Sub rdb_m_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_m.CheckedChanged
        professor_sexo = "M"
    End Sub

    Private Sub rdb_f_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_f.CheckedChanged
        professor_sexo = "F"
    End Sub

    Private Sub btn_carregar_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregar_foto.Click
        dlg_imagens.InitialDirectory = (caminho_imagens_professores)
        If dlg_imagens.ShowDialog() = DialogResult.OK Then
            If System.IO.Path.GetDirectoryName(dlg_imagens.FileName) <> caminho_imagens_professores Then
                MessageBox.Show("A imagem deve estar na pasta 'imagens_alunos' por motivos de organização", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                foto_professor = ""
            Else
                foto_professor = (System.IO.Path.GetFileName(dlg_imagens.FileName))
                ptb_foto.BackgroundImage = Image.FromFile(dlg_imagens.FileName)
            End If
        End If
    End Sub

    Private Sub btn_cam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cam.Click
        caminho_formulario_usado = caminho_imagens_professores
        formulario_usado = "Professor"
        cam()
    End Sub


    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        If rad_nome.Checked = False And rad_rg.Checked = False And rad_cpf.Checked = False And rad_cart_trab.Checked = False Then
            MessageBox.Show("Selecione o tipo de Consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rad_nome.Focus()
        Else
            carregar_dados_consulta()
        End If

    End Sub

    Private Sub lst_consulta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta.MouseClick
        If lst_consulta.SelectedIndex >= 0 Then

            Limpar2()

            Dim seleciona As String = "Select cd_professor,nm_professor,ds_endereco,cd_telefone,cd_celular,dt_nascimento,cd_rg,cd_cpf,ic_sexo_m,im_professor FROM tb_professor Where cd_professor= " & lst_consulta.SelectedValue & ""
            Dim drProfessor As SqlDataReader
            Dim cmdProfessor As SqlCommand
            cmdProfessor = New SqlCommand(seleciona, conexao)
            conexao.Open()
            drProfessor = cmdProfessor.ExecuteReader

            If drProfessor.Read() Then

                cd_professor = drProfessor.Item("cd_professor")
                txt_nome.Text = drProfessor.Item("nm_professor").ToString
                txt_endereco.Text = drProfessor.Item("ds_endereco").ToString
                txt_tel.Text = drProfessor.Item("cd_telefone").ToString
                txt_cel.Text = drProfessor.Item("cd_celular").ToString

                txt_dtnascimento.Text = CDate(drProfessor.Item("dt_nascimento")).ToString("dd/MM/yyyy")

                txt_rg.Text = drProfessor.Item("cd_rg").ToString
                txt_cpf.Text = drProfessor.Item("cd_cpf").ToString
                validar()
                professor_sexo = drProfessor.Item("ic_sexo_m").ToString
                If professor_sexo = "M" Then
                    rdb_m.Checked = True
                ElseIf professor_sexo = "F" Then
                    rdb_f.Checked = True
                End If
                foto_professor = drProfessor.Item("im_professor").ToString
                If foto_professor = Nothing Then
                    ptb_foto.BackgroundImage = My.Resources.Contact
                Else
                    Try
                        ptb_foto.BackgroundImage = Image.FromFile(caminho_imagens_professores & "\" & drProfessor.Item("im_professor").ToString)
                    Catch ex As Exception
                        MessageBox.Show("A imagem não pode ser carrega por não estar na Pasta 'imagens_professores' do programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ptb_foto.BackgroundImage = My.Resources.Contact
                    End Try
                End If
            End If

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True
            drProfessor.Close()
            conexao.Close()
            cmdProfessor.Dispose()

        End If

    End Sub

    Sub carregar_dados_consulta()

        Dim seleciona As String = "Select cd_professor, nm_professor FROM tb_professor WHERE nm_professor Like @pesquisa ORDER BY nm_professor"
        If rad_nome.Checked = True Then
            seleciona = "Select cd_professor, nm_professor FROM tb_professor WHERE nm_professor Like @pesquisa ORDER BY nm_professor"
        ElseIf rad_rg.Checked = True Then
            seleciona = "Select cd_professor, nm_professor FROM tb_professor WHERE cd_rg Like @pesquisa"
        ElseIf rad_cpf.Checked = True Then
            seleciona = "Select cd_professor, nm_professor FROM tb_professor WHERE cd_cpf Like @pesquisa"
        ElseIf rad_cart_trab.Checked = True Then
            seleciona = "Select cd_professor, nm_professor FROM tb_professor WHERE cd_telefone Like @pesquisa"
        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsProfessor As New DataSet()
        Dim daProfessor As New SqlDataAdapter(comando)
        conexao.Open()
        daProfessor.Fill(dsProfessor, "Professor")
        conexao.Close()
        With Me.lst_consulta
            .DisplayMember = "nm_Professor"
            .ValueMember = "cd_professor"
            .DataSource = dsProfessor.Tables("Professor").DefaultView
        End With
    End Sub

    Private Sub Limpar2()

        Limpar(Me)

        rdb_f.Checked = False
        rdb_m.Checked = False

        ptb_foto.BackgroundImage = My.Resources.Contact

        foto_professor = ""
        professor_sexo = ""
        cpf_valido = False
        txt_cpf.BackColor = Color.White
        cd_professor = 0

    End Sub
    Private Sub valida_geral()
        If mode <> "Consulta" Then
            If txt_cpf.MaskFull = True Then
                validar()
                If cpf_valido = True Then
                    verifica_copia_cpf()
                Else
                    txt_cpf.BackColor = Color.Red
                End If
            End If
        End If
    End Sub
    Private Sub validar()
        Dim cpf1 As New valida_CNPJ_CPF
        cpf1.cpf = txt_cpf.Text
        If cpf1.bValida Then
            cpf_valido = True
        Else
            cpf_valido = False
        End If
    End Sub

    Private Sub verifica_copia_cpf()
        Try
            Dim CPF As String = ""
            Dim sqlCPF As String
            If mode = "Novo" Then
                sqlCPF = "SELECT cd_cpf FROM tb_professor"
            Else
                sqlCPF = "SELECT cd_cpf FROM tb_professor WHERE cd_professor <> " & cd_professor
            End If
            Dim commando As New SqlCommand(sqlCPF, conexao2)
            Dim dr As SqlDataReader
            conexao2.Open()
            dr = commando.ExecuteReader()
            While (dr.Read())
                CPF = dr.GetString(0)
                If CPF = txt_cpf.Text Then
                    MessageBox.Show("CPF já cadastrado")
                    cpf_copia = True
                    txt_cpf.BackColor = Color.Red
                    txt_cpf.Focus()
                    conexao2.Close()
                    Exit Sub
                End If
            End While
            cpf_copia = False
            txt_cpf.BackColor = Color.Green
        Catch err As SqlException
            MessageBox.Show(err.Message)
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
        conexao2.Close()
    End Sub
End Class