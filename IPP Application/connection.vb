Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public queri As OdbcCommand
    Public ds As DataSet
    Public Sub koneksi()
        Dim teks As String
        teks = "Driver={MySQL ODBC 5.3 ANSI Driver};uid=root;password=root;server=127.0.0.1;database=app_ipp;port=3306"
        conn = New OdbcConnection(teks)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
