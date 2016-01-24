<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefInteger
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
        Me.tbxVal = New System.Windows.Forms.TextBox()
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
        'tbxVal
        '
        Me.tbxVal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxVal.Location = New System.Drawing.Point(4, 20)
        Me.tbxVal.Name = "tbxVal"
        Me.tbxVal.Size = New System.Drawing.Size(63, 20)
        Me.tbxVal.TabIndex = 1
        Me.tbxVal.Text = "0"
        Me.tbxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefInteger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbxVal)
        Me.Controls.Add(Me.lblCaption)
        Me.Name = "DefInteger"
        Me.Size = New System.Drawing.Size(79, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents tbxVal As System.Windows.Forms.TextBox

End Class
