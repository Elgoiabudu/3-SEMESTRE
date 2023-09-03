Public Class cadCateg
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        Try
            SQL = "SELECT * FROM tbCateg where descricao='" & txtDescCateg.Text & "'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then
                SQL = "INSERT INTO tbCateg values ('" & txtDescCateg.Text & "')"
                rs = db.Execute(SQL)
                MsgBox("Categoria cadastrada com sucesso.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                txtDescCateg.Clear()
            Else
                MsgBox("ERRO | Categoria já cadastrada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi salvo no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtDescCateg.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtDescCateg.Clear()
        Me.Close()
    End Sub
End Class