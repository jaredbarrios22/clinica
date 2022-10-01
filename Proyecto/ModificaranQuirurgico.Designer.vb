<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaranQuirurgico
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
        Me.Modcodantecedentequi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modidpac = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Moddescriop = New System.Windows.Forms.TextBox()
        Me.Modfechaop = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Modcodantecedentequi
        '
        Me.Modcodantecedentequi.FormattingEnabled = True
        Me.Modcodantecedentequi.Location = New System.Drawing.Point(307, 75)
        Me.Modcodantecedentequi.Name = "Modcodantecedentequi"
        Me.Modcodantecedentequi.Size = New System.Drawing.Size(88, 21)
        Me.Modcodantecedentequi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo del antecedente "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Paciente"
        '
        'Modidpac
        '
        Me.Modidpac.FormattingEnabled = True
        Me.Modidpac.Location = New System.Drawing.Point(307, 106)
        Me.Modidpac.Name = "Modidpac"
        Me.Modidpac.Size = New System.Drawing.Size(88, 21)
        Me.Modidpac.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion de Operación"
        '
        'Moddescriop
        '
        Me.Moddescriop.Location = New System.Drawing.Point(307, 139)
        Me.Moddescriop.Multiline = True
        Me.Moddescriop.Name = "Moddescriop"
        Me.Moddescriop.Size = New System.Drawing.Size(413, 70)
        Me.Moddescriop.TabIndex = 5
        '
        'Modfechaop
        '
        Me.Modfechaop.Location = New System.Drawing.Point(307, 231)
        Me.Modfechaop.Name = "Modfechaop"
        Me.Modfechaop.Size = New System.Drawing.Size(217, 20)
        Me.Modfechaop.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Operación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(462, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Modificar Antecentes Quirurgico"
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(222, 312)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(75, 57)
        Me.Btningresar.TabIndex = 9
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(459, 312)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 57)
        Me.Btnlimpiar.TabIndex = 10
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(355, 376)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 64)
        Me.Btnregresar.TabIndex = 11
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'ModificaranQuirurgico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 468)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Modfechaop)
        Me.Controls.Add(Me.Moddescriop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Modidpac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Modcodantecedentequi)
        Me.Name = "ModificaranQuirurgico"
        Me.Text = "ModificaranQuirurgico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Modcodantecedentequi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Modidpac As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Moddescriop As TextBox
    Friend WithEvents Modfechaop As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btningresar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnregresar As Button
End Class
