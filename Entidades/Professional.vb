Public NotInheritable Class Professional
    Implements Empleado

    Public Sub New(nombre As String, cuit As String)
        Me.Nombre = nombre
        Me.Cuit = cuit
        _factura = New List(Of Factura)
    End Sub


    Private _nombre As String
    Public Property Nombre As String Implements Empleado.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Then
                Throw New Exception("Nombre invalido!")
            End If
            If value.Length > 30 Then
                Throw New Exception("Nombre solo admite 30 caracteres!")
            End If
            _nombre = value
        End Set
    End Property


    Private _cuit As String
    Public Property Cuit() As String
        Get
            Return _cuit
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("cuit invalido!")
            End If

            If value.Length > 11 Then
                Throw New Exception("Cuit invalido!")
            End If
            _cuit = value
        End Set
    End Property


    Public Overrides Function Tostring() As String
        Return Nombre & " " & Cuit
    End Function

    Public Function MontoPago() As Decimal Implements Empleado.MontoPago
        Dim sumatoria As Decimal = 0
        For Each item In _factura
            sumatoria += item.Monto
        Next
        Return sumatoria
    End Function

    Private _factura As List(Of Factura)

    Public Sub AddFactura(factura As Factura)
        _factura.Add(factura)
    End Sub

    Public Sub RemoveFactura(factura As Factura)
        _factura.Remove(factura)
    End Sub

    Public Function GetAllFacturas() As List(Of Factura)
        Return _factura
    End Function






End Class
