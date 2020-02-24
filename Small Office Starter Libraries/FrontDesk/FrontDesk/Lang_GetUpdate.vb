'
' Get / Update language settings
'
Public Module Lang_GetUpdate
    ' path
    Dim doc As XDocument = XDocument.Load("Resources/show_lang.xml")
    ' fetch
    Public Function Lang_Get()
        Dim fetch_lang As String = ""
        Try
            Dim picker As IEnumerable(Of XElement) = doc.Descendants("language")
            For Each display As XElement In picker
                fetch_lang = display.Element("selected").Value
            Next
            Return fetch_lang
        Catch ex As Exception
            fetch_lang = "error"
            Return fetch_lang
        End Try
    End Function
    ' update
    Public Function Lang_Update(ByVal ReqVal As String)
        Dim update_lang As String = ReqVal.ToString()
        Try
            doc.Descendants("language").Elements("selected").Value = update_lang.ToString()
            doc.Save("Resources/show_lang.xml")
            Return "Thank you. Your request has been updated to " + update_lang.ToString() + ". Kindly 'EXIT' the application and start it again."
        Catch ex As Exception
            update_lang = "error in updating your request."
            Return update_lang
        End Try
    End Function
End Module
''
'' ashumeow
''