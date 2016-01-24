<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConfigCoffee = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.tbxShowOrder = New System.Windows.Forms.TextBox()
        Me.btnConfigCoffeeWithInterface = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestellungSichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialogCoffeeOrder = New System.Windows.Forms.SaveFileDialog()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialogCoffeeOrder = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfigCoffee
        '
        Me.btnConfigCoffee.Location = New System.Drawing.Point(12, 38)
        Me.btnConfigCoffee.Name = "btnConfigCoffee"
        Me.btnConfigCoffee.Size = New System.Drawing.Size(196, 23)
        Me.btnConfigCoffee.TabIndex = 0
        Me.btnConfigCoffee.Text = "1) Kaffee bestellen"
        Me.btnConfigCoffee.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(12, 215)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(196, 23)
        Me.btnPay.TabIndex = 1
        Me.btnPay.Text = "2) Bezahlen"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'tbxShowOrder
        '
        Me.tbxShowOrder.Location = New System.Drawing.Point(12, 97)
        Me.tbxShowOrder.Multiline = True
        Me.tbxShowOrder.Name = "tbxShowOrder"
        Me.tbxShowOrder.Size = New System.Drawing.Size(196, 112)
        Me.tbxShowOrder.TabIndex = 2
        '
        'btnConfigCoffeeWithInterface
        '
        Me.btnConfigCoffeeWithInterface.Location = New System.Drawing.Point(12, 68)
        Me.btnConfigCoffeeWithInterface.Name = "btnConfigCoffeeWithInterface"
        Me.btnConfigCoffeeWithInterface.Size = New System.Drawing.Size(196, 23)
        Me.btnConfigCoffeeWithInterface.TabIndex = 3
        Me.btnConfigCoffeeWithInterface.Text = "1.1) Bestellen mit Schnittstelle"
        Me.btnConfigCoffeeWithInterface.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(230, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.BestellungSichernToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BestellungSichernToolStripMenuItem
        '
        Me.BestellungSichernToolStripMenuItem.Name = "BestellungSichernToolStripMenuItem"
        Me.BestellungSichernToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BestellungSichernToolStripMenuItem.Text = "Bestellung sichern"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Bestellung öffnen"
        '
        'OpenFileDialogCoffeeOrder
        '
        Me.OpenFileDialogCoffeeOrder.Filter = "XML|*.xml|Alle Dateien|*.*"
        Me.OpenFileDialogCoffeeOrder.Title = "Kaffeebestellung öffnen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 262)
        Me.Controls.Add(Me.btnConfigCoffeeWithInterface)
        Me.Controls.Add(Me.tbxShowOrder)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnConfigCoffee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Kaffeeautomat"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfigCoffee As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents tbxShowOrder As System.Windows.Forms.TextBox
    Friend WithEvents btnConfigCoffeeWithInterface As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestellungSichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialogCoffeeOrder As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialogCoffeeOrder As System.Windows.Forms.OpenFileDialog

End Class
