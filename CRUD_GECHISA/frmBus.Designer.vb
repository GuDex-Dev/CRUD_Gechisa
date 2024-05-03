<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBus))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregaBus = New PictureBox()
        dataBus = New DataGridView()
        Eliminar = New DataGridViewImageColumn()
        panelBus = New Panel()
        Label2 = New Label()
        txtIdBus = New TextBox()
        Label3 = New Label()
        txtEstado = New TextBox()
        Label4 = New Label()
        txtMarca = New TextBox()
        Label5 = New Label()
        txtModelo = New TextBox()
        Label6 = New Label()
        txtCantAsientos = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregaBus, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataBus, ComponentModel.ISupportInitialize).BeginInit()
        panelBus.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(574, 63)
        panelHeader.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 54)
        Label1.TabIndex = 0
        Label1.Text = "BUS"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 63)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(574, 37)
        panelBusqueda.TabIndex = 20
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
        ' panelLateral
        ' 
        panelLateral.Controls.Add(btnPrincipal)
        panelLateral.Controls.Add(btnAgregaBus)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(481, 100)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 399)
        panelLateral.TabIndex = 21
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(8, 311)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 54)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregaBus
        ' 
        btnAgregaBus.Image = CType(resources.GetObject("btnAgregaBus.Image"), Image)
        btnAgregaBus.Location = New Point(3, 109)
        btnAgregaBus.Name = "btnAgregaBus"
        btnAgregaBus.Size = New Size(88, 124)
        btnAgregaBus.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregaBus.TabIndex = 0
        btnAgregaBus.TabStop = False
        ' 
        ' dataBus
        ' 
        dataBus.AllowUserToAddRows = False
        dataBus.AllowUserToDeleteRows = False
        dataBus.AllowUserToResizeColumns = False
        dataBus.BackgroundColor = SystemColors.ActiveCaption
        dataBus.BorderStyle = BorderStyle.None
        dataBus.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataBus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataBus.Columns.AddRange(New DataGridViewColumn() {Eliminar})
        dataBus.Dock = DockStyle.Fill
        dataBus.EnableHeadersVisualStyles = False
        dataBus.Location = New Point(0, 100)
        dataBus.Name = "dataBus"
        dataBus.RowHeadersVisible = False
        dataBus.RowHeadersWidth = 51
        dataBus.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataBus.Size = New Size(481, 399)
        dataBus.TabIndex = 22
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Column1"
        Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), Image)
        Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom
        Eliminar.Name = "Eliminar"
        ' 
        ' panelBus
        ' 
        panelBus.Controls.Add(Label2)
        panelBus.Controls.Add(txtIdBus)
        panelBus.Controls.Add(Label3)
        panelBus.Controls.Add(txtEstado)
        panelBus.Controls.Add(Label4)
        panelBus.Controls.Add(txtMarca)
        panelBus.Controls.Add(Label5)
        panelBus.Controls.Add(txtModelo)
        panelBus.Controls.Add(Label6)
        panelBus.Controls.Add(txtCantAsientos)
        panelBus.Controls.Add(btnGuardar)
        panelBus.Controls.Add(btnActualizar)
        panelBus.Controls.Add(btnVolver)
        panelBus.Location = New Point(0, 63)
        panelBus.Name = "panelBus"
        panelBus.Size = New Size(574, 439)
        panelBus.TabIndex = 23
        panelBus.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(80, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID DEL BUS"
        ' 
        ' txtIdBus
        ' 
        txtIdBus.Location = New Point(271, 33)
        txtIdBus.Name = "txtIdBus"
        txtIdBus.Size = New Size(267, 23)
        txtIdBus.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(80, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 21)
        Label3.TabIndex = 5
        Label3.Text = "ESTADO"
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(271, 77)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(267, 23)
        txtEstado.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 21)
        Label4.TabIndex = 6
        Label4.Text = "MARCA"
        ' 
        ' txtMarca
        ' 
        txtMarca.Location = New Point(271, 121)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(267, 23)
        txtMarca.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(80, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 21)
        Label5.TabIndex = 21
        Label5.Text = "MODELO"
        ' 
        ' txtModelo
        ' 
        txtModelo.Location = New Point(271, 167)
        txtModelo.Name = "txtModelo"
        txtModelo.Size = New Size(267, 23)
        txtModelo.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(80, 215)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 21)
        Label6.TabIndex = 22
        Label6.Text = "N° DE ASIENTO"
        ' 
        ' txtCantAsientos
        ' 
        txtCantAsientos.Location = New Point(271, 215)
        txtCantAsientos.Name = "txtCantAsientos"
        txtCantAsientos.Size = New Size(267, 23)
        txtCantAsientos.TabIndex = 25
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
        btnGuardar.Location = New Point(110, 269)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(165, 32)
        btnGuardar.TabIndex = 17
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
        btnActualizar.Location = New Point(294, 269)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(171, 32)
        btnActualizar.TabIndex = 18
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
        btnVolver.Location = New Point(440, 327)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 54)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmBus
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 499)
        Controls.Add(panelBus)
        Controls.Add(dataBus)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmBus"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmBus"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregaBus, ComponentModel.ISupportInitialize).EndInit()
        CType(dataBus, ComponentModel.ISupportInitialize).EndInit()
        panelBus.ResumeLayout(False)
        panelBus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Protected WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregaBus As PictureBox
    Friend WithEvents dataBus As DataGridView
    Friend WithEvents panelBus As Panel
    Friend WithEvents txtCantAsientos As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtIdBus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrincipal As Button
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
