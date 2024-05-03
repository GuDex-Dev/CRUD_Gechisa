Imports System.Data.SqlClient

Public Class frmPersona
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelPersona.Visible = True
        btnGuardar.Enabled = True
        btnActualizar.Enabled = False
        txtDniPersona.Focus()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        panelPersona.Visible = False
        btnGuardar.Enabled = True
        btnActualizar.Enabled = True
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub panelHeader_Paint(sender As Object, e As PaintEventArgs) Handles panelHeader.Paint

    End Sub

    Private Sub Limpiar()
        txtApellido.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
        txtDniPersona.Clear()
        txtNombre.Clear()
        txtDniPersona.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cmd As New SqlCommand
        If txtNombre.Text <> "" And txtDniPersona.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Insert_Person", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@DNI_Person", txtDniPersona.Text.ToString)
                cmd.Parameters.AddWithValue("@first_name", txtNombre.Text.ToString)
                cmd.Parameters.AddWithValue("@last_name", txtApellido.Text.ToString)
                cmd.Parameters.AddWithValue("@email", txtCorreo.Text.ToString)
                cmd.Parameters.AddWithValue("@address", txtDireccion.Text.ToString)
                cmd.Parameters.AddWithValue("@phone", txtCelular.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()

                panelPersona.Visible = False
                Limpiar()
                mostrar()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Los campos de nombre y apellido son obligatorios")
        End If
    End Sub

    Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Show_Person", conexion)
            da.Fill(dt)
            dataPersona.DataSource = dt
            Cerrar_Conexion()

            dataPersona.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Consolas", 10, FontStyle.Regular Or FontStyle.Bold)
            dataPersona.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try

    End Sub

    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Search_person", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Search", txtBuscar.Text)
            da.Fill(dt)
            dataPersona.DataSource = dt
            Cerrar_Conexion()

            dataPersona.EnableHeadersVisualStyles = False
            Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle
            estilo.BackColor = Color.White
            estilo.ForeColor = Color.Black
            estilo.Font = New Font("Consolas", 10, FontStyle.Regular Or FontStyle.Bold)
            dataPersona.ColumnHeadersDefaultCellStyle = estilo

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
    Private Sub dataPersona_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPersona.CellContentClick
        'Verificar si se ha dado clic sobre la columna de eliminar
        If e.ColumnIndex = dataPersona.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado y ya no se podra acceder a los datos de la persona", vbQuestion + vbOKCancel, "Sistema GECHISA")
            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    Abrir_Conexion()
                    cmd = New SqlCommand("Delete_Person", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@DNI_Person", dataPersona.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    Cerrar_Conexion()
                    mostrar()
                Catch ex As Exception

                End Try
            Else
                MsgBox("Eliminacion cancelada", vbInformation + vbOKOnly, "Sistema GEECHISA")
            End If
        End If
    End Sub

    Private Sub dataPersona_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataPersona.CellContentDoubleClick
        panelPersona.Visible = True
        Try
            txtDniPersona.Text = dataPersona.SelectedCells.Item(1).Value
            txtNombre.Text = dataPersona.SelectedCells.Item(2).Value
            txtApellido.Text = dataPersona.SelectedCells.Item(3).Value
            txtCorreo.Text = dataPersona.SelectedCells.Item(4).Value
            txtDireccion.Text = dataPersona.SelectedCells.Item(5).Value
            txtCelular.Text = dataPersona.SelectedCells.Item(6).Value

            btnGuardar.Enabled = False
            btnActualizar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cmd As New SqlCommand
        If txtNombre.Text <> "" And txtDniPersona.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Edit_Person", conexion)
                cmd.CommandType = 4


                cmd.Parameters.AddWithValue("@DNI_Person", txtDniPersona.Text.ToString)
                cmd.Parameters.AddWithValue("@first_name", txtNombre.Text.ToString)
                cmd.Parameters.AddWithValue("@last_name", txtApellido.Text.ToString)
                cmd.Parameters.AddWithValue("@email", txtCorreo.Text.ToString)
                cmd.Parameters.AddWithValue("@address", txtDireccion.Text.ToString)
                cmd.Parameters.AddWithValue("@phone", txtCelular.Text.ToString)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()

                panelPersona.Visible = False
                Limpiar()
                mostrar()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Los campos de nombre y apellido son obligatorios")
        End If
    End Sub


End Class