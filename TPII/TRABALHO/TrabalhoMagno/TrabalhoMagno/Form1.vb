Public Class Form1

    Private Sub Limpar()
        txtCpf.Text = ""
        txtNome.Text = ""
        txtQtdSal.Text = ""
        txtQtdSal.Text = ""
        txtSalBruto.Text = ""
        txtSalLiq.Text = ""
        txtINSS.Text = ""
        dataAdm.Value = Now()
        foto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\net6.0-windows\", "\FOTOS\new_user.jpg"))
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            SQL = $"SELECT * FROM Tb_Funcionario WHERE CPF='{txtCpf.Text}'"
            rs = db.Execute(SQL)
            aux_id = rs.Fields(0).Value
            If rs.EOF = True Then

                SQL = $"INSERT INTO Tb_Funcionario (nome, cargo, caminhoFoto, CPF, dataAdmissao, salarioBruto, salarioLiquido, INSS)
                    VALUES
                    ('{txtNome.Text}', '{cbCargo.SelectedItem}', '{diretorio}', '{txtCpf.Text}', '{dataAdm.Value.Date}', {txtSalBruto.Text}, {txtSalLiq.Text}, {txtINSS.Text});"
                rs = db.Execute(SQL)
                MsgBox("DADOS GRAVADOS COM SUCESSO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                Limpar()

            Else

                SQL = $"UPDATE Tb_Funcionario SET
                        nome='{txtNome.Text}',
                        cargo ='{cbCargo.SelectedItem}',
                        caminhoFoto='{diretorio}',
                        dataAdmissao='{dataAdm.Value.Date}',
                        salarioBruto='{txtSalBruto.Text}',
                        salarioLiquido='{txtSalLiq.Text}',
                        INSS='{txtINSS.Text}',
                        CPF='{txtCpf.Text}'
                        WHERE
                        id={aux_id}"
                rs = db.Execute(SQL)
                MsgBox("DADOS ALTERADOS COM SUCESSO!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                Limpar()

            End If

        Catch ex As Exception
            MsgBox("ERRO | Registro não foi processado no banco! Verifique os dados digitados.")
        End Try

    End Sub

    Private Sub foto_Click(sender As Object, e As EventArgs) Handles foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\FOTOS\")
                .ShowDialog()
                diretorio = .FileName
                foto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQtdSal_KeyPress(sender As Object, e As EventArgs) Handles txtQtdSal.LostFocus
        'preenchendo o salario bruto, inss e salario liquido
        Try
            Dim bruto = txtQtdSal.Text * 1320
            Dim INSS = bruto * 0.11
            Dim liquido = bruto - INSS
            If bruto >= 1630 Then
                txtSalBruto.Text = Replace(bruto, ",", ".")
                txtINSS.Text = Replace(INSS, ",", ".")
                txtSalLiq.Text = Replace(liquido, ",", ".")
            Else
                txtSalBruto.Text = Replace(bruto, ",", ".")
                txtINSS.Text = 0
                txtSalLiq.Text = Replace(bruto, ",", ".")
            End If

        Catch ex As Exception
            MsgBox("ERRO | Informe uma quantidade de salários válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            txtSalBruto.Text = ""
            txtINSS.Text = ""
            txtSalLiq.Text = ""
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        CarregarTipo()
    End Sub

    Private Sub txtQtdSal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdSal.KeyPress
        'Apenas números e vírgula
        If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And e.KeyChar <> "," Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtCpf_LostFocus(sender As Object, e As EventArgs) Handles txtCpf.LostFocus
        Try
            SQL = $"SELECT * FROM Tb_Funcionario WHERE CPF='{txtCpf.Text}'"
            rs = db.Execute(SQL)

            Dim qtdSal = rs.Fields(6).Value / 1320

            aux_id = rs.Fields(0).Value
            txtNome.Text = rs.Fields(1).Value
            cbCargo.Text = rs.Fields(2).Value
            foto.Load(rs.Fields(3).Value)
            diretorio = rs.Fields(3).Value
            dataAdm.Value = rs.Fields(5).Value
            txtQtdSal.Text = qtdSal
            txtSalBruto.Text = Replace(rs.Fields(6).Value, ",", ".")
            txtSalLiq.Text = Replace(rs.Fields(7).Value, ",", ".")
            txtINSS.Text = Replace(rs.Fields(8).Value, ",", ".")


        Catch ex As Exception

            txtNome.Text = ""
            txtQtdSal.Text = ""
            txtQtdSal.Text = ""
            txtSalBruto.Text = ""
            txtSalLiq.Text = ""
            txtINSS.Text = ""
            dataAdm.Value = Now()
            foto.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\net6.0-windows\", "\FOTOS\new_user.jpg"))
            diretorio = ""

        End Try

    End Sub
End Class
