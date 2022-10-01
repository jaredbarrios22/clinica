<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitaExpress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CitaExpress))
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbpaciente = New System.Windows.Forms.ComboBox()
        Me.cmbidpaciente = New System.Windows.Forms.ComboBox()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.Txtfecha = New System.Windows.Forms.TextBox()
        Me.Btningresocitape = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(171, 66)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 0
        Me.txtcodigo.Visible = False
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(171, 203)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtapellidos.TabIndex = 1
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(171, 123)
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(100, 20)
        Me.txtnombres.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(339, 290)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpfecha.TabIndex = 7
        Me.dtpfecha.Value = New Date(2020, 11, 3, 0, 0, 0, 0)
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(115, 351)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(96, 45)
        Me.Btningresar.TabIndex = 8
        Me.Btningresar.Text = "Ingresar Cita Paciente Nuevo"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(445, 362)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 9
        Me.btnlimpiar.Text = "Limpiar pantalla"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnregresar
        '
        Me.btnregresar.Location = New System.Drawing.Point(284, 362)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 10
        Me.btnregresar.Text = "Regresar"
        Me.btnregresar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Paciente Nuevo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Paciente Registrado"
        '
        'cmbpaciente
        '
        Me.cmbpaciente.FormattingEnabled = True
        Me.cmbpaciente.Location = New System.Drawing.Point(470, 55)
        Me.cmbpaciente.Name = "cmbpaciente"
        Me.cmbpaciente.Size = New System.Drawing.Size(191, 21)
        Me.cmbpaciente.TabIndex = 13
        '
        'cmbidpaciente
        '
        Me.cmbidpaciente.FormattingEnabled = True
        Me.cmbidpaciente.Location = New System.Drawing.Point(667, 55)
        Me.cmbidpaciente.Name = "cmbidpaciente"
        Me.cmbidpaciente.Size = New System.Drawing.Size(121, 21)
        Me.cmbidpaciente.TabIndex = 14
        Me.cmbidpaciente.Visible = False
        '
        'txtidcita
        '
        Me.txtidcita.Enabled = False
        Me.txtidcita.Location = New System.Drawing.Point(667, 97)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(100, 20)
        Me.txtidcita.TabIndex = 15
        Me.txtidcita.Visible = False
        '
        'Txtfecha
        '
        Me.Txtfecha.Enabled = False
        Me.Txtfecha.Location = New System.Drawing.Point(515, 97)
        Me.Txtfecha.Name = "Txtfecha"
        Me.Txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.Txtfecha.TabIndex = 16
        Me.Txtfecha.Visible = False
        '
        'Btningresocitape
        '
        Me.Btningresocitape.Location = New System.Drawing.Point(610, 351)
        Me.Btningresocitape.Name = "Btningresocitape"
        Me.Btningresocitape.Size = New System.Drawing.Size(112, 45)
        Me.Btningresocitape.TabIndex = 17
        Me.Btningresocitape.Text = "Ingresar Cita Paciente existente"
        Me.Btningresocitape.UseVisualStyleBackColor = True
        '
        'CitaExpress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btningresocitape)
        Me.Controls.Add(Me.Txtfecha)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.cmbidpaciente)
        Me.Controls.Add(Me.cmbpaciente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.txtcodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CitaExpress"
        Me.Text = "CitaExpress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents txtnombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Btningresar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnregresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbpaciente As ComboBox
    Friend WithEvents cmbidpaciente As ComboBox
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents Txtfecha As TextBox
    Friend WithEvents Btningresocitape As Button
End Class
