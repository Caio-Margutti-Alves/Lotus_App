Imports System.Data.SqlClient
Public Class Faltas_Professor
    '---Cadastro---'
    Private cd_professor As Integer = 0
    Private tipo_falta As String = ""

    Private dia_mes As String = "01/01/"
    Dim data_completa As Date
    Dim pseudodata_completa As String = ""
    Private data_valida1 As Boolean = False
    Private data_valida2 As Boolean = False
    Private periodo_valido As Boolean = False

    '--Menus--'
    Private mode As String = ""

    '--Alteração e Consulta--'
    Private cd_consulta_professor As Integer = 0
    Private cd_falta As Integer = 0
    Private excluido As Boolean = False


    Private Sub Faltas_Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        txt_ano.Text = Year(Now)
        carrega_professores(cmb_professor)
        carrega_professores(cmb_pesquisa)
    End Sub

    Private Sub mnu_novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_novo.Click
        mode = "Novo"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        limpar2()

    End Sub

    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_alterar.Click
        If lst_consulta.SelectedIndex >= 0 Then
            mode = "Alterar"
            alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        Else
            MessageBox.Show("Selecione um Cadastro para Alterar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub mnu_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_consulta.Click
        mode = "Consulta"
        alteracao_de_menus(mode, grb_cadastro, grb_consulta, mnu_limpar, mnu_alterar, mnu_excluir, mnu_salvar)
        limpar2()
        carrega_dados_consulta()
    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        If lst_consulta.SelectedIndex < 0 Then
            MessageBox.Show("Selecione um Cadastro antes de Excluir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            excluido = deletar_cadastro("tb_faltas_professor", "cd_falta", cd_falta)
            If excluido = True Then
                limpar2()
            End If
            carrega_dados_consulta()
            excluido = False
        End If
    End Sub
    Private Sub mnu_salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_salvar.Click

        If cmb_professor.Text = "" Or txt_data1.MaskFull = False Or (data_valida1 = False And data_valida2 = False) Or (rad_atraso.Checked = False And rad_aula_just.Checked = False And rad_aula_injust.Checked = False And rad_medica.Checked = False And rad_licença.Checked = False And rad_capacitacao.Checked = False And rad_reuniao.Checked = False) Then
            MessageBox.Show("Preencha Corretamente os Campos Assinalados com *!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim inicio As Date
            Dim fim As Date

            If tipo_falta = "Licença Médica" And (data_valida1 = False Or data_valida2 = False) Then
                MessageBox.Show("Preencha o Início e o Término da Licença Médica!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf tipo_falta = "Licença Médica" And data_valida1 = True And data_valida2 = True Then
                periodo_valido = verifica_periodo_tempo(txt_data1, txt_data2)
                If periodo_valido = False Then
                    Exit Sub
                End If
            End If
            If mode = "Novo" Then
                sql = "INSERT INTO tb_faltas_professor (cd_professor,dt_falta1,dt_falta2,ds_obs,ds_tipo_falta) VALUES (@cd_professor,@dt_falta1,@dt_falta2,@ds_obs,@ds_tipo_falta)"
            Else
                sql = "UPDATE tb_faltas_professor SET cd_professor=@cd_professor,dt_falta1=@dt_falta1,dt_falta2=@dt_falta2,ds_obs=@ds_obs,ds_tipo_falta=@ds_tipo_falta WHERE cd_falta = " & cd_falta

            End If

            inicio = FormatDateTime(txt_data1.Text, DateFormat.ShortDate)

            Dim comando As New SqlCommand(sql, conexao)
            comando.Parameters.Add(New SqlParameter("@cd_professor", cd_professor))
            comando.Parameters.Add(New SqlParameter("@dt_falta1", inicio))
            If tipo_falta = "Licença Médica" Then
                fim = FormatDateTime(txt_data2.Text, DateFormat.ShortDate)
                comando.Parameters.Add(New SqlParameter("@dt_falta2", fim))
            Else
                comando.Parameters.Add(New SqlParameter("@dt_falta2", DBNull.Value))
            End If
            comando.Parameters.Add(New SqlParameter("@ds_obs", txt_obs.Text))
            comando.Parameters.Add(New SqlParameter("@ds_tipo_falta", tipo_falta))


            conexao.Open()
            cadastrar_alterar(comando, mnu_limpar, grb_cadastro, mode)
            conexao.Close()
            carrega_dados_consulta()
        End If
    End Sub

    Private Sub cmb_professor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_professor.MouseClick
        carrega_professores(cmb_professor)
        carrega_professores(cmb_pesquisa)
    End Sub

    Private Sub cmb_professor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_professor.SelectedIndexChanged
        cd_professor = cmb_professor.SelectedValue
    End Sub

    Private Sub rad_atraso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_atraso.CheckedChanged
        tipo_falta = "Falta Atraso"
        data_licença_medica()
    End Sub

    Private Sub rad_aula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_aula_just.CheckedChanged
        tipo_falta = "Falta Aula Justificada"
        data_licença_medica()
    End Sub

    Private Sub rad_injustificada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_aula_injust.CheckedChanged
        tipo_falta = "Falta Aula Injustificada"
        data_licença_medica()
    End Sub

    Private Sub rad_reuniao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_reuniao.CheckedChanged
        tipo_falta = "Reunião"
        data_licença_medica()
    End Sub

    Private Sub rad_capacitacao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_capacitacao.CheckedChanged
        tipo_falta = "Capacitação"
        data_licença_medica()
    End Sub

    Private Sub rad_medica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_medica.CheckedChanged
        tipo_falta = "Falta Médica"
        data_licença_medica()
    End Sub

    Private Sub rad_licença_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_licença.CheckedChanged
        tipo_falta = "Licença Médica"
        data_licença_medica()
    End Sub

    Private Sub txt_data1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_data1.TextChanged
        If txt_data1.MaskFull = True Then
            data_valida1 = valida_data(txt_data1)
            If data_valida1 = False Then
                txt_data1.Clear()
            End If
        End If
    End Sub

    Private Sub txt_data2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_data2.TextChanged
        If txt_data2.MaskFull = True Then
            data_valida2 = valida_data(txt_data2)
            If data_valida2 = False Then
                txt_data2.Clear()
            End If
        End If
    End Sub

    Private Sub lst_consulta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_consulta.MouseClick
        carrega_cadastro_consulta()
    End Sub

    Private Sub cmb_pesquisa_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_pesquisa.MouseClick
        carrega_professores(cmb_professor)
        carrega_professores(cmb_pesquisa)
    End Sub

    Private Sub cmb_pesquisa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_pesquisa.SelectedIndexChanged
        cd_consulta_professor = cmb_pesquisa.SelectedValue
        carrega_dados_consulta()
    End Sub

    Private Sub cmb_mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mes.SelectedIndexChanged
        If cmb_mes.SelectedIndex = 0 Then
            dia_mes = "01/01/"
        ElseIf cmb_mes.SelectedIndex = 1 Then
            dia_mes = "02/02/"
        ElseIf cmb_mes.SelectedIndex = 2 Then
            dia_mes = "03/03/"
        ElseIf cmb_mes.SelectedIndex = 3 Then
            dia_mes = "04/04/"
        ElseIf cmb_mes.SelectedIndex = 4 Then
            dia_mes = "05/05/"
        ElseIf cmb_mes.SelectedIndex = 5 Then
            dia_mes = "06/06/"
        ElseIf cmb_mes.SelectedIndex = 6 Then
            dia_mes = "07/07/"
        ElseIf cmb_mes.SelectedIndex = 7 Then
            dia_mes = "08/08/"
        ElseIf cmb_mes.SelectedIndex = 8 Then
            dia_mes = "09/09/"
        ElseIf cmb_mes.SelectedIndex = 9 Then
            dia_mes = "10/10/"
        ElseIf cmb_mes.SelectedIndex = 10 Then
            dia_mes = "11/11/"
        ElseIf cmb_mes.SelectedIndex = 11 Then
            dia_mes = "12/12/"
        End If
        carrega_dados_consulta()
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
        carrega_dados_consulta()
    End Sub

    Private Sub carrega_professores(ByVal combo As ComboBox)
        Dim seleciona As String = "SELECT cd_professor, nm_professor FROM tb_professor"
        Dim dsProfessor As New DataSet()
        Dim daProfessor As New SqlDataAdapter(seleciona, conexao)
        conexao.Open()
        daProfessor.Fill(dsProfessor, "Professor")
        conexao.Close()
        With combo
            .DisplayMember = "nm_professor"
            .ValueMember = "cd_professor"
            .DataSource = dsProfessor.Tables("Professor").DefaultView
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub carrega_dados_consulta()
        Try
            Dim seleciona As String = ""

            If txt_ano.Text = "" Then
                seleciona = pesquisa_sem_ano_digitado(seleciona)
            Else
                seleciona = pesquisa_ano_digitado(seleciona)
            End If

            Dim dsAula As New DataSet()
            Dim daAula As New SqlDataAdapter(seleciona, conexao2)
            conexao2.Open()
            daAula.Fill(dsAula, "Faltas Professores")
            conexao2.Close()
            With Me.lst_consulta
                .DisplayMember = "professor_data"
                .ValueMember = "cd_falta"
                .DataSource = dsAula.Tables("Faltas Professores").DefaultView
                .SelectedIndex = -1
            End With
            dsAula.Dispose()
            daAula.Dispose()
        Catch ex As Exception
            conexao2.Close()
        End Try
    End Sub
    Private Sub carrega_cadastro_consulta()
        cd_falta = lst_consulta.SelectedValue
        Dim seleciona As String = "Select cd_professor,dt_falta1,dt_falta2,ds_obs,ds_tipo_falta FROM tb_faltas_professor Where cd_falta =" & cd_falta & ""
        Dim drCurso As SqlDataReader
        Dim cmdCurso As SqlCommand
        cmdCurso = New SqlCommand(seleciona, conexao)
        conexao.Open()
        drCurso = cmdCurso.ExecuteReader

        If drCurso.Read() Then

            cmb_professor.SelectedValue = drCurso.Item("cd_professor")
            txt_obs.Text = drCurso.Item("ds_obs").ToString
            tipo_falta = drCurso.Item("ds_tipo_falta").ToString
            If tipo_falta = "Falta Atraso" Then
                rad_atraso.Checked = True
            ElseIf tipo_falta = "Falta Aula Justificada" Then
                rad_aula_just.Checked = True
            ElseIf tipo_falta = "Falta Aula Injustificada" Then
                rad_aula_injust.Checked = True
            ElseIf tipo_falta = "Falta Médica" Then
                rad_medica.Checked = True
            ElseIf tipo_falta = "Licença Médica" Then
                rad_licença.Checked = True
            ElseIf tipo_falta = "Capacitação" Then
                rad_capacitacao.Checked = True
            ElseIf tipo_falta = "Reunião" Then
                rad_reuniao.Checked = True
            End If

            txt_data1.Text = drCurso.Item("dt_falta1").ToString
            data_licença_medica()
            txt_data2.Text = drCurso.Item("dt_falta2").ToString

            mnu_alterar.Enabled = True
            mnu_excluir.Enabled = True

        End If

        drCurso.Close()
        conexao.Close()
        cmdCurso.Dispose()
    End Sub

    Private Sub data_licença_medica()
        If rad_licença.Checked = True Then
            lbl_data1.Text = "Início*:"
            lbl_data2.Visible = True
            txt_data2.Visible = True
        Else
            lbl_data1.Text = "Data*:"
            lbl_data2.Visible = False
            txt_data2.Visible = False
        End If
    End Sub

    Private Sub limpar2()
        Limpar(Me)
        rad_atraso.Checked = False
        rad_aula_just.Checked = False
        rad_aula_injust.Checked = False
        rad_medica.Checked = False
        rad_licença.Checked = False
        rad_capacitacao.Checked = False
        rad_reuniao.Checked = False
    End Sub

    Private Function pesquisa_ano_digitado(ByVal seleciona As String)
        pseudodata_completa = dia_mes & txt_ano.Text
        data_completa = FormatDateTime(pseudodata_completa, DateFormat.ShortDate)
        If cmb_mes.SelectedIndex = 12 Then
            seleciona = "SELECT tb_faltas_professor.cd_falta, tb_professor.nm_professor + ' - ' + tb_faltas_professor.ds_tipo_falta + ' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta1,103) " & _
            "+ ISNULL(' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta2,103),'') as professor_data FROM tb_faltas_professor " & _
            "INNER JOIN tb_professor ON tb_faltas_professor.cd_professor = tb_professor.cd_professor " & _
            "WHERE tb_faltas_professor.cd_professor =" & cd_consulta_professor & " AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') " & _
            "ORDER BY tb_faltas_professor.dt_falta1 ASC"
        Else
            seleciona = "SELECT tb_faltas_professor.cd_falta, tb_professor.nm_professor + ' - ' + tb_faltas_professor.ds_tipo_falta + ' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta1,103) " & _
            "+ ISNULL(' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta2,103),'') as professor_data FROM tb_faltas_professor " & _
            "INNER JOIN tb_professor ON tb_faltas_professor.cd_professor = tb_professor.cd_professor " & _
            "WHERE tb_faltas_professor.cd_professor =" & cd_consulta_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
            "AND DatePart(YEAR,tb_faltas_professor.dt_falta1) = DatePart(YEAR,'" & data_completa & "') " & _
            "ORDER BY tb_faltas_professor.dt_falta1 ASC "
        End If
        Return seleciona
    End Function
    Private Function pesquisa_sem_ano_digitado(ByVal seleciona As String)
        pseudodata_completa = dia_mes & Year(Now)
        data_completa = FormatDateTime(pseudodata_completa, DateFormat.ShortDate)
        If cmb_mes.SelectedIndex = 12 Then
            seleciona = "SELECT tb_faltas_professor.cd_falta, tb_professor.nm_professor + ' - ' + tb_faltas_professor.ds_tipo_falta + ' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta1,103) " & _
            "+ ISNULL(' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta2,103),'') as professor_data FROM tb_faltas_professor " & _
            "INNER JOIN tb_professor ON tb_faltas_professor.cd_professor = tb_professor.cd_professor " & _
            "WHERE tb_faltas_professor.cd_professor =" & cd_consulta_professor & _
            " ORDER BY tb_faltas_professor.dt_falta1 ASC"
        Else
            seleciona = "SELECT tb_faltas_professor.cd_falta, tb_professor.nm_professor + ' - ' + tb_faltas_professor.ds_tipo_falta + ' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta1,103) " & _
            "+ ISNULL(' - ' + CONVERT(VARCHAR(10),tb_faltas_professor.dt_falta2,103),'') as professor_data FROM tb_faltas_professor " & _
            "INNER JOIN tb_professor ON tb_faltas_professor.cd_professor = tb_professor.cd_professor " & _
            "WHERE tb_faltas_professor.cd_professor =" & cd_consulta_professor & " AND DatePart(Month, tb_faltas_professor.dt_falta1) = DatePart(Month,'" & data_completa & "') " & _
            "ORDER BY tb_faltas_professor.dt_falta1 ASC "
        End If
        Return seleciona
    End Function
End Class