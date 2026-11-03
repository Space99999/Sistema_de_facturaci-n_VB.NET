Imports System.Data.SqlClient
Public Class IngresoDatosClientes
    'Private miconexion As New Conexion()
    Dim miConexion As New SqlConnection(My.Settings.cadena)
    Private Sub IngresoDatosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'miconexion.abrirConexion()
        miConexion.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ac_btn_grabar.Click
        If String.IsNullOrEmpty(txt_cedula.Text) Or
   String.IsNullOrEmpty(txt_nombres.Text) Or
   String.IsNullOrEmpty(txt_apellidos.Text) Or
   String.IsNullOrEmpty(txt_direccion.Text) Or
   String.IsNullOrEmpty(txt_telefono.Text) Then
            MsgBox("Debes llenar todos los campos")
        Else
            Try
                Dim adaptador As New SqlCommand("Insert into Cliente values( '" & txt_cedula.Text & "','" & txt_nombres.Text.ToUpper & "',
        '" & txt_apellidos.Text.ToUpper & "', '" & txt_direccion.Text.ToUpper & "', '" & txt_telefono.Text & "')", miConexion)

                adaptador.ExecuteNonQuery()
                MsgBox("Se guardo con exito la informacion")
                limpiarDatos()
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub ac_btn_cancelar_Click(sender As Object, e As EventArgs) Handles ac_btn_cancelar.Click
        limpiarDatos()
    End Sub

    Private Sub ac_btn_Salir_Click(sender As Object, e As EventArgs) Handles ac_btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub limpiarDatos()
        txt_cedula.Text = ""
        txt_nombres.Text = ""
        txt_apellidos.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
    End Sub
    Private Sub frmSecundario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        miConexion.Close()
        'MsgBox("Se cerro la conexion de la base de datos ")
    End Sub

    Private Sub txt_cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula.TextChanged

    End Sub
End Class