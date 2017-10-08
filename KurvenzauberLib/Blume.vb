Public Class Blume
    Inherits Shape

    Dim Rand As System.Collections.Generic.IEnumerable(Of KurvenzauberLib.PointFPolar)

    Public Sub New(Radius As Double, Dynamic As Double, Frequency As Double, CountPoints As Integer)

        Dim Kreis = New Einheitskreis(360)

        Rand = Kreis.Select(Function(P) New PointFPolar(Radius + Dynamic * Math.Sin(Frequency * P.PhiInRad), P.PhiInRad))
        Polygon = Rand.Select(Function(P) P.ToPointF()).ToArray()
    End Sub

    Public Sub Rot(AngleInGrad As Double)
        Dim Prot As New PointFPolar(1.0F, 0.0F)
        Prot.PhiInGrad = AngleInGrad

        Rand = Rand.Select(Function(P) New PointFPolar(P.Radius, P.PhiInRad + Prot.PhiInRad))
        Polygon = Rand.Select(Function(P) P.ToPointF()).ToArray()
    End Sub


    Public Sub Stretch(Dehnung As Double)
        Rand = Rand.Select(Function(P) New PointFPolar(P.Radius * Dehnung, P.PhiInRad))
        Polygon = Rand.Select(Function(P) P.ToPointF()).ToArray()
    End Sub


End Class
