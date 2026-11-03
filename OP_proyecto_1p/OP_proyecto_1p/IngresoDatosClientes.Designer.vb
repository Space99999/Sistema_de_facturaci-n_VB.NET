<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoDatosClientes
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
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_apellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ac_btn_grabar = New System.Windows.Forms.Button()
        Me.ac_btn_Salir = New System.Windows.Forms.Button()
        Me.ac_btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(213, 60)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(164, 20)
        Me.txt_cedula.TabIndex = 1
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(213, 110)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(164, 20)
        Me.txt_nombres.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txt_apellidos
        '
        Me.txt_apellidos.Location = New System.Drawing.Point(213, 167)
        Me.txt_apellidos.Name = "txt_apellidos"
        Me.txt_apellidos.Size = New System.Drawing.Size(164, 20)
        Me.txt_apellidos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(213, 212)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(164, 20)
        Me.txt_direccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(213, 273)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(164, 20)
        Me.txt_telefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono:"
        '
        'ac_btn_grabar
        '
        Me.ac_btn_grabar.Location = New System.Drawing.Point(467, 75)
        Me.ac_btn_grabar.Name = "ac_btn_grabar"
        Me.ac_btn_grabar.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_grabar.TabIndex = 10
        Me.ac_btn_grabar.Text = "Grabar"
        Me.ac_btn_grabar.UseVisualStyleBackColor = True
        '
        'ac_btn_Salir
        '
        Me.ac_btn_Salir.Location = New System.Drawing.Point(467, 256)
        Me.ac_btn_Salir.Name = "ac_btn_Salir"
        Me.ac_btn_Salir.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_Salir.TabIndex = 11
        Me.ac_btn_Salir.Text = "Salir"
        Me.ac_btn_Salir.UseVisualStyleBackColor = True
        '
        'ac_btn_cancelar
        '
        Me.ac_btn_cancelar.Location = New System.Drawing.Point(467, 167)
        Me.ac_btn_cancelar.Name = "ac_btn_cancelar"
        Me.ac_btn_cancelar.Size = New System.Drawing.Size(101, 53)
        Me.ac_btn_cancelar.TabIndex = 12
        Me.ac_btn_cancelar.Text = "Cancelar"
        Me.ac_btn_cancelar.UseVisualStyleBackColor = True
        '
        'IngresoDatosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 384)
        Me.Controls.Add(Me.ac_btn_cancelar)
        Me.Controls.Add(Me.ac_btn_Salir)
        Me.Controls.Add(Me.ac_btn_grabar)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_apellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IngresoDatosClientes"
        Me.Text = "IngresoDatosClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_apellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ac_btn_grabar As Button
    Friend WithEvents ac_btn_Salir As Button
    Friend WithEvents ac_btn_cancelar As Button
End Class
