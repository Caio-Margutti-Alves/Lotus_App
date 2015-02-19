Imports System.Data.SqlClient
Module funcoes_sistema

    Public caminho_manual As String = Application.StartupPath & "\manual\"
    Public caminho_formulario_usado As String = ""
    Public formulario_usado As String = ""
    '------------MENUS---------------'

    Public Sub alteracao_de_menus(ByVal mode As String, ByVal grb_cadastro As GroupBox, ByVal grb_consulta As GroupBox, ByVal mnu1 As ToolStripMenuItem, ByVal mnu2 As ToolStripMenuItem, ByVal mnu3 As ToolStripMenuItem, ByVal mnu4 As ToolStripMenuItem)

        If mode = "Novo" Then

            grb_cadastro.Enabled = True
            grb_consulta.Enabled = False
            mnu1.Visible = True
            mnu2.Enabled = False
            mnu3.Enabled = False
            mnu4.Enabled = True

        ElseIf mode = "Alterar" Then

            grb_cadastro.Enabled = True
            grb_consulta.Enabled = False
            mnu1.Visible = True
            mnu4.Enabled = True

        ElseIf mode = "Consulta" Then

            grb_cadastro.Enabled = False
            grb_consulta.Enabled = True
            mnu1.Visible = False
            mnu4.Enabled = False

        End If
    End Sub

    '---------ALTERAR REGISTRO - FORMATO DATA-------'
    Public Sub AlterarFormatoData(ByVal formato As String)
        Try
            Dim key As Microsoft.Win32.RegistryKey
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", True)
            key.SetValue("sShortDate", formato)
        Catch ex As Exception
            MessageBox.Show("Erro ao Tentar Alterar o tipo de Data do registro do Windows", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    '------------------------------------------'

    '--------OUTROS-------------'
    Public Sub carregar_fundo_form(ByVal formulario As Form)
        Try
            formulario.BackColor = Color.FromArgb(cor_tema)
        Catch ex As Exception
        End Try
    End Sub

    Sub cam()
        WebCam.MdiParent = frm_interface
        WebCam.Show()
    End Sub

    Public Sub Limpar(ByVal Formulario As Form)
        For Each ctl As Control In Formulario.Controls

            If TypeOf (ctl) Is TextBox Then 'TextBox

                DirectCast(ctl, TextBox).Text = String.Empty

            ElseIf TypeOf (ctl) Is CheckBox Then 'CheckBox

                DirectCast(ctl, CheckBox).Checked = False

            ElseIf TypeOf (ctl) Is ComboBox Then 'ComboBox

                DirectCast(ctl, ComboBox).SelectedIndex = -1

            ElseIf TypeOf (ctl) Is DateTimePicker Then 'DateTimerPicker

                DirectCast(ctl, DateTimePicker).Text = Date.Today.Date

            ElseIf TypeOf (ctl) Is ListBox Then 'ListBox

                DirectCast(ctl, ListBox).Items.Clear()

            ElseIf TypeOf (ctl) Is MaskedTextBox Then 'MaskedTextBox

                DirectCast(ctl, MaskedTextBox).Text = String.Empty

            ElseIf TypeOf (ctl) Is GroupBox Then

                For Each ct As Control In ctl.Controls()

                    If TypeOf (ct) Is TextBox And ct.Name <> "txt_pesquisa" Then 'TextBox

                        DirectCast(ct, TextBox).Text = String.Empty

                    ElseIf TypeOf (ct) Is CheckBox Then 'CheckBox

                        DirectCast(ct, CheckBox).Checked = False

                    ElseIf TypeOf (ct) Is ComboBox And ct.Name <> "cmb_pesquisa" Then 'ComboBox

                        DirectCast(ct, ComboBox).SelectedIndex = -1

                    ElseIf TypeOf (ct) Is DateTimePicker Then 'DateTimerPicker

                        DirectCast(ct, DateTimePicker).Text = Date.Today.Date


                    ElseIf TypeOf (ct) Is MaskedTextBox Then 'MaskedTextBox

                        DirectCast(ct, MaskedTextBox).Text = String.Empty
                    End If
                Next
            End If
        Next
    End Sub

    Sub papel_parede_padrao()
        Dim sql = "UPDATE tb_usuario SET ds_caminho_papel_parede = 'fundo_padrao.png' WHERE cd_usuario =" & cd_usuario
        Dim comando As New SqlCommand(sql, conexao)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()
    End Sub

    Sub cor_tema_padrao()
        Dim sql = "UPDATE tb_usuario SET cor_tema = '-15420550' WHERE cd_usuario =" & cd_usuario
        Dim comando As New SqlCommand(sql, conexao)
        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()

    End Sub
End Module
