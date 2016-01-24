Public Class DefaultInfoForm

    Private Sub btnOK_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DefaultInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ver = Me.GetType().Assembly.GetName().Version

        tbxVer.Text = ver.Major.ToString("D3")
        tbxSubVer.Text = ver.Minor.ToString("D3")
        tbxBuild.Text = ver.Build.ToString("D3")
        tbxRevision.Text = ver.Revision.ToString("D3")

    End Sub

    Private Sub btnOk_Click_1(sender As Object, e As EventArgs) Handles btnOk.Click
        Close()
    End Sub
End Class