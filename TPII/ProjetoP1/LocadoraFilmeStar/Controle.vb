Module Controle
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer

    Sub CarregarDados()

    End Sub

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-J8VD9D7;Initial Catalog=filmeStar;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("ERRO | Impossível se conectar ao banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub CarregarClientes()

        Try
            SQL = "SELECT * FROM tbClientes"
            rs = db.Execute(SQL)
        Catch ex As Exception
            MsgBox("ERRO | Impossível carregar os dados da planilha.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
