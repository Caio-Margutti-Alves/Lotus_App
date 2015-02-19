Public Class Relatorios_Professor

    Private Sub Relatorios_Professor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        txt_ano.Text = Year(Now)
    End Sub

    Private Sub txt_ano_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ano.TextChanged
        negar_car(txt_ano)
    End Sub

    Private Sub mnu_rel_faltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_rel_faltas.Click
        If cmb_mes.Text = "" Or txt_ano.Text = "" Then
            MessageBox.Show("Selecione o Mês e digite o Ano antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            gerar_relatorio_faltas_professores()
        End If
    End Sub

    Private Sub mnu_rel_ad_noturno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_rel_ad_noturno.Click
        If cmb_mes.Text = "" Or txt_ano.Text = "" Then
            MessageBox.Show("Selecione o Mês e digite o Ano antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            gerar_relatorio_adcional_noturno()
        End If
    End Sub

    Private Sub mnu_relatorio_grafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_relatorio_grafico.Click
        If cmb_mes.Text = "" Or txt_ano.Text = "" Then
            MessageBox.Show("Selecione o Mês e digite o Ano antes de gerar um documento!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim gra As New Graficos_professor
            gra.MdiParent = frm_interface
            gra.Show()
        End If
    End Sub
End Class