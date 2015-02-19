<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faltas_Professor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faltas_Professor))
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.lbl_obs = New System.Windows.Forms.Label
        Me.txt_data2 = New System.Windows.Forms.MaskedTextBox
        Me.lbl_data2 = New System.Windows.Forms.Label
        Me.txt_data1 = New System.Windows.Forms.MaskedTextBox
        Me.lbl_data1 = New System.Windows.Forms.Label
        Me.txt_obs = New System.Windows.Forms.TextBox
        Me.cmb_professor = New System.Windows.Forms.ComboBox
        Me.lbl_nome = New System.Windows.Forms.Label
        Me.grb_tipofalta = New System.Windows.Forms.GroupBox
        Me.rad_reuniao = New System.Windows.Forms.RadioButton
        Me.rad_capacitacao = New System.Windows.Forms.RadioButton
        Me.rad_licença = New System.Windows.Forms.RadioButton
        Me.rad_aula_just = New System.Windows.Forms.RadioButton
        Me.rad_atraso = New System.Windows.Forms.RadioButton
        Me.rad_aula_injust = New System.Windows.Forms.RadioButton
        Me.rad_medica = New System.Windows.Forms.RadioButton
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_pesquisa = New System.Windows.Forms.ComboBox
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grb_mes = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_mes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_ano = New System.Windows.Forms.TextBox
        Me.lst_consulta = New System.Windows.Forms.ListBox
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_cadastro.SuspendLayout()
        Me.grb_tipofalta.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.grb_mes.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_cadastro
        '
        Me.grb_cadastro.Controls.Add(Me.lbl_obs)
        Me.grb_cadastro.Controls.Add(Me.txt_data2)
        Me.grb_cadastro.Controls.Add(Me.lbl_data2)
        Me.grb_cadastro.Controls.Add(Me.txt_data1)
        Me.grb_cadastro.Controls.Add(Me.lbl_data1)
        Me.grb_cadastro.Controls.Add(Me.txt_obs)
        Me.grb_cadastro.Controls.Add(Me.cmb_professor)
        Me.grb_cadastro.Controls.Add(Me.lbl_nome)
        Me.grb_cadastro.Controls.Add(Me.grb_tipofalta)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 75)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(299, 390)
        Me.grb_cadastro.TabIndex = 0
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastro"
        '
        'lbl_obs
        '
        Me.lbl_obs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obs.Location = New System.Drawing.Point(93, 251)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(101, 16)
        Me.lbl_obs.TabIndex = 52
        Me.lbl_obs.Text = "Observação :"
        '
        'txt_data2
        '
        Me.txt_data2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data2.Location = New System.Drawing.Point(167, 214)
        Me.txt_data2.Mask = "00/00/0000"
        Me.txt_data2.Name = "txt_data2"
        Me.txt_data2.Size = New System.Drawing.Size(81, 22)
        Me.txt_data2.TabIndex = 10
        Me.txt_data2.ValidatingType = GetType(Date)
        Me.txt_data2.Visible = False
        '
        'lbl_data2
        '
        Me.lbl_data2.AutoSize = True
        Me.lbl_data2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data2.Location = New System.Drawing.Point(176, 186)
        Me.lbl_data2.Name = "lbl_data2"
        Me.lbl_data2.Size = New System.Drawing.Size(75, 16)
        Me.lbl_data2.TabIndex = 50
        Me.lbl_data2.Text = "Término*:"
        Me.lbl_data2.Visible = False
        '
        'txt_data1
        '
        Me.txt_data1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data1.Location = New System.Drawing.Point(21, 214)
        Me.txt_data1.Mask = "00/00/0000"
        Me.txt_data1.Name = "txt_data1"
        Me.txt_data1.Size = New System.Drawing.Size(81, 22)
        Me.txt_data1.TabIndex = 9
        Me.txt_data1.ValidatingType = GetType(Date)
        '
        'lbl_data1
        '
        Me.lbl_data1.AutoSize = True
        Me.lbl_data1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data1.Location = New System.Drawing.Point(39, 186)
        Me.lbl_data1.Name = "lbl_data1"
        Me.lbl_data1.Size = New System.Drawing.Size(51, 16)
        Me.lbl_data1.TabIndex = 48
        Me.lbl_data1.Text = "Data*:"
        '
        'txt_obs
        '
        Me.txt_obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_obs.Location = New System.Drawing.Point(6, 270)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(271, 109)
        Me.txt_obs.TabIndex = 11
        Me.tlp_login.SetToolTip(Me.txt_obs, "Insira uma observação")
        '
        'cmb_professor
        '
        Me.cmb_professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_professor.FormattingEnabled = True
        Me.cmb_professor.Location = New System.Drawing.Point(6, 35)
        Me.cmb_professor.Name = "cmb_professor"
        Me.cmb_professor.Size = New System.Drawing.Size(287, 24)
        Me.cmb_professor.TabIndex = 0
        Me.tlp_login.SetToolTip(Me.cmb_professor, "Escolha o nome do funcionário")
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(109, 16)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(85, 16)
        Me.lbl_nome.TabIndex = 44
        Me.lbl_nome.Text = "Professor*:"
        '
        'grb_tipofalta
        '
        Me.grb_tipofalta.Controls.Add(Me.rad_reuniao)
        Me.grb_tipofalta.Controls.Add(Me.rad_capacitacao)
        Me.grb_tipofalta.Controls.Add(Me.rad_licença)
        Me.grb_tipofalta.Controls.Add(Me.rad_aula_just)
        Me.grb_tipofalta.Controls.Add(Me.rad_atraso)
        Me.grb_tipofalta.Controls.Add(Me.rad_aula_injust)
        Me.grb_tipofalta.Controls.Add(Me.rad_medica)
        Me.grb_tipofalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_tipofalta.ForeColor = System.Drawing.Color.Black
        Me.grb_tipofalta.Location = New System.Drawing.Point(6, 59)
        Me.grb_tipofalta.Name = "grb_tipofalta"
        Me.grb_tipofalta.Size = New System.Drawing.Size(287, 118)
        Me.grb_tipofalta.TabIndex = 39
        Me.grb_tipofalta.TabStop = False
        Me.grb_tipofalta.Text = "Tipo da Falta*"
        Me.tlp_login.SetToolTip(Me.grb_tipofalta, "Selecione o tipo de falta")
        '
        'rad_reuniao
        '
        Me.rad_reuniao.AutoSize = True
        Me.rad_reuniao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_reuniao.Location = New System.Drawing.Point(144, 95)
        Me.rad_reuniao.Name = "rad_reuniao"
        Me.rad_reuniao.Size = New System.Drawing.Size(84, 20)
        Me.rad_reuniao.TabIndex = 8
        Me.rad_reuniao.TabStop = True
        Me.rad_reuniao.Text = "Reunião"
        Me.rad_reuniao.UseVisualStyleBackColor = True
        '
        'rad_capacitacao
        '
        Me.rad_capacitacao.AutoSize = True
        Me.rad_capacitacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_capacitacao.Location = New System.Drawing.Point(6, 95)
        Me.rad_capacitacao.Name = "rad_capacitacao"
        Me.rad_capacitacao.Size = New System.Drawing.Size(114, 20)
        Me.rad_capacitacao.TabIndex = 4
        Me.rad_capacitacao.TabStop = True
        Me.rad_capacitacao.Text = "Capacitação"
        Me.rad_capacitacao.UseVisualStyleBackColor = True
        '
        'rad_licença
        '
        Me.rad_licença.AutoSize = True
        Me.rad_licença.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_licença.Location = New System.Drawing.Point(144, 70)
        Me.rad_licença.Name = "rad_licença"
        Me.rad_licença.Size = New System.Drawing.Size(135, 20)
        Me.rad_licença.TabIndex = 7
        Me.rad_licença.TabStop = True
        Me.rad_licença.Text = "Licença Médica"
        Me.rad_licença.UseVisualStyleBackColor = True
        '
        'rad_aula_just
        '
        Me.rad_aula_just.AutoSize = True
        Me.rad_aula_just.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_aula_just.Location = New System.Drawing.Point(6, 45)
        Me.rad_aula_just.Name = "rad_aula_just"
        Me.rad_aula_just.Size = New System.Drawing.Size(132, 20)
        Me.rad_aula_just.TabIndex = 5
        Me.rad_aula_just.TabStop = True
        Me.rad_aula_just.Text = "Falta Aula Just."
        Me.rad_aula_just.UseVisualStyleBackColor = True
        '
        'rad_atraso
        '
        Me.rad_atraso.AutoSize = True
        Me.rad_atraso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_atraso.Location = New System.Drawing.Point(82, 20)
        Me.rad_atraso.Name = "rad_atraso"
        Me.rad_atraso.Size = New System.Drawing.Size(110, 20)
        Me.rad_atraso.TabIndex = 1
        Me.rad_atraso.TabStop = True
        Me.rad_atraso.Text = "Falta Atraso"
        Me.rad_atraso.UseVisualStyleBackColor = True
        '
        'rad_aula_injust
        '
        Me.rad_aula_injust.AutoSize = True
        Me.rad_aula_injust.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_aula_injust.Location = New System.Drawing.Point(144, 45)
        Me.rad_aula_injust.Name = "rad_aula_injust"
        Me.rad_aula_injust.Size = New System.Drawing.Size(140, 20)
        Me.rad_aula_injust.TabIndex = 6
        Me.rad_aula_injust.TabStop = True
        Me.rad_aula_injust.Text = "Falta Aula Injust."
        Me.rad_aula_injust.UseVisualStyleBackColor = True
        '
        'rad_medica
        '
        Me.rad_medica.AutoSize = True
        Me.rad_medica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_medica.Location = New System.Drawing.Point(6, 70)
        Me.rad_medica.Name = "rad_medica"
        Me.rad_medica.Size = New System.Drawing.Size(116, 20)
        Me.rad_medica.TabIndex = 3
        Me.rad_medica.TabStop = True
        Me.rad_medica.Text = "Falta Médica"
        Me.rad_medica.UseVisualStyleBackColor = True
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
        'cmb_pesquisa
        '
        Me.cmb_pesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pesquisa.FormattingEnabled = True
        Me.cmb_pesquisa.Location = New System.Drawing.Point(76, 35)
        Me.cmb_pesquisa.Name = "cmb_pesquisa"
        Me.cmb_pesquisa.Size = New System.Drawing.Size(294, 24)
        Me.cmb_pesquisa.TabIndex = 46
        Me.tlp_login.SetToolTip(Me.cmb_pesquisa, "Escolha o nome do funcionário")
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.Label2)
        Me.grb_consulta.Controls.Add(Me.cmb_pesquisa)
        Me.grb_consulta.Controls.Add(Me.grb_mes)
        Me.grb_consulta.Controls.Add(Me.lst_consulta)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(317, 75)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(449, 390)
        Me.grb_consulta.TabIndex = 62
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Professor"
        '
        'grb_mes
        '
        Me.grb_mes.Controls.Add(Me.Label1)
        Me.grb_mes.Controls.Add(Me.cmb_mes)
        Me.grb_mes.Controls.Add(Me.Label3)
        Me.grb_mes.Controls.Add(Me.txt_ano)
        Me.grb_mes.ForeColor = System.Drawing.Color.Black
        Me.grb_mes.Location = New System.Drawing.Point(76, 70)
        Me.grb_mes.Name = "grb_mes"
        Me.grb_mes.Size = New System.Drawing.Size(294, 59)
        Me.grb_mes.TabIndex = 2
        Me.grb_mes.TabStop = False
        Me.grb_mes.Text = "Tipo de Exibição*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Mês"
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho ", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro", "Todos"})
        Me.cmb_mes.Location = New System.Drawing.Point(6, 32)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(138, 24)
        Me.cmb_mes.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Ano"
        '
        'txt_ano
        '
        Me.txt_ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.Location = New System.Drawing.Point(150, 33)
        Me.txt_ano.MaxLength = 5
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(138, 22)
        Me.txt_ano.TabIndex = 70
        Me.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_consulta
        '
        Me.lst_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta.FormattingEnabled = True
        Me.lst_consulta.HorizontalScrollbar = True
        Me.lst_consulta.ItemHeight = 16
        Me.lst_consulta.Location = New System.Drawing.Point(6, 135)
        Me.lst_consulta.Name = "lst_consulta"
        Me.lst_consulta.Size = New System.Drawing.Size(437, 244)
        Me.lst_consulta.TabIndex = 0
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
        Me.mnu_sup.Size = New System.Drawing.Size(779, 68)
        Me.mnu_sup.TabIndex = 63
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
        'Faltas_Professor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 473)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.grb_cadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Faltas_Professor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faltas de Professores"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_tipofalta.ResumeLayout(False)
        Me.grb_tipofalta.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.grb_mes.ResumeLayout(False)
        Me.grb_mes.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_professor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_nome As System.Windows.Forms.Label
    Friend WithEvents grb_tipofalta As System.Windows.Forms.GroupBox
    Friend WithEvents rad_aula_injust As System.Windows.Forms.RadioButton
    Friend WithEvents rad_medica As System.Windows.Forms.RadioButton
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents rad_atraso As System.Windows.Forms.RadioButton
    Friend WithEvents rad_reuniao As System.Windows.Forms.RadioButton
    Friend WithEvents rad_capacitacao As System.Windows.Forms.RadioButton
    Friend WithEvents rad_licença As System.Windows.Forms.RadioButton
    Friend WithEvents rad_aula_just As System.Windows.Forms.RadioButton
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents lbl_data1 As System.Windows.Forms.Label
    Friend WithEvents txt_data1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_data2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_data2 As System.Windows.Forms.Label
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents lst_consulta As System.Windows.Forms.ListBox
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_obs As System.Windows.Forms.Label
    Friend WithEvents grb_mes As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ano As System.Windows.Forms.TextBox
    Friend WithEvents cmb_pesquisa As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
