<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class genreferenciaespecialista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(genreferenciaespecialista))
        Me.fechaemisionselect = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblcausa = New System.Windows.Forms.Label()
        Me.lbldoctor = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.txtcausa = New System.Windows.Forms.RichTextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Causa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.cmbespecialista = New System.Windows.Forms.ComboBox()
        Me.txtcodpaciente = New System.Windows.Forms.TextBox()
        Me.txtcodreferencia = New System.Windows.Forms.TextBox()
        Me.cmbcodigodoctor = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fechaemisionselect
        '
        Me.fechaemisionselect.Location = New System.Drawing.Point(110, 159)
        Me.fechaemisionselect.Name = "fechaemisionselect"
        Me.fechaemisionselect.Size = New System.Drawing.Size(305, 20)
        Me.fechaemisionselect.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Referencias a especialista"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(12, 159)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(90, 13)
        Me.lblfecha.TabIndex = 28
        Me.lblfecha.Text = "Fecha de emision"
        '
        'lblcausa
        '
        Me.lblcausa.AutoSize = True
        Me.lblcausa.Location = New System.Drawing.Point(14, 195)
        Me.lblcausa.Name = "lblcausa"
        Me.lblcausa.Size = New System.Drawing.Size(37, 13)
        Me.lblcausa.TabIndex = 27
        Me.lblcausa.Text = "Causa"
        '
        'lbldoctor
        '
        Me.lbldoctor.AutoSize = True
        Me.lbldoctor.Location = New System.Drawing.Point(12, 117)
        Me.lbldoctor.Name = "lbldoctor"
        Me.lbldoctor.Size = New System.Drawing.Size(39, 13)
        Me.lbldoctor.TabIndex = 26
        Me.lbldoctor.Text = "Doctor"
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(12, 78)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(49, 13)
        Me.lblpaciente.TabIndex = 25
        Me.lblpaciente.Text = "Paciente"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(503, 69)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 23
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'txtcausa
        '
        Me.txtcausa.Location = New System.Drawing.Point(110, 195)
        Me.txtcausa.Name = "txtcausa"
        Me.txtcausa.Size = New System.Drawing.Size(305, 96)
        Me.txtcausa.TabIndex = 33
        Me.txtcausa.Text = ""
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(503, 98)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 34
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doctor, Me.Fecha, Me.Causa})
        Me.DataGridView1.Location = New System.Drawing.Point(47, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(721, 150)
        Me.DataGridView1.TabIndex = 35
        '
        'Doctor
        '
        Me.Doctor.HeaderText = "Doctor"
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Width = 300
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Causa
        '
        Me.Causa.HeaderText = "Causa"
        Me.Causa.Name = "Causa"
        Me.Causa.Width = 275
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Historial Referencias"
        '
        'txtpaciente
        '
        Me.txtpaciente.Location = New System.Drawing.Point(110, 71)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(305, 20)
        Me.txtpaciente.TabIndex = 37
        '
        'cmbespecialista
        '
        Me.cmbespecialista.FormattingEnabled = True
        Me.cmbespecialista.Location = New System.Drawing.Point(110, 109)
        Me.cmbespecialista.Name = "cmbespecialista"
        Me.cmbespecialista.Size = New System.Drawing.Size(305, 21)
        Me.cmbespecialista.TabIndex = 38
        '
        'txtcodpaciente
        '
        Me.txtcodpaciente.Location = New System.Drawing.Point(433, 71)
        Me.txtcodpaciente.Name = "txtcodpaciente"
        Me.txtcodpaciente.Size = New System.Drawing.Size(29, 20)
        Me.txtcodpaciente.TabIndex = 39
        Me.txtcodpaciente.Visible = False
        '
        'txtcodreferencia
        '
        Me.txtcodreferencia.Location = New System.Drawing.Point(12, 26)
        Me.txtcodreferencia.Name = "txtcodreferencia"
        Me.txtcodreferencia.Size = New System.Drawing.Size(23, 20)
        Me.txtcodreferencia.TabIndex = 40
        Me.txtcodreferencia.Visible = False
        '
        'cmbcodigodoctor
        '
        Me.cmbcodigodoctor.FormattingEnabled = True
        Me.cmbcodigodoctor.Location = New System.Drawing.Point(433, 109)
        Me.cmbcodigodoctor.Name = "cmbcodigodoctor"
        Me.cmbcodigodoctor.Size = New System.Drawing.Size(33, 21)
        Me.cmbcodigodoctor.TabIndex = 41
        Me.cmbcodigodoctor.Visible = False
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(433, 159)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 42
        Me.txtfecha.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'genreferenciaespecialista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.cmbcodigodoctor)
        Me.Controls.Add(Me.txtcodreferencia)
        Me.Controls.Add(Me.txtcodpaciente)
        Me.Controls.Add(Me.cmbespecialista)
        Me.Controls.Add(Me.txtpaciente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtcausa)
        Me.Controls.Add(Me.fechaemisionselect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblcausa)
        Me.Controls.Add(Me.lbldoctor)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.btngenerar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "genreferenciaespecialista"
        Me.Text = "genreferenciaespecialista"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fechaemisionselect As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblcausa As Label
    Friend WithEvents lbldoctor As Label
    Friend WithEvents lblpaciente As Label
    Friend WithEvents btngenerar As Button
    Friend WithEvents txtcausa As RichTextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Causa As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents cmbespecialista As ComboBox
    Friend WithEvents txtcodpaciente As TextBox
    Friend WithEvents txtcodreferencia As TextBox
    Friend WithEvents cmbcodigodoctor As ComboBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Button1 As Button
End Class
