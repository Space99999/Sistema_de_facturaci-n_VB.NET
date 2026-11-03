Imports System.Data.SqlClient
Public Class MostrarFactura
    'Dim miConexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ac_btn_buscarFact_Click(sender As Object, e As EventArgs) Handles ac_btn_buscarFact.Click
        DatosCabecera()
        DatosDetalle()
        Limpiar()

    End Sub

    Private Sub MostrarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'miConexion.abrirConexion()
        miConexion.Open()
    End Sub

    Private Sub DatosCabecera()
        Try
            Dim adaptador As New SqlDataAdapter("
            select 
            cab.cabe_fecha,cab.cabe_iva,cab.cabe_subTotal,cab.cabe_total, 
            cli.cli_cedula,cli_nombres,cli.cli_apellidos,
            cli.cli_direccion, cli.cli_telefono
            From 
            Cabecera_Factura cab inner join Cliente cli
            on cab.cli_id = cli.cli_id
            where cabe_numfac = " & txt_numFact_Buscar.Text & "
            ", miConexion)

            Dim ds As New DataSet
            adaptador.Fill(ds, "tabla")
            If ds.Tables("tabla").Rows.Count > 0 Then
                txt_fecha_Emision.Text = ds.Tables("tabla").Rows(0).Item(0).ToString
                txt_valorIva.Text = ds.Tables("tabla").Rows(0).Item(1).ToString
                txt_subTotal.Text = ds.Tables("tabla").Rows(0).Item(2).ToString
                txt_totalPagar.Text = ds.Tables("tabla").Rows(0).Item(3).ToString

                txt_cedula.Text = ds.Tables("tabla").Rows(0).Item(4).ToString
                txt_nombre.Text = ds.Tables("tabla").Rows(0).Item(5).ToString
                txt_apellido.Text = ds.Tables("tabla").Rows(0).Item(6).ToString
                txt_direccion.Text = ds.Tables("tabla").Rows(0).Item(7).ToString
                txt_telefono.Text = ds.Tables("tabla").Rows(0).Item(8).ToString
                txt_numFact.Text = txt_numFact_Buscar.Text
            Else
                MsgBox("FACTURA NO ENCONTRADA")

            End If
        Catch ex As Exception
            MsgBox("Debes Ingresar un valor")

        End Try
    End Sub
    Private Sub DatosDetalle()
        Dim r As SqlDataReader
        Dim DT As New DataTable
        DT.Columns.Add("Código")
        DT.Columns.Add("Producto")
        DT.Columns.Add("Cantidad")
        DT.Columns.Add("Precio")
        DT.Columns.Add("Sub Total")
        DT.Columns.Add("Total")
        DT.Rows.Clear() 'limpia el grid para cada nueva carga de datos'
        Dim comando As New SqlCommand("
        select
        prod.prod_codigo, prod.prod_nombre, det.det_cantidad, det.det_precio,
        det.det_subtotal, det.det_total
        from
        Cabecera_Factura cab inner join Detalle_factura det on 
        cab.cabe_id = det.cabe_id 
        inner join Cliente cli on cli.cli_id = cab.cli_id
        inner join Productos prod on prod.prod_id = det.prod_id
        where cab.cabe_numfac = " & txt_numFact_Buscar.Text & "", miConexion)
        r = comando.ExecuteReader
        While r.Read
            DT.Rows.Add(r.Item("prod_codigo"), r.Item("prod_nombre"), r.Item("det_cantidad"),
                        r.Item("det_precio"), r.Item("det_subtotal"), r.Item("det_total"))
        End While
        r.Close()
        det_factura.DataSource = DT
        det_factura.Columns("Código").Width = 140
        det_factura.Columns("Producto").Width = 259
        det_factura.Columns("Cantidad").Width = 100
        det_factura.Columns("Precio").Width = 90
        det_factura.Columns("Sub Total").Width = 100
        det_factura.Columns("Total").Width = 100
    End Sub
    Public Sub Limpiar()
        txt_numFact_Buscar.Text = ""
        txt_numFact.Enabled = False
    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        'MsgBox("Se cerro la conexion de la base de datos ")
    End Sub
End Class