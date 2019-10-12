Public Class StudentAdd
    Dim flag As Integer
    Dim c As Control
    Private Sub StudentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list()
        lock()
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub

    Private Sub lvwStudent_Click(sender As Object, e As EventArgs) Handles lvwStudent.Click
        With lvwStudent
            txtLRN.Text = .SelectedItems(0).Text
            txtLastname.Text = .SelectedItems(0).SubItems(1).Text
            txtFirstname.text = .SelectedItems(0).SubItems(2).Text
            txtMid.Text = .SelectedItems(0).SubItems(3).Text
            txtAge.Text = .SelectedItems(0).SubItems(4).Text
            txtAddress.Text = .SelectedItems(0).SubItems(5).Text
            txtGuardian.Text = .SelectedItems(0).SubItems(6).Text
            txtGrade.Text = .SelectedItems(0).SubItems(7).Text
        End With
    End Sub


   

    Public Sub list()
        lvwStudent.Items.Clear()
        Dim i As Integer
        i = 0
        connect()
        rs.Open("StudentProfileTable order by LRN", con, 3, 3)
        Do Until rs.EOF
            With Me.lvwStudent
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


 
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        unlock()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        flag = 1
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If flag = 1 Then
            connect()
            rs.Open("select * From StudentProfileTable where LRN = '" & txtLRN.Text & "'", con, 3, 3)
            If rs.RecordCount = 0 Then
                rs.AddNew()
                rs.Fields("LRN").Value = txtLRN.Text
                rs.Fields("Lastname").Value = txtLastname.Text
                rs.Fields("Firstname").Value = txtLastname.Text
                rs.Fields("Middlename").Value = txtMid.Text
                rs.Fields("Age").Value = txtAge.Text
                rs.Fields("Address").Value = txtAddress.Text
                rs.Fields("GuardiansID").Value = txtGuardian.Text
                rs.Fields("Grade").Value = txtGrade.Text

                rs.Update()
            Else
                MsgBox("Records Already Exist", vbCritical, "EXISTING")
            End If
        ElseIf flag = 2 Then
            connect()
            rs.Open("select * From StudentProfileTable where LRN = '" & txtLRN.Text & "'", con, 3, 3)
            If rs.RecordCount = 1 Then
                rs.Update()
                rs.Fields("LRN").Value = txtLRN.Text
                rs.Fields("Lastname").Value = txtLastname.Text
                rs.Fields("Firstname").Value = txtFirstname.Text
                rs.Fields("Middlename").Value = txtMid.Text
                rs.Fields("Age").Value = txtAge.Text
                rs.Fields("Address").Value = txtAddress.Text
                rs.Fields("GuardiansID").Value = txtGuardian.Text
                rs.Fields("Grade").Value = txtGrade.Text

                rs.Update()
            Else
                MsgBox("Records Already Exist", vbCritical, "EXISTING")
            End If
        End If
        rs.Close()
        con.Close()
        BMIStatus.txtLRN.Text = txtLRN.Text
        BMIStatus.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        unlock()
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        flag = 2
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()
        rs.Open("select * From StudentProfileTable where LRN = '" & txtLRN.Text & "'", con, 3, 3)
        If rs.RecordCount = 1 Then
            rs.Delete()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

 
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        clr()
    End Sub



End Class