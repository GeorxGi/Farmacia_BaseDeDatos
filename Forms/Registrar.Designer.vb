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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loginIconButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.passwordPictureBox = New System.Windows.Forms.PictureBox()
        Me.showPasswordButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernamePictureBox = New System.Windows.Forms.PictureBox()
        Me.usernamePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(20, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(434, 42)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "La contraseña debe contener: Minúsculas, Mayúsculas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números y Caracteres especia" &
    "les" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.Visible = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.passwordPictureBox)
        Me.Panel2.Controls.Add(Me.showPasswordButton)
        Me.Panel2.Controls.Add(Me.passwordTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.confirmPasswordTextBox)
        Me.Panel2.Location = New System.Drawing.Point(7, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 145)
        Me.Panel2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(144, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "REGISTRARSE"
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
        Me.addButton.Location = New System.Drawing.Point(101, 317)
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
        Me.cancelButton.Location = New System.Drawing.Point(284, 317)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 25
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Cancel
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(367, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'loginIconButton
        '
        Me.loginIconButton.BackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.BackgroundImage = CType(resources.GetObject("loginIconButton.BackgroundImage"), System.Drawing.Image)
        Me.loginIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loginIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginIconButton.FlatAppearance.BorderSize = 0
        Me.loginIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginIconButton.Location = New System.Drawing.Point(83, 317)
        Me.loginIconButton.Name = "loginIconButton"
        Me.loginIconButton.Size = New System.Drawing.Size(35, 35)
        Me.loginIconButton.TabIndex = 24
        Me.loginIconButton.TabStop = False
        Me.loginIconButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Password
        Me.PictureBox2.Location = New System.Drawing.Point(8, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'passwordPictureBox
        '
        Me.passwordPictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Password
        Me.passwordPictureBox.Location = New System.Drawing.Point(8, 13)
        Me.passwordPictureBox.Name = "passwordPictureBox"
        Me.passwordPictureBox.Size = New System.Drawing.Size(41, 40)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.PictureBox1.Location = New System.Drawing.Point(3, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'usernamePictureBox
        '
        Me.usernamePictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.usernamePictureBox.Location = New System.Drawing.Point(3, 15)
        Me.usernamePictureBox.Name = "usernamePictureBox"
        Me.usernamePictureBox.Size = New System.Drawing.Size(41, 40)
        Me.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usernamePictureBox.TabIndex = 7
        Me.usernamePictureBox.TabStop = False
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.loginIconButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar"
        Me.usernamePanel.ResumeLayout(False)
        Me.usernamePanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents loginIconButton As Button
    Private WithEvents addButton As Button
    Private WithEvents cancelButton As Button
    Friend WithEvents Button1 As Button
End Class
