''
'' old unused file
''

Public Module ListDirectory
    Dim m_doc As XDocument = XDocument.Load("Resources/dir.xml")
    Public Function lo_lo(ByVal m As String)
        Try
            m_doc.Descendants("directory").Elements("show").Value = m.ToString()
            m_doc.Save("Resources/dir.xml")
            Return "Welcome!"
        Catch ex As Exception
            Return "error in updating your request."
        End Try
    End Function
End Module
''
'' ashumeow
''