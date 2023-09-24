Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class cadFilme
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        SQL = $"INSERT INTO tbFilmes 
                (nome,
                lancamento,
                codFornec,
                codCateg,
                valor,
                capa,
                sinopse)
                VALUES
                ({txtNome.Text}, 
                {dataLanc.Value.Date}, 
                {cbFornec.Text}, 
                {cbCateg.Text}, 
                {txtValor.Text}, 
                {diretorio}, 
                {txtSinopse.Text})"

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
        SQL = "SELECT ID, nome FROM tbFornec"
        rs = db.Execute(SQL)

        Dim lista As New List(Of String)()

        cont = 0

        Do While rs.EOF = True
            lista.Add("a")
            rs.MoveNext()
        Loop

        cbFornec.DataSource = lista

    End Sub
End Class