<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_esqueceu_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_esqueceu_senha))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_confirma_email = New System.Windows.Forms.TextBox
        Me.btn_esqueceu_senha = New System.Windows.Forms.Button
        Me.btn_sair = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite o Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Digite Usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirme o Email:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(197, 15)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(240, 29)
        Me.txt_usuario.TabIndex = 4
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(197, 54)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(240, 29)
        Me.txt_email.TabIndex = 5
        '
        'txt_confirma_email
        '
        Me.txt_confirma_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirma_email.Location = New System.Drawing.Point(197, 94)
        Me.txt_confirma_email.Name = "txt_confirma_email"
        Me.txt_confirma_email.Size = New System.Drawing.Size(240, 29)
        Me.txt_confirma_email.TabIndex = 6
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
        Me.btn_esqueceu_senha.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esqueceu_senha.Location = New System.Drawing.Point(151, 153)
        Me.btn_esqueceu_senha.Name = "btn_esqueceu_senha"
        Me.btn_esqueceu_senha.Size = New System.Drawing.Size(65, 59)
        Me.btn_esqueceu_senha.TabIndex = 35
        Me.btn_esqueceu_senha.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources._1306549341_monotone_close_exit_delete
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btn_sair.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.Location = New System.Drawing.Point(222, 153)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(65, 59)
        Me.btn_sair.TabIndex = 36
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_esqueceu_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(449, 234)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_esqueceu_senha)
        Me.Controls.Add(Me.txt_confirma_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_esqueceu_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_confirma_email As System.Windows.Forms.TextBox
    Friend WithEvents btn_esqueceu_senha As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
End Class
