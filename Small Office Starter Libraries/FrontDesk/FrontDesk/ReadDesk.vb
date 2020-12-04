''
'' old unused file
''

''
'' read front desk entries
''
Public Module ReadDesk
    ''
    '' get information data
    ''
    'Public read_doc_dir As XDocument = XDocument.Load("Resources/dir.xml")
    '' dir
    'Dim final_doc_dir As IEnumerable(Of XElement) = read_doc_dir.Descendants("directory")
    'Dim display As XElement = final_doc_dir
    'Dim mo_mo As String = display.Element("show").Value
    'Public mm As String = mo_mo.ToString() + "\Resources\frontdesk_.xml"
    '' load root
    Public read_doc_root As XDocument = XDocument.Load("Resources/frontdesk_.xml")
    Dim read_doc_element As XElement = read_doc_root.Element("submit_desk")
    Dim final_read As IEnumerable(Of XElement)
    Public mq As String
    Public i, mqq, abc As Integer
    Public mq0 As String
    Public Function GetDeskInfo(mval As String)
        ''enquiries
        If mval.Equals("e") Then
            Try
                final_read = read_doc_element.Descendants("info").Where(Function(enq As XElement) enq.Element("type").Value = "Enquiry".ToString())
                mqq = final_read.Count
                abc = mqq
                i = 0
                For Each read_now As XElement In final_read
                    If i <= mqq Then
                        mq0 = (read_now.Element("datetime").Value + ";" +
                        read_now.Element("id").Value + ";" +
                    read_now.Element("name").Value + ";" +
                    read_now.Element("email").Value + ";" +
                    read_now.Element("phone").Value + ";" +
                    read_now.Element("othercontact").Value + ";" +
                    read_now.Element("description").Value).ToString()
                        mq = mq + "------" + mq0 + "~~~~~~~~" + mqq.ToString() + "[[[[" + "count: " + abc.ToString()
                        abc = mqq - 1
                        i += i + 1
                    Else
                        lo_lo(mq)
                        Return mq
                    End If
                Next
                'mq = mq + "---" + "count: " + mqq.ToString()
            Catch ex As Exception
                mq = ex.ToString()
            End Try
            '' interviewees
        ElseIf mval.Equals("i") Then
            ''
            '' TODO: add some code
            ''
            Try

            Catch ex As Exception

            End Try
            '' visitors
        ElseIf mval.Equals("v") Then
            ''
            '' TODO: add some code
            ''
            Try

            Catch ex As Exception

            End Try
            '' contacts
        ElseIf mval.Equals("c") Then
            ''
            '' TODO: add some code
            ''
            Try

            Catch ex As Exception

            End Try
            '' report
        ElseIf mval.Equals("r") Then
            ''
            '' TODO: add some code
            ''
            Try

            Catch ex As Exception

            End Try
            '' ???
        Else
            ''
            '' TODO: add some code
            ''
        End If
        ' returns value
        'Return mq
    End Function
    ''
    '' get settings information
    ''
    Public Function GetDeskSettings(mmval As String)
        '' change appearance
        If mmval.Equals("c_a") Then
            ''
            '' TODO: add some code
            ''

            '' language
        ElseIf mmval.Equals("l") Then
            ''
            '' TODO: add some code
            ''

            '' company information
        ElseIf mmval.Equals("y_c_i") Then
            ''
            '' TODO: add some code
            ''

            '' about software
        ElseIf mmval.Equals("a_s") Then
            ''
            '' TODO: add some code
            ''

            '' quit
        ElseIf mmval.Equals("ex") Then
            ''
            '' TODO: add some code
            ''

            '' ???
        Else
            ''
            '' TODO: add some code
            ''
        End If
    End Function
End Module
''
'' ashumeow
''