Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Xml
Imports System.Web.Http

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class Fibonacci
    Inherits System.Web.Services.WebService

    Public Property JsonConvert As Object

    <WebMethod()>
    Public Function Fibonacci(j As Integer) As Integer
        If (Not (j < 0 Or j > 100)) Then

            If (j < 2) Then
                Return j

            End If
            Dim FibArray(900) As Integer
            Dim i As Integer
            FibArray(0) = 0
            FibArray(1) = 1
            For i = 2 To j
                FibArray(1) = FibArray(1) + FibArray(0)
                FibArray(0) = FibArray(1) - FibArray(0)
            Next
            Return FibArray(1)
        Else
            Return -1
        End If
    End Function

    <WebMethod()>
    Public Function XmlToJson(xml As String) As String


        Dim doc As XmlDocument
        doc.LoadXml("<foo>bar</foo>")
        Dim json As String
        Dim jsonVar As Object = JsonConvert.SerializeXmlNode(doc)
        json = jsonVar
        Return json

    End Function


End Class