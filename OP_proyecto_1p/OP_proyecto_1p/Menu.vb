Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Menu
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        facturacion.MdiParent = Me
        IngresoDatosClientes.MdiParent = Me
        ActualizarCliente.MdiParent = Me
        MostrarFactura.MdiParent = Me
        IngresarProductos.MdiParent = Me
        Actualizar_Producto.MdiParent = Me

    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        facturacion.Show()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized 
    End Sub

    Private Sub DatosClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatosClientesToolStripMenuItem2.Click
        IngresoDatosClientes.Show()
    End Sub

    Private Sub DatosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosClientesToolStripMenuItem.Click
        ActualizarCliente.Show()
    End Sub

    Private Sub DatosClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatosClientesToolStripMenuItem1.Click
        ActualizarCliente.Show()
    End Sub

    Private Sub BuscarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarFacturaToolStripMenuItem.Click
        MostrarFactura.Show()
    End Sub

    Private Sub DatosProductosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DatosProductosToolStripMenuItem2.Click
        IngresarProductos.Show()
    End Sub

    Private Sub DatosProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosProductosToolStripMenuItem.Click
        Actualizar_Producto.Show()
    End Sub

    Private Sub DatosProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DatosProductosToolStripMenuItem1.Click
        Actualizar_Producto.Show()
    End Sub
End Class
