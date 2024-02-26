Public Class Form1
    Public Structure NoteStruct
        Public strNoteTitle As String
        Public strNoteDesc As String
        Public strNoteCategory As String
    End Structure
    'Declare other vars
    Public notesArray(50) As NoteStruct 'Array size limited to 50
    Public intBooksStock As Integer
    Public bolUpdOrAdd As Boolean 'False for Update & True for Add
    Public intCurrentIndex As Integer = 0
    Public intCurrentNotes As Integer = 0
    Public swNotesData As IO.StreamReader
    Public swNotesUpdater As IO.StreamWriter
    Public intCategoryFlag As Integer = 0

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try to open the file, read in the notes to the array, and then close the file connection
        Try
            swNotesData = IO.File.OpenText("Notes.txt")
            readInNotes()
            swNotesData.Close()
        Catch ex As Exception
            MessageBox.Show("Error reading in file.")
        End Try

        'Display the note titles in the list box
        Try
            displayNotesByType()
        Catch ex As Exception
            MessageBox.Show("Error listing note titles")
        End Try

    End Sub

    Private Sub readInNotes()
        'Declare temp vars
        Dim tempArray() As String
        Dim tempString As String

        'Do loop until end of file; Split line into parts and set parts as needed 
        Do Until swNotesData.EndOfStream
            tempString = swNotesData.ReadLine()
            tempArray = tempString.Split(","c)

            notesArray(intCurrentIndex).strNoteTitle = tempArray(0)
            notesArray(intCurrentIndex).strNoteDesc = tempArray(1)
            notesArray(intCurrentIndex).strNoteCategory = tempArray(2)

            intCurrentIndex += 1
            intCurrentNotes += 1
        Loop
    End Sub

    Private Sub displayNotesByType()
        'Select case based on handling flag; Set check values; Clear list and add wanted titles
        Select Case intCategoryFlag
            Case 0
                mnuDisplayAll.Checked = True
                mnuDisplayProfessional.Checked = False
                mnuDisplayPersonal.Checked = False
                lstNotes.Items.Clear()
                For index As Integer = 0 To intCurrentNotes - 1
                    If notesArray(index).strNoteTitle <> "" Then
                        lstNotes.Items.Add(notesArray(index).strNoteTitle)
                    End If
                Next
            Case 1
                mnuDisplayAll.Checked = False
                mnuDisplayProfessional.Checked = True
                mnuDisplayPersonal.Checked = False
                lstNotes.Items.Clear()
                For index As Integer = 0 To intCurrentNotes - 1
                    If notesArray(index).strNoteCategory = "F" Then
                        lstNotes.Items.Add(notesArray(index).strNoteTitle)
                    End If
                Next
            Case 2
                mnuDisplayAll.Checked = False
                mnuDisplayProfessional.Checked = False
                mnuDisplayPersonal.Checked = True
                lstNotes.Items.Clear()
                For index As Integer = 0 To intCurrentNotes - 1
                    If notesArray(index).strNoteCategory = "N" Then
                        lstNotes.Items.Add(notesArray(index).strNoteTitle)
                    End If
                Next
        End Select
    End Sub

    Private Sub mnuDisplayAll_Click(sender As Object, e As EventArgs) Handles mnuDisplayAll.Click
        'Set handling flag; Display notes based on flag
        intCategoryFlag = 0
        displayNotesByType()
    End Sub

    Private Sub mnuDisplayProfessional_Click(sender As Object, e As EventArgs) Handles mnuDisplayProfessional.Click
        'Set handling flag; Display notes based on flag
        intCategoryFlag = 1
        displayNotesByType()
    End Sub

    Private Sub mnuDisplayPersonal_Click(sender As Object, e As EventArgs) Handles mnuDisplayPersonal.Click
        'Set handling flag; Display notes based on flag
        intCategoryFlag = 2
        displayNotesByType()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'End Program
        End
    End Sub

    Private Sub mnuNoteAdd_Click(sender As Object, e As EventArgs) Handles mnuNoteAdd.Click
        'Set flag for handling; Open form for use
        Try
            bolUpdOrAdd = True
            Dim openDetails = New Form2
            openDetails.Show()
        Catch ex As Exception
            MessageBox.Show("Error adding a note")
        End Try

    End Sub

    Private Sub mnuNoteDelete_Click(sender As Object, e As EventArgs) Handles mnuNoteDelete.Click
        'Set chosen array value to it's successor and repeat until reaching an empty array
        Try
            intCurrentIndex = lstNotes.SelectedIndex
            If intCurrentIndex >= 0 Then
                For i As Integer = intCurrentIndex To intCurrentNotes
                    If notesArray(i + 1).strNoteTitle <> "" Then
                        notesArray(i).strNoteTitle = notesArray(i + 1).strNoteTitle
                    End If
                Next
            Else
                MessageBox.Show("Please select a note from the list.")
                Exit Sub
            End If

            'Set last value to empty string and other reset values; Used to "resize" the array
            notesArray(intCurrentNotes - 1).strNoteTitle = ""
            notesArray(intCurrentNotes - 1).strNoteDesc = ""
            notesArray(intCurrentNotes - 1).strNoteCategory = ""

            'Decrement current notes count and refresh the display
            intCurrentNotes -= 1
            displayNotesByType()
        Catch ex As Exception
            MessageBox.Show("Error deleting note")
        End Try
    End Sub

    Private Sub mnuNoteUpdate_Click(sender As Object, e As EventArgs) Handles mnuNoteUpdate.Click
        'Get index for handling; Open form
        Try
            intCurrentIndex = lstNotes.SelectedIndex
            If intCurrentIndex >= 0 Then
                bolUpdOrAdd = False
                Dim openDetails = New Form2
                openDetails.Show()
            Else
                MessageBox.Show("Please select a note from the list.")
            End If

        Catch ex As Exception
            MessageBox.Show("Please select a note from the list.")
        End Try

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'Overwrite file to empty the file at file path; Close connection
        swNotesUpdater = IO.File.CreateText("Notes.txt")
        swNotesUpdater.Close()

        'For all notes in array set values to string and append string to file
        For i As Integer = 0 To intCurrentNotes - 1
            Dim tempString As String = ""

            tempString += notesArray(i).strNoteTitle + ","
            tempString += notesArray(i).strNoteDesc + ","
            tempString += notesArray(i).strNoteCategory + ","
            swNotesUpdater = IO.File.AppendText("Notes.txt")
            swNotesUpdater.WriteLine(tempString)
            swNotesUpdater.Close()

        Next
    End Sub
End Class
