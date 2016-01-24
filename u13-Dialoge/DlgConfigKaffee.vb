Imports System.Windows.Forms

Public Class DlgConfigKaffee
    Implements ICoffee


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Property Additive As Kafeezusatz() Implements ICoffee.Additive
        Get
            ' List, die dynamisch erweiterbar ist, anlegen
            Dim list As New List(Of Kafeezusatz)

            If cbxMilch.Checked Then
                list.Add(New Milch)
            End If

            If cbxZucker.Checked Then
                list.Add(New Zucker)
            End If

            Return list.ToArray()

        End Get
        Set(value As Kafeezusatz())

            ' alle alten Einträge löschen
            cbxMilch.Checked = False
            cbxZucker.Checked = False

            ' neue Einträge setzen
            For Each zusatz As Kafeezusatz In value

                If TypeOf zusatz Is Milch Then
                    cbxMilch.Checked = True
                End If

                If TypeOf zusatz Is Zucker Then
                    cbxMilch.Checked = True
                End If
                'cbxMilch.Checked = TypeOf zusatz Is Milch

                'cbxZucker.Checked = TypeOf zusatz Is Zucker

            Next

        End Set
    End Property

    Public Property Big As Boolean Implements ICoffee.Big
        Get
            Return rbtBig.Checked
        End Get
        Set(value As Boolean)
            rbtBig.Checked = value
        End Set
    End Property

    Public Property Hot As Boolean Implements ICoffee.Hot
        Get
            Return rbtHot.Checked
        End Get
        Set(value As Boolean)
            rbtHot.Checked = value
        End Set
    End Property
End Class
