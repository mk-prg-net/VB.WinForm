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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Merkur")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Venus")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Apollo 11")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mond", 2, 3, New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Erde", New System.Windows.Forms.TreeNode() {TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IO")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Europa")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ganymede")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Callisto")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jupiter", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Phobos")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deimos")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mars", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solarsystem", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode17, TreeNode20, TreeNode25, TreeNode28})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.trvSolarSystem = New System.Windows.Forms.TreeView()
        Me.ImageListSolarSystem = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxDeept = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxNodeName = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.trvFileSystem = New System.Windows.Forms.TreeView()
        Me.ImageListFileSystem = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FolderBrowserDialogSelectRoot = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBoxDateisystem = New System.Windows.Forms.PictureBox()
        Me.TabControlMain.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBoxDateisystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPage1)
        Me.TabControlMain.Controls.SetChildIndex(Me.TabPage1, 0)
        Me.TabControlMain.Controls.SetChildIndex(Me.TabPage2, 0)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Text = "Solarsystem"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.trvSolarSystem)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Navy
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxDeept)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxNodeName)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.Yellow
        Me.SplitContainer1.Size = New System.Drawing.Size(572, 387)
        Me.SplitContainer1.SplitterDistance = 242
        Me.SplitContainer1.TabIndex = 0
        '
        'trvSolarSystem
        '
        Me.trvSolarSystem.BackColor = System.Drawing.Color.Black
        Me.trvSolarSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvSolarSystem.ForeColor = System.Drawing.Color.White
        Me.trvSolarSystem.ImageIndex = 0
        Me.trvSolarSystem.ImageList = Me.ImageListSolarSystem
        Me.trvSolarSystem.Location = New System.Drawing.Point(0, 0)
        Me.trvSolarSystem.Name = "trvSolarSystem"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "Merkur"
        TreeNode1.Text = "Merkur"
        TreeNode17.ImageIndex = 1
        TreeNode17.Name = "Venus"
        TreeNode17.Text = "Venus"
        TreeNode18.ImageIndex = 5
        TreeNode18.Name = "Apollo"
        TreeNode18.Text = "Apollo 11"
        TreeNode19.ImageIndex = 2
        TreeNode19.Name = "Mond"
        TreeNode19.SelectedImageIndex = 3
        TreeNode19.Text = "Mond"
        TreeNode20.ImageIndex = 1
        TreeNode20.Name = "Erde"
        TreeNode20.Text = "Erde"
        TreeNode21.ImageIndex = 2
        TreeNode21.Name = "IO"
        TreeNode21.Text = "IO"
        TreeNode22.ImageIndex = 2
        TreeNode22.Name = "Europa"
        TreeNode22.Text = "Europa"
        TreeNode23.ImageIndex = 2
        TreeNode23.Name = "Ganymede"
        TreeNode23.Text = "Ganymede"
        TreeNode24.ImageIndex = 2
        TreeNode24.Name = "Callisto"
        TreeNode24.Text = "Callisto"
        TreeNode25.ImageIndex = 1
        TreeNode25.Name = "Jupiter"
        TreeNode25.Text = "Jupiter"
        TreeNode26.ImageIndex = 2
        TreeNode26.Name = "Phobos"
        TreeNode26.Text = "Phobos"
        TreeNode27.ImageIndex = 2
        TreeNode27.Name = "Deimos"
        TreeNode27.Text = "Deimos"
        TreeNode28.ImageIndex = 1
        TreeNode28.Name = "Mars"
        TreeNode28.Text = "Mars"
        TreeNode29.Name = "Solarsystem"
        TreeNode29.Text = "Solarsystem"
        Me.trvSolarSystem.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode29})
        Me.trvSolarSystem.SelectedImageIndex = 0
        Me.trvSolarSystem.Size = New System.Drawing.Size(242, 387)
        Me.trvSolarSystem.TabIndex = 0
        '
        'ImageListSolarSystem
        '
        Me.ImageListSolarSystem.ImageStream = CType(resources.GetObject("ImageListSolarSystem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListSolarSystem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListSolarSystem.Images.SetKeyName(0, "Sonne-Black.bmp")
        Me.ImageListSolarSystem.Images.SetKeyName(1, "Planet-2-Black.bmp")
        Me.ImageListSolarSystem.Images.SetKeyName(2, "Mond-Black.bmp")
        Me.ImageListSolarSystem.Images.SetKeyName(3, "Asteroid-Black.bmp")
        Me.ImageListSolarSystem.Images.SetKeyName(4, "Komet-Black.bmp")
        Me.ImageListSolarSystem.Images.SetKeyName(5, "Raumschiff-Black.bmp")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tiefe"
        '
        'tbxDeept
        '
        Me.tbxDeept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxDeept.Location = New System.Drawing.Point(246, 79)
        Me.tbxDeept.Name = "tbxDeept"
        Me.tbxDeept.Size = New System.Drawing.Size(65, 20)
        Me.tbxDeept.TabIndex = 4
        Me.tbxDeept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pfad"
        '
        'tbxPath
        '
        Me.tbxPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxPath.Location = New System.Drawing.Point(14, 27)
        Me.tbxPath.Name = "tbxPath"
        Me.tbxPath.Size = New System.Drawing.Size(297, 20)
        Me.tbxPath.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'tbxNodeName
        '
        Me.tbxNodeName.Location = New System.Drawing.Point(14, 79)
        Me.tbxNodeName.Name = "tbxNodeName"
        Me.tbxNodeName.Size = New System.Drawing.Size(226, 20)
        Me.tbxNodeName.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(578, 393)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Dateisystem"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.trvFileSystem)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.PictureBoxDateisystem)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(572, 387)
        Me.SplitContainer2.SplitterDistance = 190
        Me.SplitContainer2.TabIndex = 0
        '
        'trvFileSystem
        '
        Me.trvFileSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvFileSystem.ImageIndex = 0
        Me.trvFileSystem.ImageList = Me.ImageListFileSystem
        Me.trvFileSystem.Location = New System.Drawing.Point(0, 0)
        Me.trvFileSystem.Name = "trvFileSystem"
        TreeNode16.Name = "Root"
        TreeNode16.Text = "Root"
        Me.trvFileSystem.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.trvFileSystem.SelectedImageIndex = 0
        Me.trvFileSystem.Size = New System.Drawing.Size(190, 387)
        Me.trvFileSystem.TabIndex = 0
        '
        'ImageListFileSystem
        '
        Me.ImageListFileSystem.ImageStream = CType(resources.GetObject("ImageListFileSystem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListFileSystem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListFileSystem.Images.SetKeyName(0, "WebFormTemplate_11274_32x.png")
        Me.ImageListFileSystem.Images.SetKeyName(1, "Folder_6222.png")
        Me.ImageListFileSystem.Images.SetKeyName(2, "Folder_6221.png")
        Me.ImageListFileSystem.Images.SetKeyName(3, "Textfile_818_32x.png")
        Me.ImageListFileSystem.Images.SetKeyName(4, "Image_24x.png")
        Me.ImageListFileSystem.Images.SetKeyName(5, "HotSpot_10548_color.png")
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 49)
        Me.Panel1.TabIndex = 0
        '
        'PictureBoxDateisystem
        '
        Me.PictureBoxDateisystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxDateisystem.Location = New System.Drawing.Point(0, 49)
        Me.PictureBoxDateisystem.Name = "PictureBoxDateisystem"
        Me.PictureBoxDateisystem.Size = New System.Drawing.Size(378, 338)
        Me.PictureBoxDateisystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxDateisystem.TabIndex = 1
        Me.PictureBoxDateisystem.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 465)
        Me.Name = "Form1"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBoxDateisystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents trvSolarSystem As System.Windows.Forms.TreeView
    Friend WithEvents ImageListSolarSystem As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxDeept As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxNodeName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents trvFileSystem As System.Windows.Forms.TreeView
    Friend WithEvents ImageListFileSystem As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FolderBrowserDialogSelectRoot As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PictureBoxDateisystem As System.Windows.Forms.PictureBox

End Class
