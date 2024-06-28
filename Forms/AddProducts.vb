Public Class AddProducts
    Private dataHand As New DataHandler
    Private IntHand As New InterfaceHandler

    Private Sub registrar()
        If dataHand.RegisterProduct(nameTextBox.Text, labTextBox.Text, presentTextBox.Text + presentComboBox.Text, quantityTextBox.Text, priceTextBox.Text) Then
            nameTextBox.Text = "Nombre  "
            nameTextBox.ForeColor = Color.Gray
            labTextBox.Text = "Laboratorio  "
            labTextBox.ForeColor = Color.Gray
            presentTextBox.Text = ""
            presentComboBox.SelectedIndex = 0
            quantityTextBox.Text = ""
            priceTextBox.Text = ""
        End If
    End Sub
    Private Sub AddProducts_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        presentComboBox.SelectedIndex = 0
    End Sub

    Private Sub AddProducts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        IntHand.PlaceHolder(nameTextBox, "Nombre  ")
    End Sub

    Private Sub nameTextBox_Leave(sender As Object, e As EventArgs) Handles nameTextBox.Leave
        IntHand.PlaceHolder(nameTextBox, "Nombre  ")
    End Sub

    Private Sub labTextBox_Enter(sender As Object, e As EventArgs) Handles labTextBox.Enter
        IntHand.PlaceHolder(labTextBox, "Laboratorio  ")
    End Sub

    Private Sub labTextBox_Leave(sender As Object, e As EventArgs) Handles labTextBox.Leave
        IntHand.PlaceHolder(labTextBox, "Laboratorio  ")
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        registrar()
    End Sub

    Private Sub addIconButton_Click(sender As Object, e As EventArgs) Handles addIconButton.Click
        registrar()
    End Sub

    Private Sub quantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub

    Private Sub priceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles priceTextBox.KeyPress
        IntHand.OnlyDecNumbers(e)
    End Sub

    Private Sub presentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles presentTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub
#Region "Close buttons"
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub
#End Region
End Class