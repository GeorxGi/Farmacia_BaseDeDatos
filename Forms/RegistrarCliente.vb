Public Class RegistrarCliente
    Private IntHand As New InterfaceHandler()
    Private DatHand As New DataHandler()
    Private Sub RegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        cedComboBox.SelectedIndex = 0
    End Sub

    Private Sub RegistrarCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub

    Private Sub RegistrarCliente_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub
#Region "Placeholders"
    Private Sub nameTextBox_Leave(sender As Object, e As EventArgs) Handles nameTextBox.Leave
        IntHand.PlaceHolder(nameTextBox, "Nombre  ")
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        IntHand.PlaceHolder(nameTextBox, "Nombre  ")
    End Sub

    Private Sub numberTextBox_Enter(sender As Object, e As EventArgs) Handles numberTextBox.Enter
        IntHand.PlaceHolder(numberTextBox, "Número de teléfono  ")
        Label6.Visible = True
    End Sub

    Private Sub numberTextBox_Leave(sender As Object, e As EventArgs) Handles numberTextBox.Leave
        IntHand.PlaceHolder(numberTextBox, "Número de teléfono  ")
        Label6.Visible = False
    End Sub

    Private Sub locationTextBox_Enter(sender As Object, e As EventArgs) Handles locationTextBox.Enter
        IntHand.PlaceHolder(locationTextBox, "Ubicación  ")
    End Sub

    Private Sub locationTextBox_Leave(sender As Object, e As EventArgs) Handles locationTextBox.Leave
        IntHand.PlaceHolder(locationTextBox, "Ubicación  ")
    End Sub
#End Region
#Region "Close buttons"
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub
#End Region

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If DatHand.ClientRegister(nameTextBox.Text, cedComboBox.Text + idTextBox.Text, locationTextBox.Text, numberTextBox.Text) Then
            nameTextBox.Text = "Nombre  "
            idTextBox.Text = "Identificación  "
            locationTextBox.Text = "Ubicación  "
            numberTextBox.Text = "Número de teléfono  "
        End If
    End Sub

    Private Sub addIconButton_Click(sender As Object, e As EventArgs) Handles addIconButton.Click
        If DatHand.ClientRegister(nameTextBox.Text, cedComboBox.Text + idTextBox.Text, locationTextBox.Text, numberTextBox.Text) Then
            nameTextBox.Text = "Nombre  "
            idTextBox.Text = "Identificación  "
            locationTextBox.Text = "Ubicación  "
            numberTextBox.Text = "Número de teléfono  "
        End If
    End Sub

    Private Sub numberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub

    Private Sub idTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub
End Class