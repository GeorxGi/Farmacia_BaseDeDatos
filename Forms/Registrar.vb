Imports Org.BouncyCastle.Cmp

Public Class Registrar
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    Private showPass As Boolean = False
    Private Sub Registrar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
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
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPass)
        Label6.Visible = True
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPass)
        Label6.Visible = False
    End Sub

    Private Sub confirmPasswordTextBox_Enter(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Enter
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPass)
        Label6.Visible = True
    End Sub

    Private Sub confirmPasswordTextBox_Leave(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Leave
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPass)
        Label6.Visible = False
    End Sub

    Private Sub Registrar_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub showPasswordButton_Click(sender As Object, e As EventArgs) Handles showPasswordButton.Click
        IntHand.ShowPassword(showPass, confirmPasswordTextBox, showPasswordButton)
        showPass = IntHand.ShowPassword(showPass, passwordTextBox, showPasswordButton)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        'No hace falta hacer un metodo para esto si solo lo vamos a llamar una vez digo yo...
        If (LogHand.Register(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, fullnameTextBox.Text)) Then
            usernameTextBox.Text = "Usuario  "
            fullnameTextBox.Text = "Nombre completo"
            passwordTextBox.Text = "Contraseña  "
            confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        End If
    End Sub

    Private Sub loginIconButton_Click(sender As Object, e As EventArgs) Handles loginIconButton.Click
        'No hace falta hacer un metodo para esto si solo lo vamos a llamar una vez digo yo...
        If (LogHand.Register(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, fullnameTextBox.Text)) Then
            usernameTextBox.Text = "Usuario  "
            fullnameTextBox.Text = "Nombre completo"
            passwordTextBox.Text = "Contraseña  "
            confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class