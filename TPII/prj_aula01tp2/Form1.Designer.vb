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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LinguagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBNETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvancadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PythonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JavaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplicativosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinguagensToolStripMenuItem, Me.AplicativosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LinguagensToolStripMenuItem
        '
        Me.LinguagensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBNETToolStripMenuItem, Me.CToolStripMenuItem, Me.PythonToolStripMenuItem, Me.JavaToolStripMenuItem})
        Me.LinguagensToolStripMenuItem.Image = CType(resources.GetObject("LinguagensToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LinguagensToolStripMenuItem.Name = "LinguagensToolStripMenuItem"
        Me.LinguagensToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.LinguagensToolStripMenuItem.Text = "&Linguagens"
        '
        'VBNETToolStripMenuItem
        '
        Me.VBNETToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem})
        Me.VBNETToolStripMenuItem.Image = CType(resources.GetObject("VBNETToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VBNETToolStripMenuItem.Name = "VBNETToolStripMenuItem"
        Me.VBNETToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VBNETToolStripMenuItem.Text = "VB.NET"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicosToolStripMenuItem, Me.IntermediariosToolStripMenuItem, Me.AvancadosToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'BasicosToolStripMenuItem
        '
        Me.BasicosToolStripMenuItem.Name = "BasicosToolStripMenuItem"
        Me.BasicosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BasicosToolStripMenuItem.Text = "Basicos"
        '
        'IntermediariosToolStripMenuItem
        '
        Me.IntermediariosToolStripMenuItem.Name = "IntermediariosToolStripMenuItem"
        Me.IntermediariosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.IntermediariosToolStripMenuItem.Text = "Intermediarios"
        '
        'AvancadosToolStripMenuItem
        '
        Me.AvancadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroClientesToolStripMenuItem})
        Me.AvancadosToolStripMenuItem.Name = "AvancadosToolStripMenuItem"
        Me.AvancadosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AvancadosToolStripMenuItem.Text = "Avancados"
        '
        'CadastroClientesToolStripMenuItem
        '
        Me.CadastroClientesToolStripMenuItem.Image = CType(resources.GetObject("CadastroClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroClientesToolStripMenuItem.Name = "CadastroClientesToolStripMenuItem"
        Me.CadastroClientesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CadastroClientesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.CadastroClientesToolStripMenuItem.Text = "Cadastro Clientes"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Image = CType(resources.GetObject("CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CToolStripMenuItem.Text = "C#"
        '
        'PythonToolStripMenuItem
        '
        Me.PythonToolStripMenuItem.Image = CType(resources.GetObject("PythonToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PythonToolStripMenuItem.Name = "PythonToolStripMenuItem"
        Me.PythonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PythonToolStripMenuItem.Text = "Python"
        '
        'JavaToolStripMenuItem
        '
        Me.JavaToolStripMenuItem.Image = CType(resources.GetObject("JavaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JavaToolStripMenuItem.Name = "JavaToolStripMenuItem"
        Me.JavaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JavaToolStripMenuItem.Text = "Java"
        '
        'AplicativosToolStripMenuItem
        '
        Me.AplicativosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.ExcelToolStripMenuItem, Me.BlocoDeNotasToolStripMenuItem})
        Me.AplicativosToolStripMenuItem.Name = "AplicativosToolStripMenuItem"
        Me.AplicativosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AplicativosToolStripMenuItem.Text = "&Aplicativos"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = CType(resources.GetObject("ExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocoDeNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LinguagensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBNETToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvancadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PythonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JavaToolStripMenuItem As ToolStripMenuItem
End Class
