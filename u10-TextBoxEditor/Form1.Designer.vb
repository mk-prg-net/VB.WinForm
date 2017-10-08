<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1


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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelectLast5 = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnCopyTxt = New System.Windows.Forms.Button()
        Me.tbxEdit = New System.Windows.Forms.TextBox()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Size = New System.Drawing.Size(698, 554)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbxEdit)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Size = New System.Drawing.Size(690, 528)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSelectLast5)
        Me.Panel1.Controls.Add(Me.btnPaste)
        Me.Panel1.Controls.Add(Me.btnCopyTxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 61)
        Me.Panel1.TabIndex = 0
        '
        'btnSelectLast5
        '
        Me.btnSelectLast5.Location = New System.Drawing.Point(179, 3)
        Me.btnSelectLast5.Name = "btnSelectLast5"
        Me.btnSelectLast5.Size = New System.Drawing.Size(110, 23)
        Me.btnSelectLast5.TabIndex = 2
        Me.btnSelectLast5.Text = "Letzte 5 Zeichen selektieren"
        Me.btnSelectLast5.UseVisualStyleBackColor = True
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(86, 3)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(75, 23)
        Me.btnPaste.TabIndex = 1
        Me.btnPaste.Text = "Einfügen"
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'btnCopyTxt
        '
        Me.btnCopyTxt.Location = New System.Drawing.Point(5, 3)
        Me.btnCopyTxt.Name = "btnCopyTxt"
        Me.btnCopyTxt.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyTxt.TabIndex = 0
        Me.btnCopyTxt.Text = "Kopieren"
        Me.btnCopyTxt.UseVisualStyleBackColor = True
        '
        'tbxEdit
        '
        Me.tbxEdit.BackColor = System.Drawing.SystemColors.Info
        Me.tbxEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxEdit.Location = New System.Drawing.Point(3, 64)
        Me.tbxEdit.Multiline = True
        Me.tbxEdit.Name = "tbxEdit"
        Me.tbxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxEdit.Size = New System.Drawing.Size(684, 461)
        Me.tbxEdit.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 600)
        Me.Name = "Form1"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxEdit As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopyTxt As System.Windows.Forms.Button
    Friend WithEvents btnSelectLast5 As System.Windows.Forms.Button

End Class
