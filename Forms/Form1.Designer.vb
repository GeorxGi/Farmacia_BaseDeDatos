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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.showPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.usernamePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.usernamePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iniciar sesión"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(280, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(96, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Ingresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.usernameTextBox.Location = New System.Drawing.Point(39, 13)
        Me.usernameTextBox.MaxLength = 20
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(210, 26)
        Me.usernameTextBox.TabIndex = 0
        Me.usernameTextBox.Text = "Usuario  "
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordTextBox.Location = New System.Drawing.Point(41, 13)
        Me.passwordTextBox.MaxLength = 30
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(210, 26)
        Me.passwordTextBox.TabIndex = 1
        Me.passwordTextBox.Text = "Contraseña  "
        '
        'showPasswordCheckBox
        '
        Me.showPasswordCheckBox.AutoSize = True
        Me.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showPasswordCheckBox.Location = New System.Drawing.Point(257, 9)
        Me.showPasswordCheckBox.Name = "showPasswordCheckBox"
        Me.showPasswordCheckBox.Size = New System.Drawing.Size(79, 30)
        Me.showPasswordCheckBox.TabIndex = 0
        Me.showPasswordCheckBox.TabStop = False
        Me.showPasswordCheckBox.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña"
        Me.showPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'usernamePanel
        '
        Me.usernamePanel.Controls.Add(Me.PictureBox1)
        Me.usernamePanel.Controls.Add(Me.usernameTextBox)
        Me.usernamePanel.Location = New System.Drawing.Point(110, 56)
        Me.usernamePanel.Name = "usernamePanel"
        Me.usernamePanel.Size = New System.Drawing.Size(341, 49)
        Me.usernamePanel.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox1.InitialImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox1.Location = New System.Drawing.Point(3, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.passwordTextBox)
        Me.Panel1.Controls.Add(Me.showPasswordCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(110, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 50)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.password_icon
        Me.PictureBox2.InitialImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox2.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio sesión"
        Me.usernamePanel.ResumeLayout(False)
        Me.usernamePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents showPasswordCheckBox As CheckBox
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
