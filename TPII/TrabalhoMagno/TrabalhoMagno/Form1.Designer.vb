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
        OpenFileDialog1 = New OpenFileDialog()
        TabPage1 = New TabPage()
        btnLimpar = New Button()
        Label9 = New Label()
        txtPesq = New TextBox()
        dgvFunc = New DataGridView()
        nome = New DataGridViewTextBoxColumn()
        cargo = New DataGridViewTextBoxColumn()
        admissao = New DataGridViewTextBoxColumn()
        CPF = New DataGridViewTextBoxColumn()
        BRUTO = New DataGridViewTextBoxColumn()
        INSS = New DataGridViewTextBoxColumn()
        LIQUIDO = New DataGridViewTextBoxColumn()
        EDITAR = New DataGridViewImageColumn()
        DELETAR = New DataGridViewImageColumn()
        txtCpf = New MaskedTextBox()
        Label8 = New Label()
        btnSalvar = New Button()
        GroupBox1 = New GroupBox()
        txtSalLiq = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        txtSalBruto = New TextBox()
        txtINSS = New TextBox()
        Label6 = New Label()
        txtQtdSal = New TextBox()
        txtNome = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        dataAdm = New DateTimePicker()
        cbCargo = New ComboBox()
        Label2 = New Label()
        foto = New PictureBox()
        Label1 = New Label()
        tbcFunc = New TabControl()
        TabPage1.SuspendLayout()
        CType(dgvFunc, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(foto, ComponentModel.ISupportInitialize).BeginInit()
        tbcFunc.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnLimpar)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(txtPesq)
        TabPage1.Controls.Add(dgvFunc)
        TabPage1.Controls.Add(txtCpf)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(btnSalvar)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(txtQtdSal)
        TabPage1.Controls.Add(txtNome)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(dataAdm)
        TabPage1.Controls.Add(cbCargo)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(foto)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1222, 604)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DADOS DOS FUNCIONÁRIOS"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackColor = Color.Transparent
        btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), Image)
        btnLimpar.BackgroundImageLayout = ImageLayout.Center
        btnLimpar.Location = New Point(763, 21)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(85, 82)
        btnLimpar.TabIndex = 17
        btnLimpar.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(667, 149)
        Label9.Name = "Label9"
        Label9.Size = New Size(196, 15)
        Label9.TabIndex = 16
        Label9.Text = "DIGITE UM NOME PARA PESQUISAR"
        ' 
        ' txtPesq
        ' 
        txtPesq.Location = New Point(667, 168)
        txtPesq.Name = "txtPesq"
        txtPesq.Size = New Size(418, 23)
        txtPesq.TabIndex = 14
        ' 
        ' dgvFunc
        ' 
        dgvFunc.AllowUserToAddRows = False
        dgvFunc.AllowUserToDeleteRows = False
        dgvFunc.AllowUserToResizeColumns = False
        dgvFunc.AllowUserToResizeRows = False
        dgvFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFunc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFunc.Columns.AddRange(New DataGridViewColumn() {nome, cargo, admissao, CPF, BRUTO, INSS, LIQUIDO, EDITAR, DELETAR})
        dgvFunc.GridColor = SystemColors.ButtonFace
        dgvFunc.Location = New Point(6, 197)
        dgvFunc.Name = "dgvFunc"
        dgvFunc.ReadOnly = True
        dgvFunc.RowTemplate.Height = 25
        dgvFunc.Size = New Size(1210, 401)
        dgvFunc.TabIndex = 13
        ' 
        ' nome
        ' 
        nome.HeaderText = "NOME"
        nome.Name = "nome"
        nome.ReadOnly = True
        nome.Resizable = DataGridViewTriState.False
        ' 
        ' cargo
        ' 
        cargo.HeaderText = "CARGO"
        cargo.Name = "cargo"
        cargo.ReadOnly = True
        cargo.Resizable = DataGridViewTriState.False
        ' 
        ' admissao
        ' 
        admissao.HeaderText = "ADMISSAO"
        admissao.Name = "admissao"
        admissao.ReadOnly = True
        admissao.Resizable = DataGridViewTriState.False
        ' 
        ' CPF
        ' 
        CPF.HeaderText = "CPF"
        CPF.Name = "CPF"
        CPF.ReadOnly = True
        CPF.Resizable = DataGridViewTriState.False
        ' 
        ' BRUTO
        ' 
        BRUTO.HeaderText = "SAL. BRUTO"
        BRUTO.Name = "BRUTO"
        BRUTO.ReadOnly = True
        BRUTO.Resizable = DataGridViewTriState.False
        ' 
        ' INSS
        ' 
        INSS.HeaderText = "INSS"
        INSS.Name = "INSS"
        INSS.ReadOnly = True
        INSS.Resizable = DataGridViewTriState.False
        ' 
        ' LIQUIDO
        ' 
        LIQUIDO.HeaderText = "SAL. LIQUIDO"
        LIQUIDO.Name = "LIQUIDO"
        LIQUIDO.ReadOnly = True
        LIQUIDO.Resizable = DataGridViewTriState.False
        ' 
        ' EDITAR
        ' 
        EDITAR.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        EDITAR.HeaderText = "EDITAR"
        EDITAR.Image = CType(resources.GetObject("EDITAR.Image"), Image)
        EDITAR.MinimumWidth = 3
        EDITAR.Name = "EDITAR"
        EDITAR.ReadOnly = True
        EDITAR.Width = 129
        ' 
        ' DELETAR
        ' 
        DELETAR.HeaderText = "DELETAR"
        DELETAR.Image = CType(resources.GetObject("DELETAR.Image"), Image)
        DELETAR.Name = "DELETAR"
        DELETAR.ReadOnly = True
        ' 
        ' txtCpf
        ' 
        txtCpf.Location = New Point(6, 21)
        txtCpf.Mask = "000,000,000-00"
        txtCpf.Name = "txtCpf"
        txtCpf.Size = New Size(134, 23)
        txtCpf.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 3)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 15)
        Label8.TabIndex = 12
        Label8.Text = "CPF"
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackColor = Color.Transparent
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.Center
        btnSalvar.Location = New Point(667, 21)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(90, 82)
        btnSalvar.TabIndex = 10
        btnSalvar.UseVisualStyleBackColor = False
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
        txtSalLiq.Enabled = False
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
        txtSalBruto.Enabled = False
        txtSalBruto.Location = New Point(6, 41)
        txtSalBruto.Name = "txtSalBruto"
        txtSalBruto.Size = New Size(144, 23)
        txtSalBruto.TabIndex = 11
        ' 
        ' txtINSS
        ' 
        txtINSS.Enabled = False
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
        ' txtNome
        ' 
        txtNome.Location = New Point(154, 21)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(366, 23)
        txtNome.TabIndex = 2
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(154, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 15)
        Label1.TabIndex = 0
        Label1.Text = "NOME DO FUNCIONÁRIO"
        ' 
        ' tbcFunc
        ' 
        tbcFunc.Controls.Add(TabPage1)
        tbcFunc.Location = New Point(5, 14)
        tbcFunc.Name = "tbcFunc"
        tbcFunc.SelectedIndex = 0
        tbcFunc.Size = New Size(1230, 632)
        tbcFunc.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1236, 651)
        Controls.Add(tbcFunc)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "CADASTRO DE FUNCINÁRIOS"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvFunc, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(foto, ComponentModel.ISupportInitialize).EndInit()
        tbcFunc.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSalLiq As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalBruto As TextBox
    Friend WithEvents txtINSS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtdSal As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dataAdm As DateTimePicker
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents foto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbcFunc As TabControl
    Friend WithEvents dgvFunc As DataGridView
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents admissao As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents BRUTO As DataGridViewTextBoxColumn
    Friend WithEvents INSS As DataGridViewTextBoxColumn
    Friend WithEvents LIQUIDO As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents DELETAR As DataGridViewImageColumn
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPesq As TextBox
    Friend WithEvents btnLimpar As Button
End Class
