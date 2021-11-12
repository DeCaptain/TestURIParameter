Imports System
Imports System.Windows
Imports System.Drawing

Public Class Program

    Public Shared Sub Main(ByVal args() As String)

        If args.Length > 0 Then
            For argsnum As Integer = 0 To UBound(args, 1)
                Console.WriteLine(args(argsnum).ToString() & Environment.NewLine())

            Next

        Else
            Console.WriteLine("argument is empty!")

        End If

        Console.Read()

    End Sub


End Class
