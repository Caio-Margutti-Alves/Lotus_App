Imports System.Data.SqlClient
Public Class Cadastro_Eventos

    '--Cadastro--'
    Private cd_evento As Integer = 0

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private num_evento As Integer = 0
    Private excluido As Boolean = False

    Private Sub Eventos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        atualiza_calendario()
        alteracao_menu_eventos()
    End Sub

    Private Sub mnu_cadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cadastrar.Click
        mode = "Novo"
        Limpar(Me)
        grb_cadastro.Enabled = True
        mnu_salvar.Enabled = True
    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        grb_cadastro.Enabled = True
        dtp_evento.Enabled = False
        mnu_salvar.Enabled = True
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        excluir_evento()
        grb_cadastro.Enabled = False
        alteracao_menu_eventos()
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        If txt_nm_evento.Text = "" Then
            MessageBox.Show("Preencha Todos os Campos e Selecione a Data", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If mode = "Novo" Then
                sql = "INSERT INTO tb_evento (dt_evento,nm_evento,ds_evento) VALUES(@dt_evento, @nm_evento, @ds_evento)"
            Else
                sql = "UPDATE tb_evento SET dt_evento= @dt_evento, nm_evento = @nm_evento, ds_evento = @ds_evento  WHERE cd_evento=" & cd_evento

            End If

            Dim dia_evento As Date
            dia_evento = FormatDateTime(dtp_evento.SelectionStart, DateFormat.ShortDate)

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@dt_evento", dia_evento))
            comando.Parameters.Add(New SqlParameter("@nm_evento", txt_nm_evento.Text))
            comando.Parameters.Add(New SqlParameter("@ds_evento", txt_ds_evento.Text))

            cadastrar_alterar(comando)
            atualiza_calendario()
            carrega_evento()
            grb_cadastro.Enabled = False
            dtp_evento.Enabled = True
            mnu_salvar.Enabled = False
        End If
    End Sub

    Private Sub dtp_evento_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles dtp_evento.DateChanged
        Limpar(Me)
        alteracao_menu_eventos()
        carrega_evento()
    End Sub

    Private Sub cadastrar_alterar(ByVal comando As SqlCommand)
        Try
            Dim linhasAfetadas As Integer = 0
            conexao.Open()
            linhasAfetadas = comando.ExecuteNonQuery()
            conexao.Close()
            If linhasAfetadas <> 0 Then
                If mode = "Novo" Then
                    MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Alteração Realizada Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            mnu_salvar.Enabled = False
            alteracao_menu_eventos()
        Catch ex As Exception
            MessageBox.Show("Erro ao Inserir no Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub atualiza_calendario()
        dtp_evento.RemoveAllBoldedDates()

        sql = "SELECT dt_evento FROM tb_evento"
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando.ExecuteReader()
        While dr.Read
            dtp_evento.AddBoldedDate(dr.GetDateTime(0))
        End While
        dtp_evento.UpdateBoldedDates()
        conexao.Close()

    End Sub

    Private Sub carrega_evento()
        Try
            sql = "SELECT cd_evento,nm_evento,ds_evento FROM tb_evento WHERE dt_evento =@pesquisa"

            Dim dia_evento As Date
            dia_evento = FormatDateTime(dtp_evento.SelectionStart, DateFormat.ShortDate)

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@pesquisa", dia_evento))

            Dim dr As SqlDataReader
            conexao.Open()
            dr = comando.ExecuteReader
            While (dr.Read())
                cd_evento = dr.GetInt32(0)
                txt_nm_evento.Text = dr.GetString(1)
                txt_ds_evento.Text = dr.GetString(2)
            End While
            dr.Close()
            conexao.Close()
            dtp_evento.UpdateBoldedDates()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub excluir_evento()
        excluido = deletar_cadastro("tb_evento", "cd_evento", cd_evento)
        If excluido = True Then
            atualiza_calendario()
            grb_cadastro.Enabled = False
            excluido = False
            Limpar(Me)
        End If
    End Sub
    Private Sub alteracao_menu_eventos()
        Try
            sql = "SELECT COUNT(*) FROM tb_evento WHERE dt_evento =@pesquisa"

            Dim dia_evento As Date
            dia_evento = FormatDateTime(dtp_evento.SelectionStart, DateFormat.ShortDate)

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@pesquisa", dia_evento))

            Dim dr As SqlDataReader
            conexao.Open()
            dr = comando.ExecuteReader
            While (dr.Read())
                num_evento = dr.GetInt32(0)
            End While
            dr.Close()
            conexao.Close()
        Catch ex As Exception
        End Try
        If num_evento > 0 Then
            mnu_cadastrar.Enabled = False
            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True
            mnu_salvar.Enabled = False
            grb_cadastro.Enabled = False
        Else
            mnu_cadastrar.Enabled = True
            mnu_alterar.Enabled = False
            mnu_excluir.Enabled = False
        End If
        num_evento = 0
    End Sub
End Class