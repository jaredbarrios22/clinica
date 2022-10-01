<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExaFisico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExaFisico))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImpresionClinica = New System.Windows.Forms.TextBox()
        Me.txtUltrasonido = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtidexamen = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nombre del Paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Peso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Agregar Examen Fisico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Impresion Clinica"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ultrasonido"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(151, 146)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(160, 20)
        Me.txtPeso.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "lbs."
        '
        'txtImpresionClinica
        '
        Me.txtImpresionClinica.Location = New System.Drawing.Point(151, 186)
        Me.txtImpresionClinica.Multiline = True
        Me.txtImpresionClinica.Name = "txtImpresionClinica"
        Me.txtImpresionClinica.Size = New System.Drawing.Size(315, 93)
        Me.txtImpresionClinica.TabIndex = 24
        '
        'txtUltrasonido
        '
        Me.txtUltrasonido.Location = New System.Drawing.Point(151, 303)
        Me.txtUltrasonido.Multiline = True
        Me.txtUltrasonido.Name = "txtUltrasonido"
        Me.txtUltrasonido.Size = New System.Drawing.Size(315, 52)
        Me.txtUltrasonido.TabIndex = 26
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(349, 401)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 30
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(226, 457)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(81, 39)
        Me.btnRegresar.TabIndex = 29
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(108, 401)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 37)
        Me.btnIngresar.TabIndex = 28
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(142, 98)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(229, 20)
        Me.txtnombre.TabIndex = 31
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(454, 99)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(51, 20)
        Me.txtcod.TabIndex = 32
        Me.txtcod.Visible = False
        '
        'txtidexamen
        '
        Me.txtidexamen.Location = New System.Drawing.Point(454, 43)
        Me.txtidexamen.Name = "txtidexamen"
        Me.txtidexamen.Size = New System.Drawing.Size(51, 20)
        Me.txtidexamen.TabIndex = 33
        Me.txtidexamen.Visible = False
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(226, 401)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(85, 37)
        Me.btnactualizar.TabIndex = 34
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'AddExaFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 518)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.txtidexamen)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtUltrasonido)
        Me.Controls.Add(Me.txtImpresionClinica)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddExaFisico"
        Me.Text = "Examen Fisico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtImpresionClinica As TextBox
    Friend WithEvents txtUltrasonido As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtidexamen As TextBox
    Friend WithEvents btnactualizar As Button
End Class
