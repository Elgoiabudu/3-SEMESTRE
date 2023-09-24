<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadCateg
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(cadCateg))
        btnCancelar = New Button()
        btnLimpar = New Button()
        btnSalvar = New Button()
        txtDescCateg = New TextBox()
        Label1 = New Label()
        LBLCATEG = New Label()
        txtCod = New TextBox()
        dgvCateg = New DataGridView()
        cod = New DataGridViewTextBoxColumn()
        DES = New DataGridViewTextBoxColumn()
        EDITAR = New DataGridViewImageColumn()
        EXCLUIR = New DataGridViewImageColumn()
        CType(dgvCateg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), Image)
        btnCancelar.BackgroundImageLayout = ImageLayout.None
        btnCancelar.Location = New Point(322, 112)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(110, 41)
        btnCancelar.TabIndex = 34
        btnCancelar.Text = "CANCELAR"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), Image)
        btnLimpar.BackgroundImageLayout = ImageLayout.None
        btnLimpar.Location = New Point(173, 112)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(110, 41)
        btnLimpar.TabIndex = 33
        btnLimpar.Text = "LIMPAR"
        btnLimpar.TextAlign = ContentAlignment.MiddleRight
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.None
        btnSalvar.Location = New Point(12, 112)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(110, 41)
        btnSalvar.TabIndex = 32
        btnSalvar.Text = "SALVAR"
        btnSalvar.TextAlign = ContentAlignment.MiddleRight
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' txtDescCateg
        ' 
        txtDescCateg.Location = New Point(12, 73)
        txtDescCateg.Name = "txtDescCateg"
        txtDescCateg.Size = New Size(420, 23)
        txtDescCateg.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 14
        Label1.Text = "DESCRIÇÃO"
        ' 
        ' LBLCATEG
        ' 
        LBLCATEG.AutoSize = True
        LBLCATEG.Location = New Point(12, 9)
        LBLCATEG.Name = "LBLCATEG"
        LBLCATEG.Size = New Size(52, 15)
        LBLCATEG.TabIndex = 36
        LBLCATEG.Text = "CÓDIGO"
        ' 
        ' txtCod
        ' 
        txtCod.Enabled = False
        txtCod.Location = New Point(12, 27)
        txtCod.Name = "txtCod"
        txtCod.Size = New Size(137, 23)
        txtCod.TabIndex = 35
        ' 
        ' dgvCateg
        ' 
        dgvCateg.AllowUserToAddRows = False
        dgvCateg.AllowUserToDeleteRows = False
        dgvCateg.AllowUserToResizeColumns = False
        dgvCateg.AllowUserToResizeRows = False
        dgvCateg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCateg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCateg.Columns.AddRange(New DataGridViewColumn() {cod, DES, EDITAR, EXCLUIR})
        dgvCateg.Location = New Point(12, 159)
        dgvCateg.Name = "dgvCateg"
        dgvCateg.ReadOnly = True
        dgvCateg.RowHeadersWidth = 5
        dgvCateg.RowTemplate.Height = 25
        dgvCateg.Size = New Size(420, 218)
        dgvCateg.TabIndex = 37
        ' 
        ' cod
        ' 
        cod.HeaderText = "CÓDIGO"
        cod.Name = "cod"
        cod.ReadOnly = True
        ' 
        ' DES
        ' 
        DES.HeaderText = "NOME"
        DES.Name = "DES"
        DES.ReadOnly = True
        ' 
        ' EDITAR
        ' 
        EDITAR.HeaderText = "EDITAR"
        EDITAR.Image = CType(resources.GetObject("EDITAR.Image"), Image)
        EDITAR.Name = "EDITAR"
        EDITAR.ReadOnly = True
        EDITAR.Resizable = DataGridViewTriState.True
        EDITAR.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' EXCLUIR
        ' 
        EXCLUIR.HeaderText = "EXCLUIR"
        EXCLUIR.Image = CType(resources.GetObject("EXCLUIR.Image"), Image)
        EXCLUIR.Name = "EXCLUIR"
        EXCLUIR.ReadOnly = True
        EXCLUIR.Resizable = DataGridViewTriState.True
        EXCLUIR.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' cadCateg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 389)
        Controls.Add(dgvCateg)
        Controls.Add(LBLCATEG)
        Controls.Add(txtCod)
        Controls.Add(btnCancelar)
        Controls.Add(btnLimpar)
        Controls.Add(btnSalvar)
        Controls.Add(Label1)
        Controls.Add(txtDescCateg)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(455, 428)
        MinimizeBox = False
        MinimumSize = New Size(455, 428)
        Name = "cadCateg"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CADASTRO DE CATEGORIAS"
        CType(dgvCateg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtDescCateg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLCATEG As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents dgvCateg As DataGridView
    Friend WithEvents cod As DataGridViewTextBoxColumn
    Friend WithEvents DES As DataGridViewTextBoxColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
End Class
