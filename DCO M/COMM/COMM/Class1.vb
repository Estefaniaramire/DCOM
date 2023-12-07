Imports System.Runtime.InteropServices

<Guid("98765432-4321-4321-4321-987654321cba")>
<ClassInterface(ClassInterfaceType.None)>
<ProgId("MyCOMComponent.MyClass")>
Public Class Class1
    Implements IMyCOMInterface

    Private _nombre As String
    Private _apellidos As String
    Private _sexo As String
    Private _edad As Integer

    Public Sub EstablecerNombre(nombre As String)
        _nombre = nombre
    End Sub

    Public Sub EstablecerApellidos(apellidos As String)
        _apellidos = apellidos
    End Sub

    Public Sub EstablecerSexo(sexo As String)
        _sexo = sexo
    End Sub

    Public Sub EstablecerEdad(edad As Integer)
        _edad = edad
    End Sub

    Public Function ObtenerInformacion() As String
        Dim informacion As String = $"Nombre: {_nombre}, Apellidos: {_apellidos}, Sexo: {_sexo}, Edad: {_edad}"
        Return informacion
    End Function

    Public Function MyMethod() As String Implements IMyCOMInterface.MyMethod
        Return "Hola desde el componente COM"
    End Function
End Class
