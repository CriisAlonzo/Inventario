Public Class LogIn
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        If (txtUsuario.Text = "admin" And txtContrasena.Text = "admin") Then
            MessageBox.Show("Bienvenido al control de inventario!")
            Dim Inicio_Inventario = New Inicio_Inventario()

            Inicio_Inventario.Show()
            Me.Hide()
        Else
            MessageBox.Show("Contraseña o Usuario Incorrecto...")
        End If
    End Sub
End Class
