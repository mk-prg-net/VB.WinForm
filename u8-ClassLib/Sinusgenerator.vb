''' <summary>
''' Generator für Sinusfunktionen
''' </summary>
''' <remarks></remarks>
Public Class Sinusgenerator
    Inherits GeneratorBase
    Implements IGenerator

    ''' <summary>
    ''' Schwingungsperioden pro 2Pi
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Frequency As Double = 1.0

    ''' <summary>
    ''' "Ausschlag" der Sinusschwingungen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Amplitude As Double = 1.0

    ''' <summary>
    ''' Erzeugt aus den Eingaben eine X- Achse
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GenerateX(Interval As Interval, SampleCount As Integer) As Double() Implements IGenerator.GenerateX
        Return MyBase.GenerateXImpl(Interval, SampleCount)
    End Function

    ''' <summary>
    ''' Erzeugt aus den Eingaben eine X- Achse
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GenerateY(Interval As Interval, SampleCount As Integer) As Double() Implements IGenerator.GenerateY

        ' Array anlegen, das die X- Achse aufnimmt
        Dim Y(SampleCount - 1) As Double

        ' X- Werte erzeugen
        Dim X() = GenerateX(Interval, SampleCount)

        ' Array mit Daten Füllen
        For i As Integer = 0 To Y.GetUpperBound(0)

            Y(i) = Amplitude * Math.Sin(Frequency * X(i))
        Next
        Return Y
    End Function


    'Public Function GeneratePoints() As Tuple(Of Double, Double)()
    '    Dim X() As Double = GenerateX()
    '    Dim Y() As Double = GenerateY()

    '    Dim p(Count - 1) As Tuple(Of Double, Double)
    '    For i As Integer = 0 To Count - 1
    '        p(i) = New Tuple(Of Double, Double)(X(i), Y(i))
    '    Next

    '    Return p

    'End Function

End Class
