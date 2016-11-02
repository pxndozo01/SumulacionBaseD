Public Class Form3

    Private Sub msiRegresar_Click(sender As Object, e As EventArgs) Handles msiRegresar.Click
        Me.Close()
    End Sub

    Private Sub msiAlta_Click(sender As Object, e As EventArgs) Handles msiAlta.Click
        Form4.ShowDialog()
    End Sub
End Class