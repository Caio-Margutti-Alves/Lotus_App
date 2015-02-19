<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuario))
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_dica_senha = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.grb_tipo_usuario = New System.Windows.Forms.GroupBox
        Me.rad_secretaria = New System.Windows.Forms.RadioButton
        Me.rad_administrativo = New System.Windows.Forms.RadioButton
        Me.txt_novasenha = New System.Windows.Forms.TextBox
        Me.txt_novasenha2 = New System.Windows.Forms.TextBox
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.rad_usuario = New System.Windows.Forms.RadioButton
        Me.rad_tipo = New System.Windows.Forms.RadioButton
        Me.lst_consulta = New System.Windows.Forms.ListBox
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_cadastro.SuspendLayout()
        Me.grb_tipo_usuario.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_login
        '
        Me.tlp_login.AutomaticDelay = 9000
        Me.tlp_login.AutoPopDelay = 5000
        Me.tlp_login.InitialDelay = 1
        Me.tlp_login.IsBalloon = True
        Me.tlp_login.ReshowDelay = 1
        Me.tlp_login.ShowAlways = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(121, 32)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 12
        Me.tlp_login.SetToolTip(Me.TextBox9, "Digite o nome do professor")
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(121, 111)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 7
        Me.tlp_login.SetToolTip(Me.TextBox10, "Confirme a senha do professor")
        Me.TextBox10.UseSystemPasswordChar = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(121, 85)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 6
        Me.tlp_login.SetToolTip(Me.TextBox11, "Digite a senha do professor")
        Me.TextBox11.UseSystemPasswordChar = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(121, 59)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 5
        Me.tlp_login.SetToolTip(Me.TextBox12, "Digite o login do professor")
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(121, 32)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 12
        Me.tlp_login.SetToolTip(Me.TextBox13, "Digite o nome do professor")
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(121, 111)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 7
        Me.tlp_login.SetToolTip(Me.TextBox14, "Confirme a senha do professor")
        Me.TextBox14.UseSystemPasswordChar = True
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(121, 85)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 6
        Me.tlp_login.SetToolTip(Me.TextBox15, "Digite a senha do professor")
        Me.TextBox15.UseSystemPasswordChar = True
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(121, 59)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 5
        Me.tlp_login.SetToolTip(Me.TextBox16, "Digite o login do professor")
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(121, 32)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 12
        Me.tlp_login.SetToolTip(Me.TextBox17, "Digite o nome do professor")
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(121, 111)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 7
        Me.tlp_login.SetToolTip(Me.TextBox18, "Confirme a senha do professor")
        Me.TextBox18.UseSystemPasswordChar = True
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(121, 85)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 6
        Me.tlp_login.SetToolTip(Me.TextBox19, "Digite a senha do professor")
        Me.TextBox19.UseSystemPasswordChar = True
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(121, 59)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 5
        Me.tlp_login.SetToolTip(Me.TextBox20, "Digite o login do professor")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(418, 166)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Professores"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.PictureBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 163)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(252, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(112, 117)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Confirmação:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Senha:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Login:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(287, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Foto:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Nome:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(418, 166)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Alunos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Controls.Add(Me.PictureBox5)
        Me.GroupBox4.Controls.Add(Me.TextBox13)
        Me.GroupBox4.Controls.Add(Me.TextBox14)
        Me.GroupBox4.Controls.Add(Me.TextBox15)
        Me.GroupBox4.Controls.Add(Me.TextBox16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 163)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(252, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(112, 117)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 15)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Confirmação:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Senha:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Login:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(287, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Foto:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nome:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox5)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(418, 166)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "TabPage3"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.PictureBox6)
        Me.GroupBox5.Controls.Add(Me.TextBox17)
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.TextBox19)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 163)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(252, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(112, 117)
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 15)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Confirmação:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(19, 85)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 15)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Senha:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(19, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 15)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Login:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(287, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Foto:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(18, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 15)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Nome:"
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grb_cadastro.Controls.Add(Me.txt_email)
        Me.grb_cadastro.Controls.Add(Me.Label5)
        Me.grb_cadastro.Controls.Add(Me.txt_dica_senha)
        Me.grb_cadastro.Controls.Add(Me.Label4)
        Me.grb_cadastro.Controls.Add(Me.grb_tipo_usuario)
        Me.grb_cadastro.Controls.Add(Me.txt_novasenha)
        Me.grb_cadastro.Controls.Add(Me.txt_novasenha2)
        Me.grb_cadastro.Controls.Add(Me.txt_usuario)
        Me.grb_cadastro.Controls.Add(Me.Label3)
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.Label1)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(8, 79)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(409, 288)
        Me.grb_cadastro.TabIndex = 9
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Usuário"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(145, 101)
        Me.txt_email.MaxLength = 100
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(258, 22)
        Me.txt_email.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Email:"
        '
        'txt_dica_senha
        '
        Me.txt_dica_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dica_senha.Location = New System.Drawing.Point(145, 202)
        Me.txt_dica_senha.MaxLength = 50
        Me.txt_dica_senha.Multiline = True
        Me.txt_dica_senha.Name = "txt_dica_senha"
        Me.txt_dica_senha.Size = New System.Drawing.Size(258, 80)
        Me.txt_dica_senha.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Dica da Senha:"
        '
        'grb_tipo_usuario
        '
        Me.grb_tipo_usuario.Controls.Add(Me.rad_secretaria)
        Me.grb_tipo_usuario.Controls.Add(Me.rad_administrativo)
        Me.grb_tipo_usuario.ForeColor = System.Drawing.Color.Black
        Me.grb_tipo_usuario.Location = New System.Drawing.Point(9, 45)
        Me.grb_tipo_usuario.Name = "grb_tipo_usuario"
        Me.grb_tipo_usuario.Size = New System.Drawing.Size(394, 47)
        Me.grb_tipo_usuario.TabIndex = 71
        Me.grb_tipo_usuario.TabStop = False
        Me.grb_tipo_usuario.Text = "Tipo Usuário"
        '
        'rad_secretaria
        '
        Me.rad_secretaria.AutoSize = True
        Me.rad_secretaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_secretaria.Location = New System.Drawing.Point(216, 19)
        Me.rad_secretaria.Name = "rad_secretaria"
        Me.rad_secretaria.Size = New System.Drawing.Size(98, 20)
        Me.rad_secretaria.TabIndex = 1
        Me.rad_secretaria.TabStop = True
        Me.rad_secretaria.Text = "Secretaria"
        Me.rad_secretaria.UseVisualStyleBackColor = True
        '
        'rad_administrativo
        '
        Me.rad_administrativo.AutoSize = True
        Me.rad_administrativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_administrativo.Location = New System.Drawing.Point(67, 19)
        Me.rad_administrativo.Name = "rad_administrativo"
        Me.rad_administrativo.Size = New System.Drawing.Size(124, 20)
        Me.rad_administrativo.TabIndex = 0
        Me.rad_administrativo.TabStop = True
        Me.rad_administrativo.Text = "Administrativo"
        Me.rad_administrativo.UseVisualStyleBackColor = True
        '
        'txt_novasenha
        '
        Me.txt_novasenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_novasenha.Location = New System.Drawing.Point(145, 136)
        Me.txt_novasenha.MaxLength = 50
        Me.txt_novasenha.Name = "txt_novasenha"
        Me.txt_novasenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_novasenha.Size = New System.Drawing.Size(259, 22)
        Me.txt_novasenha.TabIndex = 5
        '
        'txt_novasenha2
        '
        Me.txt_novasenha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_novasenha2.Location = New System.Drawing.Point(145, 170)
        Me.txt_novasenha2.MaxLength = 50
        Me.txt_novasenha2.Name = "txt_novasenha2"
        Me.txt_novasenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_novasenha2.Size = New System.Drawing.Size(259, 22)
        Me.txt_novasenha2.TabIndex = 4
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(145, 18)
        Me.txt_usuario.MaxLength = 50
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(259, 22)
        Me.txt_usuario.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Digite a Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirme a Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuário:"
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.rad_usuario)
        Me.grb_consulta.Controls.Add(Me.rad_tipo)
        Me.grb_consulta.Controls.Add(Me.lst_consulta)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(423, 79)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(294, 288)
        Me.grb_consulta.TabIndex = 63
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(6, 42)
        Me.txt_pesquisa.MaxLength = 30
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(282, 20)
        Me.txt_pesquisa.TabIndex = 57
        '
        'rad_usuario
        '
        Me.rad_usuario.AutoSize = True
        Me.rad_usuario.Location = New System.Drawing.Point(6, 19)
        Me.rad_usuario.Name = "rad_usuario"
        Me.rad_usuario.Size = New System.Drawing.Size(95, 17)
        Me.rad_usuario.TabIndex = 55
        Me.rad_usuario.TabStop = True
        Me.rad_usuario.Text = "Por Usuário:"
        Me.rad_usuario.UseVisualStyleBackColor = True
        '
        'rad_tipo
        '
        Me.rad_tipo.AutoSize = True
        Me.rad_tipo.Location = New System.Drawing.Point(211, 18)
        Me.rad_tipo.Name = "rad_tipo"
        Me.rad_tipo.Size = New System.Drawing.Size(77, 17)
        Me.rad_tipo.TabIndex = 54
        Me.rad_tipo.TabStop = True
        Me.rad_tipo.Text = "Por Tipo:"
        Me.rad_tipo.UseVisualStyleBackColor = True
        '
        'lst_consulta
        '
        Me.lst_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta.FormattingEnabled = True
        Me.lst_consulta.HorizontalScrollbar = True
        Me.lst_consulta.ItemHeight = 16
        Me.lst_consulta.Location = New System.Drawing.Point(6, 68)
        Me.lst_consulta.Name = "lst_consulta"
        Me.lst_consulta.Size = New System.Drawing.Size(282, 212)
        Me.lst_consulta.TabIndex = 53
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_novo, Me.mnu_alterar, Me.mnu_limpar, Me.mnu_consulta, Me.mnu_excluir, Me.mnu_salvar})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(729, 68)
        Me.mnu_sup.TabIndex = 64
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_novo
        '
        Me.mnu_novo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_novo.Image = Global.Lótus_1._0.My.Resources.Resources.Word_Processor
        Me.mnu_novo.Name = "mnu_novo"
        Me.mnu_novo.Size = New System.Drawing.Size(57, 64)
        Me.mnu_novo.Text = "Novo"
        Me.mnu_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_novo.ToolTipText = "Adiciona uma nova sede"
        '
        'mnu_alterar
        '
        Me.mnu_alterar.Enabled = False
        Me.mnu_alterar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_alterar.Image = Global.Lótus_1._0.My.Resources.Resources.Writing
        Me.mnu_alterar.Name = "mnu_alterar"
        Me.mnu_alterar.Size = New System.Drawing.Size(58, 64)
        Me.mnu_alterar.Text = "Alterar"
        Me.mnu_alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_alterar.ToolTipText = "Altera uma sede"
        '
        'mnu_limpar
        '
        Me.mnu_limpar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_limpar.Image = Global.Lótus_1._0.My.Resources.Resources.CCleaner
        Me.mnu_limpar.Name = "mnu_limpar"
        Me.mnu_limpar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_limpar.Text = "Limpar"
        Me.mnu_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_limpar.ToolTipText = "Limpa todos os campos"
        Me.mnu_limpar.Visible = False
        '
        'mnu_consulta
        '
        Me.mnu_consulta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_consulta.Image = Global.Lótus_1._0.My.Resources.Resources.consultar
        Me.mnu_consulta.Name = "mnu_consulta"
        Me.mnu_consulta.Size = New System.Drawing.Size(71, 64)
        Me.mnu_consulta.Text = "Consultar"
        Me.mnu_consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_consulta.ToolTipText = "Consulta uma sede"
        '
        'mnu_excluir
        '
        Me.mnu_excluir.Enabled = False
        Me.mnu_excluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_excluir.Image = Global.Lótus_1._0.My.Resources.Resources.Recycle
        Me.mnu_excluir.Name = "mnu_excluir"
        Me.mnu_excluir.Size = New System.Drawing.Size(57, 64)
        Me.mnu_excluir.Text = "Excluir"
        Me.mnu_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_excluir.ToolTipText = "Exclui uma sede"
        '
        'mnu_salvar
        '
        Me.mnu_salvar.Enabled = False
        Me.mnu_salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_salvar.Image = Global.Lótus_1._0.My.Resources.Resources.Hard_Drive
        Me.mnu_salvar.Name = "mnu_salvar"
        Me.mnu_salvar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_salvar.Text = "Salvar"
        Me.mnu_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'usuario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 376)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.grb_cadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuário"
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_tipo_usuario.ResumeLayout(False)
        Me.grb_tipo_usuario.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txt_novasenha As System.Windows.Forms.TextBox
    Friend WithEvents txt_novasenha2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents rad_usuario As System.Windows.Forms.RadioButton
    Friend WithEvents rad_tipo As System.Windows.Forms.RadioButton
    Friend WithEvents lst_consulta As System.Windows.Forms.ListBox
    Friend WithEvents grb_tipo_usuario As System.Windows.Forms.GroupBox
    Friend WithEvents rad_secretaria As System.Windows.Forms.RadioButton
    Friend WithEvents rad_administrativo As System.Windows.Forms.RadioButton
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_dica_senha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
