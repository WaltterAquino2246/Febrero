Imports Entidades
Module EmpresaTest

    Sub empresas()


        Dim departamento As New Departamento("Iguazu")
        Dim departamento1 As New Departamento("Eldorado")

        Dim professional1 As New Professional("Walter aquino", "323232")
        Dim professional2 As New Professional("pepe lopez", "423232")
        Dim factura1 As New Factura(professional1, 1, 2000, "#20/03/2021#")
        Dim factura2 As New Factura(professional2, 2, 1000, "#20/03/2021#")
        Dim jornal As New Jornal("max kellerman", "5422333", 2000, 2, departamento)
        Dim jornal1 As New Jornal("juan loco", "5422333", 2000, 2, departamento1)
        Dim mensual As New Mensual("morro garcia", "2232323", 5000, departamento)
        Empresa.AddProfessional(professional1)
        Empresa.AddDepartamento(departamento)
        Console.WriteLine("Cantidad de empleados:" & " " & Empresa.CantidadEmpleados)
        Console.WriteLine("Total pago:" & " " & Empresa.TotalPagos)

        For Each item In Empresa.GetEmpleados
            Console.WriteLine(item.Nombre)
        Next

        For Each item In Empresa.GetEmpleados(departamento)
            Console.WriteLine(item.Nombre)
        Next













    End Sub

End Module
