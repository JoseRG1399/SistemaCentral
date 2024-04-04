Imports System.Data.SqlClient

Public Class Consultar_recetas
    Private Sub Consultar_recetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDepartamentosCBBX()
    End Sub
    Dim conexionSQL As New SqlConnection("Data Source=192.168.100.5;Initial Catalog=Almacen;Persist Security Info=True;User ID=Giuseppe1;Password=123456")




    Public Sub CargarDepartamentosCBBX()
        Try
            Dim adaptador As New SqlDataAdapter
            Dim dt As New DataTable


            adaptador = New SqlDataAdapter("SELECT DISTINCT  Departamento FROM Recetas", conexionSQL)

            adaptador.Fill(dt)
            cbbxDepartamentos.DataSource = dt
            cbbxDepartamentos.DisplayMember = "Departamento"


            cbbxDepartamentos.AutoCompleteMode = AutoCompleteMode.Suggest
            cbbxDepartamentos.AutoCompleteSource = AutoCompleteSource.ListItems
            cbbxDepartamentos.Text = ""

        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargarRecetasCombobox()
        Dim departamento = cbbxDepartamentos.Text

        Try
            Dim adaptador As New SqlDataAdapter
            Dim dt As New DataTable


            adaptador = New SqlDataAdapter("SELECT DISTINCT  Receta FROM Recetas WHERE Departamento='" & departamento & "'", conexionSQL)

            adaptador.Fill(dt)
            cbbxSelectRecetas.DataSource = dt
            cbbxSelectRecetas.DisplayMember = "Receta"


            cbbxSelectRecetas.AutoCompleteMode = AutoCompleteMode.Suggest
            cbbxSelectRecetas.AutoCompleteSource = AutoCompleteSource.ListItems
            cbbxSelectRecetas.Text = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Recetas.Show()
        Me.Hide()

    End Sub

    Private Sub cbbxDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbxDepartamentos.SelectedIndexChanged
        cargarRecetasCombobox()
    End Sub


    Public Sub agregarPedido()
        Dim nombreReceta = cbbxSelectRecetas.Text
        Dim departamento = cbbxDepartamentos.Text
        Try
            Dim Adaptador11 As New SqlDataAdapter
            Dim tabla11 As New DataTable
            Dim buscar11 As String
            buscar11 = ("SELECT * FROM Recetas WHERE Departamento = '" & departamento & "' AND Receta='" & nombreReceta & "' ORDER BY Numero ASC")
            Adaptador11 = New SqlDataAdapter(buscar11, conexionSQL)
            tabla11 = New DataTable
            Adaptador11.Fill(tabla11)
            dgRecetas.DataSource = tabla11

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        agregarPedido()
    End Sub

    Private Sub Consultar_recetas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Form1).Any() Then
            Form1.Show()
        Else
            ' Form1 ya no está activo.
        End If
    End Sub
End Class