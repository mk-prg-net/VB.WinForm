Public Class Form1
    Inherits u01_WinformGrundlagen.MyFormTemplate


    Private Sub btnCopyTxt_Click(sender As Object, e As EventArgs) Handles btnCopyTxt.Click
        ' Aktuell selektierten Text kopieren in Zwischenablage
        tbxEdit.Copy()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click

        tbxEdit.Paste()



    End Sub

    Private Sub btnSelectLast5_Click(sender As Object, e As EventArgs) Handles btnSelectLast5.Click
        Dim anzZeichen As Integer = tbxEdit.Text.Length
        ' Startposition für die Selektion bestimmen
        tbxEdit.HideSelection = False
        Dim StartPos As Integer = Math.Max(anzZeichen - 5, 0)
        tbxEdit.Select(StartPos, 5)
    End Sub
End Class
