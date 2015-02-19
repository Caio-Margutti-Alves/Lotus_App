<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turma))
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.cmb_modulo = New System.Windows.Forms.ComboBox
        Me.txt_ano = New System.Windows.Forms.TextBox
        Me.txt_fim = New System.Windows.Forms.MaskedTextBox
        Me.lbl_fim = New System.Windows.Forms.Label
        Me.txt_inicio = New System.Windows.Forms.MaskedTextBox
        Me.lbl_inicio = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_curso = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmb_semestre = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_periodo = New System.Windows.Forms.ComboBox
        Me.lbl_periodo = New System.Windows.Forms.Label
        Me.lst_consulta_turma = New System.Windows.Forms.ListBox
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.rad_modulo = New System.Windows.Forms.RadioButton
        Me.rad_ano = New System.Windows.Forms.RadioButton
        Me.rad_curso = New System.Windows.Forms.RadioButton
        Me.rad_nome = New System.Windows.Forms.RadioButton
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_cadastro.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.cmb_modulo)
        Me.grb_cadastro.Controls.Add(Me.txt_ano)
        Me.grb_cadastro.Controls.Add(Me.txt_fim)
        Me.grb_cadastro.Controls.Add(Me.lbl_fim)
        Me.grb_cadastro.Controls.Add(Me.txt_inicio)
        Me.grb_cadastro.Controls.Add(Me.lbl_inicio)
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.txt_nome)
        Me.grb_cadastro.Controls.Add(Me.Label1)
        Me.grb_cadastro.Controls.Add(Me.cmb_curso)
        Me.grb_cadastro.Controls.Add(Me.Label11)
        Me.grb_cadastro.Controls.Add(Me.cmb_semestre)
        Me.grb_cadastro.Controls.Add(Me.Label12)
        Me.grb_cadastro.Controls.Add(Me.Label13)
        Me.grb_cadastro.Controls.Add(Me.cmb_periodo)
        Me.grb_cadastro.Controls.Add(Me.lbl_periodo)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(328, 294)
        Me.grb_cadastro.TabIndex = 48
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Turma"
        '
        'cmb_modulo
        '
        Me.cmb_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_modulo.FormattingEnabled = True
        Me.cmb_modulo.Location = New System.Drawing.Point(166, 97)
        Me.cmb_modulo.Name = "cmb_modulo"
        Me.cmb_modulo.Size = New System.Drawing.Size(156, 24)
        Me.cmb_modulo.TabIndex = 2
        '
        'txt_ano
        '
        Me.txt_ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.Location = New System.Drawing.Point(236, 201)
        Me.txt_ano.MaxLength = 4
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(86, 22)
        Me.txt_ano.TabIndex = 5
        '
        'txt_fim
        '
        Me.txt_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fim.Location = New System.Drawing.Point(236, 268)
        Me.txt_fim.Mask = "00/00/0000"
        Me.txt_fim.Name = "txt_fim"
        Me.txt_fim.Size = New System.Drawing.Size(86, 22)
        Me.txt_fim.TabIndex = 7
        Me.txt_fim.ValidatingType = GetType(Date)
        '
        'lbl_fim
        '
        Me.lbl_fim.AutoSize = True
        Me.lbl_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fim.Location = New System.Drawing.Point(8, 271)
        Me.lbl_fim.Name = "lbl_fim"
        Me.lbl_fim.Size = New System.Drawing.Size(135, 16)
        Me.lbl_fim.TabIndex = 72
        Me.lbl_fim.Text = "Fim do Semestre*:"
        '
        'txt_inicio
        '
        Me.txt_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inicio.Location = New System.Drawing.Point(236, 236)
        Me.txt_inicio.Mask = "00/00/0000"
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(86, 22)
        Me.txt_inicio.TabIndex = 6
        Me.txt_inicio.ValidatingType = GetType(Date)
        '
        'lbl_inicio
        '
        Me.lbl_inicio.AutoSize = True
        Me.lbl_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inicio.Location = New System.Drawing.Point(8, 239)
        Me.lbl_inicio.Name = "lbl_inicio"
        Me.lbl_inicio.Size = New System.Drawing.Size(147, 16)
        Me.lbl_inicio.TabIndex = 70
        Me.lbl_inicio.Text = "Inicio do Semestre*:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Modulo*:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(115, 28)
        Me.txt_nome.MaxLength = 30
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(207, 22)
        Me.txt_nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Turma* :"
        '
        'cmb_curso
        '
        Me.cmb_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_curso.FormattingEnabled = True
        Me.cmb_curso.Location = New System.Drawing.Point(115, 62)
        Me.cmb_curso.Name = "cmb_curso"
        Me.cmb_curso.Size = New System.Drawing.Size(207, 24)
        Me.cmb_curso.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Curso* :"
        '
        'cmb_semestre
        '
        Me.cmb_semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_semestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_semestre.FormattingEnabled = True
        Me.cmb_semestre.Items.AddRange(New Object() {"Primeiro", "Segundo"})
        Me.cmb_semestre.Location = New System.Drawing.Point(166, 130)
        Me.cmb_semestre.Name = "cmb_semestre"
        Me.cmb_semestre.Size = New System.Drawing.Size(156, 24)
        Me.cmb_semestre.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Semestre*:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Ano*:"
        '
        'cmb_periodo
        '
        Me.cmb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_periodo.FormattingEnabled = True
        Me.cmb_periodo.Location = New System.Drawing.Point(166, 164)
        Me.cmb_periodo.Name = "cmb_periodo"
        Me.cmb_periodo.Size = New System.Drawing.Size(156, 24)
        Me.cmb_periodo.TabIndex = 4
        '
        'lbl_periodo
        '
        Me.lbl_periodo.AutoSize = True
        Me.lbl_periodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo.Location = New System.Drawing.Point(8, 165)
        Me.lbl_periodo.Name = "lbl_periodo"
        Me.lbl_periodo.Size = New System.Drawing.Size(77, 16)
        Me.lbl_periodo.TabIndex = 2
        Me.lbl_periodo.Text = "Período* :"
        '
        'lst_consulta_turma
        '
        Me.lst_consulta_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta_turma.FormattingEnabled = True
        Me.lst_consulta_turma.HorizontalScrollbar = True
        Me.lst_consulta_turma.ItemHeight = 16
        Me.lst_consulta_turma.Location = New System.Drawing.Point(8, 89)
        Me.lst_consulta_turma.Name = "lst_consulta_turma"
        Me.lst_consulta_turma.Size = New System.Drawing.Size(280, 196)
        Me.lst_consulta_turma.TabIndex = 53
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
        Me.grb_consulta.Location = New System.Drawing.Point(346, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(294, 294)
        Me.grb_consulta.TabIndex = 62
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'rad_modulo
        '
        Me.rad_modulo.AutoSize = True
        Me.rad_modulo.Location = New System.Drawing.Point(194, 42)
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
        Me.rad_curso.Location = New System.Drawing.Point(194, 19)
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
        Me.txt_pesquisa.Size = New System.Drawing.Size(280, 20)
        Me.txt_pesquisa.TabIndex = 57
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
        Me.mnu_sup.Size = New System.Drawing.Size(652, 68)
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
        'Turma
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(652, 371)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.grb_consulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Turma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turma"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents lst_consulta_turma As System.Windows.Forms.ListBox
    Friend WithEvents cmb_curso As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_semestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_periodo As System.Windows.Forms.Label
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fim As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_fim As System.Windows.Forms.Label
    Friend WithEvents txt_inicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_inicio As System.Windows.Forms.Label
    Friend WithEvents txt_ano As System.Windows.Forms.TextBox
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_modulo As System.Windows.Forms.ComboBox
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rad_modulo As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ano As System.Windows.Forms.RadioButton
    Friend WithEvents rad_curso As System.Windows.Forms.RadioButton
    Friend WithEvents rad_nome As System.Windows.Forms.RadioButton
End Class
