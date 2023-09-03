<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesqCli
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(pesqCli))
        Label12 = New Label()
        txtCEP = New TextBox()
        Label11 = New Label()
        txtEstado = New TextBox()
        Label10 = New Label()
        txtCidade = New TextBox()
        Label9 = New Label()
        txtEndereco = New TextBox()
        Label8 = New Label()
        txtCelular = New TextBox()
        Label7 = New Label()
        txtFixo = New TextBox()
        Label6 = New Label()
        txtCPF = New TextBox()
        Label5 = New Label()
        txtRG = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label3 = New Label()
        txtCod = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtSobrenome = New TextBox()
        Label1 = New Label()
        txtNome = New TextBox()
        dgvCli = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        NOME = New DataGridViewTextBoxColumn()
        SOBRENOME = New DataGridViewTextBoxColumn()
        EMAIL = New DataGridViewTextBoxColumn()
        CPF = New DataGridViewTextBoxColumn()
        RG = New DataGridViewTextBoxColumn()
        CELULAR = New DataGridViewTextBoxColumn()
        TELEFONE = New DataGridViewTextBoxColumn()
        ENDERECO = New DataGridViewTextBoxColumn()
        CIDADE = New DataGridViewTextBoxColumn()
        ESTADO = New DataGridViewTextBoxColumn()
        CEP = New DataGridViewTextBoxColumn()
        AÇÕES = New DataGridViewTextBoxColumn()
        btnSalvar = New Button()
        Label13 = New Label()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCli, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(767, 97)
        Label12.Name = "Label12"
        Label12.Size = New Size(28, 15)
        Label12.TabIndex = 56
        Label12.Text = "CEP"
        ' 
        ' txtCEP
        ' 
        txtCEP.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCEP.Enabled = False
        txtCEP.Location = New Point(767, 115)
        txtCEP.Name = "txtCEP"
        txtCEP.Size = New Size(144, 23)
        txtCEP.TabIndex = 55
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(614, 97)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 15)
        Label11.TabIndex = 54
        Label11.Text = "ESTADO"
        ' 
        ' txtEstado
        ' 
        txtEstado.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtEstado.Enabled = False
        txtEstado.Location = New Point(614, 115)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(144, 23)
        txtEstado.TabIndex = 53
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(443, 97)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 15)
        Label10.TabIndex = 52
        Label10.Text = "CIDADE"
        ' 
        ' txtCidade
        ' 
        txtCidade.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCidade.Enabled = False
        txtCidade.Location = New Point(443, 115)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(165, 23)
        txtCidade.TabIndex = 51
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(164, 97)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 15)
        Label9.TabIndex = 50
        Label9.Text = "ENDEREÇO"
        ' 
        ' txtEndereco
        ' 
        txtEndereco.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtEndereco.Enabled = False
        txtEndereco.Location = New Point(164, 115)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(273, 23)
        txtEndereco.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(11, 97)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 15)
        Label8.TabIndex = 48
        Label8.Text = "TELEFONE CELULAR"
        ' 
        ' txtCelular
        ' 
        txtCelular.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCelular.Enabled = False
        txtCelular.Location = New Point(11, 115)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(144, 23)
        txtCelular.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1063, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 46
        Label7.Text = "TELEFONE FIXO"
        ' 
        ' txtFixo
        ' 
        txtFixo.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtFixo.Enabled = False
        txtFixo.Location = New Point(1063, 71)
        txtFixo.Name = "txtFixo"
        txtFixo.Size = New Size(144, 23)
        txtFixo.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(513, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 44
        Label6.Text = "CPF"
        ' 
        ' txtCPF
        ' 
        txtCPF.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCPF.Enabled = False
        txtCPF.Location = New Point(513, 71)
        txtCPF.Name = "txtCPF"
        txtCPF.Size = New Size(144, 23)
        txtCPF.TabIndex = 43
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(362, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 15)
        Label5.TabIndex = 42
        Label5.Text = "RG"
        ' 
        ' txtRG
        ' 
        txtRG.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtRG.Enabled = False
        txtRG.Location = New Point(362, 71)
        txtRG.Name = "txtRG"
        txtRG.Size = New Size(144, 23)
        txtRG.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(664, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 40
        Label4.Text = "E-MAIL"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtEmail.Enabled = False
        txtEmail.Location = New Point(664, 71)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(393, 23)
        txtEmail.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 38
        Label3.Text = "CÓD. CLIENTE"
        ' 
        ' txtCod
        ' 
        txtCod.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtCod.Location = New Point(11, 27)
        txtCod.Name = "txtCod"
        txtCod.Size = New Size(144, 23)
        txtCod.TabIndex = 37
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(1213, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 138)
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(160, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 35
        Label2.Text = "SOBRENOME"
        ' 
        ' txtSobrenome
        ' 
        txtSobrenome.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtSobrenome.Enabled = False
        txtSobrenome.Location = New Point(160, 71)
        txtSobrenome.Name = "txtSobrenome"
        txtSobrenome.Size = New Size(196, 23)
        txtSobrenome.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 33
        Label1.Text = "NOME"
        ' 
        ' txtNome
        ' 
        txtNome.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        txtNome.Enabled = False
        txtNome.Location = New Point(11, 71)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(144, 23)
        txtNome.TabIndex = 32
        ' 
        ' dgvCli
        ' 
        dgvCli.AllowUserToAddRows = False
        dgvCli.AllowUserToDeleteRows = False
        dgvCli.AllowUserToOrderColumns = True
        dgvCli.AllowUserToResizeColumns = False
        dgvCli.AllowUserToResizeRows = False
        dgvCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCli.Columns.AddRange(New DataGridViewColumn() {ID, NOME, SOBRENOME, EMAIL, CPF, RG, CELULAR, TELEFONE, ENDERECO, CIDADE, ESTADO, CEP, AÇÕES})
        dgvCli.Location = New Point(11, 173)
        dgvCli.Name = "dgvCli"
        dgvCli.RowTemplate.Height = 25
        dgvCli.Size = New Size(1310, 399)
        dgvCli.TabIndex = 57
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' NOME
        ' 
        NOME.HeaderText = "NOME"
        NOME.Name = "NOME"
        NOME.ReadOnly = True
        ' 
        ' SOBRENOME
        ' 
        SOBRENOME.HeaderText = "SOBRENOME"
        SOBRENOME.Name = "SOBRENOME"
        ' 
        ' EMAIL
        ' 
        EMAIL.HeaderText = "EMAIL"
        EMAIL.Name = "EMAIL"
        ' 
        ' CPF
        ' 
        CPF.HeaderText = "CPF"
        CPF.Name = "CPF"
        ' 
        ' RG
        ' 
        RG.HeaderText = "RG"
        RG.Name = "RG"
        ' 
        ' CELULAR
        ' 
        CELULAR.HeaderText = "CELULAR"
        CELULAR.Name = "CELULAR"
        ' 
        ' TELEFONE
        ' 
        TELEFONE.HeaderText = "TELEFONE"
        TELEFONE.Name = "TELEFONE"
        ' 
        ' ENDERECO
        ' 
        ENDERECO.HeaderText = "ENDERECO"
        ENDERECO.Name = "ENDERECO"
        ' 
        ' CIDADE
        ' 
        CIDADE.HeaderText = "CIDADE"
        CIDADE.Name = "CIDADE"
        ' 
        ' ESTADO
        ' 
        ESTADO.HeaderText = "ESTADO"
        ESTADO.Name = "ESTADO"
        ' 
        ' CEP
        ' 
        CEP.HeaderText = "CEP"
        CEP.Name = "CEP"
        ' 
        ' AÇÕES
        ' 
        AÇÕES.HeaderText = "AÇÕES"
        AÇÕES.Name = "AÇÕES"
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.None
        btnSalvar.Location = New Point(1167, 97)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(40, 41)
        btnSalvar.TabIndex = 58
        btnSalvar.TextAlign = ContentAlignment.MiddleRight
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(10, 147)
        Label13.Name = "Label13"
        Label13.Size = New Size(196, 15)
        Label13.TabIndex = 60
        Label13.Text = "DIGITE UM NOME PARA PESQUISAR"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Location = New Point(212, 144)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(396, 23)
        TextBox1.TabIndex = 59
        ' 
        ' pesqCli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 584)
        Controls.Add(Label13)
        Controls.Add(TextBox1)
        Controls.Add(btnSalvar)
        Controls.Add(dgvCli)
        Controls.Add(Label12)
        Controls.Add(txtCEP)
        Controls.Add(Label11)
        Controls.Add(txtEstado)
        Controls.Add(Label10)
        Controls.Add(txtCidade)
        Controls.Add(Label9)
        Controls.Add(txtEndereco)
        Controls.Add(Label8)
        Controls.Add(txtCelular)
        Controls.Add(Label7)
        Controls.Add(txtFixo)
        Controls.Add(Label6)
        Controls.Add(txtCPF)
        Controls.Add(Label5)
        Controls.Add(txtRG)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(txtCod)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtSobrenome)
        Controls.Add(Label1)
        Controls.Add(txtNome)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "pesqCli"
        Text = "CONSULTA DE CLIENTES"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCli, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFixo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRG As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dgvCli As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents SOBRENOME As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents RG As DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONE As DataGridViewTextBoxColumn
    Friend WithEvents ENDERECO As DataGridViewTextBoxColumn
    Friend WithEvents CIDADE As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents CEP As DataGridViewTextBoxColumn
    Friend WithEvents AÇÕES As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
