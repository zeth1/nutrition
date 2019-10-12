Public Class SuitableProgram



    Private Sub SuitableProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        rs.Open("Select * from ProgramsTable", con, 3, 3)
        Do Until rs.EOF
            cbPrograms.Items.Add(rs.Fields("ProgramName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()

        connect()
        rs.Open("Select * from PartnersTable", con, 3, 3)
        Do Until rs.EOF
            cbSponsore.Items.Add(rs.Fields("PartnerName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()

    End Sub

    Private Sub txtAddProgram_Click(sender As Object, e As EventArgs) Handles txtAddProgram.Click
        Me.Hide()
        AddProgram.Show()
    End Sub
End Class