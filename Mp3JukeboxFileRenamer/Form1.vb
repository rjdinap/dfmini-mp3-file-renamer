Imports System.IO



Public Class Form1

    Dim items = New List(Of fileNames)
    Dim folder As String = ""

    Private Sub HepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HepToolStripMenuItem.Click
        Dim msg = "This program will rename all files in a directory to begin with a specific pattern. "
        msg = msg + "xxx - yyy Filename where xxx is the physical number of the mp3 on the sdcard, starting with 001. yyy will be the equivalent "
        msg = msg + "jukebox song number, starting with 100, and continuing to 199. "
        msg = msg + "This code is meant to be used with the jukebox code posted at" + vbCrLf + vbCrLf
        msg = msg + "https://github.com/rjdinap/ArduinoJukeboxR81" + vbCrLf + vbCrLf
        msg = msg + "(It could also be used for any other dfmini mp3 player project)." + vbCrLf + vbCrLf
        msg = msg + "File -> Open a directory. Select 'add numbering' or 'remove numbering' and then press that start button." + vbCrLf + vbCrLf
        msg = msg + "I recommend using the 'test run' function first, and reviewing the output. Then, unselect 'test run' and press the start button to perform the renaming."
        MessageBox.Show(msg, "Help")
    End Sub

    Private Sub OpenDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDirectoryToolStripMenuItem.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.RootFolder = Environment.SpecialFolder.Desktop
        dlg.SelectedPath = "c:\"
        dlg.Description = "Select Folder to process"
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            folder = dlg.SelectedPath
            Button_Go.Enabled = True
            Label_Directory.Text = "Processing: " + folder
        End If
        'MessageBox.Show("folder " + folder)
    End Sub




    Private Sub RenameFiles() Handles Button_Go.Click

        Dim counter As Integer = 1
        Dim jukeboxcounter As Integer = 100
        Dim isValid1 As Boolean
        Dim isValid2 As Boolean
        Dim firstThree As String = ""
        Dim secondThree As String = ""
        Dim oldFileWithPath As String = ""
        Dim newFileWithPath As String = ""
        items.Clear()

        If RadioButton_Add.Checked = False And RadioButton_Remove.Checked = False Then
            MessageBox.Show("Please select Add numbering or Remove numbering before pressing start.")
            Exit Sub
        End If

        RichTextBox_Log.Clear()
        Dim files = Directory.GetFiles(folder, "*.mp3", SearchOption.TopDirectoryOnly)

        'add all the files to our list
        For Each File In files
            Dim item = New fileNames
            item.filePath = System.IO.Path.GetDirectoryName(File) 'get the path
            item.oFileName = System.IO.Path.GetFileName(File) 'get the filename
            items.add(item)
        Next

        'strip beginning numbers from the old filename. store in strippedFilename
        For Each i As fileNames In items
            'patterns we chack for: "123 filename"  "123 - 200 filename" - really should use regex here, but this is just quick and dirty
            'RichTextBox_Log.AppendText("Processing: " + i.oFileName + vbCrLf)
            firstThree = i.oFileName.Substring(0, 3)
            isValid1 = firstThree.All(Function(c) Char.IsNumber(c))
            secondThree = i.oFileName.Substring(6, 3)
            isValid2 = secondThree.All(Function(c) Char.IsNumber(c))
            If (isValid1 And isValid2) Then 'numbers in spots 0-2 an 6-8. strip 9 characters from the filename
                i.strippedFileName = i.oFileName.Substring(9, i.oFileName.Length - 9)
            ElseIf (isValid1) Then ' numbers only in spot 1. strip 3 characters from the filename
                i.strippedFileName = i.oFileName.Substring(3, i.oFileName.Length - 3)
            Else
                i.strippedFileName = i.oFileName ' nothing to strip
            End If
        Next


        'now that we have numbers stripped, we can sort the list based on the stripped filename
        items.Sort(New stippedFilenameComparer)

        'now that our list is alphabetically sorted, let's add numbers back to the filename
        'format: xxx - yyy filename where xxx is the physical position on the card, starting with song 001 and yyy is the jukebox number starting with 100
        For Each i As fileNames In items
            If RadioButton_Add.Checked = True Then
                i.nFileName = counter.ToString("000") + " - " + jukeboxcounter.ToString("000") + " " + i.strippedFileName
            ElseIf RadioButton_Remove.Checked = True Then
                i.nFileName = i.strippedFileName
            End If
            oldFileWithPath = System.IO.Path.Combine(i.filePath, i.oFileName)
            newFileWithPath = System.IO.Path.Combine(i.filePath, i.nFileName)

            If (String.Compare(i.oFileName, i.nFileName) <> 0) Then
                RichTextBox_Log.AppendText("Renaming: " + i.oFileName + " to: " + i.nFileName + vbCrLf)
                Try
                    If CheckBox_TestRun.Checked = False Then ' if testrun is not checked, do the ren
                        System.IO.File.Move(oldFileWithPath, newFileWithPath)
                    End If
                Catch ex As Exception
                    RichTextBox_Log.AppendText("exception renaming file: " + ex.Message)
                End Try 'file names are the same
            Else
                RichTextBox_Log.AppendText("No change on filename: " + i.oFileName + vbCrLf)
            End If 'check for numbers to strip

            counter = counter + 1
            jukeboxcounter = jukeboxcounter + 1
        Next
        RichTextBox_Log.Refresh() ' refresh to show the final entries

    End Sub





    Private Sub FormLoad() Handles MyBase.Load
        'Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized
        CheckBox_TestRun.Checked = True
    End Sub





    Public Class fileNames
        Public oFileName As String = "" 'we'll need the original filename for the rename
        Public strippedFileName As String = "" 'original filename stripped of numbers
        Public nFileName As String = "" 'new filename with numbers or new numbers prepended
        Public filePath As String = "" 'path
    End Class




    Public Class stippedFilenameComparer
        Implements IComparer(Of fileNames)
        Private Function Compare(x As fileNames, y As fileNames) As Integer Implements System.Collections.Generic.IComparer(Of fileNames).Compare
            Return x.strippedFileName.CompareTo(y.strippedFileName)
        End Function
    End Class




End Class
