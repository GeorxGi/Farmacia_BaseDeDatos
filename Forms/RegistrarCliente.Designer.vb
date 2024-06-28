<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarCliente))
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.addIconButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cedComboBox = New System.Windows.Forms.ComboBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.usernamePanel = New System.Windows.Forms.Panel()
        Me.usernamePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.locationTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cancelIconButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.usernamePanel.SuspendLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cancelButton.Location = New System.Drawing.Point(258, 367)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 6
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'addIconButton
        '
        Me.addIconButton.BackColor = System.Drawing.Color.Transparent
        Me.addIconButton.BackgroundImage = CType(resources.GetObject("addIconButton.BackgroundImage"), System.Drawing.Image)
        Me.addIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addIconButton.FlatAppearance.BorderSize = 0
        Me.addIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.addIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.addIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addIconButton.Location = New System.Drawing.Point(57, 364)
        Me.addIconButton.Name = "addIconButton"
        Me.addIconButton.Size = New System.Drawing.Size(35, 35)
        Me.addIconButton.TabIndex = 52
        Me.addIconButton.TabStop = False
        Me.addIconButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.SystemColors.Control
        Me.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addButton.Location = New System.Drawing.Point(75, 367)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(95, 35)
        Me.addButton.TabIndex = 5
        Me.addButton.Text = "&Añadir"
        Me.addButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(76, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 37)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "REGISTRAR CLIENTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.PictureBox1.Location = New System.Drawing.Point(3, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.nameTextBox.Location = New System.Drawing.Point(50, 23)
        Me.nameTextBox.MaxLength = 40
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(337, 29)
        Me.nameTextBox.TabIndex = 0
        Me.nameTextBox.Text = "Nombre  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(46, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(46, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Identificación:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cedComboBox)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.idTextBox)
        Me.Panel1.Location = New System.Drawing.Point(22, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 56)
        Me.Panel1.TabIndex = 1
        '
        'cedComboBox
        '
        Me.cedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cedComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedComboBox.FormattingEnabled = True
        Me.cedComboBox.Items.AddRange(New Object() {"V", "E", "P", "J", "G"})
        Me.cedComboBox.Location = New System.Drawing.Point(49, 21)
        Me.cedComboBox.Name = "cedComboBox"
        Me.cedComboBox.Size = New System.Drawing.Size(34, 29)
        Me.cedComboBox.TabIndex = 50
        Me.cedComboBox.TabStop = False
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.idTextBox.Location = New System.Drawing.Point(89, 21)
        Me.idTextBox.MaxLength = 13
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(298, 29)
        Me.idTextBox.TabIndex = 1
        '
        'usernamePanel
        '
        Me.usernamePanel.BackColor = System.Drawing.Color.Transparent
        Me.usernamePanel.Controls.Add(Me.usernamePictureBox)
        Me.usernamePanel.Controls.Add(Me.nameTextBox)
        Me.usernamePanel.Controls.Add(Me.Label3)
        Me.usernamePanel.Location = New System.Drawing.Point(22, 48)
        Me.usernamePanel.Name = "usernamePanel"
        Me.usernamePanel.Size = New System.Drawing.Size(391, 58)
        Me.usernamePanel.TabIndex = 0
        '
        'usernamePictureBox
        '
        Me.usernamePictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.usernamePictureBox.Location = New System.Drawing.Point(3, 15)
        Me.usernamePictureBox.Name = "usernamePictureBox"
        Me.usernamePictureBox.Size = New System.Drawing.Size(40, 40)
        Me.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usernamePictureBox.TabIndex = 7
        Me.usernamePictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.locationTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(22, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 58)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.PictureBox2.Location = New System.Drawing.Point(3, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'locationTextBox
        '
        Me.locationTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.locationTextBox.Location = New System.Drawing.Point(50, 23)
        Me.locationTextBox.MaxLength = 30
        Me.locationTextBox.Name = "locationTextBox"
        Me.locationTextBox.Size = New System.Drawing.Size(337, 29)
        Me.locationTextBox.TabIndex = 4
        Me.locationTextBox.Text = "Ubicación  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(46, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ubicación:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.numberTextBox)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(22, 186)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 58)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.PictureBox3.Location = New System.Drawing.Point(3, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'numberTextBox
        '
        Me.numberTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.numberTextBox.Location = New System.Drawing.Point(50, 23)
        Me.numberTextBox.MaxLength = 15
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.Size = New System.Drawing.Size(337, 29)
        Me.numberTextBox.TabIndex = 3
        Me.numberTextBox.Text = "Número de teléfono  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(46, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Número de teléfono:"
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
        Me.cancelIconButton.Location = New System.Drawing.Point(342, 364)
        Me.cancelIconButton.Name = "cancelIconButton"
        Me.cancelIconButton.Size = New System.Drawing.Size(35, 35)
        Me.cancelIconButton.TabIndex = 53
        Me.cancelIconButton.TabStop = False
        Me.cancelIconButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(71, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Ejemplo: 4121234567"
        Me.Label6.UseWaitCursor = True
        Me.Label6.Visible = False
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(434, 411)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cancelIconButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.addIconButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegistrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.usernamePanel.ResumeLayout(False)
        Me.usernamePanel.PerformLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cancelButton As Button
    Friend WithEvents addIconButton As Button
    Private WithEvents addButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents usernamePictureBox As PictureBox
    Friend WithEvents cedComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents locationTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents numberTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cancelIconButton As Button
    Friend WithEvents Label6 As Label
End Class
