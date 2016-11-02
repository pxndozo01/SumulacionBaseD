Public Class Compra
    Private _claveCompra As Integer
    Private _proveedor As String
    Private _factura As String
    Private _fechaCompra As Date
    Private _totalCompra As Integer

    Public Property ClaveCompra As Integer
        Get
            Return _claveCompra
        End Get
        Set(value As Integer)
            _claveCompra = value
        End Set
    End Property

    Public Property Proveedor As String
        Get
            Return _proveedor
        End Get
        Set(value As String)
            _proveedor = value
        End Set
    End Property

    Public Property Factura As String
        Get
            Return _factura
        End Get
        Set(value As String)
            _factura = value
        End Set
    End Property

    Public Property FechaCompra As Date
        Get
            Return _fechaCompra
        End Get
        Set(value As Date)
            _fechaCompra = value
        End Set
    End Property

    Public Property TotalCompra As Integer
        Get
            Return _totalCompra
        End Get
        Set(value As Integer)
            _totalCompra = value
        End Set
    End Property

    Public Sub New(ByVal cve As Integer, ByVal prov As String, ByVal fac As String, ByVal fch As Date, ByVal tot As Integer)
        _claveCompra = cve
        _proveedor = prov
        _factura = fac
        _fechaCompra = fch
        _totalCompra = tot
    End Sub
End Class
