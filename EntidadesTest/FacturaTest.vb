Imports Entidades
Module FacturaTest


    Sub factura()

        Dim factura As Factura
        Dim professional As Professional



        Try
            professional = New Professional("walter aquino", "3232323")
            factura = New Factura(professional, 1, 2000, "#12/01/2021#")
            factura = New Factura(professional, 2, 3000, "#12/01/2021#")

            For Each item In professional.GetAllFacturas
                Console.WriteLine(item.Professional.Nombre & " " & " " & item.Numero & " " & item.Monto & " " & item.Fecha)

            Next

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Module
