Public Class VentaProducto
    Private IntHand As New InterfaceHandler
    Private Datahand As New DataHandler
    Private Client As New List(Of Object)

    Private Sub add()
        'DataGridView2.DataSource = DataGridView1.CurrentRow
        DataGridView2.Rows.Add(DataGridView1.CurrentRow)
        'MsgBox("hey")
    End Sub
    Private Sub VentaProducto_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub VentaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Datahand.ListOfProducts("")
        cedComboBox.SelectedIndex = 0
        Aplicacion.Enabled = False
    End Sub

    Private Sub VentaProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Client = Datahand.SearchClient(cedComboBox.Text + idTextBox.Text)
        If Client IsNot Nothing Then
            clientnameLabel.Text = Client(1)
            clientLocLabel.Text = Client(3)
        Else
            MsgBox("Cliente no encontrado", MsgBoxStyle.Information, "Informacion")
        End If
    End Sub

    Private Sub addIconButton_Click(sender As Object, e As EventArgs) Handles addIconButton.Click
        add()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        add()
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        DataGridView1.DataSource = Datahand.ListOfProducts(nameTextBox.Text)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub
End Class