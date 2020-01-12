Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorldOns() As String
        Return "Hello World Ons"
    End Function

    <WebMethod()>
    Public Function HelloWorld(j As String
    ) As String
        Return "Hello World" + j
    End Function

    <WebMethod()>
    Public Function Fibo(j As Integer) As Integer

        If (j < 2) Then
            Return j

        End If
        Dim FibArray(2) As Integer
        Dim i As Integer
        FibArray(0) = 0
        FibArray(1) = 1
        For i = 2 To j
            FibArray(1) = FibArray(1) + FibArray(0)
            FibArray(0) = FibArray(1) - FibArray(0)
        Next
        Return FibArray(1)

    End Function



End Class