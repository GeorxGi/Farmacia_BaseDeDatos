Public Class InterfaceHandler
    Public Sub PlaceHolder(textBox As TextBox, text As String)
        'Quitar placeholder
        If (textBox.Text = text) Then
            textBox.ForeColor = Color.Black
            textBox.Text = ""
        Else
            'Poner placeholder
            If (textBox.Text = "") Then
                textBox.ForeColor = Color.Gray
                textBox.Text = text
            End If
        End If
    End Sub

    Public Sub PassPlaceHolder(TextBox As TextBox, text As String, showPass As Boolean)
        'Quitar placeholder
        If (TextBox.Text = text) Then
            If (Not showPass) Then
                TextBox.PasswordChar = "*"
            End If
            TextBox.ForeColor = Color.Black
            TextBox.Text = ""
        Else
            'Poner el placeholder
            If (TextBox.Text = "") Then
                TextBox.PasswordChar = ""
                TextBox.ForeColor = Color.Gray
                TextBox.Text = text
            End If
        End If
    End Sub

    Public Sub ShowPassword(show As Boolean, textbox As TextBox)
        'Cambiar el password char del textbox dado por * o no dependiendo del valor del booleano show
        If (show) Then
            textbox.PasswordChar = ""
        Else
            'Para evitar que cambie el password char de los placeholders
            If (Not textbox.Text = "Contraseña  " And Not textbox.Text = "Confirmar Contraseña  ") Then
                textbox.PasswordChar = "*"
            End If
        End If
    End Sub
End Class
