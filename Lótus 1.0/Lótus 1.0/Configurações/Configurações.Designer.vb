<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuracoes))
        Me.dlg_papel_parede = New System.Windows.Forms.OpenFileDialog
        Me.pct_tema = New System.Windows.Forms.PictureBox
        Me.pct_papel_parede = New System.Windows.Forms.PictureBox
        Me.pct_tema2 = New System.Windows.Forms.PictureBox
        Me.pct_multiplo = New System.Windows.Forms.PictureBox
        Me.tsp_config = New System.Windows.Forms.ToolStrip
        Me.mnu_altera_tema = New System.Windows.Forms.ToolStripButton
        Me.mnu_altera_fundo = New System.Windows.Forms.ToolStripButton
        Me.mnu_backup = New System.Windows.Forms.ToolStripButton
        Me.mnu_restaurar_banco = New System.Windows.Forms.ToolStripButton
        Me.mnu_restaurar_padrao = New System.Windows.Forms.ToolStripButton
        Me.mnu_opcoes_design = New System.Windows.Forms.MenuStrip
        Me.mnu_ok = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_altera_cor = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_carregar_imagem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_cancelar = New System.Windows.Forms.ToolStripMenuItem
        Me.cdg_cores_fundo = New System.Windows.Forms.ColorDialog
        Me.backup = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.pct_tema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_papel_parede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_tema2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_multiplo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsp_config.SuspendLayout()
        Me.mnu_opcoes_design.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlg_papel_parede
        '
        Me.dlg_papel_parede.AddExtension = False
        Me.dlg_papel_parede.FileName = "OpenFileDialog1"
        Me.dlg_papel_parede.Filter = "Graphic Files |*.gif; *.bmp; *.jpg| All Files|*.*"
        '
        'pct_tema
        '
        Me.pct_tema.BackColor = System.Drawing.Color.White
        Me.pct_tema.Location = New System.Drawing.Point(432, 88)
        Me.pct_tema.Name = "pct_tema"
        Me.pct_tema.Size = New System.Drawing.Size(178, 148)
        Me.pct_tema.TabIndex = 18
        Me.pct_tema.TabStop = False
        '
        'pct_papel_parede
        '
        Me.pct_papel_parede.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pct_papel_parede.BackColor = System.Drawing.Color.White
        Me.pct_papel_parede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pct_papel_parede.Location = New System.Drawing.Point(358, 34)
        Me.pct_papel_parede.Name = "pct_papel_parede"
        Me.pct_papel_parede.Size = New System.Drawing.Size(268, 161)
        Me.pct_papel_parede.TabIndex = 20
        Me.pct_papel_parede.TabStop = False
        Me.pct_papel_parede.Visible = False
        '
        'pct_tema2
        '
        Me.pct_tema2.BackColor = System.Drawing.Color.White
        Me.pct_tema2.Location = New System.Drawing.Point(317, 39)
        Me.pct_tema2.Name = "pct_tema2"
        Me.pct_tema2.Size = New System.Drawing.Size(57, 261)
        Me.pct_tema2.TabIndex = 19
        Me.pct_tema2.TabStop = False
        '
        'pct_multiplo
        '
        Me.pct_multiplo.BackColor = System.Drawing.Color.Transparent
        Me.pct_multiplo.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources.display_tema
        Me.pct_multiplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pct_multiplo.Location = New System.Drawing.Point(314, 28)
        Me.pct_multiplo.Name = "pct_multiplo"
        Me.pct_multiplo.Size = New System.Drawing.Size(350, 274)
        Me.pct_multiplo.TabIndex = 17
        Me.pct_multiplo.TabStop = False
        '
        'tsp_config
        '
        Me.tsp_config.BackColor = System.Drawing.SystemColors.Control
        Me.tsp_config.Dock = System.Windows.Forms.DockStyle.Left
        Me.tsp_config.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsp_config.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsp_config.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsp_config.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_altera_tema, Me.mnu_altera_fundo, Me.mnu_backup, Me.mnu_restaurar_banco, Me.mnu_restaurar_padrao})
        Me.tsp_config.Location = New System.Drawing.Point(0, 0)
        Me.tsp_config.Name = "tsp_config"
        Me.tsp_config.Size = New System.Drawing.Size(231, 365)
        Me.tsp_config.TabIndex = 27
        Me.tsp_config.Text = "ToolStrip1"
        '
        'mnu_altera_tema
        '
        Me.mnu_altera_tema.BackColor = System.Drawing.SystemColors.Control
        Me.mnu_altera_tema.Font = New System.Drawing.Font("Tunga", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_altera_tema.ForeColor = System.Drawing.Color.Black
        Me.mnu_altera_tema.Image = Global.Lótus_1._0.My.Resources.Resources.balde_tinta
        Me.mnu_altera_tema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnu_altera_tema.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.mnu_altera_tema.Name = "mnu_altera_tema"
        Me.mnu_altera_tema.Padding = New System.Windows.Forms.Padding(0, 18, 0, 18)
        Me.mnu_altera_tema.Size = New System.Drawing.Size(228, 70)
        Me.mnu_altera_tema.Text = "Alterar Cor Tema"
        '
        'mnu_altera_fundo
        '
        Me.mnu_altera_fundo.BackColor = System.Drawing.SystemColors.Control
        Me.mnu_altera_fundo.Font = New System.Drawing.Font("Tunga", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_altera_fundo.ForeColor = System.Drawing.Color.Black
        Me.mnu_altera_fundo.Image = Global.Lótus_1._0.My.Resources.Resources.Picture
        Me.mnu_altera_fundo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnu_altera_fundo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_altera_fundo.Name = "mnu_altera_fundo"
        Me.mnu_altera_fundo.Padding = New System.Windows.Forms.Padding(0, 18, 0, 18)
        Me.mnu_altera_fundo.Size = New System.Drawing.Size(228, 70)
        Me.mnu_altera_fundo.Text = "Alterar Imagem de Fundo"
        '
        'mnu_backup
        '
        Me.mnu_backup.BackColor = System.Drawing.SystemColors.Control
        Me.mnu_backup.Font = New System.Drawing.Font("Tunga", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_backup.ForeColor = System.Drawing.Color.Black
        Me.mnu_backup.Image = Global.Lótus_1._0.My.Resources.Resources.backup
        Me.mnu_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnu_backup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_backup.Name = "mnu_backup"
        Me.mnu_backup.Padding = New System.Windows.Forms.Padding(0, 18, 0, 18)
        Me.mnu_backup.Size = New System.Drawing.Size(228, 70)
        Me.mnu_backup.Text = "Backup do Banco de Dados"
        '
        'mnu_restaurar_banco
        '
        Me.mnu_restaurar_banco.BackColor = System.Drawing.SystemColors.Control
        Me.mnu_restaurar_banco.Font = New System.Drawing.Font("Tunga", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_restaurar_banco.ForeColor = System.Drawing.Color.Black
        Me.mnu_restaurar_banco.Image = Global.Lótus_1._0.My.Resources.Resources.restaurar_banco
        Me.mnu_restaurar_banco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnu_restaurar_banco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_restaurar_banco.Name = "mnu_restaurar_banco"
        Me.mnu_restaurar_banco.Padding = New System.Windows.Forms.Padding(0, 18, 0, 18)
        Me.mnu_restaurar_banco.Size = New System.Drawing.Size(228, 70)
        Me.mnu_restaurar_banco.Text = "Restaurar Banco de Dados"
        '
        'mnu_restaurar_padrao
        '
        Me.mnu_restaurar_padrao.BackColor = System.Drawing.SystemColors.Control
        Me.mnu_restaurar_padrao.Font = New System.Drawing.Font("Tunga", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_restaurar_padrao.ForeColor = System.Drawing.Color.Black
        Me.mnu_restaurar_padrao.Image = Global.Lótus_1._0.My.Resources.Resources.Circle
        Me.mnu_restaurar_padrao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnu_restaurar_padrao.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_restaurar_padrao.Name = "mnu_restaurar_padrao"
        Me.mnu_restaurar_padrao.Padding = New System.Windows.Forms.Padding(0, 18, 0, 18)
        Me.mnu_restaurar_padrao.Size = New System.Drawing.Size(228, 70)
        Me.mnu_restaurar_padrao.Text = "Restaurar Padrão"
        '
        'mnu_opcoes_design
        '
        Me.mnu_opcoes_design.BackColor = System.Drawing.Color.Transparent
        Me.mnu_opcoes_design.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mnu_opcoes_design.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnu_opcoes_design.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ok, Me.mnu_altera_cor, Me.mnu_carregar_imagem, Me.mnu_cancelar})
        Me.mnu_opcoes_design.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnu_opcoes_design.Location = New System.Drawing.Point(231, 302)
        Me.mnu_opcoes_design.Name = "mnu_opcoes_design"
        Me.mnu_opcoes_design.Size = New System.Drawing.Size(498, 63)
        Me.mnu_opcoes_design.TabIndex = 28
        Me.mnu_opcoes_design.Text = "MenuStrip1"
        '
        'mnu_ok
        '
        Me.mnu_ok.AutoSize = False
        Me.mnu_ok.Image = Global.Lótus_1._0.My.Resources.Resources.check
        Me.mnu_ok.Name = "mnu_ok"
        Me.mnu_ok.Size = New System.Drawing.Size(70, 59)
        Me.mnu_ok.Text = "OK"
        Me.mnu_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnu_altera_cor
        '
        Me.mnu_altera_cor.Image = Global.Lótus_1._0.My.Resources.Resources.Paint
        Me.mnu_altera_cor.Name = "mnu_altera_cor"
        Me.mnu_altera_cor.Size = New System.Drawing.Size(76, 59)
        Me.mnu_altera_cor.Text = "Alterar Cor"
        Me.mnu_altera_cor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnu_carregar_imagem
        '
        Me.mnu_carregar_imagem.Image = Global.Lótus_1._0.My.Resources.Resources.Folder
        Me.mnu_carregar_imagem.Name = "mnu_carregar_imagem"
        Me.mnu_carregar_imagem.Size = New System.Drawing.Size(111, 59)
        Me.mnu_carregar_imagem.Text = "Carregar Imagem"
        Me.mnu_carregar_imagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_carregar_imagem.Visible = False
        '
        'mnu_cancelar
        '
        Me.mnu_cancelar.Image = Global.Lótus_1._0.My.Resources.Resources.Xion
        Me.mnu_cancelar.Name = "mnu_cancelar"
        Me.mnu_cancelar.Size = New System.Drawing.Size(65, 59)
        Me.mnu_cancelar.Text = "Cancelar"
        Me.mnu_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cdg_cores_fundo
        '
        Me.cdg_cores_fundo.AnyColor = True
        Me.cdg_cores_fundo.FullOpen = True
        '
        'configuracoes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 365)
        Me.Controls.Add(Me.pct_papel_parede)
        Me.Controls.Add(Me.mnu_opcoes_design)
        Me.Controls.Add(Me.tsp_config)
        Me.Controls.Add(Me.pct_tema)
        Me.Controls.Add(Me.pct_tema2)
        Me.Controls.Add(Me.pct_multiplo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "configuracoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        CType(Me.pct_tema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_papel_parede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_tema2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_multiplo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsp_config.ResumeLayout(False)
        Me.tsp_config.PerformLayout()
        Me.mnu_opcoes_design.ResumeLayout(False)
        Me.mnu_opcoes_design.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlg_papel_parede As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pct_tema As System.Windows.Forms.PictureBox
    Friend WithEvents pct_papel_parede As System.Windows.Forms.PictureBox
    Friend WithEvents pct_tema2 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_multiplo As System.Windows.Forms.PictureBox
    Friend WithEvents tsp_config As System.Windows.Forms.ToolStrip
    Friend WithEvents mnu_altera_tema As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnu_altera_fundo As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnu_backup As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnu_restaurar_banco As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnu_restaurar_padrao As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnu_opcoes_design As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_ok As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_carregar_imagem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_altera_cor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_cancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cdg_cores_fundo As System.Windows.Forms.ColorDialog
    Friend WithEvents backup As System.Windows.Forms.FolderBrowserDialog
End Class
