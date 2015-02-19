<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adicional_Noturno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adicional_Noturno))
        Me.grb_adicional = New System.Windows.Forms.GroupBox
        Me.grb_professor = New System.Windows.Forms.GroupBox
        Me.cmb_professor = New System.Windows.Forms.ComboBox
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_dt_adicional = New System.Windows.Forms.MaskedTextBox
        Me.txt_valor = New System.Windows.Forms.TextBox
        Me.lbl_valor = New System.Windows.Forms.Label
        Me.btn_rmv_disciplina = New System.Windows.Forms.Button
        Me.btn_add_disciplina = New System.Windows.Forms.Button
        Me.lst_adcionais_cadastrados = New System.Windows.Forms.ListBox
        Me.grb_mes = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ano = New System.Windows.Forms.TextBox
        Me.lst_mes = New System.Windows.Forms.ListBox
        Me.grb_adicional.SuspendLayout()
        Me.grb_professor.SuspendLayout()
        Me.grb_cadastro.SuspendLayout()
        Me.grb_mes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_adicional
        '
        Me.grb_adicional.Controls.Add(Me.grb_professor)
        Me.grb_adicional.Controls.Add(Me.grb_cadastro)
        Me.grb_adicional.Controls.Add(Me.btn_rmv_disciplina)
        Me.grb_adicional.Controls.Add(Me.btn_add_disciplina)
        Me.grb_adicional.Controls.Add(Me.lst_adcionais_cadastrados)
        Me.grb_adicional.Controls.Add(Me.grb_mes)
        Me.grb_adicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_adicional.ForeColor = System.Drawing.Color.Black
        Me.grb_adicional.Location = New System.Drawing.Point(12, 12)
        Me.grb_adicional.Name = "grb_adicional"
        Me.grb_adicional.Size = New System.Drawing.Size(636, 479)
        Me.grb_adicional.TabIndex = 0
        Me.grb_adicional.TabStop = False
        Me.grb_adicional.Text = "Adicional Noturno"
        '
        'grb_professor
        '
        Me.grb_professor.Controls.Add(Me.cmb_professor)
        Me.grb_professor.ForeColor = System.Drawing.Color.Black
        Me.grb_professor.Location = New System.Drawing.Point(6, 20)
        Me.grb_professor.Name = "grb_professor"
        Me.grb_professor.Size = New System.Drawing.Size(338, 59)
        Me.grb_professor.TabIndex = 75
        Me.grb_professor.TabStop = False
        Me.grb_professor.Text = "Professor*"
        '
        'cmb_professor
        '
        Me.cmb_professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_professor.FormattingEnabled = True
        Me.cmb_professor.Location = New System.Drawing.Point(6, 20)
        Me.cmb_professor.Name = "cmb_professor"
        Me.cmb_professor.Size = New System.Drawing.Size(326, 23)
        Me.cmb_professor.TabIndex = 0
        '
        'grb_cadastro
        '
        Me.grb_cadastro.Controls.Add(Me.Label3)
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.txt_dt_adicional)
        Me.grb_cadastro.Controls.Add(Me.txt_valor)
        Me.grb_cadastro.Controls.Add(Me.lbl_valor)
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(6, 85)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(338, 102)
        Me.grb_cadastro.TabIndex = 72
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "R$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = " Data*:"
        '
        'txt_dt_adicional
        '
        Me.txt_dt_adicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dt_adicional.Location = New System.Drawing.Point(124, 73)
        Me.txt_dt_adicional.Mask = "00/00/0000"
        Me.txt_dt_adicional.Name = "txt_dt_adicional"
        Me.txt_dt_adicional.Size = New System.Drawing.Size(91, 22)
        Me.txt_dt_adicional.TabIndex = 1
        Me.txt_dt_adicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_dt_adicional.ValidatingType = GetType(Date)
        '
        'txt_valor
        '
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(93, 33)
        Me.txt_valor.MaxLength = 8
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(160, 22)
        Me.txt_valor.TabIndex = 0
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.Location = New System.Drawing.Point(143, 17)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(59, 16)
        Me.lbl_valor.TabIndex = 68
        Me.lbl_valor.Text = " Valor*:"
        '
        'btn_rmv_disciplina
        '
        Me.btn_rmv_disciplina.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.left
        Me.btn_rmv_disciplina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rmv_disciplina.FlatAppearance.BorderSize = 0
        Me.btn_rmv_disciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_rmv_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rmv_disciplina.Location = New System.Drawing.Point(350, 146)
        Me.btn_rmv_disciplina.Name = "btn_rmv_disciplina"
        Me.btn_rmv_disciplina.Size = New System.Drawing.Size(34, 40)
        Me.btn_rmv_disciplina.TabIndex = 65
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
        Me.btn_add_disciplina.Location = New System.Drawing.Point(350, 99)
        Me.btn_add_disciplina.Name = "btn_add_disciplina"
        Me.btn_add_disciplina.Size = New System.Drawing.Size(34, 41)
        Me.btn_add_disciplina.TabIndex = 66
        Me.btn_add_disciplina.UseVisualStyleBackColor = True
        '
        'lst_adcionais_cadastrados
        '
        Me.lst_adcionais_cadastrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_adcionais_cadastrados.FormattingEnabled = True
        Me.lst_adcionais_cadastrados.ItemHeight = 16
        Me.lst_adcionais_cadastrados.Location = New System.Drawing.Point(390, 20)
        Me.lst_adcionais_cadastrados.Name = "lst_adcionais_cadastrados"
        Me.lst_adcionais_cadastrados.Size = New System.Drawing.Size(240, 452)
        Me.lst_adcionais_cadastrados.TabIndex = 4
        '
        'grb_mes
        '
        Me.grb_mes.Controls.Add(Me.Label1)
        Me.grb_mes.Controls.Add(Me.txt_ano)
        Me.grb_mes.Controls.Add(Me.lst_mes)
        Me.grb_mes.ForeColor = System.Drawing.Color.Black
        Me.grb_mes.Location = New System.Drawing.Point(6, 193)
        Me.grb_mes.Name = "grb_mes"
        Me.grb_mes.Size = New System.Drawing.Size(338, 281)
        Me.grb_mes.TabIndex = 1
        Me.grb_mes.TabStop = False
        Me.grb_mes.Text = "Tipo de Exibição*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Ano:"
        '
        'txt_ano
        '
        Me.txt_ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.Location = New System.Drawing.Point(63, 253)
        Me.txt_ano.MaxLength = 5
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(204, 22)
        Me.txt_ano.TabIndex = 2
        Me.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_mes
        '
        Me.lst_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_mes.FormattingEnabled = True
        Me.lst_mes.ItemHeight = 16
        Me.lst_mes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro", "Todos"})
        Me.lst_mes.Location = New System.Drawing.Point(63, 20)
        Me.lst_mes.Name = "lst_mes"
        Me.lst_mes.Size = New System.Drawing.Size(204, 212)
        Me.lst_mes.TabIndex = 0
        '
        'Adicional_Noturno
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(660, 500)
        Me.Controls.Add(Me.grb_adicional)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Adicional_Noturno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicional Noturno"
        Me.grb_adicional.ResumeLayout(False)
        Me.grb_professor.ResumeLayout(False)
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_mes.ResumeLayout(False)
        Me.grb_mes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grb_adicional As System.Windows.Forms.GroupBox
    Friend WithEvents grb_mes As System.Windows.Forms.GroupBox
    Friend WithEvents lst_mes As System.Windows.Forms.ListBox
    Friend WithEvents lst_adcionais_cadastrados As System.Windows.Forms.ListBox
    Friend WithEvents btn_rmv_disciplina As System.Windows.Forms.Button
    Friend WithEvents btn_add_disciplina As System.Windows.Forms.Button
    Friend WithEvents txt_valor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_valor As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dt_adicional As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents grb_professor As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_professor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ano As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
