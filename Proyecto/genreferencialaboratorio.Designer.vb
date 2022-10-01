<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class genreferencialaboratorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genreferencialaboratorio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lbllaboratorio = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.fechaemisionselect = New System.Windows.Forms.DateTimePicker()
        Me.cmblaboratorio = New System.Windows.Forms.ComboBox()
        Me.txtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.txtcodpaciente = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Cmbcodigolabs = New System.Windows.Forms.ComboBox()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Laboratorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcodreferencia = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Referencias laboratorio"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(23, 260)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(90, 13)
        Me.lblfecha.TabIndex = 18
        Me.lblfecha.Text = "Fecha de emision"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(20, 159)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 17
        Me.lbldescripcion.Text = "Descripcion"
        '
        'lbllaboratorio
        '
        Me.lbllaboratorio.AutoSize = True
        Me.lbllaboratorio.Location = New System.Drawing.Point(23, 95)
        Me.lbllaboratorio.Name = "lbllaboratorio"
        Me.lbllaboratorio.Size = New System.Drawing.Size(60, 13)
        Me.lbllaboratorio.TabIndex = 16
        Me.lbllaboratorio.Text = "Laboratorio"
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(23, 69)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(49, 13)
        Me.lblpaciente.TabIndex = 15
        Me.lblpaciente.Text = "Paciente"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(571, 69)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 10
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'fechaemisionselect
        '
        Me.fechaemisionselect.Location = New System.Drawing.Point(143, 260)
        Me.fechaemisionselect.Name = "fechaemisionselect"
        Me.fechaemisionselect.Size = New System.Drawing.Size(305, 20)
        Me.fechaemisionselect.TabIndex = 20
        '
        'cmblaboratorio
        '
        Me.cmblaboratorio.FormattingEnabled = True
        Me.cmblaboratorio.Location = New System.Drawing.Point(143, 87)
        Me.cmblaboratorio.Name = "cmblaboratorio"
        Me.cmblaboratorio.Size = New System.Drawing.Size(305, 21)
        Me.cmblaboratorio.TabIndex = 21
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(143, 121)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(305, 96)
        Me.txtdescripcion.TabIndex = 23
        Me.txtdescripcion.Text = ""
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(571, 119)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 24
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'txtcodpaciente
        '
        Me.txtcodpaciente.Location = New System.Drawing.Point(454, 61)
        Me.txtcodpaciente.Name = "txtcodpaciente"
        Me.txtcodpaciente.Size = New System.Drawing.Size(100, 20)
        Me.txtcodpaciente.TabIndex = 25
        Me.txtcodpaciente.Visible = False
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(454, 260)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 26
        Me.txtfecha.Visible = False
        '
        'Cmbcodigolabs
        '
        Me.Cmbcodigolabs.FormattingEnabled = True
        Me.Cmbcodigolabs.Location = New System.Drawing.Point(454, 87)
        Me.Cmbcodigolabs.Name = "Cmbcodigolabs"
        Me.Cmbcodigolabs.Size = New System.Drawing.Size(57, 21)
        Me.Cmbcodigolabs.TabIndex = 27
        Me.Cmbcodigolabs.Visible = False
        '
        'txtpaciente
        '
        Me.txtpaciente.Location = New System.Drawing.Point(143, 61)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(305, 20)
        Me.txtpaciente.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Laboratorio, Me.Descripcion, Me.FechaEmision})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 318)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'Laboratorio
        '
        Me.Laboratorio.HeaderText = "Laboratorio"
        Me.Laboratorio.Name = "Laboratorio"
        Me.Laboratorio.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 400
        '
        'FechaEmision
        '
        Me.FechaEmision.HeaderText = "Fecha de emision"
        Me.FechaEmision.Name = "FechaEmision"
        '
        'txtcodreferencia
        '
        Me.txtcodreferencia.Location = New System.Drawing.Point(142, 12)
        Me.txtcodreferencia.Name = "txtcodreferencia"
        Me.txtcodreferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtcodreferencia.TabIndex = 30
        Me.txtcodreferencia.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'genreferencialaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcodreferencia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtpaciente)
        Me.Controls.Add(Me.Cmbcodigolabs)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtcodpaciente)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.cmblaboratorio)
        Me.Controls.Add(Me.fechaemisionselect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.lbllaboratorio)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.btngenerar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "genreferencialaboratorio"
        Me.Text = "genreferencialaboratorio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents lblfecha As Label
	Friend WithEvents lbldescripcion As Label
	Friend WithEvents lbllaboratorio As Label
	Friend WithEvents lblpaciente As Label
	Friend WithEvents btngenerar As Button
	Friend WithEvents fechaemisionselect As DateTimePicker
	Friend WithEvents cmblaboratorio As ComboBox
    Friend WithEvents txtdescripcion As RichTextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtcodpaciente As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Cmbcodigolabs As ComboBox
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Laboratorio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEmision As DataGridViewTextBoxColumn
    Friend WithEvents txtcodreferencia As TextBox
    Friend WithEvents Button1 As Button
End Class
