Public Class frmPrincipal

    Private Sub smiSalir_Click(sender As Object, e As EventArgs) Handles smiSalir.Click
        If MessageBox.Show("¿Desea Finalizar La Ejecución Del Programa?", "FINALIZAR EJECUCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub smiAcerca_Click(sender As Object, e As EventArgs) Handles smiAcerca.Click
        'Dim AcercaDe As New Form2()
        'AcercaDe.MdiParent = Me
        'AcercaDe.Show()
        'Form2.MdiParent = Me
        Form2.ShowDialog()
    End Sub

    Private Sub smiProductos_Click(sender As Object, e As EventArgs) Handles smiProductos.Click
        Form3.ShowDialog()
    End Sub

    Private Sub smiCompras_Click(sender As Object, e As EventArgs) Handles smiCompras.Click
        Form5.ShowDialog()
    End Sub

    Private Sub smiVentas_Click(sender As Object, e As EventArgs) Handles smiVentas.Click
        Form7.ShowDialog()
    End Sub
End Class
