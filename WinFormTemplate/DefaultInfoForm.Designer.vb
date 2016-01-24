<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefaultInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefaultInfoForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.lblSubVer = New System.Windows.Forms.Label()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblRevision = New System.Windows.Forms.Label()
        Me.tbxVer = New System.Windows.Forms.TextBox()
        Me.tbxSubVer = New System.Windows.Forms.TextBox()
        Me.tbxBuild = New System.Windows.Forms.TextBox()
        Me.tbxRevision = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(541, 229)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnOk, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 187)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(535, 39)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOk.Location = New System.Drawing.Point(179, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(170, 33)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblVer, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSubVer, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblBuild, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblRevision, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.tbxVer, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tbxSubVer, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tbxBuild, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.tbxRevision, 3, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(535, 64)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Location = New System.Drawing.Point(3, 0)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(42, 13)
        Me.lblVer.TabIndex = 0
        Me.lblVer.Text = "Version"
        '
        'lblSubVer
        '
        Me.lblSubVer.AutoSize = True
        Me.lblSubVer.Location = New System.Drawing.Point(136, 0)
        Me.lblSubVer.Name = "lblSubVer"
        Me.lblSubVer.Size = New System.Drawing.Size(60, 13)
        Me.lblSubVer.TabIndex = 1
        Me.lblSubVer.Text = "Subversion"
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.Location = New System.Drawing.Point(269, 0)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(30, 13)
        Me.lblBuild.TabIndex = 2
        Me.lblBuild.Text = "Build"
        '
        'lblRevision
        '
        Me.lblRevision.AutoSize = True
        Me.lblRevision.Location = New System.Drawing.Point(402, 0)
        Me.lblRevision.Name = "lblRevision"
        Me.lblRevision.Size = New System.Drawing.Size(58, 13)
        Me.lblRevision.TabIndex = 3
        Me.lblRevision.Text = "lblRevision"
        '
        'tbxVer
        '
        Me.tbxVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxVer.Location = New System.Drawing.Point(3, 35)
        Me.tbxVer.Name = "tbxVer"
        Me.tbxVer.Size = New System.Drawing.Size(127, 20)
        Me.tbxVer.TabIndex = 4
        Me.tbxVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxSubVer
        '
        Me.tbxSubVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxSubVer.Location = New System.Drawing.Point(136, 35)
        Me.tbxSubVer.Name = "tbxSubVer"
        Me.tbxSubVer.Size = New System.Drawing.Size(127, 20)
        Me.tbxSubVer.TabIndex = 5
        Me.tbxSubVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxBuild
        '
        Me.tbxBuild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxBuild.Location = New System.Drawing.Point(269, 35)
        Me.tbxBuild.Name = "tbxBuild"
        Me.tbxBuild.Size = New System.Drawing.Size(127, 20)
        Me.tbxBuild.TabIndex = 6
        Me.tbxBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxRevision
        '
        Me.tbxRevision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxRevision.Location = New System.Drawing.Point(402, 35)
        Me.tbxRevision.Name = "tbxRevision"
        Me.tbxRevision.Size = New System.Drawing.Size(130, 20)
        Me.tbxRevision.TabIndex = 7
        Me.tbxRevision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Einführung in die Entwicklung von Windows Forms Anwendungen"
        '
        'DefaultInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 229)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DefaultInfoForm"
        Me.Text = "Info"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents lblSubVer As System.Windows.Forms.Label
    Friend WithEvents lblBuild As System.Windows.Forms.Label
    Friend WithEvents lblRevision As System.Windows.Forms.Label
    Friend WithEvents tbxVer As System.Windows.Forms.TextBox
    Friend WithEvents tbxSubVer As System.Windows.Forms.TextBox
    Friend WithEvents tbxBuild As System.Windows.Forms.TextBox
    Friend WithEvents tbxRevision As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
