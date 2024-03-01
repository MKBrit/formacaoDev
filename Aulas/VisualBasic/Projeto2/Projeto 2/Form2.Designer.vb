<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.diaBtn = New System.Windows.Forms.Button()
        Me.crnBtn = New System.Windows.Forms.Button()
        Me.pxBtn = New System.Windows.Forms.Button()
        Me.sopaBtn = New System.Windows.Forms.Button()
        Me.sobrBtn = New System.Windows.Forms.Button()
        Me.bebidaBtn = New System.Windows.Forms.Button()
        Me.cafeBtn = New System.Windows.Forms.Button()
        Me.contaBtn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.clear1Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'diaBtn
        '
        Me.diaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diaBtn.Location = New System.Drawing.Point(48, 87)
        Me.diaBtn.Name = "diaBtn"
        Me.diaBtn.Size = New System.Drawing.Size(85, 52)
        Me.diaBtn.TabIndex = 0
        Me.diaBtn.Text = "Prato do Dia"
        Me.diaBtn.UseVisualStyleBackColor = True
        '
        'crnBtn
        '
        Me.crnBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crnBtn.Location = New System.Drawing.Point(48, 161)
        Me.crnBtn.Name = "crnBtn"
        Me.crnBtn.Size = New System.Drawing.Size(85, 52)
        Me.crnBtn.TabIndex = 0
        Me.crnBtn.Text = "Alternativa Carne"
        Me.crnBtn.UseVisualStyleBackColor = True
        '
        'pxBtn
        '
        Me.pxBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pxBtn.Location = New System.Drawing.Point(48, 239)
        Me.pxBtn.Name = "pxBtn"
        Me.pxBtn.Size = New System.Drawing.Size(85, 52)
        Me.pxBtn.TabIndex = 0
        Me.pxBtn.Text = "Alternativa Peixe"
        Me.pxBtn.UseVisualStyleBackColor = True
        '
        'sopaBtn
        '
        Me.sopaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sopaBtn.Location = New System.Drawing.Point(161, 53)
        Me.sopaBtn.Name = "sopaBtn"
        Me.sopaBtn.Size = New System.Drawing.Size(85, 52)
        Me.sopaBtn.TabIndex = 0
        Me.sopaBtn.Text = "Sopa"
        Me.sopaBtn.UseVisualStyleBackColor = True
        '
        'sobrBtn
        '
        Me.sobrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sobrBtn.Location = New System.Drawing.Point(161, 205)
        Me.sobrBtn.Name = "sobrBtn"
        Me.sobrBtn.Size = New System.Drawing.Size(85, 52)
        Me.sobrBtn.TabIndex = 0
        Me.sobrBtn.Text = "Sobremesa"
        Me.sobrBtn.UseVisualStyleBackColor = True
        '
        'bebidaBtn
        '
        Me.bebidaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bebidaBtn.Location = New System.Drawing.Point(161, 127)
        Me.bebidaBtn.Name = "bebidaBtn"
        Me.bebidaBtn.Size = New System.Drawing.Size(85, 52)
        Me.bebidaBtn.TabIndex = 0
        Me.bebidaBtn.Text = "Bebida"
        Me.bebidaBtn.UseVisualStyleBackColor = True
        '
        'cafeBtn
        '
        Me.cafeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cafeBtn.Location = New System.Drawing.Point(161, 279)
        Me.cafeBtn.Name = "cafeBtn"
        Me.cafeBtn.Size = New System.Drawing.Size(85, 52)
        Me.cafeBtn.TabIndex = 0
        Me.cafeBtn.Text = "Café"
        Me.cafeBtn.UseVisualStyleBackColor = True
        '
        'contaBtn
        '
        Me.contaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contaBtn.Location = New System.Drawing.Point(400, 355)
        Me.contaBtn.Name = "contaBtn"
        Me.contaBtn.Size = New System.Drawing.Size(202, 60)
        Me.contaBtn.TabIndex = 0
        Me.contaBtn.Text = "Tirar Conta"
        Me.contaBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(400, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(349, 296)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(680, 355)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(69, 60)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Limpar Tudo"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'clear1Btn
        '
        Me.clear1Btn.Location = New System.Drawing.Point(608, 356)
        Me.clear1Btn.Name = "clear1Btn"
        Me.clear1Btn.Size = New System.Drawing.Size(69, 60)
        Me.clear1Btn.TabIndex = 2
        Me.clear1Btn.Text = "Limpar Último"
        Me.clear1Btn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clear1Btn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.contaBtn)
        Me.Controls.Add(Me.cafeBtn)
        Me.Controls.Add(Me.sopaBtn)
        Me.Controls.Add(Me.bebidaBtn)
        Me.Controls.Add(Me.crnBtn)
        Me.Controls.Add(Me.sobrBtn)
        Me.Controls.Add(Me.pxBtn)
        Me.Controls.Add(Me.diaBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents diaBtn As Button
    Friend WithEvents crnBtn As Button
    Friend WithEvents pxBtn As Button
    Friend WithEvents sopaBtn As Button
    Friend WithEvents sobrBtn As Button
    Friend WithEvents bebidaBtn As Button
    Friend WithEvents cafeBtn As Button
    Friend WithEvents contaBtn As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents clearBtn As Button
    Friend WithEvents clear1Btn As Button
End Class
