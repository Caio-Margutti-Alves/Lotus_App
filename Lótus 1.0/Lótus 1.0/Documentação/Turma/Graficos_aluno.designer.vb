<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficos_aluno
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Graficos_aluno))
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_imprimir = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.cht_aulas = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cht_semana = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cht_componentes = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cht_semana_aula = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.lbl_aluno = New System.Windows.Forms.Label
        Me.mnu_sup.SuspendLayout()
        CType(Me.cht_aulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_semana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_componentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_semana_aula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_imprimir})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(573, 68)
        Me.mnu_sup.TabIndex = 48
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_imprimir
        '
        Me.mnu_imprimir.Image = Global.Lótus_1._0.My.Resources.Resources._1308621475_Printer_and_Fax
        Me.mnu_imprimir.Name = "mnu_imprimir"
        Me.mnu_imprimir.Size = New System.Drawing.Size(65, 64)
        Me.mnu_imprimir.Text = "Imprimir"
        Me.mnu_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "Relatorio de Ausencias"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'cht_aulas
        '
        Me.cht_aulas.BackColor = System.Drawing.Color.Transparent
        Me.cht_aulas.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_aulas.BorderlineColor = System.Drawing.Color.Black
        Me.cht_aulas.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_aulas.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.cht_aulas.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_aulas.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.cht_aulas.BorderSkin.BorderWidth = 2
        Me.cht_aulas.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea4.Area3DStyle.Enable3D = True
        ChartArea4.Area3DStyle.IsRightAngleAxes = False
        ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea4.Area3DStyle.PointDepth = 300
        ChartArea4.Area3DStyle.Rotation = 15
        ChartArea4.Area3DStyle.WallWidth = 3
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.cht_aulas.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.cht_aulas.Legends.Add(Legend4)
        Me.cht_aulas.Location = New System.Drawing.Point(12, 96)
        Me.cht_aulas.Name = "cht_aulas"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.LabelFormat = "{0}%"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.cht_aulas.Series.Add(Series4)
        Me.cht_aulas.Size = New System.Drawing.Size(559, 168)
        Me.cht_aulas.TabIndex = 49
        Me.cht_aulas.Text = "Chart1"
        '
        'cht_semana
        '
        Me.cht_semana.BackColor = System.Drawing.Color.Transparent
        Me.cht_semana.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_semana.BorderlineColor = System.Drawing.Color.Black
        Me.cht_semana.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_semana.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.cht_semana.BorderSkin.BorderWidth = 2
        Me.cht_semana.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea3.Area3DStyle.PointDepth = 300
        ChartArea3.Area3DStyle.Rotation = 15
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.cht_semana.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.cht_semana.Legends.Add(Legend3)
        Me.cht_semana.Location = New System.Drawing.Point(12, 270)
        Me.cht_semana.Name = "cht_semana"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.LabelFormat = "{0}%"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.cht_semana.Series.Add(Series3)
        Me.cht_semana.Size = New System.Drawing.Size(559, 168)
        Me.cht_semana.TabIndex = 50
        Me.cht_semana.Text = "Chart1"
        '
        'cht_componentes
        '
        Me.cht_componentes.BackColor = System.Drawing.Color.Transparent
        Me.cht_componentes.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_componentes.BorderlineColor = System.Drawing.Color.Black
        Me.cht_componentes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_componentes.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.cht_componentes.BorderSkin.BorderWidth = 2
        Me.cht_componentes.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.PointDepth = 300
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.cht_componentes.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.cht_componentes.Legends.Add(Legend2)
        Me.cht_componentes.Location = New System.Drawing.Point(14, 444)
        Me.cht_componentes.Name = "cht_componentes"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelFormat = "{0}%"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.cht_componentes.Series.Add(Series2)
        Me.cht_componentes.Size = New System.Drawing.Size(559, 168)
        Me.cht_componentes.TabIndex = 51
        Me.cht_componentes.Text = "Chart1"
        '
        'cht_semana_aula
        '
        Me.cht_semana_aula.BackColor = System.Drawing.Color.Transparent
        Me.cht_semana_aula.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_semana_aula.BorderlineColor = System.Drawing.Color.Black
        Me.cht_semana_aula.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_semana_aula.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.cht_semana_aula.BorderSkin.BorderWidth = 2
        Me.cht_semana_aula.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.cht_semana_aula.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.cht_semana_aula.Legends.Add(Legend1)
        Me.cht_semana_aula.Location = New System.Drawing.Point(14, 618)
        Me.cht_semana_aula.Name = "cht_semana_aula"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.cht_semana_aula.Series.Add(Series1)
        Me.cht_semana_aula.Size = New System.Drawing.Size(559, 168)
        Me.cht_semana_aula.TabIndex = 52
        Me.cht_semana_aula.Text = "Chart1"
        '
        'lbl_aluno
        '
        Me.lbl_aluno.AutoSize = True
        Me.lbl_aluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aluno.Location = New System.Drawing.Point(170, 68)
        Me.lbl_aluno.Name = "lbl_aluno"
        Me.lbl_aluno.Size = New System.Drawing.Size(212, 25)
        Me.lbl_aluno.TabIndex = 63
        Me.lbl_aluno.Text = "Gráficos de Alunos"
        '
        'Graficos_aluno
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(590, 439)
        Me.Controls.Add(Me.lbl_aluno)
        Me.Controls.Add(Me.cht_semana_aula)
        Me.Controls.Add(Me.cht_componentes)
        Me.Controls.Add(Me.cht_semana)
        Me.Controls.Add(Me.cht_aulas)
        Me.Controls.Add(Me.mnu_sup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Graficos_aluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráficos de Ausência"
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        CType(Me.cht_aulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_semana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_componentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_semana_aula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_imprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents cht_aulas As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cht_semana As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cht_semana_aula As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cht_componentes As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lbl_aluno As System.Windows.Forms.Label
End Class
