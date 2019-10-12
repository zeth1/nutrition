Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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