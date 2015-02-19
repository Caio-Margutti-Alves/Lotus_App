Imports System.Data.SqlClient

Public Class Aluno

    '--Cadastros--'
    Private data_valida As Boolean = False
    Private email_valido As Boolean = False
    Private matricula_copia As Boolean = False
    Private cd_aluno As Integer = 0
    Private foto_aluno As String = ""
    Private caminho_imagens_alunos As String = Application.StartupPath & "\imagens_alunos"
    Private aluno_sexo As Char = ""

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub frm_Cadastrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub

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
        If lst_consulta_aluno.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = deletar_cadastro("tb_aluno", "cd_aluno", cd_aluno)
            If excluido = True Then
                limpar2()
            End If
            carregar_dados_consulta()
            excluido = False
        End If
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        email_valido = valida_email(txt_email)
        data_valida = valida_data(txt_dtnascimento)
        verifica_num_matricula()
        If txt_nome.Text = "" Or txt_rg.MaskFull = False Or txt_dtnascimento.MaskFull = False Or txt_matricula.Text = "" Or txt_telefone.MaskFull = False Or data_valida = False Or email_valido = False Or matricula_copia = True Or (rdb_f.Checked = False And rdb_m.Checked = False) Then
            MessageBox.Show("Preencha Corretamente os Campos Assinalados com *!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If mode = "Novo" Then
                sql = "INSERT INTO tb_aluno (nm_aluno,ds_endereco,cd_rg,dt_nascimento,ds_email,cd_telefone,cd_matricula,ds_observacoes,ic_sexo_m,im_foto_aluno) VALUES(@nm_aluno, @ds_endereco, @cd_rg, @dt_nascimento, @ds_email, @cd_telefone, @cd_matricula,@ds_observacoes,@ic_sexo_m,@im_foto_aluno)"
            Else
                sql = "UPDATE tb_aluno SET nm_aluno = @nm_aluno,ds_endereco= @ds_endereco,cd_rg = @cd_rg,dt_nascimento = @dt_nascimento, ds_email = @ds_email, cd_telefone = @cd_telefone,cd_matricula= @cd_matricula, ds_observacoes = @ds_observacoes, ic_sexo_m = @ic_sexo_m, im_foto_aluno = @im_foto_aluno WHERE cd_aluno =" & cd_aluno
            End If

            Dim nascimento As Date
            nascimento = FormatDateTime(txt_dtnascimento.Text, DateFormat.ShortDate)

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@nm_aluno", txt_nome.Text))
            comando.Parameters.Add(New SqlParameter("@ds_endereco", txt_endereco.Text))
            comando.Parameters.Add(New SqlParameter("@cd_rg", txt_rg.Text))
            comando.Parameters.Add(New SqlParameter("@dt_nascimento", nascimento))
            comando.Parameters.Add(New SqlParameter("@ds_email", txt_email.Text))
            comando.Parameters.Add(New SqlParameter("@cd_telefone", txt_telefone.Text))
            comando.Parameters.Add(New SqlParameter("@cd_matricula", txt_matricula.Text))
            comando.Parameters.Add(New SqlParameter("@ds_observacoes", txt_obs.Text))
            comando.Parameters.Add(New SqlParameter("@ic_sexo_m", aluno_sexo))
            comando.Parameters.Add(New SqlParameter("@im_foto_aluno", foto_aluno))

            conexao.Open()
            cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
            conexao.Close()
            carregar_dados_consulta()
        End If
    End Sub

    Private Sub txt_nome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        negar_car(txt_nome)
    End Sub

    Private Sub txt_matricula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        negar_car(txt_matricula)
    End Sub

    Private Sub txt_dtnascimento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_dtnascimento.TextChanged
        If txt_dtnascimento.MaskFull = True Then
            data_valida = valida_data(txt_dtnascimento)
            If data_valida = False Then
                txt_dtnascimento.Clear()
            End If
        End If
    End Sub

    Private Sub btn_carregar_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carregar_foto.Click
        dlg_imagens.InitialDirectory = (caminho_imagens_alunos)
        If dlg_imagens.ShowDialog() = DialogResult.OK Then
            If System.IO.Path.GetDirectoryName(dlg_imagens.FileName) <> caminho_imagens_alunos Then
                MessageBox.Show("A imagem deve estar na pasta 'imagens_alunos' por motivos de organização", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                foto_aluno = ""
            Else
                foto_aluno = (System.IO.Path.GetFileName(dlg_imagens.FileName))
                ptb_foto.BackgroundImage = Image.FromFile(dlg_imagens.FileName)
            End If
        End If
    End Sub

    Private Sub btn_cam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cam.Click
        caminho_formulario_usado = caminho_imagens_alunos
        formulario_usado = "Aluno"
        cam()
    End Sub

    Private Sub mnu_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Turma.Show()
    End Sub

    Private Sub rdb_m_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_m.CheckedChanged
        aluno_sexo = "M"
    End Sub

    Private Sub rdb_f_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_f.CheckedChanged
        aluno_sexo = "F"
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        If rad_email.Checked = False And rad_matricula.Checked = False And rad_nome.Checked = False And rad_rg.Checked = False Then
            MessageBox.Show("Selecione o tipo de Consulta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rad_nome.Focus()
        Else
            carregar_dados_consulta()
        End If

    End Sub

    Private Sub lst_consulta_aluno_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta_aluno.MouseClick
        If lst_consulta_aluno.SelectedIndex >= 0 Then

            Dim seleciona As String = "Select cd_aluno,nm_aluno, ds_endereco, cd_rg, dt_nascimento, ds_email, cd_telefone, cd_matricula, ds_observacoes, ic_sexo_m, im_foto_aluno FROM tb_aluno Where cd_aluno = " & lst_consulta_aluno.SelectedValue
            Dim drAlunos As SqlDataReader
            Dim cmdAlunos As New SqlCommand(seleciona, conexao)

            conexao.Open()
            drAlunos = cmdAlunos.ExecuteReader

            If drAlunos.Read() Then
                cd_aluno = drAlunos.Item("cd_aluno")
                txt_nome.Text = drAlunos.Item("nm_aluno").ToString
                txt_endereco.Text = drAlunos.Item("ds_endereco").ToString
                txt_rg.Text = drAlunos.Item("cd_rg").ToString

                txt_dtnascimento.Text = CDate(drAlunos.Item("dt_nascimento")).ToString("dd/MM/yyyy")

                txt_email.Text = drAlunos.Item("ds_email").ToString
                txt_telefone.Text = drAlunos.Item("cd_telefone").ToString
                txt_matricula.Text = drAlunos.Item("cd_matricula").ToString
                foto_aluno = drAlunos.Item("im_foto_aluno").ToString
                If foto_aluno = Nothing Then
                    ptb_foto.BackgroundImage = My.Resources.Contact
                Else
                    Try
                        ptb_foto.BackgroundImage = Image.FromFile(caminho_imagens_alunos & "\" & drAlunos.Item("im_foto_aluno").ToString)
                    Catch ex As Exception
                        MessageBox.Show("A imagem não pode ser carrega por não estar na Pasta 'imagens_aluno' do programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ptb_foto.BackgroundImage = My.Resources.Contact
                    End Try
                End If
                txt_obs.Text = drAlunos.Item("ds_observacoes").ToString
                aluno_sexo = drAlunos.Item("ic_sexo_m").ToString
                If aluno_sexo = "M" Then
                    rdb_m.Checked = True
                ElseIf aluno_sexo = "F" Then
                    rdb_f.Checked = True
                End If

                mnu_alterar.Enabled = True
                mnu_excluir.Enabled = True
            End If

            drAlunos.Close()
            conexao.Close()
            cmdAlunos.Dispose()
        End If
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        limpar2()
    End Sub

    Sub carregar_dados_consulta()
        Dim seleciona = "Select cd_aluno, nm_aluno FROM tb_aluno WHERE nm_aluno Like @pesquisa ORDER BY nm_aluno"
        If rad_nome.Checked = True Then
            seleciona = "Select cd_aluno, nm_aluno FROM tb_aluno WHERE nm_aluno Like @pesquisa ORDER BY nm_aluno"
        ElseIf rad_email.Checked = True Then
            seleciona = "Select cd_aluno, nm_aluno FROM tb_aluno WHERE ds_email Like @pesquisa"
        ElseIf rad_matricula.Checked = True Then
            seleciona = "Select cd_aluno, nm_aluno FROM tb_aluno WHERE cd_matricula Like @pesquisa"
        ElseIf rad_rg.Checked = True Then
            seleciona = "Select cd_aluno, nm_aluno FROM tb_aluno WHERE cd_rg Like @pesquisa"
        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsAluno As New DataSet()
        Dim daAluno As New SqlDataAdapter(comando)

        Try
            conexao.Open()
            daAluno.Fill(dsAluno, "Aluno")
            conexao.Close()
            With Me.lst_consulta_aluno
                .DisplayMember = "nm_aluno"
                .ValueMember = "cd_aluno"
                .DataSource = dsAluno.Tables("Aluno").DefaultView
            End With
        Catch
        End Try
        conexao.Close()
    End Sub

    Private Sub limpar2()
        Limpar(Me)
        rdb_f.Checked = False
        rdb_m.Checked = False
        ptb_foto.BackgroundImage = My.Resources.Contact
        foto_aluno = ""
    End Sub
    Private Sub verifica_num_matricula()
        Try
            Dim Matricula As String = ""
            Dim sqlMatricula As String
            If mode = "Novo" Then
                sqlMatricula = "SELECT cd_matricula FROM tb_aluno"
            Else
                sqlMatricula = "SELECT cd_matricula FROM tb_aluno WHERE cd_aluno <> " & cd_aluno
            End If
            Dim commando As New SqlCommand(sqlMatricula, conexao2)
            Dim dr As SqlDataReader
            conexao2.Open()
            dr = commando.ExecuteReader()
            While (dr.Read())
                Matricula = dr.GetString(0)
                If Matricula = txt_matricula.Text Then
                    MessageBox.Show("Número de Matrícula já Cadastrado!!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    matricula_copia = True
                    conexao2.Close()
                    Exit Sub
                End If
            End While
            matricula_copia = False
        Catch err As SqlException
            MessageBox.Show(err.Message)
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
        conexao2.Close()
    End Sub
End Class
