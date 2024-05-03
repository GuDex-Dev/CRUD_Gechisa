Imports System.Data.SqlClient

Public Class frmBus
    Private Sub btnAgregaBus_Click(sender As Object, e As EventArgs) Handles btnAgregaBus.Click
        panelBus.Visible = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelBus.Visible = False
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cmd As New SqlCommand
        If txtIdBus.Text <> "" And txtMarca.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Insert_Bus", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@ID_Bus", txtIdBus.Text.ToString)
                cmd.Parameters.AddWithValue("@status", txtEstado.Text.ToString)
                cmd.Parameters.AddWithValue("@brand", txtMarca.Text.ToString)
                cmd.Parameters.AddWithValue("@model", txtModelo.Text.ToString)
                cmd.Parameters.AddWithValue("@seats_count", txtCantAsientos.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()

                panelBus.Visible = False
                Limpiar()
                ' mostrar()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Los campos de nombre y apellido son obligatorios")
        End If
    End Sub

    Private Sub Limpiar()
        txtIdBus.Clear()
        txtEstado.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtCantAsientos.Clear()
        txtIdBus.Focus()
    End Sub

    Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Show_Bus", conexion)
            da.Fill(dt)
            dataBus.DataSource = dt
            Cerrar_Conexion()

            dataBus.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Consolas", 10, FontStyle.Regular Or FontStyle.Bold)
            dataBus.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmBus_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub
End Class