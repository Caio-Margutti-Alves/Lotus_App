Imports System.Data.SqlClient

Module funcoes_bd

    Public conexao As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
    Public conexao2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")
    Public conexao3 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\database\db_lotus.mdf;Integrated Security=True;User Instance=True")

    Public sql As String = ""
    Sub cadastrar_simples(ByVal comando As SqlCommand)
        Try
            conexao3.Open()
            comando.ExecuteNonQuery()
            conexao3.Close()
            MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao Inserir no Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexao3.Close()
        End Try
    End Sub
    Sub alterar_simples(ByVal comando As SqlCommand)
        Try
            conexao3.Open()
            comando.ExecuteNonQuery()
            conexao3.Close()
            MessageBox.Show("Alteração Realizada Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao Alterar no Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexao3.Close()
        End Try
    End Sub
    Sub deletar_simples(ByVal comando As SqlCommand)
        Try
            conexao3.Open()
            comando.ExecuteNonQuery()
            conexao3.Close()
            MessageBox.Show("Deletado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao Deletar do Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexao3.Close()
        End Try
    End Sub

    Sub cadastrar_alterar(ByVal comando As SqlCommand, ByVal menu As ToolStripMenuItem, ByVal Group As GroupBox, ByVal mode As String)
        Try
            Dim linhasAfetadas As Integer = 0
            linhasAfetadas = comando.ExecuteNonQuery()
            conexao.Close()
            tipo_operacao(linhasAfetadas, mode, menu, Group)
        Catch ex As Exception
            MessageBox.Show("Erro ao Inserir no Banco de Dados: " + vbNewLine + ex.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexao.Close()
        End Try
    End Sub

    Sub tipo_operacao(ByVal linhas As Integer, ByVal mode As String, ByVal menu As ToolStripMenuItem, ByVal Group As GroupBox)
        If linhas <> 0 Then
            If mode = "Novo" Then
                MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Alteração Realizada Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            menu.Visible = False
            Group.Enabled = False
        End If
    End Sub

    Public Function deletar_cadastro(ByVal nome_tabela As String, ByVal nome_campo As String, ByVal cd_campo As Integer) As Boolean
        Try
            If MessageBox.Show("Tem certeza que deseja Excluir esse Cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sql = "DELETE FROM " & nome_tabela & " WHERE " & nome_campo & " = " & cd_campo
                Dim comando As New SqlCommand(sql, conexao)
                Dim linhasAfetadas As Integer = 0
                conexao.Open()
                linhasAfetadas = comando.ExecuteNonQuery()
                conexao.Close()
                If linhasAfetadas <> 0 Then
                    MessageBox.Show("Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    MessageBox.Show("Erro ao Excluir o Registro", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Function

    Public Sub BackupDatabase(ByVal nomeDB As String, ByVal destino As String)
        Try
            conexao.Close()
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & nomeDB & "] TO DISK = '" & destino & "'", conexao)
            conexao.Open()
            cmdBackup.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub

    Public Sub RestauraDatabase(ByVal nomeDB As String, ByVal backupFile As String)
        Try
            conexao.Close()
            Dim cmdBackup As New SqlClient.SqlCommand("Use master  RESTORE DATABASE [" & nomeDB & "] FROM DISK = '" & backupFile & "' WITH FILE = 1, REPLACE ", conexao)
            conexao.Open()
            cmdBackup.ExecuteNonQuery()
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexao.Close()
        End Try
    End Sub
End Module
