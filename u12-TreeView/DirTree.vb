Public Class DirTree
    Enum ImgIx
        Root
        Dir
        DirOpen
        Txt
        Img
    End Enum

    Public Sub Scan(root As String, currentRootNode As TreeNode)

        ' An den CurrentNode einen neuen Verzeichnisknoten anhängen
        Dim dirNode As New TreeNode
        With dirNode
            .Name = root
            .Text = System.IO.Path.GetFileName(root)
            .ImageIndex = ImgIx.Dir
            .SelectedImageIndex = ImgIx.DirOpen
        End With
        currentRootNode.Nodes.Add(dirNode)

        ' Alle im Verzeichnis enthaltenen Dateien auflisten und verarbeiten
        Dim files() As String = System.IO.Directory.GetFiles(root)

        For Each file As String In files
            ProcessFiles(file, dirNode)
        Next

        ' Alle im Verzeichnis enthaltenen Unterverzeichnisse auflisten:
        ' für jede wiederum Scan aufrufen (Rekursion)

        Dim dirs() As String = System.IO.Directory.GetDirectories(root)

        For Each dir As String In dirs

            ' Aktionen vor dem tieferen Abstieg ins Filesystem
            BeginProcessDir(dir, dirNode)

            ' Ins Filesystem eine Stufe tiefer absteigen
            Scan(dir, dirNode)

            ' Aktion nach wiederauftauchen aus den tiefern Ebenen des Dateisystems
            EndProcessDir(dir, dirNode)
        Next

    End Sub

    Sub ProcessFiles(filename As String, currentRootNode As TreeNode)
        Dim fileNode As New TreeNode
        With fileNode
            .Name = filename
            .Text = System.IO.Path.GetFileName(filename)

            Dim ext As String = System.IO.Path.GetExtension(filename).ToLower()
            If New String() {".png", ".gif", ".jpg", ".bmp"}.Any(Function(e) e = ext) Then
                .ImageIndex = ImgIx.Img
            Else
                .ImageIndex = ImgIx.Txt
            End If

            .Tag = filename

        End With
        currentRootNode.Nodes.Add(fileNode)
    End Sub

    Sub BeginProcessDir(dirname As String, currentRootNode As TreeNode)

    End Sub

    Sub EndProcessDir(dirname As String, currentRootNode As TreeNode)

    End Sub

End Class
