Imports Entidades
Module JornalTest

    Sub jornal()

        Dim jornal As Jornal
        Try
            jornal = New Jornal("", "3232323ç", New Departamento("iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            jornal = New Jornal("walter aquino", "", New Departamento("iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            jornal = New Jornal("walter aquino", "232323", 0, 2, New Departamento("iguazu"))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            jornal = New Jornal("walter aquino", "232323", 200000, 2, New Departamento("iguazu"))
            Console.WriteLine("Nombre:" & jornal.Nombre)
            Console.WriteLine("cuil:" & jornal.Cuil)
            Console.WriteLine("MontoJornada:" & jornal.MontoJornada)
            Console.WriteLine("Dias trabajados :" & jornal.DiasTrabajados)
            Console.WriteLine("Deparatamento :" & jornal.Departamento.Nombre)
            Console.WriteLine("MontoPago:" & jornal.MontoPago)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module