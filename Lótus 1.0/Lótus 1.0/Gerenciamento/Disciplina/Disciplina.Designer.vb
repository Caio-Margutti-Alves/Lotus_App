<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disciplina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Disciplina))
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.lbl_maxaulas = New System.Windows.Forms.Label
        Me.txt_qtde_aulas_sem = New System.Windows.Forms.TextBox
        Me.lbl_abreviacao = New System.Windows.Forms.Label
        Me.txt_disciplina_abrevi = New System.Windows.Forms.TextBox
        Me.lbl_disciplina = New System.Windows.Forms.Label
        Me.txt_nome_disciplina = New System.Windows.Forms.TextBox
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.lst_consulta = New System.Windows.Forms.ListBox
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_cadastro.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.mnu_sup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.lbl_maxaulas)
        Me.grb_cadastro.Controls.Add(Me.txt_qtde_aulas_sem)
        Me.grb_cadastro.Controls.Add(Me.lbl_abreviacao)
        Me.grb_cadastro.Controls.Add(Me.txt_disciplina_abrevi)
        Me.grb_cadastro.Controls.Add(Me.lbl_disciplina)
        Me.grb_cadastro.Controls.Add(Me.txt_nome_disciplina)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(8, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(345, 266)
        Me.grb_cadastro.TabIndex = 55
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Disciplina"
        '
        'lbl_maxaulas
        '
        Me.lbl_maxaulas.AutoSize = True
        Me.lbl_maxaulas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_maxaulas.Location = New System.Drawing.Point(49, 213)
        Me.lbl_maxaulas.Name = "lbl_maxaulas"
        Me.lbl_maxaulas.Size = New System.Drawing.Size(255, 16)
        Me.lbl_maxaulas.TabIndex = 36
        Me.lbl_maxaulas.Text = "Quantidade de Aulas por Semana* :"
        '
        'txt_qtde_aulas_sem
        '
        Me.txt_qtde_aulas_sem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde_aulas_sem.Location = New System.Drawing.Point(137, 232)
        Me.txt_qtde_aulas_sem.Name = "txt_qtde_aulas_sem"
        Me.txt_qtde_aulas_sem.Size = New System.Drawing.Size(66, 22)
        Me.txt_qtde_aulas_sem.TabIndex = 35
        Me.txt_qtde_aulas_sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_abreviacao
        '
        Me.lbl_abreviacao.AutoSize = True
        Me.lbl_abreviacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abreviacao.Location = New System.Drawing.Point(122, 123)
        Me.lbl_abreviacao.Name = "lbl_abreviacao"
        Me.lbl_abreviacao.Size = New System.Drawing.Size(98, 16)
        Me.lbl_abreviacao.TabIndex = 6
        Me.lbl_abreviacao.Text = "Abreviatura*:"
        '
        'txt_disciplina_abrevi
        '
        Me.txt_disciplina_abrevi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disciplina_abrevi.Location = New System.Drawing.Point(80, 142)
        Me.txt_disciplina_abrevi.MaxLength = 10
        Me.txt_disciplina_abrevi.Name = "txt_disciplina_abrevi"
        Me.txt_disciplina_abrevi.Size = New System.Drawing.Size(181, 22)
        Me.txt_disciplina_abrevi.TabIndex = 5
        Me.txt_disciplina_abrevi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_disciplina
        '
        Me.lbl_disciplina.AutoSize = True
        Me.lbl_disciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_disciplina.Location = New System.Drawing.Point(92, 38)
        Me.lbl_disciplina.Name = "lbl_disciplina"
        Me.lbl_disciplina.Size = New System.Drawing.Size(158, 16)
        Me.lbl_disciplina.TabIndex = 1
        Me.lbl_disciplina.Text = "Nome da Disciplina* :"
        '
        'txt_nome_disciplina
        '
        Me.txt_nome_disciplina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_disciplina.Location = New System.Drawing.Point(6, 57)
        Me.txt_nome_disciplina.Name = "txt_nome_disciplina"
        Me.txt_nome_disciplina.Size = New System.Drawing.Size(333, 22)
        Me.txt_nome_disciplina.TabIndex = 0
        Me.txt_nome_disciplina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.lst_consulta)
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Controls.Add(Me.Label3)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(359, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(357, 266)
        Me.grb_consulta.TabIndex = 56
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'lst_consulta
        '
        Me.lst_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta.FormattingEnabled = True
        Me.lst_consulta.HorizontalScrollbar = True
        Me.lst_consulta.ItemHeight = 16
        Me.lst_consulta.Location = New System.Drawing.Point(6, 74)
        Me.lst_consulta.Name = "lst_consulta"
        Me.lst_consulta.Size = New System.Drawing.Size(345, 180)
        Me.lst_consulta.TabIndex = 62
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(6, 42)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(345, 22)
        Me.txt_pesquisa.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Por Abreviatura:"
        '
        'mnu_novo
        '
        Me.mnu_novo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.mnu_alterar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.mnu_consulta.ToolTipText = "Consulta uma sede"
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
        Me.mnu_excluir.ToolTipText = "Exclui uma sede"
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
        Me.mnu_sup.Size = New System.Drawing.Size(728, 68)
        Me.mnu_sup.TabIndex = 51
        Me.mnu_sup.Text = "MenuStrip1"
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
        'Disciplina
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(728, 346)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.mnu_sup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Disciplina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disciplina"
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_maxaulas As System.Windows.Forms.Label
    Friend WithEvents txt_qtde_aulas_sem As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abreviacao As System.Windows.Forms.Label
    Friend WithEvents txt_disciplina_abrevi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_disciplina As System.Windows.Forms.Label
    Friend WithEvents txt_nome_disciplina As System.Windows.Forms.TextBox
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents lst_consulta As System.Windows.Forms.ListBox
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
End Class
