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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBoxDias = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelDia = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.labelCarne = New System.Windows.Forms.Label()
        Me.labelPeixe = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnConta = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxDias
        '
        Me.ComboBoxDias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxDias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxDias.FormattingEnabled = True
        Me.ComboBoxDias.Items.AddRange(New Object() {"Segunda Feira", "Terça Feira", "Quarta Feira", "Quinta Feira", "Sexta Feira"})
        Me.ComboBoxDias.Location = New System.Drawing.Point(74, 466)
        Me.ComboBoxDias.Name = "ComboBoxDias"
        Me.ComboBoxDias.Size = New System.Drawing.Size(150, 21)
        Me.ComboBoxDias.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(635, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelDia
        '
        Me.labelDia.BackColor = System.Drawing.Color.Transparent
        Me.labelDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.labelDia.Font = New System.Drawing.Font("UNIVERSIDAD PERSONAL USE", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDia.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelDia.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.labelDia.Location = New System.Drawing.Point(33, 35)
        Me.labelDia.Name = "labelDia"
        Me.labelDia.Size = New System.Drawing.Size(712, 187)
        Me.labelDia.TabIndex = 2
        Me.labelDia.Text = "Prato do Dia"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Location = New System.Drawing.Point(74, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Location = New System.Drawing.Point(349, 352)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'labelCarne
        '
        Me.labelCarne.AutoSize = True
        Me.labelCarne.Font = New System.Drawing.Font("UNIVERSIDAD PERSONAL USE", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCarne.ForeColor = System.Drawing.SystemColors.Control
        Me.labelCarne.Location = New System.Drawing.Point(67, 227)
        Me.labelCarne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCarne.Name = "labelCarne"
        Me.labelCarne.Size = New System.Drawing.Size(0, 39)
        Me.labelCarne.TabIndex = 4
        '
        'labelPeixe
        '
        Me.labelPeixe.AutoSize = True
        Me.labelPeixe.Font = New System.Drawing.Font("UNIVERSIDAD PERSONAL USE", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPeixe.ForeColor = System.Drawing.SystemColors.Control
        Me.labelPeixe.Location = New System.Drawing.Point(341, 305)
        Me.labelPeixe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPeixe.Name = "labelPeixe"
        Me.labelPeixe.Size = New System.Drawing.Size(0, 39)
        Me.labelPeixe.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(281, 158)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(260, 245)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-61, -66)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(901, 670)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Location = New System.Drawing.Point(662, 408)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'btnConta
        '
        Me.btnConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConta.Location = New System.Drawing.Point(615, 368)
        Me.btnConta.Name = "btnConta"
        Me.btnConta.Size = New System.Drawing.Size(120, 35)
        Me.btnConta.TabIndex = 13
        Me.btnConta.Text = "Modo POS"
        Me.btnConta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 536)
        Me.Controls.Add(Me.btnConta)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.labelPeixe)
        Me.Controls.Add(Me.labelCarne)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxDias)
        Me.Controls.Add(Me.labelDia)
        Me.Controls.Add(Me.PictureBox4)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Restaurante"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxDias As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelDia As Label
    Friend WithEvents labelCarne As Label
    Friend WithEvents labelPeixe As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnConta As Button
End Class
