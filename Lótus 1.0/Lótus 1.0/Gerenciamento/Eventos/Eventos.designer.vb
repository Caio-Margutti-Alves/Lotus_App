<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Eventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Eventos))
        Me.tlp_login = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_nm_evento = New System.Windows.Forms.TextBox
        Me.dtp_evento = New System.Windows.Forms.MonthCalendar
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_cadastrar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_ds_evento = New System.Windows.Forms.TextBox
        Me.lbl_camposobrigatorios = New System.Windows.Forms.Label
        Me.lbl_feriado = New System.Windows.Forms.Label
        Me.grb_data = New System.Windows.Forms.GroupBox
        Me.mnu_sup.SuspendLayout()
        Me.grb_cadastro.SuspendLayout()
        Me.grb_data.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_login
        '
        Me.tlp_login.AutomaticDelay = 500000
        Me.tlp_login.AutoPopDelay = 5000
        Me.tlp_login.InitialDelay = 500
        Me.tlp_login.IsBalloon = True
        Me.tlp_login.ReshowDelay = 1
        Me.tlp_login.ShowAlways = True
        '
        'txt_nm_evento
        '
        Me.txt_nm_evento.BackColor = System.Drawing.Color.White
        Me.txt_nm_evento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nm_evento.Location = New System.Drawing.Point(15, 35)
        Me.txt_nm_evento.Name = "txt_nm_evento"
        Me.txt_nm_evento.Size = New System.Drawing.Size(275, 22)
        Me.txt_nm_evento.TabIndex = 3
        Me.txt_nm_evento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tlp_login.SetToolTip(Me.txt_nm_evento, "Digite o nome do feriado ou dia não letivo")
        '
        'dtp_evento
        '
        Me.dtp_evento.BackColor = System.Drawing.Color.White
        Me.dtp_evento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_evento.ForeColor = System.Drawing.Color.Black
        Me.dtp_evento.Location = New System.Drawing.Point(41, 15)
        Me.dtp_evento.MaxSelectionCount = 1
        Me.dtp_evento.Name = "dtp_evento"
        Me.dtp_evento.TabIndex = 0
        Me.dtp_evento.TitleBackColor = System.Drawing.Color.Black
        Me.dtp_evento.TitleForeColor = System.Drawing.Color.White
        Me.tlp_login.SetToolTip(Me.dtp_evento, "Selecione a data do feriado ou dia não letivo")
        Me.dtp_evento.TrailingForeColor = System.Drawing.Color.DarkGray
        '
        'mnu_sup
        '
        Me.mnu_sup.BackColor = System.Drawing.Color.Transparent
        Me.mnu_sup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnu_sup.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.mnu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_cadastrar, Me.mnu_alterar, Me.mnu_excluir, Me.mnu_salvar})
        Me.mnu_sup.Location = New System.Drawing.Point(0, 0)
        Me.mnu_sup.Name = "mnu_sup"
        Me.mnu_sup.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnu_sup.Size = New System.Drawing.Size(333, 68)
        Me.mnu_sup.TabIndex = 47
        Me.mnu_sup.Text = "MenuStrip1"
        '
        'mnu_cadastrar
        '
        Me.mnu_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_cadastrar.Image = Global.Lótus_1._0.My.Resources.Resources.Word_Processor
        Me.mnu_cadastrar.Name = "mnu_cadastrar"
        Me.mnu_cadastrar.Size = New System.Drawing.Size(57, 64)
        Me.mnu_cadastrar.Text = "Novo"
        Me.mnu_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_cadastrar.ToolTipText = "Adiciona um novo feriado ou dia não letivo"
        '
        'mnu_alterar
        '
        Me.mnu_alterar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_alterar.Image = Global.Lótus_1._0.My.Resources.Resources.Writing
        Me.mnu_alterar.Name = "mnu_alterar"
        Me.mnu_alterar.Size = New System.Drawing.Size(58, 64)
        Me.mnu_alterar.Text = "Alterar"
        Me.mnu_alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_alterar.ToolTipText = "Altera um feriado ou dia não letivo"
        '
        'mnu_excluir
        '
        Me.mnu_excluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnu_excluir.Image = Global.Lótus_1._0.My.Resources.Resources.Recycle
        Me.mnu_excluir.Name = "mnu_excluir"
        Me.mnu_excluir.Size = New System.Drawing.Size(57, 64)
        Me.mnu_excluir.Text = "Excluir"
        Me.mnu_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnu_excluir.ToolTipText = "Exclui um feriado ou dia não letivo"
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
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.Label3)
        Me.grb_cadastro.Controls.Add(Me.txt_ds_evento)
        Me.grb_cadastro.Controls.Add(Me.lbl_camposobrigatorios)
        Me.grb_cadastro.Controls.Add(Me.txt_nm_evento)
        Me.grb_cadastro.Controls.Add(Me.lbl_feriado)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(13, 303)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(310, 196)
        Me.grb_cadastro.TabIndex = 49
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Evento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Descrição:"
        '
        'txt_ds_evento
        '
        Me.txt_ds_evento.BackColor = System.Drawing.Color.White
        Me.txt_ds_evento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ds_evento.Location = New System.Drawing.Point(15, 90)
        Me.txt_ds_evento.Multiline = True
        Me.txt_ds_evento.Name = "txt_ds_evento"
        Me.txt_ds_evento.Size = New System.Drawing.Size(275, 87)
        Me.txt_ds_evento.TabIndex = 43
        '
        'lbl_camposobrigatorios
        '
        Me.lbl_camposobrigatorios.AutoSize = True
        Me.lbl_camposobrigatorios.Location = New System.Drawing.Point(142, 180)
        Me.lbl_camposobrigatorios.Name = "lbl_camposobrigatorios"
        Me.lbl_camposobrigatorios.Size = New System.Drawing.Size(162, 15)
        Me.lbl_camposobrigatorios.TabIndex = 35
        Me.lbl_camposobrigatorios.Text = "(*) Campos Obrigatórios"
        '
        'lbl_feriado
        '
        Me.lbl_feriado.AutoSize = True
        Me.lbl_feriado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_feriado.Location = New System.Drawing.Point(85, 16)
        Me.lbl_feriado.Name = "lbl_feriado"
        Me.lbl_feriado.Size = New System.Drawing.Size(137, 16)
        Me.lbl_feriado.TabIndex = 2
        Me.lbl_feriado.Text = "Nome do Evento* :"
        '
        'grb_data
        '
        Me.grb_data.Controls.Add(Me.dtp_evento)
        Me.grb_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_data.ForeColor = System.Drawing.Color.Black
        Me.grb_data.Location = New System.Drawing.Point(13, 71)
        Me.grb_data.Name = "grb_data"
        Me.grb_data.Size = New System.Drawing.Size(309, 226)
        Me.grb_data.TabIndex = 50
        Me.grb_data.TabStop = False
        Me.grb_data.Text = "Data"
        '
        'Cadastro_Eventos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 511)
        Me.Controls.Add(Me.grb_data)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.mnu_sup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cadastro_Eventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Eventos"
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_data.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlp_login As System.Windows.Forms.ToolTip
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_cadastrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_evento As System.Windows.Forms.MonthCalendar
    Friend WithEvents txt_nm_evento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_feriado As System.Windows.Forms.Label
    Friend WithEvents lbl_camposobrigatorios As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ds_evento As System.Windows.Forms.TextBox
    Friend WithEvents grb_data As System.Windows.Forms.GroupBox
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
End Class
