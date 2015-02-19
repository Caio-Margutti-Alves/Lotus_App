<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorios_Aluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relatorios_Aluno))
        Me.grb_rel = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.lbl_mes = New System.Windows.Forms.Label
        Me.cmb_mes = New System.Windows.Forms.ComboBox
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_grafico = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_relatorio_ausencia = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_mensal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_aulas = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_rel.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_rel
        '
        Me.grb_rel.Controls.Add(Me.Label1)
        Me.grb_rel.Controls.Add(Me.cmb_turma)
        Me.grb_rel.Controls.Add(Me.lbl_mes)
        Me.grb_rel.Controls.Add(Me.cmb_mes)
        Me.grb_rel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_rel.Location = New System.Drawing.Point(12, 71)
        Me.grb_rel.Name = "grb_rel"
        Me.grb_rel.Size = New System.Drawing.Size(341, 136)
        Me.grb_rel.TabIndex = 49
        Me.grb_rel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Nome da Turma - Ano - Semestre"
        '
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(6, 48)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(329, 28)
        Me.cmb_turma.TabIndex = 72
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mes.Location = New System.Drawing.Point(146, 79)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(47, 20)
        Me.lbl_mes.TabIndex = 5
        Me.lbl_mes.Text = "Mês:"
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(80, 102)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(171, 28)
        Me.cmb_mes.TabIndex = 4
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_grafico, Me.mnu_relatorio_ausencia})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(365, 68)
        Me.mnu_sup.TabIndex = 50
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_grafico
        '
        Me.mnu_grafico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_grafico.Image = Global.Lótus_1._0.My.Resources.Resources.Graphing_Spreadsheets
        Me.mnu_grafico.Name = "mnu_grafico"
        Me.mnu_grafico.Size = New System.Drawing.Size(94, 64)
        Me.mnu_grafico.Text = "Exibir Gráfico"
        Me.mnu_grafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_grafico.ToolTipText = "Exibe os gráficos de ausência"
        '
        'mnu_relatorio_ausencia
        '
        Me.mnu_relatorio_ausencia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_mensal, Me.mnu_aulas})
        Me.mnu_relatorio_ausencia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_relatorio_ausencia.Image = Global.Lótus_1._0.My.Resources.Resources.Notepad
        Me.mnu_relatorio_ausencia.Name = "mnu_relatorio_ausencia"
        Me.mnu_relatorio_ausencia.Size = New System.Drawing.Size(104, 64)
        Me.mnu_relatorio_ausencia.Text = "Exibir Relatório"
        Me.mnu_relatorio_ausencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnu_mensal
        '
        Me.mnu_mensal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_mensal.Name = "mnu_mensal"
        Me.mnu_mensal.Size = New System.Drawing.Size(185, 22)
        Me.mnu_mensal.Text = "Mensal"
        Me.mnu_mensal.ToolTipText = "Exibe o relatório mensal da turma"
        '
        'mnu_aulas
        '
        Me.mnu_aulas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_aulas.Name = "mnu_aulas"
        Me.mnu_aulas.Size = New System.Drawing.Size(185, 22)
        Me.mnu_aulas.Text = "Controle de Aulas"
        Me.mnu_aulas.ToolTipText = "Exibe o controle mensal de aulas da turma"
        '
        'Relatorios_Aluno
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(365, 219)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_rel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Relatorios_Aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Alunos"
        Me.grb_rel.ResumeLayout(False)
        Me.grb_rel.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_rel As System.Windows.Forms.GroupBox
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_grafico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_mes As System.Windows.Forms.Label
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents mnu_relatorio_ausencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_mensal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_aulas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
