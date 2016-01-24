﻿Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Neue Instanz des untergeordneten Formulars erstellen.
        ' mko: Hier wurde die ursprüngliche System.Windows.Form durch unsere eigene Klasse für Kindfenster ausgetauscht
        Dim ChildForm As New MyChildForm
        ' Vor der Anzeige dem MDI-Formular unterordnen.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1

        ' Dateiname mit der anzuzeigenden Bilddatei über Datei- Öffnen Dialog wählen


        ' DAteiname dem Kiondfenster zuweisen

        ' Titel des FEnsters aus dem Dateiname bilden
        ChildForm.Text = "Fenster " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click

        ' OpenImageFileDialog wurde über den Werkzeugkasten als Dialogkomponente eingefügt und konfiguriert -> globale Instanz
        OpenImageFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        ' Dateiname mit der anzuzeigenden Bilddatei über Datei- Öffnen Dialog wählen
        If (OpenImageFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenImageFileDialog.FileName
            ' TODO: Hier Code zum Öffnen der Datei hinzufügen

            ' Neue Instanz des untergeordneten Formulars erstellen.
            ' mko: Hier wurde die ursprüngliche System.Windows.Form durch unsere eigene Klasse für Kindfenster ausgetauscht
            Dim ChildForm As New MyChildForm
            ' Vor der Anzeige dem MDI-Formular unterordnen.
            ChildForm.MdiParent = Me

            m_ChildFormNumber += 1

            ' DAteiname dem Kiondfenster zuweisen
            ChildForm.ImageFileName = FileName

            ' Titel des FEnsters aus dem Dateiname bilden
            ChildForm.Text = FileName & " " & m_ChildFormNumber

            ChildForm.Show()

        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Hier Code einfügen, um den aktuellen Inhalt des Formulars in einer Datei zu speichern
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Mithilfe von My.Computer.Clipboard den ausgewählten Text bzw. die ausgewählten Bilder in die Zwischenablage kopieren
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Mithilfe von My.Computer.Clipboard.GetText() oder My.Computer.Clipboard.GetData Informationen aus der Zwischenablage abrufen
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Alle untergeordneten Formulare des übergeordneten Formulars schließen
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

End Class
