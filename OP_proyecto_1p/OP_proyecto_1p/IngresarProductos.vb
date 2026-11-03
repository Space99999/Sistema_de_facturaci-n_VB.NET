Imports System.Data.SqlClient
Public Class IngresarProductos
    Dim listaCategorias As New List(Of Categorias)
    ' Dim miConexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Private Sub IngresarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    miConexion.abrirConexion()
        miConexion.Open()
        cargarCombo()

    End Sub
    Private Sub ac_btn_guardar_Click(sender As Object, e As EventArgs) Handles ac_btn_guardar.Click
        guardarProducto()
    End Sub
    Public Sub cargarCombo()
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
        cbo_categorias.DataSource = listaCategorias
        cbo_categorias.DisplayMember = "categ_nom"
    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        '' MsgBox("Se cerro la conexion de la base de datos ")
    End Sub

    Private Sub cbo_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categorias.SelectedIndexChanged

    End Sub

    Private Sub ac_btn_salir_Click(sender As Object, e As EventArgs) Handles ac_btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardarProducto()

        Try

            If cbo_categorias.SelectedItem IsNot Nothing Then
                Dim objetoSeleccionado As Categorias = DirectCast(cbo_categorias.SelectedItem, Categorias)
                Dim categ_id As Integer = objetoSeleccionado.categ_id
                Dim insertar As New SqlCommand("insert into Productos Values(" & categ_id & ", '" & txt_prod_codigo.Text.ToUpper & "',
                '" & txt_prod_nombre.Text & "', " & txt_prod_precio.Text & ", " & txt_prod_stock.Text & " )", miConexion)
                insertar.ExecuteNonQuery()
                MsgBox("Se guardo con exito la información")
                limpiar()
            Else

            End If

        Catch ex As Exception
            MsgBox("error: " & ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        txt_prod_codigo.Text = ""
        txt_prod_nombre.Text = ""
        txt_prod_precio.Text = ""
        txt_prod_stock.Text = ""
    End Sub

    Private Sub ac_btn_cancelar_Click(sender As Object, e As EventArgs) Handles ac_btn_cancelar.Click
        limpiar()

    End Sub
End Class