Imports System.Collections.Generic
Imports System.Xml
Imports System.Xml.Linq

Public NotInheritable Class XMLHelper
    Private Sub New()
    End Sub

    Public Shared Function BuildXMLRequest(dictionary As Dictionary(Of String, Object), containerTag As String) As XDocument
        Dim tStream = New Dictionary(Of String, Object)()
        tStream.Add(containerTag, dictionary)
        Return XMLHelper.ToXml(tStream, "TStream")
    End Function

    Public Shared Function ParseXMLResponse(xmlResponse As String) As Dictionary(Of String, String)
        Dim dictionary As New Dictionary(Of String, String)()
        Dim doc As New XmlDocument()
        doc.LoadXml(xmlResponse)
        TraverseNodes(doc.ChildNodes, dictionary)
        Return dictionary
    End Function

    Private Shared Function ToXml(dictionary As Dictionary(Of String, Object), rootElementName As String) As XDocument
        Dim doc = New XDocument()
        Dim dataRoot = New XElement(rootElementName)
        Dim containerList = New List(Of String)()

        For Each kvp As KeyValuePair(Of String, Object) In dictionary
            dataRoot.Add(SerializeKVP(kvp))
        Next

        doc.Add(dataRoot)
        Return doc
    End Function

    Private Shared Function SerializeKVP(kvp As KeyValuePair(Of String, Object)) As XElement
        Dim xElem = New XElement(kvp.Key)
        If TypeOf kvp.Value Is Dictionary(Of String, Object) Then
            For Each key As KeyValuePair(Of String, Object) In TryCast(kvp.Value, Dictionary(Of String, Object))
                xElem.Add(SerializeKVP(key))
            Next
        Else
            If TypeOf kvp.Value Is Decimal Then
                xElem.Value = If(kvp.Value Is Nothing, String.Empty, CDec(kvp.Value).ToString("0.00"))
            ElseIf TypeOf kvp.Value Is Double Then
                xElem.Value = If(kvp.Value Is Nothing, String.Empty, CDbl(kvp.Value).ToString("0.00"))
            ElseIf TypeOf kvp.Value Is Single Then
                xElem.Value = If(kvp.Value Is Nothing, String.Empty, CSng(kvp.Value).ToString("0.00"))
            Else
                xElem.Value = If(kvp.Value Is Nothing, String.Empty, kvp.Value.ToString())
            End If
        End If

        Return xElem
    End Function

    Private Shared Sub TraverseNodes(nodes As XmlNodeList, dict As Dictionary(Of String, String))
        For Each node As XmlNode In nodes
            If node.HasChildNodes Then
                TraverseNodes(node.ChildNodes, dict)
            Else
                If node.NodeType = XmlNodeType.Text AndAlso Not dict.ContainsKey(node.ParentNode.Name) Then
                    dict.Add(node.ParentNode.Name, node.InnerText)
                End If
            End If
        Next
    End Sub
End Class
