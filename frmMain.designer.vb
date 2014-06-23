<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkLeft = New System.Windows.Forms.CheckBox()
        Me.chkRight = New System.Windows.Forms.CheckBox()
        Me.chkDown = New System.Windows.Forms.CheckBox()
        Me.chkUp = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.picGrid = New System.Windows.Forms.PictureBox()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(105, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(419, 22)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLeft)
        Me.GroupBox1.Controls.Add(Me.chkRight)
        Me.GroupBox1.Controls.Add(Me.chkDown)
        Me.GroupBox1.Controls.Add(Me.chkUp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtItems)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(524, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 500)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'chkLeft
        '
        Me.chkLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkLeft.Location = New System.Drawing.Point(199, 372)
        Me.chkLeft.Name = "chkLeft"
        Me.chkLeft.Size = New System.Drawing.Size(64, 23)
        Me.chkLeft.TabIndex = 3
        Me.chkLeft.Text = "Left"
        Me.chkLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkLeft.UseVisualStyleBackColor = True
        '
        'chkRight
        '
        Me.chkRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkRight.Location = New System.Drawing.Point(339, 371)
        Me.chkRight.Name = "chkRight"
        Me.chkRight.Size = New System.Drawing.Size(64, 25)
        Me.chkRight.TabIndex = 3
        Me.chkRight.Text = "Right"
        Me.chkRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkRight.UseVisualStyleBackColor = True
        '
        'chkDown
        '
        Me.chkDown.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkDown.Location = New System.Drawing.Point(269, 388)
        Me.chkDown.Name = "chkDown"
        Me.chkDown.Size = New System.Drawing.Size(64, 24)
        Me.chkDown.TabIndex = 3
        Me.chkDown.Text = "Down"
        Me.chkDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDown.UseVisualStyleBackColor = True
        '
        'chkUp
        '
        Me.chkUp.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkUp.Location = New System.Drawing.Point(269, 357)
        Me.chkUp.Name = "chkUp"
        Me.chkUp.Size = New System.Drawing.Size(64, 25)
        Me.chkUp.TabIndex = 3
        Me.chkUp.Text = "Up"
        Me.chkUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkUp.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Blocked Directions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(105, 64)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(419, 225)
        Me.txtDescription.TabIndex = 0
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(105, 314)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(419, 22)
        Me.txtItems.TabIndex = 0
        '
        'picGrid
        '
        Me.picGrid.Location = New System.Drawing.Point(12, 51)
        Me.picGrid.Name = "picGrid"
        Me.picGrid.Size = New System.Drawing.Size(501, 501)
        Me.picGrid.TabIndex = 5
        Me.picGrid.TabStop = False
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(1078, 28)
        Me.menuStrip.TabIndex = 6
        Me.menuStrip.Text = "mnuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.LoadToolStripMenuItem.Text = "&Load"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'saveFile
        '
        Me.saveFile.Filter = "Text Files (*.txt)|*.txt"
        Me.saveFile.Title = "Select location to save file..."
        '
        'openFile
        '
        Me.openFile.Filter = "Text Files (*.txt)|*.txt"
        Me.openFile.Title = "Select the file to open..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 564)
        Me.Controls.Add(Me.picGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BTME"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLeft As System.Windows.Forms.CheckBox
    Friend WithEvents chkRight As System.Windows.Forms.CheckBox
    Friend WithEvents chkDown As System.Windows.Forms.CheckBox
    Friend WithEvents chkUp As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtItems As System.Windows.Forms.TextBox
    Friend WithEvents picGrid As System.Windows.Forms.PictureBox
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openFile As System.Windows.Forms.OpenFileDialog

End Class
