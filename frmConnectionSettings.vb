Public Class frmConnectionSettings
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            Dim cnDatabase As New System.Data.SqlClient.SqlConnection(txtSourceSQLServerConnectionString.Text)
            cnDatabase.Open()
            cnDatabase.Close()
            cnDatabase = Nothing
        Catch ex As SqlClient.SqlException
            MsgBox("Could not connect to source database. Please check your connection string.")
            Exit Sub
        End Try

        Dim formTables As New frmTables
        formTables.sourceDBString = txtSourceSQLServerConnectionString.Text
        formTables.Show()
    End Sub

    Private Sub txtSourceSQLServerConnectionString_TextChanged(sender As Object, e As EventArgs) Handles txtSourceSQLServerConnectionString.TextChanged

    End Sub

    Private Sub labelSourceDBConnectionString_Click(sender As Object, e As EventArgs) Handles labelSourceDBConnectionString.Click

    End Sub
End Class
