Imports System.Drawing
Public Class PointFPolar

    ''' <summary>
    ''' Defaultkonstruktor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Konstruktor, der Polarkoordinaten setzt
    ''' </summary>
    ''' <param name="Radius"></param>
    ''' <param name="PhiInRad"></param>
    ''' <remarks></remarks>
    Public Sub New(Radius As Single, PhiInRad As Single)

        Me.PhiInRad = PhiInRad
        Me.Radius = Radius

    End Sub

    ''' <summary>
    ''' Erstellt aus kartesischen Koordinaten Polarkoordinaten
    ''' </summary>
    ''' <param name="P"></param>
    ''' <remarks></remarks>
    Public Sub New(P As PointF)

        If P.X = 0 And P.Y = 0 Then
            PhiInRad = 0.0
        ElseIf P.X = 0 And P.Y > 0 Then
            PhiInRad = Math.PI / 2.0
        ElseIf P.X < 0 And P.Y = 0 Then
            PhiInRad = Math.PI
        ElseIf P.X = 0 And P.Y < 0 Then
            PhiInRad = 3 * Math.PI / 2.0
        ElseIf P.Y > 0 Then
            PhiInRad = Math.Atan2(P.Y, P.X)
        ElseIf P.Y < 0 Then
            PhiInRad = Math.Atan2(P.Y, P.X) + 2 * Math.PI
        End If

        Radius = Math.Sqrt(P.X * P.X + P.Y * P.Y)

    End Sub

    Public Function ToPointF() As PointF
        Dim P As New PointF

        P.X = Math.Cos(PhiInRad) * Radius
        P.Y = Math.Sin(PhiInRad) * Radius

        Return P
    End Function

    ''' <summary>
    ''' Radius in Bogenmasz
    ''' </summary>
    ''' <remarks></remarks>
    Public PhiInRad As Single

    ''' <summary>
    ''' Radius in Grad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PhiInGrad As Single
        Get
            Return 180.0 * PhiInRad / Math.PI
        End Get
        Set(value As Single)
            PhiInRad = Math.PI * value / 180.0
        End Set
    End Property

    Public Radius As Single



End Class
