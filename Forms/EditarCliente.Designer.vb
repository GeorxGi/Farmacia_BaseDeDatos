<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.cedComboBox = New System.Windows.Forms.ComboBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.locLabel = New System.Windows.Forms.Label()
        Me.locTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.phone_numberLabel = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.editIconButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.cancelIconButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.client_idLabel = New System.Windows.Forms.Label()
        Me.actual_idLabel = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(250, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 37)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "EDITAR CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(319, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nombre"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.nameTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 71)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.nameLabel)
        Me.Panel2.Location = New System.Drawing.Point(4, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 29)
        Me.Panel2.TabIndex = 34
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nameLabel.Location = New System.Drawing.Point(3, 4)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nameLabel.Size = New System.Drawing.Size(331, 21)
        Me.nameLabel.TabIndex = 33
        Me.nameLabel.Text = "."
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nameTextBox.Location = New System.Drawing.Point(369, 34)
        Me.nameTextBox.MaxLength = 40
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(337, 29)
        Me.nameTextBox.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.searchButton)
        Me.Panel3.Controls.Add(Me.cedComboBox)
        Me.Panel3.Controls.Add(Me.idTextBox)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(160, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(414, 81)
        Me.Panel3.TabIndex = 0
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.Transparent
        Me.searchButton.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Database_Search
        Me.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.searchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Location = New System.Drawing.Point(353, 15)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(50, 50)
        Me.searchButton.TabIndex = 53
        Me.searchButton.TabStop = False
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'cedComboBox
        '
        Me.cedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cedComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedComboBox.FormattingEnabled = True
        Me.cedComboBox.Items.AddRange(New Object() {"V", "E", "P", "J", "G"})
        Me.cedComboBox.Location = New System.Drawing.Point(3, 34)
        Me.cedComboBox.Name = "cedComboBox"
        Me.cedComboBox.Size = New System.Drawing.Size(34, 29)
        Me.cedComboBox.TabIndex = 52
        Me.cedComboBox.TabStop = False
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.idTextBox.Location = New System.Drawing.Point(43, 34)
        Me.idTextBox.MaxLength = 13
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(298, 29)
        Me.idTextBox.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Ingrese la Identificación del cliente a editar"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.locTextBox)
        Me.Panel4.Location = New System.Drawing.Point(12, 231)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(710, 71)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(312, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Ubicación"
        Me.Label2.UseWaitCursor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.locLabel)
        Me.Panel5.Location = New System.Drawing.Point(4, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(337, 29)
        Me.Panel5.TabIndex = 34
        '
        'locLabel
        '
        Me.locLabel.BackColor = System.Drawing.Color.Transparent
        Me.locLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.locLabel.Location = New System.Drawing.Point(3, 4)
        Me.locLabel.Name = "locLabel"
        Me.locLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.locLabel.Size = New System.Drawing.Size(331, 21)
        Me.locLabel.TabIndex = 33
        Me.locLabel.Text = "."
        Me.locLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'locTextBox
        '
        Me.locTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.locTextBox.Location = New System.Drawing.Point(369, 34)
        Me.locTextBox.MaxLength = 30
        Me.locTextBox.Name = "locTextBox"
        Me.locTextBox.Size = New System.Drawing.Size(337, 29)
        Me.locTextBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(166, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Deje en blanco los espacios que no desea modificar"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.phoneTextBox)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(12, 312)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(710, 71)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.phone_numberLabel)
        Me.Panel7.Location = New System.Drawing.Point(4, 34)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(337, 29)
        Me.Panel7.TabIndex = 34
        '
        'phone_numberLabel
        '
        Me.phone_numberLabel.BackColor = System.Drawing.Color.Transparent
        Me.phone_numberLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_numberLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.phone_numberLabel.Location = New System.Drawing.Point(3, 4)
        Me.phone_numberLabel.Name = "phone_numberLabel"
        Me.phone_numberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.phone_numberLabel.Size = New System.Drawing.Size(331, 21)
        Me.phone_numberLabel.TabIndex = 33
        Me.phone_numberLabel.Text = "."
        Me.phone_numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.phoneTextBox.Location = New System.Drawing.Point(369, 34)
        Me.phoneTextBox.MaxLength = 15
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(337, 29)
        Me.phoneTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(273, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Número de teléfono"
        '
        'editIconButton
        '
        Me.editIconButton.BackColor = System.Drawing.Color.Transparent
        Me.editIconButton.BackgroundImage = CType(resources.GetObject("editIconButton.BackgroundImage"), System.Drawing.Image)
        Me.editIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editIconButton.FlatAppearance.BorderSize = 0
        Me.editIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.editIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editIconButton.Location = New System.Drawing.Point(204, 401)
        Me.editIconButton.Name = "editIconButton"
        Me.editIconButton.Size = New System.Drawing.Size(35, 35)
        Me.editIconButton.TabIndex = 38
        Me.editIconButton.TabStop = False
        Me.editIconButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Transparent
        Me.editButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editButton.FlatAppearance.BorderSize = 0
        Me.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.SystemColors.Control
        Me.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.editButton.Location = New System.Drawing.Point(222, 401)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(95, 35)
        Me.editButton.TabIndex = 4
        Me.editButton.Text = "&Editar"
        Me.editButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.editButton.UseVisualStyleBackColor = False
        '
        'cancelIconButton
        '
        Me.cancelIconButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelIconButton.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Cancel
        Me.cancelIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cancelIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelIconButton.FlatAppearance.BorderSize = 0
        Me.cancelIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cancelIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cancelIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelIconButton.Location = New System.Drawing.Point(495, 398)
        Me.cancelIconButton.Name = "cancelIconButton"
        Me.cancelIconButton.Size = New System.Drawing.Size(35, 35)
        Me.cancelIconButton.TabIndex = 40
        Me.cancelIconButton.TabStop = False
        Me.cancelIconButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelButton.FlatAppearance.BorderSize = 0
        Me.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.ForeColor = System.Drawing.SystemColors.Control
        Me.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancelButton.Location = New System.Drawing.Point(412, 401)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 5
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'client_idLabel
        '
        Me.client_idLabel.AutoSize = True
        Me.client_idLabel.BackColor = System.Drawing.Color.Transparent
        Me.client_idLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client_idLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.client_idLabel.Location = New System.Drawing.Point(23, 19)
        Me.client_idLabel.Name = "client_idLabel"
        Me.client_idLabel.Size = New System.Drawing.Size(117, 21)
        Me.client_idLabel.TabIndex = 35
        Me.client_idLabel.Text = "ID del Cliente "
        Me.client_idLabel.Visible = False
        '
        'actual_idLabel
        '
        Me.actual_idLabel.AutoSize = True
        Me.actual_idLabel.BackColor = System.Drawing.Color.Transparent
        Me.actual_idLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actual_idLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.actual_idLabel.Location = New System.Drawing.Point(69, 53)
        Me.actual_idLabel.Name = "actual_idLabel"
        Me.actual_idLabel.Size = New System.Drawing.Size(14, 21)
        Me.actual_idLabel.TabIndex = 41
        Me.actual_idLabel.Text = "."
        Me.actual_idLabel.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.client_idLabel)
        Me.Panel8.Controls.Add(Me.actual_idLabel)
        Me.Panel8.Location = New System.Drawing.Point(574, 49)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(163, 98)
        Me.Panel8.TabIndex = 42
        '
        'EditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cancelIconButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.editIconButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cedComboBox As ComboBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents locLabel As Label
    Friend WithEvents locTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents phone_numberLabel As Label
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents editIconButton As Button
    Private WithEvents editButton As Button
    Friend WithEvents cancelIconButton As Button
    Private WithEvents cancelButton As Button
    Friend WithEvents client_idLabel As Label
    Friend WithEvents actual_idLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
End Class
