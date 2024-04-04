Public Class Form1

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnNewProducts.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddSeller_Click(sender As Object, e As EventArgs) Handles btnAddSeller.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Choferes.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Cajas.Show()
        Me.Hide()


    End Sub

    Private Sub btnVerificarProductos_Click(sender As Object, e As EventArgs) Handles btnVerificarProductos.Click
        GestionProductos.Show()
        Me.Hide()

    End Sub

    Private Sub btnRecetas_Click(sender As Object, e As EventArgs) Handles btnRecetas.Click
        Recetas.Show()
        Me.Hide()

    End Sub
End Class
