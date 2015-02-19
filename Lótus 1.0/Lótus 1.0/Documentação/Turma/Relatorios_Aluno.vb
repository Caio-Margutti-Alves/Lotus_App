Imports System.Data.SqlClient
Public Class Relatorios_Aluno

    '--------DADOS---------'
    Private cd_turma As Integer = 0
    Private ano As Integer = 0

    Private Sub Relatorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        carregar_turmas()
    End Sub

    Private Sub cmb_turma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turma.SelectedIndexChanged
        cd_turma = cmb_turma.SelectedValue
        carregar_ano()
        carrega_mes()
    End Sub

    Private Sub mnu_mensal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_mensal.Click
        If cmb_mes.Text = "" Or cmb_turma.Text = "" Then
            MessageBox.Show("Selecione a Turma e o Mês antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            gerar_relatorio_mensal()
        End If
    End Sub

    Private Sub mnu_aulas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_aulas.Click
        If cmb_mes.Text = "" Or cmb_turma.Text = "" Then
            MessageBox.Show("Selecione a Turma e o Mês antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            gerar_relatorio_controle_aulas()
        End If
    End Sub

    Private Sub mnu_grafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_grafico.Click
        If cmb_mes.Text = "" Or cmb_turma.Text = "" Then
            MessageBox.Show("Selecione a Turma e o Mês antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim gra As New Graficos_aluno
            gra.MdiParent = frm_interface
            gra.Show()
        End If
    End Sub

    Private Sub carregar_turmas()
        Dim seleciona As String = "Select cd_turma, nm_turma +  ' - ' + CAST (dt_ano as Varchar(15)) + ' - ' + CAST(cd_semestre as char(1)) + 'º Semestre' as turma_data_semestre FROM tb_turma"
        Dim dsTurma As New DataSet()
        Dim daTurma As New SqlDataAdapter(seleciona, conexao)
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
    Private Sub carregar_ano()
        sql = "SELECT dt_ano FROM tb_turma WHERE cd_turma = " & cd_turma
        Dim comando As New SqlCommand(sql, conexao2)
        conexao2.Open()
        Dim dr As SqlDataReader = comando.ExecuteReader
        While dr.Read
            ano = dr.GetString(0)
        End While
        conexao2.Close()
    End Sub

    Private Sub carrega_mes()
        Try
            Dim seleciona As String = "SELECT DISTINCT CASE DATEPART(month, tb_faltas_aluno.dt_falta) " & _
            "WHEN '1' THEN 'Janeiro' WHEN '2' THEN 'Fevereiro' WHEN '3' THEN 'Março' WHEN '4' THEN 'Abril' " & _
            "WHEN '5' THEN 'Maio' WHEN '6' THEN 'Junho' WHEN '7' THEN 'Julho' WHEN '8' THEN 'Agosto' " & _
            "WHEN '9' THEN 'Setembro' WHEN '10' THEN 'Outubro' WHEN '11' THEN 'Novembro' " & _
            "WHEN '12' THEN 'Dezembro' END AS Mês, DATEPART(month, tb_faltas_aluno.dt_falta) AS Ordem " & _
            "FROM tb_faltas_aluno INNER JOIN tb_aluno ON tb_faltas_aluno.cd_aluno = tb_aluno.cd_aluno " & _
            "INNER JOIN tb_juncao_turma_aluno ON tb_aluno.cd_aluno = tb_juncao_turma_aluno.cd_aluno " & _
            "WHERE Datepart(year, tb_faltas_aluno.dt_falta) = " & ano & _
            "AND tb_juncao_turma_aluno.cd_turma = " & cd_turma
            Dim dsFaltas As New DataSet()
            Dim daFaltas As New SqlDataAdapter(seleciona, conexao2)
            conexao2.Open()
            daFaltas.Fill(dsFaltas, "Faltas Alunos")
            conexao2.Close()
            With Me.cmb_mes
                .DisplayMember = "Mês"
                .ValueMember = "Ordem"
                .DataSource = dsFaltas.Tables("Faltas Alunos").DefaultView
                .SelectedIndex = -1
            End With
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
            conexao2.Close()
            Exit Sub
        Finally
            conexao2.Close()
        End Try
    End Sub

End Class