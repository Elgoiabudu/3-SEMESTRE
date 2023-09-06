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
        tbcFunc = New TabControl()
        TabPage1 = New TabPage()
        btnLimpar = New Button()
        btnSalvar = New Button()
        GroupBox1 = New GroupBox()
        txtSalLiq = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        txtSalBruto = New TextBox()
        txtINSS = New TextBox()
        Label6 = New Label()
        txtQtdSal = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        dataAdm = New DateTimePicker()
        cbCargo = New ComboBox()
        Label2 = New Label()
        foto = New PictureBox()
        txtNome = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        dgvFunc = New DataGridView()
        numero = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        cargo = New DataGridViewTextBoxColumn()
        bruto = New DataGridViewTextBoxColumn()
        inss = New DataGridViewTextBoxColumn()
        liquido = New DataGridViewTextBoxColumn()
        acao = New DataGridViewTextBoxColumn()
        TextBox6 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        tbcFunc.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(foto, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvFunc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbcFunc
        ' 
        tbcFunc.Controls.Add(TabPage1)
        tbcFunc.Controls.Add(TabPage2)
        tbcFunc.Location = New Point(5, 4)
        tbcFunc.Name = "tbcFunc"
        tbcFunc.SelectedIndex = 0
        tbcFunc.Size = New Size(675, 606)
        tbcFunc.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnLimpar)
        TabPage1.Controls.Add(btnSalvar)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(txtQtdSal)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(dataAdm)
        TabPage1.Controls.Add(cbCargo)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(foto)
        TabPage1.Controls.Add(txtNome)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(667, 578)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DADOS DOS FUNCIONÁRIOS"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(332, 213)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(134, 43)
        btnLimpar.TabIndex = 11
        btnLimpar.Text = "LIMPAR"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.Location = New Point(192, 213)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(134, 43)
        btnSalvar.TabIndex = 10
        btnSalvar.Text = "SALVAR"
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtSalLiq)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtSalBruto)
        GroupBox1.Controls.Add(txtINSS)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(6, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(514, 83)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "DEMONSTRATIVOS DE RENDIMENTOS"
        ' 
        ' txtSalLiq
        ' 
        txtSalLiq.Location = New Point(364, 41)
        txtSalLiq.Name = "txtSalLiq"
        txtSalLiq.Size = New Size(144, 23)
        txtSalLiq.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 15)
        Label5.TabIndex = 10
        Label5.Text = "SALÁRIO BRUTO"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(364, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 15)
        Label7.TabIndex = 14
        Label7.Text = "SALÁRIO LÍQUIDO"
        ' 
        ' txtSalBruto
        ' 
        txtSalBruto.Location = New Point(6, 41)
        txtSalBruto.Name = "txtSalBruto"
        txtSalBruto.Size = New Size(144, 23)
        txtSalBruto.TabIndex = 11
        ' 
        ' txtINSS
        ' 
        txtINSS.Location = New Point(186, 41)
        txtINSS.Name = "txtINSS"
        txtINSS.Size = New Size(144, 23)
        txtINSS.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(186, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 12
        Label6.Text = "INSS"
        ' 
        ' txtQtdSal
        ' 
        txtQtdSal.Location = New Point(370, 65)
        txtQtdSal.Name = "txtQtdSal"
        txtQtdSal.Size = New Size(150, 23)
        txtQtdSal.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(370, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 7
        Label4.Text = "QTDE. SLÁRIOS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(154, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 15)
        Label3.TabIndex = 6
        Label3.Text = "DATA DE ADMISSÃO"
        ' 
        ' dataAdm
        ' 
        dataAdm.Location = New Point(154, 65)
        dataAdm.Name = "dataAdm"
        dataAdm.Size = New Size(200, 23)
        dataAdm.TabIndex = 5
        ' 
        ' cbCargo
        ' 
        cbCargo.FormattingEnabled = True
        cbCargo.Location = New Point(6, 65)
        cbCargo.Name = "cbCargo"
        cbCargo.Size = New Size(134, 23)
        cbCargo.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 3
        Label2.Text = "CARGO"
        ' 
        ' foto
        ' 
        foto.BackgroundImage = CType(resources.GetObject("foto.BackgroundImage"), Image)
        foto.BackgroundImageLayout = ImageLayout.Stretch
        foto.Location = New Point(526, 21)
        foto.Name = "foto"
        foto.Size = New Size(135, 170)
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.TabIndex = 2
        foto.TabStop = False
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(6, 21)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(514, 23)
        txtNome.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 15)
        Label1.TabIndex = 0
        Label1.Text = "NOME DO FUNCIONÁRIO"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvFunc)
        TabPage2.Controls.Add(TextBox6)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(667, 578)
        TabPage2.TabIndex = 1
        TabPage2.Text = "LISTAGEM DE FUNCIONÁRIOS"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvFunc
        ' 
        dgvFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvFunc.Columns.AddRange(New DataGridViewColumn() {numero, nome, cargo, bruto, inss, liquido, acao})
        dgvFunc.Location = New Point(6, 35)
        dgvFunc.Name = "dgvFunc"
        dgvFunc.RowTemplate.Height = 25
        dgvFunc.Size = New Size(655, 537)
        dgvFunc.TabIndex = 1
        ' 
        ' numero
        ' 
        numero.HeaderText = "Nº"
        numero.Name = "numero"
        ' 
        ' nome
        ' 
        nome.HeaderText = "NOME DO FUNCIONÁRIO"
        nome.Name = "nome"
        ' 
        ' cargo
        ' 
        cargo.HeaderText = "CARGO"
        cargo.Name = "cargo"
        ' 
        ' bruto
        ' 
        bruto.HeaderText = "SALÁRIO BRUTO"
        bruto.Name = "bruto"
        ' 
        ' inss
        ' 
        inss.HeaderText = "INSS"
        inss.Name = "inss"
        ' 
        ' liquido
        ' 
        liquido.HeaderText = "SALÁRIO LÍQUIDO"
        liquido.Name = "liquido"
        ' 
        ' acao
        ' 
        acao.HeaderText = "AÇÕES"
        acao.Name = "acao"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(6, 6)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(285, 23)
        TextBox6.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 613)
        Controls.Add(tbcFunc)
        Name = "Form1"
        Text = "CADASTRO DE FUNCINÁRIOS"
        tbcFunc.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(foto, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvFunc, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tbcFunc As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtQtdSal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dataAdm As DateTimePicker
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents foto As PictureBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalLiq As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalBruto As TextBox
    Friend WithEvents txtINSS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvFunc As DataGridView
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents bruto As DataGridViewTextBoxColumn
    Friend WithEvents inss As DataGridViewTextBoxColumn
    Friend WithEvents liquido As DataGridViewTextBoxColumn
    Friend WithEvents acao As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
