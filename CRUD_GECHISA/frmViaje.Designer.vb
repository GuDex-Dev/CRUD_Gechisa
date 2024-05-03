<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViaje))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarViaje = New PictureBox()
        dataViaje = New DataGridView()
        panelViaje = New Panel()
        Label2 = New Label()
        txtIdViaje = New TextBox()
        Label3 = New Label()
        txtIdRuta = New TextBox()
        Label4 = New Label()
        txtIdBus = New TextBox()
        Label5 = New Label()
        txtIdConductor = New TextBox()
        Label6 = New Label()
        txtFechaViaje = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarViaje, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataViaje, ComponentModel.ISupportInitialize).BeginInit()
        panelViaje.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(560, 71)
        panelHeader.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 54)
        Label1.TabIndex = 0
        Label1.Text = "VIAJE"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(560, 42)
        panelBusqueda.TabIndex = 18
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(110, 12)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(419, 25)
        txtBuscar.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' panelLateral
        ' 
        panelLateral.Controls.Add(btnPrincipal)
        panelLateral.Controls.Add(btnAgregarViaje)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(467, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 467)
        panelLateral.TabIndex = 19
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(9, 387)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarViaje
        ' 
        btnAgregarViaje.Image = CType(resources.GetObject("btnAgregarViaje.Image"), Image)
        btnAgregarViaje.Location = New Point(14, 154)
        btnAgregarViaje.Name = "btnAgregarViaje"
        btnAgregarViaje.Size = New Size(68, 81)
        btnAgregarViaje.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarViaje.TabIndex = 0
        btnAgregarViaje.TabStop = False
        ' 
        ' dataViaje
        ' 
        dataViaje.AllowUserToAddRows = False
        dataViaje.AllowUserToDeleteRows = False
        dataViaje.AllowUserToResizeColumns = False
        dataViaje.BackgroundColor = SystemColors.ActiveCaption
        dataViaje.BorderStyle = BorderStyle.None
        dataViaje.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataViaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataViaje.Dock = DockStyle.Fill
        dataViaje.EnableHeadersVisualStyles = False
        dataViaje.Location = New Point(0, 113)
        dataViaje.Name = "dataViaje"
        dataViaje.RowHeadersVisible = False
        dataViaje.RowHeadersWidth = 51
        dataViaje.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataViaje.Size = New Size(467, 467)
        dataViaje.TabIndex = 20
        ' 
        ' panelViaje
        ' 
        panelViaje.Controls.Add(Label2)
        panelViaje.Controls.Add(txtIdViaje)
        panelViaje.Controls.Add(Label3)
        panelViaje.Controls.Add(txtIdRuta)
        panelViaje.Controls.Add(Label4)
        panelViaje.Controls.Add(txtIdBus)
        panelViaje.Controls.Add(Label5)
        panelViaje.Controls.Add(txtIdConductor)
        panelViaje.Controls.Add(Label6)
        panelViaje.Controls.Add(txtFechaViaje)
        panelViaje.Controls.Add(btnGuardar)
        panelViaje.Controls.Add(btnActualizar)
        panelViaje.Controls.Add(btnVolver)
        panelViaje.Location = New Point(0, 113)
        panelViaje.Name = "panelViaje"
        panelViaje.Size = New Size(560, 467)
        panelViaje.TabIndex = 21
        panelViaje.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(101, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID VIAJE"
        ' 
        ' txtIdViaje
        ' 
        txtIdViaje.Location = New Point(261, 52)
        txtIdViaje.Name = "txtIdViaje"
        txtIdViaje.Size = New Size(233, 25)
        txtIdViaje.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(101, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 21)
        Label3.TabIndex = 5
        Label3.Text = "ID RUTA"
        ' 
        ' txtIdRuta
        ' 
        txtIdRuta.Location = New Point(261, 102)
        txtIdRuta.Name = "txtIdRuta"
        txtIdRuta.Size = New Size(233, 25)
        txtIdRuta.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(101, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 6
        Label4.Text = "ID BUS"
        ' 
        ' txtIdBus
        ' 
        txtIdBus.Location = New Point(261, 152)
        txtIdBus.Name = "txtIdBus"
        txtIdBus.Size = New Size(233, 25)
        txtIdBus.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(101, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 21)
        Label5.TabIndex = 21
        Label5.Text = "ID CONDUCTOR"
        ' 
        ' txtIdConductor
        ' 
        txtIdConductor.Location = New Point(261, 203)
        txtIdConductor.Name = "txtIdConductor"
        txtIdConductor.Size = New Size(233, 25)
        txtIdConductor.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(101, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(141, 21)
        Label6.TabIndex = 22
        Label6.Text = "FECHA DEL VIAJE"
        ' 
        ' txtFechaViaje
        ' 
        txtFechaViaje.Location = New Point(261, 256)
        txtFechaViaje.Name = "txtFechaViaje"
        txtFechaViaje.Size = New Size(233, 25)
        txtFechaViaje.TabIndex = 24
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
        btnGuardar.Location = New Point(98, 320)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(165, 36)
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
        btnActualizar.Location = New Point(282, 320)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(171, 36)
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
        btnVolver.Location = New Point(428, 387)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 61)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmViaje
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 580)
        Controls.Add(panelViaje)
        Controls.Add(dataViaje)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmViaje"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmViaje"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarViaje, ComponentModel.ISupportInitialize).EndInit()
        CType(dataViaje, ComponentModel.ISupportInitialize).EndInit()
        panelViaje.ResumeLayout(False)
        panelViaje.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarViaje As PictureBox
    Friend WithEvents dataViaje As DataGridView
    Friend WithEvents panelViaje As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdBus As TextBox
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents txtIdViaje As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaViaje As TextBox
    Friend WithEvents txtIdConductor As TextBox
    Friend WithEvents btnPrincipal As Button
End Class
