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
        Label1 = New Label()
        txtDescCateg = New TextBox()
        btnCancelar = New Button()
        btnLimpar = New Button()
        btnSalvar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 14
        Label1.Text = "DESCRIÇÃO"
        ' 
        ' txtDescCateg
        ' 
        txtDescCateg.Location = New Point(12, 27)
        txtDescCateg.Name = "txtDescCateg"
        txtDescCateg.Size = New Size(342, 23)
        txtDescCateg.TabIndex = 13
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), Image)
        btnCancelar.BackgroundImageLayout = ImageLayout.None
        btnCancelar.Location = New Point(244, 66)
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
        btnLimpar.Location = New Point(128, 66)
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
        btnSalvar.Location = New Point(12, 66)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(110, 41)
        btnSalvar.TabIndex = 32
        btnSalvar.Text = "SALVAR"
        btnSalvar.TextAlign = ContentAlignment.MiddleRight
        btnSalvar.UseVisualStyleBackColor = True
        ' 
        ' cadCateg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 123)
        Controls.Add(btnCancelar)
        Controls.Add(btnLimpar)
        Controls.Add(btnSalvar)
        Controls.Add(Label1)
        Controls.Add(txtDescCateg)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "cadCateg"
        Text = "CADASTRO DE CATEGORIAS"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescCateg As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSalvar As Button
End Class
