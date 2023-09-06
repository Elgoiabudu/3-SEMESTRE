Public Class Form1
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim nome = txtNome.Text
        Dim cargo = cbCargo.SelectedItem
        Dim admissao = dataAdm.Value.Date
        Dim bruto = txtSalBruto.Text
        Dim INSS = txtINSS.Text
        Dim liquido = txtSalLiq.Text
        Try
            SQL = $"INSERT INTO Tb_Funcionario (nome, cargo, caminhoFoto, dataAdmissao, salarioBruto, salarioLiquido, INSS) values
            ('{nome}','{cargo}','{diretorio}','{admissao}',{bruto},{liquido})"
            rs = db.Execute(SQL)
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi processado no banco!")
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

    Private Sub txtQtdSal_LostFocus(sender As Object, e As EventArgs) Handles txtQtdSal.LostFocus
        txtSalBruto.Text = txtQtdSal.Text * 1320
        If txtSalBruto.Text >= 1630 Then
            txtINSS.Text = txtSalBruto.Text * 0.11
            txtSalLiq.Text = txtSalBruto.Text - txtINSS.Text
        Else
            txtINSS.Text = "0"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarTipo()
    End Sub
End Class
