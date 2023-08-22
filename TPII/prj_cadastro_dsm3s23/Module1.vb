Module Module1
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset

    Sub ConectarBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-12;Initial Catolog=cadastro_dsm3s;trusted_connection=yes;")
            MsgBox("Conexão Show!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        Catch ex As Exception
            MsgBox("Conexão Não Show!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

End Module
