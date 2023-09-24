Imports System.Diagnostics.Eventing.Reader

Public Class cadFornec

    Sub PopularDvgFornec()
        Try
            SQL = $"SELECT * FROM tbFornec order by nome"
            rs = db.Execute(SQL)

            With dgvFornec
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub LimparTela()
        txtCNPJ.Clear()
        txtCidadeFornec.Clear()
        txtCodFornec.Clear()
        txtEmailFornec.Clear()
        txtEnderecoFornec.Clear()
        txtEstadoFornec.Clear()
        txtFoneFornec.Clear()
        txtNomeFornec.Clear()
        cbSit.SelectedIndex = 0
    End Sub
    Private Sub btnSalvarFornec_Click(sender As Object, e As EventArgs) Handles btnSalvarFornec.Click

        Dim auxID = txtCodFornec.Text

        Try
            If txtCodFornec.Text = "" Then

                SQL = "SELECT * FROM tbFornec WHERE CNPJ='" & txtCNPJ.Text & "'"
                rs = db.Execute(SQL)

                If rs.EOF = True Then
                    SQL = "INSERT INTO tbFornec (nome, email, CNPJ, telefone, endereco, cidade, estado, situacao)
                   VALUES
                   ('" & txtNomeFornec.Text & "', '" & txtEmailFornec.Text & "',
                   '" & txtCNPJ.Text & "', '" & txtFoneFornec.Text & "', '" & txtEnderecoFornec.Text & "', '" & txtCidadeFornec.Text & "',
                   '" & txtEstadoFornec.Text & "', 'ATIVO')"
                    rs = db.Execute(SQL)
                    MsgBox("Fornecedor cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    LimparTela()
                    PopularDvgFornec()
                Else
                    MsgBox("Fornecedor já cadastrado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    auxID = ""
                End If

            Else
                SQL = $"UPDATE tbFornec SET
                      nome = '{txtNomeFornec.Text}',
                      email = '{txtEmailFornec.Text}',
                      CNPJ = '{txtCNPJ.Text}',
                      telefone = '{txtFoneFornec.Text}',
                      endereco = '{txtEnderecoFornec.Text}',
                      cidade = '{txtCidadeFornec.Text}',
                      estado = '{txtEstadoFornec.Text}',
                      situacao = '{cbSit.Text}'
                      where
                      ID = {auxID}"
                rs = db.Execute(SQL)
                MsgBox("Fornecedor atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                LimparTela()
                PopularDvgFornec()
            End If
        Catch ex As Exception
            MsgBox("ERRO | Impossível realizar a operação.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try


    End Sub

    Private Sub btnLimparFornec_Click(sender As Object, e As EventArgs) Handles btnLimparFornec.Click
        LimparTela()
    End Sub

    Private Sub btnCancelarFornec_Click(sender As Object, e As EventArgs) Handles btnCancelarFornec.Click
        LimparTela()
        Me.Close()
    End Sub

    Private Sub cadFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularDvgFornec()
    End Sub

    Private Sub dgvFornec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFornec.CellContentClick
        Try
            With dgvFornec

                Dim auxId = .CurrentRow.Cells(0).Value

                If .CurrentRow.Cells(2).Selected Then
                    SQL = $"select * from tbFornec where ID = {auxId}"
                    rs = db.Execute(SQL)

                    txtCodFornec.Text = rs.Fields(0).Value
                    txtNomeFornec.Text = rs.Fields(1).Value
                    txtEmailFornec.Text = rs.Fields(2).Value
                    txtCNPJ.Text = rs.Fields(3).Value
                    txtFoneFornec.Text = rs.Fields(4).Value
                    txtEnderecoFornec.Text = rs.Fields(5).Value
                    txtCidadeFornec.Text = rs.Fields(6).Value
                    txtEstadoFornec.Text = rs.Fields(7).Value

                    If rs.Fields(8).Value = "ATIVO" Then
                        cbSit.SelectedIndex = 0
                    Else
                        cbSit.SelectedIndex = 1
                    End If

                End If

                If .CurrentRow.Cells(3).Selected Then

                    auxId = .CurrentRow.Cells(0).Value

                    Dim resp = MsgBox($"Deseja excluir o fornecedor { .CurrentRow.Cells(1).Value}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")

                    If resp = MsgBoxResult.Yes Then
                        SQL = $"delete from tbFornec where ID = {auxId}"
                        rs = db.Execute(SQL)
                        LimparTela()
                        MsgBox("Fornecedor excluido com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        PopularDvgFornec()

                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPesq_TextChanged(sender As Object, e As EventArgs) Handles txtPesq.TextChanged
        Try
            SQL = $"select * from tbFornec where nome like '{txtPesq.Text}%'"
            rs = db.Execute(SQL)

            With dgvFornec
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class