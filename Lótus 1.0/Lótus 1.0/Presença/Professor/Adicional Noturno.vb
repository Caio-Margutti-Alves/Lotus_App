Imports System.Data.SqlClient
Public Class Adicional_Noturno

    '---Cadastro---'
    Private cd_professor As Integer = 0
    Private dia_mes As String = "01/01/"
    Private data_valida As Boolean = False
    Private valor As Double = 0

    '--Alteração e Consulta--'
    Private excluido As Boolean = False

    Private Sub Adicional_Noturno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_form(Me)
        txt_ano.Text = Year(Now)
        lst_mes.SelectedIndex = 12
        carrega_professores()
    End Sub

    Private Sub cmb_professor_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_professor.MouseClick
        carrega_professores()
    End Sub

    Private Sub cmb_professor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_professor.SelectedIndexChanged
        cd_professor = cmb_professor.SelectedValue
        carrega_adicionais()
    End Sub

    Private Sub lst_mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_mes.SelectedIndexChanged
        If lst_mes.SelectedIndex = 0 Then
            dia_mes = "01/01/"
        ElseIf lst_mes.SelectedIndex = 1 Then
            dia_mes = "02/02/"
        ElseIf lst_mes.SelectedIndex = 2 Then
            dia_mes = "03/03/"
        ElseIf lst_mes.SelectedIndex = 3 Then
            dia_mes = "04/04/"
        ElseIf lst_mes.SelectedIndex = 4 Then
            dia_mes = "05/05/"
        ElseIf lst_mes.SelectedIndex = 5 Then
            dia_mes = "06/06/"
        ElseIf lst_mes.SelectedIndex = 6 Then
            dia_mes = "07/07/"
        ElseIf lst_mes.SelectedIndex = 7 Then
            dia_mes = "08/08/"
        ElseIf lst_mes.SelectedIndex = 8 Then
            dia_mes = "09/09/"
        ElseIf lst_mes.SelectedIndex = 9 Then
            dia_mes = "10/10/"
        ElseIf lst_mes.SelectedIndex = 10 Then
            dia_mes = "11/11/"
        ElseIf lst_mes.SelectedIndex = 11 Then
            dia_mes = "12/12/"
        End If
        carrega_adicionais()
    End Sub

    Private Sub txt_dt_adicional_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_dt_adicional.TextChanged
        If txt_dt_adicional.MaskFull = True Then
            data_valida = valida_data(txt_dt_adicional)
            If data_valida = False Then
                txt_dt_adicional.Clear()
            End If
        End If
    End Sub

    Private Sub btn_add_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_disciplina.Click
        adciona_adicional_noturno()
        txt_valor.Clear()
        txt_dt_adicional.Clear()
    End Sub

    Private Sub btn_rmv_disciplina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rmv_disciplina.Click
        If lst_adcionais_cadastrados.SelectedIndex >= 0 Then
            exclui_adcional_noturno()
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

    Private Sub carrega_adicionais()
        Try
            Dim seleciona As String = ""
            Dim data_completa As Date
       
            If txt_ano.Text = "" Then
                Dim pseudodata_completa As String = dia_mes & Year(Now)
                data_completa = FormatDateTime(pseudodata_completa, DateFormat.ShortDate)
                If lst_mes.SelectedIndex = 12 Then
                    seleciona = "SELECT cd_ad_noturno, CONVERT(VARCHAR(10),dt_ad_noturno,103) + ' | R$' + CAST(vl_ad_noturno as Varchar(max)) as data_valor FROM tb_ad_noturno WHERE cd_professor =" & cd_professor & " ORDER BY dt_ad_noturno ASC"
                Else
                    seleciona = "SELECT cd_ad_noturno, CONVERT(VARCHAR(10),dt_ad_noturno,103) + ' | R$' + CAST(vl_ad_noturno as Varchar(max)) as data_valor FROM tb_ad_noturno WHERE cd_professor =" & cd_professor & " AND DatePart(Month, dt_ad_noturno) = DatePart(Month,'" & data_completa & "') ORDER BY dt_ad_noturno ASC"
                End If
            Else
                Dim pseudodata_completa As String = dia_mes & txt_ano.Text
                data_completa = FormatDateTime(pseudodata_completa, DateFormat.ShortDate)
                If lst_mes.SelectedIndex = 12 Then
                    seleciona = "SELECT cd_ad_noturno, CONVERT(VARCHAR(10),dt_ad_noturno,103) + ' | R$' + CAST(vl_ad_noturno as Varchar(max)) as data_valor FROM tb_ad_noturno WHERE cd_professor =" & cd_professor & " AND DatePart(YEAR, dt_ad_noturno) = DatePart(YEAR,'" & data_completa & "') ORDER BY dt_ad_noturno ASC"
                Else
                    seleciona = "SELECT cd_ad_noturno, CONVERT(VARCHAR(10),dt_ad_noturno,103) + ' | R$' + CAST(vl_ad_noturno as Varchar(max)) as data_valor FROM tb_ad_noturno WHERE cd_professor =" & cd_professor & " AND DatePart(Month, dt_ad_noturno) = DatePart(Month,'" & data_completa & "') AND DatePart(YEAR, dt_ad_noturno) = DatePart(YEAR,'" & data_completa & "') ORDER BY dt_ad_noturno ASC"
                End If
            End If

            Dim dsAdicional As New DataSet()
            Dim daAdicional As New SqlDataAdapter(seleciona, conexao2)
            conexao2.Close()
            conexao2.Open()
            daAdicional.Fill(dsAdicional, "Adicional_Noturno")
            conexao2.Close()
            With Me.lst_adcionais_cadastrados
                .DisplayMember = "data_valor"
                .ValueMember = "cd_ad_noturno"
                .DataSource = dsAdicional.Tables("Adicional_Noturno").DefaultView
                .SelectedIndex = -1
            End With
            dsAdicional.Dispose()
            daAdicional.Dispose()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub adciona_adicional_noturno()

        If cmb_professor.SelectedIndex = -1 Or txt_dt_adicional.MaskFull = False Or txt_valor.Text = "" Or data_valida = False Then
            MessageBox.Show("Selecione o Professor, o Mes e digite um Valor antes de Inserir", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If txt_valor.Text = 0 Then
                MessageBox.Show("O Valor deve ser maior que R$ 0,00", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim linhas As Integer = 0
                Try
                    sql = "INSERT INTO tb_ad_noturno(cd_professor,vl_ad_noturno,dt_ad_noturno) values(@cd_professor,@vl_ad_noturno,@dt_ad_noturno)"

                    Dim data_adicional As Date
                    data_adicional = FormatDateTime(txt_dt_adicional.Text, DateFormat.ShortDate)

                    Dim comando As New SqlCommand(sql, conexao)
                    comando.Parameters.Add(New SqlParameter("@cd_professor", cmb_professor.SelectedValue))
                    comando.Parameters.Add(New SqlParameter("@vl_ad_noturno", Double.Parse(txt_valor.Text)))
                    comando.Parameters.Add(New SqlParameter("@dt_ad_noturno", data_adicional))
                    conexao.Close()
                    conexao.Open()

                    linhas = comando.ExecuteNonQuery()
                    conexao.Close()
                Catch ex As Exception
                    MessageBox.Show("Erro ao Inserir no Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                If linhas <> 0 Then
                    MessageBox.Show("Cadastro Realizado Com Sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lst_mes.SelectedIndex = 12
                    carrega_adicionais()
                    data_valida = False
                End If
            End If
        End If
    End Sub
    Private Sub exclui_adcional_noturno()
        excluido = deletar_cadastro("tb_ad_noturno", "cd_ad_noturno", lst_adcionais_cadastrados.SelectedValue)
        If excluido = True Then
            carrega_adicionais()
            excluido = False
        End If
    End Sub

    Private Sub txt_valor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_valor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(valor_monetario(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_valor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_valor.TextChanged
        negar_car(txt_valor)
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
        carrega_adicionais()
    End Sub
End Class