<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPaciente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcodpaciente = New System.Windows.Forms.TextBox()
        Me.btnvolvercita = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtreligion = New System.Windows.Forms.TextBox()
        Me.dtpfechareg = New System.Windows.Forms.DateTimePicker()
        Me.cmbtipodesangre = New System.Windows.Forms.ComboBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtocupacion = New System.Windows.Forms.TextBox()
        Me.dtpfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.lblreligion = New System.Windows.Forms.Label()
        Me.lblfecharegistro = New System.Windows.Forms.Label()
        Me.lbltipodesangre = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblrelacionsentimental = New System.Windows.Forms.Label()
        Me.lblocupacion = New System.Windows.Forms.Label()
        Me.lblfechanacimiento = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.cmbrelacion = New System.Windows.Forms.ComboBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtfechanac = New System.Windows.Forms.TextBox()
        Me.txtfechareg = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbidtiposangre = New System.Windows.Forms.ComboBox()
        Me.cmbidrelacion = New System.Windows.Forms.ComboBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "idpaciente"
        Me.Label1.Visible = False
        '
        'Txtcodpaciente
        '
        Me.Txtcodpaciente.Location = New System.Drawing.Point(133, 36)
        Me.Txtcodpaciente.Name = "Txtcodpaciente"
        Me.Txtcodpaciente.ReadOnly = True
        Me.Txtcodpaciente.Size = New System.Drawing.Size(100, 20)
        Me.Txtcodpaciente.TabIndex = 50
        Me.Txtcodpaciente.Visible = False
        '
        'btnvolvercita
        '
        Me.btnvolvercita.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnvolvercita.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnvolvercita.Location = New System.Drawing.Point(98, 374)
        Me.btnvolvercita.Name = "btnvolvercita"
        Me.btnvolvercita.Size = New System.Drawing.Size(75, 41)
        Me.btnvolvercita.TabIndex = 49
        Me.btnvolvercita.Text = "Regresar "
        Me.btnvolvercita.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(707, 375)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 48
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(486, 368)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(102, 53)
        Me.btningresar.TabIndex = 47
        Me.btningresar.Text = "Actualizar datos del paciente"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'txtreligion
        '
        Me.txtreligion.Location = New System.Drawing.Point(129, 271)
        Me.txtreligion.Name = "txtreligion"
        Me.txtreligion.Size = New System.Drawing.Size(273, 20)
        Me.txtreligion.TabIndex = 46
        '
        'dtpfechareg
        '
        Me.dtpfechareg.Location = New System.Drawing.Point(133, 211)
        Me.dtpfechareg.Name = "dtpfechareg"
        Me.dtpfechareg.Size = New System.Drawing.Size(273, 20)
        Me.dtpfechareg.TabIndex = 45
        '
        'cmbtipodesangre
        '
        Me.cmbtipodesangre.FormattingEnabled = True
        Me.cmbtipodesangre.Location = New System.Drawing.Point(509, 156)
        Me.cmbtipodesangre.Name = "cmbtipodesangre"
        Me.cmbtipodesangre.Size = New System.Drawing.Size(273, 21)
        Me.cmbtipodesangre.TabIndex = 44
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(509, 130)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(273, 20)
        Me.txttelefono.TabIndex = 43
        '
        'txtocupacion
        '
        Me.txtocupacion.Location = New System.Drawing.Point(133, 185)
        Me.txtocupacion.Name = "txtocupacion"
        Me.txtocupacion.Size = New System.Drawing.Size(273, 20)
        Me.txtocupacion.TabIndex = 42
        '
        'dtpfechanacimiento
        '
        Me.dtpfechanacimiento.Location = New System.Drawing.Point(133, 127)
        Me.dtpfechanacimiento.Name = "dtpfechanacimiento"
        Me.dtpfechanacimiento.Size = New System.Drawing.Size(273, 20)
        Me.dtpfechanacimiento.TabIndex = 41
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(509, 74)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(273, 20)
        Me.txtapellido.TabIndex = 40
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(133, 101)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(273, 20)
        Me.txtdireccion.TabIndex = 39
        '
        'lblreligion
        '
        Me.lblreligion.AutoSize = True
        Me.lblreligion.Location = New System.Drawing.Point(20, 274)
        Me.lblreligion.Name = "lblreligion"
        Me.lblreligion.Size = New System.Drawing.Size(45, 13)
        Me.lblreligion.TabIndex = 38
        Me.lblreligion.Text = "Religion"
        '
        'lblfecharegistro
        '
        Me.lblfecharegistro.AutoSize = True
        Me.lblfecharegistro.Location = New System.Drawing.Point(19, 211)
        Me.lblfecharegistro.Name = "lblfecharegistro"
        Me.lblfecharegistro.Size = New System.Drawing.Size(89, 13)
        Me.lblfecharegistro.TabIndex = 37
        Me.lblfecharegistro.Text = "Fecha de registro"
        '
        'lbltipodesangre
        '
        Me.lbltipodesangre.AutoSize = True
        Me.lbltipodesangre.Location = New System.Drawing.Point(428, 159)
        Me.lbltipodesangre.Name = "lbltipodesangre"
        Me.lbltipodesangre.Size = New System.Drawing.Size(78, 13)
        Me.lbltipodesangre.TabIndex = 36
        Me.lbltipodesangre.Text = "Tipo de sangre"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(428, 133)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbltelefono.TabIndex = 35
        Me.lbltelefono.Text = "Telefono"
        '
        'lblrelacionsentimental
        '
        Me.lblrelacionsentimental.AutoSize = True
        Me.lblrelacionsentimental.Location = New System.Drawing.Point(19, 300)
        Me.lblrelacionsentimental.Name = "lblrelacionsentimental"
        Me.lblrelacionsentimental.Size = New System.Drawing.Size(105, 13)
        Me.lblrelacionsentimental.TabIndex = 34
        Me.lblrelacionsentimental.Text = "Relacion sentimental"
        '
        'lblocupacion
        '
        Me.lblocupacion.AutoSize = True
        Me.lblocupacion.Location = New System.Drawing.Point(20, 188)
        Me.lblocupacion.Name = "lblocupacion"
        Me.lblocupacion.Size = New System.Drawing.Size(59, 13)
        Me.lblocupacion.TabIndex = 33
        Me.lblocupacion.Text = "Ocupacion"
        '
        'lblfechanacimiento
        '
        Me.lblfechanacimiento.AutoSize = True
        Me.lblfechanacimiento.Location = New System.Drawing.Point(18, 132)
        Me.lblfechanacimiento.Name = "lblfechanacimiento"
        Me.lblfechanacimiento.Size = New System.Drawing.Size(106, 13)
        Me.lblfechanacimiento.TabIndex = 32
        Me.lblfechanacimiento.Text = "Fecha de nacimiento"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(19, 104)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 31
        Me.lbldireccion.Text = "Direccion"
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(428, 77)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(49, 13)
        Me.lblapellido.TabIndex = 30
        Me.lblapellido.Text = "Apellidos"
        '
        'cmbrelacion
        '
        Me.cmbrelacion.FormattingEnabled = True
        Me.cmbrelacion.Location = New System.Drawing.Point(129, 297)
        Me.cmbrelacion.Name = "cmbrelacion"
        Me.cmbrelacion.Size = New System.Drawing.Size(273, 21)
        Me.cmbrelacion.TabIndex = 29
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(19, 77)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(49, 13)
        Me.lblnombre.TabIndex = 28
        Me.lblnombre.Text = "Nombres"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(133, 75)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(273, 20)
        Me.txtnombre.TabIndex = 27
        '
        'txtfechanac
        '
        Me.txtfechanac.Location = New System.Drawing.Point(133, 152)
        Me.txtfechanac.Name = "txtfechanac"
        Me.txtfechanac.Size = New System.Drawing.Size(100, 20)
        Me.txtfechanac.TabIndex = 52
        Me.txtfechanac.Visible = False
        '
        'txtfechareg
        '
        Me.txtfechareg.Location = New System.Drawing.Point(133, 237)
        Me.txtfechareg.Name = "txtfechareg"
        Me.txtfechareg.Size = New System.Drawing.Size(100, 20)
        Me.txtfechareg.TabIndex = 53
        Me.txtfechareg.Visible = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(129, 335)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(273, 20)
        Me.txtemail.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Correo Electronico"
        '
        'cmbidtiposangre
        '
        Me.cmbidtiposangre.Enabled = False
        Me.cmbidtiposangre.FormattingEnabled = True
        Me.cmbidtiposangre.Location = New System.Drawing.Point(747, 203)
        Me.cmbidtiposangre.Name = "cmbidtiposangre"
        Me.cmbidtiposangre.Size = New System.Drawing.Size(35, 21)
        Me.cmbidtiposangre.TabIndex = 56
        Me.cmbidtiposangre.Visible = False
        '
        'cmbidrelacion
        '
        Me.cmbidrelacion.Enabled = False
        Me.cmbidrelacion.FormattingEnabled = True
        Me.cmbidrelacion.Location = New System.Drawing.Point(431, 300)
        Me.cmbidrelacion.Name = "cmbidrelacion"
        Me.cmbidrelacion.Size = New System.Drawing.Size(41, 21)
        Me.cmbidrelacion.TabIndex = 57
        Me.cmbidrelacion.Visible = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(284, 368)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(102, 53)
        Me.btnnuevo.TabIndex = 58
        Me.btnnuevo.Text = "Ingresar paciente nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'ModificarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.cmbidrelacion)
        Me.Controls.Add(Me.cmbidtiposangre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtfechareg)
        Me.Controls.Add(Me.txtfechanac)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtcodpaciente)
        Me.Controls.Add(Me.btnvolvercita)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtreligion)
        Me.Controls.Add(Me.dtpfechareg)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarPaciente"
        Me.Text = "ModificarPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtcodpaciente As TextBox
    Friend WithEvents btnvolvercita As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btningresar As Button
    Friend WithEvents txtreligion As TextBox
    Friend WithEvents dtpfechareg As DateTimePicker
    Friend WithEvents cmbtipodesangre As ComboBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtocupacion As TextBox
    Friend WithEvents dtpfechanacimiento As DateTimePicker
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents lblreligion As Label
    Friend WithEvents lblfecharegistro As Label
    Friend WithEvents lbltipodesangre As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblrelacionsentimental As Label
    Friend WithEvents lblocupacion As Label
    Friend WithEvents lblfechanacimiento As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblapellido As Label
    Friend WithEvents cmbrelacion As ComboBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtfechanac As TextBox
    Friend WithEvents txtfechareg As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbidtiposangre As ComboBox
    Friend WithEvents cmbidrelacion As ComboBox
    Friend WithEvents btnnuevo As Button
End Class
