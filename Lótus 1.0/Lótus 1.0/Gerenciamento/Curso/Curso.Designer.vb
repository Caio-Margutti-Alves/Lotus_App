<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Curso))
        Me.mnu_alterar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_consulta = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_excluir = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_sup = New System.Windows.Forms.MenuStrip
        Me.mnu_novo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_limpar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_salvar = New System.Windows.Forms.ToolStripMenuItem
        Me.grb_consulta = New System.Windows.Forms.GroupBox
        Me.chk_pesq_noite = New System.Windows.Forms.CheckBox
        Me.chk_pesq_tarde = New System.Windows.Forms.CheckBox
        Me.chk_pesq_manha = New System.Windows.Forms.CheckBox
        Me.lst_consulta_curso = New System.Windows.Forms.ListBox
        Me.rdbperiodo = New System.Windows.Forms.RadioButton
        Me.rdbnomecurso = New System.Windows.Forms.RadioButton
        Me.txt_pesquisa = New System.Windows.Forms.TextBox
        Me.grb_cadastro = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_noite = New System.Windows.Forms.CheckBox
        Me.chk_tarde = New System.Windows.Forms.CheckBox
        Me.chk_manha = New System.Windows.Forms.CheckBox
        Me.lbl_modulo = New System.Windows.Forms.Label
        Me.txt_qtde_modulo = New System.Windows.Forms.TextBox
        Me.grb_tipo = New System.Windows.Forms.GroupBox
        Me.rdb_semestral = New System.Windows.Forms.RadioButton
        Me.rdb_anual = New System.Windows.Forms.RadioButton
        Me.lbl_qtaula = New System.Windows.Forms.Label
        Me.txt_qtde_aulas_sem = New System.Windows.Forms.TextBox
        Me.lbl_abrevi = New System.Windows.Forms.Label
        Me.txt_sigla_curso = New System.Windows.Forms.TextBox
        Me.lbl_curso = New System.Windows.Forms.Label
        Me.txt_curso = New System.Windows.Forms.TextBox
        Me.btn_professor_proximo = New System.Windows.Forms.Button
        Me.btn_professor_anterior = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_professor_ultimo = New System.Windows.Forms.Button
        Me.btn_professor_primeiro = New System.Windows.Forms.Button
        Me.lbl_camposobrigatorios = New System.Windows.Forms.Label
        Me.mnu_sup.SuspendLayout()
        Me.grb_consulta.SuspendLayout()
        Me.grb_cadastro.SuspendLayout()
        Me.grb_tipo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.mnu_sup.Size = New System.Drawing.Size(620, 68)
        Me.mnu_sup.TabIndex = 55
        Me.mnu_sup.Text = "MenuStrip1"
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
        'grb_consulta
        '
        Me.grb_consulta.BackColor = System.Drawing.Color.Transparent
        Me.grb_consulta.Controls.Add(Me.chk_pesq_noite)
        Me.grb_consulta.Controls.Add(Me.chk_pesq_tarde)
        Me.grb_consulta.Controls.Add(Me.chk_pesq_manha)
        Me.grb_consulta.Controls.Add(Me.lst_consulta_curso)
        Me.grb_consulta.Controls.Add(Me.rdbperiodo)
        Me.grb_consulta.Controls.Add(Me.rdbnomecurso)
        Me.grb_consulta.Controls.Add(Me.txt_pesquisa)
        Me.grb_consulta.Enabled = False
        Me.grb_consulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_consulta.ForeColor = System.Drawing.Color.Black
        Me.grb_consulta.Location = New System.Drawing.Point(333, 71)
        Me.grb_consulta.Name = "grb_consulta"
        Me.grb_consulta.Size = New System.Drawing.Size(282, 310)
        Me.grb_consulta.TabIndex = 62
        Me.grb_consulta.TabStop = False
        Me.grb_consulta.Text = "Consulta"
        '
        'chk_pesq_noite
        '
        Me.chk_pesq_noite.AutoSize = True
        Me.chk_pesq_noite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pesq_noite.Location = New System.Drawing.Point(208, 49)
        Me.chk_pesq_noite.Name = "chk_pesq_noite"
        Me.chk_pesq_noite.Size = New System.Drawing.Size(64, 20)
        Me.chk_pesq_noite.TabIndex = 54
        Me.chk_pesq_noite.Text = "Noite"
        Me.chk_pesq_noite.UseVisualStyleBackColor = True
        Me.chk_pesq_noite.Visible = False
        '
        'chk_pesq_tarde
        '
        Me.chk_pesq_tarde.AutoSize = True
        Me.chk_pesq_tarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pesq_tarde.Location = New System.Drawing.Point(113, 49)
        Me.chk_pesq_tarde.Name = "chk_pesq_tarde"
        Me.chk_pesq_tarde.Size = New System.Drawing.Size(69, 20)
        Me.chk_pesq_tarde.TabIndex = 53
        Me.chk_pesq_tarde.Text = "Tarde"
        Me.chk_pesq_tarde.UseVisualStyleBackColor = True
        Me.chk_pesq_tarde.Visible = False
        '
        'chk_pesq_manha
        '
        Me.chk_pesq_manha.AutoSize = True
        Me.chk_pesq_manha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pesq_manha.Location = New System.Drawing.Point(7, 49)
        Me.chk_pesq_manha.Name = "chk_pesq_manha"
        Me.chk_pesq_manha.Size = New System.Drawing.Size(73, 20)
        Me.chk_pesq_manha.TabIndex = 52
        Me.chk_pesq_manha.Text = "Manhã"
        Me.chk_pesq_manha.UseVisualStyleBackColor = True
        Me.chk_pesq_manha.Visible = False
        '
        'lst_consulta_curso
        '
        Me.lst_consulta_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_consulta_curso.FormattingEnabled = True
        Me.lst_consulta_curso.HorizontalScrollbar = True
        Me.lst_consulta_curso.ItemHeight = 16
        Me.lst_consulta_curso.Location = New System.Drawing.Point(5, 78)
        Me.lst_consulta_curso.Name = "lst_consulta_curso"
        Me.lst_consulta_curso.Size = New System.Drawing.Size(273, 228)
        Me.lst_consulta_curso.TabIndex = 51
        '
        'rdbperiodo
        '
        Me.rdbperiodo.AutoSize = True
        Me.rdbperiodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbperiodo.Location = New System.Drawing.Point(165, 19)
        Me.rdbperiodo.Name = "rdbperiodo"
        Me.rdbperiodo.Size = New System.Drawing.Size(113, 20)
        Me.rdbperiodo.TabIndex = 50
        Me.rdbperiodo.TabStop = True
        Me.rdbperiodo.Text = "Por Periodo:"
        Me.rdbperiodo.UseVisualStyleBackColor = True
        '
        'rdbnomecurso
        '
        Me.rdbnomecurso.AutoSize = True
        Me.rdbnomecurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbnomecurso.Location = New System.Drawing.Point(5, 19)
        Me.rdbnomecurso.Name = "rdbnomecurso"
        Me.rdbnomecurso.Size = New System.Drawing.Size(115, 20)
        Me.rdbnomecurso.TabIndex = 49
        Me.rdbnomecurso.TabStop = True
        Me.rdbnomecurso.Text = "Nome Curso:"
        Me.rdbnomecurso.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(7, 47)
        Me.txt_pesquisa.MaxLength = 30
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(269, 22)
        Me.txt_pesquisa.TabIndex = 48
        '
        'grb_cadastro
        '
        Me.grb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.grb_cadastro.Controls.Add(Me.Label2)
        Me.grb_cadastro.Controls.Add(Me.chk_noite)
        Me.grb_cadastro.Controls.Add(Me.chk_tarde)
        Me.grb_cadastro.Controls.Add(Me.chk_manha)
        Me.grb_cadastro.Controls.Add(Me.lbl_modulo)
        Me.grb_cadastro.Controls.Add(Me.txt_qtde_modulo)
        Me.grb_cadastro.Controls.Add(Me.grb_tipo)
        Me.grb_cadastro.Controls.Add(Me.lbl_qtaula)
        Me.grb_cadastro.Controls.Add(Me.txt_qtde_aulas_sem)
        Me.grb_cadastro.Controls.Add(Me.lbl_abrevi)
        Me.grb_cadastro.Controls.Add(Me.txt_sigla_curso)
        Me.grb_cadastro.Controls.Add(Me.lbl_curso)
        Me.grb_cadastro.Controls.Add(Me.txt_curso)
        Me.grb_cadastro.Controls.Add(Me.btn_professor_proximo)
        Me.grb_cadastro.Controls.Add(Me.btn_professor_anterior)
        Me.grb_cadastro.Controls.Add(Me.Button1)
        Me.grb_cadastro.Controls.Add(Me.btn_professor_ultimo)
        Me.grb_cadastro.Controls.Add(Me.btn_professor_primeiro)
        Me.grb_cadastro.Controls.Add(Me.lbl_camposobrigatorios)
        Me.grb_cadastro.Enabled = False
        Me.grb_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_cadastro.ForeColor = System.Drawing.Color.Black
        Me.grb_cadastro.Location = New System.Drawing.Point(6, 71)
        Me.grb_cadastro.Name = "grb_cadastro"
        Me.grb_cadastro.Size = New System.Drawing.Size(321, 310)
        Me.grb_cadastro.TabIndex = 63
        Me.grb_cadastro.TabStop = False
        Me.grb_cadastro.Text = "Cadastrar Curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Período do Curso*:"
        '
        'chk_noite
        '
        Me.chk_noite.AutoSize = True
        Me.chk_noite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_noite.Location = New System.Drawing.Point(240, 278)
        Me.chk_noite.Name = "chk_noite"
        Me.chk_noite.Size = New System.Drawing.Size(68, 20)
        Me.chk_noite.TabIndex = 9
        Me.chk_noite.Text = " Noite"
        Me.chk_noite.UseVisualStyleBackColor = True
        '
        'chk_tarde
        '
        Me.chk_tarde.AutoSize = True
        Me.chk_tarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_tarde.Location = New System.Drawing.Point(125, 278)
        Me.chk_tarde.Name = "chk_tarde"
        Me.chk_tarde.Size = New System.Drawing.Size(73, 20)
        Me.chk_tarde.TabIndex = 8
        Me.chk_tarde.Text = " Tarde"
        Me.chk_tarde.UseVisualStyleBackColor = False
        '
        'chk_manha
        '
        Me.chk_manha.AutoSize = True
        Me.chk_manha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_manha.Location = New System.Drawing.Point(11, 278)
        Me.chk_manha.Name = "chk_manha"
        Me.chk_manha.Size = New System.Drawing.Size(77, 20)
        Me.chk_manha.TabIndex = 7
        Me.chk_manha.Text = " Manhã"
        Me.chk_manha.UseVisualStyleBackColor = True
        '
        'lbl_modulo
        '
        Me.lbl_modulo.AutoSize = True
        Me.lbl_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modulo.Location = New System.Drawing.Point(2, 102)
        Me.lbl_modulo.Name = "lbl_modulo"
        Me.lbl_modulo.Size = New System.Drawing.Size(223, 16)
        Me.lbl_modulo.TabIndex = 68
        Me.lbl_modulo.Text = "Quantidade de Módulos/Anos*:"
        '
        'txt_qtde_modulo
        '
        Me.txt_qtde_modulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde_modulo.Location = New System.Drawing.Point(240, 99)
        Me.txt_qtde_modulo.Name = "txt_qtde_modulo"
        Me.txt_qtde_modulo.Size = New System.Drawing.Size(75, 22)
        Me.txt_qtde_modulo.TabIndex = 2
        Me.txt_qtde_modulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grb_tipo
        '
        Me.grb_tipo.Controls.Add(Me.rdb_semestral)
        Me.grb_tipo.Controls.Add(Me.rdb_anual)
        Me.grb_tipo.ForeColor = System.Drawing.Color.Black
        Me.grb_tipo.Location = New System.Drawing.Point(6, 177)
        Me.grb_tipo.Name = "grb_tipo"
        Me.grb_tipo.Size = New System.Drawing.Size(309, 51)
        Me.grb_tipo.TabIndex = 4
        Me.grb_tipo.TabStop = False
        Me.grb_tipo.Text = "Tipo do Curso*"
        '
        'rdb_semestral
        '
        Me.rdb_semestral.AutoSize = True
        Me.rdb_semestral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_semestral.Location = New System.Drawing.Point(154, 18)
        Me.rdb_semestral.Name = "rdb_semestral"
        Me.rdb_semestral.Size = New System.Drawing.Size(96, 20)
        Me.rdb_semestral.TabIndex = 6
        Me.rdb_semestral.TabStop = True
        Me.rdb_semestral.Text = "Semestral"
        Me.rdb_semestral.UseVisualStyleBackColor = True
        '
        'rdb_anual
        '
        Me.rdb_anual.AutoSize = True
        Me.rdb_anual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_anual.Location = New System.Drawing.Point(61, 19)
        Me.rdb_anual.Name = "rdb_anual"
        Me.rdb_anual.Size = New System.Drawing.Size(65, 20)
        Me.rdb_anual.TabIndex = 5
        Me.rdb_anual.TabStop = True
        Me.rdb_anual.Text = "Anual"
        Me.rdb_anual.UseVisualStyleBackColor = True
        '
        'lbl_qtaula
        '
        Me.lbl_qtaula.AutoSize = True
        Me.lbl_qtaula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qtaula.Location = New System.Drawing.Point(2, 144)
        Me.lbl_qtaula.Name = "lbl_qtaula"
        Me.lbl_qtaula.Size = New System.Drawing.Size(205, 16)
        Me.lbl_qtaula.TabIndex = 65
        Me.lbl_qtaula.Text = "Qtde. de aulas por semana*:"
        '
        'txt_qtde_aulas_sem
        '
        Me.txt_qtde_aulas_sem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde_aulas_sem.Location = New System.Drawing.Point(240, 141)
        Me.txt_qtde_aulas_sem.Name = "txt_qtde_aulas_sem"
        Me.txt_qtde_aulas_sem.Size = New System.Drawing.Size(75, 22)
        Me.txt_qtde_aulas_sem.TabIndex = 3
        Me.txt_qtde_aulas_sem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_abrevi
        '
        Me.lbl_abrevi.AutoSize = True
        Me.lbl_abrevi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_abrevi.Location = New System.Drawing.Point(2, 61)
        Me.lbl_abrevi.Name = "lbl_abrevi"
        Me.lbl_abrevi.Size = New System.Drawing.Size(58, 16)
        Me.lbl_abrevi.TabIndex = 63
        Me.lbl_abrevi.Text = "Sigla* :"
        '
        'txt_sigla_curso
        '
        Me.txt_sigla_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sigla_curso.Location = New System.Drawing.Point(184, 58)
        Me.txt_sigla_curso.MaxLength = 10
        Me.txt_sigla_curso.Name = "txt_sigla_curso"
        Me.txt_sigla_curso.Size = New System.Drawing.Size(131, 22)
        Me.txt_sigla_curso.TabIndex = 1
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curso.Location = New System.Drawing.Point(2, 21)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(62, 16)
        Me.lbl_curso.TabIndex = 61
        Me.lbl_curso.Text = "Curso* :"
        '
        'txt_curso
        '
        Me.txt_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_curso.Location = New System.Drawing.Point(88, 16)
        Me.txt_curso.Name = "txt_curso"
        Me.txt_curso.Size = New System.Drawing.Size(227, 22)
        Me.txt_curso.TabIndex = 0
        '
        'btn_professor_proximo
        '
        Me.btn_professor_proximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_professor_proximo.Enabled = False
        Me.btn_professor_proximo.FlatAppearance.BorderSize = 0
        Me.btn_professor_proximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_professor_proximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_professor_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professor_proximo.Location = New System.Drawing.Point(259, 478)
        Me.btn_professor_proximo.Name = "btn_professor_proximo"
        Me.btn_professor_proximo.Size = New System.Drawing.Size(60, 47)
        Me.btn_professor_proximo.TabIndex = 55
        Me.btn_professor_proximo.UseVisualStyleBackColor = True
        '
        'btn_professor_anterior
        '
        Me.btn_professor_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_professor_anterior.Enabled = False
        Me.btn_professor_anterior.FlatAppearance.BorderSize = 0
        Me.btn_professor_anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_professor_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_professor_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professor_anterior.Location = New System.Drawing.Point(78, 478)
        Me.btn_professor_anterior.Name = "btn_professor_anterior"
        Me.btn_professor_anterior.Size = New System.Drawing.Size(60, 47)
        Me.btn_professor_anterior.TabIndex = 54
        Me.btn_professor_anterior.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(169, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 47)
        Me.Button1.TabIndex = 53
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_professor_ultimo
        '
        Me.btn_professor_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_professor_ultimo.Enabled = False
        Me.btn_professor_ultimo.FlatAppearance.BorderSize = 0
        Me.btn_professor_ultimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_professor_ultimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_professor_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professor_ultimo.Location = New System.Drawing.Point(338, 478)
        Me.btn_professor_ultimo.Name = "btn_professor_ultimo"
        Me.btn_professor_ultimo.Size = New System.Drawing.Size(60, 47)
        Me.btn_professor_ultimo.TabIndex = 52
        Me.btn_professor_ultimo.UseVisualStyleBackColor = True
        '
        'btn_professor_primeiro
        '
        Me.btn_professor_primeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_professor_primeiro.Enabled = False
        Me.btn_professor_primeiro.FlatAppearance.BorderSize = 0
        Me.btn_professor_primeiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_professor_primeiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_professor_primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professor_primeiro.Location = New System.Drawing.Point(4, 478)
        Me.btn_professor_primeiro.Name = "btn_professor_primeiro"
        Me.btn_professor_primeiro.Size = New System.Drawing.Size(60, 47)
        Me.btn_professor_primeiro.TabIndex = 51
        Me.btn_professor_primeiro.UseVisualStyleBackColor = True
        '
        'lbl_camposobrigatorios
        '
        Me.lbl_camposobrigatorios.AutoSize = True
        Me.lbl_camposobrigatorios.Location = New System.Drawing.Point(258, 462)
        Me.lbl_camposobrigatorios.Name = "lbl_camposobrigatorios"
        Me.lbl_camposobrigatorios.Size = New System.Drawing.Size(140, 13)
        Me.lbl_camposobrigatorios.TabIndex = 34
        Me.lbl_camposobrigatorios.Text = "(*) Campos Obrigatórios"
        '
        'Curso
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(620, 388)
        Me.Controls.Add(Me.grb_cadastro)
        Me.Controls.Add(Me.grb_consulta)
        Me.Controls.Add(Me.mnu_sup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curso                                "
        Me.mnu_sup.ResumeLayout(False)
        Me.mnu_sup.PerformLayout()
        Me.grb_consulta.ResumeLayout(False)
        Me.grb_consulta.PerformLayout()
        Me.grb_cadastro.ResumeLayout(False)
        Me.grb_cadastro.PerformLayout()
        Me.grb_tipo.ResumeLayout(False)
        Me.grb_tipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_alterar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_consulta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_excluir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_sup As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_limpar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grb_consulta As System.Windows.Forms.GroupBox
    Friend WithEvents lst_consulta_curso As System.Windows.Forms.ListBox
    Friend WithEvents rdbperiodo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbnomecurso As System.Windows.Forms.RadioButton
    Friend WithEvents txt_pesquisa As System.Windows.Forms.TextBox
    Friend WithEvents grb_cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_modulo As System.Windows.Forms.Label
    Friend WithEvents txt_qtde_modulo As System.Windows.Forms.TextBox
    Friend WithEvents grb_tipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_semestral As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_anual As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_qtaula As System.Windows.Forms.Label
    Friend WithEvents txt_qtde_aulas_sem As System.Windows.Forms.TextBox
    Friend WithEvents lbl_abrevi As System.Windows.Forms.Label
    Friend WithEvents txt_sigla_curso As System.Windows.Forms.TextBox
    Friend WithEvents lbl_curso As System.Windows.Forms.Label
    Friend WithEvents txt_curso As System.Windows.Forms.TextBox
    Friend WithEvents btn_professor_proximo As System.Windows.Forms.Button
    Friend WithEvents btn_professor_anterior As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_professor_ultimo As System.Windows.Forms.Button
    Friend WithEvents btn_professor_primeiro As System.Windows.Forms.Button
    Friend WithEvents lbl_camposobrigatorios As System.Windows.Forms.Label
    Friend WithEvents mnu_novo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_noite As System.Windows.Forms.CheckBox
    Friend WithEvents chk_tarde As System.Windows.Forms.CheckBox
    Friend WithEvents chk_manha As System.Windows.Forms.CheckBox
    Friend WithEvents mnu_salvar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk_pesq_noite As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pesq_tarde As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pesq_manha As System.Windows.Forms.CheckBox
End Class
