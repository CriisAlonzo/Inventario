<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadExistente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnAlmacenes = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventario"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Producto, Me.CantidadExistente, Me.CantidadMinima, Me.DataGridViewTextBoxColumn1, Me.Almacen, Me.Proveedor, Me.FechaEntrada})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 181)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(922, 460)
        Me.DataGridView1.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'CantidadExistente
        '
        Me.CantidadExistente.HeaderText = "Existencias"
        Me.CantidadExistente.MinimumWidth = 6
        Me.CantidadExistente.Name = "CantidadExistente"
        Me.CantidadExistente.ReadOnly = True
        '
        'CantidadMinima
        '
        Me.CantidadMinima.HeaderText = "Cantidad Minima"
        Me.CantidadMinima.MinimumWidth = 6
        Me.CantidadMinima.Name = "CantidadMinima"
        Me.CantidadMinima.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Almacen
        '
        Me.Almacen.HeaderText = "Almacen"
        Me.Almacen.MinimumWidth = 6
        Me.Almacen.Name = "Almacen"
        Me.Almacen.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.MinimumWidth = 6
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'FechaEntrada
        '
        Me.FechaEntrada.HeaderText = "Fecha de Entrada"
        Me.FechaEntrada.MinimumWidth = 6
        Me.FechaEntrada.Name = "FechaEntrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(14, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 139)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 27)
        Me.TextBox1.TabIndex = 3
        '
        'btnProductos
        '
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProductos.Location = New System.Drawing.Point(625, 76)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(94, 93)
        Me.btnProductos.TabIndex = 4
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), System.Drawing.Image)
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProveedores.Location = New System.Drawing.Point(719, 76)
        Me.btnProveedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(112, 93)
        Me.btnProveedores.TabIndex = 5
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.FlatAppearance.BorderSize = 0
        Me.btnAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmacenes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAlmacenes.Image = CType(resources.GetObject("btnAlmacenes.Image"), System.Drawing.Image)
        Me.btnAlmacenes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlmacenes.Location = New System.Drawing.Point(829, 76)
        Me.btnAlmacenes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(107, 93)
        Me.btnAlmacenes.TabIndex = 6
        Me.btnAlmacenes.Text = "Almacenes"
        Me.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAlmacenes.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 657)
        Me.Controls.Add(Me.btnAlmacenes)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnAlmacenes As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents CantidadExistente As DataGridViewTextBoxColumn
    Friend WithEvents CantidadMinima As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Almacen As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrada As DataGridViewTextBoxColumn
End Class
