Public Class Form1
    Inherits u01_WinformGrundlagen.MyFormTemplate

    Private Sub trvSolarSystem_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvSolarSystem.AfterSelect

        ' Zugriff auf das Event- auslösende Steuerelement
        Dim tree As TreeView = CType(sender, TreeView)

        ' Zugriff auf den selektierten Knoten
        tbxNodeName.Text = e.Node.Name
        tbxPath.Text = e.Node.FullPath
        tbxDeept.Text = e.Node.Level

    End Sub

    Protected Overrides Sub OpenDoc()
        ' Verzeichnis mittels FolderBrowser auswählen
        If FolderBrowserDialogSelectRoot.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim root As String = FolderBrowserDialogSelectRoot.SelectedPath

            Dim dt As New DirTree

            dt.Scan(root, trvFileSystem.TopNode)

        End If
    End Sub

    
    Private Sub trvFileSystem_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvFileSystem.AfterSelect
        If e.Node.ImageIndex = DirTree.ImgIx.Img Then
            PictureBoxDateisystem.ImageLocation = CType(e.Node.Tag, String)
        End If
    End Sub
End Class
