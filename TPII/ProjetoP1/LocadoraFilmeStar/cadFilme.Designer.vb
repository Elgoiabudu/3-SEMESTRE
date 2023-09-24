<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadFilme
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(cadFilme))
        Label1 = New Label()
        Label2 = New Label()
        txtNome = New TextBox()
        Label3 = New Label()
        txtSinopse = New RichTextBox()
        Label4 = New Label()
        dataLanc = New DateTimePicker()
        Label5 = New Label()
        cbFornec = New ComboBox()
        Label6 = New Label()
        txtValor = New TextBox()
        capaFilme = New PictureBox()
        cbCateg = New ComboBox()
        Label7 = New Label()
        btnCancelar = New Button()
        btnLimpar = New Button()
        btnSalvar = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        dvgFilme = New DataGridView()
        COD = New DataGridViewTextBoxColumn()
        DESC = New DataGridViewTextBoxColumn()
        VAL = New DataGridViewTextBoxColumn()
        EDIT = New DataGridViewImageColumn()
        DEL = New DataGridViewImageColumn()
        Label8 = New Label()
        TextBox1 = New TextBox()
        txtCod = New TextBox()
        CType(capaFilme, ComponentModel.ISupportInitialize).BeginInit()
        CType(dvgFilme, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 1
        Label1.Text = "CÓDIGO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 3
        Label2.Text = "NOME"
        ' 
        ' txtNome
        ' 
        txtNome.CharacterCasing = CharacterCasing.Upper
        txtNome.Location = New Point(12, 71)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(383, 23)
        txtNome.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 15)
        Label3.TabIndex = 5
        Label3.Text = "DATA DE LANÇAMENTO"
        ' 
        ' txtSinopse
        ' 
        txtSinopse.Location = New Point(10, 294)
        txtSinopse.Name = "txtSinopse"
        txtSinopse.Size = New Size(384, 131)
        txtSinopse.TabIndex = 6
        txtSinopse.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 7
        Label4.Text = "SINOPSE"
        ' 
        ' dataLanc
        ' 
        dataLanc.Location = New Point(12, 115)
        dataLanc.Name = "dataLanc"
        dataLanc.Size = New Size(384, 23)
        dataLanc.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 11
        Label5.Text = "FORNECEDOR"
        ' 
        ' cbFornec
        ' 
        cbFornec.FormattingEnabled = True
        cbFornec.Location = New Point(12, 159)
        cbFornec.Name = "cbFornec"
        cbFornec.Size = New Size(383, 23)
        cbFornec.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 229)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 15)
        Label6.TabIndex = 14
        Label6.Text = "VALOR DO ALUGUEL"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(11, 247)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(121, 23)
        txtValor.TabIndex = 5
        ' 
        ' capaFilme
        ' 
        capaFilme.BackgroundImage = CType(resources.GetObject("capaFilme.BackgroundImage"), Image)
        capaFilme.BackgroundImageLayout = ImageLayout.Stretch
        capaFilme.Location = New Point(402, 9)
        capaFilme.Name = "capaFilme"
        capaFilme.Size = New Size(274, 416)
        capaFilme.SizeMode = PictureBoxSizeMode.StretchImage
        capaFilme.TabIndex = 15
        capaFilme.TabStop = False
        ' 
        ' cbCateg
        ' 
        cbCateg.FormattingEnabled = True
        cbCateg.Location = New Point(11, 203)
        cbCateg.Name = "cbCateg"
        cbCateg.Size = New Size(383, 23)
        cbCateg.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 15)
        Label7.TabIndex = 16
        Label7.Text = "CATEGORIA"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), Image)
        btnCancelar.BackgroundImageLayout = ImageLayout.None
        btnCancelar.Location = New Point(561, 441)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(110, 41)
        btnCancelar.TabIndex = 9
        btnCancelar.Text = "CANCELAR"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), Image)
        btnLimpar.BackgroundImageLayout = ImageLayout.None
        btnLimpar.Location = New Point(286, 441)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(110, 41)
        btnLimpar.TabIndex = 8
        btnLimpar.Text = "LIMPAR"
        btnLimpar.TextAlign = ContentAlignment.MiddleRight
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.None
        btnSalvar.Location = New Point(10, 441)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(110, 41)
        btnSalvar.TabIndex = 7
        btnSalvar.Text = "SALVAR"
        btnSalvar.TextAlign = ContentAlignment.MiddleRight
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' dvgFilme
        ' 
        dvgFilme.AllowUserToAddRows = False
        dvgFilme.AllowUserToDeleteRows = False
        dvgFilme.AllowUserToResizeColumns = False
        dvgFilme.AllowUserToResizeRows = False
        dvgFilme.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dvgFilme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgFilme.Columns.AddRange(New DataGridViewColumn() {COD, DESC, VAL, EDIT, DEL})
        dvgFilme.Location = New Point(683, 35)
        dvgFilme.Name = "dvgFilme"
        dvgFilme.ReadOnly = True
        dvgFilme.RowHeadersWidth = 5
        dvgFilme.RowTemplate.Height = 25
        dvgFilme.Size = New Size(701, 447)
        dvgFilme.TabIndex = 17
        ' 
        ' COD
        ' 
        COD.HeaderText = "CÓDIGO"
        COD.Name = "COD"
        COD.ReadOnly = True
        COD.Width = 139
        ' 
        ' DESC
        ' 
        DESC.HeaderText = "DESCRIÇÃO"
        DESC.Name = "DESC"
        DESC.ReadOnly = True
        DESC.Width = 139
        ' 
        ' VAL
        ' 
        VAL.HeaderText = "VALOR"
        VAL.Name = "VAL"
        VAL.ReadOnly = True
        VAL.Width = 138
        ' 
        ' EDIT
        ' 
        EDIT.HeaderText = "EDITAR"
        EDIT.Image = CType(resources.GetObject("EDIT.Image"), Image)
        EDIT.Name = "EDIT"
        EDIT.ReadOnly = True
        EDIT.Width = 139
        ' 
        ' DEL
        ' 
        DEL.HeaderText = "DELETAR"
        DEL.Image = CType(resources.GetObject("DEL.Image"), Image)
        DEL.Name = "DEL"
        DEL.ReadOnly = True
        DEL.Width = 139
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(683, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 15)
        Label8.TabIndex = 19
        Label8.Text = "PESQUISAR FILME:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(794, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(383, 23)
        TextBox1.TabIndex = 18
        ' 
        ' txtCod
        ' 
        txtCod.Location = New Point(12, 27)
        txtCod.Name = "txtCod"
        txtCod.ReadOnly = True
        txtCod.Size = New Size(100, 23)
        txtCod.TabIndex = 20
        ' 
        ' cadFilme
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1396, 497)
        Controls.Add(txtCod)
        Controls.Add(Label8)
        Controls.Add(TextBox1)
        Controls.Add(dvgFilme)
        Controls.Add(btnCancelar)
        Controls.Add(btnLimpar)
        Controls.Add(btnSalvar)
        Controls.Add(cbCateg)
        Controls.Add(Label7)
        Controls.Add(capaFilme)
        Controls.Add(Label6)
        Controls.Add(txtValor)
        Controls.Add(cbFornec)
        Controls.Add(Label5)
        Controls.Add(dataLanc)
        Controls.Add(Label4)
        Controls.Add(txtSinopse)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtNome)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "cadFilme"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRO DE FILMES"
        CType(capaFilme, ComponentModel.ISupportInitialize).EndInit()
        CType(dvgFilme, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSinopse As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dataLanc As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFornec As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents capaFilme As PictureBox
    Friend WithEvents cbCateg As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dvgFilme As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents DESC As DataGridViewTextBoxColumn
    Friend WithEvents VAL As DataGridViewTextBoxColumn
    Friend WithEvents EDIT As DataGridViewImageColumn
    Friend WithEvents DEL As DataGridViewImageColumn
    Friend WithEvents txtCod As TextBox
End Class
