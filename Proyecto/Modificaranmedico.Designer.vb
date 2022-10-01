<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificaranmedico
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
        Me.Modidanmed = New System.Windows.Forms.ComboBox()
        Me.Modidpac = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Moddesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Antecedente Medico"
        '
        'Modidanmed
        '
        Me.Modidanmed.FormattingEnabled = True
        Me.Modidanmed.Location = New System.Drawing.Point(296, 64)
        Me.Modidanmed.Name = "Modidanmed"
        Me.Modidanmed.Size = New System.Drawing.Size(82, 21)
        Me.Modidanmed.TabIndex = 1
        '
        'Modidpac
        '
        Me.Modidpac.FormattingEnabled = True
        Me.Modidpac.Location = New System.Drawing.Point(296, 108)
        Me.Modidpac.Name = "Modidpac"
        Me.Modidpac.Size = New System.Drawing.Size(82, 21)
        Me.Modidpac.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'Moddesc
        '
        Me.Moddesc.Location = New System.Drawing.Point(296, 149)
        Me.Moddesc.Multiline = True
        Me.Moddesc.Name = "Moddesc"
        Me.Moddesc.Size = New System.Drawing.Size(254, 99)
        Me.Moddesc.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Medicamento de Enfermedad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(296, 281)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 106)
        Me.TextBox1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(466, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Modificar Antecedentes Medicos"
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(225, 424)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(75, 54)
        Me.Btningresar.TabIndex = 9
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(525, 424)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 54)
        Me.Btnlimpiar.TabIndex = 10
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(397, 497)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 48)
        Me.Btnregresar.TabIndex = 11
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Modificaranmedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 606)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Moddesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Modidpac)
        Me.Controls.Add(Me.Modidanmed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Modificaranmedico"
        Me.Text = "Modificaranmedico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Modidanmed As ComboBox
    Friend WithEvents Modidpac As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Moddesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btningresar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnregresar As Button
End Class
