<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispensa_Aulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispensa_Aulas))
        Me.cmb_turma = New System.Windows.Forms.ComboBox
        Me.clb_disciplinas = New System.Windows.Forms.CheckedListBox
        Me.lst_alunos_turma = New System.Windows.Forms.ListBox
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.lbl_materias = New System.Windows.Forms.Label
        Me.lbl_alunos = New System.Windows.Forms.Label
        Me.grb_turma = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grb_cadastro.SuspendLayout()
        Me.grb_turma.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_turma
        '
        Me.cmb_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_turma.FormattingEnabled = True
        Me.cmb_turma.Location = New System.Drawing.Point(6, 38)
        Me.cmb_turma.Name = "cmb_turma"
        Me.cmb_turma.Size = New System.Drawing.Size(539, 24)
        Me.cmb_turma.TabIndex = 17
        '
        'clb_disciplinas
        '
        Me.clb_disciplinas.CheckOnClick = True
        Me.clb_disciplinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_disciplinas.FormattingEnabled = True
        Me.clb_disciplinas.HorizontalScrollbar = True
        Me.clb_disciplinas.Location = New System.Drawing.Point(341, 39)
        Me.clb_disciplinas.Name = "clb_disciplinas"
        Me.clb_disciplinas.Size = New System.Drawing.Size(204, 242)
        Me.clb_disciplinas.TabIndex = 66
        Me.clb_disciplinas.UseCompatibleTextRendering = True
        '
        'lst_alunos_turma
        '
        Me.lst_alunos_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_alunos_turma.FormattingEnabled = True
        Me.lst_alunos_turma.HorizontalScrollbar = True
        Me.lst_alunos_turma.ItemHeight = 16
        Me.lst_alunos_turma.Location = New System.Drawing.Point(6, 37)
        Me.lst_alunos_turma.Name = "lst_alunos_turma"
        Me.lst_alunos_turma.Size = New System.Drawing.Size(329, 244)
        Me.lst_alunos_turma.TabIndex = 65
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.lbl_materias)
        Me.grb_cadastro.Controls.Add(Me.lbl_alunos)
        Me.grb_cadastro.Controls.Add(Me.clb_disciplinas)
        Me.grb_cadastro.Controls.Add(Me.lst_alunos_turma)
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 83)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(551, 291)
        Me.grb_cadastro.TabIndex = 63
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Dispensa"
        '
        'lbl_materias
        '
        Me.lbl_materias.AutoSize = True
        Me.lbl_materias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_materias.Location = New System.Drawing.Point(411, 22)
        Me.lbl_materias.Name = "lbl_materias"
        Me.lbl_materias.Size = New System.Drawing.Size(68, 16)
        Me.lbl_materias.TabIndex = 68
        Me.lbl_materias.Text = "Matérias"
        '
        'lbl_alunos
        '
        Me.lbl_alunos.AutoSize = True
        Me.lbl_alunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alunos.Location = New System.Drawing.Point(142, 18)
        Me.lbl_alunos.Name = "lbl_alunos"
        Me.lbl_alunos.Size = New System.Drawing.Size(55, 16)
        Me.lbl_alunos.TabIndex = 67
        Me.lbl_alunos.Text = "Alunos"
        '
        'grb_turma
        '
        Me.grb_turma.Controls.Add(Me.Label1)
        Me.grb_turma.Controls.Add(Me.cmb_turma)
        Me.grb_turma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_turma.ForeColor = System.Drawing.Color.Black
        Me.grb_turma.Location = New System.Drawing.Point(12, 12)
        Me.grb_turma.Name = "grb_turma"
        Me.grb_turma.Size = New System.Drawing.Size(551, 65)
        Me.grb_turma.TabIndex = 64
        Me.grb_turma.TabStop = False
        Me.grb_turma.Text = "Turma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nome da Turma - Ano - Semestre"
        '
        'Dispensa_Aulas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(575, 385)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.grb_turma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dispensa_Aulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispensa de Aulas"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_turma.ResumeLayout(False)
        Me.grb_turma.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents grb_turma As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_turma As System.Windows.Forms.ComboBox
    Friend WithEvents clb_disciplinas As System.Windows.Forms.CheckedListBox
    Friend WithEvents lst_alunos_turma As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_materias As System.Windows.Forms.Label
    Friend WithEvents lbl_alunos As System.Windows.Forms.Label
End Class
