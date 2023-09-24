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
        MenuStrip1 = New MenuStrip()
        CadastroToolStripMenuItem = New ToolStripMenuItem()
        ClienteToolStripMenuItem = New ToolStripMenuItem()
        FilmesToolStripMenuItem = New ToolStripMenuItem()
        FornecedoresToolStripMenuItem = New ToolStripMenuItem()
        PedidosToolStripMenuItem1 = New ToolStripMenuItem()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        PedidosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CadastroToolStripMenuItem, ConsultasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1212, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CadastroToolStripMenuItem
        ' 
        CadastroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClienteToolStripMenuItem, FilmesToolStripMenuItem, FornecedoresToolStripMenuItem, PedidosToolStripMenuItem1, CategoriasToolStripMenuItem})
        CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        CadastroToolStripMenuItem.Size = New Size(66, 20)
        CadastroToolStripMenuItem.Text = "&Cadastro"
        ' 
        ' ClienteToolStripMenuItem
        ' 
        ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        ClienteToolStripMenuItem.ShortcutKeys = Keys.F1
        ClienteToolStripMenuItem.Size = New Size(180, 22)
        ClienteToolStripMenuItem.Text = "Cliente"
        ' 
        ' FilmesToolStripMenuItem
        ' 
        FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem"
        FilmesToolStripMenuItem.ShortcutKeys = Keys.F2
        FilmesToolStripMenuItem.Size = New Size(180, 22)
        FilmesToolStripMenuItem.Text = "Filmes"
        ' 
        ' FornecedoresToolStripMenuItem
        ' 
        FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        FornecedoresToolStripMenuItem.ShortcutKeys = Keys.F3
        FornecedoresToolStripMenuItem.Size = New Size(180, 22)
        FornecedoresToolStripMenuItem.Text = "Fornecedores"
        ' 
        ' PedidosToolStripMenuItem1
        ' 
        PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        PedidosToolStripMenuItem1.ShortcutKeys = Keys.F4
        PedidosToolStripMenuItem1.Size = New Size(180, 22)
        PedidosToolStripMenuItem1.Text = "Pedidos"
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.ShortcutKeys = Keys.F5
        CategoriasToolStripMenuItem.Size = New Size(180, 22)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, PedidosToolStripMenuItem})
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(71, 20)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ClientesToolStripMenuItem.Size = New Size(180, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' PedidosToolStripMenuItem
        ' 
        PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        PedidosToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F2
        PedidosToolStripMenuItem.Size = New Size(180, 22)
        PedidosToolStripMenuItem.Text = "Pedidos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1212, 547)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FilmesStar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilmesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
End Class
