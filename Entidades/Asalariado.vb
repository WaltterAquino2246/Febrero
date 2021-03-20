Public Class Asalariado
    Implements Empleado

    Public Sub New(nombre As String, cuil As String, departamento As Departamento)
        Me.Nombre = nombre
        Me.Cuil = cuil
        Me.Departamento = departamento
    End Sub

    Private _cuil As String
    Public Property Cuil() As String
        Get
            Return _cuil
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("cuil invalido!")
            End If

            If value.Length > 11 Then
                Throw New Exception("Cuil invalido!")
            End If
            _cuil = value
        End Set
    End Property


    Private _departamento As Departamento
    Public Property Departamento() As Departamento
        Get
            Return _departamento
        End Get
        Friend Set(ByVal value As Departamento)
            value.AddAsalariado(Me)
            _departamento = value
        End Set
    End Property

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

    Public Overrides Function Tostring() As String
        Return Nombre & " " & Cuil
    End Function

    Public Overridable Function MontoPago() As Decimal Implements Empleado.MontoPago
        Throw New NotImplementedException()
    End Function
End Class
