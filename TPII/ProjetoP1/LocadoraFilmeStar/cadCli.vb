Public Class cadCli
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        Try

            SQL = $"SELECT * FROM tbClientes WHERE cpf = '{maskCPF.Text}'"
            rs = db.Execute(SQL)

            If rs.EOF = True Then

                SQL = $"INSERT INTO tbClientes
                (nome,
                sobrenome,
                email,
                cpf,
                rg,
                telefoneCel,
                telefoneFixo,
                endereco,
                cidade,
                estado,
                cep,
                foto)
                VALUES
                ('{txtNome.Text}',
                '{txtSobrenome.Text}',
                '{txtEmail.Text}',
                '{maskCPF.Text}',
                '{maskRG.Text}',
                '{maskCel.Text}',
                '{maskFixo.Text}',
                '{txtEndereco.Text}',
                '{txtCidade.Text}',
                '{txtEstado.Text}',
                '{txtCEP.Text}',
                '{diretorio}')
                "
                rs = db.Execute(SQL)
                MsgBox("Cadastrado com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                Limpar()

            Else

                MsgBox("ERRO | Usuário já cadastrado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")

            End If

        Catch ex As Exception
            MsgBox("ERRO | Erro ao gravar o registro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto:"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                PictureBox1.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
End Class