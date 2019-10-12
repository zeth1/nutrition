

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "" And txtpass.Text = "") Or (txtUser.Text = "admin" And txtpass.Text = "admin") Then
            Me.Hide()
            Homepage.Show()
        Else
            MsgBox("Invalid Password")
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub
End Class


