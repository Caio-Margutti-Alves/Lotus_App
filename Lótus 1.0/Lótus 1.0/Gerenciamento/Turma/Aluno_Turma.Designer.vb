<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aluno_Turma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aluno_Turma))
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.lbl_numero = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gpbalunos = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.btn_rmv_todos = New System.Windows.Forms.Button
        Me.btn_rmv_aluno = New System.Windows.Forms.Button
        Me.btn_add_aluno = New System.Windows.Forms.Button
        Me.lst_aluno = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lst_alunos_turma = New System.Windows.Forms.ListBox
        Me.grb_turma = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gpbalunos.SuspendLayout()
        Me.grb_turma.SuspendLayout()
        Me.SuspendLayout()
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
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(6, 35)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(534, 24)
        Me.cmb_turma.TabIndex = 70
        Me.tlp_login.SetToolTip(Me.cmb_turma, "Selecione a turma")
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(510, 16)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(15, 15)
        Me.lbl_numero.TabIndex = 33
        Me.lbl_numero.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Numero de alunos na turma:"
        '
        'gpbalunos
        '
        Me.gpbalunos.Controls.Add(Me.Label2)
        Me.gpbalunos.Controls.Add(Me.txt_pesquisa)
        Me.gpbalunos.Controls.Add(Me.btn_rmv_todos)
        Me.gpbalunos.Controls.Add(Me.btn_rmv_aluno)
        Me.gpbalunos.Controls.Add(Me.lbl_numero)
        Me.gpbalunos.Controls.Add(Me.btn_add_aluno)
        Me.gpbalunos.Controls.Add(Me.Label4)
        Me.gpbalunos.Controls.Add(Me.lst_aluno)
        Me.gpbalunos.Controls.Add(Me.Label3)
        Me.gpbalunos.Controls.Add(Me.lst_alunos_turma)
        Me.gpbalunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbalunos.ForeColor = System.Drawing.Color.Black
        Me.gpbalunos.Location = New System.Drawing.Point(3, 88)
        Me.gpbalunos.Name = "gpbalunos"
        Me.gpbalunos.Size = New System.Drawing.Size(546, 376)
        Me.gpbalunos.TabIndex = 21
        Me.gpbalunos.TabStop = False
        Me.gpbalunos.Text = "Alunos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = " Pesquisa:"
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(6, 36)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(239, 22)
        Me.txt_pesquisa.TabIndex = 65
        '
        'btn_rmv_todos
        '
        Me.btn_rmv_todos.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.remover_todos
        Me.btn_rmv_todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rmv_todos.FlatAppearance.BorderSize = 0
        Me.btn_rmv_todos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_rmv_todos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_rmv_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rmv_todos.Location = New System.Drawing.Point(255, 218)
        Me.btn_rmv_todos.Name = "btn_rmv_todos"
        Me.btn_rmv_todos.Size = New System.Drawing.Size(45, 46)
        Me.btn_rmv_todos.TabIndex = 64
        Me.btn_rmv_todos.UseVisualStyleBackColor = True
        '
        'btn_rmv_aluno
        '
        Me.btn_rmv_aluno.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.left
        Me.btn_rmv_aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rmv_aluno.FlatAppearance.BorderSize = 0
        Me.btn_rmv_aluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_rmv_aluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_rmv_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rmv_aluno.Location = New System.Drawing.Point(255, 154)
        Me.btn_rmv_aluno.Name = "btn_rmv_aluno"
        Me.btn_rmv_aluno.Size = New System.Drawing.Size(45, 46)
        Me.btn_rmv_aluno.TabIndex = 63
        Me.btn_rmv_aluno.UseVisualStyleBackColor = True
        '
        'btn_add_aluno
        '
        Me.btn_add_aluno.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.rigth
        Me.btn_add_aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add_aluno.FlatAppearance.BorderSize = 0
        Me.btn_add_aluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_add_aluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_add_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_aluno.Location = New System.Drawing.Point(255, 95)
        Me.btn_add_aluno.Name = "btn_add_aluno"
        Me.btn_add_aluno.Size = New System.Drawing.Size(45, 47)
        Me.btn_add_aluno.TabIndex = 62
        Me.btn_add_aluno.UseVisualStyleBackColor = True
        '
        'lst_aluno
        '
        Me.lst_aluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_aluno.FormattingEnabled = True
        Me.lst_aluno.HorizontalScrollbar = True
        Me.lst_aluno.ItemHeight = 16
        Me.lst_aluno.Location = New System.Drawing.Point(6, 81)
        Me.lst_aluno.Name = "lst_aluno"
        Me.lst_aluno.Size = New System.Drawing.Size(239, 276)
        Me.lst_aluno.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alunos:"
        '
        'lst_alunos_turma
        '
        Me.lst_alunos_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_alunos_turma.FormattingEnabled = True
        Me.lst_alunos_turma.HorizontalScrollbar = True
        Me.lst_alunos_turma.ItemHeight = 16
        Me.lst_alunos_turma.Location = New System.Drawing.Point(306, 36)
        Me.lst_alunos_turma.Name = "lst_alunos_turma"
        Me.lst_alunos_turma.Size = New System.Drawing.Size(234, 324)
        Me.lst_alunos_turma.TabIndex = 1
        '
        'grb_turma
        '
        Me.grb_turma.Controls.Add(Me.cmb_turma)
        Me.grb_turma.Controls.Add(Me.Label1)
        Me.grb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_turma.ForeColor = System.Drawing.Color.Black
        Me.grb_turma.Location = New System.Drawing.Point(3, 12)
        Me.grb_turma.Name = "grb_turma"
        Me.grb_turma.Size = New System.Drawing.Size(546, 70)
        Me.grb_turma.TabIndex = 69
        Me.grb_turma.TabStop = False
        Me.grb_turma.Text = "Turma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nome da Turma - Ano - Semestre"
        '
        'Aluno_Turma
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(555, 476)
        Me.Controls.Add(Me.grb_turma)
        Me.Controls.Add(Me.gpbalunos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Aluno_Turma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alunos na Turma"
        Me.gpbalunos.ResumeLayout(False)
        Me.gpbalunos.PerformLayout()
        Me.grb_turma.ResumeLayout(False)
        Me.grb_turma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gpbalunos As System.Windows.Forms.GroupBox
    Friend WithEvents lst_aluno As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lst_alunos_turma As System.Windows.Forms.ListBox
    Friend WithEvents btn_rmv_aluno As System.Windows.Forms.Button
    Friend WithEvents btn_add_aluno As System.Windows.Forms.Button
    Friend WithEvents btn_rmv_todos As System.Windows.Forms.Button
    Friend WithEvents grb_turma As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
End Class
