Public Class DetalleVenta
    Dim x As Integer
    'Atributos
    Private _compra(19) As Compra
    Private _cantidad As Integer
    Private _precio As Double

    Public Property claveCompra As Integer
        Get
            Return _compra(x).ClaveCompra
        End Get
        Set(value As Integer)
            _compra(x).ClaveCompra = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property
End Class
