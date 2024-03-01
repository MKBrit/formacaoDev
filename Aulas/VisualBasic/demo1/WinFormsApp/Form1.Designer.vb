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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        cmd_btn_exit = New Button()
        cmd_btn_show = New Button()
        Img1 = New PictureBox()
        cmd_btn_hide = New Button()
        CheckImg1 = New CheckBox()
        Label1 = New Label()
        CType(Img1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_btn_exit
        ' 
        cmd_btn_exit.Cursor = Cursors.Hand
        cmd_btn_exit.Location = New Point(653, 396)
        cmd_btn_exit.Name = "cmd_btn_exit"
        cmd_btn_exit.Size = New Size(135, 42)
        cmd_btn_exit.TabIndex = 0
        cmd_btn_exit.Text = "Exit"
        cmd_btn_exit.UseVisualStyleBackColor = True
        ' 
        ' cmd_btn_show
        ' 
        cmd_btn_show.Cursor = Cursors.Hand
        cmd_btn_show.Location = New Point(653, 25)
        cmd_btn_show.Name = "cmd_btn_show"
        cmd_btn_show.Size = New Size(135, 57)
        cmd_btn_show.TabIndex = 1
        cmd_btn_show.Text = "Show"
        cmd_btn_show.UseVisualStyleBackColor = True
        ' 
        ' Img1
        ' 
        Img1.Image = CType(resources.GetObject("Img1.Image"), Image)
        Img1.InitialImage = Nothing
        Img1.Location = New Point(230, 100)
        Img1.Name = "Img1"
        Img1.Size = New Size(283, 257)
        Img1.SizeMode = PictureBoxSizeMode.StretchImage
        Img1.TabIndex = 2
        Img1.TabStop = False
        Img1.Visible = False
        ' 
        ' cmd_btn_hide
        ' 
        cmd_btn_hide.Cursor = Cursors.Hand
        cmd_btn_hide.Enabled = False
        cmd_btn_hide.Location = New Point(653, 100)
        cmd_btn_hide.Name = "cmd_btn_hide"
        cmd_btn_hide.Size = New Size(135, 61)
        cmd_btn_hide.TabIndex = 3
        cmd_btn_hide.Text = "Hide"
        cmd_btn_hide.UseVisualStyleBackColor = True
        ' 
        ' CheckImg1
        ' 
        CheckImg1.AutoSize = True
        CheckImg1.Location = New Point(82, 375)
        CheckImg1.Name = "CheckImg1"
        CheckImg1.Size = New Size(61, 19)
        CheckImg1.TabIndex = 4
        CheckImg1.Text = "Enable"
        CheckImg1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(230, 360)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 5
        Label1.Text = "by: Jim Marshall"
        Label1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(CheckImg1)
        Controls.Add(cmd_btn_hide)
        Controls.Add(Img1)
        Controls.Add(cmd_btn_show)
        Controls.Add(cmd_btn_exit)
        Name = "Form1"
        Text = "Start Up"
        CType(Img1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_btn_exit As Button
    Friend WithEvents cmd_btn_show As Button
    Friend WithEvents Img1 As PictureBox
    Friend WithEvents cmd_btn_hide As Button
    Friend WithEvents CheckImg1 As CheckBox
    Friend WithEvents Label1 As Label
End Class
