Public Class MyFormTemplate

    Private Sub KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click
        MessageBox.Show("Kopieren beginnt")
    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinfügenToolStripMenuItem.Click
        MessageBox.Show("Kopieren beenden")
    End Sub


    Dim Meldungsarten() As String = {"Err", "Msg", "Sta"}

    ' Zufallszahlengenerator
    Dim rnd As New Random()

    Private Sub btnMainLogGenTestmessage_Click(sender As Object, e As EventArgs) Handles btnMainLogGenTestmessage.Click
        Dim meldung As String

        Dim Meldungsart As String = Meldungsarten(rnd.Next(0, 2))

        '                                      0. Param,    1. Param,       2. Param
        meldung = String.Format("{2:T} {0} {1}", Meldungsart, Now.ToString(), Now)


        lbxMainLog.Items.Add(meldung)


    End Sub

    Private Sub btnMainLogClear_Click(sender As Object, e As EventArgs) Handles btnMainLogClear.Click
        lbxMainLog.Items.Clear()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Dim Info As New DlgInfo
        Info.Show()


    End Sub

    ''' <summary>
    ''' Implementiert die Menüfunktion "Dokument öffnen". Kann in einem Abgeleiteten Formular durch Überschreiben
    ''' ausgestaltet werden
    ''' </summary>
    ''' <remarks></remarks>
    Protected Overridable Sub OpenDoc()
        MessageBox.Show("Öffnen eines Dokumentes.")
    End Sub

    ''' <summary>
    ''' Eventhandler der Menüfunktion "öffnen"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenDoc()
    End Sub

    Protected Overridable Sub SaveDoc()
        MessageBox.Show("Sichern eines Dokumentes.")
    End Sub

    ''' <summary>
    ''' Eventhandler der Menüfunktion "sichern"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SichernToolStripMenuItem.Click
        SaveDoc()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
