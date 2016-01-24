Public Class Form1
    Inherits u01_WinformGrundlagen.MyFormTemplate

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Sinusgenerator erzeugen und konfigurieren, so dass y = sin(x) berechnet wird
        With sinGen
            .Amplitude = 1
            .Frequency = 1
        End With

        With sin2xGen
            .Amplitude = 1
            .Frequency = 2
        End With
    End Sub

    ''' <summary>
    ''' Sinusgenerator für y = sin(x)
    ''' </summary>
    ''' <remarks></remarks>
    Private sinGen As New u8_ClassLib.Sinusgenerator()

    Private sin2xGen As New u8_ClassLib.Sinusgenerator()

    Private sin2x_plus_sin3xGen As New u8_ClassLib.Superposition()


    Private Sub btnGenSinus_Click(sender As Object, e As EventArgs) Handles btnGenSinus.Click


        If DefIntervalGenerators.IsValid And DefSampleCount.IsValid Then

            Dim inter As u8_ClassLib.Interval = DefIntervalGenerators.Interval
            Dim SamplesCount As Integer = DefSampleCount.Value

            With Chart1.Series(0)
                .Points.Clear()
                .Points.DataBindXY(sinGen.GenerateX(inter, SamplesCount), sinGen.GenerateY(inter, SamplesCount))
                .XAxisType = DataVisualization.Charting.AxisType.Primary
                .YAxisType = DataVisualization.Charting.AxisType.Primary
                .ChartType = DataVisualization.Charting.SeriesChartType.Point
            End With

        End If




    End Sub

    Private Sub btnSin2x_Click(sender As Object, e As EventArgs) Handles btnSin2x.Click
        If DefIntervalGenerators.IsValid And DefSampleCount.IsValid Then

            Dim inter As u8_ClassLib.Interval = DefIntervalGenerators.Interval
            Dim SamplesCount As Integer = DefSampleCount.Value

            With Chart1.Series(0)
                .Points.Clear()
                .Points.DataBindXY(sin2xGen.GenerateX(inter, SamplesCount), sin2xGen.GenerateY(inter, SamplesCount))
                .XAxisType = DataVisualization.Charting.AxisType.Primary
                .YAxisType = DataVisualization.Charting.AxisType.Primary
            End With

        End If
    End Sub

   
End Class
