Public Class AddProgram
    Dim flag As Integer


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If flag = 1 Then
            connect()
            rs.Open("Select * from ProgramsTable where ProgramID = '" & txtProgramID.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs.Fields("ProgramID").Value = txtProgramID.Text
                rs.Fields("ProgramName").Value = txtProgramName.Text
                rs.Update()
            End If
            rs.Close()
            con.Close()

        ElseIf flag = 2 Then
            connect()
            rs.Open("Select * from ProgramsTable where ProgramID = '" & txtProgramID.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs.Fields("ProgramID").Value = txtProgramID.Text
                rs.Fields("ProgramName").Value = txtProgramName.Text
                rs.Update()
            End If
            rs.Close()
            con.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        flag = 1
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        flag = 2
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()
        rs.Open("Select * from ProgramsTable where ProgramID = '" & txtProgramID.Text & "'", con, 3, 3)
        rs.Delete()
        rs.Close()
        con.Close()
    End Sub

    Public Sub lock()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            ElseIf TypeOf c Is ComboBox Then
                c.Enabled = False
            End If
        Next
    End Sub
    Public Sub unlock()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            ElseIf TypeOf c Is ComboBox Then
                c.Enabled = True
            End If
        Next
    End Sub

    Public Sub clr()
        For Each c In Me.Controls

            If TypeOf c Is TextBox Then
                c.Text = ""
            ElseIf TypeOf c Is ComboBox Then
                c.Text = "Select"
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clr()
    End Sub

    Private Sub AddProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list()
    End Sub

    Public Sub list()
        Dim i As Integer
        i = 0
        connect()
        rs.Open("select * from ProgramsTable order by ProgramID", con, 3, 3)
        Do Until rs.EOF
            With Me.lvwProgram
                .Items.Add(rs.Fields("ProgramID").Value)
                .Items(i).SubItems.Add(rs("ProgramName").Value)
            End With
            i = i + 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub
End Class