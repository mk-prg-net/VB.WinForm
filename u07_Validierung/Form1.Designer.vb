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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxA = New System.Windows.Forms.TextBox()
        Me.tbxB = New System.Windows.Forms.TextBox()
        Me.lblStatA = New System.Windows.Forms.Label()
        Me.lblStatB = New System.Windows.Forms.Label()
        Me.tbxRes = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxA, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatA, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatB, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxRes, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(653, 198)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B="
        '
        'tbxA
        '
        Me.tbxA.Location = New System.Drawing.Point(153, 3)
        Me.tbxA.Name = "tbxA"
        Me.tbxA.Size = New System.Drawing.Size(100, 20)
        Me.tbxA.TabIndex = 2
        Me.tbxA.Text = "0"
        Me.tbxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxB
        '
        Me.tbxB.Location = New System.Drawing.Point(153, 43)
        Me.tbxB.Name = "tbxB"
        Me.tbxB.Size = New System.Drawing.Size(100, 20)
        Me.tbxB.TabIndex = 3
        Me.tbxB.Text = "0"
        Me.tbxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStatA
        '
        Me.lblStatA.AutoSize = True
        Me.lblStatA.Location = New System.Drawing.Point(303, 0)
        Me.lblStatA.Name = "lblStatA"
        Me.lblStatA.Size = New System.Drawing.Size(19, 13)
        Me.lblStatA.TabIndex = 4
        Me.lblStatA.Text = "ok"
        '
        'lblStatB
        '
        Me.lblStatB.AutoSize = True
        Me.lblStatB.Location = New System.Drawing.Point(303, 40)
        Me.lblStatB.Name = "lblStatB"
        Me.lblStatB.Size = New System.Drawing.Size(19, 13)
        Me.lblStatB.TabIndex = 5
        Me.lblStatB.Text = "ok"
        '
        'tbxRes
        '
        Me.tbxRes.Location = New System.Drawing.Point(153, 83)
        Me.tbxRes.Name = "tbxRes"
        Me.tbxRes.Size = New System.Drawing.Size(100, 20)
        Me.tbxRes.TabIndex = 6
        Me.tbxRes.Text = "0"
        Me.tbxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 198)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxA As System.Windows.Forms.TextBox
    Friend WithEvents tbxB As System.Windows.Forms.TextBox
    Friend WithEvents lblStatA As System.Windows.Forms.Label
    Friend WithEvents lblStatB As System.Windows.Forms.Label
    Friend WithEvents tbxRes As System.Windows.Forms.TextBox

End Class
