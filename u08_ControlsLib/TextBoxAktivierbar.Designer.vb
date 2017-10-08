<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxAktivierbar
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
        Me.tbxValue = New System.Windows.Forms.TextBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.cbxOnOff = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tbxValue
        '
        Me.tbxValue.Location = New System.Drawing.Point(4, 19)
        Me.tbxValue.Name = "tbxValue"
        Me.tbxValue.Size = New System.Drawing.Size(100, 20)
        Me.tbxValue.TabIndex = 0
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(4, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(205, 13)
        Me.lblCaption.TabIndex = 1
        Me.lblCaption.Text = "Hier eine sinvolle Beschriftung vornehmen"
        '
        'cbxOnOff
        '
        Me.cbxOnOff.AutoSize = True
        Me.cbxOnOff.Checked = True
        Me.cbxOnOff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxOnOff.Location = New System.Drawing.Point(111, 21)
        Me.cbxOnOff.Name = "cbxOnOff"
        Me.cbxOnOff.Size = New System.Drawing.Size(91, 17)
        Me.cbxOnOff.TabIndex = 2
        Me.cbxOnOff.Text = "Eingabe aktiv"
        Me.cbxOnOff.UseVisualStyleBackColor = True
        '
        'TextBoxAktivierbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbxOnOff)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.tbxValue)
        Me.Name = "TextBoxAktivierbar"
        Me.Size = New System.Drawing.Size(218, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents tbxValue As System.Windows.Forms.TextBox
    Public WithEvents lblCaption As System.Windows.Forms.Label
    Public WithEvents cbxOnOff As System.Windows.Forms.CheckBox

End Class
