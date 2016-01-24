''' <summary>
''' Generator, der aus der überlagerung der Ausgänge mehrerer Generatoren
''' (Superposition) ein Signal erzeugt
''' </summary>
''' <remarks></remarks>
Public Class Superposition
    Inherits GeneratorBase
    Implements IGenerator


    Private _Generatoren() As IGenerator
    ''' <summary>
    ''' Konstruktor
    ''' </summary>
    ''' <param name="Generatoren">Generatoren, deren Signale überlagert werden sollen</param>
    ''' <remarks></remarks>
    Public Sub New(ParamArray Generatoren() As IGenerator)
        _Generatoren = Generatoren
    End Sub


    Public Function GenerateX(Interval As Interval, SampleCount As Integer) As Double() Implements IGenerator.GenerateX
        Return MyBase.GenerateXImpl(Interval, SampleCount)
    End Function

    Public Function GenerateY(Interval As Interval, SampleCount As Integer) As Double() Implements IGenerator.GenerateY
        Dim sup(SampleCount) As Double

        For Each gen In _Generatoren
            Dim y = gen.GenerateY(Interval, SampleCount)
            For i As Integer = 0 To SampleCount - 1
                sup(i) += y(i)
            Next
        Next

        Return sup

    End Function


End Class
