''' <summary>
''' Martin Korneffel''' 
''' Startpunkt einer WinForm Anwendung: Sub Main.
''' http://stackoverflow.com/questions/14306903/how-to-find-the-main-entry-point-in-a-vb-net-winforms-app
''' Diese Klasse wurde manuell hinzugefügt. Sie wird normalerweise von Anwendungsframework
''' (Projekteinstellungen\Application\Enable Application Framework = on) bereitgestellt.
''' Diese Funktion manuell bereitzustellen ist sinnvoll, wenn Kommandzeilenargumente zum 
''' Iniitialisieren der Winform- Anwendung sinnvoll sind.
''' </summary>
''' <remarks></remarks>
Module Program

    Public Sub Main(args() As String)

        ' Komandozeilenargumente ausgeben
        For Each arg In args
            Debug.WriteLine("Kommandozeilenarg: " & arg)
        Next

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MyFormTemplate)
    End Sub

End Module
