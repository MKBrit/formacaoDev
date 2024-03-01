<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnYNC = New System.Windows.Forms.Button()
        Me.btnARI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(260, 280)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 74)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next Form  →"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(70, 280)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(77, 74)
        Me.btnPrevious.TabIndex = 2
        Me.btnPrevious.Text = "Previous Form  ←"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(130, 70)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(159, 40)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnYNC
        '
        Me.btnYNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYNC.Location = New System.Drawing.Point(130, 130)
        Me.btnYNC.Name = "btnYNC"
        Me.btnYNC.Size = New System.Drawing.Size(159, 40)
        Me.btnYNC.TabIndex = 3
        Me.btnYNC.Text = "Yes No Cancel"
        Me.btnYNC.UseVisualStyleBackColor = True
        '
        'btnARI
        '
        Me.btnARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnARI.Location = New System.Drawing.Point(130, 190)
        Me.btnARI.Name = "btnARI"
        Me.btnARI.Size = New System.Drawing.Size(159, 40)
        Me.btnARI.TabIndex = 3
        Me.btnARI.Text = "Abort Retry Ignore"
        Me.btnARI.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(424, 381)
        Me.Controls.Add(Me.btnARI)
        Me.Controls.Add(Me.btnYNC)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "Form2"
        Me.Text = "Msg Box Buttons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnYNC As Button
    Friend WithEvents btnARI As Button
End Class
