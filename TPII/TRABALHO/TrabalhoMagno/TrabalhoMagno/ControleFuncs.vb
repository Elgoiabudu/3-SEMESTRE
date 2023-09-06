Module ControleFuncs
    Public diretorio, SQL As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer
    Sub CarregarDados()
        Try
            SQL = "SELECT * FROM Tb_Funcionario order by nome asc"
            rs = db.Execute(SQL)

            With Form1.dgvFunc
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False

                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub CarregarTipo()
        Try
            With Form1.cbCargo.Items
                .Add("DESENVOLVEDOR JUNIOR")
                .Add("DESENVOLVEDOR SENIOR")
                .Add("DESENVOLVEDOR PLENO")
                .Add("GERENTE")
                .Add("DIRETOR")
                .Add("ESTAGIARIO")
                .Add("PRESIDENTE")
                .Add("SUPERVISOR")
            End With
            Form1.cbCargo.SelectedItem = 1
        Catch ex As Exception

        End Try
    End Sub

End Module
