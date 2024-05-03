<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedor))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarVendedor = New PictureBox()
        dataVendedor = New DataGridView()
        panelVendedor = New Panel()
        Label2 = New Label()
        txtIdVendedor = New TextBox()
        Label3 = New Label()
        txtIdEmpleado = New TextBox()
        Label4 = New Label()
        txtTipoContrato = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarVendedor, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataVendedor, ComponentModel.ISupportInitialize).BeginInit()
        panelVendedor.SuspendLayout()
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
        panelHeader.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 54)
        Label1.TabIndex = 0
        Label1.Text = "VENDEDOR"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(560, 42)
        panelBusqueda.TabIndex = 19
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
        panelLateral.Controls.Add(btnAgregarVendedor)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(467, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 400)
        panelLateral.TabIndex = 20
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(8, 323)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarVendedor
        ' 
        btnAgregarVendedor.Image = CType(resources.GetObject("btnAgregarVendedor.Image"), Image)
        btnAgregarVendedor.Location = New Point(14, 154)
        btnAgregarVendedor.Name = "btnAgregarVendedor"
        btnAgregarVendedor.Size = New Size(68, 81)
        btnAgregarVendedor.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarVendedor.TabIndex = 0
        btnAgregarVendedor.TabStop = False
        ' 
        ' dataVendedor
        ' 
        dataVendedor.AllowUserToAddRows = False
        dataVendedor.AllowUserToDeleteRows = False
        dataVendedor.AllowUserToResizeColumns = False
        dataVendedor.BackgroundColor = SystemColors.ActiveCaption
        dataVendedor.BorderStyle = BorderStyle.None
        dataVendedor.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataVendedor.Dock = DockStyle.Fill
        dataVendedor.EnableHeadersVisualStyles = False
        dataVendedor.Location = New Point(0, 113)
        dataVendedor.Name = "dataVendedor"
        dataVendedor.RowHeadersVisible = False
        dataVendedor.RowHeadersWidth = 51
        dataVendedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataVendedor.Size = New Size(467, 400)
        dataVendedor.TabIndex = 21
        ' 
        ' panelVendedor
        ' 
        panelVendedor.Controls.Add(Label2)
        panelVendedor.Controls.Add(txtIdVendedor)
        panelVendedor.Controls.Add(Label3)
        panelVendedor.Controls.Add(txtIdEmpleado)
        panelVendedor.Controls.Add(Label4)
        panelVendedor.Controls.Add(txtTipoContrato)
        panelVendedor.Controls.Add(btnGuardar)
        panelVendedor.Controls.Add(btnActualizar)
        panelVendedor.Controls.Add(btnVolver)
        panelVendedor.Location = New Point(0, 113)
        panelVendedor.Name = "panelVendedor"
        panelVendedor.Size = New Size(560, 402)
        panelVendedor.TabIndex = 22
        panelVendedor.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID VENDEDOR"
        ' 
        ' txtIdVendedor
        ' 
        txtIdVendedor.Location = New Point(281, 57)
        txtIdVendedor.Name = "txtIdVendedor"
        txtIdVendedor.Size = New Size(233, 25)
        txtIdVendedor.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(95, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 21)
        Label3.TabIndex = 5
        Label3.Text = "ID EMPLEADO"
        ' 
        ' txtIdEmpleado
        ' 
        txtIdEmpleado.Location = New Point(281, 104)
        txtIdEmpleado.Name = "txtIdEmpleado"
        txtIdEmpleado.Size = New Size(233, 25)
        txtIdEmpleado.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(95, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 21)
        Label4.TabIndex = 6
        Label4.Text = "TIPO DE CONTRATO"
        ' 
        ' txtTipoContrato
        ' 
        txtTipoContrato.Location = New Point(281, 154)
        txtTipoContrato.Name = "txtTipoContrato"
        txtTipoContrato.Size = New Size(233, 25)
        txtTipoContrato.TabIndex = 21
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
        btnGuardar.Location = New Point(107, 226)
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
        btnActualizar.Location = New Point(290, 226)
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
        btnVolver.Location = New Point(437, 292)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 61)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmVendedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 513)
        Controls.Add(panelVendedor)
        Controls.Add(dataVendedor)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmVendedor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmVendedor"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarVendedor, ComponentModel.ISupportInitialize).EndInit()
        CType(dataVendedor, ComponentModel.ISupportInitialize).EndInit()
        panelVendedor.ResumeLayout(False)
        panelVendedor.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarVendedor As PictureBox
    Friend WithEvents dataVendedor As DataGridView
    Friend WithEvents panelVendedor As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTipoContrato As TextBox
    Friend WithEvents btnPrincipal As Button
End Class
