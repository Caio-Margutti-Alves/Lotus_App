Imports System.Data.SqlClient
Module funcoes_usuario

    '------USUARIO------'

    Public cd_usuario As String = ""
    Public nm_usuario_db As String = ""
    Public ds_email_db As String = ""
    Public senha_db As String = ""
    Public dica_senha_db As String = ""
    Public tipo_usuario_db As String = ""
    Public ds_estado_db As String = ""

    Public caminho_papel_parede As String = Application.StartupPath & "\wallpapers\"
    Public papel_parede As String = ""
    Public papel_parede_escolhido As String = ""
    Public cor_tema As Integer = 0


    '------------------------------------------'
    Public Sub restricões_usuario()
        If tipo_usuario_db = "Secretaria" Then
            frm_interface.mnu_usuario.Visible = False
            frm_interface.mnu_professor.Visible = False
            frm_interface.mnu_principal.Location = New Point(0, 99)
            frm_interface.mnu_presenca_professor.Visible = False
        ElseIf tipo_usuario_db = "Administrativo" Then
            frm_interface.mnu_turma.Visible = False
            frm_interface.mnu_aluno.Visible = False
            frm_interface.mnu_presenca_turma.Visible = False
        End If
    End Sub

    Public Sub restricoes_configuracoes()
        If tipo_usuario_db = "Secretaria" Then
            configuracoes.mnu_backup.Visible = False
            configuracoes.mnu_restaurar_banco.Visible = False
        End If
    End Sub

    '--------FUNÇÕES DE SISTEMA-------------'
    Public Sub conectar_usuario()
        sql = "UPDATE tb_usuario SET ds_estado = 'online' WHERE cd_usuario = " & cd_usuario
        Dim comando As New SqlCommand(sql, conexao)
        conexao.Close()
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Public Sub desconectar_usuario()
        sql = "UPDATE tb_usuario SET ds_estado = 'offline' WHERE cd_usuario = " & cd_usuario
        Dim comando As New SqlCommand(sql, conexao)
        conexao.Close()
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Private Sub verifica_usuario_conectado()
        sql = "SELECT ds_estado FROM tb_usuario WHERE nm_usuario=@nm_usuario"
        Dim comando As New SqlCommand(sql, conexao)
        comando.Parameters.Add(New SqlParameter("@nm_usuario", nm_usuario_db))

        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando.ExecuteReader()
        While (dr.Read())
            ds_estado_db = dr.GetString(0)
        End While
        conexao.Close()
    End Sub

    Public Sub logar()

        If nm_usuario_db.Trim() = frm_Login.txt_login.Text.Trim() And senha_db.Trim() = frm_Login.txt_senha.Text.Trim() And frm_Login.txt_login.Text.Trim() <> "" And frm_Login.txt_senha.Text.Trim() <> "" Then
            verifica_usuario_conectado()
            If ds_estado_db = "offline" Then
                conectar_usuario()
                MessageBox.Show("Seja Bem Vindo, " & frm_Login.txt_login.Text, "BEM VINDO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_interface.Show()
                frm_Login.Close()
            Else
                MessageBox.Show("O usuário " & nm_usuario_db & " está Online neste momento. " & vbNewLine & _
                "Caso alguém esteja usando sua conta sem seu consentimento contate o Administrador o quanto antes!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            frm_Login.txt_login.BackColor = Color.Red
            frm_Login.txt_senha.BackColor = Color.Red
            frm_Login.btn_login.Focus()
            MessageBox.Show("Login ou Senha incorretos!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub logoff()
        If MessageBox.Show("Tem Certeza que Deseja Realizar o Logoff?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frm_Login.Show()
            frm_interface.Close()
            limpar_usuario()
        End If
    End Sub

    Public Sub sair()
        If MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            desconectar_usuario()
            End
        End If
    End Sub
    Public Sub limpar_usuario()
        cd_usuario = ""
        nm_usuario_db = ""
        ds_email_db = ""
        senha_db = ""
        dica_senha_db = ""
        tipo_usuario_db = ""
    End Sub
End Module
