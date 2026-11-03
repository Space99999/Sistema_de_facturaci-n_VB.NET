Imports System.Data.SqlClient
Public Class facturacion
    'Private miConexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Dim listaDetTabla As New List(Of DetFactTabla)
    Private DT As New DataTable
    Private cli_id As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula.TextChanged

    End Sub

    Private Sub ac_btn_buscaCedula_Click(sender As Object, e As EventArgs) Handles ac_btn_buscaCedula.Click


        Try
            ' Abrir la conexión
            ' miConexion.abrirConexion()

            Dim adaptador As New SqlDataAdapter("Select * from Cliente where cli_cedula = " & txt_cedula.Text & "", miConexion)

            Dim ds As New DataSet
            adaptador.Fill(ds, "tabla")
            If ds.Tables("tabla").Rows.Count > 0 Then
                txt_nombre.Text = ds.Tables("tabla").Rows(0).Item(2).ToString
                txt_apellido.Text = ds.Tables("tabla").Rows(0).Item(3).ToString
                cli_id = Integer.Parse(ds.Tables("tabla").Rows(0).Item(0).ToString)

            Else
                MsgBox("CÉDULA NO ENCONTRADA")

            End If
        Catch ex As Exception
            MsgBox("Debes Ingresar un valor")

        End Try
    End Sub

    Private Sub facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        miConexion.Open()

        DT.Columns.Add("Código Producto")
        DT.Columns.Add("Producto")
        DT.Columns.Add("Precio")
        DT.Columns.Add("Catidad")
        DT.Columns.Add("Sub Total")
        DT.Columns.Add("Total")

        DetalleProd.DataSource = DT
        ' Establecer el ancho de las columnas del DataGridView
        DetalleProd.Columns("Código Producto").Width = 140
        DetalleProd.Columns("Producto").Width = 259
        DetalleProd.Columns("Precio").Width = 100
        DetalleProd.Columns("Catidad").Width = 90
        DetalleProd.Columns("Sub Total").Width = 100
        DetalleProd.Columns("Total").Width = 100
        dtp_fecha_emision.Enabled = False
        txt_cab_subTotal.Enabled = False
        txt_cab_totalPagar.Enabled = False
        txt_cab_valorIva.Enabled = False
        txt_nomProd.Enabled = False
        txt_precio.Enabled = False
        txt_stock_prod.Enabled = False


    End Sub



    Private Sub DetalleProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleProd.CellContentClick

    End Sub

    Private Sub ac_btn_buscarProd_Click(sender As Object, e As EventArgs) Handles ac_btn_buscarProd.Click

        Try
            'miConexion.abrirConexion()
            Dim adaptador As New SqlDataAdapter("Select * from Productos where prod_codigo = '" & txt_codProd.Text & "'", miConexion)

            Dim ds As New DataSet
            adaptador.Fill(ds, "tabla")
            If ds.Tables("tabla").Rows.Count > 0 Then
                txt_nomProd.Text = ds.Tables("tabla").Rows(0).Item(3).ToString
                txt_precio.Text = ds.Tables("tabla").Rows(0).Item(4).ToString
                txt_stock_prod.Text = ds.Tables("tabla").Rows(0).Item(5).ToString



            Else
                MsgBox("Producto no encontrado")

            End If
        Catch ex As Exception
            MsgBox("error:" & ex.Message)

        End Try
    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        ' MsgBox("Se cerro la conexion de la base de datos ")
    End Sub

    Private Sub txt_codProd_TextChanged(sender As Object, e As EventArgs) Handles txt_codProd.TextChanged

    End Sub

    Private Sub AgregarDetalleTabla()
        Try
            Dim codigoBuscar As String
            codigoBuscar = txt_codProd.Text
            Dim cantidad As Integer
            cantidad = nud_cantidadProd.Value
            If (cantidad > 0) Then
                Dim procedimientoAlm As New SqlCommand("CalcularDetFactxProd", miConexion)
                procedimientoAlm.CommandType = CommandType.StoredProcedure
                procedimientoAlm.Parameters.AddWithValue("@Cantidad", cantidad)
                procedimientoAlm.Parameters.AddWithValue("@Cod_Prod", codigoBuscar)
                procedimientoAlm.ExecuteNonQuery()
                MsgBox("Procedimiento Almacenado ejecutado con exito")
                Dim reader As SqlDataReader = procedimientoAlm.ExecuteReader()
                While reader.Read
                    Dim det_id As Integer = 0
                    Dim cabe_id As Integer = 0
                    Dim prod_id As Integer = reader("Producto_id")
                    Dim nomProd As String = reader("Nombre")
                    Dim det_precio As Decimal = Convert.ToDecimal(reader("Precio"))
                    Dim det_subTotal As Decimal = Convert.ToDecimal(reader("Subtotal"))
                    Dim det_iva As Decimal = Convert.ToDecimal(reader("PrecioIva"))
                    Dim det_total As Decimal = Convert.ToDecimal(reader("Total"))

                    Dim objDetFact As New DetFactTabla(det_id, cabe_id, prod_id, codigoBuscar, nomProd,
                    cantidad, det_precio, det_subTotal, det_iva, det_total)
                    listaDetTabla.Add(objDetFact)

                End While
                reader.Close()

            Else
                MsgBox("la cantidad No puede ser cero")
            End If


        Catch ex As Exception
            MsgBox("Algo Fallo")
        End Try
    End Sub

    Private Sub ac_btn_agregarDetProd_Click(sender As Object, e As EventArgs) Handles ac_btn_agregarDetProd.Click
        AgregarDetalleTabla()

        DT.Rows.Clear()

        For Each objDet As DetFactTabla In listaDetTabla

            Dim nuevaFila As DataRow = DT.NewRow()
            nuevaFila("Código Producto") = objDet.codProd
            nuevaFila("Producto") = objDet.nomProd
            nuevaFila("Precio") = objDet.det_precio
            nuevaFila("Catidad") = objDet.det_cantidad
            nuevaFila("Sub Total") = objDet.det_subTotal
            nuevaFila("Total") = objDet.det_total
            ' Asigna los atributos necesarios a las columnas correspondientes
            DT.Rows.Add(nuevaFila)

        Next
        AgregarCabecera()
        limpiarAlAgg()

    End Sub

    Private Sub AgregarCabecera()
        Dim subTotalPagar As Decimal = 0
        Dim ivaTotalPagar As Decimal = 0
        Dim totalPagar As Decimal = 0

        For Each objDet As DetFactTabla In listaDetTabla
            subTotalPagar = subTotalPagar + objDet.det_subTotal
            ivaTotalPagar = ivaTotalPagar + objDet.det_iva
            totalPagar = totalPagar + objDet.det_total
        Next

        txt_cab_subTotal.Text = subTotalPagar
        txt_cab_valorIva.Text = ivaTotalPagar
        txt_cab_totalPagar.Text = totalPagar
    End Sub

    Private Sub limpiarAlAgg()
        txt_codProd.Text = ""
        txt_nomProd.Text = ""
        txt_precio.Text = ""
        txt_stock_prod.Text = ""
        nud_cantidadProd.Value = 0
    End Sub

    Private Function AgregarCabeceraFactura() As Boolean

        Try
            Dim _fechaEmision As Date = dtp_fecha_emision.Value
            Dim _subTotalPagar As Decimal = Decimal.Parse(txt_cab_subTotal.Text)
            Dim _ivaTotalPagar As Decimal = Decimal.Parse(txt_cab_valorIva.Text)
            Dim _totalPagar As Decimal = Decimal.Parse(txt_cab_totalPagar.Text)

            Dim SPagregarCab As New SqlCommand("CrearCabeceraFactura", miConexion)
            SPagregarCab.CommandType = CommandType.StoredProcedure
            SPagregarCab.Parameters.AddWithValue("@cli_id", cli_id)
            SPagregarCab.Parameters.AddWithValue("@cabe_fecha", _fechaEmision)
            SPagregarCab.Parameters.AddWithValue("@cabe_subTotal", _subTotalPagar)
            SPagregarCab.Parameters.AddWithValue("@cabe_iva", _ivaTotalPagar)
            SPagregarCab.Parameters.AddWithValue("@cabe_total", _totalPagar)
            SPagregarCab.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("error" & ex.Message)
            Return False
        End Try
    End Function

    Private Function AgregarDetalleFactura() As Boolean
        Try
            For Each objDet As DetFactTabla In listaDetTabla
                Dim SPagregarDetFact As New SqlCommand("CrearDetalleFactura", miConexion)
                SPagregarDetFact.CommandType = CommandType.StoredProcedure
                SPagregarDetFact.Parameters.AddWithValue("@prod_id", objDet.prod_id)
                SPagregarDetFact.Parameters.AddWithValue("@det_cantidad", objDet.det_cantidad)
                SPagregarDetFact.Parameters.AddWithValue("@det_precio", objDet.det_precio)

                SPagregarDetFact.Parameters.AddWithValue("@det_subtotal", objDet.det_subTotal)
                SPagregarDetFact.Parameters.AddWithValue("@det_iva", objDet.det_iva)
                SPagregarDetFact.Parameters.AddWithValue("@det_total", objDet.det_total)
                SPagregarDetFact.ExecuteNonQuery()

            Next
            Return True
        Catch ex As Exception
            MsgBox("error" & ex.Message)
            Return False
        End Try
    End Function

    Private Sub ac_btn_grabarFac_Click(sender As Object, e As EventArgs) Handles ac_btn_grabarFac.Click
        If AgregarCabeceraFactura() = True Then

            If AgregarDetalleFactura() Then
                MsgBox("La factura se ejecuto con exito")
                listaDetTabla.Clear()
                cli_id = 0
                txt_codProd.Text = ""
                txt_cedula.Text = ""
                DT.Rows.Clear()
            Else
                MsgBox("Ocurrio un problema al guardar el detalle de la Factura ")
            End If


        Else
            MsgBox("Ocurrio un problema al guardar la cabecera de la fcatura")
        End If
    End Sub

    Private Sub ac_btn_salir_Click(sender As Object, e As EventArgs) Handles ac_btn_salir.Click
        listaDetTabla.Clear()
        cli_id = 0
        txt_codProd.Text = ""
        txt_cedula.Text = ""
        DT.Rows.Clear()
        Me.Close()

    End Sub
End Class