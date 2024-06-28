Public Class Registrar
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    Private showPass As Boolean = False
    Public Property PreviousForm As Form

#Region "métodos locales"

    Private Sub register()
        If (LogHand.Register(usernameTextBox.Text, passwordTextBox.Text, confirmPasswordTextBox.Text, fullnameTextBox.Text)) Then
            usernameTextBox.Text = "Usuario  "
            fullnameTextBox.Text = "Nombre completo  "
            passwordTextBox.Text = "Contraseña  "
            confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        End If
    End Sub
    Private Sub checkPassword()
        If (Not passwordTextBox.Text = "Contraseña  ") Then
            If (LogHand.HasMinus(passwordTextBox.Text)) Then
                minusPictureBox.Image = My.Resources.Check
            Else
                minusPictureBox.Image = My.Resources.Uncheck
            End If
            If (LogHand.HasMayus(passwordTextBox.Text)) Then
                mayusPictureBox.Image = My.Resources.Check
            Else
                mayusPictureBox.Image = My.Resources.Uncheck
            End If
            If (LogHand.HasSpecialChar(passwordTextBox.Text)) Then
                specialCharPictureBox.Image = My.Resources.Check
            Else
                specialCharPictureBox.Image = My.Resources.Uncheck
            End If
            If (LogHand.HasNumber(passwordTextBox.Text)) Then
                numberPictureBox.Image = My.Resources.Check
            Else
                numberPictureBox.Image = My.Resources.Uncheck
            End If
        End If
    End Sub
#End Region
    Private Sub Registrar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PreviousForm.Enabled = True
        PreviousForm.Show()
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
        passContainPanel.Visible = True
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPass)
    End Sub

    Private Sub confirmPasswordTextBox_Enter(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Enter
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPass)
    End Sub

    Private Sub confirmPasswordTextBox_Leave(sender As Object, e As EventArgs) Handles confirmPasswordTextBox.Leave
        IntHand.PassPlaceHolder(confirmPasswordTextBox, "Confirmar Contraseña  ", showPass)
    End Sub

    Private Sub Registrar_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub showPasswordButton_Click(sender As Object, e As EventArgs) Handles showPasswordButton.Click
        IntHand.ShowPassword(showPass, confirmPasswordTextBox, showPasswordButton)
        showPass = IntHand.ShowPassword(showPass, passwordTextBox, showPasswordButton)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        register()
    End Sub

    Private Sub addIconButton_Click(sender As Object, e As EventArgs) Handles addIconButton.Click
        register()
    End Sub

    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged
        checkPassword()
    End Sub
    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreviousForm.Enabled = False
    End Sub
End Class