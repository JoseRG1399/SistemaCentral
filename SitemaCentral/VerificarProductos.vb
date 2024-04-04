Imports System.Data.OleDb

Public Class VerificarProductos
    Private Sub VerificarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaDeProductosCombobox()
    End Sub


    Private conexiones As New List(Of OleDbConnection)
    Dim basesDeDatos As String() = {"ACROPOLIS", "ADOLFO", "ALFREDO", "AERO", "CALIMAYA", "CARRANZA", "COLON", "DEPORTIVA", "FABELA", "LERMA", "METEPEC", "MEXI", "TOTO", "SUAREZ", "SANTIN", "TEC", "TORRES", "XONA", "OCOYOACAC"}
    Dim contadorTablaCaptura, ContadorVentaAlfredo As Integer
    Dim dataTableComb As New DataTable()
    Dim dataTableMergeVentaAlfredo As New DataTable()
    Dim conexion As New OleDbConnection()


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        SimplificarBusqueda()

    End Sub

    Public Sub SimplificarBusqueda()
        Dim nombreProducto = cbbxSelectProducto.Text

        For Each nombreBase As String In basesDeDatos
            Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\{nombreBase}.accdb"

            Using conexion As New OleDbConnection(connectionString)
                Select Case nombreBase
                    Case "ACROPOLIS", "ADOLFO", "ALFREDO", "AERO", "CALIMAYA", "CARRANZA", "COLON", "DEPORTIVA", "FABELA", "LERMA", "METEPEC", "MEXI", "TOTO", "SUAREZ", "SANTIN", "TEC", "TORRES", "XONA", "OCOYOACAC"
                        Try
                            Dim adaptador As New OleDbDataAdapter
                            Dim tabla As New DataTable
                            Dim buscar As String = "SELECT '" & nombreBase & "' AS Sucursal, Producto, Precio, Tasa, Categoría FROM Tabla_captura WHERE Producto = '" & nombreProducto & "'"
                            adaptador = New OleDbDataAdapter(buscar, conexion)
                            adaptador.Fill(tabla)
                            dataTableComb.Merge(tabla)
                            contadorTablaCaptura += 1

                        Catch ex As Exception
                            MsgBox($"{ex.Message} Error al obtener información de: {nombreBase}")
                        End Try

                        Try
                            Dim adaptador As New OleDbDataAdapter
                            Dim tabla As New DataTable
                            Dim buscar As String = "SELECT '" & nombreBase & "' AS Sucursal, Descripción, Precio FROM Venta_Alfredo WHERE Descripción = '" & nombreProducto & "'"
                            adaptador = New OleDbDataAdapter(buscar, conexion)
                            adaptador.Fill(tabla)
                            dataTableMergeVentaAlfredo.Merge(tabla)
                            ContadorVentaAlfredo += 1
                        Catch ex As Exception
                            MsgBox($"{ex.Message} Error al obtener información de: {nombreBase}")
                        End Try
                End Select
            End Using
        Next

        dgVentaAlfredo.DataSource = dataTableMergeVentaAlfredo
        dgBuzones.DataSource = dataTableComb
        dgBuzones.Refresh()
        dgVentaAlfredo.Refresh()
        lblContadorTablaCaptura.Text = " Producto presente en: " & contadorTablaCaptura & " sucursales"
        lblContadorVentaAlfredo.Text = " Producto presente en: " & ContadorVentaAlfredo & " sucursales"


        For Each infoGrid In dgBuzones.Rows
            infoGrid.Height = 50
        Next

        dgBuzones.DefaultCellStyle.ForeColor = Color.Black
        dgBuzones.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dataTableComb.Rows.Clear()
        dgBuzones.Refresh()
        dataTableMergeVentaAlfredo.Rows.Clear()
        dgVentaAlfredo.Refresh()


    End Sub



    Public Sub cargarListaDeProductosCombobox()
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Public\Documents\CARRANZA.accdb"


        Using conexion As New OleDbConnection(connectionString)
            Try

                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String = "SELECT Producto  FROM Tabla_Captura"
                adaptador = New OleDbDataAdapter(buscar, conexion)
                adaptador.Fill(tabla)

                cbbxSelectProducto.DataSource = tabla
                cbbxSelectProducto.DisplayMember = "Producto"


                cbbxSelectProducto.AutoCompleteMode = AutoCompleteMode.Suggest
                cbbxSelectProducto.AutoCompleteSource = AutoCompleteSource.ListItems
                cbbxSelectProducto.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using

    End Sub





End Class