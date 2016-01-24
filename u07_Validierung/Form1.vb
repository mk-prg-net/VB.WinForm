Public Class Form1

    Private BackColorBAckup As System.Drawing.Color
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColorBAckup = tbxA.BackColor
    End Sub


    ' Hier werden alle Erfolgreich validierten Eingaben gespeichert, um daraus 
    ' nach Validierung von tbxB ein Ergebnis zu berechnen
    Private A As Double
    Private B As Double

    Private Sub tbxA_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxA.Validating
        ' Option Strict lässt implizite Konvertierungen von String in Double nicht zu
        'A = tbxA.Text

        ValidateTbx(tbxA, lblStatA, A)

    End Sub


    Private Sub tbxB_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxB.Validating
        ValidateTbx(tbxB, lblStatB, B)

        tbxRes.Text = (A + B).ToString()
    End Sub


    Private Sub ValidateTbx(tbx As TextBox, lblStat As Label, ByRef Mem As Double)

        ' TryParse gibt false zurück, wenn die Konvertierung aufgrund von Eingabefehlern 
        ' scheitert
        Try
            Dim val = Convert.ToDouble(tbx.Text)

        Catch ex As InvalidCastException
            ' Konvertierungsfehler behandeln
            Debug.WriteLine("Konvertierungsfehler behandeln")
        Catch ex As Exception
            ' Allgemeinen Fehler behandeln
            Debug.WriteLine("Allgemeinen Fehler behandeln")
        End Try


        If Not Double.TryParse(tbx.Text, Mem) Then
            ' Fehlerfall
            tbx.BackColor = Color.Coral
            lblStat.Text = "<="
        Else
            ' Konvertierung geglückt
            tbx.BackColor = BackColorBAckup
            lblStat.Text = ""

        End If
    End Sub
End Class
