Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        connect()
        rs.Open("select * from PartnersTable order by Partnername", con, 3, 3)
        Do Until rs.EOF
            With Me.lvwPartners
                .Items.Add(rs.Fields("PartnerID").Value)
                .Items(i).SubItems.Add(rs("PartnerName").Value)
                .Items(i).SubItems.Add(rs("Address").Value)
                .Items(i).SubItems.Add(rs("ContactNo").Value)
                .Items(i).SubItems.Add(rs("Advocacy").Value)
                .Items(i).SubItems.Add(rs("WhatToHelp").Value)
            End With
            i = i + 1
            rs.MoveNext()
        Loop
        rs.Close()
        con.Close()
    End Sub
End Class