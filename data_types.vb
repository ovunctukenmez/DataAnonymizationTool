Public Module data_types

    Structure table
        Dim dt_name As String
        Dim dt_object_id As String
        Dim columns As List(Of data_types.table_column)
        Dim constraints As List(Of data_types.table_constraint)
        Dim keyColumnUsages As List(Of data_types.key_column_usage)
        Dim is_selected As String
    End Structure

    Structure table_column
        Dim dt_TABLE_NAME As String
        Dim dt_COLUMN_NAME As String
        Dim dt_COLUMN_DEFAULT As String
        Dim dt_IS_NULLABLE As String
        Dim dt_DATA_TYPE As String
        Dim dt_CHARACTER_MAXIMUM_LENGTH As String
        Dim hasPrimaryKey As Boolean
        Dim hasForeignKey As Boolean
        Dim anonymizationType As String
        Dim willBeAnonymized As Boolean
    End Structure

    Structure table_constraint
        Dim dt_CONSTRAINT_NAME As String
        Dim dt_TABLE_NAME As String
        Dim dt_CONSTRAINT_TYPE As String
    End Structure

    Structure key_column_usage
        Dim dt_CONSTRAINT_NAME As String
        Dim dt_TABLE_NAME As String
        Dim dt_COLUMN_NAME As String
    End Structure

    Structure replacement_rule
        Dim id As Integer
        Dim condition As String
        Dim condition_value_1 As String
        Dim condition_value_2 As String
        Dim subject As String
        Dim subject_value_1 As String
        Dim subject_value_2 As String
        Dim action As String
        Dim action_value_1 As String
        Dim action_value_2 As String
    End Structure

End Module