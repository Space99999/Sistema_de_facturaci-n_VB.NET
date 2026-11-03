<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturacion
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
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ac_btn_buscaCedula = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nud_cantidadProd = New System.Windows.Forms.NumericUpDown()
        Me.txt_codProd = New System.Windows.Forms.TextBox()
        Me.ac_btn_agregarDetProd = New System.Windows.Forms.Button()
        Me.txt_Cantidad = New System.Windows.Forms.Label()
        Me.txt_stock_prod = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nomProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ac_btn_buscarProd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DetalleProd = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ac_btn_salir = New System.Windows.Forms.Button()
        Me.dtp_fecha_emision = New System.Windows.Forms.DateTimePicker()
        Me.ac_btn_cancelar = New System.Windows.Forms.Button()
        Me.ac_btn_grabarFac = New System.Windows.Forms.Button()
        Me.txt_cab_totalPagar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cab_valorIva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cab_subTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nud_cantidadProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ac_btn_buscaCedula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(650, 37)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(111, 20)
        Me.txt_apellido.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(597, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(436, 37)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'ac_btn_buscaCedula
        '
        Me.ac_btn_buscaCedula.Location = New System.Drawing.Point(237, 31)
        Me.ac_btn_buscaCedula.Name = "ac_btn_buscaCedula"
        Me.ac_btn_buscaCedula.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_buscaCedula.TabIndex = 2
        Me.ac_btn_buscaCedula.Text = "Buscar"
        Me.ac_btn_buscaCedula.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cedula:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(121, 33)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(100, 20)
        Me.txt_cedula.TabIndex = 0
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nud_cantidadProd)
        Me.GroupBox2.Controls.Add(Me.txt_codProd)
        Me.GroupBox2.Controls.Add(Me.ac_btn_agregarDetProd)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.txt_stock_prod)
        Me.GroupBox2.Controls.Add(Me.txt_stock)
        Me.GroupBox2.Controls.Add(Me.txt_precio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_nomProd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ac_btn_buscarProd)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(859, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'nud_cantidadProd
        '
        Me.nud_cantidadProd.Location = New System.Drawing.Point(391, 73)
        Me.nud_cantidadProd.Name = "nud_cantidadProd"
        Me.nud_cantidadProd.Size = New System.Drawing.Size(120, 20)
        Me.nud_cantidadProd.TabIndex = 13
        '
        'txt_codProd
        '
        Me.txt_codProd.Location = New System.Drawing.Point(179, 31)
        Me.txt_codProd.Name = "txt_codProd"
        Me.txt_codProd.Size = New System.Drawing.Size(107, 20)
        Me.txt_codProd.TabIndex = 12
        '
        'ac_btn_agregarDetProd
        '
        Me.ac_btn_agregarDetProd.Location = New System.Drawing.Point(589, 71)
        Me.ac_btn_agregarDetProd.Name = "ac_btn_agregarDetProd"
        Me.ac_btn_agregarDetProd.Size = New System.Drawing.Size(98, 23)
        Me.ac_btn_agregarDetProd.TabIndex = 11
        Me.ac_btn_agregarDetProd.Text = "+ Agregar"
        Me.ac_btn_agregarDetProd.UseVisualStyleBackColor = True
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.AutoSize = True
        Me.txt_Cantidad.Location = New System.Drawing.Point(336, 76)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.txt_Cantidad.TabIndex = 9
        Me.txt_Cantidad.Text = "Cantidad"
        '
        'txt_stock_prod
        '
        Me.txt_stock_prod.Location = New System.Drawing.Point(179, 73)
        Me.txt_stock_prod.Name = "txt_stock_prod"
        Me.txt_stock_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_stock_prod.TabIndex = 8
        '
        'txt_stock
        '
        Me.txt_stock.AutoSize = True
        Me.txt_stock.Location = New System.Drawing.Point(130, 76)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(43, 13)
        Me.txt_stock.TabIndex = 7
        Me.txt_stock.Text = "STOCK"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(712, 30)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(667, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio"
        '
        'txt_nomProd
        '
        Me.txt_nomProd.Location = New System.Drawing.Point(513, 30)
        Me.txt_nomProd.Name = "txt_nomProd"
        Me.txt_nomProd.Size = New System.Drawing.Size(133, 20)
        Me.txt_nomProd.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre Del Producto"
        '
        'ac_btn_buscarProd
        '
        Me.ac_btn_buscarProd.Location = New System.Drawing.Point(293, 28)
        Me.ac_btn_buscarProd.Name = "ac_btn_buscarProd"
        Me.ac_btn_buscarProd.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_buscarProd.TabIndex = 2
        Me.ac_btn_buscarProd.Text = "Buscar"
        Me.ac_btn_buscarProd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Codigo Del Producto"
        '
        'DetalleProd
        '
        Me.DetalleProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleProd.Location = New System.Drawing.Point(39, 290)
        Me.DetalleProd.Name = "DetalleProd"
        Me.DetalleProd.Size = New System.Drawing.Size(836, 150)
        Me.DetalleProd.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ac_btn_salir)
        Me.GroupBox3.Controls.Add(Me.dtp_fecha_emision)
        Me.GroupBox3.Controls.Add(Me.ac_btn_cancelar)
        Me.GroupBox3.Controls.Add(Me.ac_btn_grabarFac)
        Me.GroupBox3.Controls.Add(Me.txt_cab_totalPagar)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_cab_valorIva)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_cab_subTotal)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 463)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(859, 115)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Venta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(259, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Fecha Emisión"
        '
        'ac_btn_salir
        '
        Me.ac_btn_salir.Location = New System.Drawing.Point(764, 32)
        Me.ac_btn_salir.Name = "ac_btn_salir"
        Me.ac_btn_salir.Size = New System.Drawing.Size(89, 64)
        Me.ac_btn_salir.TabIndex = 9
        Me.ac_btn_salir.Text = "Salir"
        Me.ac_btn_salir.UseVisualStyleBackColor = True
        '
        'dtp_fecha_emision
        '
        Me.dtp_fecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_emision.Location = New System.Drawing.Point(353, 70)
        Me.dtp_fecha_emision.Name = "dtp_fecha_emision"
        Me.dtp_fecha_emision.Size = New System.Drawing.Size(123, 20)
        Me.dtp_fecha_emision.TabIndex = 8
        '
        'ac_btn_cancelar
        '
        Me.ac_btn_cancelar.Location = New System.Drawing.Point(646, 32)
        Me.ac_btn_cancelar.Name = "ac_btn_cancelar"
        Me.ac_btn_cancelar.Size = New System.Drawing.Size(89, 64)
        Me.ac_btn_cancelar.TabIndex = 7
        Me.ac_btn_cancelar.Text = "Cancelar"
        Me.ac_btn_cancelar.UseVisualStyleBackColor = True
        '
        'ac_btn_grabarFac
        '
        Me.ac_btn_grabarFac.Location = New System.Drawing.Point(513, 32)
        Me.ac_btn_grabarFac.Name = "ac_btn_grabarFac"
        Me.ac_btn_grabarFac.Size = New System.Drawing.Size(91, 64)
        Me.ac_btn_grabarFac.TabIndex = 6
        Me.ac_btn_grabarFac.Text = "Grabar"
        Me.ac_btn_grabarFac.UseVisualStyleBackColor = True
        '
        'txt_cab_totalPagar
        '
        Me.txt_cab_totalPagar.Location = New System.Drawing.Point(353, 29)
        Me.txt_cab_totalPagar.Name = "txt_cab_totalPagar"
        Me.txt_cab_totalPagar.Size = New System.Drawing.Size(100, 20)
        Me.txt_cab_totalPagar.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Total a Pagar"
        '
        'txt_cab_valorIva
        '
        Me.txt_cab_valorIva.Location = New System.Drawing.Point(98, 76)
        Me.txt_cab_valorIva.Name = "txt_cab_valorIva"
        Me.txt_cab_valorIva.Size = New System.Drawing.Size(100, 20)
        Me.txt_cab_valorIva.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Valor Iva"
        '
        'txt_cab_subTotal
        '
        Me.txt_cab_subTotal.Location = New System.Drawing.Point(98, 32)
        Me.txt_cab_subTotal.Name = "txt_cab_subTotal"
        Me.txt_cab_subTotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_cab_subTotal.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sub Total"
        '
        'facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 601)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DetalleProd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "facturacion"
        Me.Text = "Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nud_cantidadProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents ac_btn_buscaCedula As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ac_btn_agregarDetProd As Button
    Friend WithEvents txt_Cantidad As Label
    Friend WithEvents txt_stock_prod As TextBox
    Friend WithEvents txt_stock As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nomProd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ac_btn_buscarProd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DetalleProd As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ac_btn_salir As Button
    Friend WithEvents dtp_fecha_emision As DateTimePicker
    Friend WithEvents ac_btn_cancelar As Button
    Friend WithEvents ac_btn_grabarFac As Button
    Friend WithEvents txt_cab_totalPagar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cab_valorIva As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cab_subTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_codProd As TextBox
    Friend WithEvents nud_cantidadProd As NumericUpDown
End Class
