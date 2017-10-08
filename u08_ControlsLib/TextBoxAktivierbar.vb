Imports System.ComponentModel
Public Class TextBoxAktivierbar

    Private Sub cbxOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOnOff.CheckedChanged
        ' Textbox ausgrauen, wenn deaktiviert
        tbxValue.Enabled = cbxOnOff.Checked
    End Sub

    <Browsable(True)> _
    <Category("Layout")> _
    Public Property Caption As String
        Set(value As String)
            lblCaption.Text = value
        End Set
        Get
            Return lblCaption.Text
        End Get
    End Property


End Class
