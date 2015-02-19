Imports System.Text.RegularExpressions
Module bloqueios
    '------------------------------------------'

    '--------- TEXTBOX--------'
    Public Sub negar_num(ByVal texto As TextBox)
        If Not IsNumeric(texto.Text) Or texto.Text = "" Then
        Else
            texto.Clear()
            MessageBox.Show("Caracter Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Function valor_monetario(ByVal Keyascii As Short) As Short
        If InStr("1234567890,", Chr(Keyascii)) = 0 Then
            valor_monetario = 0
        Else
            valor_monetario = Keyascii
        End If
        Select Case Keyascii
            Case 8
                valor_monetario = Keyascii
            Case 13
                valor_monetario = Keyascii
            Case 32
                valor_monetario = Keyascii
        End Select
    End Function

    Public Sub negar_car(ByVal numero As TextBox)
        Dim regex As New Regex(",\d\d\d")
        If numero.Text = Nothing Then
        ElseIf Not IsNumeric(numero.Text) Or regex.IsMatch(numero.Text) Then
            numero.Clear()
            MessageBox.Show("Digite Somente Números Válidos!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numero.Focus()
        End If
    End Sub
End Module
