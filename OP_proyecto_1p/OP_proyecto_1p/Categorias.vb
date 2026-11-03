Public Class Categorias

    Public Property categ_id As Integer
    Public Property categ_nom As String

    Public Sub New(id As Integer, nombre As String)
        categ_id = id
        categ_nom = nombre
    End Sub


End Class