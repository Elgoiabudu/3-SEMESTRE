Public Class cadFornec

    Sub LimparTela()
        txtCNPJ.Clear()
        txtCidadeFornec.Clear()
        txtCodFornec.Clear()
        txtEmailFornec.Clear()
        txtEnderecoFornec.Clear()
        txtEstadoFornec.Clear()
        txtFoneFornec.Clear()
        txtNomeFornec.Clear()
    End Sub
    Private Sub btnSalvarFornec_Click(sender As Object, e As EventArgs) Handles btnSalvarFornec.Click

        Try
            SQL = "SELECT * FROM tbFornec WHERE CNPJ='" & txtCNPJ.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = "INSERT INTO tbFornec (nome, email, CNPJ, telefone, endereco, cidade, estado, situacao)
                   VALUES
                   ('" & txtNomeFornec.Text & "', '" & txtEmailFornec.Text & "',
                   '" & txtCNPJ.Text & "', '" & txtFoneFornec.Text & "', '" & txtEnderecoFornec.Text & "', '" & txtCidadeFornec.Text & "',
                   '" & txtEstadoFornec.Text & "', 'Ativo')"
                rs = db.Execute(SQL)
                MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparTela()
            Else
                MsgBox("Fornecedor já cadastrado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("ERRO | Impossível realizar a operação.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Private Sub btnLimparFornec_Click(sender As Object, e As EventArgs) Handles btnLimparFornec.Click
        LimparTela()
    End Sub

    Private Sub btnCancelarFornec_Click(sender As Object, e As EventArgs) Handles btnCancelarFornec.Click
        Me.Close()
    End Sub
End Class