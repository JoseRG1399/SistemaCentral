Imports System.Data.SqlClient

Public Class Recetas
    Dim conexionSQL As New SqlConnection("Data Source=192.168.100.5;Initial Catalog=Almacen;Persist Security Info=True;User ID=Giuseppe1;Password=123456")

    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        AgregarPedidoDataGrid()
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        If MsgBox("¿Deseas subir la receta al sistema de almacen?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then

            If dgRecetas.RowCount <= 0 Then

                MsgBox("Debe haber una receta cargada en la lista")
            Else
                SubirRecetas()
                MsgBox("Receta subida correctamente")
            End If
        End If
    End Sub








    Public Sub SubirRecetas()
        For Each row As DataGridViewRow In dgRecetas.Rows
            Dim producto = row.Cells("Producto").Value.ToString()
            Dim cantidad = row.Cells("Cantidad").Value.ToString()
            Dim receta = row.Cells("Receta").Value.ToString()
            Dim unidad = row.Cells("Unidad").Value.ToString()
            Dim departamento = row.Cells("Departamento").Value.ToString()
            Dim numero = row.Cells("Numero").Value.ToString()

            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Recetas (Producto, Cantidad, Receta, Unidad, Departamento, Numero)VALUES('" & producto & "', '" & cantidad & "', '" & receta & "', '" & unidad & "', '" & departamento & "', '" & numero & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexionSQL.Close()

                Exit Sub
            End Try


        Next


    End Sub

    Public Sub AgregarPedidoDataGrid()
        ' Obtener los valores de los TextBox
        Dim producto As String = txtNombre.Text
        Dim cantidad As String = txtCantidad.Text
        Dim receta As String = txtReceta.Text
        Dim unidad As String = txtUnidad.Text
        Dim departamento As String = txtDepartamento.Text
        Dim numero As String = txtNumero.Text

        'Declarar las columnas en el grid
        If dgRecetas.Columns.Count = 0 Then
            dgRecetas.Columns.Add("Producto", "Producto")
            dgRecetas.Columns.Add("Cantidad", "Cantidad")
            dgRecetas.Columns.Add("Receta", "Receta")
            dgRecetas.Columns.Add("Unidad", "Unidad")
            dgRecetas.Columns.Add("Departamento", "Departamento")
            dgRecetas.Columns.Add("Numero", "Numero")
        End If

        ' Crear una nueva fila y agregar los valores
        Dim nuevaFila As DataGridViewRow = dgRecetas.Rows(dgRecetas.Rows.Add())
        nuevaFila.Cells("Producto").Value = producto
        nuevaFila.Cells("Cantidad").Value = cantidad
        nuevaFila.Cells("Receta").Value = receta
        nuevaFila.Cells("Unidad").Value = unidad
        nuevaFila.Cells("Departamento").Value = departamento
        nuevaFila.Cells("Numero").Value = numero


        dgRecetas.DefaultCellStyle.ForeColor = Color.Black
        dgRecetas.DefaultCellStyle.Font = New Font("Arial", 14, FontStyle.Bold)
        dgRecetas.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow


        ' Limpiar los TextBox después de la inserción
        txtNombre.Text = ""
        txtCantidad.Text = ""
        txtNumero.Text = ""
        txtUnidad.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Consultar_recetas.Show()
        Me.Hide()

    End Sub

    Private Sub Recetas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Form1).Any() Then
            Form1.Show()
        Else
            ' Form1 ya no está activo.
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class