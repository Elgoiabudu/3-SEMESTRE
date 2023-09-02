Public Class Form1
    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Try
            cadCli.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO | Erro no formulário de Cadastro de Clientes", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub
End Class
