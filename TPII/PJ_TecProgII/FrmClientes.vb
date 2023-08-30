Public Class FrmClientes
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ImgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                '.InitialDirectory = Application.StartupPath & "\Fotos\"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\")
                .ShowDialog()
                diretorio = .FileName
                ImgFoto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarDados()
        CarregarTipo()
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles BtnGravar.Click
        Try
            SQL = "SELECT * FROM tb_usuario WHERE cpf = '" & TxtCPF.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                SQL = "INSERT INTO tb_usuario (cpf, nome, foto) VALUES ('" & TxtCPF.Text & "', " &
                      "'" & TxtNome.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                TxtCPF.Clear()
                TxtNome.Clear()
                ImgFoto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\NovaFoto.png"))
                TxtCPF.Focus()
                CarregarDados()
            Else
                MsgBox("ERRO | CPF já cadastrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi salvo no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub TxtCPF_LostFocus(sender As Object, e As EventArgs) Handles TxtCPF.LostFocus
        Try
            SQL = "SELECT * FROM tb_usuario WHERE cpf = '" & TxtCPF.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                TxtNome.Text = rs.Fields(2).Value
                ImgFoto.Load(rs.Fields(3).Value)
            Else
                TxtNome.Focus()
            End If
        Catch ex As Exception
            MsgBox("ERRO | Consulta ao CPF no banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "SELECT * FROM tb_usuario WHERE " & cmb_tipo.Text & " LIKE '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)

            With dgv_dados
                cont = 1
                .Rows.Clear()

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Usuário não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try

            With dgv_dados

                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_usuario WHERE cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Focando na aba dados pessoais
                        TxtCPF.Text = rs.Fields(1).Value
                        TxtNome.Text = rs.Fields(2).Value
                        ImgFoto.Load(rs.Fields(3).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "SELECT * FROM tb_usuario where cpf = '" & aux_cpf & "'"
                    rs = db.Execute(SQL)

                    If rs.EOF = False Then
                        resp = MsgBox("Deseja realmente excluir o CPF " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                        If resp = MsgBoxResult.Yes Then
                            SQL = "DELETE FROM tb_usuario WHERE cpf='" & aux_cpf & "'"
                            rs = db.Execute(SQL)
                            TxtCPF.Clear()
                            TxtNome.Clear()
                            ImgFoto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Fotos\NovaFoto.png"))
                            CarregarDados()
                        End If
                    End If
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub
End Class