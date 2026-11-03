Public Class DetFactTabla
    Public Property det_id As Integer
    Public Property cabe_id As Integer
    Public Property prod_id As Integer
    Public Property codProd As String
    Public Property nomProd As String
    Public Property det_cantidad As Integer
    Public Property det_precio As Decimal
    Public Property det_subTotal As Decimal
    Public Property det_iva As Decimal
    Public Property det_total As Decimal

    Public Sub New(det_id As Integer, cabe_id As Integer, prod_id As Integer, codProd As String, nomProd As String, det_cantidad As Integer, det_precio As Decimal, det_subTotal As Decimal, det_iva As Decimal, det_total As Decimal)
        Me.det_id = det_id
        Me.cabe_id = cabe_id
        Me.prod_id = prod_id
        Me.codProd = codProd
        Me.nomProd = nomProd
        Me.det_cantidad = det_cantidad
        Me.det_precio = det_precio
        Me.det_subTotal = det_subTotal
        Me.det_iva = det_iva
        Me.det_total = det_total
    End Sub


End Class
