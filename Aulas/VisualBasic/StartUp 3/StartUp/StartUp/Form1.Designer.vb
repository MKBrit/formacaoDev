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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonHappy = New System.Windows.Forms.Button()
        Me.ButtonSad = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.CheckBoxHappy = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSad = New System.Windows.Forms.CheckBox()
        Me.PictureHappy = New System.Windows.Forms.PictureBox()
        Me.PictureSad = New System.Windows.Forms.PictureBox()
        Me.LabelHappy = New System.Windows.Forms.Label()
        Me.LabelSad = New System.Windows.Forms.Label()
        CType(Me.PictureHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureSad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStart.FlatAppearance.BorderSize = 0
        Me.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStart.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonStart.Location = New System.Drawing.Point(186, 203)
        Me.ButtonStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(98, 64)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'ButtonHappy
        '
        Me.ButtonHappy.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHappy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHappy.Enabled = False
        Me.ButtonHappy.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonHappy.FlatAppearance.BorderSize = 0
        Me.ButtonHappy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHappy.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHappy.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonHappy.Location = New System.Drawing.Point(72, 203)
        Me.ButtonHappy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonHappy.Name = "ButtonHappy"
        Me.ButtonHappy.Size = New System.Drawing.Size(99, 30)
        Me.ButtonHappy.TabIndex = 1
        Me.ButtonHappy.Text = "Happy"
        Me.ButtonHappy.UseVisualStyleBackColor = False
        Me.ButtonHappy.Visible = False
        '
        'ButtonSad
        '
        Me.ButtonSad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonSad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSad.Enabled = False
        Me.ButtonSad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonSad.FlatAppearance.BorderSize = 0
        Me.ButtonSad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSad.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonSad.Location = New System.Drawing.Point(301, 203)
        Me.ButtonSad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSad.Name = "ButtonSad"
        Me.ButtonSad.Size = New System.Drawing.Size(99, 30)
        Me.ButtonSad.TabIndex = 2
        Me.ButtonSad.Text = "Sad"
        Me.ButtonSad.UseVisualStyleBackColor = False
        Me.ButtonSad.Visible = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonExit.FlatAppearance.BorderSize = 0
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.ForeColor = System.Drawing.Color.Black
        Me.ButtonExit.Location = New System.Drawing.Point(212, 317)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(51, 37)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        Me.ButtonExit.Visible = False
        '
        'CheckBoxHappy
        '
        Me.CheckBoxHappy.AutoSize = True
        Me.CheckBoxHappy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxHappy.Enabled = False
        Me.CheckBoxHappy.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxHappy.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBoxHappy.Location = New System.Drawing.Point(72, 172)
        Me.CheckBoxHappy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxHappy.Name = "CheckBoxHappy"
        Me.CheckBoxHappy.Size = New System.Drawing.Size(90, 29)
        Me.CheckBoxHappy.TabIndex = 4
        Me.CheckBoxHappy.Text = "Happy"
        Me.CheckBoxHappy.UseVisualStyleBackColor = True
        Me.CheckBoxHappy.Visible = False
        '
        'CheckBoxSad
        '
        Me.CheckBoxSad.AutoSize = True
        Me.CheckBoxSad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CheckBoxSad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxSad.Enabled = False
        Me.CheckBoxSad.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBoxSad.Location = New System.Drawing.Point(313, 172)
        Me.CheckBoxSad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxSad.Name = "CheckBoxSad"
        Me.CheckBoxSad.Size = New System.Drawing.Size(66, 29)
        Me.CheckBoxSad.TabIndex = 5
        Me.CheckBoxSad.Text = "Sad"
        Me.CheckBoxSad.UseVisualStyleBackColor = False
        Me.CheckBoxSad.Visible = False
        '
        'PictureHappy
        '
        Me.PictureHappy.Image = CType(resources.GetObject("PictureHappy.Image"), System.Drawing.Image)
        Me.PictureHappy.Location = New System.Drawing.Point(46, 41)
        Me.PictureHappy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureHappy.Name = "PictureHappy"
        Me.PictureHappy.Size = New System.Drawing.Size(150, 123)
        Me.PictureHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureHappy.TabIndex = 6
        Me.PictureHappy.TabStop = False
        Me.PictureHappy.Visible = False
        '
        'PictureSad
        '
        Me.PictureSad.Image = CType(resources.GetObject("PictureSad.Image"), System.Drawing.Image)
        Me.PictureSad.Location = New System.Drawing.Point(271, 41)
        Me.PictureSad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureSad.Name = "PictureSad"
        Me.PictureSad.Size = New System.Drawing.Size(150, 123)
        Me.PictureSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureSad.TabIndex = 7
        Me.PictureSad.TabStop = False
        Me.PictureSad.Visible = False
        '
        'LabelHappy
        '
        Me.LabelHappy.AutoSize = True
        Me.LabelHappy.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHappy.ForeColor = System.Drawing.Color.Gold
        Me.LabelHappy.Location = New System.Drawing.Point(88, 12)
        Me.LabelHappy.Name = "LabelHappy"
        Me.LabelHappy.Size = New System.Drawing.Size(71, 25)
        Me.LabelHappy.TabIndex = 8
        Me.LabelHappy.Text = "Happy"
        Me.LabelHappy.Visible = False
        '
        'LabelSad
        '
        Me.LabelSad.AutoSize = True
        Me.LabelSad.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSad.ForeColor = System.Drawing.Color.Red
        Me.LabelSad.Location = New System.Drawing.Point(322, 12)
        Me.LabelSad.Name = "LabelSad"
        Me.LabelSad.Size = New System.Drawing.Size(47, 25)
        Me.LabelSad.TabIndex = 9
        Me.LabelSad.Text = "Sad"
        Me.LabelSad.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(464, 423)
        Me.Controls.Add(Me.LabelSad)
        Me.Controls.Add(Me.LabelHappy)
        Me.Controls.Add(Me.PictureSad)
        Me.Controls.Add(Me.PictureHappy)
        Me.Controls.Add(Me.CheckBoxSad)
        Me.Controls.Add(Me.CheckBoxHappy)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSad)
        Me.Controls.Add(Me.ButtonHappy)
        Me.Controls.Add(Me.ButtonStart)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.AliceBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "StartUp"
        CType(Me.PictureHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureSad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonHappy As Button
    Friend WithEvents ButtonSad As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents CheckBoxHappy As CheckBox
    Friend WithEvents CheckBoxSad As CheckBox
    Friend WithEvents PictureHappy As PictureBox
    Friend WithEvents PictureSad As PictureBox
    Friend WithEvents LabelHappy As Label
    Friend WithEvents LabelSad As Label
End Class
