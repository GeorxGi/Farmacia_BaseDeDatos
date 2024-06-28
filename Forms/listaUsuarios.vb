Public Class listaUsuarios
    Private dataHandler As New DataHandler
    Private IntHand As New InterfaceHandler
    Private Sub listaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = dataHandler.ListOfUsers()
        Aplicacion.Enabled = False
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Me.Close()
    End Sub

    Private Sub loginIconButton_Click(sender As Object, e As EventArgs) Handles loginIconButton.Click
        Me.Close()
    End Sub

    Private Sub listaUsuarios_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub listaUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub
End Class