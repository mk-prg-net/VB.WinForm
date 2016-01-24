Public Class Form1

    Private Sub btnConfigCoffee_Click(sender As Object, e As EventArgs) Handles btnConfigCoffee.Click
        ' Auifrufen des selbstdefinierten Dialoges

        ' 1) Dialogobjekt anlegen
        Dim dlg As New DlgConfigKaffee

        Dim bestellung As String = "Sie haben bestellt: " + vbCrLf

        ' 2) Dialog modal anzeigen
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

            ' Direkter Zugriff auf die Steuerelemente im Dialog
            ' Nachteil: Zugriff auf den Dialog ist vom Layout des
            '           Dialoges abhängig
            If dlg.rbtBig.Checked Then
                bestellung += "große Tasse" + vbCrLf
            Else
                bestellung += "kleine Tasse" + vbCrLf
            End If

            If dlg.rbtHot.Checked Then
                bestellung += "Temperatur: heiss" + vbCrLf
            Else
                bestellung += "Temperatur: kalt" + vbCrLf
            End If

            If dlg.cbxMilch.Checked Or dlg.cbxZucker.Checked Then

                bestellung += "Zusätze: "

                If dlg.cbxMilch.Checked Then
                    bestellung += "Milch"
                End If

                If dlg.cbxZucker.Checked Then
                    bestellung += "Zucker"
                Else
                    ' Keine Alternative geplant
                End If
            End If

            tbxShowOrder.Text = bestellung

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxShowOrder.ReadOnly = True
    End Sub

    Private ActOrder As CoffeeOrder

    Private Sub btnConfigCoffeeWithInterface_Click(sender As Object, e As EventArgs) Handles btnConfigCoffeeWithInterface.Click
        Dim dlg As New DlgConfigKaffee

        Dim bestellung As String = "Sie haben bestellt: " + vbCrLf

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

            ActOrder = New CoffeeOrder(dlg)

            tbxShowOrder.Text = ActOrder.ToString()
        Else
            tbxShowOrder.Text = "Bestellung abgebrochen"
        End If

    End Sub

    Private Sub BestellungSichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestellungSichernToolStripMenuItem.Click
        If Not ActOrder Is Nothing Then

            ' Dateiname bestimmen
            If SaveFileDialogCoffeeOrder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' Datenstrom zum schreiben in Datei öffnen
                Dim fstream As New System.IO.FileStream(SaveFileDialogCoffeeOrder.FileName, IO.FileMode.Create)

                ' Objekt in die Datei serialisieren
                Dim serializer As New System.Xml.Serialization.XmlSerializer(ActOrder.GetType())
                serializer.Serialize(fstream, ActOrder)

                MessageBox.Show("Aktuelle Bestellung in der Datei " & SaveFileDialogCoffeeOrder.FileName & " gesichert")

            End If
        End If
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        ' Dateiname bestimmen
        If OpenFileDialogCoffeeOrder.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Datenstrom zum schreiben in Datei öffnen
            Dim fstream As New System.IO.FileStream(OpenFileDialogCoffeeOrder.FileName, IO.FileMode.Open)

            ' Objekt in die Datei serialisieren
            Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(CoffeeOrder))
            ActOrder = CType(serializer.Deserialize(fstream), CoffeeOrder)

            MessageBox.Show("Bestellung aus Datei " & OpenFileDialogCoffeeOrder.FileName & " geladen")

            tbxShowOrder.Text = ActOrder.ToString()

        End If
    End Sub
End Class
