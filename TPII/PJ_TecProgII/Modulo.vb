Module Modulo
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer


    Sub CarregarDados()
        Try
            SQL = "Select * from tb_usuario order by nome asc"
            rs = db.Execute(SQL)

            With FrmClientes.dgv_dados

                cont = 0

                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont += 1
                Loop

            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-13;Initial Catalog=CadastroTecProgII;trusted_connection=yes;")
            MsgBox("Conexão magna!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO | Conexão ao Banco não efetuada!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
