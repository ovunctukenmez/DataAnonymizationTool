<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelSourceDBConnectionString = New System.Windows.Forms.Label()
        Me.txtSourceSQLServerConnectionString = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelSourceDBConnectionString
        '
        Me.labelSourceDBConnectionString.AutoSize = True
        Me.labelSourceDBConnectionString.Location = New System.Drawing.Point(12, 23)
        Me.labelSourceDBConnectionString.Name = "labelSourceDBConnectionString"
        Me.labelSourceDBConnectionString.Size = New System.Drawing.Size(211, 15)
        Me.labelSourceDBConnectionString.TabIndex = 0
        Me.labelSourceDBConnectionString.Text = "Source SQL Server Connection String"
        '
        'txtSourceSQLServerConnectionString
        '
        Me.txtSourceSQLServerConnectionString.Location = New System.Drawing.Point(15, 42)
        Me.txtSourceSQLServerConnectionString.Name = "txtSourceSQLServerConnectionString"
        Me.txtSourceSQLServerConnectionString.Size = New System.Drawing.Size(568, 20)
        Me.txtSourceSQLServerConnectionString.TabIndex = 1
        Me.txtSourceSQLServerConnectionString.Text = "Data Source=.;Initial Catalog=akgunler2023;User Id=sa;Password=sqlsapass;Multiple" &
    "ActiveResultSets=true;"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(15, 79)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'frmConnectionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 144)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtSourceSQLServerConnectionString)
        Me.Controls.Add(Me.labelSourceDBConnectionString)
        Me.Name = "frmConnectionSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSourceDBConnectionString As Label
    Friend WithEvents txtSourceSQLServerConnectionString As TextBox
    Friend WithEvents btnConnect As Button
End Class
