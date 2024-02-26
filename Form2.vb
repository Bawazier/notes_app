Public Class Form2
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check flag for handling; Set appropriate text box preferences
        'Read in values
        If Form1.bolUpdOrAdd = False Then
            txtTitle.Enabled = False
            Try
                txtTitle.Text = Form1.notesArray(Form1.intCurrentIndex).strNoteTitle
                txtNote.Text = Form1.notesArray(Form1.intCurrentIndex).strNoteDesc
                If Form1.notesArray(Form1.intCurrentIndex).strNoteCategory = "F" Then
                    radProfessional.Checked = True
                    radPersonal.Checked = False
                Else
                    radProfessional.Checked = False
                    radPersonal.Checked = True
                End If
            Catch ex As Exception
                MessageBox.Show("Please select a note from the list to update")
            End Try
        End If

        'Check flag for handling; Set for input
        If Form1.bolUpdOrAdd = True Then
            radProfessional.Checked = False
            radPersonal.Checked = False
        End If

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Check flag for handling; If updating read in appropriate parameters and set
        If Form1.bolUpdOrAdd = False Then
            Try
                Form1.notesArray(Form1.intCurrentIndex).strNoteDesc = txtNote.Text
                If radProfessional.Checked Then
                    Form1.notesArray(Form1.intCurrentIndex).strNoteCategory = "F"
                Else
                    Form1.notesArray(Form1.intCurrentIndex).strNoteCategory = "N"
                End If
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Please keep no fields blank")
            End Try
        End If

        'Check flags for handling; Input validation
        If Form1.bolUpdOrAdd = True Then
            If txtTitle.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf txtNote.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf txtTitle.Text = "" Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            ElseIf radProfessional.Checked = False And radPersonal.Checked = False Then
                MessageBox.Show("Please complete all fields")
                Exit Sub
            End If

            'Set value of new array entry
            Try
                Form1.notesArray(Form1.intCurrentNotes).strNoteTitle = txtTitle.Text
                Form1.notesArray(Form1.intCurrentNotes).strNoteDesc = txtNote.Text
                If radProfessional.Checked Then
                    Form1.notesArray(Form1.intCurrentNotes).strNoteCategory = "F"
                ElseIf radPersonal.Checked Then
                    Form1.notesArray(Form1.intCurrentNotes).strNoteCategory = "N"
                End If
                Form1.lstNotes.Items.Add(Form1.notesArray(Form1.intCurrentNotes).strNoteTitle)
                Form1.intCurrentNotes += 1
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Please fill all fields")
            End Try
        End If
    End Sub
End Class