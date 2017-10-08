Imports System.Data.Entity

Public Class Form1
    Inherits u01_WinformGrundlagen.MyFormTemplate



    Dim ormMain As KeplerDB.KeplerDBEntities

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ormMain = New KeplerDB.KeplerDBEntities()
        'SternePlaetenMondeDecoBindingSource.DataSource = ormMain.Sterne_Planeten_MondeTab.ToArray().Select(Function(cb) New SternePlanetenMondeDeco(cb))




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

        BindingSource1.DataSource = Zusatzliste


        Try

            ' Daten aus der DAtenbank laden und über bindingSource an GridView binden
            Using orm = New KeplerDB.KeplerDBEntities

                orm.Configuration.LazyLoadingEnabled = False


                Debug.Assert(orm.Sterne_Planeten_MondeTab.Count() > 0)

#If DEBUG Then


                Dim res = orm.Sterne_Planeten_MondeTab.ToArray()
#End If

                KeplerDBHimmelskoerperBindingSource.DataSource = orm.Sterne_Planeten_MondeTab.ToArray()

                ' Die verknüpften Datensätze wie HimmelskoerperTab usw. werden gleich in der ersten
                ' abfrage mitgeladen- kein Konflikt beim späteren Zugriff, wenn die DB- Verbindung
                ' bereits geschlossen ist
                SternePlaetenMondeDecoBindingSource.DataSource = orm.Sterne_Planeten_MondeTab _
                                                    .Include(Function(spm) spm.HimmelskoerperTab) _
                                                    .Include(Function(spm) spm.HimmelskoerperTab.HimmelskoerperTypenTab) _
                                                    .ToArray() _
                                                    .Select(Function(cb) New SternePlanetenMondeDeco(cb))



            End Using

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try


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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim kaffezusatElem = CType(ListBox1.SelectedItem, Kafeezusatz)

        MessageBox.Show("Sie haben gewählt: " & kaffezusatElem.Name)
    End Sub
End Class
