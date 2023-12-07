Imports System

Module Module1
    Sub Main()
        Dim myInstance As New COMM.Class1()

        Console.WriteLine("Ingrese el nombre:")
        Dim nombre As String = Console.ReadLine()

        Console.WriteLine("Ingrese los apellidos:")
        Dim apellidos As String = Console.ReadLine()

        Console.WriteLine("Ingrese el sexo:")
        Dim sexo As String = Console.ReadLine()

        Console.WriteLine("Ingrese la edad:")
        Dim edad As Integer = Integer.Parse(Console.ReadLine())

        myInstance.EstablecerNombre(nombre)
        myInstance.EstablecerApellidos(apellidos)
        myInstance.EstablecerSexo(sexo)
        myInstance.EstablecerEdad(edad)

        Dim informacion As String = myInstance.ObtenerInformacion()
        Console.WriteLine("Información establecida:")
        Console.WriteLine(informacion)

        Dim result As String = myInstance.MyMethod()

        Console.WriteLine("Resultado del método MyMethod: " & result)

        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
