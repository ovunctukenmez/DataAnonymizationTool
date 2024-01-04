<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTables
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxColumnProperties = New System.Windows.Forms.GroupBox()
        Me.chkColumnWillBeAnonymized = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelColumnName = New System.Windows.Forms.Label()
        Me.labelTableName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkColumnHasForeignKey = New System.Windows.Forms.CheckBox()
        Me.chkColumnHasPrimaryKey = New System.Windows.Forms.CheckBox()
        Me.labelKeys = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtSourceSQLServerConnectionString = New System.Windows.Forms.TextBox()
        Me.labelSourceDBConnectionString = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtResultLimit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox_Replacement = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelActionValue2 = New System.Windows.Forms.Label()
        Me.LabelActionValue1 = New System.Windows.Forms.Label()
        Me.LabelSubjectValue2 = New System.Windows.Forms.Label()
        Me.LabelSubjectValue1 = New System.Windows.Forms.Label()
        Me.LabelFieldValueConditionValue2 = New System.Windows.Forms.Label()
        Me.LabelFieldValueConditionValue1 = New System.Windows.Forms.Label()
        Me.txtActionValue2 = New System.Windows.Forms.TextBox()
        Me.comboAction = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtActionValue1 = New System.Windows.Forms.TextBox()
        Me.txtSubjectValue2 = New System.Windows.Forms.TextBox()
        Me.comboSubject = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubjectValue1 = New System.Windows.Forms.TextBox()
        Me.txtFieldValueConditionValue2 = New System.Windows.Forms.TextBox()
        Me.comboFieldValueCondition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFieldValueConditionValue1 = New System.Windows.Forms.TextBox()
        Me.btnReplacementRuleAdd = New System.Windows.Forms.Button()
        Me.DataGridViewReplacementRules = New System.Windows.Forms.DataGridView()
        Me.ComboTableColumns = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboTables = New System.Windows.Forms.ComboBox()
        Me.btnReplacementRuleDelete = New System.Windows.Forms.Button()
        Me.btnReplacementRuleDeleteAll = New System.Windows.Forms.Button()
        Me.btnAnonymize = New System.Windows.Forms.Button()
        Me.GroupBoxColumnProperties.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox_Replacement.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewReplacementRules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxColumnProperties
        '
        Me.GroupBoxColumnProperties.Controls.Add(Me.chkColumnWillBeAnonymized)
        Me.GroupBoxColumnProperties.Controls.Add(Me.Label4)
        Me.GroupBoxColumnProperties.Controls.Add(Me.Label3)
        Me.GroupBoxColumnProperties.Controls.Add(Me.labelColumnName)
        Me.GroupBoxColumnProperties.Controls.Add(Me.labelTableName)
        Me.GroupBoxColumnProperties.Controls.Add(Me.Label2)
        Me.GroupBoxColumnProperties.Controls.Add(Me.chkColumnHasForeignKey)
        Me.GroupBoxColumnProperties.Controls.Add(Me.chkColumnHasPrimaryKey)
        Me.GroupBoxColumnProperties.Controls.Add(Me.labelKeys)
        Me.GroupBoxColumnProperties.Controls.Add(Me.Label1)
        Me.GroupBoxColumnProperties.Location = New System.Drawing.Point(1391, 28)
        Me.GroupBoxColumnProperties.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxColumnProperties.Name = "GroupBoxColumnProperties"
        Me.GroupBoxColumnProperties.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxColumnProperties.Size = New System.Drawing.Size(345, 438)
        Me.GroupBoxColumnProperties.TabIndex = 0
        Me.GroupBoxColumnProperties.TabStop = False
        Me.GroupBoxColumnProperties.Text = "Properties"
        '
        'chkColumnWillBeAnonymized
        '
        Me.chkColumnWillBeAnonymized.AutoSize = True
        Me.chkColumnWillBeAnonymized.Enabled = False
        Me.chkColumnWillBeAnonymized.Location = New System.Drawing.Point(19, 261)
        Me.chkColumnWillBeAnonymized.Margin = New System.Windows.Forms.Padding(4)
        Me.chkColumnWillBeAnonymized.Name = "chkColumnWillBeAnonymized"
        Me.chkColumnWillBeAnonymized.Size = New System.Drawing.Size(85, 21)
        Me.chkColumnWillBeAnonymized.TabIndex = 8
        Me.chkColumnWillBeAnonymized.Text = "Selected"
        Me.chkColumnWillBeAnonymized.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 338)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Table"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Anonymization"
        '
        'labelColumnName
        '
        Me.labelColumnName.Location = New System.Drawing.Point(89, 57)
        Me.labelColumnName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelColumnName.Name = "labelColumnName"
        Me.labelColumnName.Size = New System.Drawing.Size(248, 46)
        Me.labelColumnName.TabIndex = 6
        Me.labelColumnName.Text = "columnName"
        '
        'labelTableName
        '
        Me.labelTableName.AutoSize = True
        Me.labelTableName.Location = New System.Drawing.Point(89, 25)
        Me.labelTableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTableName.Name = "labelTableName"
        Me.labelTableName.Size = New System.Drawing.Size(76, 17)
        Me.labelTableName.TabIndex = 5
        Me.labelTableName.Text = "tableName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Column"
        '
        'chkColumnHasForeignKey
        '
        Me.chkColumnHasForeignKey.AutoSize = True
        Me.chkColumnHasForeignKey.Enabled = False
        Me.chkColumnHasForeignKey.Location = New System.Drawing.Point(17, 172)
        Me.chkColumnHasForeignKey.Margin = New System.Windows.Forms.Padding(4)
        Me.chkColumnHasForeignKey.Name = "chkColumnHasForeignKey"
        Me.chkColumnHasForeignKey.Size = New System.Drawing.Size(123, 21)
        Me.chkColumnHasForeignKey.TabIndex = 3
        Me.chkColumnHasForeignKey.Text = "FOREIGN KEY"
        Me.chkColumnHasForeignKey.UseVisualStyleBackColor = True
        '
        'chkColumnHasPrimaryKey
        '
        Me.chkColumnHasPrimaryKey.AutoSize = True
        Me.chkColumnHasPrimaryKey.Enabled = False
        Me.chkColumnHasPrimaryKey.Location = New System.Drawing.Point(17, 144)
        Me.chkColumnHasPrimaryKey.Margin = New System.Windows.Forms.Padding(4)
        Me.chkColumnHasPrimaryKey.Name = "chkColumnHasPrimaryKey"
        Me.chkColumnHasPrimaryKey.Size = New System.Drawing.Size(122, 21)
        Me.chkColumnHasPrimaryKey.TabIndex = 2
        Me.chkColumnHasPrimaryKey.Text = "PRIMARY KEY"
        Me.chkColumnHasPrimaryKey.UseVisualStyleBackColor = True
        '
        'labelKeys
        '
        Me.labelKeys.AutoSize = True
        Me.labelKeys.Location = New System.Drawing.Point(13, 112)
        Me.labelKeys.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelKeys.Name = "labelKeys"
        Me.labelKeys.Size = New System.Drawing.Size(39, 17)
        Me.labelKeys.TabIndex = 1
        Me.labelKeys.Text = "Keys"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Table"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1391, 474)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 204)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Settings"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1199, 685)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnConnect)
        Me.TabPage1.Controls.Add(Me.txtSourceSQLServerConnectionString)
        Me.TabPage1.Controls.Add(Me.labelSourceDBConnectionString)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1191, 702)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Source"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(19, 86)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(108, 28)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtSourceSQLServerConnectionString
        '
        Me.txtSourceSQLServerConnectionString.Location = New System.Drawing.Point(19, 49)
        Me.txtSourceSQLServerConnectionString.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSourceSQLServerConnectionString.Name = "txtSourceSQLServerConnectionString"
        Me.txtSourceSQLServerConnectionString.Size = New System.Drawing.Size(949, 23)
        Me.txtSourceSQLServerConnectionString.TabIndex = 4
        Me.txtSourceSQLServerConnectionString.Text = "Data Source=.;Initial Catalog=seds542;User Id=sa;Password=sqlsapass;MultipleActiv" &
    "eResultSets=true;"
        '
        'labelSourceDBConnectionString
        '
        Me.labelSourceDBConnectionString.AutoSize = True
        Me.labelSourceDBConnectionString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.labelSourceDBConnectionString.Location = New System.Drawing.Point(15, 26)
        Me.labelSourceDBConnectionString.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSourceDBConnectionString.Name = "labelSourceDBConnectionString"
        Me.labelSourceDBConnectionString.Size = New System.Drawing.Size(226, 17)
        Me.labelSourceDBConnectionString.TabIndex = 3
        Me.labelSourceDBConnectionString.Text = "SQL Server Connection String"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAnonymize)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtResultLimit)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.GroupBox_Replacement)
        Me.TabPage2.Controls.Add(Me.ComboTableColumns)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.ComboTables)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1191, 655)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Anonymization"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(225, 536)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 197
        Me.Label12.Text = "(0 for all rows)"
        '
        'txtResultLimit
        '
        Me.txtResultLimit.Location = New System.Drawing.Point(119, 532)
        Me.txtResultLimit.Name = "txtResultLimit"
        Me.txtResultLimit.Size = New System.Drawing.Size(100, 23)
        Me.txtResultLimit.TabIndex = 196
        Me.txtResultLimit.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Result Limit"
        '
        'GroupBox_Replacement
        '
        Me.GroupBox_Replacement.Controls.Add(Me.btnReplacementRuleDeleteAll)
        Me.GroupBox_Replacement.Controls.Add(Me.btnReplacementRuleDelete)
        Me.GroupBox_Replacement.Controls.Add(Me.GroupBox2)
        Me.GroupBox_Replacement.Controls.Add(Me.DataGridViewReplacementRules)
        Me.GroupBox_Replacement.Location = New System.Drawing.Point(119, 108)
        Me.GroupBox_Replacement.Name = "GroupBox_Replacement"
        Me.GroupBox_Replacement.Size = New System.Drawing.Size(1055, 407)
        Me.GroupBox_Replacement.TabIndex = 191
        Me.GroupBox_Replacement.TabStop = False
        Me.GroupBox_Replacement.Text = "Rules"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelActionValue2)
        Me.GroupBox2.Controls.Add(Me.LabelActionValue1)
        Me.GroupBox2.Controls.Add(Me.LabelSubjectValue2)
        Me.GroupBox2.Controls.Add(Me.LabelSubjectValue1)
        Me.GroupBox2.Controls.Add(Me.LabelFieldValueConditionValue2)
        Me.GroupBox2.Controls.Add(Me.LabelFieldValueConditionValue1)
        Me.GroupBox2.Controls.Add(Me.txtActionValue2)
        Me.GroupBox2.Controls.Add(Me.comboAction)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtActionValue1)
        Me.GroupBox2.Controls.Add(Me.txtSubjectValue2)
        Me.GroupBox2.Controls.Add(Me.comboSubject)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSubjectValue1)
        Me.GroupBox2.Controls.Add(Me.txtFieldValueConditionValue2)
        Me.GroupBox2.Controls.Add(Me.comboFieldValueCondition)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtFieldValueConditionValue1)
        Me.GroupBox2.Controls.Add(Me.btnReplacementRuleAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(653, 210)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        '
        'LabelActionValue2
        '
        Me.LabelActionValue2.AutoSize = True
        Me.LabelActionValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelActionValue2.Location = New System.Drawing.Point(347, 124)
        Me.LabelActionValue2.Name = "LabelActionValue2"
        Me.LabelActionValue2.Size = New System.Drawing.Size(58, 17)
        Me.LabelActionValue2.TabIndex = 208
        Me.LabelActionValue2.Text = "Value2"
        Me.LabelActionValue2.Visible = False
        '
        'LabelActionValue1
        '
        Me.LabelActionValue1.AutoSize = True
        Me.LabelActionValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelActionValue1.Location = New System.Drawing.Point(241, 124)
        Me.LabelActionValue1.Name = "LabelActionValue1"
        Me.LabelActionValue1.Size = New System.Drawing.Size(58, 17)
        Me.LabelActionValue1.TabIndex = 207
        Me.LabelActionValue1.Text = "Value1"
        Me.LabelActionValue1.Visible = False
        '
        'LabelSubjectValue2
        '
        Me.LabelSubjectValue2.AutoSize = True
        Me.LabelSubjectValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSubjectValue2.Location = New System.Drawing.Point(347, 71)
        Me.LabelSubjectValue2.Name = "LabelSubjectValue2"
        Me.LabelSubjectValue2.Size = New System.Drawing.Size(58, 17)
        Me.LabelSubjectValue2.TabIndex = 206
        Me.LabelSubjectValue2.Text = "Value2"
        Me.LabelSubjectValue2.Visible = False
        '
        'LabelSubjectValue1
        '
        Me.LabelSubjectValue1.AutoSize = True
        Me.LabelSubjectValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSubjectValue1.Location = New System.Drawing.Point(241, 71)
        Me.LabelSubjectValue1.Name = "LabelSubjectValue1"
        Me.LabelSubjectValue1.Size = New System.Drawing.Size(58, 17)
        Me.LabelSubjectValue1.TabIndex = 205
        Me.LabelSubjectValue1.Text = "Value1"
        Me.LabelSubjectValue1.Visible = False
        '
        'LabelFieldValueConditionValue2
        '
        Me.LabelFieldValueConditionValue2.AutoSize = True
        Me.LabelFieldValueConditionValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelFieldValueConditionValue2.Location = New System.Drawing.Point(347, 19)
        Me.LabelFieldValueConditionValue2.Name = "LabelFieldValueConditionValue2"
        Me.LabelFieldValueConditionValue2.Size = New System.Drawing.Size(58, 17)
        Me.LabelFieldValueConditionValue2.TabIndex = 204
        Me.LabelFieldValueConditionValue2.Text = "Value2"
        Me.LabelFieldValueConditionValue2.Visible = False
        '
        'LabelFieldValueConditionValue1
        '
        Me.LabelFieldValueConditionValue1.AutoSize = True
        Me.LabelFieldValueConditionValue1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelFieldValueConditionValue1.Location = New System.Drawing.Point(241, 19)
        Me.LabelFieldValueConditionValue1.Name = "LabelFieldValueConditionValue1"
        Me.LabelFieldValueConditionValue1.Size = New System.Drawing.Size(58, 17)
        Me.LabelFieldValueConditionValue1.TabIndex = 203
        Me.LabelFieldValueConditionValue1.Text = "Value1"
        Me.LabelFieldValueConditionValue1.Visible = False
        '
        'txtActionValue2
        '
        Me.txtActionValue2.Location = New System.Drawing.Point(350, 144)
        Me.txtActionValue2.Name = "txtActionValue2"
        Me.txtActionValue2.Size = New System.Drawing.Size(100, 23)
        Me.txtActionValue2.TabIndex = 202
        Me.txtActionValue2.Visible = False
        '
        'comboAction
        '
        Me.comboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAction.FormattingEnabled = True
        Me.comboAction.Location = New System.Drawing.Point(18, 144)
        Me.comboAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboAction.Name = "comboAction"
        Me.comboAction.Size = New System.Drawing.Size(208, 25)
        Me.comboAction.TabIndex = 201
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 200
        Me.Label14.Text = "Action"
        '
        'txtActionValue1
        '
        Me.txtActionValue1.Location = New System.Drawing.Point(244, 144)
        Me.txtActionValue1.Name = "txtActionValue1"
        Me.txtActionValue1.Size = New System.Drawing.Size(100, 23)
        Me.txtActionValue1.TabIndex = 199
        Me.txtActionValue1.Visible = False
        '
        'txtSubjectValue2
        '
        Me.txtSubjectValue2.Location = New System.Drawing.Point(350, 91)
        Me.txtSubjectValue2.Name = "txtSubjectValue2"
        Me.txtSubjectValue2.Size = New System.Drawing.Size(100, 23)
        Me.txtSubjectValue2.TabIndex = 198
        Me.txtSubjectValue2.Visible = False
        '
        'comboSubject
        '
        Me.comboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSubject.FormattingEnabled = True
        Me.comboSubject.Location = New System.Drawing.Point(18, 91)
        Me.comboSubject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboSubject.Name = "comboSubject"
        Me.comboSubject.Size = New System.Drawing.Size(208, 25)
        Me.comboSubject.TabIndex = 197
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "Subject"
        '
        'txtSubjectValue1
        '
        Me.txtSubjectValue1.Location = New System.Drawing.Point(244, 91)
        Me.txtSubjectValue1.Name = "txtSubjectValue1"
        Me.txtSubjectValue1.Size = New System.Drawing.Size(100, 23)
        Me.txtSubjectValue1.TabIndex = 195
        Me.txtSubjectValue1.Visible = False
        '
        'txtFieldValueConditionValue2
        '
        Me.txtFieldValueConditionValue2.Location = New System.Drawing.Point(350, 39)
        Me.txtFieldValueConditionValue2.Name = "txtFieldValueConditionValue2"
        Me.txtFieldValueConditionValue2.Size = New System.Drawing.Size(100, 23)
        Me.txtFieldValueConditionValue2.TabIndex = 194
        Me.txtFieldValueConditionValue2.Visible = False
        '
        'comboFieldValueCondition
        '
        Me.comboFieldValueCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFieldValueCondition.FormattingEnabled = True
        Me.comboFieldValueCondition.Location = New System.Drawing.Point(18, 39)
        Me.comboFieldValueCondition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboFieldValueCondition.Name = "comboFieldValueCondition"
        Me.comboFieldValueCondition.Size = New System.Drawing.Size(208, 25)
        Me.comboFieldValueCondition.TabIndex = 193
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "Field Value Filter"
        '
        'txtFieldValueConditionValue1
        '
        Me.txtFieldValueConditionValue1.Location = New System.Drawing.Point(244, 39)
        Me.txtFieldValueConditionValue1.Name = "txtFieldValueConditionValue1"
        Me.txtFieldValueConditionValue1.Size = New System.Drawing.Size(100, 23)
        Me.txtFieldValueConditionValue1.TabIndex = 1
        Me.txtFieldValueConditionValue1.Visible = False
        '
        'btnReplacementRuleAdd
        '
        Me.btnReplacementRuleAdd.Location = New System.Drawing.Point(506, 144)
        Me.btnReplacementRuleAdd.Name = "btnReplacementRuleAdd"
        Me.btnReplacementRuleAdd.Size = New System.Drawing.Size(101, 25)
        Me.btnReplacementRuleAdd.TabIndex = 0
        Me.btnReplacementRuleAdd.Text = "Add"
        Me.btnReplacementRuleAdd.UseVisualStyleBackColor = True
        '
        'DataGridViewReplacementRules
        '
        Me.DataGridViewReplacementRules.AllowUserToAddRows = False
        Me.DataGridViewReplacementRules.AllowUserToDeleteRows = False
        Me.DataGridViewReplacementRules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridViewReplacementRules.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewReplacementRules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewReplacementRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewReplacementRules.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewReplacementRules.Location = New System.Drawing.Point(9, 21)
        Me.DataGridViewReplacementRules.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewReplacementRules.MultiSelect = False
        Me.DataGridViewReplacementRules.Name = "DataGridViewReplacementRules"
        Me.DataGridViewReplacementRules.ReadOnly = True
        Me.DataGridViewReplacementRules.RowHeadersVisible = False
        Me.DataGridViewReplacementRules.RowHeadersWidth = 51
        Me.DataGridViewReplacementRules.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewReplacementRules.RowTemplate.Height = 24
        Me.DataGridViewReplacementRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewReplacementRules.Size = New System.Drawing.Size(1036, 148)
        Me.DataGridViewReplacementRules.TabIndex = 66
        '
        'ComboTableColumns
        '
        Me.ComboTableColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTableColumns.FormattingEnabled = True
        Me.ComboTableColumns.Location = New System.Drawing.Point(119, 64)
        Me.ComboTableColumns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboTableColumns.Name = "ComboTableColumns"
        Me.ComboTableColumns.Size = New System.Drawing.Size(532, 25)
        Me.ComboTableColumns.TabIndex = 188
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Column"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "Table"
        '
        'ComboTables
        '
        Me.ComboTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTables.FormattingEnabled = True
        Me.ComboTables.Location = New System.Drawing.Point(119, 22)
        Me.ComboTables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboTables.Name = "ComboTables"
        Me.ComboTables.Size = New System.Drawing.Size(532, 25)
        Me.ComboTables.TabIndex = 182
        '
        'btnReplacementRuleDelete
        '
        Me.btnReplacementRuleDelete.Location = New System.Drawing.Point(685, 183)
        Me.btnReplacementRuleDelete.Name = "btnReplacementRuleDelete"
        Me.btnReplacementRuleDelete.Size = New System.Drawing.Size(101, 25)
        Me.btnReplacementRuleDelete.TabIndex = 68
        Me.btnReplacementRuleDelete.Text = "Delete"
        Me.btnReplacementRuleDelete.UseVisualStyleBackColor = True
        '
        'btnReplacementRuleDeleteAll
        '
        Me.btnReplacementRuleDeleteAll.Location = New System.Drawing.Point(792, 183)
        Me.btnReplacementRuleDeleteAll.Name = "btnReplacementRuleDeleteAll"
        Me.btnReplacementRuleDeleteAll.Size = New System.Drawing.Size(133, 25)
        Me.btnReplacementRuleDeleteAll.TabIndex = 69
        Me.btnReplacementRuleDeleteAll.Text = "Delete All"
        Me.btnReplacementRuleDeleteAll.UseVisualStyleBackColor = True
        '
        'btnAnonymize
        '
        Me.btnAnonymize.Location = New System.Drawing.Point(119, 587)
        Me.btnAnonymize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnonymize.Name = "btnAnonymize"
        Me.btnAnonymize.Size = New System.Drawing.Size(157, 34)
        Me.btnAnonymize.TabIndex = 198
        Me.btnAnonymize.Text = "Anonymize"
        Me.btnAnonymize.UseVisualStyleBackColor = True
        '
        'frmTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 713)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxColumnProperties)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Anonymization Tool"
        Me.GroupBoxColumnProperties.ResumeLayout(False)
        Me.GroupBoxColumnProperties.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox_Replacement.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewReplacementRules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxColumnProperties As GroupBox
    Friend WithEvents chkColumnHasPrimaryKey As CheckBox
    Friend WithEvents labelKeys As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkColumnHasForeignKey As CheckBox
    Friend WithEvents labelTableName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelColumnName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkColumnWillBeAnonymized As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboTables As ComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtSourceSQLServerConnectionString As TextBox
    Friend WithEvents labelSourceDBConnectionString As Label
    Friend WithEvents ComboTableColumns As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox_Replacement As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents comboFieldValueCondition As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFieldValueConditionValue1 As TextBox
    Friend WithEvents btnReplacementRuleAdd As Button
    Friend WithEvents DataGridViewReplacementRules As DataGridView
    Friend WithEvents txtFieldValueConditionValue2 As TextBox
    Friend WithEvents comboSubject As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSubjectValue1 As TextBox
    Friend WithEvents txtSubjectValue2 As TextBox
    Friend WithEvents txtActionValue2 As TextBox
    Friend WithEvents comboAction As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtActionValue1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtResultLimit As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelActionValue2 As Label
    Friend WithEvents LabelActionValue1 As Label
    Friend WithEvents LabelSubjectValue2 As Label
    Friend WithEvents LabelSubjectValue1 As Label
    Friend WithEvents LabelFieldValueConditionValue2 As Label
    Friend WithEvents LabelFieldValueConditionValue1 As Label
    Friend WithEvents btnReplacementRuleDelete As Button
    Friend WithEvents btnReplacementRuleDeleteAll As Button
    Friend WithEvents btnAnonymize As Button
End Class
