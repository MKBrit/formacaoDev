<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddMulti = New System.Windows.Forms.Button()
        Me.btnAddMultis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(170, 280)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(77, 74)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous Form  ←"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(50, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(227, 207)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(300, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(66, 29)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(300, 210)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 35)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddMulti
        '
        Me.btnAddMulti.Location = New System.Drawing.Point(300, 75)
        Me.btnAddMulti.Name = "btnAddMulti"
        Me.btnAddMulti.Size = New System.Drawing.Size(66, 48)
        Me.btnAddMulti.TabIndex = 5
        Me.btnAddMulti.Text = "Add Multiple"
        Me.btnAddMulti.UseVisualStyleBackColor = True
        '
        'btnAddMultis
        '
        Me.btnAddMultis.Location = New System.Drawing.Point(300, 130)
        Me.btnAddMultis.Name = "btnAddMultis"
        Me.btnAddMultis.Size = New System.Drawing.Size(66, 48)
        Me.btnAddMultis.TabIndex = 5
        Me.btnAddMultis.Text = "Add Multiple's"
        Me.btnAddMultis.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 381)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddMultis)
        Me.Controls.Add(Me.btnAddMulti)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "Form3"
        Me.Text = "Listview"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddMulti As Button
    Friend WithEvents btnAddMultis As Button
End Class
