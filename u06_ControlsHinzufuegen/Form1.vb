Public Class Form1

    Private aktParent As System.Windows.Forms.Control

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aktParent = panMain
    End Sub


    Dim palette() As System.Drawing.Color = {System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue}
    Dim ixPalette As Integer

    Private Sub btnAddPanel_Click(sender As Object, e As EventArgs) Handles btnAddPanel.Click

        Dim newPanel As New Panel

        With newPanel

            .Size = New System.Drawing.Size With {.Height = aktParent.Height * 2.0 / 3.0, .Width = aktParent.Width * 2.0 / 3.0}
            .Location = New System.Drawing.Point(aktParent.Width * 1.0 / 6.0, aktParent.Height * 1.0 / 6.0)
            .BackColor = palette(ixPalette)
            ixPalette = (ixPalette + 1) Mod palette.Length

        End With

        ' Dynamische hinzufügen von Controls zur Laufzeit
        aktParent.Controls.Add(newPanel)

        aktParent = newPanel


    End Sub

    
End Class
