<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.usernamePanel = New System.Windows.Forms.Panel()
        Me.usernamePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.showPasswordButton = New System.Windows.Forms.Button()
        Me.passwordPictureBox = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.registerIconButton = New System.Windows.Forms.Button()
        Me.loginIconButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.usernamePanel.SuspendLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(84, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIAR SESIÓN"
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.Transparent
        Me.registerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerButton.FlatAppearance.BorderSize = 0
        Me.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerButton.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.ForeColor = System.Drawing.SystemColors.Control
        Me.registerButton.Location = New System.Drawing.Point(224, 310)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(95, 35)
        Me.registerButton.TabIndex = 3
        Me.registerButton.Text = "&Registrar"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.usernameTextBox.Location = New System.Drawing.Point(41, 12)
        Me.usernameTextBox.MaxLength = 20
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(220, 29)
        Me.usernameTextBox.TabIndex = 0
        Me.usernameTextBox.Text = "Usuario  "
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordTextBox.Location = New System.Drawing.Point(41, 12)
        Me.passwordTextBox.MaxLength = 30
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(220, 29)
        Me.passwordTextBox.TabIndex = 1
        Me.passwordTextBox.Text = "Contraseña  "
        '
        'usernamePanel
        '
        Me.usernamePanel.BackColor = System.Drawing.Color.Transparent
        Me.usernamePanel.Controls.Add(Me.usernamePictureBox)
        Me.usernamePanel.Controls.Add(Me.usernameTextBox)
        Me.usernamePanel.Location = New System.Drawing.Point(41, 177)
        Me.usernamePanel.Name = "usernamePanel"
        Me.usernamePanel.Size = New System.Drawing.Size(312, 49)
        Me.usernamePanel.TabIndex = 7
        '
        'usernamePictureBox
        '
        Me.usernamePictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.User
        Me.usernamePictureBox.Location = New System.Drawing.Point(0, 5)
        Me.usernamePictureBox.Name = "usernamePictureBox"
        Me.usernamePictureBox.Size = New System.Drawing.Size(41, 40)
        Me.usernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usernamePictureBox.TabIndex = 1
        Me.usernamePictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.showPasswordButton)
        Me.Panel1.Controls.Add(Me.passwordPictureBox)
        Me.Panel1.Controls.Add(Me.passwordTextBox)
        Me.Panel1.Location = New System.Drawing.Point(41, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 50)
        Me.Panel1.TabIndex = 8
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
        Me.showPasswordButton.Location = New System.Drawing.Point(268, 8)
        Me.showPasswordButton.Name = "showPasswordButton"
        Me.showPasswordButton.Size = New System.Drawing.Size(35, 35)
        Me.showPasswordButton.TabIndex = 10
        Me.showPasswordButton.TabStop = False
        Me.showPasswordButton.UseVisualStyleBackColor = False
        '
        'passwordPictureBox
        '
        Me.passwordPictureBox.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.Password
        Me.passwordPictureBox.Location = New System.Drawing.Point(0, 4)
        Me.passwordPictureBox.Name = "passwordPictureBox"
        Me.passwordPictureBox.Size = New System.Drawing.Size(41, 40)
        Me.passwordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.passwordPictureBox.TabIndex = 1
        Me.passwordPictureBox.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.Transparent
        Me.loginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.SystemColors.Control
        Me.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.loginButton.Location = New System.Drawing.Point(70, 314)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(95, 35)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "&Ingresar"
        Me.loginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'registerIconButton
        '
        Me.registerIconButton.BackColor = System.Drawing.Color.Transparent
        Me.registerIconButton.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.SignUp
        Me.registerIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.registerIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerIconButton.FlatAppearance.BorderSize = 0
        Me.registerIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.registerIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.registerIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerIconButton.Location = New System.Drawing.Point(309, 310)
        Me.registerIconButton.Name = "registerIconButton"
        Me.registerIconButton.Size = New System.Drawing.Size(35, 35)
        Me.registerIconButton.TabIndex = 12
        Me.registerIconButton.TabStop = False
        Me.registerIconButton.UseVisualStyleBackColor = False
        '
        'loginIconButton
        '
        Me.loginIconButton.BackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.BackgroundImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.LogIn
        Me.loginIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.loginIconButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginIconButton.FlatAppearance.BorderSize = 0
        Me.loginIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginIconButton.Location = New System.Drawing.Point(47, 312)
        Me.loginIconButton.Name = "loginIconButton"
        Me.loginIconButton.Size = New System.Drawing.Size(35, 35)
        Me.loginIconButton.TabIndex = 11
        Me.loginIconButton.TabStop = False
        Me.loginIconButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(393, 139)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(394, 361)
        Me.Controls.Add(Me.registerIconButton)
        Me.Controls.Add(Me.loginIconButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio sesión"
        Me.usernamePanel.ResumeLayout(False)
        Me.usernamePanel.PerformLayout()
        CType(Me.usernamePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.passwordPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents registerButton As Button
    Friend WithEvents loginButton As Button
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents usernamePictureBox As PictureBox
    Friend WithEvents passwordPictureBox As PictureBox
    Friend WithEvents showPasswordButton As Button
    Friend WithEvents loginIconButton As Button
    Friend WithEvents registerIconButton As Button
End Class
