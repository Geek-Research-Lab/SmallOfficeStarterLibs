''
'' new front desk entry
''
Public Module SubmitDesk
    ' init xml declaration
    Dim doc_root As XDocument
    Dim meowmeow As XElement
    Public Function FD_Submit(ByVal m1 As String, ByVal m2 As String, ByVal m3 As String, ByVal m4 As String,
                              ByVal m5 As String, ByVal m6 As String, ByVal m7 As String, ByVal m8 As String)
        ' m1 - Date / Time
        ' m2 - ID
        ' m3 - Type
        ' m4 - Name
        ' m5 - Email
        ' m6 - Phone
        ' m7 - Other Contact
        ' m8 - Description
        doc_root = XDocument.Load("Resources/frontdesk_.xml")
        meowmeow = doc_root.Element("submit_desk")
        Dim meow As XElement = New XElement("info", New Object() {New XElement("datetime", m1),
                                             New XElement("id", m2), New XElement("type", m3),
                                             New XElement("name", m4), New XElement("email", m5),
                                             New XElement("phone", m6), New XElement("othercontact", m7), New XElement("description", m8)})
        meowmeow.Add(meow)
        doc_root.Save("Resources/frontdesk_.xml")
        Return "Information added. Thank you!"
    End Function
End Module
''
'' ashumeow
''