<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarlaboratorio
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregarlaboratorio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblespecialidad = New System.Windows.Forms.Label()
        Me.lbllaboratorio = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombrelab = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreLaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccionlaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoLaboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidlaboratorio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ingreso de laboratorio"
        '
        'lblespecialidad
        '
        Me.lblespecialidad.AutoSize = True
        Me.lblespecialidad.Location = New System.Drawing.Point(236, 193)
        Me.lblespecialidad.Name = "lblespecialidad"
        Me.lblespecialidad.Size = New System.Drawing.Size(49, 13)
        Me.lblespecialidad.TabIndex = 17
        Me.lblespecialidad.Text = "Telefono"
        '
        'lbllaboratorio
        '
        Me.lbllaboratorio.AutoSize = True
        Me.lbllaboratorio.Location = New System.Drawing.Point(236, 167)
        Me.lbllaboratorio.Name = "lbllaboratorio"
        Me.lbllaboratorio.Size = New System.Drawing.Size(52, 13)
        Me.lbllaboratorio.TabIndex = 16
        Me.lbllaboratorio.Text = "Direccion"
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(236, 141)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(96, 13)
        Me.lblpaciente.TabIndex = 15
        Me.lblpaciente.Text = "Nombre laboratorio"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(338, 193)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(243, 20)
        Me.txttelefono.TabIndex = 13
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(338, 167)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(243, 20)
        Me.txtdireccion.TabIndex = 12
        '
        'txtnombrelab
        '
        Me.txtnombrelab.Location = New System.Drawing.Point(338, 141)
        Me.txtnombrelab.Name = "txtnombrelab"
        Me.txtnombrelab.Size = New System.Drawing.Size(243, 20)
        Me.txtnombrelab.TabIndex = 11
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(682, 141)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 10
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(682, 184)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 20
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreLaboratorio, Me.Direccionlaboratorio, Me.TelefonoLaboratorio})
        Me.DataGridView1.Location = New System.Drawing.Point(116, 317)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(652, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'NombreLaboratorio
        '
        Me.NombreLaboratorio.HeaderText = "Nombre del laboratorio"
        Me.NombreLaboratorio.Name = "NombreLaboratorio"
        Me.NombreLaboratorio.Width = 225
        '
        'Direccionlaboratorio
        '
        Me.Direccionlaboratorio.HeaderText = "Direccion del laboratorio"
        Me.Direccionlaboratorio.Name = "Direccionlaboratorio"
        Me.Direccionlaboratorio.Width = 275
        '
        'TelefonoLaboratorio
        '
        Me.TelefonoLaboratorio.HeaderText = "Telefono del laboratorio"
        Me.TelefonoLaboratorio.Name = "TelefonoLaboratorio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Laboratorios  Registrados"
        '
        'txtidlaboratorio
        '
        Me.txtidlaboratorio.Location = New System.Drawing.Point(26, 12)
        Me.txtidlaboratorio.Name = "txtidlaboratorio"
        Me.txtidlaboratorio.Size = New System.Drawing.Size(44, 20)
        Me.txtidlaboratorio.TabIndex = 23
        Me.txtidlaboratorio.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'agregarlaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(847, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtidlaboratorio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblespecialidad)
        Me.Controls.Add(Me.lbllaboratorio)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnombrelab)
        Me.Controls.Add(Me.btnagregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agregarlaboratorio"
        Me.Text = "agregarlaboratorio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents lblespecialidad As Label
	Friend WithEvents lbllaboratorio As Label
	Friend WithEvents lblpaciente As Label
	Friend WithEvents txttelefono As TextBox
	Friend WithEvents txtdireccion As TextBox
	Friend WithEvents txtnombrelab As TextBox
	Friend WithEvents btnagregar As Button
	Friend WithEvents btnlimpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidlaboratorio As TextBox
    Friend WithEvents NombreLaboratorio As DataGridViewTextBoxColumn
    Friend WithEvents Direccionlaboratorio As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoLaboratorio As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
