<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosProductosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.BuscarFacturaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosClientesToolStripMenuItem2, Me.DatosProductosToolStripMenuItem2})
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'DatosClientesToolStripMenuItem2
        '
        Me.DatosClientesToolStripMenuItem2.Name = "DatosClientesToolStripMenuItem2"
        Me.DatosClientesToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.DatosClientesToolStripMenuItem2.Text = "Datos Clientes"
        '
        'DatosProductosToolStripMenuItem2
        '
        Me.DatosProductosToolStripMenuItem2.Name = "DatosProductosToolStripMenuItem2"
        Me.DatosProductosToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.DatosProductosToolStripMenuItem2.Text = "Datos Productos"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosClientesToolStripMenuItem, Me.DatosProductosToolStripMenuItem})
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'DatosClientesToolStripMenuItem
        '
        Me.DatosClientesToolStripMenuItem.Name = "DatosClientesToolStripMenuItem"
        Me.DatosClientesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DatosClientesToolStripMenuItem.Text = "Datos Clientes"
        '
        'DatosProductosToolStripMenuItem
        '
        Me.DatosProductosToolStripMenuItem.Name = "DatosProductosToolStripMenuItem"
        Me.DatosProductosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DatosProductosToolStripMenuItem.Text = "Datos Productos"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosClientesToolStripMenuItem1, Me.DatosProductosToolStripMenuItem1})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'DatosClientesToolStripMenuItem1
        '
        Me.DatosClientesToolStripMenuItem1.Name = "DatosClientesToolStripMenuItem1"
        Me.DatosClientesToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.DatosClientesToolStripMenuItem1.Text = "Datos Clientes"
        '
        'DatosProductosToolStripMenuItem1
        '
        Me.DatosProductosToolStripMenuItem1.Name = "DatosProductosToolStripMenuItem1"
        Me.DatosProductosToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.DatosProductosToolStripMenuItem1.Text = "Datos Productos"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'BuscarFacturaToolStripMenuItem
        '
        Me.BuscarFacturaToolStripMenuItem.Name = "BuscarFacturaToolStripMenuItem"
        Me.BuscarFacturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscarFacturaToolStripMenuItem.Text = "Buscar Factura"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 519)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "SISTEMA DE FACTURACION"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosClientesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DatosProductosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DatosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DatosProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BuscarFacturaToolStripMenuItem As ToolStripMenuItem
End Class
