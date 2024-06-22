<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.acceptButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fullnameTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.usernamePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.showPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.usernamePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario:"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.usernameTextBox.Location = New System.Drawing.Point(38, 23)
        Me.usernameTextBox.MaxLength = 20
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(337, 26)
        Me.usernameTextBox.TabIndex = 0
        Me.usernameTextBox.Text = "Usuario  "
        '
        'acceptButton
        '
        Me.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.acceptButton.Location = New System.Drawing.Point(98, 324)
        Me.acceptButton.Name = "acceptButton"
        Me.acceptButton.Size = New System.Drawing.Size(105, 35)
        Me.acceptButton.TabIndex = 4
        Me.acceptButton.Text = "Aceptar"
        Me.acceptButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Registrarse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(43, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Contraseña:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordTextBox.Location = New System.Drawing.Point(43, 22)
        Me.passwordTextBox.MaxLength = 30
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(334, 26)
        Me.passwordTextBox.TabIndex = 2
        Me.passwordTextBox.Text = "Contraseña  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(38, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nombre completo:"
        '
        'fullnameTextBox
        '
        Me.fullnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.fullnameTextBox.Location = New System.Drawing.Point(38, 22)
        Me.fullnameTextBox.MaxLength = 40
        Me.fullnameTextBox.Name = "fullnameTextBox"
        Me.fullnameTextBox.Size = New System.Drawing.Size(337, 26)
        Me.fullnameTextBox.TabIndex = 1
        Me.fullnameTextBox.Text = "Nombre completo  "
        '
        'cancelButton
        '
        Me.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelButton.Location = New System.Drawing.Point(282, 324)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(105, 35)
        Me.cancelButton.TabIndex = 5
        Me.cancelButton.Text = "Cancelar"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(43, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Confirmar Contraseña:"
        '
        'confirmPasswordTextBox
        '
        Me.confirmPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.confirmPasswordTextBox.Location = New System.Drawing.Point(43, 73)
        Me.confirmPasswordTextBox.MaxLength = 30
        Me.confirmPasswordTextBox.Name = "confirmPasswordTextBox"
        Me.confirmPasswordTextBox.Size = New System.Drawing.Size(334, 26)
        Me.confirmPasswordTextBox.TabIndex = 3
        Me.confirmPasswordTextBox.Text = "Confirmar Contraseña  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 38)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "La contraseña debe contener: Minúsculas, Mayúsculas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números y Caracteres especia" &
    "les" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'usernamePanel
        '
        Me.usernamePanel.Controls.Add(Me.PictureBox1)
        Me.usernamePanel.Controls.Add(Me.usernameTextBox)
        Me.usernamePanel.Controls.Add(Me.Label3)
        Me.usernamePanel.Location = New System.Drawing.Point(12, 45)
        Me.usernamePanel.Name = "usernamePanel"
        Me.usernamePanel.Size = New System.Drawing.Size(379, 58)
        Me.usernamePanel.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(2, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.fullnameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 56)
        Me.Panel1.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.nameTag_icon
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(2, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.showPasswordCheckBox)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.passwordTextBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.confirmPasswordTextBox)
        Me.Panel2.Location = New System.Drawing.Point(7, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 145)
        Me.Panel2.TabIndex = 18
        '
        'showPasswordCheckBox
        '
        Me.showPasswordCheckBox.AutoSize = True
        Me.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showPasswordCheckBox.Location = New System.Drawing.Point(383, 18)
        Me.showPasswordCheckBox.Name = "showPasswordCheckBox"
        Me.showPasswordCheckBox.Size = New System.Drawing.Size(79, 30)
        Me.showPasswordCheckBox.TabIndex = 0
        Me.showPasswordCheckBox.TabStop = False
        Me.showPasswordCheckBox.Text = "Ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña"
        Me.showPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.password_icon
        Me.PictureBox3.InitialImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox3.Location = New System.Drawing.Point(7, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Farmacia_BaseDeDatos.My.Resources.Resources.password_icon
        Me.PictureBox4.InitialImage = Global.Farmacia_BaseDeDatos.My.Resources.Resources.user_icon
        Me.PictureBox4.Location = New System.Drawing.Point(7, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.usernamePanel)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.acceptButton)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents acceptButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fullnameTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents confirmPasswordTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents usernamePanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents showPasswordCheckBox As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
