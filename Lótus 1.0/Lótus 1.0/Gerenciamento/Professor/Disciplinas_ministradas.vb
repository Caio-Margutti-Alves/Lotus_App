Imports System.Data.SqlClient
Public Class Disciplinas_ministradas

    '--Cadastro--'
    Private cd_professor As Integer = 0
    Private cd_disciplina_ministrada As Integer = 0
    Private cd_modulo As Integer = 0
    Private cd_disciplina As Integer = 0
    Private cd_curso As Integer = 0
    Private cd_turma As Integer = 0
    Private num_prof As Integer = 0

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Aulas_ministradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carrega_professores()
        carrega_turmas()
    End Sub

    Private Sub cmb_professor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_professor.MouseClick
        carrega_professores()
    End Sub

    Private Sub cmb_professor_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_professor.SelectedIndexChanged
        cd_professor = cmb_professor.SelectedValue
        carrega_disciplinas_ministradas()
        carrega_disciplinas()
    End Sub

    Private Sub cmb_turma_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_turma.MouseClick
        carrega_turmas()
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        cd_turma = cmb_turma.SelectedValue
        carregar_curso_e_modulo()
        carrega_disciplinas()
    End Sub

    Private Sub cmb_disciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_disciplina.SelectedIndexChanged
        cd_disciplina = cmb_disciplina.SelectedValue
    End Sub

    Private Sub btn_add_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_disciplina.Click
        adcionar_disciplina_ministrada()
    End Sub

    Private Sub btn_rmv_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmv_disciplina.Click
        If lst_disciplinas_ministradas.SelectedIndex >= 0 Then
            excluir_disciplina_ministrada()
        Else
            MessageBox.Show("Selecione um Registro para ser Deletado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub carrega_professores()
        Dim seleciona As String = "SELECT cd_professor, nm_professor FROM tb_professor"
        Dim dsProfessor As New DataSet()
        Dim daProfessor As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daProfessor.Fill(dsProfessor, "Professor")
        conexao2.Close()
        With Me.cmb_professor
            .DisplayMember = "nm_professor"
            .ValueMember = "cd_professor"
            .DataSource = dsProfessor.Tables("Professor").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_turmas()
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

    Private Sub carregar_curso_e_modulo()
        Dim seleciona As String = "Select cd_curso,cd_modulo FROM tb_turma WHERE cd_turma=" & cd_turma
        Dim comando As New SqlCommand(seleciona, conexao2)
        Dim drCurso As SqlDataReader
        conexao2.Open()
        drCurso = comando.ExecuteReader
        If drCurso.Read() Then
            cd_curso = drCurso.GetInt32(0)
            cd_modulo = drCurso.GetInt32(1)
        End If
        conexao2.Close()
    End Sub

    Private Sub carrega_disciplinas()
        Dim seleciona As String = "SELECT tb_disciplina.sg_disciplina,tb_disciplina.cd_disciplina FROM tb_disciplina " & _
        "INNER JOIN tb_juncao_disciplina_modulo_curso on tb_disciplina.cd_disciplina = tb_juncao_disciplina_modulo_curso.cd_disciplina " & _
        "INNER JOIN tb_juncao_modulo_curso on tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
        "WHERE tb_disciplina.cd_disciplina NOT IN(SELECT tb_disciplina_ministrada.cd_disciplina FROM tb_disciplina_ministrada WHERE tb_disciplina_ministrada.cd_professor =" & cd_professor & ") " & _
        "AND tb_juncao_disciplina_modulo_curso.cd_modulo =" & cd_modulo & _
        "AND tb_juncao_modulo_curso.cd_curso =" & cd_curso

        Dim dsDisciplina As New DataSet()
        Dim daDisciplina As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daDisciplina.Fill(dsDisciplina, "Disciplina")
        conexao2.Close()
        With Me.cmb_disciplina
            .DisplayMember = "sg_disciplina"
            .ValueMember = "cd_disciplina"
            .DataSource = dsDisciplina.Tables("Disciplina").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_disciplinas_ministradas()
        Dim seleciona As String = "SELECT cd_disciplina_ministrada, ds_disciplina_ministrada FROM tb_disciplina_ministrada WHERE cd_professor =" & cd_professor
        Dim dsDisciplina As New DataSet()
        Dim daDisciplina As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daDisciplina.Fill(dsDisciplina, "Disciplina_Ministrada")
        conexao2.Close()
        With Me.lst_disciplinas_ministradas
            .DisplayMember = "ds_disciplina_ministrada"
            .ValueMember = "cd_disciplina_ministrada"
            .DataSource = dsDisciplina.Tables("Disciplina_Ministrada").DefaultView
            .SelectedIndex = -1
        End With
        dsDisciplina.Dispose()
        daDisciplina.Dispose()

    End Sub

    Private Sub adcionar_disciplina_ministrada()
        If cmb_professor.SelectedIndex = -1 Or cmb_turma.SelectedIndex = -1 Or cmb_disciplina.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o Professor, a Turma e a Disciplina antes de Inserir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            verifica_num_prof()
            If num_prof > 0 Then
                If MessageBox.Show("Já existe(m) " & num_prof & " Professor(es) ministrando essa Disciplina nessa Turma. Deseja adicionar mais um?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim linhas As Integer = 0
                    Try
                        sql = "INSERT INTO tb_disciplina_ministrada (ds_disciplina_ministrada,cd_disciplina,cd_professor,cd_turma) values('" & cmb_disciplina.Text & " - " & cmb_turma.Text & "'," & cmb_disciplina.SelectedValue & "," & cmb_professor.SelectedValue & "," & cd_turma & ")"
                        Dim comando As New SqlCommand(sql, conexao)
                        conexao.Open()
                        linhas = comando.ExecuteNonQuery()
                        conexao.Close()
                        num_prof = 0
                    Catch ex As Exception
                        MessageBox.Show("Erro ao Inserir no Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    If linhas <> 0 Then
                        MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        carrega_disciplinas_ministradas()
                        carrega_disciplinas()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub excluir_disciplina_ministrada()
        excluido = deletar_cadastro("tb_disciplina_ministrada", "cd_disciplina_ministrada", lst_disciplinas_ministradas.SelectedValue)
        If excluido = True Then
            carrega_disciplinas_ministradas()
            excluido = False
            carrega_disciplinas()
        End If
    End Sub

    Private Sub verifica_num_prof()
        sql = "SELECT COUNT(*) FROM tb_disciplina_ministrada WHERE cd_turma =" & cd_turma & " AND cd_disciplina =" & cd_disciplina
        Dim comando As New SqlCommand(sql, conexao)
        Dim dr As SqlDataReader
        conexao.Open()
        dr = comando.ExecuteReader()
        If dr.Read() Then
            num_prof = dr.GetInt32(0)
        End If
        conexao.Close()
    End Sub
End Class