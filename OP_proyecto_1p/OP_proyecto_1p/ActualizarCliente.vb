Imports System.Data.SqlClient
Public Class ActualizarCliente
    'Dim miconexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Private Sub ActualizarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' miconexion.abrirConexion()
        miConexion.Open()
    End Sub

    Private Sub ac_btn_actualizar_Click(sender As Object, e As EventArgs) Handles ac_btn_actualizar.Click
        Dim verificador As Integer = 1
        ActualizarEliminarCliente(verificador)
        MsgBox("Se Actulizo correctamente los datos")
        limpiarDatos()

    End Sub

    Private Sub ac_btn_eliminar_Click(sender As Object, e As EventArgs) Handles ac_btn_eliminar.Click
        Dim verificador As Integer = 0
        ActualizarEliminarCliente(verificador)
        MsgBox("Se eliminó Correctamente los Datos")
        limpiarDatos()
    End Sub

    Private Sub ac_btn_Salir_Click(sender As Object, e As EventArgs) Handles ac_btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub ac_btn_buscar_Click(sender As Object, e As EventArgs) Handles ac_btn_buscar.Click

        Dim adaptador As New SqlDataAdapter("Select * from Cliente where cli_id = " & txt_cliente_id.Text & "", miConexion)

        Dim ds As New DataSet
        adaptador.Fill(ds, "tabla")
        If ds.Tables("tabla").Rows.Count > 0 Then
            txt_cedula.Text = ds.Tables("tabla").Rows(0).Item(1).ToString
            txt_nombres.Text = ds.Tables("tabla").Rows(0).Item(2).ToString
            txt_apellidos.Text = ds.Tables("tabla").Rows(0).Item(3).ToString
            txt_direccion.Text = ds.Tables("tabla").Rows(0).Item(4).ToString
            txt_telefono.Text = ds.Tables("tabla").Rows(0).Item(5).ToString

        Else
            MsgBox("CODIGO NO ENCONTRADO")

        End If

    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        ' MsgBox("Se cerro la conexion de la base de datos ")
    End Sub

    Private Sub ActualizarEliminarCliente(verificador As Integer)
        Dim _cli_id As Integer = Integer.Parse(txt_cliente_id.Text)
        Dim comando As New SqlCommand("ActualizarEliminarCliente", miConexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@verificador", verificador)
        comando.Parameters.AddWithValue("@cli_id", _cli_id)
        comando.Parameters.AddWithValue("@cli_cedula", txt_cedula.Text.ToUpper)
        comando.Parameters.AddWithValue("@cli_nombre", txt_nombres.Text.ToUpper)
        comando.Parameters.AddWithValue("@cli_apellido", txt_apellidos.Text.ToUpper)
        comando.Parameters.AddWithValue("@cli_direccion", txt_direccion.Text.ToUpper)
        comando.Parameters.AddWithValue("@cli_telefono", txt_telefono.Text.ToUpper)
        comando.ExecuteNonQuery()


    End Sub
    Private Sub limpiarDatos()
        txt_cliente_id.Text = ""
        txt_cedula.Text = ""
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
    End Sub
End Class