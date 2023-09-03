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
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        PedidosToolStripMenuItem = New ToolStripMenuItem()
        FornecedoresToolStripMenuItem1 = New ToolStripMenuItem()
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
        CadastroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClienteToolStripMenuItem, FilmesToolStripMenuItem, FornecedoresToolStripMenuItem, PedidosToolStripMenuItem1})
        CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        CadastroToolStripMenuItem.Size = New Size(66, 20)
        CadastroToolStripMenuItem.Text = "&Cadastro"
        ' 
        ' ClienteToolStripMenuItem
        ' 
        ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        ClienteToolStripMenuItem.Size = New Size(180, 22)
        ClienteToolStripMenuItem.Text = "Cliente"
        ' 
        ' FilmesToolStripMenuItem
        ' 
        FilmesToolStripMenuItem.Name = "FilmesToolStripMenuItem"
        FilmesToolStripMenuItem.Size = New Size(180, 22)
        FilmesToolStripMenuItem.Text = "Filmes"
        ' 
        ' FornecedoresToolStripMenuItem
        ' 
        FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        FornecedoresToolStripMenuItem.Size = New Size(180, 22)
        FornecedoresToolStripMenuItem.Text = "Fornecedores"
        ' 
        ' PedidosToolStripMenuItem1
        ' 
        PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        PedidosToolStripMenuItem1.Size = New Size(180, 22)
        PedidosToolStripMenuItem1.Text = "Pedidos"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, PedidosToolStripMenuItem, FornecedoresToolStripMenuItem1})
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(71, 20)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(145, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' PedidosToolStripMenuItem
        ' 
        PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        PedidosToolStripMenuItem.Size = New Size(145, 22)
        PedidosToolStripMenuItem.Text = "Pedidos"
        ' 
        ' FornecedoresToolStripMenuItem1
        ' 
        FornecedoresToolStripMenuItem1.Name = "FornecedoresToolStripMenuItem1"
        FornecedoresToolStripMenuItem1.Size = New Size(145, 22)
        FornecedoresToolStripMenuItem1.Text = "Fornecedores"
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
    Friend WithEvents FornecedoresToolStripMenuItem1 As ToolStripMenuItem
End Class
