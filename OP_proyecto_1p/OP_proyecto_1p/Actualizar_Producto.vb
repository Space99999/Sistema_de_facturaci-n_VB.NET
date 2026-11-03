Imports System.Data.SqlClient
Public Class Actualizar_Producto
    'Dim miConexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Dim listaCategorias As New List(Of Categorias)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ac_btn_buscar.Click

        retornarDatos()


    End Sub

    Private Sub Actualizar_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaCategorias.Clear()
        'miConexion.abrirConexion()
        miConexion.Open()
        cargarCombo()
    End Sub

    Private Sub ac_btn_actualizar_Click(sender As Object, e As EventArgs) Handles ac_btn_actualizar.Click
        Dim verificador As Integer = 1
        ActualizarEliminar(verificador)
        MsgBox("Se actualizo Correctamente")
        limpiar()
    End Sub

    Private Sub ac_btn_cancelar_Click(sender As Object, e As EventArgs) Handles ac_btn_cancelar.Click
        limpiar()
    End Sub

    Private Sub ac_btn_salir_Click(sender As Object, e As EventArgs) Handles ac_btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cargarCombo()
        Dim r As SqlDataReader
        Dim comando As New SqlCommand("
        select 
        categ_id, categ_nombre
        from Categorias_Prod ", miConexion)
        r = comando.ExecuteReader()
        While r.Read

            Dim categ_id = Integer.Parse(r("categ_id"))
            Dim categ_nombre = r("categ_nombre").ToString()

            Dim objCateg As New Categorias(categ_id, categ_nombre)
            listaCategorias.Add(objCateg)
        End While
        r.Close()
        cbo_categorias.Items.AddRange(listaCategorias.ToArray)
        ' Después de cargar los objetos en la lista listaCategorias

    End Sub

    Public Sub retornarDatos()
        Dim _categ_id As Integer
        If String.IsNullOrEmpty(txt_prod_id_buscar.Text) Then
            MsgBox("Debes ingresar un id")
        Else
            Dim comando As New SqlCommand("select *from Productos where prod_id = " & txt_prod_id_buscar.Text & " ", miConexion)
            Dim r As SqlDataReader
            r = comando.ExecuteReader()
            Dim contador As Integer = 0
            While r.Read
                _categ_id = Integer.Parse(r("categ_id"))
                txt_prod_codigo.Text = r("prod_codigo")
                txt_prod_nombre.Text = r("prod_nombre")
                txt_prod_precio.Text = r("prod_precio")
                txt_prod_stock.Text = r("prod_stock")
                contador = contador + 1
            End While
            r.Close()
            If contador = 0 Then

                MsgBox("Producto no encontrado")
            Else

                cbo_categorias.DataSource = listaCategorias
                cbo_categorias.DisplayMember = "categ_nom"
                For Each item As Categorias In cbo_categorias.Items
                    If item.categ_id = _categ_id Then
                        cbo_categorias.SelectedItem = item
                        Exit For ' Una vez encontrada la categoría, puedes salir del bucle.
                    End If
                Next
            End If


        End If


    End Sub

    Private Sub ActualizarEliminar(verificador As Integer)
        Dim categoriaSeleccionada As Categorias = DirectCast(cbo_categorias.SelectedItem, Categorias)
        Dim idCategoriaSeleccionada As Integer = categoriaSeleccionada.categ_id
        Dim _precio As Decimal = txt_prod_precio.Text
        Dim _stock As Integer = txt_prod_stock.Text
        Dim comando As New SqlCommand("ActualizarEliminarProducto", miConexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@verificador", verificador)
        comando.Parameters.AddWithValue("@prod_id", txt_prod_id_buscar.Text)
        comando.Parameters.AddWithValue("@categ_id", idCategoriaSeleccionada)
        comando.Parameters.AddWithValue("@prod_codigo", txt_prod_codigo.Text)
        comando.Parameters.AddWithValue("@prod_nombre", txt_prod_nombre.Text.ToUpper)
        comando.Parameters.AddWithValue("@prod_precio", _precio)
        comando.Parameters.AddWithValue("@prod_stock", _stock)
        comando.ExecuteNonQuery()

    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim verificador As Integer = 0
        ActualizarEliminar(verificador)
        MsgBox("Se eliminó correctamente")
        limpiar()
    End Sub
    Private Sub limpiar()
        txt_prod_id_buscar.Text = ""
        txt_prod_codigo.Text = ""
        txt_prod_nombre.Text = ""
        txt_prod_precio.Text = ""
        txt_prod_stock.Text = ""
    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        'MsgBox("Se cerro la conexion de la base de datos ")
    End Sub
End Class