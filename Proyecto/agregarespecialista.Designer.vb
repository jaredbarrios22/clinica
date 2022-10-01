<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarespecialista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agregarespecialista))
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtespecialidad = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblespecialidad = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtiddoctor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(485, 115)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 0
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(197, 125)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(215, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(197, 151)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(215, 20)
        Me.txtapellido.TabIndex = 2
        '
        'txtespecialidad
        '
        Me.txtespecialidad.Location = New System.Drawing.Point(197, 177)
        Me.txtespecialidad.Name = "txtespecialidad"
        Me.txtespecialidad.Size = New System.Drawing.Size(215, 20)
        Me.txtespecialidad.TabIndex = 3
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(197, 203)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(215, 20)
        Me.txttelefono.TabIndex = 4
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(123, 125)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Nombre"
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(123, 151)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(44, 13)
        Me.lblapellido.TabIndex = 6
        Me.lblapellido.Text = "Apellido"
        '
        'lblespecialidad
        '
        Me.lblespecialidad.AutoSize = True
        Me.lblespecialidad.Location = New System.Drawing.Point(123, 177)
        Me.lblespecialidad.Name = "lblespecialidad"
        Me.lblespecialidad.Size = New System.Drawing.Size(67, 13)
        Me.lblespecialidad.TabIndex = 7
        Me.lblespecialidad.Text = "Especialidad"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(123, 203)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbltelefono.TabIndex = 8
        Me.lbltelefono.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Especialistas"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(485, 151)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.Especialidad, Me.Telefono})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 150
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 150
        '
        'Especialidad
        '
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.Width = 150
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Especialistas Registrados"
        '
        'txtiddoctor
        '
        Me.txtiddoctor.Location = New System.Drawing.Point(40, 32)
        Me.txtiddoctor.Name = "txtiddoctor"
        Me.txtiddoctor.Size = New System.Drawing.Size(38, 20)
        Me.txtiddoctor.TabIndex = 15
        Me.txtiddoctor.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'agregarespecialista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtiddoctor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lblespecialidad)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtespecialidad)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btnagregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agregarespecialista"
        Me.Text = "agregarespecialista"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnagregar As Button
	Friend WithEvents txtnombre As TextBox
	Friend WithEvents txtapellido As TextBox
	Friend WithEvents txtespecialidad As TextBox
	Friend WithEvents txttelefono As TextBox
	Friend WithEvents lblnombre As Label
	Friend WithEvents lblapellido As Label
	Friend WithEvents lblespecialidad As Label
	Friend WithEvents lbltelefono As Label
	Friend WithEvents Label1 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtiddoctor As TextBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
