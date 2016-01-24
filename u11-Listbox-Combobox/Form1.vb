Public Class Form1
    Inherits u01_WinformGrundlagen.MyFormTemplate

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Liste der Farben (PAlette) anlegen, und an die Listbox binden
        Dim palette() As ColorItem = { _
                New ColorItem() With {.Blue = 255}, _
                New ColorItem() With {.Green = 255}, _
                New ColorItem() With {.Red = 255}
            }

        ' Hier wird die Bindung tatsächlich implementiert
        BindingSourceLbxDemo.DataSource = palette


        '----------------------------------------------------------------------------------------
        ' Liste der Kaffezusätze anlegen
        Dim Zusatzliste() As Kafeezusatz = { _
             New Milch(), _
             New Sahne(), _
             New Zucker(), _
             New Schokolade(), _
             New Chili()
            }

        ' Hier wird die Bindung tatsächlich implementiert
        ' IN einer internen Schleife werden alle Array- Elemente 
        ' durchaufen, und dabei für jeden ein neues Listenelement angelegt,
        ' dessen DisplayMEmber - Eigenschaft mit dem Wert aus KAffezusatz.Name,
        ' und dessen Value- Eigenschaft mit dem Wert aus Kaffezusatz.GetMe 
        ' initialisiert wird
        BindingSourceKaffezusatz.DataSource = Zusatzliste

        BindingSourceCbxCoffe.DataSource = Zusatzliste

    End Sub

    Sub ShowSelectedValue()
        Dim selectedColor As ColorItem = CType(lbxDemo.SelectedValue, ColorItem)

        tbxColorBlue.Text = selectedColor.Blue.ToString()
        tbxColorGreen.Text = selectedColor.Green.ToString()
        tbxColorRed.Text = selectedColor.Red.ToString()
    End Sub

    Private Sub btnShowSelected_Click(sender As Object, e As EventArgs) Handles btnShowSelected.Click
        ShowSelectedValue()
    End Sub

    Private Sub lbxDemo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDemo.SelectedIndexChanged
        ShowSelectedValue()
    End Sub

    Private Sub btnUpdatePalette_Click(sender As Object, e As EventArgs) Handles btnUpdatePalette.Click
        Dim selVal As ColorItem = CType(lbxDemo.SelectedValue, ColorItem)

        selVal.Blue = Byte.Parse(tbxColorBlue.Text)
        selVal.Green = Byte.Parse(tbxColorGreen.Text)
        selVal.Red = Byte.Parse(tbxColorRed.Text)

        BindingSourceLbxDemo.ResetBindings(False)

    End Sub

    Private Sub btnProduceCoffe_Click(sender As Object, e As EventArgs) Handles btnProduceCoffe.Click
        ' Alten Kaffee löschen
        lbxKaffeeinhalt.Items.Clear()

        ' Aus der Multiselect- Listbox alle gewählten Zusätze auslesen
        For Each item As Kafeezusatz In lbxMulti.SelectedItems
            ' Jeden Zusatz im Kaffeinhalt vermerken

            lbxKaffeeinhalt.Items.Add(item.Name)


        Next




    End Sub

    Private Sub cobCoffe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobCoffe.SelectedIndexChanged
        tbxSelectedCoffe.Text = CType(cobCoffe.SelectedItem, Kafeezusatz).Name


    End Sub
End Class
