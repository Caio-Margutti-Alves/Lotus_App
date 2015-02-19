Public NotInheritable Class Loading
    Dim contador As Integer = 0
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        contador = contador + 1
        Select Case contador
            Case 10
                lbl_loading.Text = "Carregando."
            Case 20
                lbl_loading.Text = "Carregando.."
            Case 30
                lbl_loading.Text = "Carregando..."
            Case 40
                lbl_loading.Text = "Carregando"
            Case 50
                lbl_loading.Text = "Carregando."
            Case 60
                lbl_loading.Text = "Carregando.."
            Case 70
                lbl_loading.Text = "Carregando..."
            Case 80
                lbl_loading.Text = "Carregando"
            Case 90
                lbl_loading.Text = "Carregando."
            Case 100
                frm_Login.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub gif_Loading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
