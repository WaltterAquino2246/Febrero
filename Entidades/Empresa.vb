﻿Public Class Empresa

    Private Shared _departamento As New List(Of Departamento)
    Private Shared _professional As New List(Of Professional)


    Private _CantidadEmpleados As UShort
    Public Shared ReadOnly Property CantidadEmpleados() As UShort
        Get
            Return _departamento.Count + _professional.Count
        End Get
    End Property

    Public Shared Sub AddDepartamento(departamento As Departamento)
        _departamento.Add(departamento)
    End Sub

    Public Shared Sub AddProfessional(professional As Professional)
        _professional.Add(professional)
    End Sub



    Public Shared Function GetEmpleados() As List(Of Empleado)

        Dim _empleados As New List(Of Empleado)

        For Each item In _departamento
            _empleados.Add(item)
        Next
        For Each item In _professional
            _professional.Add(item)
        Next
        Return _empleados
    End Function


    Public Shared Function GetEmpleados(departamento As Departamento) As List(Of Asalariado)
        Return departamento.GetAllasalariados
    End Function



    Public Shared Function TotalPagos() As Decimal

        Dim sumatoria As Decimal = 0

        For Each item In _departamento
            sumatoria += item.TotalPago
        Next
        For Each item In _professional
            sumatoria += item.MontoPago
        Next
        Return sumatoria
    End Function






End Class
