Imports System.Runtime.InteropServices

Public Class WebCam
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblDevice As System.Windows.Forms.Label
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Friend WithEvents lst_Dispositivos As System.Windows.Forms.ListBox
    Friend WithEvents pic_captura As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebCam))
        Me.lblDevice = New System.Windows.Forms.Label
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnParar = New System.Windows.Forms.Button
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog
        Me.lst_Dispositivos = New System.Windows.Forms.ListBox
        Me.pic_captura = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.pic_captura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDevice
        '
        Me.lblDevice.BackColor = System.Drawing.Color.Transparent
        Me.lblDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevice.Location = New System.Drawing.Point(48, 34)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(193, 18)
        Me.lblDevice.TabIndex = 2
        Me.lblDevice.Text = "Dispositivos Encontrados:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIniciar
        '
        Me.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIniciar.BackColor = System.Drawing.Color.Transparent
        Me.btnIniciar.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources._1307073583_media_play
        Me.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIniciar.FlatAppearance.BorderSize = 0
        Me.btnIniciar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Location = New System.Drawing.Point(139, 363)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(90, 90)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources._1307073561_photo
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(439, 363)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(90, 90)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnParar
        '
        Me.btnParar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnParar.BackColor = System.Drawing.Color.Transparent
        Me.btnParar.BackgroundImage = Global.Lótus_1._0.My.Resources.Resources._1307073578_media_stop
        Me.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParar.FlatAppearance.BorderSize = 0
        Me.btnParar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnParar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnParar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParar.Location = New System.Drawing.Point(284, 363)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(90, 90)
        Me.btnParar.TabIndex = 5
        Me.btnParar.UseVisualStyleBackColor = False
        '
        'sfdImage
        '
        Me.sfdImage.FileName = "Webcam1"
        Me.sfdImage.Filter = "Bitmap|*.bmp"
        '
        'lst_Dispositivos
        '
        Me.lst_Dispositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Dispositivos.FormattingEnabled = True
        Me.lst_Dispositivos.HorizontalScrollbar = True
        Me.lst_Dispositivos.ItemHeight = 16
        Me.lst_Dispositivos.Location = New System.Drawing.Point(17, 55)
        Me.lst_Dispositivos.Name = "lst_Dispositivos"
        Me.lst_Dispositivos.Size = New System.Drawing.Size(246, 308)
        Me.lst_Dispositivos.TabIndex = 6
        '
        'pic_captura
        '
        Me.pic_captura.BackColor = System.Drawing.Color.Transparent
        Me.pic_captura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_captura.Location = New System.Drawing.Point(269, 55)
        Me.pic_captura.Name = "pic_captura"
        Me.pic_captura.Size = New System.Drawing.Size(391, 308)
        Me.pic_captura.TabIndex = 7
        Me.pic_captura.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "WebCam"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WebCam
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(676, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_captura)
        Me.Controls.Add(Me.lst_Dispositivos)
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblDevice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WebCam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebCam"
        CType(Me.pic_captura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0
    Dim hHwnd As Integer

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean


    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        carregar_fundo_form(Me)

        carregaDispositivos()

        If lst_Dispositivos.Items.Count > 0 Then
            btnIniciar.Enabled = True
            lst_Dispositivos.SelectedIndex = 0
            btnIniciar.Enabled = True
        Else
            lst_Dispositivos.Items.Add("Não há dispositivo de captura instalado.")
            btnIniciar.Enabled = False
        End If

        btnParar.Enabled = False
        btnSalvar.Enabled = False
        pic_captura.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub carregaDispositivos()
        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0

        Do
         
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)

            If bRetorna Then lst_Dispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub

    Private Sub abreJanelaVisualizacao()
        Dim iHeight As Integer = pic_Captura.Height
        Dim iWidth As Integer = pic_Captura.Width

        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, pic_Captura.Handle.ToInt32, 0)


        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
     
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pic_Captura.Width, pic_Captura.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)

            btnSalvar.Enabled = True
            btnParar.Enabled = True
            btnIniciar.Enabled = False
        Else
         
            DestroyWindow(hHwnd)
            btnSalvar.Enabled = False
        End If
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        iDevice = lst_Dispositivos.SelectedIndex
        If iDevice <> -1 Then
            abreJanelaVisualizacao()
        Else
            MsgBox("Selecione um dispositivo de video...")
        End If
    End Sub

    Private Sub fechaJanelaVisualizacao()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btnParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParar.Click
        fechaJanelaVisualizacao()
        btnSalvar.Enabled = False
        btnIniciar.Enabled = True
        btnParar.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim dados As IDataObject
        Dim bmap As Image

        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        dados = Clipboard.GetDataObject()

        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            pic_captura.Image = bmap
            fechaJanelaVisualizacao()
            btnSalvar.Enabled = False
            btnParar.Enabled = False
            btnIniciar.Enabled = True

            sfdImage.InitialDirectory = (caminho_formulario_usado)
            If sfdImage.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
                If formulario_usado = "Professor" Then
                    define_imagem_formulario(Professor.ptb_foto, bmap)
                ElseIf formulario_usado = "Aluno" Then
                    define_imagem_formulario(Aluno.ptb_foto, bmap)
                End If
            End If

        End If

        Me.Close()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If btnParar.Enabled Then
            fechaJanelaVisualizacao()
        End If
    End Sub
    Private Sub define_imagem_formulario(ByVal picture As PictureBox, ByVal imagem As Bitmap)
        picture.BackgroundImage = imagem
    End Sub
End Class
