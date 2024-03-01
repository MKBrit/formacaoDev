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
        MenuStrip1 = New MenuStrip()
        FicheiroToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarTudoToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        ColarToolStripMenuItem = New ToolStripMenuItem()
        CortarToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        AdicionarToolStripMenuItem = New ToolStripMenuItem()
        LimparToolStripMenuItem = New ToolStripMenuItem()
        FormatarToolStripMenuItem = New ToolStripMenuItem()
        lbl_title = New Label()
        lbl_nome = New Label()
        lbl_morada = New Label()
        lbl_cod = New Label()
        lbl_local = New Label()
        lbl_tlm = New Label()
        txt_nome = New TextBox()
        txt_morada = New TextBox()
        txt_cod = New TextBox()
        txt_local = New TextBox()
        txt_tlm = New TextBox()
        btn_add = New Button()
        btn_clear = New Button()
        btn_format = New Button()
        txt_results = New TextBox()
        btn_save = New Button()
        btn_exit = New Button()
        FontDialog1 = New FontDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FicheiroToolStripMenuItem, EditarToolStripMenuItem, VerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(500, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FicheiroToolStripMenuItem
        ' 
        FicheiroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbrirToolStripMenuItem, GuardarToolStripMenuItem, ImprimirToolStripMenuItem, SairToolStripMenuItem})
        FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        FicheiroToolStripMenuItem.Size = New Size(61, 20)
        FicheiroToolStripMenuItem.Text = "Ficheiro"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(120, 22)
        AbrirToolStripMenuItem.Text = "&Abrir"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(120, 22)
        GuardarToolStripMenuItem.Text = "&Guardar"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(120, 22)
        ImprimirToolStripMenuItem.Text = "&Imprimir"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(120, 22)
        SairToolStripMenuItem.Text = "&Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelecionarTudoToolStripMenuItem, CopiarToolStripMenuItem, ColarToolStripMenuItem, CortarToolStripMenuItem})
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' SelecionarTudoToolStripMenuItem
        ' 
        SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        SelecionarTudoToolStripMenuItem.Size = New Size(156, 22)
        SelecionarTudoToolStripMenuItem.Text = "&Selecionar tudo"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(156, 22)
        CopiarToolStripMenuItem.Text = "&Copiar"
        ' 
        ' ColarToolStripMenuItem
        ' 
        ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        ColarToolStripMenuItem.Size = New Size(156, 22)
        ColarToolStripMenuItem.Text = "&Colar"
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(156, 22)
        CortarToolStripMenuItem.Text = "&Cortar"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdicionarToolStripMenuItem, LimparToolStripMenuItem, FormatarToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(35, 20)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' AdicionarToolStripMenuItem
        ' 
        AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        AdicionarToolStripMenuItem.Size = New Size(125, 22)
        AdicionarToolStripMenuItem.Text = "&Adicionar"
        ' 
        ' LimparToolStripMenuItem
        ' 
        LimparToolStripMenuItem.Name = "LimparToolStripMenuItem"
        LimparToolStripMenuItem.Size = New Size(125, 22)
        LimparToolStripMenuItem.Text = "&Limpar"
        ' 
        ' FormatarToolStripMenuItem
        ' 
        FormatarToolStripMenuItem.Name = "FormatarToolStripMenuItem"
        FormatarToolStripMenuItem.Size = New Size(125, 22)
        FormatarToolStripMenuItem.Text = "&Formatar"
        ' 
        ' lbl_title
        ' 
        lbl_title.AutoSize = True
        lbl_title.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_title.Location = New Point(127, 50)
        lbl_title.Name = "lbl_title"
        lbl_title.Size = New Size(234, 37)
        lbl_title.TabIndex = 0
        lbl_title.Text = "Dados de Cliente"
        ' 
        ' lbl_nome
        ' 
        lbl_nome.AutoSize = True
        lbl_nome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_nome.Location = New Point(50, 126)
        lbl_nome.Name = "lbl_nome"
        lbl_nome.Size = New Size(53, 21)
        lbl_nome.TabIndex = 1
        lbl_nome.Text = "Nome"
        ' 
        ' lbl_morada
        ' 
        lbl_morada.AutoSize = True
        lbl_morada.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_morada.Location = New Point(50, 154)
        lbl_morada.Name = "lbl_morada"
        lbl_morada.Size = New Size(64, 21)
        lbl_morada.TabIndex = 1
        lbl_morada.Text = "Morada"
        ' 
        ' lbl_cod
        ' 
        lbl_cod.AutoSize = True
        lbl_cod.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_cod.Location = New Point(50, 181)
        lbl_cod.Name = "lbl_cod"
        lbl_cod.Size = New Size(83, 21)
        lbl_cod.TabIndex = 1
        lbl_cod.Text = "Cód Postal"
        ' 
        ' lbl_local
        ' 
        lbl_local.AutoSize = True
        lbl_local.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_local.Location = New Point(50, 209)
        lbl_local.Name = "lbl_local"
        lbl_local.Size = New Size(84, 21)
        lbl_local.TabIndex = 1
        lbl_local.Text = "Localidade"
        ' 
        ' lbl_tlm
        ' 
        lbl_tlm.AutoSize = True
        lbl_tlm.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_tlm.Location = New Point(50, 238)
        lbl_tlm.Name = "lbl_tlm"
        lbl_tlm.Size = New Size(59, 21)
        lbl_tlm.TabIndex = 1
        lbl_tlm.Text = "Nº Tlm"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(163, 124)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(234, 23)
        txt_nome.TabIndex = 1
        ' 
        ' txt_morada
        ' 
        txt_morada.Location = New Point(163, 152)
        txt_morada.Name = "txt_morada"
        txt_morada.Size = New Size(234, 23)
        txt_morada.TabIndex = 2
        ' 
        ' txt_cod
        ' 
        txt_cod.Location = New Point(163, 179)
        txt_cod.Name = "txt_cod"
        txt_cod.Size = New Size(234, 23)
        txt_cod.TabIndex = 3
        ' 
        ' txt_local
        ' 
        txt_local.Location = New Point(163, 207)
        txt_local.Name = "txt_local"
        txt_local.Size = New Size(234, 23)
        txt_local.TabIndex = 4
        ' 
        ' txt_tlm
        ' 
        txt_tlm.Location = New Point(163, 236)
        txt_tlm.Name = "txt_tlm"
        txt_tlm.Size = New Size(234, 23)
        txt_tlm.TabIndex = 5
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(39, 284)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(102, 31)
        btn_add.TabIndex = 6
        btn_add.Text = "Adicionar"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(192, 284)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(102, 31)
        btn_clear.TabIndex = 7
        btn_clear.Text = "Limpar "
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' btn_format
        ' 
        btn_format.Location = New Point(350, 284)
        btn_format.Name = "btn_format"
        btn_format.Size = New Size(102, 31)
        btn_format.TabIndex = 8
        btn_format.Text = "Formatar"
        btn_format.UseVisualStyleBackColor = True
        ' 
        ' txt_results
        ' 
        txt_results.Location = New Point(39, 329)
        txt_results.Multiline = True
        txt_results.Name = "txt_results"
        txt_results.Size = New Size(413, 92)
        txt_results.TabIndex = 9
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(92, 431)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(102, 31)
        btn_save.TabIndex = 10
        btn_save.Text = "Guardar"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' btn_exit
        ' 
        btn_exit.Location = New Point(295, 431)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(102, 31)
        btn_exit.TabIndex = 11
        btn_exit.Text = "Sair"
        btn_exit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 474)
        Controls.Add(txt_results)
        Controls.Add(btn_exit)
        Controls.Add(btn_format)
        Controls.Add(btn_save)
        Controls.Add(btn_clear)
        Controls.Add(btn_add)
        Controls.Add(txt_tlm)
        Controls.Add(txt_local)
        Controls.Add(txt_cod)
        Controls.Add(txt_morada)
        Controls.Add(txt_nome)
        Controls.Add(lbl_tlm)
        Controls.Add(lbl_local)
        Controls.Add(lbl_cod)
        Controls.Add(lbl_morada)
        Controls.Add(lbl_nome)
        Controls.Add(lbl_title)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Novo Cliente"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_morada As Label
    Friend WithEvents lbl_cod As Label
    Friend WithEvents lbl_local As Label
    Friend WithEvents lbl_tlm As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents txt_local As TextBox
    Friend WithEvents txt_tlm As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_format As Button
    Friend WithEvents txt_results As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents FontDialog1 As FontDialog
End Class
