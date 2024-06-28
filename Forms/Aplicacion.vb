Imports System.Drawing.Imaging

Public Class Aplicacion
    Public Property ActiveUser As String

    Private intHand As New InterfaceHandler
    Private Sub Aplicacion_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        intHand.Gradient(Me, e)
    End Sub

    Private Sub Aplicacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("¿Seguro que desea salir?", MsgBoxStyle.OkCancel, "Salir") = vbOK Then
            e.Cancel = False
            Form1.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgregarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuariosToolStripMenuItem.Click
        Registrar.PreviousForm = Me
        Registrar.Show()
        Registrar.Activate()
    End Sub

    Private Sub Aplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text += ActiveUser
    End Sub

    Private Sub AgregarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductosToolStripMenuItem.Click
        AddProducts.Show()
        AddProducts.Activate()
    End Sub

    Private Sub AgregarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClientesToolStripMenuItem.Click
        RegistrarCliente.Show()
        RegistrarCliente.Activate()
    End Sub

    Private Sub EditarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarClienteToolStripMenuItem.Click
        EditarCliente.Show()
        EditarCliente.Activate()
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        ListaClientes.Show()
        ListaClientes.Activate()
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click
        listaUsuarios.Show()
        listaUsuarios.Activate()
    End Sub

    Private Sub ListaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProductosToolStripMenuItem.Click
        listaProductos.Show()
        listaProductos.Activate()
    End Sub

    Private Sub EditarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarProductoToolStripMenuItem.Click
        EditarProducto.Show()
        EditarProducto.Activate()
    End Sub

    Private Sub VenderProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderProductosToolStripMenuItem.Click
        VentaProducto.Show()
        VentaProducto.Activate()
    End Sub
End Class