Imports System
Imports System.Data

Module Program
    Sub Main(args As String())
        Console.ForegroundColor = ConsoleColor.Green
        _Interface()
    End Sub

    Function Calculos(_input As String) As Double
        Dim result As Double = New DataTable().Compute(_input, Nothing)

        Return result

    End Function

    Sub _Interface()
        Console.Clear()
        Dim _logoCalc As String
        _logoCalc =
        "
 ██████  █████  ██       ██████ ██    ██ ██       █████  ████████  ██████  ██████  
██      ██   ██ ██      ██      ██    ██ ██      ██   ██    ██    ██    ██ ██   ██ 
██      ███████ ██      ██      ██    ██ ██      ███████    ██    ██    ██ ██████  
██      ██   ██ ██      ██      ██    ██ ██      ██   ██    ██    ██    ██ ██   ██ 
 ██████ ██   ██ ███████  ██████  ██████  ███████ ██   ██    ██     ██████  ██   ██ 
                                                                                   
                                                                                   
        " +
        "[+] Soma [/] Divisão [*] Multiplicação [-] Subtração etc...
        ((2+2 1º prioridade)+2 2ª prioridade) etc...
        /exit para sair"


        Console.WriteLine(_logoCalc)
        Do
            Console.Write(">")
            Dim _input As String = Console.ReadLine()
            If _input = "/exit" Then Exit Do

            Dim calc As Double = Calculos(_input)
            Console.WriteLine(">" + calc.ToString)
        Loop



    End Sub


End Module

