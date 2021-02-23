Public Class Departamento

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        _asalariado = New List(Of Asalariado)
    End Sub

    Private _nombre As String

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Nombre invalido! ")
            End If

            If value.Length > 15 Then
                Throw New Exception("Nombre invalido! ")
            End If
            _nombre = value
        End Set
    End Property

    Public Function TotalPago() As Decimal
        Return 0
    End Function

    Private _asalariado As List(Of Asalariado)

    Public Sub AddAsalariado(asalariado As Asalariado)
        _asalariado.Add(asalariado)
    End Sub


    Public Sub RemoveAsalariado(asalariado As Asalariado)
        _asalariado.Remove(asalariado)
    End Sub

    Public Function GetAllasalariados() As List(Of Asalariado)
        Return _asalariado
    End Function

End Class
