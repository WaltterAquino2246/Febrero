Public Class Jornal

    Inherits Asalariado


    Public Sub New(nombre As String, cuil As String, departamento As Departamento)
        MyBase.New(nombre, cuil, departamento)
    End Sub


    Public Sub New(nombre As String, cuil As String, montojornada As Decimal, diastrabajados As UShort, departamento As Departamento)
        Me.New(nombre, cuil, departamento)
        Me.DiasTrabajados = diastrabajados
        Me.MontoJornada = montojornada
    End Sub



    Private _diastrabajados As UShort
    Public Property DiasTrabajados() As UShort
        Get
            Return _diastrabajados
        End Get
        Set(ByVal value As UShort)
            If value <= 0 Then
                Throw New Exception("Numero invalido!")
            End If
            _diastrabajados = value
        End Set
    End Property


    Private _montojornada As Decimal
    Public Property MontoJornada() As Decimal
        Get
            Return _montojornada
        End Get
        Set(ByVal value As Decimal)
            If value <= 0 Then
                Throw New Exception("sueldo invalido!")
            End If
            _montojornada = value
        End Set
    End Property

    Public Overloads Function MontoPago() As Decimal

        Return DiasTrabajados * MontoJornada
    End Function


End Class
