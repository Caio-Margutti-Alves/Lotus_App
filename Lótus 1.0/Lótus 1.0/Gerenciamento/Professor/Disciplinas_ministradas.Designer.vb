<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disciplinas_ministradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Disciplinas_ministradas))
        Me.grb_disciplinas_ministradas = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_rmv_disciplina = New System.Windows.Forms.Button
        Me.btn_add_disciplina = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_disciplina = New System.Windows.Forms.ComboBox
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.lst_disciplinas_ministradas = New System.Windows.Forms.ListBox
        Me.grb_professor = New System.Windows.Forms.GroupBox
        Me.cmb_professor = New System.Windows.Forms.ComboBox
        Me.grb_disciplinas_ministradas.SuspendLayout()
        Me.grb_professor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_disciplinas_ministradas
        '
        Me.grb_disciplinas_ministradas.Controls.Add(Me.Label1)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.btn_rmv_disciplina)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.btn_add_disciplina)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.Label6)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.cmb_disciplina)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.cmb_turma)
        Me.grb_disciplinas_ministradas.Controls.Add(Me.lst_disciplinas_ministradas)
        Me.grb_disciplinas_ministradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_disciplinas_ministradas.ForeColor = System.Drawing.Color.Black
        Me.grb_disciplinas_ministradas.Location = New System.Drawing.Point(12, 81)
        Me.grb_disciplinas_ministradas.Name = "grb_disciplinas_ministradas"
        Me.grb_disciplinas_ministradas.Size = New System.Drawing.Size(566, 224)
        Me.grb_disciplinas_ministradas.TabIndex = 63
        Me.grb_disciplinas_ministradas.TabStop = False
        Me.grb_disciplinas_ministradas.Text = "Disciplinas Ministradas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nome da Turma - Ano - Semestre"
        '
        'btn_rmv_disciplina
        '
        Me.btn_rmv_disciplina.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.left
        Me.btn_rmv_disciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rmv_disciplina.FlatAppearance.BorderSize = 0
        Me.btn_rmv_disciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rmv_disciplina.Location = New System.Drawing.Point(279, 131)
        Me.btn_rmv_disciplina.Name = "btn_rmv_disciplina"
        Me.btn_rmv_disciplina.Size = New System.Drawing.Size(34, 40)
        Me.btn_rmv_disciplina.TabIndex = 61
        Me.btn_rmv_disciplina.UseVisualStyleBackColor = True
        '
        'btn_add_disciplina
        '
        Me.btn_add_disciplina.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.rigth
        Me.btn_add_disciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add_disciplina.FlatAppearance.BorderSize = 0
        Me.btn_add_disciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_add_disciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_add_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_disciplina.Location = New System.Drawing.Point(279, 84)
        Me.btn_add_disciplina.Name = "btn_add_disciplina"
        Me.btn_add_disciplina.Size = New System.Drawing.Size(34, 41)
        Me.btn_add_disciplina.TabIndex = 61
        Me.btn_add_disciplina.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Disciplina:"
        '
        'cmb_disciplina
        '
        Me.cmb_disciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_disciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_disciplina.ForeColor = System.Drawing.Color.Black
        Me.cmb_disciplina.FormattingEnabled = True
        Me.cmb_disciplina.Location = New System.Drawing.Point(6, 148)
        Me.cmb_disciplina.Name = "cmb_disciplina"
        Me.cmb_disciplina.Size = New System.Drawing.Size(267, 24)
        Me.cmb_disciplina.TabIndex = 59
        '
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(6, 94)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(267, 24)
        Me.cmb_turma.TabIndex = 56
        '
        'lst_disciplinas_ministradas
        '
        Me.lst_disciplinas_ministradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_disciplinas_ministradas.FormattingEnabled = True
        Me.lst_disciplinas_ministradas.HorizontalScrollbar = True
        Me.lst_disciplinas_ministradas.ItemHeight = 16
        Me.lst_disciplinas_ministradas.Location = New System.Drawing.Point(319, 14)
        Me.lst_disciplinas_ministradas.Name = "lst_disciplinas_ministradas"
        Me.lst_disciplinas_ministradas.Size = New System.Drawing.Size(241, 196)
        Me.lst_disciplinas_ministradas.TabIndex = 48
        '
        'grb_professor
        '
        Me.grb_professor.Controls.Add(Me.cmb_professor)
        Me.grb_professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_professor.ForeColor = System.Drawing.Color.Black
        Me.grb_professor.Location = New System.Drawing.Point(12, 12)
        Me.grb_professor.Name = "grb_professor"
        Me.grb_professor.Size = New System.Drawing.Size(566, 63)
        Me.grb_professor.TabIndex = 64
        Me.grb_professor.TabStop = False
        Me.grb_professor.Text = "Professor"
        '
        'cmb_professor
        '
        Me.cmb_professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_professor.FormattingEnabled = True
        Me.cmb_professor.Location = New System.Drawing.Point(6, 20)
        Me.cmb_professor.Name = "cmb_professor"
        Me.cmb_professor.Size = New System.Drawing.Size(554, 24)
        Me.cmb_professor.TabIndex = 57
        '
        'Disciplinas_ministradas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(589, 317)
        Me.Controls.Add(Me.grb_professor)
        Me.Controls.Add(Me.grb_disciplinas_ministradas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Disciplinas_ministradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disciplinas Ministradas"
        Me.grb_disciplinas_ministradas.ResumeLayout(False)
        Me.grb_disciplinas_ministradas.PerformLayout()
        Me.grb_professor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_disciplinas_ministradas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_rmv_disciplina As System.Windows.Forms.Button
    Friend WithEvents btn_add_disciplina As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_disciplina As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents lst_disciplinas_ministradas As System.Windows.Forms.ListBox
    Friend WithEvents grb_professor As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_professor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
