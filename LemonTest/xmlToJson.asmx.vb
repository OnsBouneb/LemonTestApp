﻿Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Xml
Imports Newtonsoft.Json

' Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class xmlToJson
    Inherits System.Web.Services.WebService

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