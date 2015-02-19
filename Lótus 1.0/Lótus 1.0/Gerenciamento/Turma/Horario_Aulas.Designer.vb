<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horario_Aulas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horario_Aulas))
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.lbl_aulas = New System.Windows.Forms.Label
        Me.lbl_seg = New System.Windows.Forms.Label
        Me.lbl_ter = New System.Windows.Forms.Label
        Me.lbl_qua = New System.Windows.Forms.Label
        Me.lbl_qui = New System.Windows.Forms.Label
        Me.lbl_sex = New System.Windows.Forms.Label
        Me.pnl_aula = New System.Windows.Forms.Panel
        Me.pnl_sex = New System.Windows.Forms.Panel
        Me.pnl_qui = New System.Windows.Forms.Panel
        Me.pnl_qua = New System.Windows.Forms.Panel
        Me.pnl_ter = New System.Windows.Forms.Panel
        Me.pnl_seg = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.lbl_periodo = New System.Windows.Forms.Label
        Me.lbl_modulo = New System.Windows.Forms.Label
        Me.lbl_curso = New System.Windows.Forms.Label
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.rad_modulo = New System.Windows.Forms.RadioButton
        Me.rad_ano = New System.Windows.Forms.RadioButton
        Me.rad_curso = New System.Windows.Forms.RadioButton
        Me.rad_nome = New System.Windows.Forms.RadioButton
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.lst_consulta_turma = New System.Windows.Forms.ListBox
        Me.grb_cadastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_cadastro
        '
        Me.grb_cadastro.Controls.Add(Me.lbl_aulas)
        Me.grb_cadastro.Controls.Add(Me.lbl_seg)
        Me.grb_cadastro.Controls.Add(Me.lbl_ter)
        Me.grb_cadastro.Controls.Add(Me.lbl_qua)
        Me.grb_cadastro.Controls.Add(Me.lbl_qui)
        Me.grb_cadastro.Controls.Add(Me.lbl_sex)
        Me.grb_cadastro.Controls.Add(Me.pnl_aula)
        Me.grb_cadastro.Controls.Add(Me.pnl_sex)
        Me.grb_cadastro.Controls.Add(Me.pnl_qui)
        Me.grb_cadastro.Controls.Add(Me.pnl_qua)
        Me.grb_cadastro.Controls.Add(Me.pnl_ter)
        Me.grb_cadastro.Controls.Add(Me.pnl_seg)
        Me.grb_cadastro.Controls.Add(Me.GroupBox1)
        Me.grb_cadastro.Controls.Add(Me.lbl_periodo)
        Me.grb_cadastro.Controls.Add(Me.lbl_modulo)
        Me.grb_cadastro.Controls.Add(Me.lbl_curso)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(762, 375)
        Me.grb_cadastro.TabIndex = 0
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Horário"
        '
        'lbl_aulas
        '
        Me.lbl_aulas.AutoSize = True
        Me.lbl_aulas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aulas.Location = New System.Drawing.Point(39, 95)
        Me.lbl_aulas.Name = "lbl_aulas"
        Me.lbl_aulas.Size = New System.Drawing.Size(48, 17)
        Me.lbl_aulas.TabIndex = 17
        Me.lbl_aulas.Text = "Aulas"
        '
        'lbl_seg
        '
        Me.lbl_seg.AutoSize = True
        Me.lbl_seg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seg.Location = New System.Drawing.Point(157, 95)
        Me.lbl_seg.Name = "lbl_seg"
        Me.lbl_seg.Size = New System.Drawing.Size(72, 17)
        Me.lbl_seg.TabIndex = 3
        Me.lbl_seg.Text = "Segunda"
        '
        'lbl_ter
        '
        Me.lbl_ter.AutoSize = True
        Me.lbl_ter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ter.Location = New System.Drawing.Point(286, 95)
        Me.lbl_ter.Name = "lbl_ter"
        Me.lbl_ter.Size = New System.Drawing.Size(50, 17)
        Me.lbl_ter.TabIndex = 5
        Me.lbl_ter.Text = "Terça"
        '
        'lbl_qua
        '
        Me.lbl_qua.AutoSize = True
        Me.lbl_qua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qua.Location = New System.Drawing.Point(409, 95)
        Me.lbl_qua.Name = "lbl_qua"
        Me.lbl_qua.Size = New System.Drawing.Size(58, 17)
        Me.lbl_qua.TabIndex = 7
        Me.lbl_qua.Text = "Quarta"
        '
        'lbl_qui
        '
        Me.lbl_qui.AutoSize = True
        Me.lbl_qui.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qui.Location = New System.Drawing.Point(538, 95)
        Me.lbl_qui.Name = "lbl_qui"
        Me.lbl_qui.Size = New System.Drawing.Size(56, 17)
        Me.lbl_qui.TabIndex = 6
        Me.lbl_qui.Text = "Quinta"
        '
        'lbl_sex
        '
        Me.lbl_sex.AutoSize = True
        Me.lbl_sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sex.Location = New System.Drawing.Point(668, 95)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(48, 17)
        Me.lbl_sex.TabIndex = 4
        Me.lbl_sex.Text = "Sexta"
        '
        'pnl_aula
        '
        Me.pnl_aula.AutoScroll = True
        Me.pnl_aula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_aula.Location = New System.Drawing.Point(6, 115)
        Me.pnl_aula.Name = "pnl_aula"
        Me.pnl_aula.Size = New System.Drawing.Size(112, 254)
        Me.pnl_aula.TabIndex = 16
        '
        'pnl_sex
        '
        Me.pnl_sex.AutoScroll = True
        Me.pnl_sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_sex.Location = New System.Drawing.Point(632, 115)
        Me.pnl_sex.Name = "pnl_sex"
        Me.pnl_sex.Size = New System.Drawing.Size(121, 254)
        Me.pnl_sex.TabIndex = 15
        '
        'pnl_qui
        '
        Me.pnl_qui.AutoScroll = True
        Me.pnl_qui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_qui.Location = New System.Drawing.Point(505, 115)
        Me.pnl_qui.Name = "pnl_qui"
        Me.pnl_qui.Size = New System.Drawing.Size(121, 254)
        Me.pnl_qui.TabIndex = 14
        '
        'pnl_qua
        '
        Me.pnl_qua.AutoScroll = True
        Me.pnl_qua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_qua.Location = New System.Drawing.Point(378, 115)
        Me.pnl_qua.Name = "pnl_qua"
        Me.pnl_qua.Size = New System.Drawing.Size(121, 254)
        Me.pnl_qua.TabIndex = 13
        '
        'pnl_ter
        '
        Me.pnl_ter.AutoScroll = True
        Me.pnl_ter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_ter.Location = New System.Drawing.Point(251, 115)
        Me.pnl_ter.Name = "pnl_ter"
        Me.pnl_ter.Size = New System.Drawing.Size(121, 254)
        Me.pnl_ter.TabIndex = 12
        '
        'pnl_seg
        '
        Me.pnl_seg.AutoScroll = True
        Me.pnl_seg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_seg.Location = New System.Drawing.Point(124, 115)
        Me.pnl_seg.Name = "pnl_seg"
        Me.pnl_seg.Size = New System.Drawing.Size(121, 254)
        Me.pnl_seg.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_turma)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 71)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nome da Turma - Ano - Semestre"
        '
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turma.ForeColor = System.Drawing.Color.Black
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(6, 42)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(735, 24)
        Me.cmb_turma.TabIndex = 0
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(651, 48)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(0, 15)
        Me.lbl_periodo.TabIndex = 8
        '
        'lbl_modulo
        '
        Me.lbl_modulo.AutoSize = True
        Me.lbl_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modulo.Location = New System.Drawing.Point(375, 48)
        Me.lbl_modulo.Name = "lbl_modulo"
        Me.lbl_modulo.Size = New System.Drawing.Size(0, 15)
        Me.lbl_modulo.TabIndex = 7
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curso.Location = New System.Drawing.Point(518, 48)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(0, 15)
        Me.lbl_curso.TabIndex = 6
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
        Me.mnu_sup.Size = New System.Drawing.Size(1043, 68)
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
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.rad_modulo)
        Me.grb_consulta.Controls.Add(Me.rad_ano)
        Me.grb_consulta.Controls.Add(Me.rad_curso)
        Me.grb_consulta.Controls.Add(Me.rad_nome)
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.lst_consulta_turma)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(780, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(263, 375)
        Me.grb_consulta.TabIndex = 65
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'rad_modulo
        '
        Me.rad_modulo.AutoSize = True
        Me.rad_modulo.Location = New System.Drawing.Point(164, 42)
        Me.rad_modulo.Name = "rad_modulo"
        Me.rad_modulo.Size = New System.Drawing.Size(93, 17)
        Me.rad_modulo.TabIndex = 67
        Me.rad_modulo.TabStop = True
        Me.rad_modulo.Text = "Por Módulo:"
        Me.rad_modulo.UseVisualStyleBackColor = True
        '
        'rad_ano
        '
        Me.rad_ano.AutoSize = True
        Me.rad_ano.Location = New System.Drawing.Point(8, 42)
        Me.rad_ano.Name = "rad_ano"
        Me.rad_ano.Size = New System.Drawing.Size(74, 17)
        Me.rad_ano.TabIndex = 66
        Me.rad_ano.TabStop = True
        Me.rad_ano.Text = "Por Ano:"
        Me.rad_ano.UseVisualStyleBackColor = True
        '
        'rad_curso
        '
        Me.rad_curso.AutoSize = True
        Me.rad_curso.Location = New System.Drawing.Point(164, 19)
        Me.rad_curso.Name = "rad_curso"
        Me.rad_curso.Size = New System.Drawing.Size(84, 17)
        Me.rad_curso.TabIndex = 65
        Me.rad_curso.TabStop = True
        Me.rad_curso.Text = "Por Curso:"
        Me.rad_curso.UseVisualStyleBackColor = True
        '
        'rad_nome
        '
        Me.rad_nome.AutoSize = True
        Me.rad_nome.Location = New System.Drawing.Point(8, 19)
        Me.rad_nome.Name = "rad_nome"
        Me.rad_nome.Size = New System.Drawing.Size(84, 17)
        Me.rad_nome.TabIndex = 64
        Me.rad_nome.TabStop = True
        Me.rad_nome.Text = "Por Nome:"
        Me.rad_nome.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(8, 63)
        Me.txt_pesquisa.MaxLength = 30
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(249, 20)
        Me.txt_pesquisa.TabIndex = 57
        '
        'lst_consulta_turma
        '
        Me.lst_consulta_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta_turma.FormattingEnabled = True
        Me.lst_consulta_turma.HorizontalScrollbar = True
        Me.lst_consulta_turma.ItemHeight = 16
        Me.lst_consulta_turma.Location = New System.Drawing.Point(8, 89)
        Me.lst_consulta_turma.Name = "lst_consulta_turma"
        Me.lst_consulta_turma.Size = New System.Drawing.Size(249, 276)
        Me.lst_consulta_turma.TabIndex = 53
        '
        'Horario_Aulas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(779, 469)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_cadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Horario_Aulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horario das Aulas"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_modulo As System.Windows.Forms.Label
    Friend WithEvents lbl_curso As System.Windows.Forms.Label
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents rad_modulo As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ano As System.Windows.Forms.RadioButton
    Friend WithEvents rad_curso As System.Windows.Forms.RadioButton
    Friend WithEvents rad_nome As System.Windows.Forms.RadioButton
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents lst_consulta_turma As System.Windows.Forms.ListBox
    Friend WithEvents pnl_sex As System.Windows.Forms.Panel
    Friend WithEvents pnl_qui As System.Windows.Forms.Panel
    Friend WithEvents pnl_qua As System.Windows.Forms.Panel
    Friend WithEvents pnl_ter As System.Windows.Forms.Panel
    Friend WithEvents pnl_seg As System.Windows.Forms.Panel
    Friend WithEvents lbl_sex As System.Windows.Forms.Label
    Friend WithEvents lbl_qui As System.Windows.Forms.Label
    Friend WithEvents lbl_qua As System.Windows.Forms.Label
    Friend WithEvents lbl_ter As System.Windows.Forms.Label
    Friend WithEvents lbl_seg As System.Windows.Forms.Label
    Friend WithEvents pnl_aula As System.Windows.Forms.Panel
    Friend WithEvents lbl_aulas As System.Windows.Forms.Label
End Class
