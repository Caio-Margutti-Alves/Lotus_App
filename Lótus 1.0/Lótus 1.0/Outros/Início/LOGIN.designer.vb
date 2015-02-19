<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.txt_login = New System.Windows.Forms.TextBox
        Me.txt_senha = New System.Windows.Forms.TextBox
        Me.btn_login = New System.Windows.Forms.Button
        Me.btn_sair = New System.Windows.Forms.Button
        Me.lbl_mensagem = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lbl_exibir_dica_senha = New System.Windows.Forms.Label
        Me.lbl_data = New System.Windows.Forms.Label
        Me.lbl_hora = New System.Windows.Forms.Label
        Me.Relogio = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_dica = New System.Windows.Forms.Label
        Me.btn_dica_senha = New System.Windows.Forms.Button
        Me.btn_esqueceu_senha = New System.Windows.Forms.Button
        Me.lbl_esqueceu_senha = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(81, 261)
        Me.txt_login.MaxLength = 20
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(214, 26)
        Me.txt_login.TabIndex = 0
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(81, 333)
        Me.txt_senha.MaxLength = 20
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(214, 26)
        Me.txt_senha.TabIndex = 2
        Me.txt_senha.Tag = "***"
        '
        'btn_login
        '
        Me.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.Location = New System.Drawing.Point(408, 252)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(74, 67)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Logar"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(542, 252)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(68, 67)
        Me.btn_sair.TabIndex = 8
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'lbl_mensagem
        '
        Me.lbl_mensagem.AutoSize = True
        Me.lbl_mensagem.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mensagem.ForeColor = System.Drawing.Color.White
        Me.lbl_mensagem.Location = New System.Drawing.Point(101, 185)
        Me.lbl_mensagem.Name = "lbl_mensagem"
        Me.lbl_mensagem.Size = New System.Drawing.Size(67, 13)
        Me.lbl_mensagem.TabIndex = 9
        Me.lbl_mensagem.Text = "                    "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Magneto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Magneto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Senha:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Lótus_1._0.My.Resources.Resources.usuario
        Me.PictureBox2.Location = New System.Drawing.Point(371, 299)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 53)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Lótus_1._0.My.Resources.Resources.usuario
        Me.PictureBox3.Location = New System.Drawing.Point(505, 299)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 53)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'lbl_exibir_dica_senha
        '
        Me.lbl_exibir_dica_senha.AutoSize = True
        Me.lbl_exibir_dica_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_exibir_dica_senha.Font = New System.Drawing.Font("Magneto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exibir_dica_senha.ForeColor = System.Drawing.Color.Black
        Me.lbl_exibir_dica_senha.Location = New System.Drawing.Point(165, 100)
        Me.lbl_exibir_dica_senha.Name = "lbl_exibir_dica_senha"
        Me.lbl_exibir_dica_senha.Size = New System.Drawing.Size(275, 25)
        Me.lbl_exibir_dica_senha.TabIndex = 15
        Me.lbl_exibir_dica_senha.Text = " Exibir Dica da Senha?"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_data.Font = New System.Drawing.Font("Magneto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_data.Location = New System.Drawing.Point(80, 419)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(66, 24)
        Me.lbl_data.TabIndex = 31
        Me.lbl_data.Text = "Data:"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hora.Font = New System.Drawing.Font("Magneto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_hora.Location = New System.Drawing.Point(453, 419)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(72, 24)
        Me.lbl_hora.TabIndex = 30
        Me.lbl_hora.Text = "Hora:"
        '
        'Relogio
        '
        Me.Relogio.Enabled = True
        '
        'lbl_dica
        '
        Me.lbl_dica.AutoEllipsis = True
        Me.lbl_dica.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_dica.Font = New System.Drawing.Font("Magneto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dica.ForeColor = System.Drawing.Color.Black
        Me.lbl_dica.Location = New System.Drawing.Point(140, 143)
        Me.lbl_dica.Name = "lbl_dica"
        Me.lbl_dica.Size = New System.Drawing.Size(300, 25)
        Me.lbl_dica.TabIndex = 32
        Me.lbl_dica.Text = "                       "
        Me.lbl_dica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_dica.Visible = False
        '
        'btn_dica_senha
        '
        Me.btn_dica_senha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_dica_senha.BackColor = System.Drawing.Color.Transparent
        Me.btn_dica_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_dica_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dica_senha.FlatAppearance.BorderSize = 0
        Me.btn_dica_senha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_dica_senha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_dica_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dica_senha.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dica_senha.Image = CType(resources.GetObject("btn_dica_senha.Image"), System.Drawing.Image)
        Me.btn_dica_senha.Location = New System.Drawing.Point(69, 81)
        Me.btn_dica_senha.Name = "btn_dica_senha"
        Me.btn_dica_senha.Size = New System.Drawing.Size(65, 63)
        Me.btn_dica_senha.TabIndex = 33
        Me.btn_dica_senha.UseVisualStyleBackColor = False
        '
        'btn_esqueceu_senha
        '
        Me.btn_esqueceu_senha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_esqueceu_senha.BackColor = System.Drawing.Color.Transparent
        Me.btn_esqueceu_senha.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources._1306471349_MAIL
        Me.btn_esqueceu_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_esqueceu_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_esqueceu_senha.FlatAppearance.BorderSize = 0
        Me.btn_esqueceu_senha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_esqueceu_senha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_esqueceu_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esqueceu_senha.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esqueceu_senha.Location = New System.Drawing.Point(69, 150)
        Me.btn_esqueceu_senha.Name = "btn_esqueceu_senha"
        Me.btn_esqueceu_senha.Size = New System.Drawing.Size(65, 59)
        Me.btn_esqueceu_senha.TabIndex = 34
        Me.btn_esqueceu_senha.UseVisualStyleBackColor = False
        '
        'lbl_esqueceu_senha
        '
        Me.lbl_esqueceu_senha.AutoSize = True
        Me.lbl_esqueceu_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_esqueceu_senha.Font = New System.Drawing.Font("Magneto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_esqueceu_senha.ForeColor = System.Drawing.Color.Black
        Me.lbl_esqueceu_senha.Location = New System.Drawing.Point(165, 173)
        Me.lbl_esqueceu_senha.Name = "lbl_esqueceu_senha"
        Me.lbl_esqueceu_senha.Size = New System.Drawing.Size(261, 25)
        Me.lbl_esqueceu_senha.TabIndex = 35
        Me.lbl_esqueceu_senha.Text = "Esqueceu sua Senha?"
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 474)
        Me.Controls.Add(Me.lbl_esqueceu_senha)
        Me.Controls.Add(Me.btn_esqueceu_senha)
        Me.Controls.Add(Me.btn_dica_senha)
        Me.Controls.Add(Me.lbl_exibir_dica_senha)
        Me.Controls.Add(Me.lbl_dica)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_mensagem)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(293, 105)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.TransparencyKey = System.Drawing.Color.Cornsilk
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents txt_senha As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents lbl_mensagem As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_exibir_dica_senha As System.Windows.Forms.Label
    Friend WithEvents lbl_data As System.Windows.Forms.Label
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Relogio As System.Windows.Forms.Timer
    Friend WithEvents lbl_dica As System.Windows.Forms.Label
    Friend WithEvents btn_dica_senha As System.Windows.Forms.Button
    Friend WithEvents btn_esqueceu_senha As System.Windows.Forms.Button
    Friend WithEvents lbl_esqueceu_senha As System.Windows.Forms.Label

End Class
