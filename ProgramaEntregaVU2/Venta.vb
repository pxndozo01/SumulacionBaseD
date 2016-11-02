Public Class Venta
    'Declaración de Atributos
    Private _clave As Integer
    Private _cliente As String
    Private _factura As String
    Private _fecha As Date
    Private _total As Integer

    'Declaracion de Metodos Get y Set
    Public Property Clave As Integer
        Get
            Return _clave
        End Get
        Set(value As Integer)
            _clave = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
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

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    'Constructor
    Public Sub New(cve As Integer, clien As String, fact As String, ByVal fech As Date, tot As Integer)
        Clave = cve
        Cliente = clien
        Factura = fact
        Fecha = fech
        Total = tot
    End Sub

End Class
