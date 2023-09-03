<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadCli
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(cadCli))
        txtNome = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtSobrenome = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtCod = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label5 = New Label()
        txtRG = New TextBox()
        Label6 = New Label()
        txtCPF = New TextBox()
        Label7 = New Label()
        txtFixo = New TextBox()
        Label8 = New Label()
        txtCelular = New TextBox()
        Label9 = New Label()
        txtEndereco = New TextBox()
        Label10 = New Label()
        txtCidade = New TextBox()
        Label11 = New Label()
        txtEstado = New TextBox()
        Label12 = New Label()
        txtCEP = New TextBox()
        btnSalvar = New Button()
        btnLimpar = New Button()
        btnCancelar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(12, 71)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(144, 23)
        txtNome.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 1
        Label1.Text = "NOME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 3
        Label2.Text = "SOBRENOME"
        ' 
        ' txtSobrenome
        ' 
        txtSobrenome.Location = New Point(176, 71)
        txtSobrenome.Name = "txtSobrenome"
        txtSobrenome.Size = New Size(144, 23)
        txtSobrenome.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(326, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 129)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 10
        Label3.Text = "CÓD. CLIENTE"
        ' 
        ' txtCod
        ' 
        txtCod.Enabled = False
        txtCod.Location = New Point(12, 27)
        txtCod.Name = "txtCod"
        txtCod.Size = New Size(144, 23)
        txtCod.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 12
        Label4.Text = "E-MAIL"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(12, 159)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(414, 23)
        txtEmail.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 15)
        Label5.TabIndex = 14
        Label5.Text = "RG"
        ' 
        ' txtRG
        ' 
        txtRG.Location = New Point(12, 115)
        txtRG.Name = "txtRG"
        txtRG.Size = New Size(144, 23)
        txtRG.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(176, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 16
        Label6.Text = "CPF"
        ' 
        ' txtCPF
        ' 
        txtCPF.Location = New Point(176, 115)
        txtCPF.Name = "txtCPF"
        txtCPF.Size = New Size(144, 23)
        txtCPF.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 18
        Label7.Text = "TELEFONE FIXO"
        ' 
        ' txtFixo
        ' 
        txtFixo.Location = New Point(12, 203)
        txtFixo.Name = "txtFixo"
        txtFixo.Size = New Size(144, 23)
        txtFixo.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(176, 185)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 15)
        Label8.TabIndex = 20
        Label8.Text = "TELEFONE CELULAR"
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(176, 203)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(144, 23)
        txtCelular.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 229)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 15)
        Label9.TabIndex = 22
        Label9.Text = "ENDEREÇO"
        ' 
        ' txtEndereco
        ' 
        txtEndereco.Location = New Point(12, 247)
        txtEndereco.Name = "txtEndereco"
        txtEndereco.Size = New Size(241, 23)
        txtEndereco.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(261, 229)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 15)
        Label10.TabIndex = 24
        Label10.Text = "CIDADE"
        ' 
        ' txtCidade
        ' 
        txtCidade.Location = New Point(261, 247)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(165, 23)
        txtCidade.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 273)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 15)
        Label11.TabIndex = 26
        Label11.Text = "ESTADO"
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(12, 291)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(144, 23)
        txtEstado.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(176, 273)
        Label12.Name = "Label12"
        Label12.Size = New Size(28, 15)
        Label12.TabIndex = 28
        Label12.Text = "CEP"
        ' 
        ' txtCEP
        ' 
        txtCEP.Location = New Point(176, 291)
        txtCEP.Name = "txtCEP"
        txtCEP.Size = New Size(144, 23)
        txtCEP.TabIndex = 27
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackgroundImage = CType(resources.GetObject("btnSalvar.BackgroundImage"), Image)
        btnSalvar.BackgroundImageLayout = ImageLayout.None
        btnSalvar.Location = New Point(12, 320)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(110, 41)
        btnSalvar.TabIndex = 29
        btnSalvar.Text = "SALVAR"
        btnSalvar.TextAlign = ContentAlignment.MiddleRight
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackgroundImage = CType(resources.GetObject("btnLimpar.BackgroundImage"), Image)
        btnLimpar.BackgroundImageLayout = ImageLayout.None
        btnLimpar.Location = New Point(165, 320)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(110, 41)
        btnLimpar.TabIndex = 30
        btnLimpar.Text = "LIMPAR"
        btnLimpar.TextAlign = ContentAlignment.MiddleRight
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), Image)
        btnCancelar.BackgroundImageLayout = ImageLayout.None
        btnCancelar.Location = New Point(316, 320)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(110, 41)
        btnCancelar.TabIndex = 31
        btnCancelar.Text = "CANCELAR"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' cadCli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 372)
        Controls.Add(btnCancelar)
        Controls.Add(btnLimpar)
        Controls.Add(btnSalvar)
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
        Name = "cadCli"
        Text = "CADASTRO DE CLIENTES"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRG As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFixo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnCancelar As Button
End Class
