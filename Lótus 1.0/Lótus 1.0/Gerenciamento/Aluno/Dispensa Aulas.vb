Imports System.Data.SqlClient
Public Class Dispensa_Aulas

    '--Cadastro--'

    Private cd_disciplina As Integer = 0
    Private cd_turma As Integer = 0
    Private cd_aluno As Integer = 0
    Private cd_aluno_turma As Integer = 0
    Private sigla_disciplina As String = Nothing

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Dispensa_Aulas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carrega_turmas()
    End Sub

    Private Sub cmb_turma_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_turma.MouseClick
        carrega_turmas()
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        clb_disciplinas.Items.Clear()
        cd_turma = cmb_turma.SelectedValue
        carrega_alunos_turma()
    End Sub

    Private Sub lst_alunos_turma_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_alunos_turma.MouseClick
        cd_aluno = lst_alunos_turma.SelectedValue
        carrega_dispensas_aluno()
    End Sub

    Private Sub carrega_turmas()
        Dim seleciona As String = "Select cd_turma,nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma"
        Dim comando As New SqlCommand(seleciona, conexao)
        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(comando)
        conexao.Close()
        conexao.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao.Close()
        With Me.cmb_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_alunos_turma()
        Dim seleciona As String = "SELECT tb_aluno.cd_aluno, tb_aluno.nm_aluno FROM tb_juncao_turma_aluno " & _
        "INNER JOIN tb_turma ON tb_juncao_turma_aluno.cd_turma = tb_turma.cd_turma " & _
        "INNER JOIN tb_aluno ON tb_juncao_turma_aluno.cd_aluno = tb_aluno.cd_aluno " & _
        "Where tb_turma.cd_turma = " & cd_turma

        Dim dsAluno_Turma As New DataSet()
        Dim daAluno_Turma As New SqlDataAdapter(seleciona, conexao)
        conexao.Close()
        conexao.Open()
        daAluno_Turma.Fill(dsAluno_Turma, "Aluno_Turma")
        conexao.Close()
        With Me.lst_alunos_turma
            .DisplayMember = "nm_aluno"
            .ValueMember = "cd_aluno"
            .DataSource = dsAluno_Turma.Tables("Aluno_Turma").DefaultView
            .SelectedIndex = -1
        End With
        dsAluno_Turma.Dispose()
        daAluno_Turma.Dispose()

    End Sub

    Private Sub carrega_dispensas_aluno()
        clb_disciplinas.Items.Clear()
        Dim seleciona = "SELECT tb_disciplina.cd_disciplina, tb_disciplina.sg_disciplina FROM tb_disciplina " & _
        "INNER JOIN tb_juncao_disciplina_modulo_curso ON tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
        "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
        "INNER JOIN tb_turma ON tb_juncao_modulo_curso.cd_modulo = tb_turma.cd_modulo " & _
        "WHERE tb_turma.cd_turma =" & cd_turma

        Dim comando As New SqlCommand(seleciona, conexao)
        conexao.Close()
        conexao.Open()
        Dim dr As SqlDataReader = comando.ExecuteReader()

        While dr.Read()
            conexao2.Open()
            sql = "SELECT COUNT(*) FROM tb_dispensa WHERE cd_disciplina =" & dr.GetInt32(0) & " AND cd_aluno = " & cd_aluno
            Dim comando2 As New SqlCommand(sql, conexao2)
            Dim dr2 As SqlDataReader = comando2.ExecuteReader
            dr2.Read()
            If dr2.GetInt32(0) > 0 Then
                conexao2.Close()
                clb_disciplinas.Items.Add(dr.GetString(1), True)
            Else
                conexao2.Close()
                clb_disciplinas.Items.Add(dr.GetString(1), False)
            End If
        End While
        conexao.Close()

    End Sub

    Private Sub clb_disciplinas_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clb_disciplinas.ItemCheck
        If e.NewValue = CheckState.Checked Then
            Try
                conexao2.Open()
                sql = "SELECT cd_disciplina FROM tb_disciplina WHERE sg_disciplina ='" & clb_disciplinas.SelectedItem & "'"
                Dim comando As New SqlCommand(sql, conexao2)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    Dim sql2 As String = "INSERT INTO tb_dispensa VALUES(" & lst_alunos_turma.SelectedValue() & "," & dr.GetInt32(0) & ")"
                    Dim comando2 As New SqlCommand(sql2, conexao3)
                    cadastrar_simples(comando2)
                End While
                dr.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            conexao2.Close()
        Else
            Try
                conexao2.Open()
                sql = "SELECT cd_disciplina FROM tb_disciplina WHERE sg_disciplina ='" & clb_disciplinas.SelectedItem & "'"
                Dim comando As New SqlCommand(sql, conexao2)
                Dim dr As SqlDataReader = comando.ExecuteReader
                While dr.Read
                    Dim sql2 As String = "DELETE FROM tb_dispensa WHERE cd_disciplina = " & dr.GetInt32(0) & " AND cd_aluno=" & lst_alunos_turma.SelectedValue() & ""
                    Dim comando2 As New SqlCommand(sql2, conexao3)
                    deletar_simples(comando2)
                End While
                dr.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            conexao2.Close()
        End If
    End Sub
End Class