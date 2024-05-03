<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConductor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConductor))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarConductor = New PictureBox()
        dataConductor = New DataGridView()
        panelConductor = New Panel()
        Label2 = New Label()
        txtIdConductor = New TextBox()
        Label3 = New Label()
        txtIdEmpleado = New TextBox()
        Label4 = New Label()
        txtLicencia = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarConductor, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataConductor, ComponentModel.ISupportInitialize).BeginInit()
        panelConductor.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(596, 71)
        panelHeader.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 54)
        Label1.TabIndex = 0
        Label1.Text = "CONDUCTOR"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(596, 42)
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
        panelLateral.Controls.Add(btnAgregarConductor)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(503, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 423)
        panelLateral.TabIndex = 19
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(11, 350)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarConductor
        ' 
        btnAgregarConductor.Image = CType(resources.GetObject("btnAgregarConductor.Image"), Image)
        btnAgregarConductor.Location = New Point(11, 155)
        btnAgregarConductor.Name = "btnAgregarConductor"
        btnAgregarConductor.Size = New Size(79, 86)
        btnAgregarConductor.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarConductor.TabIndex = 0
        btnAgregarConductor.TabStop = False
        ' 
        ' dataConductor
        ' 
        dataConductor.AllowUserToAddRows = False
        dataConductor.AllowUserToDeleteRows = False
        dataConductor.AllowUserToResizeColumns = False
        dataConductor.BackgroundColor = SystemColors.ActiveCaption
        dataConductor.BorderStyle = BorderStyle.None
        dataConductor.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataConductor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataConductor.Dock = DockStyle.Fill
        dataConductor.EnableHeadersVisualStyles = False
        dataConductor.Location = New Point(0, 113)
        dataConductor.Name = "dataConductor"
        dataConductor.RowHeadersVisible = False
        dataConductor.RowHeadersWidth = 51
        dataConductor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataConductor.Size = New Size(503, 423)
        dataConductor.TabIndex = 20
        ' 
        ' panelConductor
        ' 
        panelConductor.Controls.Add(Label2)
        panelConductor.Controls.Add(txtIdConductor)
        panelConductor.Controls.Add(Label3)
        panelConductor.Controls.Add(txtIdEmpleado)
        panelConductor.Controls.Add(Label4)
        panelConductor.Controls.Add(txtLicencia)
        panelConductor.Controls.Add(btnGuardar)
        panelConductor.Controls.Add(btnActualizar)
        panelConductor.Controls.Add(btnVolver)
        panelConductor.Location = New Point(0, 110)
        panelConductor.Name = "panelConductor"
        panelConductor.Size = New Size(596, 425)
        panelConductor.TabIndex = 21
        panelConductor.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(45, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID DE CONDUCTOR"
        ' 
        ' txtIdConductor
        ' 
        txtIdConductor.Location = New Point(236, 52)
        txtIdConductor.Name = "txtIdConductor"
        txtIdConductor.Size = New Size(267, 25)
        txtIdConductor.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 21)
        Label3.TabIndex = 5
        Label3.Text = "ID EMPLEADO"
        ' 
        ' txtIdEmpleado
        ' 
        txtIdEmpleado.Location = New Point(236, 102)
        txtIdEmpleado.Name = "txtIdEmpleado"
        txtIdEmpleado.Size = New Size(267, 25)
        txtIdEmpleado.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 21)
        Label4.TabIndex = 6
        Label4.Text = "LICENCIA"
        ' 
        ' txtLicencia
        ' 
        txtLicencia.Location = New Point(236, 152)
        txtLicencia.Name = "txtLicencia"
        txtLicencia.Size = New Size(267, 25)
        txtLicencia.TabIndex = 9
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
        btnGuardar.Location = New Point(91, 256)
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
        btnActualizar.Location = New Point(275, 256)
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
        btnVolver.Location = New Point(421, 322)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 61)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmConductor
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(596, 536)
        Controls.Add(panelConductor)
        Controls.Add(dataConductor)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmConductor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmConductor"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarConductor, ComponentModel.ISupportInitialize).EndInit()
        CType(dataConductor, ComponentModel.ISupportInitialize).EndInit()
        panelConductor.ResumeLayout(False)
        panelConductor.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarConductor As PictureBox
    Friend WithEvents dataConductor As DataGridView
    Friend WithEvents panelConductor As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtLicencia As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents txtIdConductor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrincipal As Button
End Class
