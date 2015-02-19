<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unidade_Escolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Unidade_Escolar))
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ptb_foto = New System.Windows.Forms.PictureBox
        Me.btn_carregar_foto = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_unidade = New System.Windows.Forms.TextBox
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_endereco = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_nome_sede = New System.Windows.Forms.Label
        Me.txt_nome_unidade = New System.Windows.Forms.TextBox
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.dlg_imagens = New System.Windows.Forms.OpenFileDialog
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.lst_consulta = New System.Windows.Forms.ListBox
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.rad_num = New System.Windows.Forms.RadioButton
        Me.rad_nome = New System.Windows.Forms.RadioButton
        Me.grb_cadastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_sup.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.GroupBox1)
        Me.grb_cadastro.Controls.Add(Me.Label1)
        Me.grb_cadastro.Controls.Add(Me.txt_unidade)
        Me.grb_cadastro.Controls.Add(Me.txt_tel)
        Me.grb_cadastro.Controls.Add(Me.Label5)
        Me.grb_cadastro.Controls.Add(Me.txt_endereco)
        Me.grb_cadastro.Controls.Add(Me.Label3)
        Me.grb_cadastro.Controls.Add(Me.txt_email)
        Me.grb_cadastro.Controls.Add(Me.lbl_email)
        Me.grb_cadastro.Controls.Add(Me.lbl_nome_sede)
        Me.grb_cadastro.Controls.Add(Me.txt_nome_unidade)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(12, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(483, 260)
        Me.grb_cadastro.TabIndex = 46
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Unidade"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ptb_foto)
        Me.GroupBox1.Controls.Add(Me.btn_carregar_foto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 207)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logotipo"
        '
        'ptb_foto
        '
        Me.ptb_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.sede
        Me.ptb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ptb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_foto.Enabled = False
        Me.ptb_foto.Location = New System.Drawing.Point(6, 34)
        Me.ptb_foto.Name = "ptb_foto"
        Me.ptb_foto.Size = New System.Drawing.Size(124, 121)
        Me.ptb_foto.TabIndex = 59
        Me.ptb_foto.TabStop = False
        '
        'btn_carregar_foto
        '
        Me.btn_carregar_foto.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.Search__2_
        Me.btn_carregar_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_carregar_foto.FlatAppearance.BorderSize = 0
        Me.btn_carregar_foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_carregar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_carregar_foto.Location = New System.Drawing.Point(36, 161)
        Me.btn_carregar_foto.Name = "btn_carregar_foto"
        Me.btn_carregar_foto.Size = New System.Drawing.Size(65, 40)
        Me.btn_carregar_foto.TabIndex = 5
        Me.btn_carregar_foto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nº da Unidade*:"
        '
        'txt_unidade
        '
        Me.txt_unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unidade.Location = New System.Drawing.Point(362, 204)
        Me.txt_unidade.MaxLength = 8
        Me.txt_unidade.Name = "txt_unidade"
        Me.txt_unidade.Size = New System.Drawing.Size(115, 22)
        Me.txt_unidade.TabIndex = 4
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(339, 157)
        Me.txt_tel.Mask = "(00) 0000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(138, 22)
        Me.txt_tel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(148, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Telefone* :"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(264, 113)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(213, 22)
        Me.txt_endereco.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Endereço* :"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(264, 64)
        Me.txt_email.MaxLength = 30
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(213, 22)
        Me.txt_email.TabIndex = 1
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(148, 70)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(56, 16)
        Me.lbl_email.TabIndex = 2
        Me.lbl_email.Text = "E-Mail:"
        '
        'lbl_nome_sede
        '
        Me.lbl_nome_sede.AutoSize = True
        Me.lbl_nome_sede.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_sede.Location = New System.Drawing.Point(148, 23)
        Me.lbl_nome_sede.Name = "lbl_nome_sede"
        Me.lbl_nome_sede.Size = New System.Drawing.Size(116, 16)
        Me.lbl_nome_sede.TabIndex = 1
        Me.lbl_nome_sede.Text = "Nome da Uni.* :"
        '
        'txt_nome_unidade
        '
        Me.txt_nome_unidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_unidade.Location = New System.Drawing.Point(264, 17)
        Me.txt_nome_unidade.Name = "txt_nome_unidade"
        Me.txt_nome_unidade.Size = New System.Drawing.Size(213, 22)
        Me.txt_nome_unidade.TabIndex = 0
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_novo, Me.mnu_alterar, Me.mnu_limpar, Me.mnu_consulta, Me.mnu_excluir, Me.mnu_salvar})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(780, 68)
        Me.mnu_sup.TabIndex = 52
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_novo
        '
        Me.mnu_novo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_novo.Image = Global.Lótus_1._0.My.Resources.Resources.Word_Processor
        Me.mnu_novo.Name = "mnu_novo"
        Me.mnu_novo.Size = New System.Drawing.Size(57, 64)
        Me.mnu_novo.Text = "Novo"
        Me.mnu_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_novo.ToolTipText = "Adiciona uma nova sede"
        '
        'mnu_alterar
        '
        Me.mnu_alterar.Enabled = False
        Me.mnu_alterar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_alterar.Image = Global.Lótus_1._0.My.Resources.Resources.Writing
        Me.mnu_alterar.Name = "mnu_alterar"
        Me.mnu_alterar.Size = New System.Drawing.Size(58, 64)
        Me.mnu_alterar.Text = "Alterar"
        Me.mnu_alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_alterar.ToolTipText = "Altera uma sede"
        '
        'mnu_limpar
        '
        Me.mnu_limpar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_limpar.Image = Global.Lótus_1._0.My.Resources.Resources.CCleaner
        Me.mnu_limpar.Name = "mnu_limpar"
        Me.mnu_limpar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_limpar.Text = "Limpar"
        Me.mnu_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_limpar.ToolTipText = "Limpa todos os campos"
        Me.mnu_limpar.Visible = False
        '
        'mnu_consulta
        '
        Me.mnu_consulta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_consulta.Image = Global.Lótus_1._0.My.Resources.Resources.consultar
        Me.mnu_consulta.Name = "mnu_consulta"
        Me.mnu_consulta.Size = New System.Drawing.Size(71, 64)
        Me.mnu_consulta.Text = "Consultar"
        Me.mnu_consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_consulta.ToolTipText = "Consulta um cadastro"
        '
        'mnu_excluir
        '
        Me.mnu_excluir.Enabled = False
        Me.mnu_excluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_excluir.Image = Global.Lótus_1._0.My.Resources.Resources.Recycle
        Me.mnu_excluir.Name = "mnu_excluir"
        Me.mnu_excluir.Size = New System.Drawing.Size(57, 64)
        Me.mnu_excluir.Text = "Excluir"
        Me.mnu_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_excluir.ToolTipText = "Exclui um cadastro"
        '
        'mnu_salvar
        '
        Me.mnu_salvar.Enabled = False
        Me.mnu_salvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_salvar.Image = Global.Lótus_1._0.My.Resources.Resources.Hard_Drive
        Me.mnu_salvar.Name = "mnu_salvar"
        Me.mnu_salvar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_salvar.Text = "Salvar"
        Me.mnu_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dlg_imagens
        '
        Me.dlg_imagens.FileName = "OpenFileDialog1"
        Me.dlg_imagens.Filter = "(Arquivos de imagens BMP;JPG;GIF;PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        Me.dlg_imagens.RestoreDirectory = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(6, 41)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(255, 22)
        Me.txt_pesquisa.TabIndex = 3
        '
        'lst_consulta
        '
        Me.lst_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta.FormattingEnabled = True
        Me.lst_consulta.HorizontalScrollbar = True
        Me.lst_consulta.ItemHeight = 16
        Me.lst_consulta.Location = New System.Drawing.Point(6, 70)
        Me.lst_consulta.Name = "lst_consulta"
        Me.lst_consulta.Size = New System.Drawing.Size(255, 180)
        Me.lst_consulta.TabIndex = 0
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.rad_num)
        Me.grb_consulta.Controls.Add(Me.rad_nome)
        Me.grb_consulta.Controls.Add(Me.lst_consulta)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(501, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(267, 260)
        Me.grb_consulta.TabIndex = 64
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'rad_num
        '
        Me.rad_num.AutoSize = True
        Me.rad_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_num.Location = New System.Drawing.Point(190, 12)
        Me.rad_num.Name = "rad_num"
        Me.rad_num.Size = New System.Drawing.Size(71, 20)
        Me.rad_num.TabIndex = 2
        Me.rad_num.TabStop = True
        Me.rad_num.Text = "Por Nº"
        Me.rad_num.UseVisualStyleBackColor = True
        '
        'rad_nome
        '
        Me.rad_nome.AutoSize = True
        Me.rad_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_nome.Location = New System.Drawing.Point(6, 12)
        Me.rad_nome.Name = "rad_nome"
        Me.rad_nome.Size = New System.Drawing.Size(95, 20)
        Me.rad_nome.TabIndex = 1
        Me.rad_nome.TabStop = True
        Me.rad_nome.Text = "Por Nome"
        Me.rad_nome.UseVisualStyleBackColor = True
        '
        'Unidade_Escolar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(780, 343)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.mnu_sup)
        Me.Controls.Add(Me.grb_cadastro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Unidade_Escolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidade Escolar"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ptb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_endereco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_nome_sede As System.Windows.Forms.Label
    Friend WithEvents txt_nome_unidade As System.Windows.Forms.TextBox
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_unidade As System.Windows.Forms.TextBox
    Friend WithEvents btn_carregar_foto As System.Windows.Forms.Button
    Friend WithEvents ptb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dlg_imagens As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents lst_consulta As System.Windows.Forms.ListBox
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents rad_num As System.Windows.Forms.RadioButton
    Friend WithEvents rad_nome As System.Windows.Forms.RadioButton
End Class
