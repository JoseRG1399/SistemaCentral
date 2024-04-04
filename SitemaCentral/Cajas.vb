Imports System.Data.SqlClient

Public Class Cajas
    Dim conexionSQL As New SqlConnection("Data Source=SERVER;Initial Catalog=Choferes;Persist Security Info=True;User ID=Giuseppe1;Password=123456")

    Private Sub Cajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Public Sub ConsultarInformacion()
        Dim fecha = lblFecha.Text
        Dim hora = lblHora.Text
        ' Dim clasificacion = cbbxTamanios.Text

        Try
            conexionSQL.Open()
            Dim consulta As String = "SELECT Sucursal, SUM(Cantidad) AS Cajas_P25 " &
                                         "FROM [Choferes].[dbo].[Distribución_Pone] " &
                                         "WHERE Clasificación = 'Pastel 25' AND Fecha = '" & fecha & "' " &
                                         "GROUP BY Sucursal"

            Dim cmd As New SqlCommand(consulta, conexionSQL)
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            adaptador.Fill(tabla)
            dgCajas.DataSource = tabla

            For Each infoGrid In dgCajas.Rows
                infoGrid.Height = 50
            Next

            dgCajas.DefaultCellStyle.ForeColor = Color.Black
            dgCajas.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            dgCajas.Columns(0).Width = 90
            dgCajas.RowHeadersVisible = False
            conexionSQL.Close()
            ConsultarInformacionP18()


        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        End Try

    End Sub

    Public Sub ConsultarInformacionP18()
        Dim fecha = lblFecha.Text
        Dim hora = lblHora.Text


        Try
            conexionSQL.Open()
            Dim consulta As String = "SELECT Sucursal, SUM(Cantidad) AS Cajas_P18 " &
                                         "FROM [Choferes].[dbo].[Distribución_Pone] " &
                                         "WHERE Clasificación = 'Pastel 18' AND Fecha = '" & fecha & "' " &
                                         "GROUP BY Sucursal"

            Dim cmd As New SqlCommand(consulta, conexionSQL)
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            adaptador.Fill(tabla)
            dgCajas18.DataSource = tabla

            For Each infoGrid In dgCajas18.Rows
                infoGrid.Height = 50
            Next

            dgCajas18.DefaultCellStyle.ForeColor = Color.Black
            dgCajas18.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            dgCajas18.Columns(0).Width = 90
            dgCajas18.RowHeadersVisible = False
            conexionSQL.Close()
            'printNumeroCajas.Print()

        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblHora.Text = TimeString
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        ConsultarInformacion()
    End Sub

    Private Sub printNumeroCajas_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printNumeroCajas.PrintPage
        Dim i1 As Integer = 0

        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        Dim prFont10 As New Font("Arial", 8, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 0)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 15)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 30)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 45)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 60)
        e.Graphics.DrawString("Departartamento: Almacen", prFont2, Brushes.Black, 0, 75)
        e.Graphics.DrawString("REPORTE DE CAJAS POR SUCURSAL", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("Responsable: Leticia", prFont2, Brushes.Black, 10, 105)
        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 120)
        e.Graphics.DrawString(lblFecha.Text, prFont2, Brushes.Black, 55, 120)


        While i1 < dgCajas.RowCount
            e.Graphics.DrawString(dgCajas.Item(0, i1).Value, prFont10, Brushes.Black, 0, i1 * 15 + 140)
            e.Graphics.DrawString(dgCajas.Item(1, i1).Value, prFont10, Brushes.Black, 125, i1 * 15 + 140)
            i1 += 1
        End While





    End Sub
End Class