﻿Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Public Class Form1
    'Sinceramente, prefiero manejar backend que frontend
    'la interfaz sencilla, pero las funcionalidades tan pulidas como pueda

    'Al final si le meti diseño como quienes dicen

    'https://icons8.com/icon/set/user-interface/ios-filled
    Private LogHand As New LoginHandler
    Private IntHand As New InterfaceHandler
    Private showPass As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        LogHand.Login(usernameTextBox.Text, passwordTextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        Me.Hide()
        Registrar.Show()
    End Sub

    Private Sub usernameTextBox_Enter(sender As Object, e As EventArgs) Handles usernameTextBox.Enter
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub usernameTextBox_Leave(sender As Object, e As EventArgs) Handles usernameTextBox.Leave
        IntHand.PlaceHolder(usernameTextBox, "Usuario  ")
    End Sub

    Private Sub passwordTextBox_Enter(sender As Object, e As EventArgs) Handles passwordTextBox.Enter
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPass)
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        IntHand.PassPlaceHolder(passwordTextBox, "Contraseña  ", showPass)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles showPasswordButton.Click
        showPass = IntHand.ShowPassword(showPass, passwordTextBox, showPasswordButton)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles loginIconButton.Click
        LogHand.Login(usernameTextBox.Text, passwordTextBox.Text)
    End Sub

    Private Sub registerIconButton_Click(sender As Object, e As EventArgs) Handles registerIconButton.Click
        Me.Hide()
        Registrar.Show()
    End Sub
End Class
