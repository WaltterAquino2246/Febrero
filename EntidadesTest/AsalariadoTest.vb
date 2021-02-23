Imports Entidades
Module AsalariadoTest


    Sub asalariado()


        Dim asalariado As Asalariado

        Try
            asalariado = New Asalariado("", "20323223", New Departamento("Candelaria"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            asalariado = New Asalariado("Walter aquino", "2032322332323232", New Departamento("Candelaria"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            asalariado = New Asalariado("Walter aquino", "20323232", New Departamento("Candelaria"))
            Console.WriteLine("Nombre:" & asalariado.Nombre)
            Console.WriteLine("Cuil:" & asalariado.Cuil)
            Console.WriteLine("Departamento:" & asalariado.Departamento.Nombre)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub

End Module
