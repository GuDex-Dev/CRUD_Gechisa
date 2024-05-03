Public Class frmBoleto
    Private Sub btnAgregarTicket_Click(sender As Object, e As EventArgs) Handles btnAgregarBoleto.Click
        panelBoleto.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelBoleto.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub
End Class