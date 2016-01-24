<Serializable> _
Public Class Kafeezusatz

    'Public Enum KaffezusatzId
    '    Zucker
    '    Milch
    '    Schokolade
    '    Kakau
    '    Chili
    'End Enum

    'Public Sub New(ID As KaffezusatzId)
    '    _ID = ID
    'End Sub

    'Public ReadOnly Property ID As KaffezusatzId
    '    Get
    '        Return _ID
    '    End Get
    'End Property
    'Dim _ID As KaffezusatzId

    Public ReadOnly Property GetMe As Kafeezusatz
        Get
            Return Me
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return ToString()
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return "Kaffezusatz"
    End Function


End Class
