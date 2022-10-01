<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificaranalergias
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
        Me.Modidanaler = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modidpac = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Moddescri = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Modmedi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Antecedente de Alergia"
        '
        'Modidanaler
        '
        Me.Modidanaler.FormattingEnabled = True
        Me.Modidanaler.Location = New System.Drawing.Point(302, 74)
        Me.Modidanaler.Name = "Modidanaler"
        Me.Modidanaler.Size = New System.Drawing.Size(76, 21)
        Me.Modidanaler.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID paciente"
        '
        'Modidpac
        '
        Me.Modidpac.FormattingEnabled = True
        Me.Modidpac.Location = New System.Drawing.Point(302, 117)
        Me.Modidpac.Name = "Modidpac"
        Me.Modidpac.Size = New System.Drawing.Size(76, 21)
        Me.Modidpac.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'Moddescri
        '
        Me.Moddescri.Location = New System.Drawing.Point(302, 166)
        Me.Moddescri.Multiline = True
        Me.Moddescri.Name = "Moddescri"
        Me.Moddescri.Size = New System.Drawing.Size(296, 107)
        Me.Moddescri.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Medicamentos"
        '
        'Modmedi
        '
        Me.Modmedi.Location = New System.Drawing.Point(302, 291)
        Me.Modmedi.Multiline = True
        Me.Modmedi.Name = "Modmedi"
        Me.Modmedi.Size = New System.Drawing.Size(296, 110)
        Me.Modmedi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(464, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Modificar Antecedentes Alergias"
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(250, 443)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(75, 50)
        Me.Btningresar.TabIndex = 9
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(416, 523)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 50)
        Me.Btnregresar.TabIndex = 10
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(546, 443)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 50)
        Me.Btnlimpiar.TabIndex = 11
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Modificaranalergias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Modmedi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Moddescri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Modidpac)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Modidanaler)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Modificaranalergias"
        Me.Text = "Modificaranalergias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Modidanaler As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Modidpac As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Moddescri As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Modmedi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btningresar As Button
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Btnlimpiar As Button
End Class
