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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxComboBox1 = New AxMicrosoft.Vbe.Interop.Forms.AxComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AxTV1 = New AxCTVLib.AxTV()
        CType(Me.AxComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxTV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxComboBox1
        '
        Me.AxComboBox1.Location = New System.Drawing.Point(22, 38)
        Me.AxComboBox1.Name = "AxComboBox1"
        Me.AxComboBox1.OcxState = CType(resources.GetObject("AxComboBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxComboBox1.Size = New System.Drawing.Size(96, 24)
        Me.AxComboBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'AxTV1
        '
        Me.AxTV1.Enabled = True
        Me.AxTV1.Location = New System.Drawing.Point(22, 97)
        Me.AxTV1.Name = "AxTV1"
        Me.AxTV1.OcxState = CType(resources.GetObject("AxTV1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTV1.Size = New System.Drawing.Size(100, 50)
        Me.AxTV1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.AxTV1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AxComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxTV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxComboBox1 As AxMicrosoft.Vbe.Interop.Forms.AxComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AxTV1 As AxCTVLib.AxTV

End Class
