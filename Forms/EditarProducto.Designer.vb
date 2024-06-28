<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarProducto))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cancelIconButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.presentLabel = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.presentComboBox = New System.Windows.Forms.ComboBox()
        Me.presentTextBox = New System.Windows.Forms.TextBox()
        Me.newLabTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.newNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.editIconButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cancelIconButton.Location = New System.Drawing.Point(494, 611)
        Me.cancelIconButton.Name = "cancelIconButton"
        Me.cancelIconButton.Size = New System.Drawing.Size(35, 35)
        Me.cancelIconButton.TabIndex = 52
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
        Me.cancelButton.Location = New System.Drawing.Point(411, 614)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 48
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
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
        Me.editButton.Location = New System.Drawing.Point(221, 614)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(95, 35)
        Me.editButton.TabIndex = 47
        Me.editButton.Text = "&Editar"
        Me.editButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.editButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(301, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Presentación"
        '
        'presentLabel
        '
        Me.presentLabel.BackColor = System.Drawing.Color.Transparent
        Me.presentLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.presentLabel.Location = New System.Drawing.Point(3, 4)
        Me.presentLabel.Name = "presentLabel"
        Me.presentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.presentLabel.Size = New System.Drawing.Size(331, 21)
        Me.presentLabel.TabIndex = 33
        Me.presentLabel.Text = "."
        Me.presentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.presentLabel)
        Me.Panel7.Location = New System.Drawing.Point(4, 34)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(337, 29)
        Me.Panel7.TabIndex = 34
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
        Me.Panel5.Controls.Add(Me.labLabel)
        Me.Panel5.Location = New System.Drawing.Point(4, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(337, 29)
        Me.Panel5.TabIndex = 34
        '
        'labLabel
        '
        Me.labLabel.BackColor = System.Drawing.Color.Transparent
        Me.labLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labLabel.Location = New System.Drawing.Point(3, 4)
        Me.labLabel.Name = "labLabel"
        Me.labLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labLabel.Size = New System.Drawing.Size(331, 21)
        Me.labLabel.TabIndex = 33
        Me.labLabel.Text = "."
        Me.labLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(166, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 21)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Deje en blanco los espacios que no desea modificar"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.presentComboBox)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.presentTextBox)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(12, 516)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(710, 71)
        Me.Panel6.TabIndex = 46
        '
        'presentComboBox
        '
        Me.presentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.presentComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentComboBox.FormattingEnabled = True
        Me.presentComboBox.Items.AddRange(New Object() {"MG", "G", "KG", "ML", "L"})
        Me.presentComboBox.Location = New System.Drawing.Point(656, 34)
        Me.presentComboBox.Name = "presentComboBox"
        Me.presentComboBox.Size = New System.Drawing.Size(51, 29)
        Me.presentComboBox.TabIndex = 52
        Me.presentComboBox.TabStop = False
        '
        'presentTextBox
        '
        Me.presentTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.presentTextBox.Location = New System.Drawing.Point(369, 34)
        Me.presentTextBox.MaxLength = 18
        Me.presentTextBox.Name = "presentTextBox"
        Me.presentTextBox.Size = New System.Drawing.Size(281, 29)
        Me.presentTextBox.TabIndex = 51
        '
        'newLabTextBox
        '
        Me.newLabTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newLabTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.newLabTextBox.Location = New System.Drawing.Point(369, 34)
        Me.newLabTextBox.MaxLength = 30
        Me.newLabTextBox.Name = "newLabTextBox"
        Me.newLabTextBox.Size = New System.Drawing.Size(337, 29)
        Me.newLabTextBox.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.newLabTextBox)
        Me.Panel4.Location = New System.Drawing.Point(12, 435)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(710, 71)
        Me.Panel4.TabIndex = 45
        '
        'newNameTextBox
        '
        Me.newNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.newNameTextBox.Location = New System.Drawing.Point(369, 34)
        Me.newNameTextBox.MaxLength = 13
        Me.newNameTextBox.Name = "newNameTextBox"
        Me.newNameTextBox.Size = New System.Drawing.Size(337, 29)
        Me.newNameTextBox.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(154, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Ingrese el nombre del producto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.nameTextBox)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(88, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 81)
        Me.Panel3.TabIndex = 43
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nameTextBox.Location = New System.Drawing.Point(43, 41)
        Me.nameTextBox.MaxLength = 40
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(472, 29)
        Me.nameTextBox.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.nameLabel)
        Me.Panel2.Location = New System.Drawing.Point(4, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 29)
        Me.Panel2.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.newNameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 71)
        Me.Panel1.TabIndex = 44
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(229, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 37)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "EDITAR PRODUCTO"
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
        Me.editIconButton.Location = New System.Drawing.Point(206, 611)
        Me.editIconButton.Name = "editIconButton"
        Me.editIconButton.Size = New System.Drawing.Size(35, 35)
        Me.editIconButton.TabIndex = 52
        Me.editIconButton.TabStop = False
        Me.editIconButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(9, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(713, 183)
        Me.DataGridView1.TabIndex = 58
        '
        'EditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(734, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.editIconButton)
        Me.Controls.Add(Me.cancelIconButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar producto"
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelIconButton As Button
    Private WithEvents cancelButton As Button
    Private WithEvents editButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents presentLabel As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents newLabTextBox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents newNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents editIconButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents presentComboBox As ComboBox
    Friend WithEvents presentTextBox As TextBox
End Class
