Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports System.Data.SqlClient
Public Class cadFilme

    Private Sub Limpar()
        txtNome.Text = ""
        txtValor.Text = ""
        txtSinopse.Text = ""
        diretorio = ""
        capaFilme.Load(AppDomain.CurrentDomain.BaseDirectory.Replace("\net6.0-windows\", "\capas\capa_padrao.jpg"))
        txtNome.Focus()
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            If diretorio = "" Then
                MsgBox("ERRO | Registro não foi processado no banco! Verifique os dados digitados.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                Exit Sub
            End If

            SQL = $"INSERT INTO tbFilmes 
                (
                nome,
                lancamento,
                codFornec,
                codCateg,
                valor,
                capa,
                sinopse
                )
                VALUES
                (
                '{txtNome.Text}', 
                '{dataLanc.Value.Date}', 
                {cbFornec.SelectedValue}, 
                {cbCateg.SelectedValue}, 
                {txtValor.Text}, 
                '{diretorio}', 
                '{txtSinopse.Text}'
                )"
            rs = db.Execute(SQL)

            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")

            Limpar()
        Catch ex As Exception
            MsgBox("ERRO | Registro não foi processado no banco! Verifique os dados digitados.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try

    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        ' Verifica se a tecla pressionada é um número, o ponto decimal ou a tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            ' Se não for um número, ponto decimal ou tecla Backspace, ignora a tecla pressionada
            e.Handled = True
        End If

        ' Verifica se já existe um ponto decimal na TextBox
        If e.KeyChar = "." AndAlso txtValor.Text.Contains(".") Then
            ' Se já existe um ponto, ignora o ponto pressionado
            e.Handled = True
        End If

        ' Verifica o número de casas decimais após o ponto
        If txtValor.Text.Contains(".") AndAlso txtValor.Text.Substring(txtValor.Text.IndexOf(".") + 1).Length >= 2 Then
            ' Permite apenas duas casas decimais após o ponto
            e.Handled = True
        End If
    End Sub

    Private Sub capaFilme_Click(sender As Object, e As EventArgs) Handles capaFilme.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma imagem:"
                .InitialDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\debug\", "\capas\")
                .ShowDialog()
                diretorio = .FileName
                capaFilme.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("ERRO | Erro ao carregar a imagem. Tente novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção.")
        End Try
    End Sub

    Private Sub cadFilme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Server = DESKTOP-J8VD9D7; Database = filmestar;Integrated Security = true;")
        Dim queryFornec As New SqlCommand("select * from tbFornec", con)
        Dim queryCateg As New SqlCommand("select * from tbCateg", con)

        Dim adapterF As New SqlDataAdapter(queryFornec)
        Dim adapterC As New SqlDataAdapter(queryCateg)
        Dim tabela, tabelaC As New DataTable()

        Try
            adapterF.Fill(tabela)

            cbFornec.DataSource = tabela

            cbFornec.DisplayMember = "nome"
            cbFornec.ValueMember = "ID"

            adapterC.Fill(tabelaC)

            cbCateg.DataSource = tabelaC

            cbCateg.DisplayMember = "descricao"
            cbCateg.ValueMember = "ID"


            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cadFilme_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Limpar()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class