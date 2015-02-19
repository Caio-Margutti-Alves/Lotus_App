<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relacionamento_Disciplina_Curso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relacionamento_Disciplina_Curso))
        Me.grb_disciplina = New System.Windows.Forms.GroupBox
        Me.cmb_disciplina = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_curso = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_modulo = New System.Windows.Forms.ComboBox
        Me.lst_relacionamento = New System.Windows.Forms.ListBox
        Me.btn_add_disciplina = New System.Windows.Forms.Button
        Me.btn_rmv_disciplina = New System.Windows.Forms.Button
        Me.grb_relacionamento = New System.Windows.Forms.GroupBox
        Me.grb_disciplina.SuspendLayout()
        Me.grb_relacionamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_disciplina
        '
        Me.grb_disciplina.Controls.Add(Me.cmb_disciplina)
        Me.grb_disciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_disciplina.ForeColor = System.Drawing.Color.Black
        Me.grb_disciplina.Location = New System.Drawing.Point(12, 8)
        Me.grb_disciplina.Name = "grb_disciplina"
        Me.grb_disciplina.Size = New System.Drawing.Size(682, 47)
        Me.grb_disciplina.TabIndex = 65
        Me.grb_disciplina.TabStop = False
        Me.grb_disciplina.Text = "Disciplina"
        '
        'cmb_disciplina
        '
        Me.cmb_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_disciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_disciplina.FormattingEnabled = True
        Me.cmb_disciplina.Location = New System.Drawing.Point(6, 18)
        Me.cmb_disciplina.Name = "cmb_disciplina"
        Me.cmb_disciplina.Size = New System.Drawing.Size(670, 23)
        Me.cmb_disciplina.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Curso* :"
        '
        'cmb_curso
        '
        Me.cmb_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_curso.FormattingEnabled = True
        Me.cmb_curso.Location = New System.Drawing.Point(89, 69)
        Me.cmb_curso.Name = "cmb_curso"
        Me.cmb_curso.Size = New System.Drawing.Size(236, 24)
        Me.cmb_curso.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Mód/Ano* :"
        '
        'cmb_modulo
        '
        Me.cmb_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_modulo.FormattingEnabled = True
        Me.cmb_modulo.Location = New System.Drawing.Point(89, 107)
        Me.cmb_modulo.Name = "cmb_modulo"
        Me.cmb_modulo.Size = New System.Drawing.Size(236, 24)
        Me.cmb_modulo.TabIndex = 42
        '
        'lst_relacionamento
        '
        Me.lst_relacionamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_relacionamento.FormattingEnabled = True
        Me.lst_relacionamento.HorizontalScrollbar = True
        Me.lst_relacionamento.ItemHeight = 16
        Me.lst_relacionamento.Location = New System.Drawing.Point(371, 16)
        Me.lst_relacionamento.Name = "lst_relacionamento"
        Me.lst_relacionamento.Size = New System.Drawing.Size(305, 180)
        Me.lst_relacionamento.TabIndex = 62
        '
        'btn_add_disciplina
        '
        Me.btn_add_disciplina.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.rigth
        Me.btn_add_disciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add_disciplina.FlatAppearance.BorderSize = 0
        Me.btn_add_disciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_add_disciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_add_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_disciplina.Location = New System.Drawing.Point(331, 52)
        Me.btn_add_disciplina.Name = "btn_add_disciplina"
        Me.btn_add_disciplina.Size = New System.Drawing.Size(34, 41)
        Me.btn_add_disciplina.TabIndex = 64
        Me.btn_add_disciplina.UseVisualStyleBackColor = True
        '
        'btn_rmv_disciplina
        '
        Me.btn_rmv_disciplina.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.left
        Me.btn_rmv_disciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rmv_disciplina.FlatAppearance.BorderSize = 0
        Me.btn_rmv_disciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rmv_disciplina.Location = New System.Drawing.Point(331, 108)
        Me.btn_rmv_disciplina.Name = "btn_rmv_disciplina"
        Me.btn_rmv_disciplina.Size = New System.Drawing.Size(34, 40)
        Me.btn_rmv_disciplina.TabIndex = 63
        Me.btn_rmv_disciplina.UseVisualStyleBackColor = True
        '
        'grb_relacionamento
        '
        Me.grb_relacionamento.Controls.Add(Me.btn_rmv_disciplina)
        Me.grb_relacionamento.Controls.Add(Me.btn_add_disciplina)
        Me.grb_relacionamento.Controls.Add(Me.lst_relacionamento)
        Me.grb_relacionamento.Controls.Add(Me.cmb_modulo)
        Me.grb_relacionamento.Controls.Add(Me.Label1)
        Me.grb_relacionamento.Controls.Add(Me.cmb_curso)
        Me.grb_relacionamento.Controls.Add(Me.Label4)
        Me.grb_relacionamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_relacionamento.ForeColor = System.Drawing.Color.Black
        Me.grb_relacionamento.Location = New System.Drawing.Point(12, 61)
        Me.grb_relacionamento.Name = "grb_relacionamento"
        Me.grb_relacionamento.Size = New System.Drawing.Size(682, 202)
        Me.grb_relacionamento.TabIndex = 43
        Me.grb_relacionamento.TabStop = False
        Me.grb_relacionamento.Text = "Relacionamento"
        '
        'Relacionamento_Disciplina_Curso
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(706, 272)
        Me.Controls.Add(Me.grb_disciplina)
        Me.Controls.Add(Me.grb_relacionamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Relacionamento_Disciplina_Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacionamento Disciplina/Curso"
        Me.grb_disciplina.ResumeLayout(False)
        Me.grb_relacionamento.ResumeLayout(False)
        Me.grb_relacionamento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_disciplina As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_disciplina As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_curso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_modulo As System.Windows.Forms.ComboBox
    Friend WithEvents lst_relacionamento As System.Windows.Forms.ListBox
    Friend WithEvents btn_add_disciplina As System.Windows.Forms.Button
    Friend WithEvents btn_rmv_disciplina As System.Windows.Forms.Button
    Friend WithEvents grb_relacionamento As System.Windows.Forms.GroupBox
End Class
