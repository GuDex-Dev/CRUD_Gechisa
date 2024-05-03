Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Abrir_Conexion()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(frmPrincipal.MousePosition.X - Me.Location.X - ex, frmPrincipal.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseUp
        Arrastre = False
    End Sub

    Private Sub btnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        frmPersona.Show()
        Me.Close()
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        frmRuta.Show()
        Me.Close()
    End Sub

    Private Sub btnBus_Click(sender As Object, e As EventArgs) Handles btnBus.Click
        frmBus.Show()
        Me.Close()
    End Sub

    Private Sub btnConductor_Click(sender As Object, e As EventArgs) Handles btnConductor.Click
        frmConductor.Show()
        Me.Close()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        frmEmpleado.Show()
        Me.Close()
    End Sub

    Private Sub btnViaje_Click(sender As Object, e As EventArgs) Handles btnViaje.Click
        frmViaje.Show()
        Me.Close()
    End Sub

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles btnVendedor.Click
        frmVendedor.Show()
        Me.Close()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCliente.Show()
        Me.Close()
    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnBoleto.Click
        frmBoleto.Show()
        Me.Close()
    End Sub


End Class
