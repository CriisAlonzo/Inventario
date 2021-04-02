Public Class Inicio_Inventario
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim login = New LogIn()
        login.Show()
        Me.Dispose()
    End Sub

    Private Sub MS_Menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MS_Menu.ItemClicked
        Select Case e.ClickedItem.ToString()
            Case "Usuarios"
                Dim usuarios = New Usuarios()
                usuarios.Show()
            Case "Proveedores"
                Dim proveedores = New Proveedores()
                proveedores.Show()
            Case "Almacenes"
                Dim almacenes = New Almacenes()
                almacenes.Show()
        End Select
    End Sub

    Private Sub btnEntradaProducto_Click(sender As Object, e As EventArgs) Handles btnEntradaProducto.Click
        Dim entrada_producto = New Entrada_Producto()
        entrada_producto.Show()
    End Sub

    Private Sub btnReporteEntrada_Click(sender As Object, e As EventArgs) Handles btnReporteEntrada.Click
        Dim reportes_entradas = New Reportes_Entradas()
        reportes_entradas.Show()
    End Sub

    Private Sub btnSalidaProducto_Click(sender As Object, e As EventArgs) Handles btnSalidaProducto.Click
        Dim salida_producto = New Salida_Producto()
        salida_producto.Show()
    End Sub

    Private Sub btnReporteSalida_Click(sender As Object, e As EventArgs) Handles btnReporteSalida.Click
        Dim reportes_salidas = New Reportes_Salidas()
        reportes_salidas.Show()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim inventario = New Inventario()
        inventario.Show()
    End Sub
End Class