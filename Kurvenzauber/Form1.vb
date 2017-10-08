Imports KurvenzauberLib

Public Class Form1

    Private Sub BeendenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Dim Palette() As Brush = {Brushes.Yellow, Brushes.White, Brushes.YellowGreen, Brushes.Violet, Brushes.Blue, Brushes.Brown, Brushes.RosyBrown, Brushes.Red, Brushes.Orange}
    Dim NextColorIndex As Integer = 0

    Dim Zeichnung As New List(Of Tuple(Of Blume, Brush))

    Private Sub btnEllipsePlusSinusDraw_Click(sender As System.Object, e As System.EventArgs) Handles btnEllipsePlusSinusDraw.Click

        Dim Radius As Double
        Dim Frequenz As Double
        Dim Dynamic As Double

        If Double.TryParse(tbxES_Radius.Text, Radius) And _
            Double.TryParse(tbxES_Sinus_Frequenz.Text, Frequenz) And _
            Double.TryParse(tbxES_Dynamic.Text, Dynamic) Then

            Dim blume1 As New Blume(Radius, Dynamic, Frequenz, 360)

            'Using gph As Graphics = pbxCanvas.CreateGraphics()

            Zeichnung.Add(New Tuple(Of Blume, Brush)(blume1, Palette(NextColorIndex)))
            'Draw(gph)
            pbxCanvas.Invalidate()

            'End Using

            NextColorIndex = (NextColorIndex + 1) Mod Palette.Length

        End If
    End Sub

    Sub Draw(gph As Graphics)

        gph.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        gph.TranslateTransform(pbxCanvas.ClientSize.Width / 2, pbxCanvas.Height / 2)

        Using myBrush As New SolidBrush(pbxCanvas.BackColor)
            gph.FillRectangle(myBrush, pbxCanvas.ClientRectangle)
        End Using

        For Each t In Zeichnung
            Using myPen As New Pen(t.Item2, 3.0F)
                gph.DrawPolygon(myPen, t.Item1.Polygon)
            End Using
        Next


    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Zeichnung.Clear()
        pbxCanvas.Invalidate()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim bmp As New Bitmap(pbxCanvas.ClientSize.Width, pbxCanvas.ClientSize.Height)

            pbxCanvas.DrawToBitmap(bmp, pbxCanvas.ClientRectangle)

            bmp.Save(SaveFileDialog1.FileName)

        End If

    End Sub

    Private Sub pbxCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pbxCanvas.Paint
        Draw(e.Graphics)
    End Sub
End Class
