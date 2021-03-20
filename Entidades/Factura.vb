Public Class Factura

    Public Sub New(professional As Professional, numero As UInt16, monto As Decimal, fecha As Date)
        Me.Numero = numero
        Me.Monto = monto
        Me.Fecha = fecha
        Me.Professional = professional
    End Sub

    Private _numero As UInt16

    Public Property Numero() As UInt16
        Get
            Return _numero
        End Get
        Set(ByVal value As UInt16)

            If value <= 0 Then
                Throw New Exception("Numero invalido!")
            End If
            _numero = value
        End Set
    End Property


    Private _monto As Decimal
    Public Property Monto() As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            If value <= 0 Then
                Throw New Exception("Monto invalido!")
            End If
            _monto = value
        End Set
    End Property

    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            Dim fechaactual = Date.Now

            If value > fechaactual Then
                Console.WriteLine("fecha invalida!")
            End If
            _fecha = value

        End Set
    End Property


    Private _professional As Professional
    Public Property Professional() As Professional
        Get
            Return _professional
        End Get
        Friend Set(ByVal value As Professional)
            value.AddFactura(Me)
            _professional = value
        End Set
    End Property

End Class
