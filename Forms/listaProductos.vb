Public Class listaProductos
    Private IntHand As New InterfaceHandler
    Private datahand As New DataHandler
#Region "form startup"
    Private Sub listaProductos_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub
    Private Sub listaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        DataGridView1.DataSource = datahand.ListOfProducts("")
    End Sub
    Private Sub listaProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Me.Close()
    End Sub
    Private Sub loginIconButton_Click(sender As Object, e As EventArgs) Handles loginIconButton.Click
        Me.Close()
    End Sub
#End Region
    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        DataGridView1.DataSource = datahand.ListOfProducts(nameTextBox.Text)
    End Sub
End Class