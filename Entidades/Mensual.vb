Public Class Mensual

    Inherits Asalariado

    Public Sub New(nombre As String, cuil As String, sueldo As Decimal, departamento As Departamento)
        MyBase.New(nombre, cuil, departamento)
        Me.Sueldo = sueldo
    End Sub


    Private _sueldo As Decimal
    Public Property Sueldo() As Decimal
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Decimal)
            If value <= 0 Then
                Throw New Exception("sueldo invalido!")
            End If
            _sueldo = value
        End Set
    End Property


    Public Overrides Function MontoPago() As Decimal

        Return Sueldo
    End Function

End Class
