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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnUpdatePalette = New System.Windows.Forms.Button()
        Me.tbxColorBlue = New System.Windows.Forms.TextBox()
        Me.tbxColorGreen = New System.Windows.Forms.TextBox()
        Me.tbxColorRed = New System.Windows.Forms.TextBox()
        Me.btnShowSelected = New System.Windows.Forms.Button()
        Me.lbxDemo = New System.Windows.Forms.ListBox()
        Me.BindingSourceLbxDemo = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lbxKaffeeinhalt = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProduceCoffe = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxMulti = New System.Windows.Forms.ListBox()
        Me.BindingSourceKaffezusatz = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cobCoffe = New System.Windows.Forms.ComboBox()
        Me.BindingSourceCbxCoffe = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxSelectedCoffe = New System.Windows.Forms.TextBox()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BindingSourceLbxDemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BindingSourceKaffezusatz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingSourceCbxCoffe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPage1)
        Me.TabControlMain.Controls.Add(Me.TabPage3)
        Me.TabControlMain.Size = New System.Drawing.Size(706, 486)
        Me.TabControlMain.Controls.SetChildIndex(Me.TabPage3, 0)
        Me.TabControlMain.Controls.SetChildIndex(Me.TabPage1, 0)
        Me.TabControlMain.Controls.SetChildIndex(Me.TabPage2, 0)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Size = New System.Drawing.Size(698, 460)
        Me.TabPage2.Text = "ListBox Single Select"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdatePalette)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbxColorBlue)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbxColorGreen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbxColorRed)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnShowSelected)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbxDemo)
        Me.SplitContainer1.Size = New System.Drawing.Size(692, 454)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.TabIndex = 0
        '
        'btnUpdatePalette
        '
        Me.btnUpdatePalette.Location = New System.Drawing.Point(20, 95)
        Me.btnUpdatePalette.Name = "btnUpdatePalette"
        Me.btnUpdatePalette.Size = New System.Drawing.Size(159, 23)
        Me.btnUpdatePalette.TabIndex = 4
        Me.btnUpdatePalette.Text = "Aktualisieren"
        Me.btnUpdatePalette.UseVisualStyleBackColor = True
        '
        'tbxColorBlue
        '
        Me.tbxColorBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxColorBlue.Location = New System.Drawing.Point(130, 59)
        Me.tbxColorBlue.Name = "tbxColorBlue"
        Me.tbxColorBlue.Size = New System.Drawing.Size(49, 20)
        Me.tbxColorBlue.TabIndex = 3
        '
        'tbxColorGreen
        '
        Me.tbxColorGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbxColorGreen.Location = New System.Drawing.Point(76, 59)
        Me.tbxColorGreen.Name = "tbxColorGreen"
        Me.tbxColorGreen.Size = New System.Drawing.Size(48, 20)
        Me.tbxColorGreen.TabIndex = 2
        '
        'tbxColorRed
        '
        Me.tbxColorRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbxColorRed.Location = New System.Drawing.Point(20, 59)
        Me.tbxColorRed.Name = "tbxColorRed"
        Me.tbxColorRed.Size = New System.Drawing.Size(48, 20)
        Me.tbxColorRed.TabIndex = 1
        '
        'btnShowSelected
        '
        Me.btnShowSelected.Location = New System.Drawing.Point(20, 20)
        Me.btnShowSelected.Name = "btnShowSelected"
        Me.btnShowSelected.Size = New System.Drawing.Size(159, 23)
        Me.btnShowSelected.TabIndex = 0
        Me.btnShowSelected.Text = "Auswahl anzeigen"
        Me.btnShowSelected.UseVisualStyleBackColor = True
        '
        'lbxDemo
        '
        Me.lbxDemo.DataSource = Me.BindingSourceLbxDemo
        Me.lbxDemo.DisplayMember = "ColorName"
        Me.lbxDemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxDemo.FormattingEnabled = True
        Me.lbxDemo.Location = New System.Drawing.Point(0, 0)
        Me.lbxDemo.Name = "lbxDemo"
        Me.lbxDemo.Size = New System.Drawing.Size(471, 454)
        Me.lbxDemo.TabIndex = 0
        Me.lbxDemo.ValueMember = "GetMe"
        '
        'BindingSourceLbxDemo
        '
        Me.BindingSourceLbxDemo.DataSource = GetType(u11_Listbox_Combobox.ColorItem)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(578, 393)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Multiselect"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbxKaffeeinhalt)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnProduceCoffe)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(572, 387)
        Me.SplitContainer2.SplitterDistance = 190
        Me.SplitContainer2.TabIndex = 0
        '
        'lbxKaffeeinhalt
        '
        Me.lbxKaffeeinhalt.FormattingEnabled = True
        Me.lbxKaffeeinhalt.Location = New System.Drawing.Point(18, 71)
        Me.lbxKaffeeinhalt.Name = "lbxKaffeeinhalt"
        Me.lbxKaffeeinhalt.Size = New System.Drawing.Size(191, 199)
        Me.lbxKaffeeinhalt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kaffe mit:"
        '
        'btnProduceCoffe
        '
        Me.btnProduceCoffe.Location = New System.Drawing.Point(15, 24)
        Me.btnProduceCoffe.Name = "btnProduceCoffe"
        Me.btnProduceCoffe.Size = New System.Drawing.Size(194, 23)
        Me.btnProduceCoffe.TabIndex = 0
        Me.btnProduceCoffe.Text = "gewünschten Kaffe kochen"
        Me.btnProduceCoffe.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbxMulti, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.030837!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.96916!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(378, 387)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bitte Kaffezusätze wählen"
        '
        'lbxMulti
        '
        Me.lbxMulti.DataSource = Me.BindingSourceKaffezusatz
        Me.lbxMulti.DisplayMember = "Name"
        Me.lbxMulti.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbxMulti.FormattingEnabled = True
        Me.lbxMulti.Location = New System.Drawing.Point(3, 37)
        Me.lbxMulti.Name = "lbxMulti"
        Me.lbxMulti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbxMulti.Size = New System.Drawing.Size(202, 347)
        Me.lbxMulti.TabIndex = 1
        Me.lbxMulti.ValueMember = "GetMe"
        '
        'BindingSourceKaffezusatz
        '
        Me.BindingSourceKaffezusatz.DataSource = GetType(u11_Listbox_Combobox.Kafeezusatz)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tbxSelectedCoffe)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.cobCoffe)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(698, 460)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "ComboBox"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cobCoffe
        '
        Me.cobCoffe.DataSource = Me.BindingSourceCbxCoffe
        Me.cobCoffe.DisplayMember = "Name"
        Me.cobCoffe.FormattingEnabled = True
        Me.cobCoffe.Location = New System.Drawing.Point(8, 41)
        Me.cobCoffe.Name = "cobCoffe"
        Me.cobCoffe.Size = New System.Drawing.Size(121, 21)
        Me.cobCoffe.TabIndex = 0
        Me.cobCoffe.ValueMember = "GetMe"
        '
        'BindingSourceCbxCoffe
        '
        Me.BindingSourceCbxCoffe.DataSource = GetType(u11_Listbox_Combobox.Kafeezusatz)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ihre Auswahl:"
        '
        'tbxSelectedCoffe
        '
        Me.tbxSelectedCoffe.Location = New System.Drawing.Point(262, 48)
        Me.tbxSelectedCoffe.Name = "tbxSelectedCoffe"
        Me.tbxSelectedCoffe.Size = New System.Drawing.Size(100, 20)
        Me.tbxSelectedCoffe.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 532)
        Me.Name = "Form1"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BindingSourceLbxDemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BindingSourceKaffezusatz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BindingSourceCbxCoffe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbxDemo As System.Windows.Forms.ListBox
    Friend WithEvents BindingSourceLbxDemo As System.Windows.Forms.BindingSource
    Friend WithEvents tbxColorBlue As System.Windows.Forms.TextBox
    Friend WithEvents tbxColorGreen As System.Windows.Forms.TextBox
    Friend WithEvents tbxColorRed As System.Windows.Forms.TextBox
    Friend WithEvents btnShowSelected As System.Windows.Forms.Button
    Friend WithEvents btnUpdatePalette As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbxMulti As System.Windows.Forms.ListBox
    Friend WithEvents BindingSourceKaffezusatz As System.Windows.Forms.BindingSource
    Friend WithEvents lbxKaffeeinhalt As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProduceCoffe As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents tbxSelectedCoffe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cobCoffe As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSourceCbxCoffe As System.Windows.Forms.BindingSource

End Class
