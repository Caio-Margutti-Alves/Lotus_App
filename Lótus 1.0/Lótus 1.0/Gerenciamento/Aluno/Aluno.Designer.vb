<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aluno))
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.rad_email = New System.Windows.Forms.RadioButton
        Me.rad_matricula = New System.Windows.Forms.RadioButton
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.rad_rg = New System.Windows.Forms.RadioButton
        Me.rad_nome = New System.Windows.Forms.RadioButton
        Me.lst_consulta_aluno = New System.Windows.Forms.ListBox
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.txt_endereco = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox
        Me.lbl_camposobrigatorios = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_carregar_foto = New System.Windows.Forms.Button
        Me.btn_cam = New System.Windows.Forms.Button
        Me.ptb_foto = New System.Windows.Forms.PictureBox
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.lbl_obs = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.lbl_email = New System.Windows.Forms.Label
        Me.txt_dtnascimento = New System.Windows.Forms.MaskedTextBox
        Me.txt_rg = New System.Windows.Forms.MaskedTextBox
        Me.lbl_dtnascimento = New System.Windows.Forms.Label
        Me.lbl_rg = New System.Windows.Forms.Label
        Me.grb_sexo = New System.Windows.Forms.GroupBox
        Me.rdb_f = New System.Windows.Forms.RadioButton
        Me.rdb_m = New System.Windows.Forms.RadioButton
        Me.txt_matricula = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.dlg_imagens = New System.Windows.Forms.OpenFileDialog
        Me.grb_consulta.SuspendLayout()
        Me.grb_cadastro.SuspendLayout()
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_sexo.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.rad_email)
        Me.grb_consulta.Controls.Add(Me.rad_matricula)
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.rad_rg)
        Me.grb_consulta.Controls.Add(Me.rad_nome)
        Me.grb_consulta.Controls.Add(Me.lst_consulta_aluno)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(381, 72)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(255, 320)
        Me.grb_consulta.TabIndex = 63
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'rad_email
        '
        Me.rad_email.AutoSize = True
        Me.rad_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_email.Location = New System.Drawing.Point(172, 35)
        Me.rad_email.Name = "rad_email"
        Me.rad_email.Size = New System.Drawing.Size(78, 17)
        Me.rad_email.TabIndex = 47
        Me.rad_email.TabStop = True
        Me.rad_email.Text = "Por Email"
        Me.rad_email.UseVisualStyleBackColor = True
        '
        'rad_matricula
        '
        Me.rad_matricula.AutoSize = True
        Me.rad_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_matricula.Location = New System.Drawing.Point(6, 38)
        Me.rad_matricula.Name = "rad_matricula"
        Me.rad_matricula.Size = New System.Drawing.Size(102, 17)
        Me.rad_matricula.TabIndex = 46
        Me.rad_matricula.TabStop = True
        Me.rad_matricula.Text = "Por Matrícula"
        Me.rad_matricula.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Location = New System.Drawing.Point(6, 63)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(244, 20)
        Me.txt_pesquisa.TabIndex = 3
        '
        'rad_rg
        '
        Me.rad_rg.AutoSize = True
        Me.rad_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_rg.Location = New System.Drawing.Point(172, 12)
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
        Me.rad_nome.Location = New System.Drawing.Point(6, 12)
        Me.rad_nome.Name = "rad_nome"
        Me.rad_nome.Size = New System.Drawing.Size(80, 17)
        Me.rad_nome.TabIndex = 1
        Me.rad_nome.TabStop = True
        Me.rad_nome.Text = "Por Nome"
        Me.rad_nome.UseVisualStyleBackColor = True
        '
        'lst_consulta_aluno
        '
        Me.lst_consulta_aluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta_aluno.FormattingEnabled = True
        Me.lst_consulta_aluno.HorizontalScrollbar = True
        Me.lst_consulta_aluno.ItemHeight = 16
        Me.lst_consulta_aluno.Location = New System.Drawing.Point(6, 89)
        Me.lst_consulta_aluno.Name = "lst_consulta_aluno"
        Me.lst_consulta_aluno.Size = New System.Drawing.Size(244, 228)
        Me.lst_consulta_aluno.TabIndex = 0
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.txt_endereco)
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.txt_telefone)
        Me.grb_cadastro.Controls.Add(Me.lbl_camposobrigatorios)
        Me.grb_cadastro.Controls.Add(Me.Label1)
        Me.grb_cadastro.Controls.Add(Me.btn_carregar_foto)
        Me.grb_cadastro.Controls.Add(Me.btn_cam)
        Me.grb_cadastro.Controls.Add(Me.ptb_foto)
        Me.grb_cadastro.Controls.Add(Me.txt_obs)
        Me.grb_cadastro.Controls.Add(Me.lbl_obs)
        Me.grb_cadastro.Controls.Add(Me.txt_email)
        Me.grb_cadastro.Controls.Add(Me.lbl_email)
        Me.grb_cadastro.Controls.Add(Me.txt_dtnascimento)
        Me.grb_cadastro.Controls.Add(Me.txt_rg)
        Me.grb_cadastro.Controls.Add(Me.lbl_dtnascimento)
        Me.grb_cadastro.Controls.Add(Me.lbl_rg)
        Me.grb_cadastro.Controls.Add(Me.grb_sexo)
        Me.grb_cadastro.Controls.Add(Me.txt_matricula)
        Me.grb_cadastro.Controls.Add(Me.Label5)
        Me.grb_cadastro.Controls.Add(Me.txt_nome)
        Me.grb_cadastro.Controls.Add(Me.Label6)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(6, 72)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(369, 320)
        Me.grb_cadastro.TabIndex = 62
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Aluno"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(91, 270)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(272, 22)
        Me.txt_endereco.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Endereço* :"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(65, 242)
        Me.txt_telefone.Mask = "(00) 0000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(116, 22)
        Me.txt_telefone.TabIndex = 52
        '
        'lbl_camposobrigatorios
        '
        Me.lbl_camposobrigatorios.AutoSize = True
        Me.lbl_camposobrigatorios.Location = New System.Drawing.Point(211, 304)
        Me.lbl_camposobrigatorios.Name = "lbl_camposobrigatorios"
        Me.lbl_camposobrigatorios.Size = New System.Drawing.Size(140, 13)
        Me.lbl_camposobrigatorios.TabIndex = 33
        Me.lbl_camposobrigatorios.Text = "(*) Campos Obrigatórios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Tel*:"
        '
        'btn_carregar_foto
        '
        Me.btn_carregar_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Search__2_
        Me.btn_carregar_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_carregar_foto.FlatAppearance.BorderSize = 0
        Me.btn_carregar_foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_carregar_foto.Location = New System.Drawing.Point(3, 31)
        Me.btn_carregar_foto.Name = "btn_carregar_foto"
        Me.btn_carregar_foto.Size = New System.Drawing.Size(60, 47)
        Me.btn_carregar_foto.TabIndex = 43
        Me.btn_carregar_foto.UseVisualStyleBackColor = True
        '
        'btn_cam
        '
        Me.btn_cam.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Camera
        Me.btn_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cam.FlatAppearance.BorderSize = 0
        Me.btn_cam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_cam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cam.Location = New System.Drawing.Point(3, 84)
        Me.btn_cam.Name = "btn_cam"
        Me.btn_cam.Size = New System.Drawing.Size(60, 47)
        Me.btn_cam.TabIndex = 44
        Me.btn_cam.UseVisualStyleBackColor = True
        '
        'ptb_foto
        '
        Me.ptb_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Contact
        Me.ptb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb_foto.Enabled = False
        Me.ptb_foto.Location = New System.Drawing.Point(65, 19)
        Me.ptb_foto.Name = "ptb_foto"
        Me.ptb_foto.Size = New System.Drawing.Size(112, 133)
        Me.ptb_foto.TabIndex = 2
        Me.ptb_foto.TabStop = False
        '
        'txt_obs
        '
        Me.txt_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs.Location = New System.Drawing.Point(190, 103)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(173, 49)
        Me.txt_obs.TabIndex = 35
        '
        'lbl_obs
        '
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obs.Location = New System.Drawing.Point(258, 86)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(40, 16)
        Me.lbl_obs.TabIndex = 34
        Me.lbl_obs.Text = "Obs:"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(65, 214)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(298, 22)
        Me.txt_email.TabIndex = 32
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(7, 217)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(56, 16)
        Me.lbl_email.TabIndex = 31
        Me.lbl_email.Text = "E-Mail:"
        '
        'txt_dtnascimento
        '
        Me.txt_dtnascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dtnascimento.Location = New System.Drawing.Point(275, 186)
        Me.txt_dtnascimento.Mask = "00/00/0000"
        Me.txt_dtnascimento.Name = "txt_dtnascimento"
        Me.txt_dtnascimento.Size = New System.Drawing.Size(88, 22)
        Me.txt_dtnascimento.TabIndex = 11
        '
        'txt_rg
        '
        Me.txt_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rg.Location = New System.Drawing.Point(65, 186)
        Me.txt_rg.Mask = "00,000,000-a"
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(95, 22)
        Me.txt_rg.TabIndex = 10
        '
        'lbl_dtnascimento
        '
        Me.lbl_dtnascimento.AutoSize = True
        Me.lbl_dtnascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dtnascimento.Location = New System.Drawing.Point(166, 189)
        Me.lbl_dtnascimento.Name = "lbl_dtnascimento"
        Me.lbl_dtnascimento.Size = New System.Drawing.Size(103, 16)
        Me.lbl_dtnascimento.TabIndex = 7
        Me.lbl_dtnascimento.Text = "DT Nascimt* :"
        '
        'lbl_rg
        '
        Me.lbl_rg.AutoSize = True
        Me.lbl_rg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rg.Location = New System.Drawing.Point(7, 189)
        Me.lbl_rg.Name = "lbl_rg"
        Me.lbl_rg.Size = New System.Drawing.Size(52, 16)
        Me.lbl_rg.TabIndex = 6
        Me.lbl_rg.Text = "R.G.* :"
        '
        'grb_sexo
        '
        Me.grb_sexo.Controls.Add(Me.rdb_f)
        Me.grb_sexo.Controls.Add(Me.rdb_m)
        Me.grb_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_sexo.ForeColor = System.Drawing.Color.Black
        Me.grb_sexo.Location = New System.Drawing.Point(190, 19)
        Me.grb_sexo.Name = "grb_sexo"
        Me.grb_sexo.Size = New System.Drawing.Size(173, 64)
        Me.grb_sexo.TabIndex = 4
        Me.grb_sexo.TabStop = False
        Me.grb_sexo.Text = "Sexo*"
        '
        'rdb_f
        '
        Me.rdb_f.AutoSize = True
        Me.rdb_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_f.Location = New System.Drawing.Point(8, 42)
        Me.rdb_f.Name = "rdb_f"
        Me.rdb_f.Size = New System.Drawing.Size(89, 20)
        Me.rdb_f.TabIndex = 1
        Me.rdb_f.TabStop = True
        Me.rdb_f.Text = "Feminino"
        Me.rdb_f.UseVisualStyleBackColor = True
        '
        'rdb_m
        '
        Me.rdb_m.AutoSize = True
        Me.rdb_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_m.Location = New System.Drawing.Point(8, 19)
        Me.rdb_m.Name = "rdb_m"
        Me.rdb_m.Size = New System.Drawing.Size(96, 20)
        Me.rdb_m.TabIndex = 0
        Me.rdb_m.TabStop = True
        Me.rdb_m.Text = "Masculino"
        Me.rdb_m.UseVisualStyleBackColor = True
        '
        'txt_matricula
        '
        Me.txt_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricula.Location = New System.Drawing.Point(275, 242)
        Me.txt_matricula.MaxLength = 30
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(88, 22)
        Me.txt_matricula.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Matrícula* :"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(65, 158)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(298, 22)
        Me.txt_nome.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nome* :"
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_novo, Me.mnu_alterar, Me.mnu_limpar, Me.mnu_consulta, Me.mnu_excluir, Me.mnu_salvar})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(648, 68)
        Me.mnu_sup.TabIndex = 61
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
        Me.mnu_novo.ToolTipText = "Adiciona um novo cadastro"
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
        Me.mnu_alterar.ToolTipText = "Altera o cadastro"
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
        'dlg_imagens
        '
        Me.dlg_imagens.FileName = "OpenFileDialog1"
        Me.dlg_imagens.Filter = "All Files|*.*"
        '
        'Aluno
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(648, 404)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.mnu_sup)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aluno"
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_sexo.ResumeLayout(False)
        Me.grb_sexo.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents rad_email As System.Windows.Forms.RadioButton
    Friend WithEvents rad_matricula As System.Windows.Forms.RadioButton
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents rad_rg As System.Windows.Forms.RadioButton
    Friend WithEvents rad_nome As System.Windows.Forms.RadioButton
    Friend WithEvents lst_consulta_aluno As System.Windows.Forms.ListBox
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_carregar_foto As System.Windows.Forms.Button
    Friend WithEvents btn_cam As System.Windows.Forms.Button
    Friend WithEvents ptb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents lbl_obs As System.Windows.Forms.Label
    Friend WithEvents lbl_camposobrigatorios As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents txt_dtnascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_rg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_dtnascimento As System.Windows.Forms.Label
    Friend WithEvents lbl_rg As System.Windows.Forms.Label
    Friend WithEvents grb_sexo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_f As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_m As System.Windows.Forms.RadioButton
    Friend WithEvents txt_matricula As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlg_imagens As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
End Class
