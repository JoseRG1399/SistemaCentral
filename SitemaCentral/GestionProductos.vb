Imports System.Data.OleDb

Public Class GestionProductos

    Dim conexion, conexionLocal As New OleDbConnection
    Dim contador As Integer
    'Branches Array
    Dim sucursalesArray = New Sucursales() {
           New Sucursales("192.168.125.2", "ACROPOLIS", "Acropolis"),
        New Sucursales("192.168.139.2", "ADOLFO", "Adolfo"),
        New Sucursales("192.168.123.2", "AERO", "Aero"),
        New Sucursales("192.168.121.2", "ALFREDO", "Alfredo"),
        New Sucursales("192.168.138.2", "CARRANZA", "Carranza"),
        New Sucursales("192.168.128.2", "COLON", "Colon"),
        New Sucursales("192.168.137.2", "LERMA", "Lerma"),
        New Sucursales("192.168.130.2", "METEPEC", "Metepec"),
        New Sucursales("192.168.136.2", "MEXI", "Mexicaltzingo"),
        New Sucursales("192.168.133.2", "SUAREZ", "Pino Suarez"),
         New Sucursales("192.168.129.2", "TEC", "Tecnologico"),
         New Sucursales("192.168.127.2", "TORRES", "Torres"),
         New Sucursales("192.168.131.2", "DEPORTIVA", "Deportiva"),
         New Sucursales("192.168.135.2", "CALIMAYA", "Calimaya"),
         New Sucursales("192.168.126.2", "FABELA", "Fabela"),
         New Sucursales("192.168.132.2", "TOTO", "Moderna"),
         New Sucursales("192.168.124.2", "SANTIN", "Santin"),
         New Sucursales("192.168.140.2", "OCOYOACAC", "Ocoyoacac"),
         New Sucursales("192.168.134.2", "XONA", "Xonacatlan"),
         New Sucursales("192.168.140.4", "FOGON", "Fogon")
    }

    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerConexion()
        ConsultarProductosLocales()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateAllStores()
    End Sub

    Public Sub UpdateAllStores()
        Dim adaptador As New OleDbDataAdapter
        Dim ejecutar As New OleDbCommand
        Dim tabla As New DataTable
        Dim categoria As String = cbbxCategoria.Text
        Dim clasificacion = cbbxClasificacion.Text
        Dim producto = cbbxProducto.Text
        For Each item As Sucursales In sucursalesArray
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + item.getIpDirection + "\Users\Public\Documents\" + item.getNameDB + ".accdb"
            Catch ex As Exception
                MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " + item.getName + ".")
            End Try

            Try
                Dim str1 As String
                str1 = "UPDATE [Tabla_Captura] SET [Categoría]='" & categoria & "' WHERE Producto = '" & producto & "'"
                Dim cmd5 As OleDbCommand = New OleDbCommand(str1, conexion)
                conexion.Open()
                cmd5.ExecuteNonQuery()
                conexion.Close()

                MsgBox("¡Datos actualizados correctamente!")
            Catch ex As Exception
                conexionLocal.Close()
                MsgBox(ex.Message & "Error al actualizar la informacion en la tabla: Tabla_Captura")
            End Try

            Try
                Dim str1 As String
                str1 = "UPDATE [Venta_Alfredo] SET [Categoría]='" & categoria & "', Clasificación = '" & clasificacion & "' WHERE Descripción = '" & producto & "'"
                Dim cmd5 As OleDbCommand = New OleDbCommand(str1, conexion)
                conexion.Open()
                cmd5.ExecuteNonQuery()
                conexion.Close()

                MsgBox("¡Datos actualizados correctamente!")
            Catch ex As Exception
                conexionLocal.Close()
                MsgBox(ex.Message & "Error al actualizar la informacion en la tabla: Venta_Alfredo")
            End Try
            MsgBox("Informacion actualizada en : " & item.getName)
            contador += 1
        Next
        MsgBox("Informacion actualizada en : " & contador & " tiendas")
    End Sub

    Public Sub ConsultarProductosLocales()
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String = $"SELECT Producto FROM Tabla_Captura"
            adaptador = New OleDbDataAdapter(buscar, conexionLocal)
            adaptador.Fill(tabla)

            cbbxProducto.DataSource = tabla
            cbbxProducto.DisplayMember = "Producto"


            cbbxProducto.AutoCompleteMode = AutoCompleteMode.Suggest
            cbbxProducto.AutoCompleteSource = AutoCompleteSource.ListItems
            cbbxProducto.Text = ""

        Catch ex As Exception
            MsgBox($"{ex.Message} Error al obtener información del supervisor")
        End Try

    End Sub

    Public Sub EstablecerConexion()
        Try
            conexionLocal.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\CARRANZA.accdb"
        Catch ex As Exception
            MsgBox("Error al establecer conexion con la base de datos local")
        End Try
    End Sub

End Class