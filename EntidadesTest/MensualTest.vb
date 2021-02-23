Imports Entidades
Module MensualTest

    Sub mensual()

        Dim mensual As Mensual


        Try
            mensual = New Mensual("", "34343434", 2000, New Departamento("Iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            mensual = New Mensual("walter aquino", "", 2000, New Departamento("Iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            mensual = New Mensual("walter aquino", "3232323", 0, New Departamento("Iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Try
            mensual = New Mensual("walter aquino", "3232323", 100000, New Departamento("Iguazu"))
            Console.WriteLine("Nombre:" & mensual.Nombre)
            Console.WriteLine("cuil:" & mensual.Cuil)
            Console.WriteLine("sueldo:" & mensual.Sueldo)
            Console.WriteLine("departamento:" & mensual.Departamento.Nombre)



        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module
