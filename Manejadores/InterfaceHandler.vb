Imports System.Drawing

Public Class InterfaceHandler

    Dim col1 As Color = Color.FromArgb(35, 181, 118)
    Dim col2 As Color = Color.FromArgb(6, 200, 199)
#Region "Gradientes"
    ''' <summary>
    ''' Gradiente con colores predeterminados
    ''' </summary>
    ''' <param name="item">Elemento al que se le aplicará la gradiente</param>
    ''' <param name="e">Evento de dibujado en pantalla PaintEventArgs</param>
    Public Sub Gradient(item As Control, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim p1 As Point = item.ClientRectangle.Location
        Dim p2 As Point = New Point(item.ClientRectangle.Right, item.ClientRectangle.Bottom)
        Using brsGradient As New Drawing2D.LinearGradientBrush(p1, p2, col1, col2)
            g.FillRectangle(brsGradient, e.ClipRectangle)
        End Using
    End Sub

    ''' <summary>
    ''' Gradiente con colores personalizados
    ''' </summary>
    ''' <param name="item">ELemento al que se le aplicará la gradiente</param>
    ''' <param name="e">Evento de dibujado en pantalla PaintEventArgs</param>
    ''' <param name="color1">Color inicial (izquierda)</param>
    ''' <param name="color2">Color final (derecha)</param>
    Public Sub Gradient(item As Control, e As PaintEventArgs, color1 As Color, color2 As Color)
        Dim g As Graphics = e.Graphics
        Dim p1 As Point = item.ClientRectangle.Location
        Dim p2 As Point = New Point(item.ClientRectangle.Right, item.ClientRectangle.Bottom)
        Using brsGradient As New Drawing2D.LinearGradientBrush(p1, p2, color1, color2)
            g.FillRectangle(brsGradient, e.ClipRectangle)
        End Using
    End Sub
#End Region
#Region "Place Holders"
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
#End Region
    Public Function ShowPassword(show As Boolean, textbox As TextBox, checker As Button) As Boolean
        'Recibe el estado actual de mostrar contraseña, lo inverte y opera en base a ello
        'Y luego retorna el booleano inicial invertido
        show = Not show
        If (show) Then
            textbox.PasswordChar = ""
            checker.BackgroundImage = My.Resources.ShowPassword
        Else
            'Para evitar que cambie el password char de los placeholders
            If (Not textbox.Text = "Contraseña  " And Not textbox.Text = "Confirmar Contraseña  ") Then
                textbox.PasswordChar = "*"
            End If
            checker.BackgroundImage = My.Resources.HidePassword
        End If
        Return show
    End Function

    Public Sub OnlyNumbers(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Sub OnlyDecNumbers(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
