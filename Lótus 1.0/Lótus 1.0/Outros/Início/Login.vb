Imports System.Data.SqlClient

Public Class frm_Login
    '--Menus--'
    Private senha_exibida As Boolean = False

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AlterarFormatoData("dd/MM/yyyy")
        txt_login.Focus()
        lbl_data.Text = "Data: " & Date.Today.ToShortDateString
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        logar()
    End Sub

    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        End
    End Sub

    Private Sub txt_senha_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_senha.GotFocus
        txt_login.BackColor = Color.White
        txt_senha.BackColor = Color.White
    End Sub

    Private Sub txt_senha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_senha.KeyDown

        If e.KeyCode = Keys.Enter Then
            logar()
        End If

    End Sub

    Private Sub txt_login_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_login.GotFocus
        txt_login.BackColor = Color.White
        txt_senha.BackColor = Color.White
    End Sub

    Private Sub txt_login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_login.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha.Focus()
        End If
    End Sub

    Private Sub Relogio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relogio.Tick
        lbl_hora.Text = "Hora: " & (Hour(Now) & ":" & Minute(Now) & ":" & Second(Now))
    End Sub

    Private Sub txt_login_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_login.LostFocus
        carrega_dados()
    End Sub

    Private Sub btn_dica_senha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dica_senha.Click
        If senha_exibida = True Then
            esconde_dica_senha()
        Else
            exibe_dica_senha()
        End If
    End Sub

    Private Sub exibe_dica_senha()
        senha_exibida = True

        lbl_exibir_dica_senha.Text = "Dica da Senha:"
        lbl_dica.Visible = True
        lbl_esqueceu_senha.Visible = False
    End Sub

    Private Sub esconde_dica_senha()
        senha_exibida = False

        lbl_exibir_dica_senha.Text = "Exibir Dica da Senha?"
        lbl_dica.Visible = False
        lbl_esqueceu_senha.Visible = True
    End Sub

    Private Sub carrega_dados()
        sql = "SELECT * FROM tb_usuario WHERE nm_usuario=@nm_usuario"
        Dim comando As New SqlCommand(sql, conexao)
        comando.Parameters.Add(New SqlParameter("@nm_usuario", txt_login.Text))

        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando.ExecuteReader()
        While (dr.Read())
            cd_usuario = dr.GetInt32(0)
            nm_usuario_db = dr.GetString(1)
            senha_db = dr.GetString(2)
            ds_email_db = dr.GetString(3)
            dica_senha_db = dr.GetString(4)
            tipo_usuario_db = dr.GetString(5)
            papel_parede = dr.GetString(6)
            cor_tema = dr.GetInt32(7)
        End While
        lbl_dica.Text = dica_senha_db
        conexao.Close()
    End Sub

    Private Sub btn_esqueceu_senha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_esqueceu_senha.Click
        frm_esqueceu_senha.Show()
    End Sub
End Class
