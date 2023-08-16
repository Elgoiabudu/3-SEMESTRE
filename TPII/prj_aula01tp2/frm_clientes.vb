Public Class frm_clientes
    Private Sub frm_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim diretorio As String 'Variavel local'

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class