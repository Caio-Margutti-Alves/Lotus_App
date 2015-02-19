Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Word

Public Class frm_interface

    Private Sub frm_interface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_fundo_e_tema()
        restricões_usuario()
        lbl_usuario.Text = "Usuário: " & nm_usuario_db
        lbl_tipo.Text = "Tipo: " & tipo_usuario_db
    End Sub

    Private Sub frm_interface_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        desconectar_usuario()
    End Sub

    Private Sub Relogio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relogio.Tick
        lbl_hora.Text = "Hora: " & (Hour(Now) & ":" & Minute(Now) & ":" & Second(Now))
    End Sub

    Private Sub DispensaDeAulasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispensaDeAulasToolStripMenuItem1.Click
        Dispensa_Aulas.MdiParent = Me
        Dispensa_Aulas.Show()
    End Sub

    Private Sub mnu_cadastrar_unidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cadastrar_sede.Click
        Unidade_Escolar.MdiParent = Me
        Unidade_Escolar.Show()
    End Sub

    Private Sub mnu_cadastrar_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_cadastrar_curso.Click
        Curso.MdiParent = Me
        Curso.Show()
    End Sub

    Private Sub CadastroProfessorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroProfessorToolStripMenuItem.Click
        Professor.MdiParent = Me
        Professor.Show()
    End Sub

    Private Sub DisciplinasMinistradasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisciplinasMinistradasToolStripMenuItem1.Click
        Disciplinas_ministradas.MdiParent = Me
        Disciplinas_ministradas.Show()
    End Sub

    Private Sub CadastroDisciplinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDisciplinaToolStripMenuItem.Click
        Disciplina.MdiParent = Me
        Disciplina.Show()
    End Sub

    Private Sub RelacionamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionamentoToolStripMenuItem.Click
        Relacionamento_Disciplina_Curso.MdiParent = Me
        Relacionamento_Disciplina_Curso.Show()
    End Sub

    Private Sub CadastroTurmaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroTurmaToolStripMenuItem.Click
        Turma.MdiParent = Me
        Turma.Show()
    End Sub

    Private Sub CadastrarAlunosNaTurmaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarAlunosNaTurmaToolStripMenuItem.Click
        Aluno_Turma.MdiParent = Me
        Aluno_Turma.Show()

    End Sub

    Private Sub CadastrarAlunoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarAlunoToolStripMenuItem.Click
        Aluno.MdiParent = Me
        Aluno.Show()
    End Sub

    Private Sub EventosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventosToolStripMenuItem.Click
        Cadastro_Eventos.MdiParent = Me
        Cadastro_Eventos.Show()
    End Sub

    '--------------Presença----------------'
    '--------------Turma------------------'
    Private Sub ChamadaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChamadaToolStripMenuItem1.Click
        Chamada_Aluno.MdiParent = Me
        Chamada_Aluno.Show()
    End Sub
    '--------------Professor----------------'
    Private Sub AdicionalNoturnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionalNoturnoToolStripMenuItem.Click
        Adicional_Noturno.MdiParent = Me
        Adicional_Noturno.Show()
    End Sub

    Private Sub RegistrarFaltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarFaltaToolStripMenuItem.Click
        Faltas_Professor.MdiParent = Me
        Faltas_Professor.Show()
    End Sub

    '---------------Documentação---------'
    Private Sub ProfessorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessorToolStripMenuItem.Click
        Relatorios_Professor.MdiParent = Me
        Relatorios_Professor.Show()
    End Sub
    '-------------Configurações--------'
    Private Sub mnu_configuracoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_configuracoes.Click
        configuracoes.MdiParent = Me
        configuracoes.Show()
    End Sub
    '---------------Ajuda-------------'
    Private Sub mnu_ajuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ajuda.Click
        Process.Start(caminho_manual & "manual_novo.pdf")
    End Sub
    '--------------Sistema-----------'
    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoffToolStripMenuItem.Click
        logoff()
    End Sub

    Private Sub EncerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncerrarToolStripMenuItem.Click
        sair()
    End Sub

    Private Sub mnu_gerenciamento_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_gerenciamento.MouseMove
        mnu_gerenciamento.Image = My.Resources.lapis1_icone
        mnu_gerenciamento.ImageScaling = ToolStripItemImageScaling.None
        mnu_gerenciamento.Text = ""
    End Sub

    Private Sub mnu_gerenciamento_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_gerenciamento.MouseLeave
        mnu_gerenciamento.Image = My.Resources.lapis1
        mnu_gerenciamento.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_gerenciamento.Text = "Gerenciamento"
    End Sub

    Private Sub mnu_presenca_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_presenca.MouseMove
        mnu_presenca.Image = My.Resources.lapis3_icone
        mnu_presenca.ImageScaling = ToolStripItemImageScaling.None
        mnu_presenca.Text = ""
    End Sub

    Private Sub mnu_presenca_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_presenca.MouseLeave
        mnu_presenca.Image = My.Resources.lapis3
        mnu_presenca.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_presenca.Text = "Presença"
    End Sub

    Private Sub mnu_configuracoes_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_configuracoes.MouseMove
        mnu_configuracoes.Image = My.Resources.lapis5_icone
        mnu_configuracoes.ImageScaling = ToolStripItemImageScaling.None
        mnu_configuracoes.Text = ""
    End Sub

    Private Sub mnu_configuracoes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_configuracoes.MouseLeave
        mnu_configuracoes.Image = My.Resources.lapis5
        mnu_configuracoes.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_configuracoes.Text = "Configurações"

    End Sub

    Private Sub mnu_sistema_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_sistema.MouseMove
        mnu_sistema.Image = My.Resources.lapis7_icone
        mnu_sistema.ImageScaling = ToolStripItemImageScaling.None
        mnu_sistema.Text = ""

    End Sub

    Private Sub mnu_sistema_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_sistema.MouseLeave
        mnu_sistema.Image = My.Resources.lapis7
        mnu_sistema.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_sistema.Text = "Sistema"
    End Sub

    Private Sub mnu_documentacao_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_documentacao.MouseMove
        mnu_documentacao.Image = My.Resources.lapis4_icone
        mnu_documentacao.ImageScaling = ToolStripItemImageScaling.None
        mnu_documentacao.Text = ""
    End Sub

    Private Sub mnu_documentacao_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_documentacao.MouseLeave
        mnu_documentacao.Image = My.Resources.lapis4
        mnu_documentacao.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_documentacao.Text = "Documentação"

    End Sub

    Private Sub mnu_usuario_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_usuario.MouseMove
        mnu_usuario.Image = My.Resources.lapis2_icone
        mnu_usuario.ImageScaling = ToolStripItemImageScaling.None
        mnu_usuario.Text = ""

    End Sub

    Private Sub mnu_usuario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_usuario.MouseLeave
        mnu_usuario.Image = My.Resources.lapis2
        mnu_usuario.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_usuario.Text = "Usuário"
    End Sub

    Private Sub mnu_ajuda_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_ajuda.MouseMove
        mnu_ajuda.Image = My.Resources.lapis6_icone
        mnu_ajuda.ImageScaling = ToolStripItemImageScaling.None
        mnu_ajuda.Text = ""
    End Sub

    Private Sub mnu_ajuda_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_ajuda.MouseLeave
        mnu_ajuda.Image = My.Resources.lapis6
        mnu_ajuda.ImageScaling = ToolStripItemImageScaling.SizeToFit
        mnu_ajuda.Text = "Ajuda"

    End Sub

    Private Sub mnu_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_usuario.Click
        usuario.MdiParent = Me
        usuario.Show()
    End Sub

    Private Sub ad_lembrete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim post As New Controles.PostIt(cd_usuario, New Point(675, 300), False)
        'Me.Controls.Add(post)
    End Sub

    Private Sub carregar_fundo_e_tema()

        Try
            Me.BackgroundImage = Image.FromFile(papel_parede)
        Catch ex1 As Exception
            Try
                Me.BackgroundImage = Image.FromFile(caminho_papel_parede & papel_parede)
            Catch ex2 As Exception
                MessageBox.Show("Não foi possível localizar o seu papel de parede pois o mesmo não se encontra nesta máquina", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.BackgroundImage = My.Resources.fundo_padrao
                papel_parede_padrao()
            End Try
        End Try

        Try
            pnl_cor.BackColor = Color.FromArgb(cor_tema)
            pnl_usuario.BackColor = Color.FromArgb(cor_tema)
        Catch ex As Exception
            MessageBox.Show("Não foi possível carregar a cor do tema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pnl_cor.BackColor = Color.FromArgb(-15420550)
            pnl_usuario.BackColor = Color.FromArgb(-15420550)
            cor_tema_padrao()
        End Try

    End Sub

    Private Sub AlunosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlunosToolStripMenuItem.Click
        Relatorios_Aluno.MdiParent = Me
        Relatorios_Aluno.Show()
    End Sub

    Private Sub MontarHorárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MontarHorárioToolStripMenuItem.Click
        Horario_Aulas.MdiParent = Me
        Horario_Aulas.Show()
    End Sub
End Class