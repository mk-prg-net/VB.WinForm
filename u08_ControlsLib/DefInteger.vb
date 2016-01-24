Imports System.ComponentModel
Public Class DefInteger

    Dim BackColorBAckup As System.Drawing.Color

    Private Sub DefInteger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = tbxVal.BackColor
    End Sub

    Private Function ValidateTbx(tbx As TextBox, ByRef Mem As Integer) As Boolean

        If Not Integer.TryParse(tbx.Text, Mem) Then
            ' Fehlerfall
            tbx.BackColor = Color.Coral
            Return False
        Else
            ' Konvertierung geglückt
            tbx.BackColor = BackColorBAckup
            Return True
        End If
    End Function


    Private Sub tbxVal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxVal.Validating
        Dim tbx As TextBox = CType(sender, TextBox)
        Dim val As Integer
        ValidateTbx(tbx, val)
    End Sub


    Public ReadOnly Property IsValid As Boolean
        Get
            Dim val As Integer
            Return ValidateTbx(tbxVal, val)
        End Get
    End Property

    <Category("Verhalten"), Browsable(True)> _
     Public Property Value As Integer
        Get
            Dim val As Integer
            If ValidateTbx(tbxVal, val) Then
                Return val
            Else
                Return 0
            End If
        End Get
        Set(value As Integer)
            tbxVal.Text = value.ToString()
        End Set
    End Property

    <Category("Verhalten"), Browsable(True)> _
    Public Property Caption As String
        Get
            Return lblCaption.Text
        End Get
        Set(value As String)
            lblCaption.Text = value
        End Set
    End Property
End Class
