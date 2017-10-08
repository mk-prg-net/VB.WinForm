<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form

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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSin2x = New System.Windows.Forms.Button()
        Me.btnGenSinus = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBoxAktivierbar1 = New u08_ControlsLib.TextBoxAktivierbar()
        Me.DefInteger1 = New u08_ControlsLib.DefInteger()
        Me.DefSampleCount = New u08_ControlsLib.DefInteger()
        Me.DefIntervalGenerators = New u08_ControlsLib.DefInterval()
        Me.btnProcessTbx = New System.Windows.Forms.Button()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Size = New System.Drawing.Size(922, 419)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Size = New System.Drawing.Size(914, 393)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnProcessTbx)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxAktivierbar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DefInteger1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DefSampleCount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DefIntervalGenerators)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSin2x)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGenSinus)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Size = New System.Drawing.Size(908, 387)
        Me.SplitContainer1.SplitterDistance = 343
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Intervall"
        '
        'btnSin2x
        '
        Me.btnSin2x.Location = New System.Drawing.Point(8, 124)
        Me.btnSin2x.Name = "btnSin2x"
        Me.btnSin2x.Size = New System.Drawing.Size(167, 23)
        Me.btnSin2x.TabIndex = 1
        Me.btnSin2x.Text = "y = sin(2x)"
        Me.btnSin2x.UseVisualStyleBackColor = True
        '
        'btnGenSinus
        '
        Me.btnGenSinus.Location = New System.Drawing.Point(8, 95)
        Me.btnGenSinus.Name = "btnGenSinus"
        Me.btnGenSinus.Size = New System.Drawing.Size(168, 23)
        Me.btnGenSinus.TabIndex = 0
        Me.btnGenSinus.Text = "y = sin(x)"
        Me.btnGenSinus.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(561, 387)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TextBoxAktivierbar1
        '
        Me.TextBoxAktivierbar1.Caption = "Meine Beschriftung"
        Me.TextBoxAktivierbar1.Location = New System.Drawing.Point(8, 269)
        Me.TextBoxAktivierbar1.Name = "TextBoxAktivierbar1"
        Me.TextBoxAktivierbar1.Size = New System.Drawing.Size(218, 42)
        Me.TextBoxAktivierbar1.TabIndex = 6
        '
        'DefInteger1
        '
        Me.DefInteger1.BackColor = System.Drawing.SystemColors.Window
        Me.DefInteger1.Caption = "Caption"
        Me.DefInteger1.Location = New System.Drawing.Point(32, 193)
        Me.DefInteger1.Name = "DefInteger1"
        Me.DefInteger1.Size = New System.Drawing.Size(79, 45)
        Me.DefInteger1.TabIndex = 5
        Me.DefInteger1.Value = 0
        '
        'DefSampleCount
        '
        Me.DefSampleCount.BackColor = System.Drawing.SystemColors.Window
        Me.DefSampleCount.Caption = "#Samples"
        Me.DefSampleCount.Location = New System.Drawing.Point(245, 28)
        Me.DefSampleCount.Name = "DefSampleCount"
        Me.DefSampleCount.Size = New System.Drawing.Size(79, 47)
        Me.DefSampleCount.TabIndex = 4
        Me.DefSampleCount.Value = 100
        '
        'DefIntervalGenerators
        '
        Me.DefIntervalGenerators.BackColor = System.Drawing.SystemColors.Window
        Me.DefIntervalGenerators.Location = New System.Drawing.Point(8, 28)
        Me.DefIntervalGenerators.Name = "DefIntervalGenerators"
        Me.DefIntervalGenerators.Size = New System.Drawing.Size(231, 47)
        Me.DefIntervalGenerators.TabIndex = 2
        '
        'btnProcessTbx
        '
        Me.btnProcessTbx.Location = New System.Drawing.Point(8, 317)
        Me.btnProcessTbx.Name = "btnProcessTbx"
        Me.btnProcessTbx.Size = New System.Drawing.Size(156, 23)
        Me.btnProcessTbx.TabIndex = 7
        Me.btnProcessTbx.Text = "Meine aktivierbare Textbox auswerten"
        Me.btnProcessTbx.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 465)
        Me.Name = "Form1"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnGenSinus As System.Windows.Forms.Button
    Friend WithEvents btnSin2x As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefIntervalGenerators As u08_ControlsLib.DefInterval
    Friend WithEvents DefSampleCount As u08_ControlsLib.DefInteger
    Friend WithEvents DefInteger1 As u08_ControlsLib.DefInteger
    Friend WithEvents TextBoxAktivierbar1 As u08_ControlsLib.TextBoxAktivierbar
    Friend WithEvents btnProcessTbx As System.Windows.Forms.Button

End Class
