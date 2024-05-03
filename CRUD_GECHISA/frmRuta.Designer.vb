<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRuta))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelRuta = New Panel()
        Label2 = New Label()
        txtIdRuta = New TextBox()
        Label3 = New Label()
        txtDestino = New TextBox()
        Label4 = New Label()
        txtPrecio = New TextBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        dataRuta = New DataGridView()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarRuta = New PictureBox()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelRuta.SuspendLayout()
        CType(dataRuta, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarRuta, ComponentModel.ISupportInitialize).BeginInit()
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
        panelHeader.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 54)
        Label1.TabIndex = 0
        Label1.Text = "RUTA"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(559, 42)
        panelBusqueda.TabIndex = 17
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
        ' panelRuta
        ' 
        panelRuta.Controls.Add(Label2)
        panelRuta.Controls.Add(txtIdRuta)
        panelRuta.Controls.Add(Label3)
        panelRuta.Controls.Add(txtDestino)
        panelRuta.Controls.Add(Label4)
        panelRuta.Controls.Add(txtPrecio)
        panelRuta.Controls.Add(btnGuardar)
        panelRuta.Controls.Add(btnActualizar)
        panelRuta.Controls.Add(btnVolver)
        panelRuta.Location = New Point(0, 113)
        panelRuta.Name = "panelRuta"
        panelRuta.Size = New Size(559, 402)
        panelRuta.TabIndex = 1
        panelRuta.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(45, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID DE RUTA"
        ' 
        ' txtIdRuta
        ' 
        txtIdRuta.Location = New Point(270, 52)
        txtIdRuta.Name = "txtIdRuta"
        txtIdRuta.Size = New Size(233, 25)
        txtIdRuta.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 21)
        Label3.TabIndex = 5
        Label3.Text = "CIUDAD DE DESTINO"
        ' 
        ' txtDestino
        ' 
        txtDestino.Location = New Point(270, 102)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(233, 25)
        txtDestino.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 21)
        Label4.TabIndex = 6
        Label4.Text = "PRECIO"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(270, 152)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(233, 25)
        txtPrecio.TabIndex = 9
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
        btnGuardar.Location = New Point(96, 224)
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
        btnActualizar.Location = New Point(280, 224)
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
        btnVolver.Location = New Point(359, 283)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 61)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' dataRuta
        ' 
        dataRuta.AllowUserToAddRows = False
        dataRuta.AllowUserToDeleteRows = False
        dataRuta.AllowUserToResizeColumns = False
        dataRuta.BackgroundColor = SystemColors.ActiveCaption
        dataRuta.BorderStyle = BorderStyle.None
        dataRuta.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataRuta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataRuta.Dock = DockStyle.Fill
        dataRuta.EnableHeadersVisualStyles = False
        dataRuta.Location = New Point(0, 113)
        dataRuta.Name = "dataRuta"
        dataRuta.RowHeadersVisible = False
        dataRuta.RowHeadersWidth = 51
        dataRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataRuta.Size = New Size(466, 402)
        dataRuta.TabIndex = 2
        ' 
        ' panelLateral
        ' 
        panelLateral.Controls.Add(btnPrincipal)
        panelLateral.Controls.Add(btnAgregarRuta)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(466, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 402)
        panelLateral.TabIndex = 0
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(8, 317)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarRuta
        ' 
        btnAgregarRuta.Image = CType(resources.GetObject("btnAgregarRuta.Image"), Image)
        btnAgregarRuta.Location = New Point(14, 154)
        btnAgregarRuta.Name = "btnAgregarRuta"
        btnAgregarRuta.Size = New Size(68, 81)
        btnAgregarRuta.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarRuta.TabIndex = 0
        btnAgregarRuta.TabStop = False
        ' 
        ' frmRuta
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 515)
        Controls.Add(panelRuta)
        Controls.Add(dataRuta)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmRuta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRuta"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelRuta.ResumeLayout(False)
        panelRuta.PerformLayout()
        CType(dataRuta, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarRuta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarRuta As PictureBox
    Friend WithEvents panelRuta As Panel
    Friend WithEvents dataRuta As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnPrincipal As Button
End Class
