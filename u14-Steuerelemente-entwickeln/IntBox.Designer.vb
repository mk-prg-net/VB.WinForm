<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntBox
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.tbxValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(4, 4)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(43, 13)
        Me.lblCaption.TabIndex = 0
        Me.lblCaption.Text = "Caption"
        '
        'tbxValue
        '
        Me.tbxValue.Location = New System.Drawing.Point(7, 21)
        Me.tbxValue.Name = "tbxValue"
        Me.tbxValue.Size = New System.Drawing.Size(100, 20)
        Me.tbxValue.TabIndex = 1
        Me.tbxValue.Text = "0"
        Me.tbxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IntBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbxValue)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "IntBox"
        Me.Size = New System.Drawing.Size(113, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents tbxValue As System.Windows.Forms.TextBox

End Class
