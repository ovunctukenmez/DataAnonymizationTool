Imports System.Text.RegularExpressions

Public Class frmTables
    Public sourceDBString As String = ""
    Dim dtTables As New DataTable()
    Dim dtTableColumns As New DataTable()
    Dim dtTableConstraints As New DataTable()
    Dim dtKeyColumnUsages As New DataTable()
    Dim dtReplacementRules As New DataTable()
    Dim listOfTable As New List(Of data_types.table)
    Dim listOfReplacementRule As New List(Of data_types.replacement_rule)
    Dim globalIncrementalValue As Integer = 0

    Private Sub fillReplacementRuleConditions()
        Dim dt As New DataTable()

        dt.Columns.Add("value")
        dt.Columns.Add("title")

        Dim nr_ As DataRow = dt.NewRow
        nr_("value") = "any"
        nr_("title") = "Any"
        dt.Rows.Add(nr_)

        Dim nr1 As DataRow = dt.NewRow
        nr1("value") = "equals"
        nr1("title") = "Equals to"
        dt.Rows.Add(nr1)

        Dim nr2 As DataRow = dt.NewRow
        nr2("value") = "less_than"
        nr2("title") = "Less than"
        dt.Rows.Add(nr2)

        Dim nr3 As DataRow = dt.NewRow
        nr3("value") = "greater_than"
        nr3("title") = "Greater than"
        dt.Rows.Add(nr3)

        Dim nr4 As DataRow = dt.NewRow
        nr4("value") = "between"
        nr4("title") = "Between"
        dt.Rows.Add(nr4)

        Dim nr5 As DataRow = dt.NewRow
        nr5("value") = "is_numeric"
        nr5("title") = "Is Numeric"
        dt.Rows.Add(nr5)

        Dim nr6 As DataRow = dt.NewRow
        nr6("value") = "email_domain"
        nr6("title") = "Email Domain"
        dt.Rows.Add(nr6)

        Dim nr7 As DataRow = dt.NewRow
        nr7("value") = "email_username"
        nr7("title") = "Email Username"
        dt.Rows.Add(nr7)

        Dim nr8 As DataRow = dt.NewRow
        nr8("value") = "regex"
        nr8("title") = "Regex"
        dt.Rows.Add(nr8)

        With comboFieldValueCondition
            .DataSource = dt
            .DisplayMember = "title"
            .ValueMember = "value"
        End With
    End Sub

    Private Sub fillReplacementRuleSubjects()
        Dim dt As New DataTable()

        dt.Columns.Add("value")
        dt.Columns.Add("title")

        Dim nr_ As DataRow = dt.NewRow
        nr_("value") = "filtered_value"
        nr_("title") = "Filtered Value"
        dt.Rows.Add(nr_)

        Dim nr1 As DataRow = dt.NewRow
        nr1("value") = "first_characters"
        nr1("title") = "First Characters"
        dt.Rows.Add(nr1)

        Dim nr2 As DataRow = dt.NewRow
        nr2("value") = "last_characters"
        nr2("title") = "Last Characters"
        dt.Rows.Add(nr2)

        Dim nr3 As DataRow = dt.NewRow
        nr3("value") = "between_characters"
        nr3("title") = "Between Characters"
        dt.Rows.Add(nr3)

        With comboSubject
            .DataSource = dt
            .DisplayMember = "title"
            .ValueMember = "value"
        End With
    End Sub

    Private Sub fillReplacementRuleActions()
        Dim dt As New DataTable()

        dt.Columns.Add("value")
        dt.Columns.Add("title")

        Dim nr_ As DataRow = dt.NewRow
        nr_("value") = "replace"
        nr_("title") = "Replace"
        dt.Rows.Add(nr_)

        Dim nr1 As DataRow = dt.NewRow
        nr1("value") = "replace_with"
        nr1("title") = "Replace With"
        dt.Rows.Add(nr1)

        Dim nr2 As DataRow = dt.NewRow
        nr2("value") = "incrementally_replace_with"
        nr2("title") = "Incrementally Replace With"
        dt.Rows.Add(nr2)

        Dim nr3 As DataRow = dt.NewRow
        nr3("value") = "mask"
        nr3("title") = "Mask"
        dt.Rows.Add(nr3)

        Dim nr4 As DataRow = dt.NewRow
        nr4("value") = "shuffle_chars"
        nr4("title") = "Shuffle Characters"
        dt.Rows.Add(nr4)

        Dim nr5 As DataRow = dt.NewRow
        nr5("value") = "shuffle_values"
        nr5("title") = "Shuffle Values"
        dt.Rows.Add(nr5)

        Dim nr6 As DataRow = dt.NewRow
        nr6("value") = "multiply_with"
        nr6("title") = "Multiply With"
        dt.Rows.Add(nr6)

        Dim nr7 As DataRow = dt.NewRow
        nr7("value") = "multiply_with_random"
        nr7("title") = "Multiply With Random"
        dt.Rows.Add(nr7)

        Dim nr8 As DataRow = dt.NewRow
        nr8("value") = "add"
        nr8("title") = "Add"
        dt.Rows.Add(nr8)

        Dim nr9 As DataRow = dt.NewRow
        nr9("value") = "add_random"
        nr9("title") = "Add Random"
        dt.Rows.Add(nr9)

        With comboAction
            .DataSource = dt
            .DisplayMember = "title"
            .ValueMember = "value"
        End With
    End Sub

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

        Me.sourceDBString = txtSourceSQLServerConnectionString.Text

        fetchTables()
    End Sub

    Private Sub fetchTables()
        dtTables.Rows.Clear()
        dtTables.Columns.Clear()
        dtTables.Columns.Add("name")
        dtTables.Columns.Add("object_id")

        Dim cnDatabase As New System.Data.SqlClient.SqlConnection(Me.sourceDBString)
        Dim commandKayitListele As New System.Data.SqlClient.SqlCommand

        commandKayitListele.Connection = cnDatabase
        commandKayitListele.CommandTimeout = 60
        commandKayitListele.CommandType = CommandType.Text

        commandKayitListele.CommandText = "SELECT * FROM Sys.Tables ORDER BY name ASC"

        cnDatabase.Open()

        Dim dataReaderKayit As System.Data.SqlClient.SqlDataReader
        dataReaderKayit = commandKayitListele.ExecuteReader

        Dim newRow As DataRow = dtTables.NewRow
        newRow("name") = ""
        newRow("object_id") = ""
        dtTables.Rows.Add(newRow)

        While dataReaderKayit.Read
            Dim nr As DataRow = dtTables.NewRow
            nr("name") = dataReaderKayit("name")
            nr("object_id") = dataReaderKayit("object_id")
            dtTables.Rows.Add(nr)
        End While
        dataReaderKayit.Close()

        cnDatabase.Close()
        cnDatabase = Nothing

        With ComboTables
            .DataSource = dtTables
            .DisplayMember = "name"
            .ValueMember = "name"
        End With
    End Sub

    Private Sub fetchTableColumns(tableName As String)
        dtTableColumns.Rows.Clear()
        dtTableColumns.Columns.Clear()
        dtTableColumns.Columns.Add("TABLE_NAME")
        dtTableColumns.Columns.Add("COLUMN_NAME")
        dtTableColumns.Columns.Add("COLUMN_DEFAULT")
        dtTableColumns.Columns.Add("IS_NULLABLE")
        dtTableColumns.Columns.Add("DATA_TYPE")
        dtTableColumns.Columns.Add("CHARACTER_MAXIMUM_LENGTH")

        If tableName = "" Then
            Return
        End If

        Dim cnDatabase As New System.Data.SqlClient.SqlConnection(Me.sourceDBString)
        Dim commandKayitListele As New System.Data.SqlClient.SqlCommand

        commandKayitListele.Connection = cnDatabase
        commandKayitListele.CommandTimeout = 60
        commandKayitListele.CommandType = CommandType.Text
        commandKayitListele.CommandText = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & tableName & "'"

        dtTableColumns.Clear()

        cnDatabase.Open()

        Dim dataReaderKayit As System.Data.SqlClient.SqlDataReader
        dataReaderKayit = commandKayitListele.ExecuteReader

        Dim newRow As DataRow = dtTableColumns.NewRow
        newRow("TABLE_NAME") = ""
        newRow("COLUMN_NAME") = ""
        dtTableColumns.Rows.Add(newRow)

        While dataReaderKayit.Read
            Dim nr As DataRow = dtTableColumns.NewRow

            nr("TABLE_NAME") = dataReaderKayit("TABLE_NAME")
            nr("COLUMN_NAME") = dataReaderKayit("COLUMN_NAME")
            nr("COLUMN_DEFAULT") = dataReaderKayit("COLUMN_DEFAULT")
            nr("IS_NULLABLE") = dataReaderKayit("IS_NULLABLE")
            nr("DATA_TYPE") = dataReaderKayit("DATA_TYPE")
            nr("CHARACTER_MAXIMUM_LENGTH") = dataReaderKayit("CHARACTER_MAXIMUM_LENGTH")

            dtTableColumns.Rows.Add(nr)
        End While
        dataReaderKayit.Close()

        cnDatabase.Close()
        cnDatabase = Nothing

        With ComboTableColumns
            .DataSource = dtTableColumns
            .DisplayMember = "COLUMN_NAME"
            .ValueMember = "COLUMN_NAME"
        End With
    End Sub

    Private Sub frmTables_Load(sender As Object, e As EventArgs) Handles Me.Load
        With DataGridViewReplacementRules
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            .DefaultCellStyle.Padding = New Padding(2)

            dtReplacementRules.Columns.Add("id", GetType(System.Int32)) 'id
            dtReplacementRules.Columns.Add("Field Value Filter")
            dtReplacementRules.Columns.Add("Condition Value 1")
            dtReplacementRules.Columns.Add("Condition Value 2")
            dtReplacementRules.Columns.Add("Subject")
            dtReplacementRules.Columns.Add("Subject Value 1")
            dtReplacementRules.Columns.Add("Subject Value 2")
            dtReplacementRules.Columns.Add("Action")
            dtReplacementRules.Columns.Add("Action Value 1")
            dtReplacementRules.Columns.Add("Action Value 2")
            .DataSource = dtReplacementRules

            .Columns(0).Width = 80 'id
            .Columns(1).Width = 140 'Field Value Condition
            .Columns(2).Width = 120 'Condition Value 1
            .Columns(3).Width = 120 'Condition Value 2
            .Columns(4).Width = 120 'Subject
            .Columns(5).Width = 120 'Subject Value 1
            .Columns(6).Width = 120 'Subject Value 2
            .Columns(7).Width = 120 'Action
            .Columns(8).Width = 120 'Action Value 1
            .Columns(9).Width = 120 'Action Value 2

            For i = 0 To .Columns.Count - 1
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next

            'hide id column
            .Columns(0).Visible = False
        End With

        fillReplacementRuleConditions()
        fillReplacementRuleSubjects()
        fillReplacementRuleActions()
        fillDatagridViewReplacementRules()

        comboReplacementRuleCondition_SelectedIndexChanged(Me, EventArgs.Empty)
        comboSubject_SelectedIndexChanged(Me, EventArgs.Empty)
        comboAction_SelectedIndexChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub ComboTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTables.SelectedIndexChanged
        Try
            fetchTableColumns(ComboTables.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReplacementRuleAdd_Click(sender As Object, e As EventArgs) Handles btnReplacementRuleAdd.Click
        Dim replacementRule As New data_types.replacement_rule
        replacementRule.id = listOfReplacementRule.Count
        replacementRule.condition = comboFieldValueCondition.SelectedValue
        replacementRule.condition_value_1 = txtFieldValueConditionValue1.Text
        replacementRule.condition_value_2 = txtFieldValueConditionValue2.Text
        replacementRule.subject = comboSubject.SelectedValue
        replacementRule.subject_value_1 = txtSubjectValue1.Text
        replacementRule.subject_value_2 = txtSubjectValue2.Text
        replacementRule.action = comboAction.SelectedValue
        replacementRule.action_value_1 = txtActionValue1.Text
        replacementRule.action_value_2 = txtActionValue2.Text
        listOfReplacementRule.Add(replacementRule)
        fillDatagridViewReplacementRules()
    End Sub

    Public Sub fillDatagridViewReplacementRules()
        dtReplacementRules.Clear()

        For Each replacementRule In listOfReplacementRule
            Dim nr As DataRow = dtReplacementRules.NewRow

            nr(0) = replacementRule.id
            nr(1) = replacementRule.condition
            nr(2) = replacementRule.condition_value_1
            nr(3) = replacementRule.condition_value_2
            nr(4) = replacementRule.subject
            nr(5) = replacementRule.subject_value_1
            nr(6) = replacementRule.subject_value_2
            nr(7) = replacementRule.action
            nr(8) = replacementRule.action_value_1
            nr(9) = replacementRule.action_value_2

            dtReplacementRules.Rows.Add(nr)
        Next
    End Sub

    Private Sub doAction(ByVal replacementRule As replacement_rule)
        Dim cnDatabase As New System.Data.SqlClient.SqlConnection(Me.sourceDBString)

        Dim commandSQL As New System.Data.SqlClient.SqlCommand
        commandSQL.Connection = cnDatabase
        commandSQL.CommandTimeout = 60
        commandSQL.CommandType = CommandType.Text

        Dim id_column_name As String = "id"
        Dim column_name As String = ComboTableColumns.SelectedValue
        Dim table_name As String = ComboTables.SelectedValue
        Dim dtTable As New DataTable()

        Dim resultLimit As Integer = 0
        Integer.TryParse(txtResultLimit.Text, resultLimit)
        Dim lastId As Integer = 0

        dtTable.Columns.Add("id", GetType(System.Int32))
        dtTable.Columns.Add("value")

        Try
            cnDatabase.Open()

            commandSQL.CommandText = "" &
            "SELECT " &
            id_column_name & ", " &
            column_name & " " &
            "FROM " & table_name

            dtTable.Clear()

            Dim dataReaderKayit As System.Data.SqlClient.SqlDataReader
            dataReaderKayit = commandSQL.ExecuteReader

            While dataReaderKayit.Read
                Dim nr As DataRow = dtTable.NewRow
                Dim value As String = dataReaderKayit(column_name).ToString

                If doesValueMatchFilter(replacementRule, value) = False Then
                    Continue While
                End If

                nr("id") = dataReaderKayit(id_column_name)
                nr("value") = value
                dtTable.Rows.Add(nr)

                If resultLimit > 0 Then
                    lastId = dataReaderKayit(id_column_name)
                    If dtTable.Rows.Count = resultLimit Then
                        Exit While
                    End If
                End If
            End While
            dataReaderKayit.Close()

            Dim newValues As List(Of String) = New List(Of String)
            For Each row As DataRow In dtTable.Rows
                Dim idValue As Integer = row.Item("id")
                Dim rowValue As String = row.Item("value")

                newValues.Add(getNewValue(replacementRule, rowValue))
            Next

            If replacementRule.action = "shuffle_values" Then
                Dim rnd As New Random()
                Dim n As Integer = newValues.Count
                While n > 1
                    n -= 1
                    Dim k As Integer = rnd.Next(n + 1)
                    Dim value As String = newValues(k)
                    newValues(k) = newValues(n)
                    newValues(n) = value
                End While
            End If

            Dim i As Integer = 0
            For Each row As DataRow In dtTable.Rows
                Dim newValue As String = newValues.ElementAt(i)
                i += 1

                commandSQL.CommandText = "" &
                "UPDATE " & table_name & " " &
                "SET " &
                column_name & "=@value " &
                "WHERE " &
                id_column_name & "=@id"

                commandSQL.Parameters.Clear()
                commandSQL.Parameters.AddWithValue("@id", row(id_column_name).ToString)
                commandSQL.Parameters.AddWithValue("@value", newValue)
                commandSQL.ExecuteNonQuery()
            Next

            If resultLimit > 0 Then
                lastId = dataReaderKayit(id_column_name)

                commandSQL.CommandText = "" &
                "DELETE FROM " & table_name & " " &
                "WHERE " &
                id_column_name & " > @id"

                commandSQL.Parameters.Clear()
                commandSQL.Parameters.AddWithValue("@id", lastId)
                commandSQL.ExecuteNonQuery()
            End If

            cnDatabase.Close()
            cnDatabase = Nothing
        Catch ex As Exception

            Select Case ex.Message
            Case Else
                MsgBox("An error occured." & vbCrLf & ex.Message)
        End Select

        cnDatabase.Close()
        cnDatabase = Nothing
        Exit Sub
        End Try
    End Sub

    Private Function doesValueMatchFilter(ByVal replacementRule As replacement_rule, ByVal value As String) As Boolean
        Dim value_num As Decimal = 0
        Dim condition_value_num_1 As Decimal = 0
        Dim condition_value_num_2 As Decimal = 0
        Dim pattern As String = ""

        Select Case replacementRule.condition
            Case "any"
                Return True
            Case "equals"
                If replacementRule.condition_value_1.Equals(value) Then
                    Return True
                End If
            Case "less_than"
                Decimal.TryParse(replacementRule.condition_value_1, condition_value_num_1)
                Decimal.TryParse(value, value_num)
                If value_num.CompareTo(condition_value_num_1) < 0 Then
                    Return True
                End If
            Case "greater_than"
                Decimal.TryParse(replacementRule.condition_value_1, condition_value_num_1)
                Decimal.TryParse(value, value_num)
                If value_num.CompareTo(condition_value_num_1) > 0 Then
                    Return True
                End If
            Case "between"
                Decimal.TryParse(replacementRule.condition_value_1, condition_value_num_1)
                Decimal.TryParse(replacementRule.condition_value_2, condition_value_num_2)
                Decimal.TryParse(value, value_num)
                If value_num.CompareTo(condition_value_num_1) >= 0 And value_num.CompareTo(condition_value_num_2) <= 0 Then
                    Return True
                End If
            Case "is_numeric"
                If IsNumeric(value) Then
                    Return True
                End If
            Case "email_domain"
                pattern = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
                Dim matches As MatchCollection = Regex.Matches(value, pattern)
                If matches.Count > 0 Then
                    Return True
                End If
            Case "email_username"
                pattern = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
                Dim matches As MatchCollection = Regex.Matches(value, pattern)
                If matches.Count > 0 Then
                    Return True
                End If
            Case "regex"
                pattern = replacementRule.condition_value_1
                Dim matches As MatchCollection = Regex.Matches(value, pattern)
                If matches.Count > 0 Then
                    Return True
                End If
        End Select

        Return False
    End Function

    Private Function getNewValue(ByVal replacementRule As replacement_rule, ByVal rowValue As String) As String
        Dim returnValue As String = rowValue

        Dim newValue As String = ""
        Dim oldValue As String = rowValue
        Dim value_num As Decimal = 0
        Dim subject_value_num_1 As Decimal = 0
        Dim subject_value_num_2 As Decimal = 0
        Dim pattern As String = ""
        Dim parts() As String

        Select Case replacementRule.condition
            Case "email_domain"
                pattern = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
                Dim matches As MatchCollection = Regex.Matches(rowValue, pattern)
                If matches.Count > 0 Then
                    For i As Integer = 0 To matches.Count - 1
                        oldValue = matches.Item(i).Value
                        parts = oldValue.Split("@")
                        If parts.Count = 2 Then
                            newValue = parts(0) & "@" & applyAction(replacementRule, parts(1))
                            returnValue = Strings.Replace(rowValue, oldValue, newValue)
                        End If
                    Next
                End If
            Case "email_username"
                pattern = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
                Dim matches As MatchCollection = Regex.Matches(rowValue, pattern)
                If matches.Count > 0 Then
                    For i As Integer = 0 To matches.Count - 1
                        oldValue = matches.Item(i).Value
                        parts = oldValue.Split("@")
                        If parts.Count = 2 Then
                            newValue = applyAction(replacementRule, parts(0)) & "@" & parts(1)
                            returnValue = Strings.Replace(rowValue, oldValue, newValue)
                        End If
                    Next
                End If
            Case "regex"
                pattern = replacementRule.condition_value_1
                Dim matches As MatchCollection = Regex.Matches(rowValue, pattern)
                If matches.Count > 0 Then
                    For i As Integer = 0 To matches.Count - 1
                        oldValue = matches.Item(i).Value
                        newValue = applyAction(replacementRule, newValue)
                        returnValue = Strings.Replace(rowValue, oldValue, newValue)
                    Next
                End If
            Case Else
                newValue = applyAction(replacementRule, oldValue)
                returnValue = Strings.Replace(rowValue, oldValue, newValue)
        End Select

        Return returnValue
    End Function

    Private Function applyAction(ByVal replacementRule As replacement_rule, ByVal value As String) As String
        Dim returnValue As String = ""

        Dim subjectValue As String = filterSubjectValue(replacementRule, value)
        Dim newValue As String = value
        Dim value_num As Decimal = 0
        Dim action_value_num_1 As Decimal = 0
        Dim action_value_num_2 As Decimal = 0
        Dim subject_value_num_1 As Decimal = 0
        Dim subject_value_num_2 As Integer = 0

        Select Case replacementRule.action
            Case "replace"
                newValue = subjectValue.Replace(replacementRule.action_value_1, replacementRule.action_value_2)
            Case "replace_with"
                newValue = replacementRule.action_value_1
                'Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                'If subject_value_num_1 > 0 Then
                '    newValue = Strings.StrDup(CInt(subject_value_num_1), replacementRule.action_value_1)
                'Else
                '    newValue = replacementRule.action_value_1
                'End If
            Case "incrementally_replace_with"
                globalIncrementalValue += 1
                newValue = replacementRule.action_value_1 & globalIncrementalValue.ToString
            Case "mask"
                newValue = Strings.StrDup(subjectValue.Length, replacementRule.action_value_1)
            Case "shuffle_chars"
                Dim rnd As New Random
                newValue = subjectValue.OrderBy(Function() rnd.Next).ToArray
            Case "multiply_with"
                Decimal.TryParse(replacementRule.action_value_1, action_value_num_1)
                Decimal.TryParse(value, value_num)
                newValue = value_num * action_value_num_1
            Case "multiply_with_random"
                Decimal.TryParse(replacementRule.action_value_1, action_value_num_1)
                Decimal.TryParse(replacementRule.action_value_2, action_value_num_2)
                Decimal.TryParse(value, value_num)
                Dim rnd As New Random()
                newValue = value_num * rnd.Next(action_value_num_1, action_value_num_2)
            Case "add"
                Decimal.TryParse(replacementRule.action_value_1, action_value_num_1)
                Decimal.TryParse(value, value_num)
                newValue = value_num + action_value_num_1
            Case "add_random"
                Decimal.TryParse(replacementRule.action_value_1, action_value_num_1)
                Decimal.TryParse(replacementRule.action_value_2, action_value_num_2)
                Decimal.TryParse(value, value_num)
                Dim rnd As New Random()
                newValue = value_num + rnd.Next(action_value_num_1, action_value_num_2)
            Case Else
                newValue = subjectValue
        End Select

        Select Case replacementRule.subject
            Case "filtered_value"
                returnValue = newValue
            Case "first_characters"
                returnValue = value.Substring(0, replacementRule.subject_value_1)
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                returnValue = newValue & value.Substring(subject_value_num_1)
            Case "last_characters"
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                returnValue = value.Substring(0, value.Length - subject_value_num_1) & newValue
            Case "between_characters"
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                Decimal.TryParse(replacementRule.subject_value_2, subject_value_num_2)
                returnValue = value.Substring(0, subject_value_num_1) & newValue & value.Substring(subject_value_num_2)
        End Select

        Return returnValue
    End Function

    Private Function filterSubjectValue(ByVal replacementRule As replacement_rule, ByVal value As String) As String
        Dim return_value As String = value
        Dim subject_value_num_1 As Integer = 0
        Dim subject_value_num_2 As Integer = 0

        Select Case replacementRule.subject
            Case "filtered_value"
                return_value = value
            Case "first_characters"
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                return_value = value.Substring(0, subject_value_num_1)
            Case "last_characters"
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                return_value = value.Substring(return_value.Length - subject_value_num_1)
            Case "between_characters"
                Decimal.TryParse(replacementRule.subject_value_1, subject_value_num_1)
                Decimal.TryParse(replacementRule.subject_value_2, subject_value_num_2)
                return_value = value.Substring(subject_value_num_1, subject_value_num_2 - subject_value_num_1)
        End Select

        Return return_value
    End Function

    Private Sub comboReplacementRuleCondition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboFieldValueCondition.SelectedIndexChanged
        LabelFieldValueConditionValue1.Visible = False
        LabelFieldValueConditionValue2.Visible = False
        txtFieldValueConditionValue1.Visible = False
        txtFieldValueConditionValue2.Visible = False
        txtFieldValueConditionValue1.Text = ""
        txtFieldValueConditionValue2.Text = ""

        Try
            Select Case comboFieldValueCondition.SelectedValue
                Case "equals"
                    LabelFieldValueConditionValue1.Text = "Value"
                    LabelFieldValueConditionValue1.Visible = True
                    txtFieldValueConditionValue1.Visible = True
                Case "less_than"
                    LabelFieldValueConditionValue1.Text = "Number"
                    LabelFieldValueConditionValue1.Visible = True
                    txtFieldValueConditionValue1.Visible = True
                Case "greater_than"
                    LabelFieldValueConditionValue1.Text = "Number"
                    LabelFieldValueConditionValue1.Visible = True
                    txtFieldValueConditionValue1.Visible = True
                Case "between"
                    LabelFieldValueConditionValue1.Text = "From"
                    LabelFieldValueConditionValue1.Visible = True
                    txtFieldValueConditionValue1.Visible = True
                    LabelFieldValueConditionValue2.Text = "To"
                    LabelFieldValueConditionValue2.Visible = True
                    txtFieldValueConditionValue2.Visible = True
                Case "regex"
                    LabelFieldValueConditionValue1.Text = "Pattern"
                    LabelFieldValueConditionValue1.Visible = True
                    txtFieldValueConditionValue1.Visible = True
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub comboSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSubject.SelectedIndexChanged
        LabelSubjectValue1.Visible = False
        LabelSubjectValue2.Visible = False
        txtSubjectValue1.Visible = False
        txtSubjectValue2.Visible = False
        txtSubjectValue1.Text = ""
        txtSubjectValue2.Text = ""

        Try
            Select Case comboSubject.SelectedValue
                'Case "field_value"
                Case "first_characters"
                    LabelSubjectValue1.Text = "Number"
                    LabelSubjectValue1.Visible = True
                    txtSubjectValue1.Visible = True
                Case "last_characters"
                    LabelSubjectValue1.Text = "Number"
                    LabelSubjectValue1.Visible = True
                    txtSubjectValue1.Visible = True
                Case "between_characters"
                    LabelSubjectValue1.Text = "From"
                    LabelSubjectValue1.Visible = True
                    txtSubjectValue1.Visible = True
                    LabelSubjectValue2.Text = "To"
                    LabelSubjectValue2.Visible = True
                    txtSubjectValue2.Visible = True
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub comboAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboAction.SelectedIndexChanged
        LabelActionValue1.Visible = False
        LabelActionValue2.Visible = False
        txtActionValue1.Visible = False
        txtActionValue2.Visible = False
        txtActionValue1.Text = ""
        txtActionValue2.Text = ""

        Try
            Select Case comboAction.SelectedValue
                Case "replace"
                    LabelActionValue1.Text = "Source"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                    LabelActionValue2.Text = "Target"
                    LabelActionValue2.Visible = True
                    txtActionValue2.Visible = True
                Case "replace_with"
                    LabelActionValue1.Text = "Value"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                Case "mask"
                    LabelActionValue1.Text = "Character"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Text = "*"
                    txtActionValue1.Visible = True
                Case "incrementally_replace_with"
                    LabelActionValue1.Text = "Base Text"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                    If comboFieldValueCondition.SelectedValue = "email_username" Then
                        txtActionValue1.Text = "user"
                    End If
                Case "multiply_with"
                    LabelActionValue1.Text = "Number Text"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                Case "multiply_with_random"
                    LabelActionValue1.Text = "Min"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                    LabelActionValue2.Text = "Max"
                    LabelActionValue2.Visible = True
                    txtActionValue2.Visible = True
                Case "add"
                    LabelActionValue1.Text = "Number Text"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                Case "add_random"
                    LabelActionValue1.Text = "Min"
                    LabelActionValue1.Visible = True
                    txtActionValue1.Visible = True
                    LabelActionValue2.Text = "Max"
                    LabelActionValue2.Visible = True
                    txtActionValue2.Visible = True
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReplacementRuleDelete_Click(sender As Object, e As EventArgs) Handles btnReplacementRuleDelete.Click
        If DataGridViewReplacementRules.SelectedCells.Count > 0 Then
            Dim dialogResult As DialogResult
            Dim record_id As Integer = DataGridViewReplacementRules.Item(0, DataGridViewReplacementRules.SelectedCells.Item(0).RowIndex).Value

            dialogResult = MsgBox("Are you sure to delete selected rule?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Rule Deletion Confirmation")

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                Dim replacementRule As replacement_rule = listOfReplacementRule.Find(Function(value As replacement_rule) value.id = record_id)
                listOfReplacementRule.Remove(replacementRule)
                fillDatagridViewReplacementRules()
            End If
        End If
    End Sub

    Private Sub btnReplacementRuleDeleteAll_Click(sender As Object, e As EventArgs) Handles btnReplacementRuleDeleteAll.Click
        If DataGridViewReplacementRules.Rows.Count > 0 Then
            Dim dialogResult As DialogResult
            dialogResult = MsgBox("Are you sure to delete defined rules?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Rule Deletion Confirmation")

            If dialogResult = Windows.Forms.DialogResult.Yes Then
                listOfReplacementRule.Clear()
                fillDatagridViewReplacementRules()
            End If
        End If
    End Sub

    Private Sub btnAnonymize_Click(sender As Object, e As EventArgs) Handles btnAnonymize.Click
        For Each replacementRule In listOfReplacementRule
            globalIncrementalValue = 0
            doAction(replacementRule)
        Next
        MsgBox("Anonymization operation completed.")
    End Sub


End Class