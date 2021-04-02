<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio_Inventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_Inventario))
        Me.MS_Menu = New System.Windows.Forms.MenuStrip()
        Me.TSM_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEntradaProducto = New System.Windows.Forms.Button()
        Me.btnReporteEntrada = New System.Windows.Forms.Button()
        Me.btnReporteSalida = New System.Windows.Forms.Button()
        Me.btnSalidaProducto = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MS_Menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_Menu
        '
        Me.MS_Menu.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MS_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MS_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_Usuarios, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MS_Menu.Location = New System.Drawing.Point(0, 0)
        Me.MS_Menu.Name = "MS_Menu"
        Me.MS_Menu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MS_Menu.Size = New System.Drawing.Size(975, 25)
        Me.MS_Menu.TabIndex = 0
        Me.MS_Menu.Tag = ""
        Me.MS_Menu.Text = "MenuStrip1"
        '
        'TSM_Usuarios
        '
        Me.TSM_Usuarios.Name = "TSM_Usuarios"
        Me.TSM_Usuarios.Size = New System.Drawing.Size(75, 21)
        Me.TSM_Usuarios.Text = "Usuarios"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(103, 21)
        Me.ToolStripMenuItem2.Text = "Proveedores"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(98, 21)
        Me.ToolStripMenuItem3.Text = "Almacenes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 374)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 21)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(94, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido/a: "
        '
        'btnEntradaProducto
        '
        Me.btnEntradaProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnEntradaProducto.BackgroundImage = CType(resources.GetObject("btnEntradaProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnEntradaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEntradaProducto.FlatAppearance.BorderSize = 0
        Me.btnEntradaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntradaProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEntradaProducto.ForeColor = System.Drawing.Color.White
        Me.btnEntradaProducto.Location = New System.Drawing.Point(10, 134)
        Me.btnEntradaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEntradaProducto.Name = "btnEntradaProducto"
        Me.btnEntradaProducto.Size = New System.Drawing.Size(151, 126)
        Me.btnEntradaProducto.TabIndex = 2
        Me.btnEntradaProducto.Text = "Entrada de Producto"
        Me.btnEntradaProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEntradaProducto.UseVisualStyleBackColor = False
        '
        'btnReporteEntrada
        '
        Me.btnReporteEntrada.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteEntrada.BackgroundImage = CType(resources.GetObject("btnReporteEntrada.BackgroundImage"), System.Drawing.Image)
        Me.btnReporteEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReporteEntrada.FlatAppearance.BorderSize = 0
        Me.btnReporteEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReporteEntrada.ForeColor = System.Drawing.Color.White
        Me.btnReporteEntrada.Location = New System.Drawing.Point(195, 134)
        Me.btnReporteEntrada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReporteEntrada.Name = "btnReporteEntrada"
        Me.btnReporteEntrada.Size = New System.Drawing.Size(151, 126)
        Me.btnReporteEntrada.TabIndex = 3
        Me.btnReporteEntrada.Text = "Reportes de Entrada"
        Me.btnReporteEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporteEntrada.UseVisualStyleBackColor = False
        '
        'btnReporteSalida
        '
        Me.btnReporteSalida.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteSalida.BackgroundImage = CType(resources.GetObject("btnReporteSalida.BackgroundImage"), System.Drawing.Image)
        Me.btnReporteSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReporteSalida.FlatAppearance.BorderSize = 0
        Me.btnReporteSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReporteSalida.ForeColor = System.Drawing.Color.White
        Me.btnReporteSalida.Location = New System.Drawing.Point(609, 134)
        Me.btnReporteSalida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReporteSalida.Name = "btnReporteSalida"
        Me.btnReporteSalida.Size = New System.Drawing.Size(151, 126)
        Me.btnReporteSalida.TabIndex = 4
        Me.btnReporteSalida.Text = "Reportes de Salida"
        Me.btnReporteSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporteSalida.UseVisualStyleBackColor = False
        '
        'btnSalidaProducto
        '
        Me.btnSalidaProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnSalidaProducto.BackgroundImage = CType(resources.GetObject("btnSalidaProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnSalidaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalidaProducto.FlatAppearance.BorderSize = 0
        Me.btnSalidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalidaProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalidaProducto.ForeColor = System.Drawing.Color.White
        Me.btnSalidaProducto.Location = New System.Drawing.Point(406, 134)
        Me.btnSalidaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalidaProducto.Name = "btnSalidaProducto"
        Me.btnSalidaProducto.Size = New System.Drawing.Size(151, 126)
        Me.btnSalidaProducto.TabIndex = 5
        Me.btnSalidaProducto.Text = "Salida de Producto"
        Me.btnSalidaProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalidaProducto.UseVisualStyleBackColor = False
        '
        'btnInventario
        '
        Me.btnInventario.BackColor = System.Drawing.Color.Transparent
        Me.btnInventario.BackgroundImage = CType(resources.GetObject("btnInventario.BackgroundImage"), System.Drawing.Image)
        Me.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInventario.ForeColor = System.Drawing.Color.White
        Me.btnInventario.Location = New System.Drawing.Point(784, 134)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(151, 126)
        Me.btnInventario.TabIndex = 6
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInventario.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(821, 38)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(142, 36)
        Me.btnCerrarSesion.TabIndex = 7
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 44)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Control de Inventario"
        '
        'Inicio_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 404)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.btnSalidaProducto)
        Me.Controls.Add(Me.btnReporteSalida)
        Me.Controls.Add(Me.btnReporteEntrada)
        Me.Controls.Add(Me.btnEntradaProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MS_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MS_Menu
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inicio_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio_Inventario"
        Me.MS_Menu.ResumeLayout(False)
        Me.MS_Menu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MS_Menu As MenuStrip
    Friend WithEvents TSM_Usuarios As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEntradaProducto As Button
    Friend WithEvents btnReporteEntrada As Button
    Friend WithEvents btnReporteSalida As Button
    Friend WithEvents btnSalidaProducto As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label3 As Label
End Class
