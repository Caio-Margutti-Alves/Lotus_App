Imports System.Data.SqlClient
Public Class Turma


    '--Cadastro--'
    Private cd_turma As Integer = 0
    Private cd_curso As Integer = 0
    Private cd_periodo As Integer = 0
    Private data_valida1 As Boolean = False
    Private data_valida2 As Boolean = False
    Private periodo_valido As Boolean = False

    '--Menus--'
    Private mode As String = ""

    '-- Exclusão--'
    Private excluido As Boolean = False

    Private Sub Cadastrar_Turma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carrega_cursos()
    End Sub

    Private Sub mnu_cadastrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        Limpar(Me)
        txt_ano.Text = Year(Now)
    End Sub

    Private Sub mnu_alterar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        mode = "Alterar"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
    End Sub

    Private Sub mnu_consulta_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        rad_nome.Checked = True
        carregar_dados_consulta()
    End Sub

    Private Sub mnu_limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_limpar.Click
        Limpar(Me)
    End Sub
    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta_turma.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = (deletar_cadastro("tb_turma", "cd_turma", cd_turma))
            If excluido = True Then
                Limpar(Me)
            End If
            carregar_dados_consulta()
            excluido = False
        End If
    End Sub

    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click
        valida_ano(txt_ano)
        If txt_nome.Text = "" Or txt_ano.Text = "" Or txt_inicio.MaskFull = False Or txt_fim.MaskFull = False Or cmb_curso.Text = "" Or cmb_modulo.Text = "" Or cmb_semestre.Text = "" Then
            MessageBox.Show("Preencha os Campos Assinalados com *!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            periodo_valido = verifica_periodo_tempo(txt_inicio, txt_fim)
            If periodo_valido = True Then
                If mode = "Novo" Then
                    sql = "INSERT INTO tb_turma (nm_turma,cd_periodo,cd_modulo,cd_curso,cd_semestre,dt_ano,dt_inisemestre,dt_fimsemestre) VALUES (@nm_turma,@cd_periodo,@cd_modulo,@cd_curso,@cd_semestre,@dt_ano,@dt_inisemestre,@dt_fimsemestre)"
                Else
                    sql = "UPDATE tb_turma SET nm_turma = @nm_turma, cd_periodo= @cd_periodo,cd_modulo=@cd_modulo,cd_curso=@cd_curso,cd_semestre=@cd_semestre,dt_ano=@dt_ano,dt_inisemestre=@dt_inisemestre,dt_fimsemestre=@dt_fimsemestre WHERE cd_turma = " & cd_turma
                End If

                Dim inicio As Date
                inicio = FormatDateTime(txt_inicio.Text, DateFormat.ShortDate)
                Dim fim As Date
                fim = FormatDateTime(txt_fim.Text, DateFormat.ShortDate)

                Dim comando As New SqlCommand(sql, conexao)
                comando.Parameters.Add(New SqlParameter("@nm_turma", txt_nome.Text))
                comando.Parameters.Add(New SqlParameter("@cd_periodo", cd_periodo))
                comando.Parameters.Add(New SqlParameter("@cd_modulo", cmb_modulo.SelectedValue))
                comando.Parameters.Add(New SqlParameter("@cd_curso", cmb_curso.SelectedValue))
                comando.Parameters.Add(New SqlParameter("@cd_semestre", cmb_semestre.SelectedIndex + 1))
                comando.Parameters.Add(New SqlParameter("@dt_ano", txt_ano.Text))
                comando.Parameters.Add(New SqlParameter("@dt_inisemestre", inicio))
                comando.Parameters.Add(New SqlParameter("@dt_fimsemestre", fim))

                conexao.Open()
                cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
                conexao.Close()
                carregar_dados_consulta()
            End If
        End If
    End Sub

    Private Sub cmb_curso_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_curso.MouseClick
        carrega_cursos()
    End Sub

    Private Sub cmb_curso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_curso.SelectedIndexChanged
        cd_curso = cmb_curso.SelectedValue
        carrega_modulos()
        carrega_periodos()
    End Sub

    Private Sub txt_ano_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ano.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ano_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ano.TextChanged
        negar_car(txt_ano)
    End Sub

    Private Sub txt_inicio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_inicio.TextChanged
        If txt_inicio.MaskFull = True Then
            data_valida1 = valida_data(txt_inicio)
            If data_valida1 = False Then
                txt_inicio.Clear()
            End If
        End If
    End Sub

    Private Sub txt_fim_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_fim.TextChanged
        If txt_fim.MaskFull = True Then
            data_valida2 = valida_data(txt_fim)
            If data_valida2 = False Then
                txt_fim.Clear()
            End If
        End If
    End Sub

    Private Sub txtpesquisa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pesquisa.TextChanged
        carregar_dados_consulta()
    End Sub

    Private Sub lstpesquisa_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta_turma.MouseClick

        If lst_consulta_turma.SelectedIndex >= 0 Then
            cd_turma = lst_consulta_turma.SelectedValue

            Dim seleciona As String = "Select cd_turma, nm_turma, cd_periodo, cd_modulo, cd_curso, cd_semestre, dt_ano, dt_inisemestre,dt_fimsemestre FROM tb_turma Where cd_turma = " & cd_turma & ""
            Dim drTurma As SqlDataReader
            Dim cmdTurma As SqlCommand
            cmdTurma = New SqlCommand(seleciona, conexao)
            conexao.Open()
            drTurma = cmdTurma.ExecuteReader

            If drTurma.Read() Then
                cd_turma = drTurma.Item("cd_turma")
                txt_nome.Text = drTurma.Item("nm_turma").ToString
                cmb_curso.SelectedValue = drTurma.Item("cd_curso")
                cmb_modulo.SelectedValue = drTurma.Item("cd_modulo")
                cmb_semestre.SelectedIndex = drTurma.Item("cd_semestre") - 1
                cd_periodo = drTurma.Item("cd_periodo")
                If cd_periodo = 1 Then
                    cmb_periodo.SelectedItem = "Matutino"
                ElseIf cd_periodo = 2 Then
                    cmb_periodo.SelectedItem = "Vespertino"
                ElseIf cd_periodo = 3 Then
                    cmb_periodo.SelectedItem = "Noturno"
                End If
                txt_ano.Text = drTurma.Item("dt_ano").ToString

                txt_inicio.Text = CDate(drTurma.Item("dt_inisemestre")).ToString("dd/MM/yyyy")
                txt_fim.Text = CDate(drTurma.Item("dt_fimsemestre")).ToString("dd/MM/yyyy")

            End If

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True

            drTurma.Close()
            conexao.Close()
            cmdTurma.Dispose()
        End If
    End Sub

    Private Sub carregar_dados_consulta()

        Dim seleciona As String = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma " & _
            "INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso WHERE nm_turma Like @pesquisa ORDER BY nm_curso"
        If rad_nome.Checked = True Then
            seleciona = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma " & _
            "INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso WHERE nm_turma Like @pesquisa ORDER BY nm_curso"
        ElseIf rad_curso.Checked = True Then
            seleciona = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre  FROM tb_turma INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso WHERE tb_curso.nm_curso Like @pesquisa ORDER BY nm_curso"
        ElseIf rad_ano.Checked = True Then
            seleciona = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre  FROM tb_turma INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso WHERE dt_ano Like @pesquisa ORDER BY nm_curso"
        ElseIf rad_modulo.Checked = True Then
            seleciona = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre  FROM tb_turma INNER JOIN tb_juncao_modulo_curso on tb_turma.cd_modulo = tb_juncao_modulo_curso.cd_modulo INNER JOIN tb_curso on tb_turma.cd_curso = tb_curso.cd_curso WHERE tb_juncao_modulo_curso.ds_modulo Like @pesquisa ORDER BY nm_curso"
        End If

        Dim comando As New SqlCommand(seleciona, conexao)
        comando.Parameters.Add(New SqlParameter("@pesquisa", String.Format("%{0}%", txt_pesquisa.Text)))

        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(comando)

        conexao.Open()
        daTurma.Fill(dsTurma, "Turma")
        conexao.Close()
        With Me.lst_consulta_turma
            .DisplayMember = "turma_data_semestre"
            .ValueMember = "cd_turma"
            .DataSource = dsTurma.Tables("Turma").DefaultView
        End With
    End Sub

    Private Sub carrega_cursos()
        Dim seleciona As String = "Select cd_curso, nm_curso FROM tb_curso"
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

    Private Sub carrega_periodos()
        Dim seleciona = "Select cd_manha, cd_tarde, cd_noite FROM tb_curso WHERE cd_curso =" & cd_curso
        Dim comando As New SqlCommand(seleciona, conexao2)
        Dim dr As SqlDataReader
        conexao2.Open()
        dr = comando.ExecuteReader()
        cmb_periodo.Items.Clear()
        While (dr.Read())
            If dr.GetBoolean(0) = True Then
                cmb_periodo.Items.Add("Matutino")
            End If
            If dr.GetBoolean(1) = True Then
                cmb_periodo.Items.Add("Vespertino")
            End If
            If dr.GetBoolean(2) = True Then
                cmb_periodo.Items.Add("Noturno")
            End If
        End While

        conexao2.Close()
    End Sub

    Private Sub cmb_periodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_periodo.SelectedIndexChanged
        If cmb_periodo.SelectedText = "Matutino" Then
            cd_periodo = 1
        ElseIf cmb_periodo.SelectedText = "Vespertino" Then
            cd_periodo = 2
        ElseIf cmb_periodo.SelectedText = "Noturno" Then
            cd_periodo = 3
        End If
    End Sub
End Class