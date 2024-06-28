Public Class ListaClientes
    Private IntHand As New InterfaceHandler
    Private DataHand As New DataHandler

    Private Sub actualizarLista()
        DataGridView1.DataSource = DataHand.ListOfClients(cedComboBox.Text + idTextBox.Text)
    End Sub

    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        cedComboBox.SelectedIndex = 0
        DataGridView1.DataSource = DataHand.ListOfClients("")
    End Sub

    Private Sub ListaClientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub

    Private Sub ListaClientes_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub idTextBox_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged
        actualizarLista()
    End Sub

    Private Sub cedComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cedComboBox.SelectedIndexChanged
        actualizarLista()
    End Sub

    Private Sub loginIconButton_Click(sender As Object, e As EventArgs) Handles loginIconButton.Click
        Me.Close()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Me.Close()
    End Sub
End Class