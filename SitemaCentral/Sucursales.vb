Public Class Sucursales




    Public ipDirection As String
    Public nameSucursal As String
    Public nameDataBase As String

    Public Sub New(_ipDirection As String, _dbName As String, _sucuralName As String)
        ipDirection = _ipDirection
        nameSucursal = _sucuralName
        nameDataBase = _dbName
    End Sub


    Public Property getName() As String
        Get
            Return nameSucursal
        End Get
        Set(value As String)
            nameSucursal = value
        End Set
    End Property

    Public Property getIpDirection() As String
        Get
            Return ipDirection
        End Get
        Set(value As String)
            ipDirection = value
        End Set
    End Property
    Public Property getNameDB() As String
        Get
            Return nameDataBase
        End Get
        Set(value As String)

        End Set
    End Property


End Class
