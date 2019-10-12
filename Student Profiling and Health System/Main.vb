Public Class Main
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs)
        StudentAdd.Show()

    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        connect()
        rs.Open("StudentProfileTable order by LRN", con, 3, 3)
        Do Until rs.EOF
            With Me.lvwStudentStatus
                .Items.Add(rs.Fields("LRN").Value)
                .Items(i).SubItems.Add(rs("Lastname").Value)
                .Items(i).SubItems.Add(rs("Firstname").Value)
                .Items(i).SubItems.Add(rs("Middlename").Value)
                .Items(i).SubItems.Add(rs("Age").Value)
                .Items(i).SubItems.Add(rs("Address").Value)
                .Items(i).SubItems.Add(rs("GuardiansID").Value)
                .Items(i).SubItems.Add(rs("Grade").Value)

            End With
            i = i + 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim i As Integer
        i = 0
        lvwStudentStatus.Items.Clear()
        connect()
        rs.Open("SELECT * FROM  WHERE LRN LIKE " & "'%" & txtSearch.Text & "%'", con, 3, 3)
        Do Until rs.EOF
            With Me.lvwStudentStatus
                .Items.Add(rs.Fields("LRN").Value)
                rss.Open("Select * from StudentProfileTable where LRN = '" & txtSearch.Text & "'", con, 3, 3)
                .Items.Add(rss.Fields("Lastname").Value)
                .Items.Add(rss.Fields("Firstnamename").Value)
                rss.Close()
                .Items.Add(rs.Fields("DateOfTaking").Value)
                .Items.Add(rs.Fields("BMIResult").Value)
                .Items.Add(rs.Fields("Status").Value)

            End With
            i = i + 1
            rs.MoveNext()

        Loop
        rs.Close()
        con.Close()
    End Sub
End Class