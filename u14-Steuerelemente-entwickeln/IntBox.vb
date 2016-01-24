Imports System.ComponentModel

Public Class IntBox

    Dim BackColorBackup As System.Drawing.Color
    Private Sub IntBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColorBackup = tbxValue.BackColor
    End Sub

    Private Sub tbxValue_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxValue.Validating
        Dim tbx = CType(sender, TextBox)

        If IsValid Then
            e.Cancel = False
            tbx.BackColor = BackColorBackup
        Else
            e.Cancel = True
            tbx.BackColor = Drawing.Color.Coral
        End If

    End Sub

    Dim _val As Integer

    <Browsable(True)> _
    <Category("Verhalten")> _
    Public Property Value As Integer
        Get
            Return _val
        End Get
        Set(value As Integer)
            _val = value
            tbxValue.Text = value.ToString()
        End Set
    End Property

    <Browsable(False)> _
    Public ReadOnly Property IsValid As Boolean
        Get

            If (Integer.TryParse(tbxValue.Text, _val)) Then
                Return True
            Else
                Return False
            End If

        End Get
    End Property

    <Browsable(True)> _
    <Category("Darstellung")> _
    Public Property Caption As String
        Get
            Return lblCaption.Text
        End Get
        Set(value As String)
            lblCaption.Text = value
        End Set
    End Property

End Class
