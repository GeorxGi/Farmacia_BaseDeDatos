Imports System.ComponentModel

Public Class EditarProducto
    Private Datahand As New DataHandler
    Private IntHand As New InterfaceHandler
    Private id As String

    Private Sub Editar()
        Dim name As String = ""
        Dim present As String = ""
        Dim lab As String = ""
        If (newNameTextBox.Text = "") Then
            name = DataGridView1.CurrentRow.Cells(1).Value
        Else
            name = newNameTextBox.Text
        End If
        If (presentTextBox.Text = "") Then
            present = DataGridView1.CurrentRow.Cells(3).Value
        Else
            present = presentTextBox.Text + presentComboBox.Text
        End If
        If (newLabTextBox.Text = "") Then
            lab = DataGridView1.CurrentRow.Cells(2).Value
        Else
            lab = newLabTextBox.Text
        End If
        If Datahand.EditProduct(id, name, lab, present) Then
            Me.Close()
        End If
    End Sub

#Region "Loader"
    Private Sub cargarTabla()
        DataGridView1.DataSource = Datahand.ListOfProducts(nameTextBox.Text)
    End Sub
    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        presentComboBox.SelectedIndex = 0
        cargarTabla()
    End Sub

    Private Sub EditarProducto_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub EditarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub
#End Region
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        id = DataGridView1.CurrentRow.Cells(0).Value
        nameLabel.Text = DataGridView1.CurrentRow.Cells(1).Value
        labLabel.Text = DataGridView1.CurrentRow.Cells(2).Value
        presentLabel.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        cargarTabla()
    End Sub

    Private Sub editIconButton_Click(sender As Object, e As EventArgs) Handles editIconButton.Click
        Editar()
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Editar()
    End Sub

    Private Sub presentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles presentTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub
End Class