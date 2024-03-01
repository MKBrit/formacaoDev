<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdBtn1 = New System.Windows.Forms.Button()
        Me.cmdBtn2 = New System.Windows.Forms.Button()
        Me.cmdBtn3 = New System.Windows.Forms.Button()
        Me.imgA = New System.Windows.Forms.PictureBox()
        Me.imgB = New System.Windows.Forms.PictureBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.imgD = New System.Windows.Forms.PictureBox()
        Me.imgC = New System.Windows.Forms.PictureBox()
        CType(Me.imgA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBtn1
        '
        Me.cmdBtn1.Location = New System.Drawing.Point(109, 182)
        Me.cmdBtn1.Name = "cmdBtn1"
        Me.cmdBtn1.Size = New System.Drawing.Size(142, 62)
        Me.cmdBtn1.TabIndex = 0
        Me.cmdBtn1.Text = "cmd switch case"
        Me.cmdBtn1.UseVisualStyleBackColor = True
        '
        'cmdBtn2
        '
        Me.cmdBtn2.Location = New System.Drawing.Point(109, 289)
        Me.cmdBtn2.Name = "cmdBtn2"
        Me.cmdBtn2.Size = New System.Drawing.Size(142, 62)
        Me.cmdBtn2.TabIndex = 1
        Me.cmdBtn2.Text = "cmd if"
        Me.cmdBtn2.UseVisualStyleBackColor = True
        '
        'cmdBtn3
        '
        Me.cmdBtn3.Location = New System.Drawing.Point(109, 70)
        Me.cmdBtn3.Name = "cmdBtn3"
        Me.cmdBtn3.Size = New System.Drawing.Size(142, 62)
        Me.cmdBtn3.TabIndex = 0
        Me.cmdBtn3.Text = "cmd btn mes"
        Me.cmdBtn3.UseVisualStyleBackColor = True
        '
        'imgA
        '
        Me.imgA.Image = CType(resources.GetObject("imgA.Image"), System.Drawing.Image)
        Me.imgA.Location = New System.Drawing.Point(521, 116)
        Me.imgA.Name = "imgA"
        Me.imgA.Size = New System.Drawing.Size(90, 84)
        Me.imgA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgA.TabIndex = 2
        Me.imgA.TabStop = False
        Me.imgA.Visible = False
        '
        'imgB
        '
        Me.imgB.Image = CType(resources.GetObject("imgB.Image"), System.Drawing.Image)
        Me.imgB.Location = New System.Drawing.Point(521, 116)
        Me.imgB.Name = "imgB"
        Me.imgB.Size = New System.Drawing.Size(90, 84)
        Me.imgB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgB.TabIndex = 2
        Me.imgB.TabStop = False
        Me.imgB.Visible = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Plan A", "Plan B", "Plan C", "Plan D"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(538, 242)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(58, 64)
        Me.CheckedListBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Plan A", "Plan B", "Plan C", "Plan D"})
        Me.ComboBox1.Location = New System.Drawing.Point(521, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(90, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'imgD
        '
        Me.imgD.Image = CType(resources.GetObject("imgD.Image"), System.Drawing.Image)
        Me.imgD.Location = New System.Drawing.Point(521, 116)
        Me.imgD.Name = "imgD"
        Me.imgD.Size = New System.Drawing.Size(90, 84)
        Me.imgD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgD.TabIndex = 5
        Me.imgD.TabStop = False
        Me.imgD.Visible = False
        '
        'imgC
        '
        Me.imgC.Image = CType(resources.GetObject("imgC.Image"), System.Drawing.Image)
        Me.imgC.Location = New System.Drawing.Point(521, 116)
        Me.imgC.Name = "imgC"
        Me.imgC.Size = New System.Drawing.Size(90, 84)
        Me.imgC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgC.TabIndex = 6
        Me.imgC.TabStop = False
        Me.imgC.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.imgD)
        Me.Controls.Add(Me.imgC)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.imgB)
        Me.Controls.Add(Me.imgA)
        Me.Controls.Add(Me.cmdBtn2)
        Me.Controls.Add(Me.cmdBtn3)
        Me.Controls.Add(Me.cmdBtn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBtn1 As Button
    Friend WithEvents cmdBtn2 As Button
    Friend WithEvents cmdBtn3 As Button
    Friend WithEvents imgA As PictureBox
    Friend WithEvents imgB As PictureBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents imgD As PictureBox
    Friend WithEvents imgC As PictureBox
End Class
