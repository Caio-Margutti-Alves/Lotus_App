<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chamada_Aluno
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chamada_Aluno))
        Me.lbl_rturma = New System.Windows.Forms.Label
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_aula = New System.Windows.Forms.ComboBox
        Me.lbl_aula = New System.Windows.Forms.Label
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.lstaluno = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbf = New System.Windows.Forms.RadioButton
        Me.rdbp = New System.Windows.Forms.RadioButton
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.dtpdia = New System.Windows.Forms.DateTimePicker
        Me.cmbmateria = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblnaulas = New System.Windows.Forms.Label
        Me.lblncurso = New System.Windows.Forms.Label
        Me.lbldiasemana = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_rturma
        '
        Me.lbl_rturma.AutoSize = True
        Me.lbl_rturma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rturma.Location = New System.Drawing.Point(7, 78)
        Me.lbl_rturma.Name = "lbl_rturma"
        Me.lbl_rturma.Size = New System.Drawing.Size(52, 15)
        Me.lbl_rturma.TabIndex = 6
        Me.lbl_rturma.Text = "Turma:"
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
        'cmb_aula
        '
        Me.cmb_aula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aula.FormattingEnabled = True
        Me.cmb_aula.Items.AddRange(New Object() {"1"})
        Me.cmb_aula.Location = New System.Drawing.Point(68, 104)
        Me.cmb_aula.Name = "cmb_aula"
        Me.cmb_aula.Size = New System.Drawing.Size(127, 21)
        Me.cmb_aula.TabIndex = 55
        '
        'lbl_aula
        '
        Me.lbl_aula.AutoSize = True
        Me.lbl_aula.Location = New System.Drawing.Point(7, 107)
        Me.lbl_aula.Name = "lbl_aula"
        Me.lbl_aula.Size = New System.Drawing.Size(31, 13)
        Me.lbl_aula.TabIndex = 53
        Me.lbl_aula.Text = "Aula:"
        '
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(68, 77)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(335, 21)
        Me.cmb_turma.TabIndex = 58
        '
        'lstaluno
        '
        Me.lstaluno.FormattingEnabled = True
        Me.lstaluno.Location = New System.Drawing.Point(6, 48)
        Me.lstaluno.Name = "lstaluno"
        Me.lstaluno.Size = New System.Drawing.Size(188, 199)
        Me.lstaluno.Sorted = True
        Me.lstaluno.TabIndex = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstaluno)
        Me.GroupBox1.Controls.Add(Me.rdbf)
        Me.GroupBox1.Controls.Add(Me.rdbp)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 253)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alunos:"
        '
        'rdbf
        '
        Me.rdbf.AutoSize = True
        Me.rdbf.Location = New System.Drawing.Point(121, 19)
        Me.rdbf.Name = "rdbf"
        Me.rdbf.Size = New System.Drawing.Size(48, 17)
        Me.rdbf.TabIndex = 66
        Me.rdbf.TabStop = True
        Me.rdbf.Text = "Falta"
        Me.rdbf.UseVisualStyleBackColor = True
        '
        'rdbp
        '
        Me.rdbp.AutoSize = True
        Me.rdbp.Location = New System.Drawing.Point(6, 19)
        Me.rdbp.Name = "rdbp"
        Me.rdbp.Size = New System.Drawing.Size(67, 17)
        Me.rdbp.TabIndex = 65
        Me.rdbp.TabStop = True
        Me.rdbp.Text = "Presente"
        Me.rdbp.UseVisualStyleBackColor = True
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_excluir})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(408, 68)
        Me.mnu_sup.TabIndex = 67
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_excluir
        '
        Me.mnu_excluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_excluir.Image = Global.Lótus_1._0.My.Resources.Resources.Recycle
        Me.mnu_excluir.Name = "mnu_excluir"
        Me.mnu_excluir.Size = New System.Drawing.Size(57, 64)
        Me.mnu_excluir.Text = "Excluir"
        Me.mnu_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_excluir.ToolTipText = "Exclui um feriado ou dia não letivo"
        '
        'dtpdia
        '
        Me.dtpdia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdia.Location = New System.Drawing.Point(10, 232)
        Me.dtpdia.Name = "dtpdia"
        Me.dtpdia.Size = New System.Drawing.Size(185, 20)
        Me.dtpdia.TabIndex = 69
        '
        'cmbmateria
        '
        Me.cmbmateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmateria.FormattingEnabled = True
        Me.cmbmateria.Location = New System.Drawing.Point(68, 131)
        Me.cmbmateria.Name = "cmbmateria"
        Me.cmbmateria.Size = New System.Drawing.Size(127, 21)
        Me.cmbmateria.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Disciplina:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Copiar para próxima aula"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblnaulas
        '
        Me.lblnaulas.AutoSize = True
        Me.lblnaulas.Location = New System.Drawing.Point(7, 178)
        Me.lblnaulas.Name = "lblnaulas"
        Me.lblnaulas.Size = New System.Drawing.Size(98, 13)
        Me.lblnaulas.TabIndex = 60
        Me.lblnaulas.Text = "Nº de aulas diarias:"
        '
        'lblncurso
        '
        Me.lblncurso.AutoSize = True
        Me.lblncurso.Location = New System.Drawing.Point(7, 204)
        Me.lblncurso.Name = "lblncurso"
        Me.lblncurso.Size = New System.Drawing.Size(37, 13)
        Me.lblncurso.TabIndex = 61
        Me.lblncurso.Text = "Curso:"
        '
        'lbldiasemana
        '
        Me.lbldiasemana.AutoSize = True
        Me.lbldiasemana.Location = New System.Drawing.Point(13, 259)
        Me.lbldiasemana.Name = "lbldiasemana"
        Me.lbldiasemana.Size = New System.Drawing.Size(26, 13)
        Me.lbldiasemana.TabIndex = 73
        Me.lbldiasemana.Text = "Dia:"
        '
        'Chamada_Aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(408, 359)
        Me.Controls.Add(Me.lbldiasemana)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpdia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbmateria)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblncurso)
        Me.Controls.Add(Me.lblnaulas)
        Me.Controls.Add(Me.cmb_turma)
        Me.Controls.Add(Me.lbl_rturma)
        Me.Controls.Add(Me.cmb_aula)
        Me.Controls.Add(Me.lbl_aula)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chamada_Aluno"
        Me.Text = " Chamadas de aluno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_rturma As System.Windows.Forms.Label
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents cmb_aula As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_aula As System.Windows.Forms.Label
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents lstaluno As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbp As System.Windows.Forms.RadioButton
    Friend WithEvents rdbf As System.Windows.Forms.RadioButton
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbmateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpdia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblnaulas As System.Windows.Forms.Label
    Friend WithEvents lblncurso As System.Windows.Forms.Label
    Friend WithEvents lbldiasemana As System.Windows.Forms.Label
End Class
