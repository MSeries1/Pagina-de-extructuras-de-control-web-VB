Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contraseña As String
        Dim admin As String = "admin"
        Dim contra As String = "1234"
        Dim intentos As Integer = 0
        Dim maxIntentos As Integer = 3
        Dim acceso As Boolean = False

        Do While intentos < maxIntentos And Not acceso
            usuario = txt_usuario.Text
            contraseña = txt_contraseña.Text

            If usuario = admin AndAlso contraseña = contra Then
                txt_estatus.Text = "Bienvenido."
                acceso = True
            Else
                intentos = intentos + 1
                txt_estatus.Text = "Incorrecto"
            End If
        Loop

    End Sub


End Class
