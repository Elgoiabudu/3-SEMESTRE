Public Class pesqCli
    Private Sub pesqCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularDgvClientes()
    End Sub

    Private Sub LimparTudo()
        txtCod.Text = ""
        txtNome.Text = ""
        txtSobrenome.Text = ""
        mkRG.Text = ""
        mkCPF.Text = ""
        txtEmail.Text = ""
        mkFixo.Text = ""
        mkCel.Text = ""
        txtEndereco.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        mkCEP.Text = ""
        foto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\net6.0-windows\", "\Fotos\avatar.png"))
    End Sub

    Private Sub dgvCli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCli.CellContentClick
        Try
            With dgvCli
                If .CurrentRow.Cells(12).Selected Then
                    aux_cpf = .CurrentRow.Cells(4).Value
                    SQL = $"select * from tbClientes where CPF = '{aux_cpf}'"
                    rs = db.Execute(SQL)

                    txtCod.Text = rs.Fields(0).Value
                    txtNome.Text = rs.Fields(1).Value
                    txtSobrenome.Text = rs.Fields(2).Value
                    mkRG.Text = rs.Fields(5).Value
                    mkCPF.Text = rs.Fields(4).Value
                    txtEmail.Text = rs.Fields(3).Value
                    mkFixo.Text = rs.Fields(7).Value
                    mkCel.Text = rs.Fields(6).Value
                    txtEndereco.Text = rs.Fields(8).Value
                    txtCidade.Text = rs.Fields(9).Value
                    txtEstado.Text = rs.Fields(10).Value
                    mkCEP.Text = rs.Fields(11).Value
                    foto.Load(rs.Fields(13).Value)
                    diretorio = rs.Fields(13).Value

                End If

                If .CurrentRow.Cells(13).Selected Then
                    aux_cpf = .CurrentRow.Cells(4).Value

                    SQL = $"select * from tbClientes where CPF = '{aux_cpf}'"
                    rs = db.Execute(SQL)


                    If rs.EOF = False Then
                        Dim resp = MsgBox($"Deseja excluir {rs.Fields(1).Value} " + $"{rs.Fields(2).Value} da base de dados?",
                                          MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO!")
                        If resp = MsgBoxResult.Yes Then
                            'MsgBox($"{rs.Fields(4).Value}")
                            SQL = $"delete from tbClientes where CPF='{aux_cpf}'"
                            rs = db.Execute(SQL)
                            LimparTudo()
                            PopularDgvClientes()
                        End If
                    End If
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            SQL = $"UPDATE tbClientes SET
                nome = '{txtNome.Text}',
                sobrenome = '{txtSobrenome.Text}',
                email = '{txtEmail.Text}',
                cpf = '{mkCPF.Text}',
                rg = '{mkRG.Text}',
                telefoneCel = '{mkCel.Text}',
                telefoneFixo = '{mkFixo.Text}',
                endereco = '{txtEndereco.Text}',
                cidade = '{txtCidade.Text}',
                estado = '{txtEstado.Text}',
                cep = '{mkCEP.Text}',
                foto = '{diretorio}'
                WHERE
                cpf = '{aux_cpf}'"
            rs = db.Execute(SQL)

            LimparTudo()
            PopularDgvClientes()

        Catch ex As Exception
            MsgBox($"ERRO | Os dados não foram atualizados. Verique os dados digitados. ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO!")
        End Try


    End Sub

    Private Sub foto_Click(sender As Object, e As EventArgs) Handles foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto:"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                foto.Load(diretorio)
            End With
        Catch ex As Exception
            diretorio = ""
        End Try
    End Sub

    Private Sub txtPesq_TextChanged(sender As Object, e As EventArgs) Handles txtPesq.TextChanged

        Try
            SQL = $"SELECT * FROM tbClientes WHERE nome LIKE '{txtPesq.Text}%'"
            rs = db.Execute(SQL)

            With dgvCli
                cont = 1
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value,
                            rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value,
                            rs.Fields(11).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception

        End Try

    End Sub
End Class