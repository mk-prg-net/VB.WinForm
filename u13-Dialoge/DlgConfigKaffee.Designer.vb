<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgConfigKaffee
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.cbxZucker = New System.Windows.Forms.CheckBox()
        Me.cbxMilch = New System.Windows.Forms.CheckBox()
        Me.grpCoffeeAdditionals = New System.Windows.Forms.GroupBox()
        Me.grpColdHot = New System.Windows.Forms.GroupBox()
        Me.rbtHot = New System.Windows.Forms.RadioButton()
        Me.rbtCold = New System.Windows.Forms.RadioButton()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rbtSmall = New System.Windows.Forms.RadioButton()
        Me.rbtBig = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpCoffeeAdditionals.SuspendLayout()
        Me.grpColdHot.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(212, 113)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        'cbxZucker
        '
        Me.cbxZucker.AutoSize = True
        Me.cbxZucker.Location = New System.Drawing.Point(16, 22)
        Me.cbxZucker.Name = "cbxZucker"
        Me.cbxZucker.Size = New System.Drawing.Size(60, 17)
        Me.cbxZucker.TabIndex = 1
        Me.cbxZucker.Text = "Zucker"
        Me.cbxZucker.UseVisualStyleBackColor = True
        '
        'cbxMilch
        '
        Me.cbxMilch.AutoSize = True
        Me.cbxMilch.Location = New System.Drawing.Point(16, 45)
        Me.cbxMilch.Name = "cbxMilch"
        Me.cbxMilch.Size = New System.Drawing.Size(51, 17)
        Me.cbxMilch.TabIndex = 2
        Me.cbxMilch.Text = "Milch"
        Me.cbxMilch.UseVisualStyleBackColor = True
        '
        'grpCoffeeAdditionals
        '
        Me.grpCoffeeAdditionals.Controls.Add(Me.cbxZucker)
        Me.grpCoffeeAdditionals.Controls.Add(Me.cbxMilch)
        Me.grpCoffeeAdditionals.Location = New System.Drawing.Point(12, 24)
        Me.grpCoffeeAdditionals.Name = "grpCoffeeAdditionals"
        Me.grpCoffeeAdditionals.Size = New System.Drawing.Size(95, 73)
        Me.grpCoffeeAdditionals.TabIndex = 3
        Me.grpCoffeeAdditionals.TabStop = False
        Me.grpCoffeeAdditionals.Text = "Kaffezusätze"
        '
        'grpColdHot
        '
        Me.grpColdHot.Controls.Add(Me.rbtCold)
        Me.grpColdHot.Controls.Add(Me.rbtHot)
        Me.grpColdHot.Location = New System.Drawing.Point(134, 24)
        Me.grpColdHot.Name = "grpColdHot"
        Me.grpColdHot.Size = New System.Drawing.Size(94, 73)
        Me.grpColdHot.TabIndex = 4
        Me.grpColdHot.TabStop = False
        Me.grpColdHot.Text = "Temperatur"
        '
        'rbtHot
        '
        Me.rbtHot.AutoSize = True
        Me.rbtHot.Checked = True
        Me.rbtHot.Location = New System.Drawing.Point(7, 22)
        Me.rbtHot.Name = "rbtHot"
        Me.rbtHot.Size = New System.Drawing.Size(49, 17)
        Me.rbtHot.TabIndex = 0
        Me.rbtHot.TabStop = True
        Me.rbtHot.Text = "heiss"
        Me.rbtHot.UseVisualStyleBackColor = True
        '
        'rbtCold
        '
        Me.rbtCold.AutoSize = True
        Me.rbtCold.Location = New System.Drawing.Point(7, 45)
        Me.rbtCold.Name = "rbtCold"
        Me.rbtCold.Size = New System.Drawing.Size(42, 17)
        Me.rbtCold.TabIndex = 1
        Me.rbtCold.Text = "kalt"
        Me.rbtCold.UseVisualStyleBackColor = True
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rbtBig)
        Me.grpSize.Controls.Add(Me.rbtSmall)
        Me.grpSize.Location = New System.Drawing.Point(247, 24)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(110, 73)
        Me.grpSize.TabIndex = 5
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Größe"
        '
        'rbtSmall
        '
        Me.rbtSmall.AutoSize = True
        Me.rbtSmall.Checked = True
        Me.rbtSmall.Location = New System.Drawing.Point(7, 22)
        Me.rbtSmall.Name = "rbtSmall"
        Me.rbtSmall.Size = New System.Drawing.Size(47, 17)
        Me.rbtSmall.TabIndex = 0
        Me.rbtSmall.TabStop = True
        Me.rbtSmall.Text = "klein"
        Me.rbtSmall.UseVisualStyleBackColor = True
        '
        'rbtBig
        '
        Me.rbtBig.AutoSize = True
        Me.rbtBig.Location = New System.Drawing.Point(7, 46)
        Me.rbtBig.Name = "rbtBig"
        Me.rbtBig.Size = New System.Drawing.Size(46, 17)
        Me.rbtBig.TabIndex = 1
        Me.rbtBig.Text = "groß"
        Me.rbtBig.UseVisualStyleBackColor = True
        '
        'DlgConfigKaffee
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(370, 154)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.grpColdHot)
        Me.Controls.Add(Me.grpCoffeeAdditionals)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgConfigKaffee"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bestellen Sie Ihren Kaffee ..."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpCoffeeAdditionals.ResumeLayout(False)
        Me.grpCoffeeAdditionals.PerformLayout()
        Me.grpColdHot.ResumeLayout(False)
        Me.grpColdHot.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cbxZucker As System.Windows.Forms.CheckBox
    Friend WithEvents cbxMilch As System.Windows.Forms.CheckBox
    Friend WithEvents grpCoffeeAdditionals As System.Windows.Forms.GroupBox
    Friend WithEvents grpColdHot As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCold As System.Windows.Forms.RadioButton
    Friend WithEvents rbtHot As System.Windows.Forms.RadioButton
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents rbtBig As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSmall As System.Windows.Forms.RadioButton

End Class
