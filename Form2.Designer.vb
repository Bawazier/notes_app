<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.radPersonal = New System.Windows.Forms.RadioButton()
        Me.radProfessional = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.RichTextBox()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(80, 17)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(264, 22)
        Me.txtTitle.TabIndex = 0
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(17, 357)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(327, 37)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Add Note"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.radPersonal)
        Me.grpCategory.Controls.Add(Me.radProfessional)
        Me.grpCategory.Location = New System.Drawing.Point(17, 258)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpCategory.Size = New System.Drawing.Size(327, 80)
        Me.grpCategory.TabIndex = 5
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'radPersonal
        '
        Me.radPersonal.AutoSize = True
        Me.radPersonal.Location = New System.Drawing.Point(187, 31)
        Me.radPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radPersonal.Name = "radPersonal"
        Me.radPersonal.Size = New System.Drawing.Size(82, 20)
        Me.radPersonal.TabIndex = 1
        Me.radPersonal.TabStop = True
        Me.radPersonal.Text = "Personal"
        Me.radPersonal.UseVisualStyleBackColor = True
        '
        'radProfessional
        '
        Me.radProfessional.AutoSize = True
        Me.radProfessional.Location = New System.Drawing.Point(47, 31)
        Me.radProfessional.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radProfessional.Name = "radProfessional"
        Me.radProfessional.Size = New System.Drawing.Size(103, 20)
        Me.radProfessional.TabIndex = 0
        Me.radProfessional.TabStop = True
        Me.radProfessional.Text = "Professional"
        Me.radProfessional.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(31, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(36, 16)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Title:"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(28, 58)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(39, 16)
        Me.lblAuthor.TabIndex = 7
        Me.lblAuthor.Text = "Note:"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(80, 55)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(264, 185)
        Me.txtNote.TabIndex = 8
        Me.txtNote.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 411)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtTitle)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Details"
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnRecord As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents radPersonal As RadioButton
    Friend WithEvents radProfessional As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtNote As RichTextBox
End Class
