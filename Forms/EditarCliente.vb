Public Class EditarCliente
    Dim Clientes = Nothing
    Private IntHand As New InterfaceHandler
    Private dataHandler As New DataHandler

    Private Sub edit()
        If (Clientes IsNot Nothing) Then
            Dim name As String = Clientes(1)
            Dim phone As String = Clientes(4)
            Dim loc As String = Clientes(3)

            If (Not nameTextBox.Text = "") Then
                name = nameTextBox.Text
            End If

            If (Not phoneTextBox.Text = "") Then
                phone = phoneTextBox.Text
            End If

            If (Not locTextBox.Text = "") Then
                loc = locTextBox.Text
            End If

            If dataHandler.EditClient(Clientes(0), name, Clientes(2), loc, phone) Then
                actual_idLabel.Text = ""
                actual_idLabel.Visible = False
                client_idLabel.Visible = False
                nameLabel.Text = "."
                locLabel.Text = "."
                phone_numberLabel.Text = "."
                nameTextBox.Text = ""
                phoneTextBox.Text = ""
                locTextBox.Text = ""
            End If
        Else
                MsgBox("Ingrese primero los datos", MsgBoxStyle.Information, "Informacion")
            End If
    End Sub
    Private Sub editClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicacion.Enabled = False
        cedComboBox.SelectedIndex = 0
    End Sub

    Private Sub editClient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Aplicacion.Enabled = True
    End Sub

    Private Sub editClient_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        IntHand.Gradient(Me, e)
    End Sub

    Private Sub idTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idTextBox.KeyPress
        IntHand.OnlyNumbers(e)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Clientes = dataHandler.SearchClient(cedComboBox.Text + idTextBox.Text)
        If Clientes IsNot Nothing Then
            actual_idLabel.Text = Clientes(0).ToString
            client_idLabel.Visible = True
            actual_idLabel.Visible = True

            'nameTextBox.Text = Clientes(1)
            nameLabel.Text = Clientes(1)

            'locTextBox.Text = Clientes(3)
            locLabel.Text = Clientes(3)

            'phoneTextBox.Text = Clientes(4)
            phone_numberLabel.Text = Clientes(4)
        Else
            MsgBox("Cliente no encontrado", MsgBoxStyle.Information, "Información")
            nameLabel.Text = "."
            locLabel.Text = "."
            phone_numberLabel.Text = "."
            actual_idLabel.Text = ""
            actual_idLabel.Visible = False
            client_idLabel.Visible = False
        End If
    End Sub

    'No quería crear un método externo para esto, más fácil así
    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        edit()
    End Sub
    Private Sub editIconButton_Click(sender As Object, e As EventArgs) Handles editIconButton.Click
        edit()
    End Sub

#Region "Cancel buttons"
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub cancelIconButton_Click(sender As Object, e As EventArgs) Handles cancelIconButton.Click
        Me.Close()
    End Sub


#End Region
End Class