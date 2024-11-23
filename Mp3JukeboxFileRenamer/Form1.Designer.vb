<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Fill = New System.Windows.Forms.Panel()
        Me.RichTextBox_Log = New System.Windows.Forms.RichTextBox()
        Me.Panel_Bottom = New System.Windows.Forms.Panel()
        Me.CheckBox_TestRun = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Remove = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Add = New System.Windows.Forms.RadioButton()
        Me.Label_Directory = New System.Windows.Forms.Label()
        Me.Button_Go = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Fill.SuspendLayout()
        Me.Panel_Bottom.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HepToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(973, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenDirectoryToolStripMenuItem
        '
        Me.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem"
        Me.OpenDirectoryToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.OpenDirectoryToolStripMenuItem.Text = "Open Directory"
        '
        'HepToolStripMenuItem
        '
        Me.HepToolStripMenuItem.Name = "HepToolStripMenuItem"
        Me.HepToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HepToolStripMenuItem.Text = "Help"
        '
        'Panel_Fill
        '
        Me.Panel_Fill.Controls.Add(Me.RichTextBox_Log)
        Me.Panel_Fill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Fill.Location = New System.Drawing.Point(0, 24)
        Me.Panel_Fill.Name = "Panel_Fill"
        Me.Panel_Fill.Size = New System.Drawing.Size(973, 470)
        Me.Panel_Fill.TabIndex = 1
        '
        'RichTextBox_Log
        '
        Me.RichTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox_Log.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox_Log.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox_Log.Name = "RichTextBox_Log"
        Me.RichTextBox_Log.ReadOnly = True
        Me.RichTextBox_Log.Size = New System.Drawing.Size(973, 470)
        Me.RichTextBox_Log.TabIndex = 0
        Me.RichTextBox_Log.Text = ""
        '
        'Panel_Bottom
        '
        Me.Panel_Bottom.Controls.Add(Me.CheckBox_TestRun)
        Me.Panel_Bottom.Controls.Add(Me.GroupBox1)
        Me.Panel_Bottom.Controls.Add(Me.Label_Directory)
        Me.Panel_Bottom.Controls.Add(Me.Button_Go)
        Me.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Bottom.Location = New System.Drawing.Point(0, 406)
        Me.Panel_Bottom.Name = "Panel_Bottom"
        Me.Panel_Bottom.Size = New System.Drawing.Size(973, 88)
        Me.Panel_Bottom.TabIndex = 2
        '
        'CheckBox_TestRun
        '
        Me.CheckBox_TestRun.AutoSize = True
        Me.CheckBox_TestRun.Location = New System.Drawing.Point(12, 61)
        Me.CheckBox_TestRun.Name = "CheckBox_TestRun"
        Me.CheckBox_TestRun.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox_TestRun.TabIndex = 5
        Me.CheckBox_TestRun.Text = "Test Run Only"
        Me.CheckBox_TestRun.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_Remove)
        Me.GroupBox1.Controls.Add(Me.RadioButton_Add)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 51)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_Remove
        '
        Me.RadioButton_Remove.AutoSize = True
        Me.RadioButton_Remove.Location = New System.Drawing.Point(10, 28)
        Me.RadioButton_Remove.Name = "RadioButton_Remove"
        Me.RadioButton_Remove.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton_Remove.TabIndex = 1
        Me.RadioButton_Remove.TabStop = True
        Me.RadioButton_Remove.Text = "Remove Numbering"
        Me.RadioButton_Remove.UseVisualStyleBackColor = True
        '
        'RadioButton_Add
        '
        Me.RadioButton_Add.AutoSize = True
        Me.RadioButton_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RadioButton_Add.Location = New System.Drawing.Point(10, 6)
        Me.RadioButton_Add.Name = "RadioButton_Add"
        Me.RadioButton_Add.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton_Add.TabIndex = 0
        Me.RadioButton_Add.TabStop = True
        Me.RadioButton_Add.Text = "Add Numbering"
        Me.RadioButton_Add.UseVisualStyleBackColor = True
        '
        'Label_Directory
        '
        Me.Label_Directory.AutoSize = True
        Me.Label_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Directory.Location = New System.Drawing.Point(334, 63)
        Me.Label_Directory.Name = "Label_Directory"
        Me.Label_Directory.Size = New System.Drawing.Size(0, 16)
        Me.Label_Directory.TabIndex = 3
        '
        'Button_Go
        '
        Me.Button_Go.Enabled = False
        Me.Button_Go.Location = New System.Drawing.Point(193, 55)
        Me.Button_Go.Name = "Button_Go"
        Me.Button_Go.Size = New System.Drawing.Size(117, 23)
        Me.Button_Go.TabIndex = 2
        Me.Button_Go.Text = "Start"
        Me.Button_Go.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 494)
        Me.Controls.Add(Me.Panel_Bottom)
        Me.Controls.Add(Me.Panel_Fill)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Mp3 File Renamer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Fill.ResumeLayout(False)
        Me.Panel_Bottom.ResumeLayout(False)
        Me.Panel_Bottom.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel_Fill As System.Windows.Forms.Panel
    Friend WithEvents Panel_Bottom As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox_Log As System.Windows.Forms.RichTextBox
    Friend WithEvents Button_Go As System.Windows.Forms.Button
    Friend WithEvents Label_Directory As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Remove As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Add As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_TestRun As System.Windows.Forms.CheckBox

End Class
