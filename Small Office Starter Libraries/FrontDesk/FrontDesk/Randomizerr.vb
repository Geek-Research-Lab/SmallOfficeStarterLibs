''
'' random id / date
''
' random id
Public Module Randomizerr
    Dim m_m As New Random
    Dim mmm As String = ""
    Public Function RandomID()
        mmm = m_m.Next(1000, 10000).ToString()
        Return mmm
    End Function
    ''
    '' todo : add some more code
    ''
End Module
''
'' ashumeow
''