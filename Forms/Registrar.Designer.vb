<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fullnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.usernamePanel = New System.Windows.Forms.Panel()
        Me.usernamePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.passContainPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.specialCharPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numberPictureBox = New System.Windows.Forms.PictureBox()
        Me.minusPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mayusPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.passwordPictureBox = New System.Windows.Forms.PictureBox()
        Me.showPasswordButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.cancelIconButton = New System.Windows.Forms.Button()
        Me.addIconButton = New System.Windows.Forms.Button()
        Me.usernamePanel.SuspendLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.passContainPanel.SuspendLayout()
        CType(Me.specialCharPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mayusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(46, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.usernameTextBox.Location = New System.Drawing.Point(50, 23)
        Me.usernameTextBox.MaxLength = 20
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(337, 29)
        Me.usernameTextBox.TabIndex = 0
        Me.usernameTextBox.Text = "Usuario  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(51, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordTextBox.Location = New System.Drawing.Point(55, 22)
        Me.passwordTextBox.MaxLength = 30
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(334, 29)
        Me.passwordTextBox.TabIndex = 2
        Me.passwordTextBox.Text = "Contraseña  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(46, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre completo:"
        '
        'fullnameTextBox
        '
        Me.fullnameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.fullnameTextBox.Location = New System.Drawing.Point(50, 21)
        Me.fullnameTextBox.MaxLength = 40
        Me.fullnameTextBox.Name = "fullnameTextBox"
        Me.fullnameTextBox.Size = New System.Drawing.Size(337, 29)
        Me.fullnameTextBox.TabIndex = 1
        Me.fullnameTextBox.Text = "Nombre completo  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(51, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Confirmar Contraseña:"
        '
        'confirmPasswordTextBox
        '
        Me.confirmPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.confirmPasswordTextBox.Location = New System.Drawing.Point(55, 71)
        Me.confirmPasswordTextBox.MaxLength = 30
        Me.confirmPasswordTextBox.Name = "confirmPasswordTextBox"
        Me.confirmPasswordTextBox.Size = New System.Drawing.Size(334, 29)
        Me.confirmPasswordTextBox.TabIndex = 3
        Me.confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "La contraseña debe contener:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'usernamePanel
        '
        Me.usernamePanel.BackColor = System.Drawing.Color.Transparent
        Me.usernamePanel.Controls.Add(Me.usernamePictureBox)
        Me.usernamePanel.Controls.Add(Me.usernameTextBox)
        Me.usernamePanel.Controls.Add(Me.Label3)
        Me.usernamePanel.Location = New System.Drawing.Point(12, 45)
        Me.usernamePanel.Name = "usernamePanel"
        Me.usernamePanel.Size = New System.Drawing.Size(391, 58)
        Me.usernamePanel.TabIndex = 16
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.fullnameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 56)
        Me.Panel1.TabIndex = 17
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.passContainPanel)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.passwordPictureBox)
        Me.Panel2.Controls.Add(Me.showPasswordButton)
        Me.Panel2.Controls.Add(Me.passwordTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.confirmPasswordTextBox)
        Me.Panel2.Location = New System.Drawing.Point(7, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 189)
        Me.Panel2.TabIndex = 18
        '
        'passContainPanel
        '
        Me.passContainPanel.Controls.Add(Me.Label10)
        Me.passContainPanel.Controls.Add(Me.specialCharPictureBox)
        Me.passContainPanel.Controls.Add(Me.Label6)
        Me.passContainPanel.Controls.Add(Me.Label7)
        Me.passContainPanel.Controls.Add(Me.Label9)
        Me.passContainPanel.Controls.Add(Me.numberPictureBox)
        Me.passContainPanel.Controls.Add(Me.minusPictureBox)
        Me.passContainPanel.Controls.Add(Me.Label8)
        Me.passContainPanel.Controls.Add(Me.mayusPictureBox)
        Me.passContainPanel.Location = New System.Drawing.Point(8, 102)
        Me.passContainPanel.Name = "passContainPanel"
        Me.passContainPanel.Size = New System.Drawing.Size(337, 70)
        Me.passContainPanel.TabIndex = 33
        Me.passContainPanel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(178, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Caracteres especiales"
        '
        'specialCharPictureBox
        '
        Me.specialCharPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.specialCharPictureBox.Image = CType(resources.GetObject("specialCharPictureBox.Image"), System.Drawing.Image)
        Me.specialCharPictureBox.Location = New System.Drawing.Point(152, 39)
        Me.specialCharPictureBox.Name = "specialCharPictureBox"
        Me.specialCharPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.specialCharPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.specialCharPictureBox.TabIndex = 32
        Me.specialCharPictureBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(42, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Minúsculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(178, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Números"
        '
        'numberPictureBox
        '
        Me.numberPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.numberPictureBox.Image = CType(resources.GetObject("numberPictureBox.Image"), System.Drawing.Image)
        Me.numberPictureBox.Location = New System.Drawing.Point(152, 20)
        Me.numberPictureBox.Name = "numberPictureBox"
        Me.numberPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.numberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.numberPictureBox.TabIndex = 30
        Me.numberPictureBox.TabStop = False
        '
        'minusPictureBox
        '
        Me.minusPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.minusPictureBox.Image = CType(resources.GetObject("minusPictureBox.Image"), System.Drawing.Image)
        Me.minusPictureBox.Location = New System.Drawing.Point(16, 19)
        Me.minusPictureBox.Name = "minusPictureBox"
        Me.minusPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.minusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minusPictureBox.TabIndex = 22
        Me.minusPictureBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(42, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Mayúsculas"
        '
        'mayusPictureBox
        '
        Me.mayusPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.mayusPictureBox.Image = CType(resources.GetObject("mayusPictureBox.Image"), System.Drawing.Image)
        Me.mayusPictureBox.Location = New System.Drawing.Point(16, 39)
        Me.mayusPictureBox.Name = "mayusPictureBox"
        Me.mayusPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.mayusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mayusPictureBox.TabIndex = 28
        Me.mayusPictureBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Password
        Me.PictureBox2.Location = New System.Drawing.Point(8, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'passwordPictureBox
        '
        Me.passwordPictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Password
        Me.passwordPictureBox.Location = New System.Drawing.Point(8, 13)
        Me.passwordPictureBox.Name = "passwordPictureBox"
        Me.passwordPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.passwordPictureBox.TabIndex = 20
        Me.passwordPictureBox.TabStop = False
        '
        'showPasswordButton
        '
        Me.showPasswordButton.BackColor = System.Drawing.Color.Transparent
        Me.showPasswordButton.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.HidePassword
        Me.showPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.showPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showPasswordButton.FlatAppearance.BorderSize = 0
        Me.showPasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.showPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showPasswordButton.Location = New System.Drawing.Point(395, 43)
        Me.showPasswordButton.Name = "showPasswordButton"
        Me.showPasswordButton.Size = New System.Drawing.Size(35, 35)
        Me.showPasswordButton.TabIndex = 19
        Me.showPasswordButton.TabStop = False
        Me.showPasswordButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(78, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "REGISTRAR USUARIO"
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
        Me.addButton.Location = New System.Drawing.Point(101, 364)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(95, 35)
        Me.addButton.TabIndex = 23
        Me.addButton.Text = "&Añadir"
        Me.addButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addButton.UseVisualStyleBackColor = False
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
        Me.cancelButton.Location = New System.Drawing.Point(284, 364)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 25
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
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
        Me.cancelIconButton.Location = New System.Drawing.Point(367, 361)
        Me.cancelIconButton.Name = "cancelIconButton"
        Me.cancelIconButton.Size = New System.Drawing.Size(35, 35)
        Me.cancelIconButton.TabIndex = 26
        Me.cancelIconButton.TabStop = False
        Me.cancelIconButton.UseVisualStyleBackColor = False
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
        Me.addIconButton.Location = New System.Drawing.Point(83, 364)
        Me.addIconButton.Name = "addIconButton"
        Me.addIconButton.Size = New System.Drawing.Size(35, 35)
        Me.addIconButton.TabIndex = 24
        Me.addIconButton.TabStop = False
        Me.addIconButton.UseVisualStyleBackColor = False
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(454, 411)
        Me.Controls.Add(Me.cancelIconButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.addIconButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(470, 450)
        Me.MinimumSize = New System.Drawing.Size(470, 450)
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.usernamePanel.ResumeLayout(False)
        Me.usernamePanel.PerformLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.passContainPanel.ResumeLayout(False)
        Me.passContainPanel.PerformLayout()
        CType(Me.specialCharPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mayusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fullnameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents confirmPasswordTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents showPasswordButton As Button
    Friend WithEvents usernamePictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents passwordPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addIconButton As Button
    Private WithEvents addButton As Button
    Private WithEvents cancelButton As Button
    Friend WithEvents cancelIconButton As Button
    Friend WithEvents minusPictureBox As PictureBox
    Friend WithEvents passContainPanel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents specialCharPictureBox As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents numberPictureBox As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mayusPictureBox As PictureBox
End Class
