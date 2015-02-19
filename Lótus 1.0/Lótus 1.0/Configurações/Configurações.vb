Imports System.Data.SqlClient
Imports System.IO

Public Class configuracoes
    Private cor_tema_temporario As Integer = 0
    Private altera_cor_tema As Boolean = True

    Private Sub frm_configuracoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        restricoes_configuracoes()
        carregar_cores()
        carregar_cor_tema()
    End Sub

    Private Sub mnu_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ok.Click
        Try
            If altera_cor_tema = False Then
                papel_parede = papel_parede_escolhido
                sql = "UPDATE tb_usuario SET ds_caminho_papel_parede = '" & papel_parede & "' WHERE cd_usuario =" & cd_usuario
                frm_interface.BackgroundImage = pct_papel_parede.BackgroundImage

            Else
                cor_tema = cor_tema_temporario
                sql = "UPDATE tb_usuario SET cor_tema = '" & cor_tema & "' WHERE cd_usuario =" & cd_usuario
                frm_interface.pnl_cor.BackColor = pct_tema.BackColor
                frm_interface.pnl_usuario.BackColor = pct_tema.BackColor
                carregar_cores()
            End If

            Dim comando As New SqlCommand(sql, conexao)
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub mnu_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cancelar.Click

        If altera_cor_tema = False Then
            papel_parede_escolhido = papel_parede
            carregar_papel_parede()
        Else
            carregar_cor_tema()
        End If

    End Sub

    Private Sub mnu_altera_cor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_altera_cor.Click

        selecionar_cor()

    End Sub

    Private Sub mnu_carregar_imagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_carregar_imagem.Click

        selecionar_imagem()

    End Sub

    Private Sub mnu_altera_tema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_altera_tema.Click

        altera_cor_tema = True

        troca_menus()

    End Sub

    Private Sub mnu_altera_fundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_altera_fundo.Click

        altera_cor_tema = False

        troca_menus()

    End Sub

    Private Sub mnu_backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_backup.Click
        Try
            backup.Description = "Selecione a pasta onde deseja realizar o Backup"
            backup.RootFolder = Environment.SpecialFolder.Desktop
            backup.ShowNewFolderButton = True

            If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
                BackupDatabase(Application.StartupPath & "\database\db_lotus.mdf", backup.SelectedPath() & "\Backup.bak")
                MessageBox.Show("Backup Realizado com Sucesso")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao realizar o Backup", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mnu_restaurar_banco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_restaurar_banco.Click
        Try
            Dim nomeArquivo As String
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "(Arquivo de Backup BAK)|*.BAK;"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Selecionar Arquivo de Backup do Banco de Dados"

            If (openDlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                nomeArquivo = openDlg.FileName
                RestauraDatabase(Application.StartupPath & "\database\db_lotus.mdf", nomeArquivo)
                Try
                    carrega_dados()
                    carregar_fundo_e_tema()
                    carregar_cor_tema()
                    carregar_cores()
                    carregar_papel_parede()
                    pct_tema.Visible = False
                    pct_tema2.Visible = False
                    MessageBox.Show("Restauração Feita com Sucesso")
                Catch ex As Exception
                    MessageBox.Show("Não foi Possível Carregar todas as Cores do Sistema: " & ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub mnu_restaurar_padrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_restaurar_padrao.Click
        Try
            sql = "UPDATE tb_usuario SET ds_caminho_papel_parede = 'fundo_padrao.jpg',cor_tema = '-15420550' WHERE cd_usuario =" & cd_usuario
            Dim comando As New SqlCommand(sql, conexao)
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

            cor_tema = -15420550
            frm_interface.pnl_cor.BackColor = Color.FromArgb(cor_tema)
            frm_interface.pnl_usuario.BackColor = Color.FromArgb(cor_tema)
            carregar_fundo_form(Me)
            carregar_cores()
            carregar_cor_tema()
            frm_interface.BackgroundImage = My.Resources.fundo_padrao
        Catch ex As Exception
            MessageBox.Show("Não foi Possível restaurar o Visual padrão do Programa", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexao.Close()
        End Try
    End Sub

    '---------------- SUBS E FUNÇÕES---------------------'

    Private Sub carregar_cores()

        mnu_altera_tema.BackColor = Color.FromArgb(cor_tema)
        mnu_altera_fundo.BackColor = Color.FromArgb(cor_tema)
        mnu_backup.BackColor = Color.FromArgb(cor_tema)
        mnu_restaurar_banco.BackColor = Color.FromArgb(cor_tema)
        mnu_restaurar_padrao.BackColor = Color.FromArgb(cor_tema)

        tsp_config.BackColor = Color.FromArgb(cor_tema)

        carregar_fundo_form(Me)

    End Sub

    Private Sub carregar_cor_tema()

        pct_tema.BackColor = frm_interface.pnl_cor.BackColor
        pct_tema2.BackColor = frm_interface.pnl_cor.BackColor
        cor_tema = pct_tema.BackColor.ToArgb
        cor_tema_temporario = cor_tema

    End Sub

    Private Sub carregar_papel_parede()

        pct_multiplo.BackgroundImage = My.Resources.display_background
        pct_papel_parede.BackgroundImage = frm_interface.BackgroundImage

    End Sub

    Private Sub selecionar_imagem()
        dlg_papel_parede.InitialDirectory = (Application.StartupPath & "\wallpapers")
        If dlg_papel_parede.ShowDialog() = DialogResult.OK Then
            Try
                papel_parede_escolhido = dlg_papel_parede.FileName
                pct_papel_parede.BackgroundImage = Image.FromFile(dlg_papel_parede.FileName)
            Catch ex As Exception
                MessageBox.Show("Formato não Suportado pelo Sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub selecionar_cor()

        If cdg_cores_fundo.ShowDialog() = DialogResult.OK Then
            cor_tema_temporario = cdg_cores_fundo.Color.ToArgb
            pct_tema.BackColor = Color.FromArgb(cor_tema_temporario)
            pct_tema2.BackColor = Color.FromArgb(cor_tema_temporario)
        End If

    End Sub

    Private Sub troca_menus()

        If altera_cor_tema = False Then

            mnu_carregar_imagem.Visible = True
            mnu_altera_cor.Visible = False

            pct_papel_parede.Visible = True
            pct_papel_parede.BackColor = Color.Black

            pct_tema.Visible = False
            pct_tema2.Visible = False

            carregar_papel_parede()

        Else

            mnu_carregar_imagem.Visible = False
            mnu_altera_cor.Visible = True

            pct_multiplo.BackgroundImage = My.Resources.display_tema
            pct_papel_parede.Visible = False

            pct_tema.BackgroundImage = Nothing
            pct_tema.Visible = True
            pct_tema2.Visible = True

            carregar_cor_tema()

        End If

    End Sub

    Private Sub carrega_dados()
        Try
            sql = "SELECT ds_caminho_papel_parede, cor_tema FROM tb_usuario WHERE cd_usuario = @cd_usuario"
            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@cd_usuario", cd_usuario))
            Dim dr As SqlDataReader
            conexao.Open()
            dr = comando.ExecuteReader()
            While (dr.Read())
                papel_parede = dr.GetString(0)
                cor_tema = dr.GetInt32(1)
            End While
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao Carregar as Informações do Usuário: " & ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Private Sub carregar_fundo_e_tema()

        Try
            frm_interface.BackgroundImage = Image.FromFile(papel_parede)
        Catch ex1 As Exception
            Try
                frm_interface.BackgroundImage = Image.FromFile(caminho_papel_parede & papel_parede)
            Catch ex2 As Exception
                MessageBox.Show("Não foi possível localizar o seu papel de parede pois o mesmo não se encontra nesta máquina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                frm_interface.BackgroundImage = My.Resources.fundo_padrao
                papel_parede_padrao()
            End Try
        End Try

        Try
            frm_interface.pnl_cor.BackColor = Color.FromArgb(cor_tema)
            frm_interface.pnl_usuario.BackColor = Color.FromArgb(cor_tema)
        Catch ex As Exception
            MessageBox.Show("Não foi possível carregar a cor do tema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            frm_interface.pnl_cor.BackColor = Color.FromArgb(-15420550)
            frm_interface.pnl_usuario.BackColor = Color.FromArgb(-15420550)
            cor_tema_padrao()
        End Try
    End Sub
End Class