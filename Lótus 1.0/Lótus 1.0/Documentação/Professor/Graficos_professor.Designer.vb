<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficos_professor
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Graficos_professor))
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_imprimir = New System.Windows.Forms.ToolStripMenuItem
        Me.cht_dias = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cht_tipo_falta = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.cht_ad_noturno = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.lbl_cht_tipo_falta = New System.Windows.Forms.Label
        Me.lbl_cht_ad_noturno = New System.Windows.Forms.Label
        Me.lbl_cht_dias = New System.Windows.Forms.Label
        Me.lbl_cht_faltas_dias = New System.Windows.Forms.Label
        Me.cht_semana_tipo_falta = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lbl_professor = New System.Windows.Forms.Label
        Me.mnu_sup.SuspendLayout()
        CType(Me.cht_dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_tipo_falta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_ad_noturno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cht_semana_tipo_falta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnu_sup.Size = New System.Drawing.Size(568, 68)
        Me.mnu_sup.TabIndex = 49
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
        'cht_dias
        '
        Me.cht_dias.BackColor = System.Drawing.Color.Transparent
        Me.cht_dias.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_dias.BorderlineColor = System.Drawing.Color.Black
        Me.cht_dias.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_dias.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.cht_dias.BorderSkin.BorderWidth = 2
        Me.cht_dias.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.PointDepth = 300
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.cht_dias.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.cht_dias.Legends.Add(Legend1)
        Me.cht_dias.Location = New System.Drawing.Point(12, 440)
        Me.cht_dias.Name = "cht_dias"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelFormat = "{0}%"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.cht_dias.Series.Add(Series1)
        Me.cht_dias.Size = New System.Drawing.Size(551, 166)
        Me.cht_dias.TabIndex = 55
        Me.cht_dias.Text = "Chart1"
        '
        'cht_tipo_falta
        '
        Me.cht_tipo_falta.BackColor = System.Drawing.Color.Transparent
        Me.cht_tipo_falta.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_tipo_falta.BorderlineColor = System.Drawing.Color.Black
        Me.cht_tipo_falta.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_tipo_falta.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.cht_tipo_falta.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_tipo_falta.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.cht_tipo_falta.BorderSkin.BorderWidth = 2
        Me.cht_tipo_falta.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.PointDepth = 300
        ChartArea2.Area3DStyle.Rotation = 15
        ChartArea2.Area3DStyle.WallWidth = 3
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.cht_tipo_falta.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.cht_tipo_falta.Legends.Add(Legend2)
        Me.cht_tipo_falta.Location = New System.Drawing.Point(12, 268)
        Me.cht_tipo_falta.Name = "cht_tipo_falta"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelFormat = "{0}%"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.cht_tipo_falta.Series.Add(Series2)
        Me.cht_tipo_falta.Size = New System.Drawing.Size(551, 166)
        Me.cht_tipo_falta.TabIndex = 54
        Me.cht_tipo_falta.Text = "Chart1"
        '
        'cht_ad_noturno
        '
        Me.cht_ad_noturno.BackColor = System.Drawing.Color.Transparent
        Me.cht_ad_noturno.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_ad_noturno.BorderlineColor = System.Drawing.Color.Black
        Me.cht_ad_noturno.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_ad_noturno.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.cht_ad_noturno.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_ad_noturno.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.cht_ad_noturno.BorderSkin.BorderWidth = 2
        Me.cht_ad_noturno.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.Area3DStyle.IsRightAngleAxes = False
        ChartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea3.Area3DStyle.PointDepth = 300
        ChartArea3.Area3DStyle.Rotation = 15
        ChartArea3.Area3DStyle.WallWidth = 3
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.cht_ad_noturno.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.cht_ad_noturno.Legends.Add(Legend3)
        Me.cht_ad_noturno.Location = New System.Drawing.Point(12, 96)
        Me.cht_ad_noturno.Name = "cht_ad_noturno"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.EmptyPointStyle.AxisLabel = """$#,##0.00;($#,##0.00);"""""
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.LabelFormat = "{0}%"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.cht_ad_noturno.Series.Add(Series3)
        Me.cht_ad_noturno.Size = New System.Drawing.Size(551, 166)
        Me.cht_ad_noturno.TabIndex = 0
        Me.cht_ad_noturno.Text = "Chart1"
        '
        'lbl_cht_tipo_falta
        '
        Me.lbl_cht_tipo_falta.AutoSize = True
        Me.lbl_cht_tipo_falta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cht_tipo_falta.Location = New System.Drawing.Point(127, 337)
        Me.lbl_cht_tipo_falta.Name = "lbl_cht_tipo_falta"
        Me.lbl_cht_tipo_falta.Size = New System.Drawing.Size(63, 20)
        Me.lbl_cht_tipo_falta.TabIndex = 57
        Me.lbl_cht_tipo_falta.Text = "Label1"
        Me.lbl_cht_tipo_falta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_cht_tipo_falta.Visible = False
        '
        'lbl_cht_ad_noturno
        '
        Me.lbl_cht_ad_noturno.AutoSize = True
        Me.lbl_cht_ad_noturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cht_ad_noturno.Location = New System.Drawing.Point(127, 163)
        Me.lbl_cht_ad_noturno.Name = "lbl_cht_ad_noturno"
        Me.lbl_cht_ad_noturno.Size = New System.Drawing.Size(63, 20)
        Me.lbl_cht_ad_noturno.TabIndex = 58
        Me.lbl_cht_ad_noturno.Text = "Label1"
        Me.lbl_cht_ad_noturno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_cht_ad_noturno.Visible = False
        '
        'lbl_cht_dias
        '
        Me.lbl_cht_dias.AutoSize = True
        Me.lbl_cht_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cht_dias.Location = New System.Drawing.Point(127, 501)
        Me.lbl_cht_dias.Name = "lbl_cht_dias"
        Me.lbl_cht_dias.Size = New System.Drawing.Size(63, 20)
        Me.lbl_cht_dias.TabIndex = 59
        Me.lbl_cht_dias.Text = "Label1"
        Me.lbl_cht_dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_cht_dias.Visible = False
        '
        'lbl_cht_faltas_dias
        '
        Me.lbl_cht_faltas_dias.AutoSize = True
        Me.lbl_cht_faltas_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cht_faltas_dias.Location = New System.Drawing.Point(127, 676)
        Me.lbl_cht_faltas_dias.Name = "lbl_cht_faltas_dias"
        Me.lbl_cht_faltas_dias.Size = New System.Drawing.Size(63, 20)
        Me.lbl_cht_faltas_dias.TabIndex = 60
        Me.lbl_cht_faltas_dias.Text = "Label1"
        Me.lbl_cht_faltas_dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_cht_faltas_dias.Visible = False
        '
        'cht_semana_tipo_falta
        '
        Me.cht_semana_tipo_falta.BackColor = System.Drawing.Color.Transparent
        Me.cht_semana_tipo_falta.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.cht_semana_tipo_falta.BorderlineColor = System.Drawing.Color.Black
        Me.cht_semana_tipo_falta.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cht_semana_tipo_falta.BorderSkin.BackColor = System.Drawing.Color.Black
        Me.cht_semana_tipo_falta.BorderSkin.BorderWidth = 2
        Me.cht_semana_tipo_falta.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea4.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea4.Area3DStyle.PointDepth = 300
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.cht_semana_tipo_falta.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.cht_semana_tipo_falta.Legends.Add(Legend4)
        Me.cht_semana_tipo_falta.Location = New System.Drawing.Point(12, 612)
        Me.cht_semana_tipo_falta.Name = "cht_semana_tipo_falta"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.LabelForeColor = System.Drawing.Color.White
        Series4.LabelFormat = "{0}%"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.cht_semana_tipo_falta.Series.Add(Series4)
        Me.cht_semana_tipo_falta.Size = New System.Drawing.Size(551, 166)
        Me.cht_semana_tipo_falta.TabIndex = 61
        Me.cht_semana_tipo_falta.Text = "Chart1"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "Relatorio de Ausencias"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lbl_professor
        '
        Me.lbl_professor.AutoSize = True
        Me.lbl_professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_professor.Location = New System.Drawing.Point(143, 68)
        Me.lbl_professor.Name = "lbl_professor"
        Me.lbl_professor.Size = New System.Drawing.Size(254, 25)
        Me.lbl_professor.TabIndex = 62
        Me.lbl_professor.Text = "Gráficos de Profesores"
        '
        'Graficos_professor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(585, 439)
        Me.Controls.Add(Me.lbl_professor)
        Me.Controls.Add(Me.lbl_cht_faltas_dias)
        Me.Controls.Add(Me.lbl_cht_dias)
        Me.Controls.Add(Me.lbl_cht_ad_noturno)
        Me.Controls.Add(Me.lbl_cht_tipo_falta)
        Me.Controls.Add(Me.cht_ad_noturno)
        Me.Controls.Add(Me.cht_dias)
        Me.Controls.Add(Me.cht_tipo_falta)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.cht_semana_tipo_falta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Graficos_professor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graficos Professor"
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        CType(Me.cht_dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_tipo_falta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_ad_noturno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cht_semana_tipo_falta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_imprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cht_dias As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cht_tipo_falta As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cht_ad_noturno As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lbl_cht_tipo_falta As System.Windows.Forms.Label
    Friend WithEvents lbl_cht_ad_noturno As System.Windows.Forms.Label
    Friend WithEvents lbl_cht_dias As System.Windows.Forms.Label
    Friend WithEvents lbl_cht_faltas_dias As System.Windows.Forms.Label
    Friend WithEvents cht_semana_tipo_falta As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lbl_professor As System.Windows.Forms.Label
End Class
