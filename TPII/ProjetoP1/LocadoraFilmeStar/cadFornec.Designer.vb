﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadFornec
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(cadFornec))
        Label3 = New Label()
        txtCodFornec = New TextBox()
        Label1 = New Label()
        txtNomeFornec = New TextBox()
        Label2 = New Label()
        txtEmailFornec = New TextBox()
        Label4 = New Label()
        txtCNPJ = New TextBox()
        Label5 = New Label()
        txtFoneFornec = New TextBox()
        Label6 = New Label()
        txtEnderecoFornec = New TextBox()
        Label7 = New Label()
        txtCidadeFornec = New TextBox()
        Label8 = New Label()
        txtEstadoFornec = New TextBox()
        Label9 = New Label()
        btnCancelarFornec = New Button()
        btnLimparFornec = New Button()
        btnSalvarFornec = New Button()
        dgvFornec = New DataGridView()
        cod = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        editar = New DataGridViewImageColumn()
        excluir = New DataGridViewImageColumn()
        cbSit = New ComboBox()
        Label10 = New Label()
        txtPesq = New TextBox()
        CType(dgvFornec, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 12
        Label3.Text = "CÓD. FORNECEDOR"
        ' 
        ' txtCodFornec
        ' 
        txtCodFornec.Enabled = False
        txtCodFornec.Location = New Point(12, 27)
        txtCodFornec.Name = "txtCodFornec"
        txtCodFornec.Size = New Size(144, 23)
        txtCodFornec.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 14
        Label1.Text = "NOME"
        ' 
        ' txtNomeFornec
        ' 
        txtNomeFornec.Location = New Point(12, 71)
        txtNomeFornec.Name = "txtNomeFornec"
        txtNomeFornec.Size = New Size(144, 23)
        txtNomeFornec.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 16
        Label2.Text = "EMAIL"
        ' 
        ' txtEmailFornec
        ' 
        txtEmailFornec.Location = New Point(175, 71)
        txtEmailFornec.Name = "txtEmailFornec"
        txtEmailFornec.Size = New Size(144, 23)
        txtEmailFornec.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(341, 53)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 18
        Label4.Text = "CNPJ"
        ' 
        ' txtCNPJ
        ' 
        txtCNPJ.Location = New Point(341, 71)
        txtCNPJ.Name = "txtCNPJ"
        txtCNPJ.Size = New Size(144, 23)
        txtCNPJ.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 20
        Label5.Text = "TELEFONE"
        ' 
        ' txtFoneFornec
        ' 
        txtFoneFornec.Location = New Point(12, 115)
        txtFoneFornec.Name = "txtFoneFornec"
        txtFoneFornec.Size = New Size(144, 23)
        txtFoneFornec.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(175, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 22
        Label6.Text = "ENDERECO"
        ' 
        ' txtEnderecoFornec
        ' 
        txtEnderecoFornec.Location = New Point(175, 115)
        txtEnderecoFornec.Name = "txtEnderecoFornec"
        txtEnderecoFornec.Size = New Size(310, 23)
        txtEnderecoFornec.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 24
        Label7.Text = "CIDADE"
        ' 
        ' txtCidadeFornec
        ' 
        txtCidadeFornec.Location = New Point(12, 159)
        txtCidadeFornec.Name = "txtCidadeFornec"
        txtCidadeFornec.Size = New Size(144, 23)
        txtCidadeFornec.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(175, 141)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 26
        Label8.Text = "ESTADO"
        ' 
        ' txtEstadoFornec
        ' 
        txtEstadoFornec.Location = New Point(175, 159)
        txtEstadoFornec.Name = "txtEstadoFornec"
        txtEstadoFornec.Size = New Size(144, 23)
        txtEstadoFornec.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(341, 141)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 15)
        Label9.TabIndex = 28
        Label9.Text = "SITUAÇÃO"
        ' 
        ' btnCancelarFornec
        ' 
        btnCancelarFornec.BackgroundImage = CType(resources.GetObject("btnCancelarFornec.BackgroundImage"), Image)
        btnCancelarFornec.BackgroundImageLayout = ImageLayout.None
        btnCancelarFornec.Location = New Point(375, 188)
        btnCancelarFornec.Name = "btnCancelarFornec"
        btnCancelarFornec.Size = New Size(110, 41)
        btnCancelarFornec.TabIndex = 34
        btnCancelarFornec.Text = "CANCELAR"
        btnCancelarFornec.TextAlign = ContentAlignment.MiddleRight
        btnCancelarFornec.UseVisualStyleBackColor = True
        ' 
        ' btnLimparFornec
        ' 
        btnLimparFornec.BackgroundImage = CType(resources.GetObject("btnLimparFornec.BackgroundImage"), Image)
        btnLimparFornec.BackgroundImageLayout = ImageLayout.None
        btnLimparFornec.Location = New Point(199, 188)
        btnLimparFornec.Name = "btnLimparFornec"
        btnLimparFornec.Size = New Size(110, 41)
        btnLimparFornec.TabIndex = 33
        btnLimparFornec.Text = "LIMPAR"
        btnLimparFornec.TextAlign = ContentAlignment.MiddleRight
        btnLimparFornec.UseVisualStyleBackColor = True
        ' 
        ' btnSalvarFornec
        ' 
        btnSalvarFornec.BackgroundImage = CType(resources.GetObject("btnSalvarFornec.BackgroundImage"), Image)
        btnSalvarFornec.BackgroundImageLayout = ImageLayout.None
        btnSalvarFornec.Location = New Point(12, 188)
        btnSalvarFornec.Name = "btnSalvarFornec"
        btnSalvarFornec.Size = New Size(110, 41)
        btnSalvarFornec.TabIndex = 32
        btnSalvarFornec.Text = "SALVAR"
        btnSalvarFornec.TextAlign = ContentAlignment.MiddleRight
        btnSalvarFornec.UseVisualStyleBackColor = True
        ' 
        ' dgvFornec
        ' 
        dgvFornec.AllowUserToAddRows = False
        dgvFornec.AllowUserToDeleteRows = False
        dgvFornec.AllowUserToResizeColumns = False
        dgvFornec.AllowUserToResizeRows = False
        dgvFornec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFornec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFornec.Columns.AddRange(New DataGridViewColumn() {cod, nome, editar, excluir})
        dgvFornec.Location = New Point(12, 273)
        dgvFornec.Name = "dgvFornec"
        dgvFornec.ReadOnly = True
        dgvFornec.RowHeadersWidth = 5
        dgvFornec.RowTemplate.Height = 25
        dgvFornec.ScrollBars = ScrollBars.Vertical
        dgvFornec.Size = New Size(473, 355)
        dgvFornec.TabIndex = 35
        ' 
        ' cod
        ' 
        cod.HeaderText = "CÓDIGO"
        cod.Name = "cod"
        cod.ReadOnly = True
        ' 
        ' nome
        ' 
        nome.HeaderText = "NOME"
        nome.Name = "nome"
        nome.ReadOnly = True
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
        ' excluir
        ' 
        excluir.HeaderText = "EXCLUIR"
        excluir.Image = CType(resources.GetObject("excluir.Image"), Image)
        excluir.Name = "excluir"
        excluir.ReadOnly = True
        excluir.Resizable = DataGridViewTriState.True
        excluir.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' cbSit
        ' 
        cbSit.FormattingEnabled = True
        cbSit.Items.AddRange(New Object() {"ATIVO", "INATIVO"})
        cbSit.Location = New Point(341, 159)
        cbSit.Name = "cbSit"
        cbSit.Size = New Size(141, 23)
        cbSit.TabIndex = 36
        cbSit.Text = "ATIVO"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 249)
        Label10.Name = "Label10"
        Label10.Size = New Size(102, 15)
        Label10.TabIndex = 38
        Label10.Text = "PESQUISAR FILME"
        ' 
        ' txtPesq
        ' 
        txtPesq.Location = New Point(120, 244)
        txtPesq.Name = "txtPesq"
        txtPesq.Size = New Size(178, 23)
        txtPesq.TabIndex = 37
        ' 
        ' cadFornec
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 640)
        Controls.Add(Label10)
        Controls.Add(txtPesq)
        Controls.Add(cbSit)
        Controls.Add(dgvFornec)
        Controls.Add(btnCancelarFornec)
        Controls.Add(btnLimparFornec)
        Controls.Add(btnSalvarFornec)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtEstadoFornec)
        Controls.Add(Label7)
        Controls.Add(txtCidadeFornec)
        Controls.Add(Label6)
        Controls.Add(txtEnderecoFornec)
        Controls.Add(Label5)
        Controls.Add(txtFoneFornec)
        Controls.Add(Label4)
        Controls.Add(txtCNPJ)
        Controls.Add(Label2)
        Controls.Add(txtEmailFornec)
        Controls.Add(Label1)
        Controls.Add(txtNomeFornec)
        Controls.Add(Label3)
        Controls.Add(txtCodFornec)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(510, 679)
        MinimizeBox = False
        MinimumSize = New Size(510, 679)
        Name = "cadFornec"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRO DE FORNECEDORES"
        CType(dgvFornec, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodFornec As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeFornec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmailFornec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCNPJ As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFoneFornec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEnderecoFornec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCidadeFornec As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstadoFornec As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCancelarFornec As Button
    Friend WithEvents btnLimparFornec As Button
    Friend WithEvents btnSalvarFornec As Button
    Friend WithEvents dgvFornec As DataGridView
    Friend WithEvents cod As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
    Friend WithEvents cbSit As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPesq As TextBox
End Class
