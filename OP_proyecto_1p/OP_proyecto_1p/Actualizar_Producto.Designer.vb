<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Producto
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ac_btn_buscar = New System.Windows.Forms.Button()
        Me.txt_prod_id_buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.ac_btn_actualizar = New System.Windows.Forms.Button()
        Me.ac_btn_cancelar = New System.Windows.Forms.Button()
        Me.ac_btn_salir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.txt_prod_stock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_prod_precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prod_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prod_codigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ac_btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_prod_id_buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto a Buscar"
        '
        'ac_btn_buscar
        '
        Me.ac_btn_buscar.Location = New System.Drawing.Point(229, 52)
        Me.ac_btn_buscar.Name = "ac_btn_buscar"
        Me.ac_btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_buscar.TabIndex = 2
        Me.ac_btn_buscar.Text = "buscar"
        Me.ac_btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_prod_id_buscar
        '
        Me.txt_prod_id_buscar.Location = New System.Drawing.Point(112, 54)
        Me.txt_prod_id_buscar.Name = "txt_prod_id_buscar"
        Me.txt_prod_id_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_prod_id_buscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto_Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.eliminar)
        Me.GroupBox2.Controls.Add(Me.ac_btn_actualizar)
        Me.GroupBox2.Controls.Add(Me.ac_btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.ac_btn_salir)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbo_categorias)
        Me.GroupBox2.Controls.Add(Me.txt_prod_stock)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_prod_precio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_prod_nombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_prod_codigo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(758, 251)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos a Actualizar"
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(513, 98)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 69)
        Me.eliminar.TabIndex = 39
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'ac_btn_actualizar
        '
        Me.ac_btn_actualizar.Location = New System.Drawing.Point(396, 98)
        Me.ac_btn_actualizar.Name = "ac_btn_actualizar"
        Me.ac_btn_actualizar.Size = New System.Drawing.Size(75, 69)
        Me.ac_btn_actualizar.TabIndex = 38
        Me.ac_btn_actualizar.Text = "Actualizar "
        Me.ac_btn_actualizar.UseVisualStyleBackColor = True
        '
        'ac_btn_cancelar
        '
        Me.ac_btn_cancelar.Location = New System.Drawing.Point(627, 98)
        Me.ac_btn_cancelar.Name = "ac_btn_cancelar"
        Me.ac_btn_cancelar.Size = New System.Drawing.Size(75, 69)
        Me.ac_btn_cancelar.TabIndex = 37
        Me.ac_btn_cancelar.Text = "Cancelar"
        Me.ac_btn_cancelar.UseVisualStyleBackColor = True
        '
        'ac_btn_salir
        '
        Me.ac_btn_salir.Location = New System.Drawing.Point(456, 190)
        Me.ac_btn_salir.Name = "ac_btn_salir"
        Me.ac_btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_salir.TabIndex = 36
        Me.ac_btn_salir.Text = "Salir"
        Me.ac_btn_salir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(391, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Categorias"
        '
        'cbo_categorias
        '
        Me.cbo_categorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Location = New System.Drawing.Point(476, 41)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(205, 26)
        Me.cbo_categorias.TabIndex = 34
        '
        'txt_prod_stock
        '
        Me.txt_prod_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_stock.Location = New System.Drawing.Point(208, 184)
        Me.txt_prod_stock.Name = "txt_prod_stock"
        Me.txt_prod_stock.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_stock.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Stock"
        '
        'txt_prod_precio
        '
        Me.txt_prod_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_precio.Location = New System.Drawing.Point(208, 133)
        Me.txt_prod_precio.Name = "txt_prod_precio"
        Me.txt_prod_precio.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_precio.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Precio"
        '
        'txt_prod_nombre
        '
        Me.txt_prod_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_nombre.Location = New System.Drawing.Point(208, 83)
        Me.txt_prod_nombre.Name = "txt_prod_nombre"
        Me.txt_prod_nombre.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_nombre.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre Producto"
        '
        'txt_prod_codigo
        '
        Me.txt_prod_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod_codigo.Location = New System.Drawing.Point(208, 37)
        Me.txt_prod_codigo.Name = "txt_prod_codigo"
        Me.txt_prod_codigo.Size = New System.Drawing.Size(100, 24)
        Me.txt_prod_codigo.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Código"
        '
        'Actualizar_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 439)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Actualizar_Producto"
        Me.Text = "Actualizar_Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ac_btn_buscar As Button
    Friend WithEvents txt_prod_id_buscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ac_btn_actualizar As Button
    Friend WithEvents ac_btn_cancelar As Button
    Friend WithEvents ac_btn_salir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_categorias As ComboBox
    Friend WithEvents txt_prod_stock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_prod_precio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_prod_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_prod_codigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents eliminar As Button
End Class
