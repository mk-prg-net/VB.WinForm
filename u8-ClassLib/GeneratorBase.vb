''' <summary>
''' Basisklasse aller Generatoren. Implementiert die Erzeugung von X- Werten auf einem 
''' abzutastenden Intervall
''' </summary>
''' <remarks></remarks>
Public Class GeneratorBase

    Public Function GenerateXImpl(Interval As Interval, SampleCount As Integer) As Double()

        ' Array anlegen, das die X- Achse aufnimmt
        Dim X(SampleCount - 1) As Double

        ' Weginkremente berechnen
        Dim weginkrement As Double = Interval.Length / SampleCount

        ' Array mit Daten Füllen
        For i As Integer = 0 To X.GetUpperBound(0)
            ' Kurzform von X(i) = X(i) + weginkrement
            X(i) = i * weginkrement + Interval.BeginInterval
        Next
        Return X
    End Function


End Class
