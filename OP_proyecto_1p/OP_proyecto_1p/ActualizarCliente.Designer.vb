<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarCliente
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
        Me.ac_btn_eliminar = New System.Windows.Forms.Button()
        Me.ac_btn_Salir = New System.Windows.Forms.Button()
        Me.ac_btn_actualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ac_btn_buscar = New System.Windows.Forms.Button()
        Me.txt_cliente_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ac_btn_eliminar
        '
        Me.ac_btn_eliminar.Location = New System.Drawing.Point(487, 237)
        Me.ac_btn_eliminar.Name = "ac_btn_eliminar"
        Me.ac_btn_eliminar.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_eliminar.TabIndex = 25
        Me.ac_btn_eliminar.Text = "Eliminar"
        Me.ac_btn_eliminar.UseVisualStyleBackColor = True
        '
        'ac_btn_Salir
        '
        Me.ac_btn_Salir.Location = New System.Drawing.Point(487, 326)
        Me.ac_btn_Salir.Name = "ac_btn_Salir"
        Me.ac_btn_Salir.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_Salir.TabIndex = 24
        Me.ac_btn_Salir.Text = "Salir"
        Me.ac_btn_Salir.UseVisualStyleBackColor = True
        '
        'ac_btn_actualizar
        '
        Me.ac_btn_actualizar.Location = New System.Drawing.Point(487, 145)
        Me.ac_btn_actualizar.Name = "ac_btn_actualizar"
        Me.ac_btn_actualizar.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_actualizar.TabIndex = 23
        Me.ac_btn_actualizar.Text = "Actualizar"
        Me.ac_btn_actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_apellidos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 280)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(184, 248)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(164, 20)
        Me.txt_telefono.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Teléfono:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(184, 187)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(164, 20)
        Me.txt_direccion.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Dirección:"
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(184, 140)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(164, 20)
        Me.txt_apellidos.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apellido:"
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(184, 83)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(164, 20)
        Me.txt_nombres.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(184, 33)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(164, 20)
        Me.txt_cedula.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cédula:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ac_btn_buscar)
        Me.GroupBox2.Controls.Add(Me.txt_cliente_id)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 57)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar"
        '
        'ac_btn_buscar
        '
        Me.ac_btn_buscar.Location = New System.Drawing.Point(343, 15)
        Me.ac_btn_buscar.Name = "ac_btn_buscar"
        Me.ac_btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.ac_btn_buscar.TabIndex = 30
        Me.ac_btn_buscar.Text = "Buscar"
        Me.ac_btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_cliente_id
        '
        Me.txt_cliente_id.Location = New System.Drawing.Point(139, 19)
        Me.txt_cliente_id.Name = "txt_cliente_id"
        Me.txt_cliente_id.Size = New System.Drawing.Size(164, 20)
        Me.txt_cliente_id.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "ID Cliente"
        '
        'ActualizarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 439)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ac_btn_eliminar)
        Me.Controls.Add(Me.ac_btn_Salir)
        Me.Controls.Add(Me.ac_btn_actualizar)
        Me.Name = "ActualizarCliente"
        Me.Text = "ActualizarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ac_btn_eliminar As Button
    Friend WithEvents ac_btn_Salir As Button
    Friend WithEvents ac_btn_actualizar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ac_btn_buscar As Button
    Friend WithEvents txt_cliente_id As TextBox
    Friend WithEvents Label6 As Label
End Class
