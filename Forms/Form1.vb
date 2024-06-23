Imports System.Drawing.Text
Public Class Form1
    'Sinceramente, prefiero manejar backend que frontend
    'la interfaz sencilla, pero las funcionalidades tan pulidas como pueda
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LogHand.Login(usernameTextBox.Text, passwordTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Registrar.Show()
    End Sub

    Private Sub showPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPasswordCheckBox.CheckedChanged
        IntHand.ShowPassword(showPasswordCheckBox.Checked, passwordTextBox)
    End Sub

    Private Sub usernameTextBox_Enter(sender As Object, e As EventArgs) Handles usernameTextBox.Enter
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub usernameTextBox_Leave(sender As Object, e As EventArgs) Handles usernameTextBox.Leave
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub passwordTextBox_Enter(sender As Object, e As EventArgs) Handles passwordTextBox.Enter
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPasswordCheckBox.Checked)
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPasswordCheckBox.Checked)
    End Sub
End Class
