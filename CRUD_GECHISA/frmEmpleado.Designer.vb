<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        panelHeader = New Panel()
        Label1 = New Label()
        panelBusqueda = New Panel()
        txtBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        panelLateral = New Panel()
        btnPrincipal = New Button()
        btnAgregarEmpleado = New PictureBox()
        dataEmpleado = New DataGridView()
        panelEmpleado = New Panel()
        Label2 = New Label()
        txtIdEmpleado = New TextBox()
        Label3 = New Label()
        txtDniPersona = New TextBox()
        Label4 = New Label()
        txtContrasena = New TextBox()
        Label5 = New Label()
        txtEstado = New TextBox()
        Label6 = New Label()
        txtSalario = New TextBox()
        Label7 = New Label()
        cboTipoEmpleado = New ComboBox()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnVolver = New Button()
        panelHeader.SuspendLayout()
        panelBusqueda.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelLateral.SuspendLayout()
        CType(btnAgregarEmpleado, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataEmpleado, ComponentModel.ISupportInitialize).BeginInit()
        panelEmpleado.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(580, 71)
        panelHeader.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 54)
        Label1.TabIndex = 0
        Label1.Text = "EMPLEADO"
        ' 
        ' panelBusqueda
        ' 
        panelBusqueda.Controls.Add(txtBuscar)
        panelBusqueda.Controls.Add(PictureBox1)
        panelBusqueda.Dock = DockStyle.Top
        panelBusqueda.Location = New Point(0, 71)
        panelBusqueda.Name = "panelBusqueda"
        panelBusqueda.Size = New Size(580, 42)
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
        panelLateral.Controls.Add(btnAgregarEmpleado)
        panelLateral.Dock = DockStyle.Right
        panelLateral.Location = New Point(487, 113)
        panelLateral.Name = "panelLateral"
        panelLateral.Size = New Size(93, 510)
        panelLateral.TabIndex = 20
        ' 
        ' btnPrincipal
        ' 
        btnPrincipal.BackgroundImage = CType(resources.GetObject("btnPrincipal.BackgroundImage"), Image)
        btnPrincipal.BackgroundImageLayout = ImageLayout.Center
        btnPrincipal.Cursor = Cursors.Hand
        btnPrincipal.FlatAppearance.BorderSize = 0
        btnPrincipal.FlatStyle = FlatStyle.Flat
        btnPrincipal.Location = New Point(9, 418)
        btnPrincipal.Name = "btnPrincipal"
        btnPrincipal.Size = New Size(77, 61)
        btnPrincipal.TabIndex = 21
        btnPrincipal.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEmpleado
        ' 
        btnAgregarEmpleado.Image = CType(resources.GetObject("btnAgregarEmpleado.Image"), Image)
        btnAgregarEmpleado.Location = New Point(14, 183)
        btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        btnAgregarEmpleado.Size = New Size(68, 118)
        btnAgregarEmpleado.SizeMode = PictureBoxSizeMode.Zoom
        btnAgregarEmpleado.TabIndex = 0
        btnAgregarEmpleado.TabStop = False
        ' 
        ' dataEmpleado
        ' 
        dataEmpleado.AllowUserToAddRows = False
        dataEmpleado.AllowUserToDeleteRows = False
        dataEmpleado.AllowUserToResizeColumns = False
        dataEmpleado.BackgroundColor = SystemColors.ActiveCaption
        dataEmpleado.BorderStyle = BorderStyle.None
        dataEmpleado.CellBorderStyle = DataGridViewCellBorderStyle.None
        dataEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataEmpleado.Dock = DockStyle.Fill
        dataEmpleado.EnableHeadersVisualStyles = False
        dataEmpleado.Location = New Point(0, 113)
        dataEmpleado.Name = "dataEmpleado"
        dataEmpleado.RowHeadersVisible = False
        dataEmpleado.RowHeadersWidth = 51
        dataEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataEmpleado.Size = New Size(487, 510)
        dataEmpleado.TabIndex = 21
        ' 
        ' panelEmpleado
        ' 
        panelEmpleado.Controls.Add(Label2)
        panelEmpleado.Controls.Add(txtIdEmpleado)
        panelEmpleado.Controls.Add(Label3)
        panelEmpleado.Controls.Add(txtDniPersona)
        panelEmpleado.Controls.Add(Label4)
        panelEmpleado.Controls.Add(txtContrasena)
        panelEmpleado.Controls.Add(Label5)
        panelEmpleado.Controls.Add(txtEstado)
        panelEmpleado.Controls.Add(Label6)
        panelEmpleado.Controls.Add(txtSalario)
        panelEmpleado.Controls.Add(Label7)
        panelEmpleado.Controls.Add(cboTipoEmpleado)
        panelEmpleado.Controls.Add(btnGuardar)
        panelEmpleado.Controls.Add(btnActualizar)
        panelEmpleado.Controls.Add(btnVolver)
        panelEmpleado.Location = New Point(0, 110)
        panelEmpleado.Name = "panelEmpleado"
        panelEmpleado.Size = New Size(580, 519)
        panelEmpleado.TabIndex = 22
        panelEmpleado.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(67, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 21)
        Label2.TabIndex = 4
        Label2.Text = "ID DE EMPLEADO"
        ' 
        ' txtIdEmpleado
        ' 
        txtIdEmpleado.Location = New Point(259, 33)
        txtIdEmpleado.Name = "txtIdEmpleado"
        txtIdEmpleado.Size = New Size(267, 25)
        txtIdEmpleado.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(67, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 21)
        Label3.TabIndex = 5
        Label3.Text = "DNI DE PERSONA"
        ' 
        ' txtDniPersona
        ' 
        txtDniPersona.Location = New Point(259, 83)
        txtDniPersona.Name = "txtDniPersona"
        txtDniPersona.Size = New Size(267, 25)
        txtDniPersona.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(67, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 21)
        Label4.TabIndex = 6
        Label4.Text = "CONTRASEÑA"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(259, 133)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(267, 25)
        txtContrasena.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(67, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 21)
        Label5.TabIndex = 21
        Label5.Text = "ESTADO"
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(259, 185)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(267, 25)
        txtEstado.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(67, 241)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 21)
        Label6.TabIndex = 22
        Label6.Text = "SALARIO"
        ' 
        ' txtSalario
        ' 
        txtSalario.Location = New Point(259, 241)
        txtSalario.Name = "txtSalario"
        txtSalario.Size = New Size(267, 25)
        txtSalario.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(67, 298)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 21)
        Label7.TabIndex = 23
        Label7.Text = "TIPO DE EMPLEADO"
        ' 
        ' cboTipoEmpleado
        ' 
        cboTipoEmpleado.FormattingEnabled = True
        cboTipoEmpleado.Items.AddRange(New Object() {"--Seleciona--", "Empleado", "Conductor"})
        cboTipoEmpleado.Location = New Point(259, 298)
        cboTipoEmpleado.Name = "cboTipoEmpleado"
        cboTipoEmpleado.Size = New Size(267, 25)
        cboTipoEmpleado.TabIndex = 26
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
        btnGuardar.Location = New Point(120, 362)
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
        btnActualizar.Location = New Point(304, 362)
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
        btnVolver.Location = New Point(450, 428)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(77, 61)
        btnVolver.TabIndex = 20
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmEmpleado
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(580, 623)
        Controls.Add(panelEmpleado)
        Controls.Add(dataEmpleado)
        Controls.Add(panelLateral)
        Controls.Add(panelBusqueda)
        Controls.Add(panelHeader)
        Name = "frmEmpleado"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmEmpleado"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelBusqueda.ResumeLayout(False)
        panelBusqueda.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelLateral.ResumeLayout(False)
        CType(btnAgregarEmpleado, ComponentModel.ISupportInitialize).EndInit()
        CType(dataEmpleado, ComponentModel.ISupportInitialize).EndInit()
        panelEmpleado.ResumeLayout(False)
        panelEmpleado.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregarEmpleado As PictureBox
    Friend WithEvents dataEmpleado As DataGridView
    Friend WithEvents panelEmpleado As Panel
    Friend WithEvents cboTipoEmpleado As ComboBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtDniPersona As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrincipal As Button
End Class
