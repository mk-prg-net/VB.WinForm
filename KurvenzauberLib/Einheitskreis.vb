Public Class Einheitskreis
    Implements IEnumerable(Of PointFPolar)

    Sub New(CountPoints As Integer)
        Me.CountPoints = CountPoints
    End Sub

    Dim CountPoints As Integer

    '----------------------------------------------------------------------------------------------------
    ' Implementierung der IEnumarable- Schnittstelle
    Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of PointFPolar) Implements System.Collections.Generic.IEnumerable(Of PointFPolar).GetEnumerator
        Return New Enumerator(CountPoints)
    End Function

    Public Function GetEnumerator1() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function


    '---------------------------------------------------------------------------------------------------
    ' Enumeratorklasse, die zur Implementierung der IENumerable- Schnittstelle dient
    Public Class Enumerator
        Implements IEnumerator(Of PointFPolar)

        Dim CountPoints As Integer
        Public Sub New(CountPoints As Integer)
            Me.CountPoints = CountPoints
            dPhi = 2 * Math.PI / CountPoints
            CurrentPhi = -dPhi
        End Sub

        Dim dPhi As Double
        Dim CurrentPhi As Double
        Public ReadOnly Property Current As PointFPolar Implements System.Collections.Generic.IEnumerator(Of PointFPolar).Current
            Get
                Return New PointFPolar(1.0F, CType(CurrentPhi, Single))
            End Get
        End Property

        Public ReadOnly Property Current1 As Object Implements System.Collections.IEnumerator.Current
            Get
                Return Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
            CurrentPhi += dPhi
            Return CurrentPhi <= 2 * Math.PI
        End Function

        Public Sub Reset() Implements System.Collections.IEnumerator.Reset
            CurrentPhi = -dPhi
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' So ermitteln Sie überflüssige Aufrufe

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Verwalteten Zustand löschen (verwaltete Objekte).
                End If

                ' TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalize() unten überschreiben.
                ' TODO: Große Felder auf NULL festlegen.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: Finalize() nur überschreiben, wenn Dispose(ByVal disposing As Boolean) oben über Code zum Freigeben von nicht verwalteten Ressourcen verfügt.
        'Protected Overrides Sub Finalize()
        '    ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(ByVal disposing As Boolean) Bereinigungscode ein.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Dieser Code wird von Visual Basic hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Ändern Sie diesen Code nicht. Fügen Sie oben in Dispose(ByVal disposing As Boolean) Bereinigungscode ein.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Class
