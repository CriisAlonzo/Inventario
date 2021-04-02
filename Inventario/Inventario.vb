Public Class Inventario
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim productos = New Productos()
        productos.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim proveedores = New Proveedores()
        proveedores.Show()
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        Dim almacenes = New Almacenes()
        almacenes.Show()
    End Sub
End Class