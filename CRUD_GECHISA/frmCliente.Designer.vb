<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarCliente = New PictureBox()
        dataCliente = New DataGridView()
        panelCliente = New Panel()
        Label2 = New Label()
        txtIdRuta = New TextBox()
        Label3 = New Label()
        txtDestino = New TextBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarCliente, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataCliente, ComponentModel.ISupportInitialize).BeginInit()
        panelCliente.SuspendLayout()
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
        panelHeader.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 54)
        Label1.TabIndex = 0
        Label1.Text = "CLIENTE"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(560, 42)
        panelBusqueda.TabIndex = 20
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
        panelLateral.Controls.Add(btnAgregarCliente)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(467, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 402)
        panelLateral.TabIndex = 21
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(9, 329)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Image = CType(resources.GetObject("btnAgregarCliente.Image"), Image)
        btnAgregarCliente.Location = New Point(14, 137)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(68, 81)
        btnAgregarCliente.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarCliente.TabIndex = 0
        btnAgregarCliente.TabStop = False
        ' 
        ' dataCliente
        ' 
        dataCliente.AllowUserToAddRows = False
        dataCliente.AllowUserToDeleteRows = False
        dataCliente.AllowUserToResizeColumns = False
        dataCliente.BackgroundColor = SystemColors.ActiveCaption
        dataCliente.BorderStyle = BorderStyle.None
        dataCliente.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataCliente.Dock = DockStyle.Fill
        dataCliente.EnableHeadersVisualStyles = False
        dataCliente.Location = New Point(0, 113)
        dataCliente.Name = "dataCliente"
        dataCliente.RowHeadersVisible = False
        dataCliente.RowHeadersWidth = 51
        dataCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataCliente.Size = New Size(467, 402)
        dataCliente.TabIndex = 22
        ' 
        ' panelCliente
        ' 
        panelCliente.Controls.Add(Label2)
        panelCliente.Controls.Add(txtIdRuta)
        panelCliente.Controls.Add(Label3)
        panelCliente.Controls.Add(txtDestino)
        panelCliente.Controls.Add(Label4)
        panelCliente.Controls.Add(TextBox1)
        panelCliente.Controls.Add(btnGuardar)
        panelCliente.Controls.Add(btnActualizar)
        panelCliente.Controls.Add(btnVolver)
        panelCliente.Location = New Point(0, 113)
        panelCliente.Name = "panelCliente"
        panelCliente.Size = New Size(560, 404)
        panelCliente.TabIndex = 23
        panelCliente.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID CLIENTE"
        ' 
        ' txtIdRuta
        ' 
        txtIdRuta.Location = New Point(234, 57)
        txtIdRuta.Name = "txtIdRuta"
        txtIdRuta.Size = New Size(233, 25)
        txtIdRuta.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(95, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 21)
        Label3.TabIndex = 5
        Label3.Text = "DNI PERSONA"
        ' 
        ' txtDestino
        ' 
        txtDestino.Location = New Point(234, 104)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(233, 25)
        txtDestino.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(95, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 21)
        Label4.TabIndex = 6
        Label4.Text = "CONTRASEÑA"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(234, 154)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 25)
        TextBox1.TabIndex = 21
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
        ' frmCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 515)
        Controls.Add(panelCliente)
        Controls.Add(dataCliente)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCliente"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarCliente, ComponentModel.ISupportInitialize).EndInit()
        CType(dataCliente, ComponentModel.ISupportInitialize).EndInit()
        panelCliente.ResumeLayout(False)
        panelCliente.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarCliente As PictureBox
    Friend WithEvents dataCliente As DataGridView
    Friend WithEvents panelCliente As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrincipal As Button
End Class
