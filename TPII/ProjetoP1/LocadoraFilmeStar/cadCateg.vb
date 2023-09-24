Public Class cadCateg
    Private Sub PopularDvgCateg()

        Try
            SQL = "SELECT * FROM tbCateg order by descricao"
            rs = db.Execute(SQL)

            With dgvCateg

                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim cod = txtCod.Text

        Try

            If txtCod.Text = "" Then
                SQL = "SELECT * FROM tbCateg where descricao='" & txtDescCateg.Text & "'"
                rs = db.Execute(SQL)
                Dim auxID = rs.Fields(0).Value

                If rs.EOF = True Then
                    SQL = "INSERT INTO tbCateg values ('" & txtDescCateg.Text & "')"
                    rs = db.Execute(SQL)
                    MsgBox("Categoria cadastrada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txtDescCateg.Text = ""
                    PopularDvgCateg()
                Else
                    MsgBox("Categoria já cadastrada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End If
            Else
                SQL = $"update tbCateg set descricao = '{txtDescCateg.Text}' where ID = {cod}"
                rs = db.Execute(SQL)
                MsgBox("Categoria atualizada com sucesso.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txtCod.Text = ""
                txtDescCateg.Text = ""
                txtDescCateg.Focus()
                PopularDvgCateg()
            End If

        Catch ex As Exception
            MsgBox("ERRO | Registro não foi salvo no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtCod.Clear()
        txtDescCateg.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCod.Clear()
        txtDescCateg.Clear()
        Me.Close()
    End Sub

    Private Sub cadCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularDvgCateg()
    End Sub

    Private Sub dgvCateg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCateg.CellContentClick
        Try
            With dgvCateg
                Dim auxId = .CurrentRow.Cells(0).Value

                If .CurrentRow.Cells(2).Selected Then
                    txtCod.Text = auxId
                    txtDescCateg.Text = .CurrentRow.Cells(1).Value
                End If

                If .CurrentRow.Cells(3).Selected Then

                    Dim resp = MsgBox($"Deseja excluir a categoria { .CurrentRow.Cells(1).Value}?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")

                    If resp = MsgBoxResult.Yes Then
                        SQL = $"delete from tbCateg where ID = { .CurrentRow.Cells(0).Value}"
                        rs = db.Execute(SQL)
                        txtCod.Clear()
                        txtDescCateg.Clear()
                        MsgBox("Categoria excluida com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                        PopularDvgCateg()
                    End If
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class