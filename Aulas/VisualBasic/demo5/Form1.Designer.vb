<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        cmd_mysql = New Button()
        cmd_mysqldbtest = New Button()
        DataGridView1 = New DataGridView()
        cmd_dataPessoal = New Button()
        cmd_dataTest = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_mysql
        ' 
        cmd_mysql.Location = New Point(90, 43)
        cmd_mysql.Name = "cmd_mysql"
        cmd_mysql.Size = New Size(215, 51)
        cmd_mysql.TabIndex = 0
        cmd_mysql.Text = "mySql.con to test DB"
        cmd_mysql.UseVisualStyleBackColor = True
        ' 
        ' cmd_mysqldbtest
        ' 
        cmd_mysqldbtest.Location = New Point(464, 43)
        cmd_mysqldbtest.Name = "cmd_mysqldbtest"
        cmd_mysqldbtest.Size = New Size(215, 51)
        cmd_mysqldbtest.TabIndex = 0
        cmd_mysqldbtest.Text = "mySql.con to pessoal DB"
        cmd_mysqldbtest.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(90, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(589, 184)
        DataGridView1.TabIndex = 1
        ' 
        ' cmd_dataPessoal
        ' 
        cmd_dataPessoal.Location = New Point(464, 359)
        cmd_dataPessoal.Name = "cmd_dataPessoal"
        cmd_dataPessoal.Size = New Size(215, 51)
        cmd_dataPessoal.TabIndex = 2
        cmd_dataPessoal.Text = "Show Data from tabela contatos"
        cmd_dataPessoal.UseVisualStyleBackColor = True
        ' 
        ' cmd_dataTest
        ' 
        cmd_dataTest.Location = New Point(90, 359)
        cmd_dataTest.Name = "cmd_dataTest"
        cmd_dataTest.Size = New Size(215, 51)
        cmd_dataTest.TabIndex = 3
        cmd_dataTest.Text = "Show Data from tabela produtos"
        cmd_dataTest.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmd_dataPessoal)
        Controls.Add(cmd_dataTest)
        Controls.Add(DataGridView1)
        Controls.Add(cmd_mysqldbtest)
        Controls.Add(cmd_mysql)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmd_mysql As Button
    Friend WithEvents cmd_mysqldbtest As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmd_dataPessoal As Button
    Friend WithEvents cmd_dataTest As Button
End Class
