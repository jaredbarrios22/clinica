<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresopaciente
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
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.cmbrelacion = New System.Windows.Forms.ComboBox()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblfechanacimiento = New System.Windows.Forms.Label()
        Me.lblocupacion = New System.Windows.Forms.Label()
        Me.lblrelacionsentimental = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lbltipodesangre = New System.Windows.Forms.Label()
        Me.lblfecharegistro = New System.Windows.Forms.Label()
        Me.lblreligion = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.dtpfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtocupacion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.cmbtipodesangre = New System.Windows.Forms.ComboBox()
        Me.btpfechareg = New System.Windows.Forms.DateTimePicker()
        Me.txtreligion = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnvolvercita = New System.Windows.Forms.Button()
        Me.Txtcodpaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(125, 86)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(273, 20)
        Me.txtnombre.TabIndex = 0
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(11, 88)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(49, 13)
        Me.lblnombre.TabIndex = 1
        Me.lblnombre.Text = "Nombres"
        '
        'cmbrelacion
        '
        Me.cmbrelacion.FormattingEnabled = True
        Me.cmbrelacion.Location = New System.Drawing.Point(125, 269)
        Me.cmbrelacion.Name = "cmbrelacion"
        Me.cmbrelacion.Size = New System.Drawing.Size(273, 21)
        Me.cmbrelacion.TabIndex = 2
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(420, 88)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(49, 13)
        Me.lblapellido.TabIndex = 3
        Me.lblapellido.Text = "Apellidos"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(11, 115)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 4
        Me.lbldireccion.Text = "Direccion"
        '
        'lblfechanacimiento
        '
        Me.lblfechanacimiento.AutoSize = True
        Me.lblfechanacimiento.Location = New System.Drawing.Point(10, 143)
        Me.lblfechanacimiento.Name = "lblfechanacimiento"
        Me.lblfechanacimiento.Size = New System.Drawing.Size(106, 13)
        Me.lblfechanacimiento.TabIndex = 5
        Me.lblfechanacimiento.Text = "Fecha de nacimiento"
        '
        'lblocupacion
        '
        Me.lblocupacion.AutoSize = True
        Me.lblocupacion.Location = New System.Drawing.Point(11, 167)
        Me.lblocupacion.Name = "lblocupacion"
        Me.lblocupacion.Size = New System.Drawing.Size(59, 13)
        Me.lblocupacion.TabIndex = 6
        Me.lblocupacion.Text = "Ocupacion"
        '
        'lblrelacionsentimental
        '
        Me.lblrelacionsentimental.AutoSize = True
        Me.lblrelacionsentimental.Location = New System.Drawing.Point(10, 277)
        Me.lblrelacionsentimental.Name = "lblrelacionsentimental"
        Me.lblrelacionsentimental.Size = New System.Drawing.Size(105, 13)
        Me.lblrelacionsentimental.TabIndex = 7
        Me.lblrelacionsentimental.Text = "Relacion sentimental"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(420, 144)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbltelefono.TabIndex = 8
        Me.lbltelefono.Text = "Telefono"
        '
        'lbltipodesangre
        '
        Me.lbltipodesangre.AutoSize = True
        Me.lbltipodesangre.Location = New System.Drawing.Point(420, 170)
        Me.lbltipodesangre.Name = "lbltipodesangre"
        Me.lbltipodesangre.Size = New System.Drawing.Size(78, 13)
        Me.lbltipodesangre.TabIndex = 9
        Me.lbltipodesangre.Text = "Tipo de sangre"
        '
        'lblfecharegistro
        '
        Me.lblfecharegistro.AutoSize = True
        Me.lblfecharegistro.Location = New System.Drawing.Point(10, 210)
        Me.lblfecharegistro.Name = "lblfecharegistro"
        Me.lblfecharegistro.Size = New System.Drawing.Size(89, 13)
        Me.lblfecharegistro.TabIndex = 10
        Me.lblfecharegistro.Text = "Fecha de registro"
        '
        'lblreligion
        '
        Me.lblreligion.AutoSize = True
        Me.lblreligion.Location = New System.Drawing.Point(11, 243)
        Me.lblreligion.Name = "lblreligion"
        Me.lblreligion.Size = New System.Drawing.Size(45, 13)
        Me.lblreligion.TabIndex = 11
        Me.lblreligion.Text = "Religion"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(125, 112)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(273, 20)
        Me.txtdireccion.TabIndex = 13
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(501, 85)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(273, 20)
        Me.txtapellido.TabIndex = 14
        '
        'dtpfechanacimiento
        '
        Me.dtpfechanacimiento.Location = New System.Drawing.Point(125, 138)
        Me.dtpfechanacimiento.Name = "dtpfechanacimiento"
        Me.dtpfechanacimiento.Size = New System.Drawing.Size(273, 20)
        Me.dtpfechanacimiento.TabIndex = 15
        '
        'txtocupacion
        '
        Me.txtocupacion.Location = New System.Drawing.Point(125, 164)
        Me.txtocupacion.Name = "txtocupacion"
        Me.txtocupacion.Size = New System.Drawing.Size(273, 20)
        Me.txtocupacion.TabIndex = 16
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(501, 141)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(273, 20)
        Me.txttelefono.TabIndex = 17
        '
        'cmbtipodesangre
        '
        Me.cmbtipodesangre.FormattingEnabled = True
        Me.cmbtipodesangre.Location = New System.Drawing.Point(501, 167)
        Me.cmbtipodesangre.Name = "cmbtipodesangre"
        Me.cmbtipodesangre.Size = New System.Drawing.Size(273, 21)
        Me.cmbtipodesangre.TabIndex = 18
        '
        'btpfechareg
        '
        Me.btpfechareg.Location = New System.Drawing.Point(125, 203)
        Me.btpfechareg.Name = "btpfechareg"
        Me.btpfechareg.Size = New System.Drawing.Size(273, 20)
        Me.btpfechareg.TabIndex = 19
        '
        'txtreligion
        '
        Me.txtreligion.Location = New System.Drawing.Point(125, 236)
        Me.txtreligion.Name = "txtreligion"
        Me.txtreligion.Size = New System.Drawing.Size(273, 20)
        Me.txtreligion.TabIndex = 20
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(378, 386)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 22
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(699, 386)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 23
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnvolvercita
        '
        Me.btnvolvercita.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnvolvercita.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnvolvercita.Location = New System.Drawing.Point(90, 385)
        Me.btnvolvercita.Name = "btnvolvercita"
        Me.btnvolvercita.Size = New System.Drawing.Size(75, 41)
        Me.btnvolvercita.TabIndex = 24
        Me.btnvolvercita.Text = "Regresar a Cita"
        Me.btnvolvercita.UseVisualStyleBackColor = False
        '
        'Txtcodpaciente
        '
        Me.Txtcodpaciente.Location = New System.Drawing.Point(125, 47)
        Me.Txtcodpaciente.Name = "Txtcodpaciente"
        Me.Txtcodpaciente.Size = New System.Drawing.Size(100, 20)
        Me.Txtcodpaciente.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "idpaciente"
        '
        'ingresopaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtcodpaciente)
        Me.Controls.Add(Me.btnvolvercita)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtreligion)
        Me.Controls.Add(Me.btpfechareg)
        Me.Controls.Add(Me.cmbtipodesangre)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtocupacion)
        Me.Controls.Add(Me.dtpfechanacimiento)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.lblreligion)
        Me.Controls.Add(Me.lblfecharegistro)
        Me.Controls.Add(Me.lbltipodesangre)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lblrelacionsentimental)
        Me.Controls.Add(Me.lblocupacion)
        Me.Controls.Add(Me.lblfechanacimiento)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.cmbrelacion)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtnombre)
        Me.Name = "ingresopaciente"
        Me.Text = "ingreso nuevo paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents cmbrelacion As ComboBox
    Friend WithEvents lblapellido As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblfechanacimiento As Label
    Friend WithEvents lblocupacion As Label
    Friend WithEvents lblrelacionsentimental As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lbltipodesangre As Label
    Friend WithEvents lblfecharegistro As Label
    Friend WithEvents lblreligion As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents dtpfechanacimiento As DateTimePicker
    Friend WithEvents txtocupacion As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents cmbtipodesangre As ComboBox
    Friend WithEvents btpfechareg As DateTimePicker
    Friend WithEvents txtreligion As TextBox
    Friend WithEvents btningresar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnvolvercita As Button
    Friend WithEvents Txtcodpaciente As TextBox
    Friend WithEvents Label1 As Label
End Class
