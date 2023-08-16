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
        conectarBanco()
    End Sub
End Class