<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefInterval
    Inherits System.Windows.Forms.UserControl

    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.lblBeg = New System.Windows.Forms.Label()
        Me.tbxBeg = New System.Windows.Forms.TextBox()
        Me.lblSep = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.tbxEnd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblBeg
        '
        Me.lblBeg.AutoSize = True
        Me.lblBeg.Location = New System.Drawing.Point(4, 5)
        Me.lblBeg.Name = "lblBeg"
        Me.lblBeg.Size = New System.Drawing.Size(32, 13)
        Me.lblBeg.TabIndex = 0
        Me.lblBeg.Text = "Beg.:"
        '
        'tbxBeg
        '
        Me.tbxBeg.Location = New System.Drawing.Point(4, 20)
        Me.tbxBeg.Name = "tbxBeg"
        Me.tbxBeg.Size = New System.Drawing.Size(100, 20)
        Me.tbxBeg.TabIndex = 1
        Me.tbxBeg.Text = "0"
        Me.tbxBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSep
        '
        Me.lblSep.AutoSize = True
        Me.lblSep.Location = New System.Drawing.Point(108, 20)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(12, 13)
        Me.lblSep.TabIndex = 2
        Me.lblSep.Text = "\"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(124, 5)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblEnd.TabIndex = 3
        Me.lblEnd.Text = "End"
        '
        'tbxEnd
        '
        Me.tbxEnd.Location = New System.Drawing.Point(124, 20)
        Me.tbxEnd.Name = "tbxEnd"
        Me.tbxEnd.Size = New System.Drawing.Size(100, 20)
        Me.tbxEnd.TabIndex = 4
        Me.tbxEnd.Text = "1"
        Me.tbxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefInterval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbxEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblSep)
        Me.Controls.Add(Me.tbxBeg)
        Me.Controls.Add(Me.lblBeg)
        Me.Name = "DefInterval"
        Me.Size = New System.Drawing.Size(231, 47)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBeg As System.Windows.Forms.Label
    Friend WithEvents tbxBeg As System.Windows.Forms.TextBox
    Friend WithEvents lblSep As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents tbxEnd As System.Windows.Forms.TextBox

End Class
