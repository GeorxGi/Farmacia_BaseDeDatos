Imports System.Drawing.Text
Public Class Form1
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    'https://coolors.co/3c493f-7e8d85-b3bfb8-f0f7f4-a2e3c4
    'Un detalle del programa es que quise añadir los placeholders en los textboxs, y aunque pude
    'Tienen un detalle, si el usuario escribe la misma palabra del placeholder
    'Medio que se alborotan los textboxs... Pero yo tengo fe en que el usuario no escribirá "usuario" como su usuario... espero
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
