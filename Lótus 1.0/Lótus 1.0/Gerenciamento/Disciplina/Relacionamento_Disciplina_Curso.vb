Imports System.Data.SqlClient
Public Class Relacionamento_Disciplina_Curso

    '--Cadastro--'
    Private cd_disciplina As Integer = 0
    Private cd_curso As Integer = 0
    Private cd_modulo As Integer = 0
    Private sg_disciplina As String = ""

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Juncao_Disciplina_Curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
    End Sub

    Private Sub cmb_disciplina_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_disciplina.MouseClick
        carrega_disciplinas()
    End Sub

    Private Sub cmb_disciplina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_disciplina.SelectedIndexChanged
        cd_disciplina = cmb_disciplina.SelectedValue
        pega_sigla()
        carrega_relacionamento_disciplinas_cursos()
        carrega_cursos()
    End Sub

    Private Sub cmb_curso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_curso.SelectedIndexChanged
        cd_curso = cmb_curso.SelectedValue
        carrega_modulos()
    End Sub

    Private Sub cmb_modulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_modulo.SelectedIndexChanged
        cd_modulo = cmb_modulo.SelectedValue
    End Sub

    Private Sub btn_add_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_disciplina.Click
        adcionar_relacionamento()
        carrega_cursos()
    End Sub

    Private Sub btn_rmv_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmv_disciplina.Click
        If lst_relacionamento.SelectedIndex >= 0 Then
            excluir_relacionamento()
            carrega_cursos()
        Else
            MessageBox.Show("Selecione um Registro para ser Deletado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub carrega_disciplinas()
        Dim seleciona As String = "SELECT cd_disciplina, nm_disciplina FROM tb_disciplina ORDER BY nm_disciplina"
        Dim dsDisciplina As New DataSet()
        Dim daDisciplina As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daDisciplina.Fill(dsDisciplina, "Disciplina")
        conexao2.Close()
        With Me.cmb_disciplina
            .DisplayMember = "nm_disciplina"
            .ValueMember = "cd_disciplina"
            .DataSource = dsDisciplina.Tables("Disciplina").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub pega_sigla()
        Dim seleciona As String = "SELECT sg_disciplina FROM tb_disciplina WHERE cd_disciplina = " & cd_disciplina
        Dim comando As New SqlCommand(seleciona, conexao2)
        Dim drDisciplina As SqlDataReader
        conexao2.Open()
        drDisciplina = comando.ExecuteReader
        If drDisciplina.Read() Then
            sg_disciplina = drDisciplina.GetString(0)
        End If
        conexao2.Close()
    End Sub

    Private Sub carrega_cursos()
        Dim seleciona As String = "SELECT tb_curso.cd_curso, tb_curso.nm_curso FROM tb_curso " & _
        "WHERE NOT EXISTS(SELECT tb_juncao_disciplina_modulo_curso.cd_juncao_disciplina_modulo_curso, " & _
        "tb_juncao_disciplina_modulo_curso.ds_juncao_disciplina_modulo_curso, " & _
        "tb_juncao_disciplina_modulo_curso.cd_disciplina, tb_juncao_disciplina_modulo_curso.cd_modulo " & _
        "FROM tb_juncao_disciplina_modulo_curso " & _
        "INNER JOIN tb_juncao_modulo_curso ON tb_juncao_disciplina_modulo_curso.cd_modulo = tb_juncao_modulo_curso.cd_modulo " & _
        "WHERE tb_juncao_modulo_curso.cd_curso=tb_curso.cd_curso AND tb_juncao_disciplina_modulo_curso.cd_disciplina= " & cd_disciplina & ")"

        Dim dsCurso As New DataSet()
        Dim daCurso As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daCurso.Fill(dsCurso, "Curso")
        conexao2.Close()
        With Me.cmb_curso
            .DisplayMember = "nm_curso"
            .ValueMember = "cd_curso"
            .DataSource = dsCurso.Tables("Curso").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_modulos()
        Dim seleciona = "Select cd_modulo, ds_modulo FROM tb_juncao_modulo_curso WHERE cd_curso =" & cd_curso
        Dim dsModulo As New DataSet()
        Dim daModulo As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daModulo.Fill(dsModulo, "Modulo")
        conexao2.Close()
        With Me.cmb_modulo
            .DisplayMember = "ds_modulo"
            .ValueMember = "cd_modulo"
            .DataSource = dsModulo.Tables("Modulo").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_relacionamento_disciplinas_cursos()

        Dim seleciona As String = "SELECT cd_juncao_disciplina_modulo_curso, ds_juncao_disciplina_modulo_curso FROM tb_juncao_disciplina_modulo_curso WHERE cd_disciplina =" & cd_disciplina
        Dim dsRelacionamento As New DataSet()
        Dim daRelacionamento As New SqlDataAdapter(seleciona, conexao2)
        conexao2.Open()
        daRelacionamento.Fill(dsRelacionamento, "Relacionamento")
        conexao2.Close()
        With Me.lst_relacionamento
            .DisplayMember = "ds_juncao_disciplina_modulo_curso"
            .ValueMember = "cd_juncao_disciplina_modulo_curso"
            .DataSource = dsRelacionamento.Tables("Relacionamento").DefaultView
            .SelectedIndex = -1
        End With
        dsRelacionamento.Dispose()
        daRelacionamento.Dispose()

    End Sub
    Private Sub adcionar_relacionamento()
        If cmb_disciplina.SelectedIndex = -1 Or cmb_curso.SelectedIndex = -1 Or cmb_modulo.SelectedIndex = -1 Then
            MessageBox.Show("Selecione a Disciplina, o Curso e o Módulo antes de Inserir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim linhas As Integer = 0
            Try
                sql = "INSERT INTO tb_juncao_disciplina_modulo_curso (ds_juncao_disciplina_modulo_curso,cd_disciplina,cd_modulo) values('" & sg_disciplina & " - " & cmb_curso.Text & " - " & cmb_modulo.Text & "'," & cd_disciplina & "," & cd_modulo & ")"
                Dim comando As New SqlCommand(sql, conexao)
                conexao.Open()
                linhas = comando.ExecuteNonQuery()
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show("Erro ao Inserir no Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If linhas <> 0 Then
                MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_relacionamento_disciplinas_cursos()
            End If
        End If
    End Sub

    Private Sub excluir_relacionamento()

        excluido = deletar_cadastro("tb_juncao_disciplina_modulo_curso", "cd_juncao_disciplina_modulo_curso", lst_relacionamento.SelectedValue)
        If excluido = True Then
            carrega_relacionamento_disciplinas_cursos()
            excluido = False
        End If
    End Sub
End Class