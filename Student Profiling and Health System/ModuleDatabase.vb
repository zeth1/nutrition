Module ModuleDatabase
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public rss As New ADODB.Recordset

    Public Sub connect()
        con.Open("provider= Microsoft.jet.OLEDB.4.0; Data source = " & Application.StartupPath & "\StudentProfilingAndHealthMonitoringDatabase.mdb")
    End Sub
End Module
