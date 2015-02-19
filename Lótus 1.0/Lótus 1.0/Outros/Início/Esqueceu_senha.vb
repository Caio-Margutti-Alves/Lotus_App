Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class frm_esqueceu_senha

    Private Sub btn_esqueceu_senha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_esqueceu_senha.Click
        If txt_email.Text <> txt_confirma_email.Text Then
            MessageBox.Show("Os Emails Digitados não Batem!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            carrega_dados()
            If txt_usuario.Text <> nm_usuario_db Or txt_email.Text <> ds_email_db Then
                MessageBox.Show("Usuário e Email Digitados não Batem!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                envia_email()
            End If
        End If
    End Sub
    Private Sub carrega_dados()
        sql = "SELECT nm_usuario,ds_senha,ds_email FROM tb_usuario WHERE nm_usuario=@nm_usuario AND ds_email=@ds_email"

        Dim comando As New SqlCommand(sql, conexao)
        comando.Parameters.Add(New SqlParameter("@nm_usuario", txt_usuario.Text))
        comando.Parameters.Add(New SqlParameter("@ds_email", txt_email.Text))

        Dim dr As SqlDataReader

        conexao.Open()

        dr = comando.ExecuteReader()


        While (dr.Read())

            nm_usuario_db = dr.GetString(0)
            senha_db = dr.GetString(1)
            ds_email_db = dr.GetString(2)

        End While

        conexao.Close()
    End Sub

    Private Sub envia_email()
        Try
            Dim Email As New MailMessage(New MailAddress("etech.2010@hotmail.com"), New MailAddress(ds_email_db))

            Email.Subject = "RECUPERAÇÃO DE SENHA - LÓTUS"
            Email.Body = "Senhor(a) <b>" & nm_usuario_db & "</b>, <div>Estamos enviando seu pedido de recuperação de senha logo abaixo.<br /><br /><div>" & _
                                                          "<b>Login:</b> " & nm_usuario_db & "<div>" & _
                                                          "<b>Senha:</b> " & senha_db & vbNewLine & "<br /><br />" & _
            "Caso o Senhor(a) não tenha solicitado este email peço que nos desculpe e o ignore.<br />" & _
            "<b>Atenciosamente,</b><br />" & _
            "<p><b>Equipe E-tech.</b></p>"

            Email.IsBodyHtml = True

            Dim server As New SmtpClient()
            server.Credentials = New System.Net.NetworkCredential("etech.des.soft@gmail.com", "inf.etech")
            server.Host = "smtp.gmail.com"
            server.Port = 587
            server.EnableSsl = True
            server.Send(Email)

            server.Send(Email)

            MessageBox.Show("E-MAIL ENVIADO COM SUCESSO!!!", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao enviar o email!!!", "Recuperação de Senha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
End Class