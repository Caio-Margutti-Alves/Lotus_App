Module validacoes
    '---------------Valida Email----------'
    Public Function valida_email(ByVal texto As TextBox)
        Dim Expression As New System.Text.RegularExpressions.Regex("\S+@\S+\.\S+")
        If Expression.IsMatch(texto.Text) Then
            Return True
        Else
            MessageBox.Show("O e-mail fornecido não é válido!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            texto.Focus()
            Return False
        End If
    End Function
    '--------------- DATA -------------'
    Public Sub valida_ano(ByVal texto As TextBox)
        If Integer.Parse(texto.Text) < 1900 Then
            MessageBox.Show("O Ano deve ser maior que 1900", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            texto.Clear()
        End If
    End Sub

    Public Function valida_data(ByVal texto As MaskedTextBox)
        Dim data As DateTime
        If (DateTime.TryParse(texto.Text, data)) Then
            If data > "01/01/1900" Then
                Return True
            Else
                MessageBox.Show("A Data deve ser maior que 01/01/1900", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Else
            MessageBox.Show("A Data não é Válida!!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
    '---------------Periodo--------------'
    Public Function verifica_periodo_tempo(ByVal texto1 As MaskedTextBox, ByVal texto2 As MaskedTextBox)
        Dim data1 As Date = texto1.Text
        Dim data2 As Date = texto2.Text
        If data1 > data2 Or data1 = data2 Then
            MessageBox.Show("A data de Término deve ser maior que a de Início!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

End Module
