Public Class ColorItem

    Public Property Red As Byte

    Public Property Green As Byte

    Public Property Blue As Byte


    Private Function IntensityToPercent(intensity As Integer) As Double

        ' 0% -> 0, 100% -> 255
        Return (intensity * 100.0) / 255.0

    End Function

    Private Function ColorPercentName(Colorname As String, Percent As Double) As String

        Return Colorname & CInt(Percent).ToString("D3") & " "

    End Function

    Public ReadOnly Property ColorName As String
        Get
            Return ColorPercentName("R", IntensityToPercent(Red)) & _
                    ColorPercentName("G", IntensityToPercent(Green)) & _
                    ColorPercentName("B", IntensityToPercent(Blue))
        End Get
    End Property

    ''' <summary>
    ''' Liefert die Startadresse vom Objekt selbst zurück
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetMe As ColorItem
        Get
            Return Me
        End Get
    End Property

End Class
