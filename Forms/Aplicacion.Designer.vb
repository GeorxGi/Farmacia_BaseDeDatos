<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aplicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aplicacion))
        Me.optionMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.VenderProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.optionMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionMenuStrip
        '
        Me.optionMenuStrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.optionMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.optionMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.optionMenuStrip.Name = "optionMenuStrip"
        Me.optionMenuStrip.Size = New System.Drawing.Size(684, 27)
        Me.optionMenuStrip.TabIndex = 3
        Me.optionMenuStrip.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductosToolStripMenuItem, Me.ToolStripMenuItem1, Me.EditarProductoToolStripMenuItem, Me.ListaDeProductosToolStripMenuItem, Me.ToolStripMenuItem4, Me.VenderProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(83, 23)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        '
        'AgregarProductosToolStripMenuItem
        '
        Me.AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        Me.AgregarProductosToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.AgregarProductosToolStripMenuItem.Text = "Agregar productos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'EditarProductoToolStripMenuItem
        '
        Me.EditarProductoToolStripMenuItem.Name = "EditarProductoToolStripMenuItem"
        Me.EditarProductoToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.EditarProductoToolStripMenuItem.Text = "Editar producto"
        '
        'ListaDeProductosToolStripMenuItem
        '
        Me.ListaDeProductosToolStripMenuItem.Name = "ListaDeProductosToolStripMenuItem"
        Me.ListaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ListaDeProductosToolStripMenuItem.Text = "Lista de productos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(190, 6)
        '
        'VenderProductosToolStripMenuItem
        '
        Me.VenderProductosToolStripMenuItem.Name = "VenderProductosToolStripMenuItem"
        Me.VenderProductosToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.VenderProductosToolStripMenuItem.Text = "Vender productos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClientesToolStripMenuItem, Me.ToolStripMenuItem2, Me.ListaDeClientesToolStripMenuItem, Me.EditarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'AgregarClientesToolStripMenuItem
        '
        Me.AgregarClientesToolStripMenuItem.Name = "AgregarClientesToolStripMenuItem"
        Me.AgregarClientesToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.AgregarClientesToolStripMenuItem.Text = "Agregar clientes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(173, 6)
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de clientes"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.EditarClienteToolStripMenuItem.Text = "Editar cliente"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuariosToolStripMenuItem, Me.ToolStripMenuItem3, Me.ListaDeUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'AgregarUsuariosToolStripMenuItem
        '
        Me.AgregarUsuariosToolStripMenuItem.Name = "AgregarUsuariosToolStripMenuItem"
        Me.AgregarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.AgregarUsuariosToolStripMenuItem.Text = "Agregar Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 6)
        '
        'ListaDeUsuariosToolStripMenuItem
        '
        Me.ListaDeUsuariosToolStripMenuItem.Name = "ListaDeUsuariosToolStripMenuItem"
        Me.ListaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.ListaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bienvenido: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'Aplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(684, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optionMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.optionMenuStrip
        Me.Name = "Aplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicacion"
        Me.optionMenuStrip.ResumeLayout(False)
        Me.optionMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optionMenuStrip As MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EditarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents EditarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents VenderProductosToolStripMenuItem As ToolStripMenuItem
End Class
