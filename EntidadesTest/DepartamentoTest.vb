Imports Entidades
Module DepartamentoTest

    Sub departamento()

        Dim departamento
        Try
            departamento = New Departamento("")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            departamento = New Departamento("San ignacio")
            Console.WriteLine("departamento: " & departamento.nombre)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

End Module
