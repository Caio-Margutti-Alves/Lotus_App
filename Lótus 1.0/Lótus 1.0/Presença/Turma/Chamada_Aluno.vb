Imports System.Data.SqlClient
Public Class Chamada_Aluno
    Dim data As Date
    Dim codturma As Integer
    Dim p, f As Integer
    Public codcurso As Integer
    Dim qtaula As Integer
    Public diasemana As String
    Private Function pegadata()
        Dim dia As Integer
        Dim mes As Integer
        Dim ano As Integer
        Dim data As Date
        dia = dtpdia.Value.Day
        mes = dtpdia.Value.Month
        ano = dtpdia.Value.Year
        data = dia & "/" & mes & "/" & ano
        data = FormatDateTime(data, DateFormat.ShortDate)
        Return data
    End Function
    Function pegardiasemana()
        diasemana = dtpdia.Value.DayOfWeek.ToString()
        If diasemana = "Monday" Then
            diasemana = "Segunda"
        ElseIf diasemana = "Tuesday" Then
            diasemana = "Terça"
        ElseIf diasemana = "Wednesday" Then
            diasemana = "Quarta"
        ElseIf diasemana = "Thursday" Then
            diasemana = "Quinta"
        ElseIf diasemana = "Friday" Then
            diasemana = "Sexta"
        ElseIf diasemana = "Saturday" Then
            diasemana = "Sabado"
        ElseIf diasemana = "Sunday" Then
            diasemana = "Domingo"
        End If
        lbldiasemana.Text = "Dia: " & diasemana
        Return diasemana
    End Function
    Private Sub carregar_turmas()
        Dim seleciona As String = "Select cd_turma,cd_curso,nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma"
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
    Sub pegacurso()
        Dim linhapegacurso As String = "SELECT nm_curso FROM tb_curso WHERE cd_curso =" & codcurso
        Dim drpeganomecurso As SqlDataReader
        Dim cmdpeganomecurso As New SqlCommand(linhapegacurso, conexao)
        conexao.Close()
        conexao.Open()
        drpeganomecurso = cmdpeganomecurso.ExecuteReader
        If drpeganomecurso.Read() Then
            lblncurso.Text = "Curso: " & drpeganomecurso.Item("nm_curso").ToString
        End If
        conexao.Close()
    End Sub

    Private Sub Chamada_Aluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexao.Close()
        conexao2.Close()
        carregar_turmas()
        pegadata()
        pegardiasemana()
        verificadata()
        lblncurso.Text = "Curso: "
        lblnaulas.Text = "Nº de aulas diarias: "
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        rdbf.Checked = False
        rdbp.Checked = False
        codturma = cmb_turma.SelectedValue
        carregar_alunos_turma(codturma)
        carregadisciplinas(codturma, pegardiasemana())
        carregarqtaulas()
        pegacurso()
        carregarqtaulas()
    End Sub
    Sub carregarqtaulas()
        Try
            conexao.Close()
            Dim seleciona As String = "SELECT cd_curso FROM tb_turma WHERE cd_turma = " & cmb_turma.SelectedValue
            Dim drqtaula As SqlDataReader
            Dim cmdpegacodcurso As New SqlCommand(seleciona, conexao)
            conexao.Open()
            drqtaula = cmdpegacodcurso.ExecuteReader
            If drqtaula.Read() Then
                codcurso = drqtaula.Item("cd_curso")
            End If
            drqtaula.Close()
            conexao.Close()
            cmdpegacodcurso.Dispose()
            '''''
            Dim selec As String = "SELECT qt_aula_sem FROM tb_curso WHERE cd_curso = " & codcurso
            Dim cmdpegaqtaulas As New SqlCommand(selec, conexao)
            Dim drqtaula1 As SqlDataReader
            conexao.Close()
            conexao.Open()
            drqtaula1 = cmdpegaqtaulas.ExecuteReader
            If drqtaula1.Read() Then
                qtaula = drqtaula1.Item("qt_aula_sem")
                qtaula = qtaula / 5
            End If
            drqtaula.Close()
            conexao.Close()
            cmdpegaqtaulas.Dispose()
            cmb_aula.Items.Clear()
            Dim c As Integer = 0
            cmb_aula.Items.Clear()
            lblnaulas.Text = "Quantidade de aulas diárias: " & qtaula
            While c <= qtaula - 1
                cmb_aula.Items.Add(c + 1)
                c = c + 1
            End While
            cmb_aula.Items.Add("Reposição")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub carregar_alunos_turma(ByVal turma As Integer)
        Try
            Dim seleciona As String = "SELECT tb_aluno.cd_aluno, tb_aluno.nm_aluno FROM tb_juncao_turma_aluno " & _
            "INNER JOIN tb_turma ON tb_juncao_turma_aluno.cd_turma = tb_turma.cd_turma " & _
            "INNER JOIN tb_aluno ON tb_juncao_turma_aluno.cd_aluno = tb_aluno.cd_aluno " & _
            "Where tb_turma.cd_turma = " & turma
            Dim dsAluno_Turma As New DataSet()
            Dim daAluno_Turma As New SqlDataAdapter(seleciona, conexao2)

            daAluno_Turma.Fill(dsAluno_Turma, "Aluno_Turma")
            conexao2.Close()
            With Me.lstaluno
                .DisplayMember = "nm_aluno"
                .ValueMember = "cd_aluno"
                .DataSource = dsAluno_Turma.Tables("Aluno_Turma").DefaultView

            End With
            dsAluno_Turma.Dispose()
            daAluno_Turma.Dispose()
        Catch ex As Exception
        End Try
    End Sub
    Sub carregadisciplinas(ByVal codturma As Integer, ByVal diasemana As String)
        conexao2.Close()
        conexao.Close()
        Dim seleciona As String = "Select tb_aula.cd_disciplina,tb_disciplina.nm_disciplina FROM tb_aula " & _
        "INNER JOIN tb_disciplina on tb_aula.cd_disciplina = tb_disciplina.cd_disciplina " & _
        "WHERE cd_turma =" & codturma & " AND ds_dia ='" & diasemana & "'"
        conexao2.Open()

        Dim dsDisc As New DataSet()
        Dim daDisc As New SqlDataAdapter(seleciona, conexao2)

        daDisc.Fill(dsDisc, "Disciplina")
        conexao2.Close()
        With Me.cmbmateria
            .DisplayMember = "nm_disciplina"
            .ValueMember = "cd_disciplina"
            .DataSource = dsDisc.Tables("Disciplina").DefaultView
        End With
        dsDisc.Dispose()
        daDisc.Dispose()
    End Sub
    Private Sub lstaluno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstaluno.SelectedIndexChanged
        verificaestadoaluno()
    End Sub
    Sub verificaestadoaluno()
        conexao.Close()
        conexao2.Close()
        Try
            Dim strp As String = " IF EXISTS (SELECT * from tb_presenca_aluno WHERE cd_aluno = @cd_aluno AND dt_presenca = @dt_presenca AND ds_aula = @ds_aula)" & _
                                " set @verdade = 1" & _
                                " SELECT @verdade"
            Dim strf As String = " IF EXISTS (SELECT * from tb_faltas_aluno WHERE cd_aluno = @cd_aluno AND dt_falta = @dt_falta AND ds_aula = @ds_aula)" & _
                                " set @verdade = 1" & _
                                " SELECT @verdade"
            Dim comandop As New SqlCommand(strp, conexao)
            Dim drcomandop As SqlDataReader
            comandop.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
            comandop.Parameters.Add(New SqlParameter("@dt_presenca", pegadata()))
            comandop.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            comandop.Parameters.Add(New SqlParameter("@verdade", 0))
            conexao.Open()
            drcomandop = comandop.ExecuteReader
            If drcomandop.Read() Then
                p = drcomandop.Item("@verdade")
            End If
            drcomandop.Close()
            conexao.Close()
            Dim comandof As New SqlCommand(strf, conexao)
            Dim drcomandof As SqlDataReader
            comandop.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
            comandop.Parameters.Add(New SqlParameter("@dt_falta", pegadata()))
            comandop.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            comandop.Parameters.Add(New SqlParameter("@verdade", 0))
            conexao.Open()
            drcomandof = comandof.ExecuteReader
            If drcomandof.Read() Then
                f = drcomandof.Item("@verdade")
            End If
            drcomandof.Close()
            conexao.Close()
            If p = 1 Then
                rdbp.Checked = True
                rdbf.Checked = False
            ElseIf f = 1 Then
                rdbf.Checked = True
                rdbp.Checked = False
            Else
                rdbf.Checked = False
                rdbp.Checked = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbf.CheckedChanged
        Try
            If cmb_aula.SelectedItem.ToString <> Nothing And cmb_turma.SelectedItem.ToString <> Nothing And cmbmateria.SelectedItem.ToString <> Nothing And lstaluno.SelectedItem.ToString <> Nothing Then
                relataula()
                falta()
            End If
        Catch ex As Exception
            MessageBox.Show("Preencha os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdbf.Checked = False
            rdbp.Checked = False
        End Try
    End Sub
    Private Sub mnu_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmb_turma.Enabled = True
    End Sub
    Sub relataula()

        Dim stri As String = "IF NOT EXISTS (SELECT * FROM tb_aula_dada where cd_turma = @cd_turma AND dt_aula = @dt_aula AND ds_aula = @ds_aula) " & _
                        "INSERT INTO tb_aula_dada(cd_disciplina_dada,cd_disciplina_reposta,cd_turma,dt_aula,ds_aula,vl_aula) values (@cd_disciplina_dada,@cd_disciplina_reposta,@cd_turma,@dt_aula,@ds_aula,@vl_aula)"
        Dim comando As New SqlCommand(stri, conexao)
        comando.Parameters.Add(New SqlParameter("@cd_disciplina_dada", cmbmateria.SelectedValue))
        If cmb_aula.SelectedItem.ToString = "Reposição" Then
            comando.Parameters.Add(New SqlParameter("@ds_aula", "Reposta"))
            comando.Parameters.Add(New SqlParameter("@cd_disciplina_reposta", cmbmateria.SelectedValue))
        Else
            comando.Parameters.Add(New SqlParameter("@cd_disciplina_reposta", ""))
            comando.Parameters.Add(New SqlParameter("@ds_aula", "Dada"))
        End If
        comando.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
        comando.Parameters.Add(New SqlParameter("@dt_aula", pegadata()))
        comando.Parameters.Add(New SqlParameter("@vl_aula", cmbmateria.SelectedValue))
        conexao.Close()
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbp.CheckedChanged
        Try
            If cmb_aula.SelectedItem.ToString <> Nothing And cmb_turma.SelectedItem.ToString <> Nothing And cmbmateria.SelectedItem.ToString <> Nothing And lstaluno.SelectedItem.ToString <> Nothing Then
                relataula()
                presenca()
            End If
        Catch ex As Exception
            MessageBox.Show("Preencha os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rdbf.Checked = False
            rdbp.Checked = False
        End Try
    End Sub

    Private Sub dtp_evento_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        pegadata()
        pegardiasemana()
    End Sub

    Private Sub dtpdia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdia.ValueChanged
        pegardiasemana()
        pegadata()
        carregadisciplinas(codturma, pegardiasemana())
        verificadata()
    End Sub
    Private Sub cmb_aula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aula.SelectedIndexChanged

    End Sub

    Private Sub mnu_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_excluir.Click
        MessageBox.Show("Certeza que deseja excluir a chamada deste dia?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If MessageBox.Show("Certeza que deseja excluir a chamada deste dia?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Try
                '''''''deletando presencas
                Dim str1 As String = "DELETE FROM tb_presenca_aluno WHERE cd_turma = @cd_turma AND dt_presenca = @dt_presenca "
                Dim comando1 As New SqlCommand(str1, conexao)
                comando1.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
                comando1.Parameters.Add(New SqlParameter("@dt_presenca", pegadata()))
                conexao.Open()
                comando1.ExecuteNonQuery()
                conexao.Close()
            Catch ex As Exception
            End Try
            Try
                ''''''''deletando falhas
                Dim str1 As String = "DELETE FROM tb_faltas_aluno WHERE cd_turma = @cd_turma AND dt_falta = @dt_falta "
                Dim comando1 As New SqlCommand(str1, conexao)
                comando1.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
                comando1.Parameters.Add(New SqlParameter("@dt_falta", pegadata()))
                conexao.Open()
                comando1.ExecuteNonQuery()
                conexao.Close()
            Catch ex As Exception
            End Try
            Try
                Dim str1 As String = "DELETE FROM tb_aula_dada WHERE cd_turma = @cd_turma AND dt_falta = @dt_aula "
                Dim comando1 As New SqlCommand(str1, conexao)
                comando1.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
                comando1.Parameters.Add(New SqlParameter("@dt_aula", pegadata()))
                conexao.Open()
                comando1.ExecuteNonQuery()
                conexao.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        data = pegadata()
        diasemana = pegardiasemana()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cont As Integer = 0
        lstaluno.SelectedIndex = -1
        Try
            cmb_aula.SelectedText = Integer.Parse(cmb_aula.SelectedItem) + 1
        Catch ex As Exception
            MessageBox.Show("Ja foram realizadas todas as aulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        While cont < lstaluno.Items.Count
            lstaluno.SelectedIndex = cont
            verificaestadoaluno()
            If rdbf.Checked = True Then
                falta()
            ElseIf rdbp.Checked = True Then
                presenca()
            Else
            End If
        End While
    End Sub
    Sub presenca()
        Dim linhap As String = "INSERT INTO tb_presenca_aluno (cd_aluno,cd_disciplina,cd_turma,dt_presenca,ds_aula) values (@cd_aluno,@cd_disciplina,@cd_turma,@dt_presenca,@ds_aula)"
        Dim linhaconferef As String = "IF EXISTS (SELECT * FROM tb_faltas_aluno WHERE cd_aluno = @cd_aluno AND cd_disciplina = @cd_disciplina AND cd_turma = @cd_turma AND dt_falta = @dt_falta AND ds_aula = @ds_aula)" & _
                               " DELETE FROM tb_faltas_aluno WHERE  cd_aluno = @cd_aluno AND cd_disciplina = @cd_disciplina AND cd_turma = @cd_turma AND dt_falta = @dt_falta AND ds_aula = @ds_aula"
        Dim ccf As New SqlCommand(linhaconferef, conexao)
        Dim p As New SqlCommand(linhap, conexao)
        ccf.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
        ccf.Parameters.Add(New SqlParameter("@cd_disciplina", cmbmateria.SelectedValue))
        ccf.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
        ccf.Parameters.Add(New SqlParameter("@dt_falta", pegadata()))
        If cmbmateria.SelectedItem.ToString = "Reposição" Then
            ccf.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            p.Parameters.Add(New SqlParameter("@ds_aula", 0))
        Else
            ccf.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            p.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
        End If
        p.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
        p.Parameters.Add(New SqlParameter("@cd_disciplina", cmbmateria.SelectedValue))
        p.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
        p.Parameters.Add(New SqlParameter("@dt_presenca", pegadata()))
        conexao.Close()
        conexao.Open()
        ccf.ExecuteNonQuery()
        conexao.Close()
        conexao.Open()
        p.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Sub falta()
        Dim linhaf As String = "INSERT INTO tb_faltas_aluno (cd_aluno,cd_disciplina,cd_turma,dt_falta,ds_aula) values (@cd_aluno,@cd_disciplina,@cd_turma,@dt_falta,@ds_aula)"
        Dim linhaconferep As String = "IF EXISTS (SELECT * FROM tb_presenca_aluno WHERE cd_aluno = @cd_aluno AND cd_disciplina = @cd_disciplina AND cd_turma = @cd_turma AND dt_presenca = @dt_presenca AND ds_aula = @ds_aula)" & _
                                      "DELETE FROM tb_presenca_aluno WHERE  cd_aluno = @cd_aluno AND cd_disciplina = @cd_disciplina AND cd_turma = @cd_turma AND dt_presenca = @dt_presenca AND ds_aula = @ds_aula"
        Dim ccp As New SqlCommand(linhaconferep, conexao)
        Dim f As New SqlCommand(linhaf, conexao)
        ccp.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
        ccp.Parameters.Add(New SqlParameter("@cd_disciplina", cmbmateria.SelectedValue))
        ccp.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
        ccp.Parameters.Add(New SqlParameter("@dt_presenca", pegadata()))
        If cmbmateria.SelectedItem.ToString = "Reposição" Then
            ccp.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            f.Parameters.Add(New SqlParameter("@ds_aula", 0))
        Else
            ccp.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
            f.Parameters.Add(New SqlParameter("@ds_aula", cmb_aula.SelectedItem))
        End If
        f.Parameters.Add(New SqlParameter("@cd_aluno", lstaluno.SelectedValue))
        f.Parameters.Add(New SqlParameter("@cd_disciplina", cmbmateria.SelectedValue))
        f.Parameters.Add(New SqlParameter("@cd_turma", cmb_turma.SelectedValue))
        f.Parameters.Add(New SqlParameter("@dt_falta", pegadata()))
        conexao.Close()
        conexao.Open()
        ccp.ExecuteNonQuery()
        conexao.Close()
        conexao.Open()
        f.ExecuteNonQuery()
        conexao.Close()
    End Sub
    Function verificadata()
        conexao.Close()
        Dim evento As String = ""
        Dim dsevento As String = ""
        Dim linhapesquisa As String = "SELECT nm_evento,ds_evento FROM tb_evento WHERE dt_evento = @dt_evento"
        Dim cmdpesquisa As New SqlCommand(linhapesquisa, conexao)
        Dim drevento As SqlDataReader
        cmdpesquisa.Parameters.Add(New SqlParameter("@dt_evento", pegadata()))
        conexao.Open()
        drevento = cmdpesquisa.ExecuteReader
        If drevento.Read() Then
            evento = drevento.Item("nm_evento").ToString
            dsevento = drevento.Item("ds_evento").ToString
        End If
        If evento = Nothing Or evento = "" Then
        Else
            conexao.Close()
            MessageBox.Show("Neste dia esta agendado: " & evento & vbCrLf & dsevento)
        End If
    End Function
End Class
