Public Class SternePlanetenMondeDeco

    ' Typisch für Dekorator: auf zu dekorierendes Objekt wird 
    ' verwiesen
    Dim _spm As KeplerDB.Sterne_Planeten_MondeTab

    Public Sub New(spm As KeplerDB.Sterne_Planeten_MondeTab)
        _spm = spm
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _spm.HimmelskoerperTab.Name
        End Get
    End Property

    Public ReadOnly Property Typ As String
        Get
            Return _spm.HimmelskoerperTab.HimmelskoerperTypenTab.Name
        End Get
    End Property

    Public ReadOnly Property Durchmesser As Double
        Get
            Return _spm.Aequatordurchmesser_in_km
        End Get
    End Property

End Class
