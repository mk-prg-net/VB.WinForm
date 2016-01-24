Public Class TechnicalBaseForm

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        ShowInfo()
    End Sub

    Protected Overridable Sub ShowInfo()

        Dim frm As New DefaultInfoForm
        frm.Show()

    End Sub

End Class
