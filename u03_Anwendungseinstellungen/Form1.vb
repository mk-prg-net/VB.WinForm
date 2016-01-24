Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Titel der Anwendung aus den Anwendungseinstellungen laden
        Me.Text = My.Settings.ProgTitel

        Me.BackColor = My.Settings.Hintergrundfarbe

    End Sub
End Class
