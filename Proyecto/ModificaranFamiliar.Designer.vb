<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaranFamiliar
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
        Me.ModIdanfam = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Antecedente Familiar"
        '
        'ModIdanfam
        '
        Me.ModIdanfam.FormattingEnabled = True
        Me.ModIdanfam.Location = New System.Drawing.Point(269, 69)
        Me.ModIdanfam.Name = "ModIdanfam"
        Me.ModIdanfam.Size = New System.Drawing.Size(73, 21)
        Me.ModIdanfam.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(269, 113)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(73, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(269, 162)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(339, 114)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(497, 33)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Modificar Antecedentes Familiares"
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(228, 298)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(75, 55)
        Me.Btningresar.TabIndex = 7
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(497, 298)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 54)
        Me.Btnlimpiar.TabIndex = 8
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(375, 365)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 53)
        Me.Btnregresar.TabIndex = 9
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'ModificaranFamiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ModIdanfam)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificaranFamiliar"
        Me.Text = "ModificaranFamiliar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ModIdanfam As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btningresar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnregresar As Button
End Class
