Imports System.Data.SqlClient

Public Class Form2

    'Arreglo de sucursales para nombrar los refgistros de las consultas
    Dim sucursalesArray = New Sucursales() {
          New Sucursales("192.168.125.2", "ACROPOLIS", "Acropolis"),
        New Sucursales("192.168.139.2", "ADOLFO", "Adolfo"),
        New Sucursales("192.168.123.2", "AERO", "Aeropuerto"),
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
         New Sucursales("192.168.140.4", "FOGON", "Fogon")}


    'Boton para probar conexion en sucursales
    Private Sub btnConexion_Click(sender As Object, e As EventArgs) Handles btnConexion.Click

        For Each item As Sucursales In sucursalesArray
            Dim etiqueta = item.getName
            Try
                Dim conexionSQL As New SqlConnection("Data Source=" + item.getIpDirection + ";Initial Catalog=Ventas;Persist Security Info=True;User ID=Giuseppe1;Password=123456")

                Try
                    conexionSQL.Open()
                    labelsColorsGreen(item.getName)
                    conexionSQL.Close()
                Catch ex As Exception
                    labelsColorsRed(item.getName)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message & "Algo ocurrio al conectar con:")
            End Try
        Next

    End Sub

    'Metodo que pinta de verde las sucursales si estas estan conectadas
    Private Sub labelsColorsGreen(label As String)
        Dim labelDict As New Dictionary(Of String, Label) From {
       {"Acropolis", lblAcropolis},
       {"Adolfo", lblAdolfo},
       {"Aeropuerto", lblAeropuerto},
       {"Alfredo", lblAlfredo},
       {"Calimaya", lblCalimaya},
       {"Carranza", lblCarranza},
       {"Colon", lblColon},
       {"Deportiva", lblDeportiva},
       {"Fabela", lblFabela},
       {"Lerma", lblLerma},
       {"Metepec", lblMetepec},
       {"Mexicaltzingo", lblMexicaltzingo},
       {"Moderna", lblModerna},
       {"Ocoyoacac", lblOcoyoacac},
       {"Santin", lblSantin},
       {"Pino Suarez", lblPinoSuarez},
       {"Tecnologico", lblTecnologico},
       {"Torres", lblTorres},
       {"Xonacatlan", lblXonacatlan},
       {"Fogon", lblFogon}
   }

        If labelDict.ContainsKey(label) Then
            labelDict(label).BackColor = Color.Green
        Else

        End If

    End Sub

    'Metodo que pinta de rojo las sucursales si no estas estan conectadas
    Private Sub labelsColorsRed(label As String)
        Dim labelDict As New Dictionary(Of String, Label) From {
       {"Acropolis", lblAcropolis},
       {"Adolfo", lblAdolfo},
       {"Aeropuerto", lblAeropuerto},
       {"Alfredo", lblAlfredo},
       {"Calimaya", lblCalimaya},
       {"Carranza", lblCarranza},
       {"Colon", lblColon},
       {"Deportiva", lblDeportiva},
       {"Fabela", lblFabela},
       {"Lerma", lblLerma},
       {"Metepec", lblMetepec},
       {"Mexicaltzingo", lblMexicaltzingo},
       {"Moderna", lblModerna},
       {"Ocoyoacac", lblOcoyoacac},
       {"Santin", lblSantin},
       {"Pino Suarez", lblPinoSuarez},
       {"Tecnologico", lblTecnologico},
       {"Torres", lblTorres},
       {"Xonacatlan", lblXonacatlan},
       {"Fogon", lblFogon}
   }

        If labelDict.ContainsKey(label) Then
            labelDict(label).BackColor = Color.Red
        Else

        End If

    End Sub

    'Method that closing form2
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Application.OpenForms().OfType(Of Form1).Any() Then
            Form1.Show()
        Else
            ' Form1 ya no está activo.
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
