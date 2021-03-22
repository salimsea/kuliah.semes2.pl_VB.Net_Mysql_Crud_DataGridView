Module Connection
    Public conn As New ADODB.Connection
    Public rec As New ADODB.Recordset

    Public Sub openDB()
        conn.Open("DSN=pl.pertemuan1")
    End Sub

    Public Sub closeDB()
        conn.Close()
    End Sub

End Module