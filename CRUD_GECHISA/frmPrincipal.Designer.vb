<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        panelHeader = New Panel()
        btnCerrar = New Button()
        Label1 = New Label()
        btnRuta = New Button()
        btnConductor = New Button()
        btnEmpleado = New Button()
        btnBus = New Button()
        btnViaje = New Button()
        btnVendedor = New Button()
        btnCliente = New Button()
        btnPersona = New Button()
        btnBoleto = New Button()
        panelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = SystemColors.MenuHighlight
        panelHeader.Controls.Add(btnCerrar)
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(642, 63)
        panelHeader.TabIndex = 0
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.Cursor = Cursors.Hand
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(592, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(50, 53)
        btnCerrar.TabIndex = 1
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 39)
        Label1.TabIndex = 0
        Label1.Text = "MENÚ PRINCIPAL"
        ' 
        ' btnRuta
        ' 
        btnRuta.Location = New Point(43, 94)
        btnRuta.Name = "btnRuta"
        btnRuta.Size = New Size(126, 48)
        btnRuta.TabIndex = 1
        btnRuta.Text = "RUTA"
        btnRuta.UseVisualStyleBackColor = True
        ' 
        ' btnConductor
        ' 
        btnConductor.Location = New Point(186, 94)
        btnConductor.Name = "btnConductor"
        btnConductor.Size = New Size(130, 48)
        btnConductor.TabIndex = 2
        btnConductor.Text = "CONDUCTOR"
        btnConductor.UseVisualStyleBackColor = True
        ' 
        ' btnEmpleado
        ' 
        btnEmpleado.Location = New Point(332, 94)
        btnEmpleado.Name = "btnEmpleado"
        btnEmpleado.Size = New Size(126, 48)
        btnEmpleado.TabIndex = 3
        btnEmpleado.Text = "EMPLEADO"
        btnEmpleado.UseVisualStyleBackColor = True
        ' 
        ' btnBus
        ' 
        btnBus.Location = New Point(43, 156)
        btnBus.Name = "btnBus"
        btnBus.Size = New Size(130, 48)
        btnBus.TabIndex = 4
        btnBus.Text = "BUS"
        btnBus.UseVisualStyleBackColor = True
        ' 
        ' btnViaje
        ' 
        btnViaje.Location = New Point(186, 156)
        btnViaje.Name = "btnViaje"
        btnViaje.Size = New Size(130, 48)
        btnViaje.TabIndex = 5
        btnViaje.Text = "VIAJE"
        btnViaje.UseVisualStyleBackColor = True
        ' 
        ' btnVendedor
        ' 
        btnVendedor.Location = New Point(332, 156)
        btnVendedor.Name = "btnVendedor"
        btnVendedor.Size = New Size(126, 48)
        btnVendedor.TabIndex = 6
        btnVendedor.Text = "VENDEDOR"
        btnVendedor.UseVisualStyleBackColor = True
        ' 
        ' btnCliente
        ' 
        btnCliente.Location = New Point(475, 156)
        btnCliente.Name = "btnCliente"
        btnCliente.Size = New Size(126, 48)
        btnCliente.TabIndex = 7
        btnCliente.Text = "CLIENTE"
        btnCliente.UseVisualStyleBackColor = True
        ' 
        ' btnPersona
        ' 
        btnPersona.Location = New Point(475, 94)
        btnPersona.Name = "btnPersona"
        btnPersona.Size = New Size(126, 48)
        btnPersona.TabIndex = 8
        btnPersona.Text = "PERSONA"
        btnPersona.UseVisualStyleBackColor = True
        ' 
        ' btnBoleto
        ' 
        btnBoleto.Location = New Point(264, 221)
        btnBoleto.Name = "btnBoleto"
        btnBoleto.Size = New Size(130, 48)
        btnBoleto.TabIndex = 9
        btnBoleto.Text = "BOLETO"
        btnBoleto.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(642, 304)
        Controls.Add(btnBoleto)
        Controls.Add(btnPersona)
        Controls.Add(btnCliente)
        Controls.Add(btnVendedor)
        Controls.Add(btnViaje)
        Controls.Add(btnBus)
        Controls.Add(btnEmpleado)
        Controls.Add(btnConductor)
        Controls.Add(btnRuta)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnRuta As Button
    Friend WithEvents btnConductor As Button
    Friend WithEvents btnEmpleado As Button
    Friend WithEvents btnBus As Button
    Friend WithEvents btnViaje As Button
    Friend WithEvents btnVendedor As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnPersona As Button
    Friend WithEvents btnBoleto As Button

End Class
