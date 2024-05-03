<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersona))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelPersona = New Panel()
        Label2 = New Label()
        txtDniPersona = New TextBox()
        Label3 = New Label()
        txtNombre = New TextBox()
        Label4 = New Label()
        txtApellido = New TextBox()
        Label5 = New Label()
        txtCorreo = New TextBox()
        Label6 = New Label()
        txtDireccion = New TextBox()
        Label7 = New Label()
        txtCelular = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        dataPersona = New DataGridView()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnNuevo = New PictureBox()
        Eliminar = New DataGridViewImageColumn()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelPersona.SuspendLayout()
        CType(dataPersona, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnNuevo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(561, 63)
        panelHeader.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 54)
        Label1.TabIndex = 0
        Label1.Text = "PERSONA"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 63)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(561, 37)
        panelBusqueda.TabIndex = 16
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(110, 11)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(419, 23)
        txtBuscar.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 26)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' panelPersona
        ' 
        panelPersona.Controls.Add(Label2)
        panelPersona.Controls.Add(txtDniPersona)
        panelPersona.Controls.Add(Label3)
        panelPersona.Controls.Add(txtNombre)
        panelPersona.Controls.Add(Label4)
        panelPersona.Controls.Add(txtApellido)
        panelPersona.Controls.Add(Label5)
        panelPersona.Controls.Add(txtCorreo)
        panelPersona.Controls.Add(Label6)
        panelPersona.Controls.Add(txtDireccion)
        panelPersona.Controls.Add(Label7)
        panelPersona.Controls.Add(txtCelular)
        panelPersona.Controls.Add(btnGuardar)
        panelPersona.Controls.Add(btnActualizar)
        panelPersona.Controls.Add(btnVolver)
        panelPersona.Location = New Point(0, 63)
        panelPersona.Name = "panelPersona"
        panelPersona.Size = New Size(561, 410)
        panelPersona.TabIndex = 17
        panelPersona.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(98, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 21)
        Label2.TabIndex = 3
        Label2.Text = "DNI "
        ' 
        ' txtDniPersona
        ' 
        txtDniPersona.Location = New Point(204, 44)
        txtDniPersona.Name = "txtDniPersona"
        txtDniPersona.Size = New Size(236, 23)
        txtDniPersona.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(98, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 21)
        Label3.TabIndex = 4
        Label3.Text = "Nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(204, 80)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(236, 23)
        txtNombre.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(98, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 21)
        Label4.TabIndex = 5
        Label4.Text = "Apellido"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(204, 119)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(236, 23)
        txtApellido.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(98, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 21)
        Label5.TabIndex = 6
        Label5.Text = "Correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(204, 155)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(236, 23)
        txtCorreo.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(98, 193)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 21)
        Label6.TabIndex = 7
        Label6.Text = "Direccion"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(204, 197)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(236, 23)
        txtDireccion.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(98, 228)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 21)
        Label7.TabIndex = 8
        Label7.Text = "Teléfono"
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(204, 230)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(236, 23)
        txtCelular.TabIndex = 13
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), Image)
        btnGuardar.BackgroundImageLayout = ImageLayout.None
        btnGuardar.CausesValidation = False
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.Black
        btnGuardar.Location = New Point(46, 274)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(165, 32)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), Image)
        btnActualizar.BackgroundImageLayout = ImageLayout.None
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(229, 274)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(171, 32)
        btnActualizar.TabIndex = 15
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), Image)
        btnVolver.BackgroundImageLayout = ImageLayout.Center
        btnVolver.Cursor = Cursors.Hand
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Location = New Point(452, 290)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 54)
        btnVolver.TabIndex = 2
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' dataPersona
        ' 
        dataPersona.AllowUserToAddRows = False
        dataPersona.AllowUserToDeleteRows = False
        dataPersona.AllowUserToResizeColumns = False
        dataPersona.BackgroundColor = SystemColors.ActiveCaption
        dataPersona.BorderStyle = BorderStyle.None
        dataPersona.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataPersona.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        dataPersona.Dock = DockStyle.Fill
        dataPersona.EnableHeadersVisualStyles = False
        dataPersona.Location = New Point(0, 100)
        dataPersona.Name = "dataPersona"
        dataPersona.RowHeadersVisible = False
        dataPersona.RowHeadersWidth = 51
        dataPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataPersona.Size = New Size(456, 373)
        dataPersona.TabIndex = 1
        ' 
        ' panelLateral
        ' 
        panelLateral.Controls.Add(btnPrincipal)
        panelLateral.Controls.Add(btnNuevo)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(456, 100)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(105, 373)
        panelLateral.TabIndex = 0
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(16, 290)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 54)
        btnPrincipal.TabIndex = 3
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Cursor = Cursors.Hand
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.Location = New Point(3, 116)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(102, 87)
        btnNuevo.SizeMode = PictureBoxSizeMode.Zoom
        btnNuevo.TabIndex = 0
        btnNuevo.TabStop = False
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), Image)
        Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Eliminar.Name = "Eliminar"
        ' 
        ' frmPersona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(561, 473)
        Controls.Add(panelPersona)
        Controls.Add(dataPersona)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmPersona"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelPersona.ResumeLayout(False)
        panelPersona.PerformLayout()
        CType(dataPersona, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnNuevo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDniPersona As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents panelPersona As Panel
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents dataPersona As DataGridView
    Friend WithEvents btnPrincipal As Button
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
