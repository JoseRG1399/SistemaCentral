Imports System.Data.OleDb
Public Class Form4
    Dim contador As Integer = 0
    Dim conexion As New OleDbConnection
    Dim conexionLocal As New OleDbConnection

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


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this person to all branches?", "Comercializadora saron shekina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            AddInAllStores()
            MsgBox("Clave generada exitosamente en: " & contador & " Sucursales")
        End If

    End Sub

    Private Sub btnAddOnlyOne_Click(sender As Object, e As EventArgs) Handles btnAddOnlyOne.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this person on " & cbbxSucursal.Text & "?", "Comercializadora saron shekina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            AddInOneStoreOnly(cbbxSucursal.Text)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want delete this id?", "Comercializadora saron shekina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DeleteKey()
            MsgBox("Clave eliminada correctamente en: " & contador & " Sucursales")
        End If

    End Sub

    'method that adds salespersons in all branches
    Public Sub AddInAllStores()
        Dim adaptador As New OleDbDataAdapter
        Dim ejecutar As New OleDbCommand
        Dim tabla As New DataTable
        Dim nombre As String = txtNombre.Text
        Dim matricula As String = txtMatricula.Text
        Dim password As Integer = CDec(txtPassword.Text)
        For Each item As Sucursales In sucursalesArray
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + item.getIpDirection + "\Users\Public\Documents\" + item.getNameDB + ".accdb"
            Catch ex As Exception
                MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " + item.getName + ".")
            End Try

            Try
                'Eliminamos un el registro primero para evitar duplicar la informacion
                Try
                    Dim cmd15 As New OleDbCommand
                    cmd15 = New OleDbCommand("delete from Vendedoras where Matrícula='" & txtMatricula.Text & "'", conexion)
                    conexion.Open()
                    cmd15.ExecuteNonQuery()
                    conexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message & "Error al eliminar de: " + item.getName)
                    conexion.Close()

                End Try
                'Ahora agregamos a las vendedoras en su tabla correspondiente
                Try

                    Dim cmd As New OleDbCommand
                    Dim r1 As Integer

                    cmd = New OleDbCommand("INSERT INTO Vendedoras(Matrícula,Nombre,Pass) VALUES('" & matricula & "','" & nombre & "','" & password & "')", conexion)
                    conexion.Open()
                    r1 = cmd.ExecuteNonQuery
                    conexion.Close()
                    contador += 1
                Catch ex As Exception
                    MsgBox("No se pudo agregar la persona en: " + item.getName + MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                    conexion.Close()

                End Try


            Catch ex As Exception

                MsgBox(ex.Message & "Error al agregar vendedora en: " + item.getName)
            End Try
        Next

    End Sub

    'Method that adds saleswomen in a single branch office
    Public Sub AddInOneStoreOnly(branch As String)
        Dim ipDirection
        Dim dbName
        Dim branchName
        Dim id = txtMatricula.Text, name = txtNombre.Text
        Dim password As Integer = CDec(txtPassword.Text)

        For Each item As Sucursales In sucursalesArray
            ipDirection = item.getIpDirection
            dbName = item.getNameDB
            branchName = item.getName
            If branchName.Equals(branch) Then

                Try
                    conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + ipDirection + "\Users\Public\Documents\" + dbName + ".accdb"
                    MsgBox("Conexion exitosa con: " & branchName)

                Catch ex As Exception
                    MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " & branchName & ".")
                End Try
            End If
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Vendedoras(Matrícula,Nombre,Pass) VALUES('" & id & "','" & name & "','" & password & "')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()

            Catch ex As Exception
                MsgBox("No se pudo agregar la persona en: " + branchName + MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                conexion.Close()

            End Try



        Next



    End Sub

    'Method for deleting vendor records 
    Public Sub DeleteKey()
        Dim matricula As String = txtNegativeMatricula.Text
        contador = 0
        For Each item As Sucursales In sucursalesArray
            Try
                conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\" + item.getIpDirection + "\Users\Public\Documents\" + item.getNameDB + ".accdb"
            Catch ex As Exception
                MsgBox("Lo siento, no se pudo establecer la conexión con la sucursal de: " + item.getName + ".")
            End Try
            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Vendedoras where Matrícula='" & matricula & "'", conexion)
                conexion.Open()
                cmd15.ExecuteNonQuery()
                conexion.Close()
                contador += 1
            Catch ex As Exception
                MsgBox(ex.Message & "Error al eliminar de: " + item.getName)
                conexion.Close()

            End Try
        Next
    End Sub


    Public Sub UpdateInformation()

    End Sub

    Public Sub SearchById()

        Dim matricula = txtSearchById.Text
        Dim nombre, password As String

        Try
            conexionLocal.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\CARRANZA.accdb"
        Catch ex As Exception
            MsgBox("Error al establecer conexion con la base de datos local")
        End Try


        Try
            Dim adaptador_combo As OleDbDataAdapter
            Dim buscar_combo As String
            Dim tabla_combo As DataTable

            buscar_combo = "SELECT * FROM Vendedoras Where Matrícula = '" & matricula & "'"
            adaptador_combo = New OleDbDataAdapter(buscar_combo, conexionLocal)
            tabla_combo = New DataTable
            adaptador_combo.Fill(tabla_combo)



        Catch ex As Exception


        End Try



    End Sub

    'Method that closing form2
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Form1).Any() Then
            Form1.Show()
        Else
            ' Form1 ya no está activo.
        End If
    End Sub

    Private Sub btnSearchById_Click(sender As Object, e As EventArgs) Handles btnSearchById.Click
        SearchById()
    End Sub

End Class

