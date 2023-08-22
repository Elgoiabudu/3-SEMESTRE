Public Class frm_clientes
    Private Sub ImgFoto_Click(sender As Object, e As EventArgs) Handles imgFoto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                imgFoto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
    End Sub

    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try

            'SQL = "select * from tb_cadastro where cpf='" & txtCPF.Text & "'"
            SQL = "select * from tb_cadastro"
            rs = db.Execute(SQL)

            'If rs.EOF = True Then 'Se não conter o CPF na tabela'
            'SQL = "insert into tb_cadastro (cpf, nome, foto) values 
            '           ('" & txtCPF.Text & "','" & txtNome.Text & "','" & diretorio & "')"
            'End If
        Catch ex As Exception

        End Try
    End Sub
End Class