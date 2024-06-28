<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaProducto))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.clientLocLabel = New System.Windows.Forms.Label()
        Me.clientnameLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cedComboBox = New System.Windows.Forms.ComboBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addIconButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.cancelIconButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(10, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.Size = New System.Drawing.Size(765, 157)
        Me.DataGridView1.TabIndex = 61
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.nameTextBox)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(113, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 81)
        Me.Panel3.TabIndex = 62
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(424, 429)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 71)
        Me.Panel1.TabIndex = 63
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(0, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Monto total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(337, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 37)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "VENTA"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.searchButton)
        Me.Panel4.Controls.Add(Me.clientLocLabel)
        Me.Panel4.Controls.Add(Me.clientnameLabel)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cedComboBox)
        Me.Panel4.Controls.Add(Me.idTextBox)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(787, 81)
        Me.Panel4.TabIndex = 63
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(397, 38)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(390, 5)
        Me.Panel6.TabIndex = 65
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
        Me.searchButton.Location = New System.Drawing.Point(347, 13)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(50, 50)
        Me.searchButton.TabIndex = 64
        Me.searchButton.TabStop = False
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'clientLocLabel
        '
        Me.clientLocLabel.AutoSize = True
        Me.clientLocLabel.BackColor = System.Drawing.Color.Transparent
        Me.clientLocLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientLocLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.clientLocLabel.Location = New System.Drawing.Point(500, 46)
        Me.clientLocLabel.Name = "clientLocLabel"
        Me.clientLocLabel.Size = New System.Drawing.Size(14, 21)
        Me.clientLocLabel.TabIndex = 66
        Me.clientLocLabel.Text = "."
        '
        'clientnameLabel
        '
        Me.clientnameLabel.AutoSize = True
        Me.clientnameLabel.BackColor = System.Drawing.Color.Transparent
        Me.clientnameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientnameLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.clientnameLabel.Location = New System.Drawing.Point(500, 11)
        Me.clientnameLabel.Name = "clientnameLabel"
        Me.clientnameLabel.Size = New System.Drawing.Size(14, 21)
        Me.clientnameLabel.TabIndex = 65
        Me.clientnameLabel.Text = "."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(784, 5)
        Me.Panel5.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(403, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Ubicación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(403, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nombre: "
        '
        'cedComboBox
        '
        Me.cedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cedComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedComboBox.FormattingEnabled = True
        Me.cedComboBox.Items.AddRange(New Object() {"V", "E", "P", "J", "G"})
        Me.cedComboBox.Location = New System.Drawing.Point(3, 37)
        Me.cedComboBox.Name = "cedComboBox"
        Me.cedComboBox.Size = New System.Drawing.Size(34, 29)
        Me.cedComboBox.TabIndex = 54
        Me.cedComboBox.TabStop = False
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.idTextBox.Location = New System.Drawing.Point(43, 37)
        Me.idTextBox.MaxLength = 13
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(298, 29)
        Me.idTextBox.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Ingrese la Identificación del cliente"
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
        Me.addIconButton.Location = New System.Drawing.Point(714, 386)
        Me.addIconButton.Name = "addIconButton"
        Me.addIconButton.Size = New System.Drawing.Size(35, 35)
        Me.addIconButton.TabIndex = 65
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
        Me.addButton.Location = New System.Drawing.Point(640, 388)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(95, 35)
        Me.addButton.TabIndex = 64
        Me.addButton.Text = "&Añadir"
        Me.addButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addButton.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeight = 40
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.Location = New System.Drawing.Point(10, 400)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.Size = New System.Drawing.Size(390, 157)
        Me.DataGridView2.TabIndex = 66
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
        Me.cancelIconButton.Location = New System.Drawing.Point(723, 611)
        Me.cancelIconButton.Name = "cancelIconButton"
        Me.cancelIconButton.Size = New System.Drawing.Size(35, 35)
        Me.cancelIconButton.TabIndex = 68
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
        Me.cancelButton.Location = New System.Drawing.Point(640, 614)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(95, 35)
        Me.cancelButton.TabIndex = 67
        Me.cancelButton.Text = "&Cancelar"
        Me.cancelButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(204, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(376, 74)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "MENU NO TERMINADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(En unos días lo terminaré)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VentaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cancelIconButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.addIconButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VentaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de Productos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cedComboBox As ComboBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents clientLocLabel As Label
    Friend WithEvents clientnameLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents addIconButton As Button
    Private WithEvents addButton As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cancelIconButton As Button
    Private WithEvents cancelButton As Button
    Friend WithEvents Label7 As Label
End Class
