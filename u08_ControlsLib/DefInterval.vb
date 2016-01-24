Public Class DefInterval

    Dim BackColorBAckup As System.Drawing.Color

    Private Sub DefInterval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = tbxBeg.BackColor
    End Sub


    Private Function ValidateTbx(tbx As TextBox, ByRef Mem As Double) As Boolean

        If Not Double.TryParse(tbx.Text, Mem) Then
            ' Fehlerfall
            tbx.BackColor = Color.Coral
            Return False
        Else
            ' Konvertierung geglückt
            tbx.BackColor = BackColorBAckup
            Return True
        End If
    End Function


    Private Sub tbxEnd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbxEnd.Validating
        Dim b As Double
        Dim ende As Double
        TryParseInterval(b, ende)
    End Sub

    Public Function TryParseInterval(ByRef b, ByRef e) As Boolean

        Return ValidateTbx(tbxBeg, b) AndAlso ValidateTbx(tbxEnd, e) AndAlso b < e

    End Function

    Public ReadOnly Property IsValid As Boolean
        Get
            Dim b As Double
            Dim ende As Double
            Return TryParseInterval(b, ende)
        End Get
    End Property

    Public Property Interval As u8_ClassLib.Interval
        Get
            Dim b As Double
            Dim e As Double
            If (TryParseInterval(b, e)) Then
                Return New u8_ClassLib.Interval(b, e)
            Else
                Return New u8_ClassLib.Interval(0, 1)
            End If
        End Get

        Set(value As u8_ClassLib.Interval)

            tbxBeg.Text = value.BeginInterval.ToString()
            tbxEnd.Text = value.EndInterval.ToString()

            Dim b As Double
            Dim e As Double
            TryParseInterval(b, e)

        End Set
    End Property

End Class
