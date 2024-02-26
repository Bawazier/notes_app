<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNote = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNoteAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNoteDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNoteUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayProfessional = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstNotes = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuNote, Me.mnuDisplay})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(361, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(224, 26)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuNote
        '
        Me.mnuNote.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNoteAdd, Me.mnuNoteDelete, Me.mnuNoteUpdate})
        Me.mnuNote.Name = "mnuNote"
        Me.mnuNote.Size = New System.Drawing.Size(62, 24)
        Me.mnuNote.Text = "Notes"
        '
        'mnuNoteAdd
        '
        Me.mnuNoteAdd.Name = "mnuNoteAdd"
        Me.mnuNoteAdd.Size = New System.Drawing.Size(224, 26)
        Me.mnuNoteAdd.Text = "Add"
        '
        'mnuNoteDelete
        '
        Me.mnuNoteDelete.Name = "mnuNoteDelete"
        Me.mnuNoteDelete.Size = New System.Drawing.Size(224, 26)
        Me.mnuNoteDelete.Text = "Delete"
        '
        'mnuNoteUpdate
        '
        Me.mnuNoteUpdate.Name = "mnuNoteUpdate"
        Me.mnuNoteUpdate.Size = New System.Drawing.Size(224, 26)
        Me.mnuNoteUpdate.Text = "Update"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayAll, Me.mnuDisplayProfessional, Me.mnuDisplayPersonal})
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(72, 24)
        Me.mnuDisplay.Text = "Display"
        '
        'mnuDisplayAll
        '
        Me.mnuDisplayAll.Name = "mnuDisplayAll"
        Me.mnuDisplayAll.Size = New System.Drawing.Size(224, 26)
        Me.mnuDisplayAll.Text = "All"
        '
        'mnuDisplayProfessional
        '
        Me.mnuDisplayProfessional.Name = "mnuDisplayProfessional"
        Me.mnuDisplayProfessional.Size = New System.Drawing.Size(224, 26)
        Me.mnuDisplayProfessional.Text = "Professional"
        '
        'mnuDisplayPersonal
        '
        Me.mnuDisplayPersonal.Name = "mnuDisplayPersonal"
        Me.mnuDisplayPersonal.Size = New System.Drawing.Size(224, 26)
        Me.mnuDisplayPersonal.Text = "Personal"
        '
        'lstNotes
        '
        Me.lstNotes.FormattingEnabled = True
        Me.lstNotes.ItemHeight = 16
        Me.lstNotes.Location = New System.Drawing.Point(11, 28)
        Me.lstNotes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNotes.Name = "lstNotes"
        Me.lstNotes.Size = New System.Drawing.Size(341, 276)
        Me.lstNotes.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 318)
        Me.Controls.Add(Me.lstNotes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Diary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuNote As ToolStripMenuItem
    Friend WithEvents mnuNoteAdd As ToolStripMenuItem
    Friend WithEvents mnuNoteDelete As ToolStripMenuItem
    Friend WithEvents mnuNoteUpdate As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuDisplayAll As ToolStripMenuItem
    Friend WithEvents mnuDisplayProfessional As ToolStripMenuItem
    Friend WithEvents mnuDisplayPersonal As ToolStripMenuItem
    Public WithEvents lstNotes As ListBox
End Class