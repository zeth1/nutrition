Public Class BMIStatus
    Dim h As Integer
    Dim w As Integer
    Dim bmi As Integer


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        connect()
        rs.Open("Select * from BMIStatusTable where LRN = '" & txtLRN.Text & "'", con, 3, 3)
        rs.AddNew()
        rs.Fields("LRN").Value = txtLRN.Text
        rs.Fields("Height").Value = txtHeight.Text
        rs.Fields("Weight").Value = txtWeight.Text
        rs.Fields("BMIResult").Value = txtBMI.Text
        rs.Fields("Status").Value = txtStatus.Text
        rs.Fields("DateOfTaking").Value = dateTaking.Text
        rs.Update()
        rs.Close()
        con.Close()

        SuitableProgram.txtLRN.Text = txtLRN.Text
        Me.Hide()
        SuitableProgram.Show()
    End Sub

 
    Private Sub txtBMI_LostFocus(sender As Object, e As EventArgs) Handles txtBMI.LostFocus
        h = Val(txtHeight.Text)
        w = Val(txtWeight.Text)

        bmi = w / (h * h)
        txtBMI.Text = Val(bmi)
        If Val(txtBMI.Text) < 20 Then
            MsgBox("Proceed to Programs")
            txtStatus.Text = "Malnourished"
        Else
            txtStatus.Text = "Healthy"
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        connect()
        rs.Open("Select * from BMIStatusTable where LRN = '" & txtLRN.Text & "'", con, 3, 3)
        rs.AddNew()
        rs.Fields("LRN").Value = txtLRN.Text
        rs.Fields("Height").Value = txtHeight.Text
        rs.Fields("Weight").Value = txtWeight.Text
        rs.Fields("BMIResult").Value = txtBMI.Text
        rs.Fields("Status").Value = txtStatus.Text
        rs.Fields("DateOfTaking").Value = dateTaking.Text
        rs.Update()
        rs.Close()
        con.Close()
    End Sub
End Class