<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoleto))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarBoleto = New PictureBox()
        dataBoleto = New DataGridView()
        panelBoleto = New Panel()
        Label2 = New Label()
        txtIdBoleto = New TextBox()
        Label3 = New Label()
        txtIdCliente = New TextBox()
        Label4 = New Label()
        txtIdVendedor = New TextBox()
        Label5 = New Label()
        txtIdViaje = New TextBox()
        Label6 = New Label()
        txtFechaBoleto = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarBoleto, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataBoleto, ComponentModel.ISupportInitialize).BeginInit()
        panelBoleto.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(559, 71)
        panelHeader.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 54)
        Label1.TabIndex = 0
        Label1.Text = "BOLETO"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(559, 42)
        panelBusqueda.TabIndex = 21
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
        panelLateral.Controls.Add(btnAgregarBoleto)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(466, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 468)
        panelLateral.TabIndex = 22
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(8, 373)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarBoleto
        ' 
        btnAgregarBoleto.Image = CType(resources.GetObject("btnAgregarBoleto.Image"), Image)
        btnAgregarBoleto.Location = New Point(14, 137)
        btnAgregarBoleto.Name = "btnAgregarBoleto"
        btnAgregarBoleto.Size = New Size(68, 81)
        btnAgregarBoleto.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarBoleto.TabIndex = 0
        btnAgregarBoleto.TabStop = False
        ' 
        ' dataBoleto
        ' 
        dataBoleto.AllowUserToAddRows = False
        dataBoleto.AllowUserToDeleteRows = False
        dataBoleto.AllowUserToResizeColumns = False
        dataBoleto.BackgroundColor = SystemColors.ActiveCaption
        dataBoleto.BorderStyle = BorderStyle.None
        dataBoleto.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataBoleto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataBoleto.Dock = DockStyle.Fill
        dataBoleto.EnableHeadersVisualStyles = False
        dataBoleto.Location = New Point(0, 113)
        dataBoleto.Name = "dataBoleto"
        dataBoleto.RowHeadersVisible = False
        dataBoleto.RowHeadersWidth = 51
        dataBoleto.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataBoleto.Size = New Size(466, 468)
        dataBoleto.TabIndex = 23
        ' 
        ' panelBoleto
        ' 
        panelBoleto.Controls.Add(Label2)
        panelBoleto.Controls.Add(txtIdBoleto)
        panelBoleto.Controls.Add(Label3)
        panelBoleto.Controls.Add(txtIdCliente)
        panelBoleto.Controls.Add(Label4)
        panelBoleto.Controls.Add(txtIdVendedor)
        panelBoleto.Controls.Add(Label5)
        panelBoleto.Controls.Add(txtIdViaje)
        panelBoleto.Controls.Add(Label6)
        panelBoleto.Controls.Add(txtFechaBoleto)
        panelBoleto.Controls.Add(btnGuardar)
        panelBoleto.Controls.Add(btnActualizar)
        panelBoleto.Controls.Add(btnVolver)
        panelBoleto.Location = New Point(0, 116)
        panelBoleto.Name = "panelBoleto"
        panelBoleto.Size = New Size(559, 464)
        panelBoleto.TabIndex = 24
        panelBoleto.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(101, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID BOLETO"
        ' 
        ' txtIdBoleto
        ' 
        txtIdBoleto.Location = New Point(261, 52)
        txtIdBoleto.Name = "txtIdBoleto"
        txtIdBoleto.Size = New Size(233, 25)
        txtIdBoleto.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(101, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 21)
        Label3.TabIndex = 5
        Label3.Text = "ID CLIENTE"
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Location = New Point(261, 102)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(233, 25)
        txtIdCliente.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(101, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 21)
        Label4.TabIndex = 6
        Label4.Text = "ID VENDEDOR"
        ' 
        ' txtIdVendedor
        ' 
        txtIdVendedor.Location = New Point(261, 152)
        txtIdVendedor.Name = "txtIdVendedor"
        txtIdVendedor.Size = New Size(233, 25)
        txtIdVendedor.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(101, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 21)
        Label5.TabIndex = 21
        Label5.Text = "ID VIAJE"
        ' 
        ' txtIdViaje
        ' 
        txtIdViaje.Location = New Point(261, 203)
        txtIdViaje.Name = "txtIdViaje"
        txtIdViaje.Size = New Size(233, 25)
        txtIdViaje.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(101, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 21)
        Label6.TabIndex = 22
        Label6.Text = "FECHA DEL BOLETO"
        ' 
        ' txtFechaBoleto
        ' 
        txtFechaBoleto.Location = New Point(261, 256)
        txtFechaBoleto.Name = "txtFechaBoleto"
        txtFechaBoleto.Size = New Size(233, 25)
        txtFechaBoleto.TabIndex = 24
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
        ' frmBoleto
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 581)
        Controls.Add(panelBoleto)
        Controls.Add(dataBoleto)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmBoleto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmTicket"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarBoleto, ComponentModel.ISupportInitialize).EndInit()
        CType(dataBoleto, ComponentModel.ISupportInitialize).EndInit()
        panelBoleto.ResumeLayout(False)
        panelBoleto.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarBoleto As PictureBox
    Friend WithEvents dataBoleto As DataGridView
    Friend WithEvents panelBoleto As Panel
    Friend WithEvents txtFechaBoleto As TextBox
    Friend WithEvents txtIdViaje As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtIdBoleto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrincipal As Button
End Class
