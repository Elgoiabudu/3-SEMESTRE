Public Class Form1
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Try
            cadCli.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO | Erro no formulário de Cadastro de Clientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Try
            cadFornec.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO | Erro no formulário de Cadastro de Fornecedores.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Try
            cadCateg.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO | Erro no formulário de Cadastro de Categorias.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarClientes()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Try
            pesqCli.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO | Erro no formulário de pesquisa de clientes.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub
End Class
