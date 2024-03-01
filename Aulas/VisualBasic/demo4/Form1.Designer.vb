<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.lblNrInicial = New System.Windows.Forms.Label()
        Me.lblNrFinal = New System.Windows.Forms.Label()
        Me.txtBoxInicial = New System.Windows.Forms.TextBox()
        Me.txtBoxFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWhile
        '
        Me.btnWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWhile.Location = New System.Drawing.Point(80, 215)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(77, 44)
        Me.btnWhile.TabIndex = 0
        Me.btnWhile.Text = "while do"
        Me.btnWhile.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFor.Location = New System.Drawing.Point(275, 215)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(77, 44)
        Me.btnFor.TabIndex = 0
        Me.btnFor.Text = "for"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'lblNrInicial
        '
        Me.lblNrInicial.AutoSize = True
        Me.lblNrInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrInicial.Location = New System.Drawing.Point(70, 100)
        Me.lblNrInicial.Name = "lblNrInicial"
        Me.lblNrInicial.Size = New System.Drawing.Size(187, 31)
        Me.lblNrInicial.TabIndex = 1
        Me.lblNrInicial.Text = "Número Inicial"
        '
        'lblNrFinal
        '
        Me.lblNrFinal.AutoSize = True
        Me.lblNrFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrFinal.Location = New System.Drawing.Point(70, 160)
        Me.lblNrFinal.Name = "lblNrFinal"
        Me.lblNrFinal.Size = New System.Drawing.Size(176, 31)
        Me.lblNrFinal.TabIndex = 1
        Me.lblNrFinal.Text = "Número Final"
        '
        'txtBoxInicial
        '
        Me.txtBoxInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxInicial.Location = New System.Drawing.Point(285, 105)
        Me.txtBoxInicial.Name = "txtBoxInicial"
        Me.txtBoxInicial.Size = New System.Drawing.Size(52, 30)
        Me.txtBoxInicial.TabIndex = 2
        '
        'txtBoxFinal
        '
        Me.txtBoxFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxFinal.Location = New System.Drawing.Point(285, 165)
        Me.txtBoxFinal.Name = "txtBoxFinal"
        Me.txtBoxFinal.Size = New System.Drawing.Size(52, 30)
        Me.txtBoxFinal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ciclos"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(170, 280)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(77, 74)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Form  →"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(424, 381)
        Me.Controls.Add(Me.txtBoxFinal)
        Me.Controls.Add(Me.txtBoxInicial)
        Me.Controls.Add(Me.lblNrFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNrInicial)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.btnWhile)
        Me.Name = "Form1"
        Me.Text = "Ciclos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWhile As Button
    Friend WithEvents btnFor As Button
    Friend WithEvents lblNrInicial As Label
    Friend WithEvents lblNrFinal As Label
    Friend WithEvents txtBoxInicial As TextBox
    Friend WithEvents txtBoxFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNext As Button
End Class
