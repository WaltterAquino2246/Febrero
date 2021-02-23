Imports Entidades
Module ProfessionalTest


    Sub professional()
        Dim professional As Professional


        Try
            professional = New Professional("", "323232")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            professional = New Professional("walter aquino", "")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            professional = New Professional("walter aquino", "323232")
            Console.WriteLine("Nombre: " & professional.Nombre)
            Console.WriteLine("cuit: " & professional.Cuit)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module
