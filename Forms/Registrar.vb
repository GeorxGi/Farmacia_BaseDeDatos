Imports Org.BouncyCastle.Cmp

Public Class Registrar
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    Private Sub Registrar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub acceptButton_Click(sender As Object, e As EventArgs) Handles acceptButton.Click
        'No hace falta hacer un metodo para esto si solo lo vamos a llamar una vez digo yo...
        If (LogHand.Register(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, fullnameTextBox.Text)) Then
            usernameTextBox.Text = "Usuario  "
            fullnameTextBox.Text = "Nombre completo"
            passwordTextBox.Text = "Contraseña  "
            confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        End If
    End Sub

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub usernameTextBox_Leave(sender As Object, e As EventArgs) Handles usernameTextBox.Leave
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub usernameTextBox_Enter(sender As Object, e As EventArgs) Handles usernameTextBox.Enter
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub fullnameTextBox_Enter(sender As Object, e As EventArgs) Handles fullnameTextBox.Enter
        IntHand.PlaceHolder(fullnameTextBox, "Nombre completo  ")
    End Sub

    Private Sub fullnameTextBox_Leave(sender As Object, e As EventArgs) Handles fullnameTextBox.Leave
        IntHand.PlaceHolder(fullnameTextBox, "Nombre completo  ")
    End Sub

    Private Sub passwordTextBox_Enter(sender As Object, e As EventArgs) Handles passwordTextBox.Enter
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPasswordCheckBox.Checked)
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPasswordCheckBox.Checked)
    End Sub

    Private Sub showPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPasswordCheckBox.CheckedChanged
        IntHand.ShowPassword(showPasswordCheckBox.Checked, passwordTextBox)
        IntHand.ShowPassword(showPasswordCheckBox.Checked, confirmPasswordTextBox)
    End Sub

    Private Sub confirmPasswordTextBox_Enter(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Enter
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPasswordCheckBox.Checked)
    End Sub

    Private Sub confirmPasswordTextBox_Leave(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Leave
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPasswordCheckBox.Checked)
    End Sub
End Class