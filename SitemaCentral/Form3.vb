Imports System.Data.OleDb

Public Class Form3
    Dim conexion As New OleDbConnection
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







    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        For Each item As Sucursales In sucursalesArray
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + item.getIpDirection + "\Users\Public\Documents\" + item.getNameDB + ".accdb"
            Catch ex As Exception
                MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " + item.getName + ".")
            End Try

            Try
                'Aqui van las consultas pertinentes para los productos



            Catch ex As Exception

                MsgBox(ex.Message & "Error al agregar vendedora en: " + item.getName)
            End Try
        Next
    End Sub



    Public Sub updatePices()
        Dim str1 As String
        For Each item As Sucursales In sucursalesArray
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + item.getIpDirection + "\Users\Public\Documents\" + item.getNameDB + ".accdb"
            Catch ex As Exception
                MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " + item.getName + ".")
            End Try

            Try
                str1 = "update [Tabla_captura] set [Clasificación]='" & txtUpdate.Text & "'where [Producto]='" & cbbProducts.Text & "'"
                Dim cmd5 As OleDbCommand = New OleDbCommand(str1, conexion)
                conexion.Open()
                cmd5.ExecuteNonQuery()
                conexion.Close()



            Catch ex As Exception

                MsgBox(ex.Message & "Error al agregar vendedora en: " + item.getName)
            End Try
        Next


    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Close()
    End Sub
    'Metodo para finalizar la aplicacion
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Form1).Any() Then
            Form1.Show()
        Else
            ' Form1 ya no está activo.
        End If
    End Sub
End Class