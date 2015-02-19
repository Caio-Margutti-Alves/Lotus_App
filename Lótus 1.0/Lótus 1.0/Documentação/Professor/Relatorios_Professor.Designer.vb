<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorios_Professor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relatorios_Professor))
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_relatorio_grafico = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_relatorio_ausencia = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_rel_faltas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_rel_ad_noturno = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_rel = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ano = New System.Windows.Forms.TextBox
        Me.lbl_mes = New System.Windows.Forms.Label
        Me.cmb_mes = New System.Windows.Forms.ComboBox
        Me.mnu_sup.SuspendLayout()
        Me.grb_rel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_relatorio_grafico, Me.mnu_relatorio_ausencia})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(331, 68)
        Me.mnu_sup.TabIndex = 51
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_relatorio_grafico
        '
        Me.mnu_relatorio_grafico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_relatorio_grafico.Image = Global.Lótus_1._0.My.Resources.Resources.Graphing_Spreadsheets
        Me.mnu_relatorio_grafico.Name = "mnu_relatorio_grafico"
        Me.mnu_relatorio_grafico.Size = New System.Drawing.Size(94, 64)
        Me.mnu_relatorio_grafico.Text = "Exibir Gráfico"
        Me.mnu_relatorio_grafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_relatorio_grafico.ToolTipText = "Exibe os gráficos de ausência"
        '
        'mnu_relatorio_ausencia
        '
        Me.mnu_relatorio_ausencia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_rel_faltas, Me.mnu_rel_ad_noturno})
        Me.mnu_relatorio_ausencia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_relatorio_ausencia.Image = Global.Lótus_1._0.My.Resources.Resources.Notepad
        Me.mnu_relatorio_ausencia.Name = "mnu_relatorio_ausencia"
        Me.mnu_relatorio_ausencia.Size = New System.Drawing.Size(104, 64)
        Me.mnu_relatorio_ausencia.Text = "Exibir Relatório"
        Me.mnu_relatorio_ausencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnu_rel_faltas
        '
        Me.mnu_rel_faltas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_rel_faltas.Name = "mnu_rel_faltas"
        Me.mnu_rel_faltas.Size = New System.Drawing.Size(189, 22)
        Me.mnu_rel_faltas.Text = "Faltas"
        Me.mnu_rel_faltas.ToolTipText = "Exibe o relatório mensal da turma"
        '
        'mnu_rel_ad_noturno
        '
        Me.mnu_rel_ad_noturno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_rel_ad_noturno.Name = "mnu_rel_ad_noturno"
        Me.mnu_rel_ad_noturno.Size = New System.Drawing.Size(189, 22)
        Me.mnu_rel_ad_noturno.Text = "Adicional Noturno"
        Me.mnu_rel_ad_noturno.ToolTipText = "Exibe o controle mensal de aulas da turma"
        '
        'grb_rel
        '
        Me.grb_rel.Controls.Add(Me.Label1)
        Me.grb_rel.Controls.Add(Me.txt_ano)
        Me.grb_rel.Controls.Add(Me.lbl_mes)
        Me.grb_rel.Controls.Add(Me.cmb_mes)
        Me.grb_rel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_rel.Location = New System.Drawing.Point(10, 71)
        Me.grb_rel.Name = "grb_rel"
        Me.grb_rel.Size = New System.Drawing.Size(309, 128)
        Me.grb_rel.TabIndex = 52
        Me.grb_rel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Ano:"
        '
        'txt_ano
        '
        Me.txt_ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.Location = New System.Drawing.Point(46, 96)
        Me.txt_ano.MaxLength = 5
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(204, 26)
        Me.txt_ano.TabIndex = 73
        Me.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mes.Location = New System.Drawing.Point(130, 13)
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
        Me.cmb_mes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        Me.cmb_mes.Location = New System.Drawing.Point(46, 38)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(204, 28)
        Me.cmb_mes.TabIndex = 4
        '
        'Relatorios_Professor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(331, 211)
        Me.Controls.Add(Me.grb_rel)
        Me.Controls.Add(Me.mnu_sup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Relatorios_Professor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios de Professores"
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_rel.ResumeLayout(False)
        Me.grb_rel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_relatorio_grafico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_relatorio_ausencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_rel_faltas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_rel_ad_noturno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grb_rel As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_mes As System.Windows.Forms.Label
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ano As System.Windows.Forms.TextBox
End Class
