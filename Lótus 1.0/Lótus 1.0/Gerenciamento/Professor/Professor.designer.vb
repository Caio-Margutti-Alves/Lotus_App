<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Professor))
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.lbl_nome = New System.Windows.Forms.Label
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox
        Me.txt_endereco = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_carregar_foto = New System.Windows.Forms.Button
        Me.txt_dtnascimento = New System.Windows.Forms.MaskedTextBox
        Me.btn_cam = New System.Windows.Forms.Button
        Me.txt_cel = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ptb_foto = New System.Windows.Forms.PictureBox
        Me.grb_sexo = New System.Windows.Forms.GroupBox
        Me.rdb_f = New System.Windows.Forms.RadioButton
        Me.rdb_m = New System.Windows.Forms.RadioButton
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_cadastrar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.rad_cpf = New System.Windows.Forms.RadioButton
        Me.rad_cart_trab = New System.Windows.Forms.RadioButton
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.rad_rg = New System.Windows.Forms.RadioButton
        Me.rad_nome = New System.Windows.Forms.RadioButton
        Me.lst_consulta = New System.Windows.Forms.ListBox
        Me.dlg_imagens = New System.Windows.Forms.OpenFileDialog
        Me.grb_cadastro.SuspendLayout()
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_sexo.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.White
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(71, 19)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(317, 22)
        Me.txt_nome.TabIndex = 0
        Me.tlp_login.SetToolTip(Me.txt_nome, "Digite o nome do funcionário")
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(6, 20)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(63, 16)
        Me.lbl_nome.TabIndex = 2
        Me.lbl_nome.Text = "Nome* :"
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.txt_cpf)
        Me.grb_cadastro.Controls.Add(Me.txt_endereco)
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.btn_carregar_foto)
        Me.grb_cadastro.Controls.Add(Me.txt_dtnascimento)
        Me.grb_cadastro.Controls.Add(Me.btn_cam)
        Me.grb_cadastro.Controls.Add(Me.txt_cel)
        Me.grb_cadastro.Controls.Add(Me.Label1)
        Me.grb_cadastro.Controls.Add(Me.txt_tel)
        Me.grb_cadastro.Controls.Add(Me.Label9)
        Me.grb_cadastro.Controls.Add(Me.Label8)
        Me.grb_cadastro.Controls.Add(Me.txt_rg)
        Me.grb_cadastro.Controls.Add(Me.Label5)
        Me.grb_cadastro.Controls.Add(Me.Label4)
        Me.grb_cadastro.Controls.Add(Me.ptb_foto)
        Me.grb_cadastro.Controls.Add(Me.grb_sexo)
        Me.grb_cadastro.Controls.Add(Me.txt_nome)
        Me.grb_cadastro.Controls.Add(Me.lbl_nome)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(394, 311)
        Me.grb_cadastro.TabIndex = 4
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Professor"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(130, 213)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(114, 20)
        Me.txt_cpf.TabIndex = 6
        '
        'txt_endereco
        '
        Me.txt_endereco.BackColor = System.Drawing.Color.White
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(95, 50)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(293, 22)
        Me.txt_endereco.TabIndex = 1
        Me.tlp_login.SetToolTip(Me.txt_endereco, "Digite o nome do funcionário")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Endereço* :"
        '
        'btn_carregar_foto
        '
        Me.btn_carregar_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Search__2_
        Me.btn_carregar_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_carregar_foto.FlatAppearance.BorderSize = 0
        Me.btn_carregar_foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_carregar_foto.Location = New System.Drawing.Point(262, 251)
        Me.btn_carregar_foto.Name = "btn_carregar_foto"
        Me.btn_carregar_foto.Size = New System.Drawing.Size(55, 51)
        Me.btn_carregar_foto.TabIndex = 45
        Me.btn_carregar_foto.UseVisualStyleBackColor = True
        '
        'txt_dtnascimento
        '
        Me.txt_dtnascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dtnascimento.Location = New System.Drawing.Point(130, 147)
        Me.txt_dtnascimento.Mask = "00/00/0000"
        Me.txt_dtnascimento.Name = "txt_dtnascimento"
        Me.txt_dtnascimento.Size = New System.Drawing.Size(114, 22)
        Me.txt_dtnascimento.TabIndex = 4
        Me.txt_dtnascimento.ValidatingType = GetType(Date)
        '
        'btn_cam
        '
        Me.btn_cam.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Camera
        Me.btn_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cam.FlatAppearance.BorderSize = 0
        Me.btn_cam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_cam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cam.Location = New System.Drawing.Point(323, 251)
        Me.btn_cam.Name = "btn_cam"
        Me.btn_cam.Size = New System.Drawing.Size(56, 51)
        Me.btn_cam.TabIndex = 46
        Me.btn_cam.UseVisualStyleBackColor = True
        '
        'txt_cel
        '
        Me.txt_cel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cel.Location = New System.Drawing.Point(105, 115)
        Me.txt_cel.Mask = "(00) 0000-0000"
        Me.txt_cel.Name = "txt_cel"
        Me.txt_cel.Size = New System.Drawing.Size(139, 22)
        Me.txt_cel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Cel*:"
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(105, 78)
        Me.txt_tel.Mask = "(00) 0000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(139, 22)
        Me.txt_tel.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Telefone*:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "DT Nascimento*:"
        '
        'txt_rg
        '
        Me.txt_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rg.Location = New System.Drawing.Point(130, 179)
        Me.txt_rg.Mask = "00,000,000-a"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(114, 22)
        Me.txt_rg.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CPF*:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "RG*:"
        '
        'ptb_foto
        '
        Me.ptb_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Contact
        Me.ptb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb_foto.Location = New System.Drawing.Point(250, 78)
        Me.ptb_foto.Name = "ptb_foto"
        Me.ptb_foto.Size = New System.Drawing.Size(138, 168)
        Me.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_foto.TabIndex = 5
        Me.ptb_foto.TabStop = False
        '
        'grb_sexo
        '
        Me.grb_sexo.Controls.Add(Me.rdb_f)
        Me.grb_sexo.Controls.Add(Me.rdb_m)
        Me.grb_sexo.ForeColor = System.Drawing.Color.Black
        Me.grb_sexo.Location = New System.Drawing.Point(10, 238)
        Me.grb_sexo.Name = "grb_sexo"
        Me.grb_sexo.Size = New System.Drawing.Size(234, 66)
        Me.grb_sexo.TabIndex = 7
        Me.grb_sexo.TabStop = False
        Me.grb_sexo.Text = "Sexo*"
        Me.tlp_login.SetToolTip(Me.grb_sexo, "Escolha o sexo do funcionário")
        '
        'rdb_f
        '
        Me.rdb_f.AutoSize = True
        Me.rdb_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_f.Location = New System.Drawing.Point(116, 28)
        Me.rdb_f.Name = "rdb_f"
        Me.rdb_f.Size = New System.Drawing.Size(89, 20)
        Me.rdb_f.TabIndex = 9
        Me.rdb_f.Text = "Feminino"
        Me.rdb_f.UseVisualStyleBackColor = True
        '
        'rdb_m
        '
        Me.rdb_m.AutoSize = True
        Me.rdb_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_m.Location = New System.Drawing.Point(6, 28)
        Me.rdb_m.Name = "rdb_m"
        Me.rdb_m.Size = New System.Drawing.Size(96, 20)
        Me.rdb_m.TabIndex = 8
        Me.rdb_m.Text = "Masculino"
        Me.rdb_m.UseVisualStyleBackColor = True
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_cadastrar, Me.mnu_alterar, Me.mnu_limpar, Me.mnu_consulta, Me.mnu_excluir, Me.mnu_salvar})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(720, 68)
        Me.mnu_sup.TabIndex = 25
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_cadastrar
        '
        Me.mnu_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_cadastrar.Image = Global.Lótus_1._0.My.Resources.Resources.Word_Processor
        Me.mnu_cadastrar.Name = "mnu_cadastrar"
        Me.mnu_cadastrar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_cadastrar.Text = "Novo"
        Me.mnu_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_cadastrar.ToolTipText = "Adiciona um novo cadastro"
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
        Me.mnu_alterar.ToolTipText = "Altera um cadastro"
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
        Me.mnu_consulta.ToolTipText = "Consulta um cadastro"
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
        Me.mnu_excluir.ToolTipText = "Exclui um cadastro"
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
        'tlp_login
        '
        Me.tlp_login.AutomaticDelay = 500000
        Me.tlp_login.AutoPopDelay = 5000
        Me.tlp_login.InitialDelay = 500
        Me.tlp_login.IsBalloon = True
        Me.tlp_login.ReshowDelay = 1
        Me.tlp_login.ShowAlways = True
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.rad_cpf)
        Me.grb_consulta.Controls.Add(Me.rad_cart_trab)
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.rad_rg)
        Me.grb_consulta.Controls.Add(Me.rad_nome)
        Me.grb_consulta.Controls.Add(Me.lst_consulta)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(412, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(296, 311)
        Me.grb_consulta.TabIndex = 61
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'rad_cpf
        '
        Me.rad_cpf.AutoSize = True
        Me.rad_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_cpf.Location = New System.Drawing.Point(216, 41)
        Me.rad_cpf.Name = "rad_cpf"
        Me.rad_cpf.Size = New System.Drawing.Size(71, 17)
        Me.rad_cpf.TabIndex = 47
        Me.rad_cpf.TabStop = True
        Me.rad_cpf.Text = "Por CPF"
        Me.rad_cpf.UseVisualStyleBackColor = True
        '
        'rad_cart_trab
        '
        Me.rad_cart_trab.AutoSize = True
        Me.rad_cart_trab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_cart_trab.Location = New System.Drawing.Point(6, 41)
        Me.rad_cart_trab.Name = "rad_cart_trab"
        Me.rad_cart_trab.Size = New System.Drawing.Size(98, 17)
        Me.rad_cart_trab.TabIndex = 46
        Me.rad_cart_trab.TabStop = True
        Me.rad_cart_trab.Text = "Por Telefone"
        Me.rad_cart_trab.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Location = New System.Drawing.Point(4, 66)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(286, 20)
        Me.txt_pesquisa.TabIndex = 3
        '
        'rad_rg
        '
        Me.rad_rg.AutoSize = True
        Me.rad_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_rg.Location = New System.Drawing.Point(216, 16)
        Me.rad_rg.Name = "rad_rg"
        Me.rad_rg.Size = New System.Drawing.Size(74, 17)
        Me.rad_rg.TabIndex = 2
        Me.rad_rg.TabStop = True
        Me.rad_rg.Text = "Por R.G."
        Me.rad_rg.UseVisualStyleBackColor = True
        '
        'rad_nome
        '
        Me.rad_nome.AutoSize = True
        Me.rad_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_nome.Location = New System.Drawing.Point(6, 16)
        Me.rad_nome.Name = "rad_nome"
        Me.rad_nome.Size = New System.Drawing.Size(80, 17)
        Me.rad_nome.TabIndex = 1
        Me.rad_nome.TabStop = True
        Me.rad_nome.Text = "Por Nome"
        Me.rad_nome.UseVisualStyleBackColor = True
        '
        'lst_consulta
        '
        Me.lst_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta.FormattingEnabled = True
        Me.lst_consulta.HorizontalScrollbar = True
        Me.lst_consulta.ItemHeight = 16
        Me.lst_consulta.Location = New System.Drawing.Point(4, 92)
        Me.lst_consulta.Name = "lst_consulta"
        Me.lst_consulta.Size = New System.Drawing.Size(286, 212)
        Me.lst_consulta.TabIndex = 0
        '
        'dlg_imagens
        '
        Me.dlg_imagens.FileName = "OpenFileDialog1"
        Me.dlg_imagens.Filter = "All Files|*.*"
        '
        'Professor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(720, 392)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Professor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professor"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_sexo.ResumeLayout(False)
        Me.grb_sexo.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nome As System.Windows.Forms.Label
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents grb_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_f As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_m As System.Windows.Forms.RadioButton
    Friend WithEvents ptb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_cadastrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents txt_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_dtnascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_rg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_carregar_foto As System.Windows.Forms.Button
    Friend WithEvents btn_cam As System.Windows.Forms.Button
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents rad_rg As System.Windows.Forms.RadioButton
    Friend WithEvents rad_nome As System.Windows.Forms.RadioButton
    Friend WithEvents lst_consulta As System.Windows.Forms.ListBox
    Friend WithEvents rad_cpf As System.Windows.Forms.RadioButton
    Friend WithEvents rad_cart_trab As System.Windows.Forms.RadioButton
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dlg_imagens As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_cpf As System.Windows.Forms.MaskedTextBox
End Class
