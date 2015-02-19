Imports System.Data.SqlClient
Public Class Aluno_Turma

    '--Cadastro--'
    Private cd_turma As Integer = 0
    Private cd_aluno As Integer = 0
    Private cd_aluno_turma As Integer = 0

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Aluno_Turma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carregar_turmas()
    End Sub

    Private Sub cmb_turma_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_turma.MouseClick
        carregar_turmas()
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        cd_turma = cmb_turma.SelectedValue
        carregar_alunos()
        carregar_alunos_turma()
        carrega_numero_alunos()
    End Sub

    Private Sub txt_pesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        carregar_alunos()
    End Sub
    Private Sub lst_aluno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_aluno.SelectedIndexChanged
        cd_aluno = lst_aluno.SelectedValue
    End Sub

    Private Sub lst_aluno_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_alunos_turma.SelectedIndexChanged
        cd_aluno_turma = lst_alunos_turma.SelectedValue
    End Sub

    Private Sub btn_add_aluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_aluno.Click
        adcionar_aluno_turma()
        carrega_numero_alunos()
    End Sub

    Private Sub btn_rmv_aluno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmv_aluno.Click
        If lst_alunos_turma.SelectedIndex >= 0 Then
            excluir_aluno_turma()
            carrega_numero_alunos()
        Else
            MessageBox.Show("Selecione um Registro para ser Deletado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btn_rmv_todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmv_todos.Click
        If lst_alunos_turma.Items.Count = 0 Then
            MessageBox.Show("Não há Alunos nessa Turma", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluir_todos()
            carregar_alunos()
            carregar_alunos_turma()
            carrega_numero_alunos()
        End If
    End Sub

    Private Sub carregar_turmas()
        Dim seleciona As String = "Select cd_turma,nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma"
        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao2.Close()
        With Me.cmb_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Sub carregar_alunos()
        Dim seleciona As String = "SELECT tb_aluno.cd_aluno, tb_aluno.nm_aluno FROM tb_aluno " & _
        "WHERE tb_aluno.cd_aluno NOT IN(SELECT tb_juncao_turma_aluno.cd_aluno From tb_juncao_turma_aluno " & _
        "WHERE tb_juncao_turma_aluno.cd_turma = " & cd_turma & ") " & _
        "AND tb_aluno.nm_aluno Like @pesquisa " & _
        "ORDER BY tb_aluno.nm_aluno ASC"

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsAluno As New DataSet()
        Dim daAluno As New SqlDataAdapter(comando)
        conexao2.Open()
        daAluno.Fill(dsAluno, "Aluno")
        conexao2.Close()
        With Me.lst_aluno
            .DisplayMember = "nm_aluno"
            .ValueMember = "cd_aluno"
            .DataSource = dsAluno.Tables("Aluno").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carregar_alunos_turma()
        Dim seleciona As String = "SELECT tb_aluno.cd_aluno, tb_aluno.nm_aluno as numero_aluno " & _
        "FROM tb_juncao_turma_aluno " & _
        "INNER JOIN tb_turma ON tb_juncao_turma_aluno.cd_turma = tb_turma.cd_turma " & _
        "INNER JOIN tb_aluno ON tb_juncao_turma_aluno.cd_aluno = tb_aluno.cd_aluno " & _
        "Where tb_turma.cd_turma = " & cd_turma & " ORDER BY tb_aluno.nm_aluno ASC"

        Dim dsAluno_Turma As New DataSet()
        Dim daAluno_Turma As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daAluno_Turma.Fill(dsAluno_Turma, "Aluno_Turma")
        conexao2.Close()
        With Me.lst_alunos_turma
            .DisplayMember = "numero_aluno"
            .ValueMember = "cd_aluno"
            .DataSource = dsAluno_Turma.Tables("Aluno_Turma").DefaultView
            .SelectedIndex = -1
        End With
        dsAluno_Turma.Dispose()
        daAluno_Turma.Dispose()

    End Sub

    Private Sub adcionar_aluno_turma()
        If cmb_turma.SelectedIndex = -1 Or lst_aluno.SelectedIndex < 0 Then
            MessageBox.Show("Selecione a Turma e o Aluno a ser Adicionado nela", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim linhas As Integer = 0
            Try
 
                sql = "INSERT INTO tb_juncao_turma_aluno (cd_turma, cd_aluno) values(" & cd_turma & "," & cd_aluno & ")"
                Dim comando As New SqlCommand(sql, conexao)

                If conexao.State = ConnectionState.Closed Then
                    conexao.Open()
                End If
                linhas = comando.ExecuteNonQuery()
                conexao.Close()

            Catch ex As Exception
                MessageBox.Show("Erro ao Inserir no Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If linhas <> 0 Then
                carregar_alunos()
                carregar_alunos_turma()
            End If
        End If
    End Sub
   
    Private Sub excluir_aluno_turma()
        If MessageBox.Show("Tem certeza que deseja Excluir esse Cadastro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            sql = "DELETE FROM tb_juncao_turma_aluno WHERE cd_aluno = " & cd_aluno_turma & " AND cd_turma = " & cd_turma
            Dim comando As New SqlCommand(sql, conexao2)
            conexao2.Open()
            comando.ExecuteNonQuery()
            conexao2.Close()
            MessageBox.Show("Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
            excluido = True
        End If
        If excluido = True Then
            carregar_alunos_turma()
            carregar_alunos()
            excluido = False
        End If
    End Sub

    Private Sub excluir_todos()
        If MessageBox.Show("Tem certeza que deseja Excluir Todos os Cadastros desta Turma?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            sql = "DELETE FROM tb_juncao_turma_aluno WHERE cd_turma = " & cd_turma
            Dim comando As New SqlCommand(sql, conexao)
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
            MessageBox.Show("Excluído com Sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
            excluido = True
        End If
        If excluido = True Then
            carregar_alunos_turma()
            carregar_alunos()
            excluido = False
        End If
    End Sub

    Private Sub carrega_numero_alunos()
        sql = "SELECT COUNT(*) FROM tb_juncao_turma_aluno WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao2)
        Dim dr As SqlDataReader
        conexao2.Open()
        dr = comando.ExecuteReader()
        While (dr.Read())
            lbl_numero.Text = dr.GetInt32(0)
        End While
        conexao2.Close()
    End Sub
End Class