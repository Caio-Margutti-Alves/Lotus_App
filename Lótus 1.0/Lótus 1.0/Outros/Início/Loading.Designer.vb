<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_loading = New System.Windows.Forms.Label

        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 50
        '
        'lbl_loading
        '
        Me.lbl_loading.AutoSize = True
        Me.lbl_loading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_loading.Font = New System.Drawing.Font("Algerian", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loading.Location = New System.Drawing.Point(99, 186)
        Me.lbl_loading.Name = "lbl_loading"
        Me.lbl_loading.Size = New System.Drawing.Size(122, 18)
        Me.lbl_loading.TabIndex = 9
        Me.lbl_loading.Text = "Carregando"
        '
      
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_loading)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carregando..."
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lbl_loading As System.Windows.Forms.Label

End Class
