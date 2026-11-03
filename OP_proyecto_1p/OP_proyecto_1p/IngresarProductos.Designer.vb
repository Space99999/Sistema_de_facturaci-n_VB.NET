<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_prod_codigo = New System.Windows.Forms.TextBox()
        Me.txt_prod_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prod_precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prod_stock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ac_btn_salir = New System.Windows.Forms.Button()
        Me.ac_btn_cancelar = New System.Windows.Forms.Button()
        Me.ac_btn_guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'txt_prod_codigo
        '
        Me.txt_prod_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_codigo.Location = New System.Drawing.Point(207, 52)
        Me.txt_prod_codigo.Name = "txt_prod_codigo"
        Me.txt_prod_codigo.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_codigo.TabIndex = 1
        '
        'txt_prod_nombre
        '
        Me.txt_prod_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_nombre.Location = New System.Drawing.Point(207, 98)
        Me.txt_prod_nombre.Name = "txt_prod_nombre"
        Me.txt_prod_nombre.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Producto"
        '
        'txt_prod_precio
        '
        Me.txt_prod_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_precio.Location = New System.Drawing.Point(207, 148)
        Me.txt_prod_precio.Name = "txt_prod_precio"
        Me.txt_prod_precio.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_precio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio"
        '
        'txt_prod_stock
        '
        Me.txt_prod_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_stock.Location = New System.Drawing.Point(207, 199)
        Me.txt_prod_stock.Name = "txt_prod_stock"
        Me.txt_prod_stock.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_stock.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stock"
        '
        'cbo_categorias
        '
        Me.cbo_categorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Location = New System.Drawing.Point(454, 95)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(205, 26)
        Me.cbo_categorias.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Categorias"
        '
        'ac_btn_salir
        '
        Me.ac_btn_salir.Location = New System.Drawing.Point(320, 311)
        Me.ac_btn_salir.Name = "ac_btn_salir"
        Me.ac_btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_salir.TabIndex = 10
        Me.ac_btn_salir.Text = "Salir"
        Me.ac_btn_salir.UseVisualStyleBackColor = True
        '
        'ac_btn_cancelar
        '
        Me.ac_btn_cancelar.Location = New System.Drawing.Point(491, 175)
        Me.ac_btn_cancelar.Name = "ac_btn_cancelar"
        Me.ac_btn_cancelar.Size = New System.Drawing.Size(75, 69)
        Me.ac_btn_cancelar.TabIndex = 11
        Me.ac_btn_cancelar.Text = "Cancelar"
        Me.ac_btn_cancelar.UseVisualStyleBackColor = True
        '
        'ac_btn_guardar
        '
        Me.ac_btn_guardar.Location = New System.Drawing.Point(371, 175)
        Me.ac_btn_guardar.Name = "ac_btn_guardar"
        Me.ac_btn_guardar.Size = New System.Drawing.Size(75, 69)
        Me.ac_btn_guardar.TabIndex = 12
        Me.ac_btn_guardar.Text = "Guardar"
        Me.ac_btn_guardar.UseVisualStyleBackColor = True
        '
        'IngresarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 360)
        Me.Controls.Add(Me.ac_btn_guardar)
        Me.Controls.Add(Me.ac_btn_cancelar)
        Me.Controls.Add(Me.ac_btn_salir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.txt_prod_stock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_prod_precio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prod_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_prod_codigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IngresarProductos"
        Me.Text = "IngresarProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_prod_codigo As TextBox
    Friend WithEvents txt_prod_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_prod_precio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_prod_stock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_categorias As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ac_btn_salir As Button
    Friend WithEvents ac_btn_cancelar As Button
    Friend WithEvents ac_btn_guardar As Button
End Class
