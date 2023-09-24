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
        Label11 = New Label()
        txtEstado = New TextBox()
        Label10 = New Label()
        txtCidade = New TextBox()
        Label9 = New Label()
        txtEndereco = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label3 = New Label()
        txtCod = New TextBox()
        foto = New PictureBox()
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
        editar = New DataGridViewImageColumn()
        deletar = New DataGridViewImageColumn()
        btnSalvar = New Button()
        Label13 = New Label()
        txtPesq = New TextBox()
        mkRG = New MaskedTextBox()
        mkCPF = New MaskedTextBox()
        mkCel = New MaskedTextBox()
        mkFixo = New MaskedTextBox()
        mkCEP = New MaskedTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        CType(foto, ComponentModel.ISupportInitialize).BeginInit()
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
        txtEstado.Location = New Point(614, 115)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(144, 23)
        txtEstado.TabIndex = 10
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
        txtCidade.Location = New Point(443, 115)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(165, 23)
        txtCidade.TabIndex = 9
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
        txtEndereco.Location = New Point(164, 115)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(273, 23)
        txtEndereco.TabIndex = 8
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1063, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 46
        Label7.Text = "TELEFONE FIXO"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(362, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 15)
        Label5.TabIndex = 42
        Label5.Text = "RG"
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
        txtEmail.Location = New Point(664, 71)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(393, 23)
        txtEmail.TabIndex = 5
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
        txtCod.Enabled = False
        txtCod.Location = New Point(11, 27)
        txtCod.Name = "txtCod"
        txtCod.Size = New Size(144, 23)
        txtCod.TabIndex = 37
        ' 
        ' foto
        ' 
        foto.BackgroundImage = CType(resources.GetObject("foto.BackgroundImage"), Image)
        foto.BackgroundImageLayout = ImageLayout.Stretch
        foto.Location = New Point(1213, 9)
        foto.Name = "foto"
        foto.Size = New Size(108, 138)
        foto.SizeMode = PictureBoxSizeMode.StretchImage
        foto.TabIndex = 36
        foto.TabStop = False
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
        txtSobrenome.Location = New Point(160, 71)
        txtSobrenome.Name = "txtSobrenome"
        txtSobrenome.Size = New Size(196, 23)
        txtSobrenome.TabIndex = 2
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
        txtNome.Location = New Point(11, 71)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(144, 23)
        txtNome.TabIndex = 1
        ' 
        ' dgvCli
        ' 
        dgvCli.AllowUserToAddRows = False
        dgvCli.AllowUserToDeleteRows = False
        dgvCli.AllowUserToResizeColumns = False
        dgvCli.AllowUserToResizeRows = False
        dgvCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCli.Columns.AddRange(New DataGridViewColumn() {ID, NOME, SOBRENOME, EMAIL, CPF, RG, CELULAR, TELEFONE, ENDERECO, CIDADE, ESTADO, CEP, editar, deletar})
        dgvCli.Location = New Point(11, 173)
        dgvCli.Name = "dgvCli"
        dgvCli.ReadOnly = True
        dgvCli.RowHeadersWidth = 5
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
        SOBRENOME.ReadOnly = True
        ' 
        ' EMAIL
        ' 
        EMAIL.HeaderText = "EMAIL"
        EMAIL.Name = "EMAIL"
        EMAIL.ReadOnly = True
        ' 
        ' CPF
        ' 
        CPF.HeaderText = "CPF"
        CPF.Name = "CPF"
        CPF.ReadOnly = True
        ' 
        ' RG
        ' 
        RG.HeaderText = "RG"
        RG.Name = "RG"
        RG.ReadOnly = True
        ' 
        ' CELULAR
        ' 
        CELULAR.HeaderText = "CELULAR"
        CELULAR.Name = "CELULAR"
        CELULAR.ReadOnly = True
        ' 
        ' TELEFONE
        ' 
        TELEFONE.HeaderText = "TELEFONE"
        TELEFONE.Name = "TELEFONE"
        TELEFONE.ReadOnly = True
        ' 
        ' ENDERECO
        ' 
        ENDERECO.HeaderText = "ENDERECO"
        ENDERECO.Name = "ENDERECO"
        ENDERECO.ReadOnly = True
        ' 
        ' CIDADE
        ' 
        CIDADE.HeaderText = "CIDADE"
        CIDADE.Name = "CIDADE"
        CIDADE.ReadOnly = True
        ' 
        ' ESTADO
        ' 
        ESTADO.HeaderText = "ESTADO"
        ESTADO.Name = "ESTADO"
        ESTADO.ReadOnly = True
        ' 
        ' CEP
        ' 
        CEP.HeaderText = "CEP"
        CEP.Name = "CEP"
        CEP.ReadOnly = True
        ' 
        ' editar
        ' 
        editar.HeaderText = "EDITAR"
        editar.Image = CType(resources.GetObject("editar.Image"), Image)
        editar.Name = "editar"
        editar.ReadOnly = True
        editar.Resizable = DataGridViewTriState.True
        editar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' deletar
        ' 
        deletar.HeaderText = "DELETAR"
        deletar.Image = CType(resources.GetObject("deletar.Image"), Image)
        deletar.Name = "deletar"
        deletar.ReadOnly = True
        deletar.Resizable = DataGridViewTriState.True
        deletar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.None
        btnSalvar.Location = New Point(1167, 97)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(40, 41)
        btnSalvar.TabIndex = 12
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
        ' txtPesq
        ' 
        txtPesq.BackColor = Color.White
        txtPesq.Location = New Point(212, 144)
        txtPesq.Name = "txtPesq"
        txtPesq.Size = New Size(396, 23)
        txtPesq.TabIndex = 13
        ' 
        ' mkRG
        ' 
        mkRG.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        mkRG.Location = New Point(362, 71)
        mkRG.Mask = "00000000-0"
        mkRG.Name = "mkRG"
        mkRG.Size = New Size(144, 23)
        mkRG.TabIndex = 3
        ' 
        ' mkCPF
        ' 
        mkCPF.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        mkCPF.Location = New Point(512, 71)
        mkCPF.Mask = "000,000,000-00"
        mkCPF.Name = "mkCPF"
        mkCPF.Size = New Size(144, 23)
        mkCPF.TabIndex = 4
        ' 
        ' mkCel
        ' 
        mkCel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        mkCel.Location = New Point(11, 115)
        mkCel.Mask = "(00)00000-0000"
        mkCel.Name = "mkCel"
        mkCel.Size = New Size(144, 23)
        mkCel.TabIndex = 7
        ' 
        ' mkFixo
        ' 
        mkFixo.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        mkFixo.Location = New Point(1063, 71)
        mkFixo.Mask = "(00)0000-0000"
        mkFixo.Name = "mkFixo"
        mkFixo.Size = New Size(144, 23)
        mkFixo.TabIndex = 6
        ' 
        ' mkCEP
        ' 
        mkCEP.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        mkCEP.Location = New Point(767, 115)
        mkCEP.Mask = "00000-000"
        mkCEP.Name = "mkCEP"
        mkCEP.Size = New Size(144, 23)
        mkCEP.TabIndex = 61
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' pesqCli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 584)
        Controls.Add(mkCEP)
        Controls.Add(mkFixo)
        Controls.Add(mkCel)
        Controls.Add(mkCPF)
        Controls.Add(mkRG)
        Controls.Add(Label13)
        Controls.Add(txtPesq)
        Controls.Add(btnSalvar)
        Controls.Add(dgvCli)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(txtEstado)
        Controls.Add(Label10)
        Controls.Add(txtCidade)
        Controls.Add(Label9)
        Controls.Add(txtEndereco)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(txtCod)
        Controls.Add(foto)
        Controls.Add(Label2)
        Controls.Add(txtSobrenome)
        Controls.Add(Label1)
        Controls.Add(txtNome)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "pesqCli"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CONSULTA DE CLIENTES"
        CType(foto, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCli, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents foto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dgvCli As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPesq As TextBox
    Friend WithEvents mkRG As MaskedTextBox
    Friend WithEvents mkCPF As MaskedTextBox
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
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents deletar As DataGridViewImageColumn
    Friend WithEvents mkCel As MaskedTextBox
    Friend WithEvents mkFixo As MaskedTextBox
    Friend WithEvents mkCEP As MaskedTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
