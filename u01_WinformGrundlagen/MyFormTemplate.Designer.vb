<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyFormTemplate
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


    'Shared Function GetColor() As System.Drawing.Color
    '    Return Color.Red
    'End Function

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyFormTemplate))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBarMain = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageMainLog = New System.Windows.Forms.TabPage()
        Me.lbxMainLog = New System.Windows.Forms.ListBox()
        Me.panMainLogCtrl = New System.Windows.Forms.Panel()
        Me.btnMainLogClear = New System.Windows.Forms.Button()
        Me.btnMainLogGenTestmessage = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageMainLog.SuspendLayout()
        Me.panMainLogCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SichernToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.ShowShortcutKeys = False
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelMain, Me.ToolStripProgressBarMain})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(586, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelMain
        '
        Me.ToolStripStatusLabelMain.Name = "ToolStripStatusLabelMain"
        Me.ToolStripStatusLabelMain.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabelMain.Text = "Bereit"
        '
        'ToolStripProgressBarMain
        '
        Me.ToolStripProgressBarMain.Name = "ToolStripProgressBarMain"
        Me.ToolStripProgressBarMain.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBarMain.Value = 33
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageMainLog)
        Me.TabControlMain.Controls.Add(Me.TabPage2)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 24)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(586, 419)
        Me.TabControlMain.TabIndex = 4
        '
        'TabPageMainLog
        '
        Me.TabPageMainLog.Controls.Add(Me.lbxMainLog)
        Me.TabPageMainLog.Controls.Add(Me.panMainLogCtrl)
        Me.TabPageMainLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMainLog.Name = "TabPageMainLog"
        Me.TabPageMainLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMainLog.Size = New System.Drawing.Size(578, 393)
        Me.TabPageMainLog.TabIndex = 0
        Me.TabPageMainLog.Text = "Log"
        Me.TabPageMainLog.UseVisualStyleBackColor = True
        '
        'lbxMainLog
        '
        Me.lbxMainLog.BackColor = System.Drawing.Color.Black
        Me.lbxMainLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxMainLog.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMainLog.ForeColor = System.Drawing.Color.White
        Me.lbxMainLog.FormattingEnabled = True
        Me.lbxMainLog.Location = New System.Drawing.Point(3, 66)
        Me.lbxMainLog.Name = "lbxMainLog"
        Me.lbxMainLog.Size = New System.Drawing.Size(572, 324)
        Me.lbxMainLog.TabIndex = 1
        '
        'panMainLogCtrl
        '
        Me.panMainLogCtrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panMainLogCtrl.Controls.Add(Me.btnMainLogClear)
        Me.panMainLogCtrl.Controls.Add(Me.btnMainLogGenTestmessage)
        Me.panMainLogCtrl.Dock = System.Windows.Forms.DockStyle.Top
        Me.panMainLogCtrl.Location = New System.Drawing.Point(3, 3)
        Me.panMainLogCtrl.Name = "panMainLogCtrl"
        Me.panMainLogCtrl.Size = New System.Drawing.Size(572, 63)
        Me.panMainLogCtrl.TabIndex = 0
        '
        'btnMainLogClear
        '
        Me.btnMainLogClear.Location = New System.Drawing.Point(163, 14)
        Me.btnMainLogClear.Name = "btnMainLogClear"
        Me.btnMainLogClear.Size = New System.Drawing.Size(121, 23)
        Me.btnMainLogClear.TabIndex = 1
        Me.btnMainLogClear.Text = "Alle löschen"
        Me.btnMainLogClear.UseVisualStyleBackColor = True
        '
        'btnMainLogGenTestmessage
        '
        Me.btnMainLogGenTestmessage.Location = New System.Drawing.Point(5, 14)
        Me.btnMainLogGenTestmessage.Name = "btnMainLogGenTestmessage"
        Me.btnMainLogGenTestmessage.Size = New System.Drawing.Size(152, 23)
        Me.btnMainLogGenTestmessage.TabIndex = 0
        Me.btnMainLogGenTestmessage.Text = "Testmessage erzeugen"
        Me.btnMainLogGenTestmessage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(578, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÖffnenToolStripMenuItem.Text = "öffnen"
        '
        'SichernToolStripMenuItem
        '
        Me.SichernToolStripMenuItem.Name = "SichernToolStripMenuItem"
        Me.SichernToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SichernToolStripMenuItem.Text = "sichern"
        '
        'MyFormTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 465)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyFormTemplate"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageMainLog.ResumeLayout(False)
        Me.panMainLogCtrl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBarMain As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabPageMainLog As System.Windows.Forms.TabPage
    Friend WithEvents lbxMainLog As System.Windows.Forms.ListBox
    Friend WithEvents panMainLogCtrl As System.Windows.Forms.Panel
    Friend WithEvents btnMainLogClear As System.Windows.Forms.Button
    Friend WithEvents btnMainLogGenTestmessage As System.Windows.Forms.Button
    Protected WithEvents TabControlMain As System.Windows.Forms.TabControl
    Protected WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
