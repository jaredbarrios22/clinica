<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class guardarcitatratamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(guardarcitatratamiento))
        Me.btningresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.RichTextBox()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.cmbpaciente = New System.Windows.Forms.ComboBox()
        Me.txtdiagnostico = New System.Windows.Forms.RichTextBox()
        Me.lbldiagnoscito = New System.Windows.Forms.Label()
        Me.lblmotivo = New System.Windows.Forms.Label()
        Me.dptfecha = New System.Windows.Forms.DateTimePicker()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtcita = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btningresarcita = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(507, 392)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 48
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(485, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 31)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Cita"
        '
        'txtmotivo
        '
        Me.txtmotivo.Location = New System.Drawing.Point(137, 105)
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(332, 96)
        Me.txtmotivo.TabIndex = 46
        Me.txtmotivo.Text = ""
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(23, 83)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(49, 13)
        Me.lblpaciente.TabIndex = 45
        Me.lblpaciente.Text = "Paciente"
        '
        'cmbpaciente
        '
        Me.cmbpaciente.FormattingEnabled = True
        Me.cmbpaciente.Location = New System.Drawing.Point(137, 79)
        Me.cmbpaciente.Name = "cmbpaciente"
        Me.cmbpaciente.Size = New System.Drawing.Size(332, 21)
        Me.cmbpaciente.TabIndex = 44
        '
        'txtdiagnostico
        '
        Me.txtdiagnostico.Location = New System.Drawing.Point(602, 105)
        Me.txtdiagnostico.Name = "txtdiagnostico"
        Me.txtdiagnostico.Size = New System.Drawing.Size(332, 96)
        Me.txtdiagnostico.TabIndex = 43
        Me.txtdiagnostico.Text = ""
        '
        'lbldiagnoscito
        '
        Me.lbldiagnoscito.AutoSize = True
        Me.lbldiagnoscito.Location = New System.Drawing.Point(488, 108)
        Me.lbldiagnoscito.Name = "lbldiagnoscito"
        Me.lbldiagnoscito.Size = New System.Drawing.Size(63, 13)
        Me.lbldiagnoscito.TabIndex = 42
        Me.lbldiagnoscito.Text = "Diagnostico"
        '
        'lblmotivo
        '
        Me.lblmotivo.AutoSize = True
        Me.lblmotivo.Location = New System.Drawing.Point(23, 108)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(39, 13)
        Me.lblmotivo.TabIndex = 41
        Me.lblmotivo.Text = "Motivo"
        '
        'dptfecha
        '
        Me.dptfecha.Location = New System.Drawing.Point(602, 79)
        Me.dptfecha.Name = "dptfecha"
        Me.dptfecha.Size = New System.Drawing.Size(332, 20)
        Me.dptfecha.TabIndex = 40
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(488, 85)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(37, 13)
        Me.lblfecha.TabIndex = 39
        Me.lblfecha.Text = "Fecha"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(247, 294)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(120, 13)
        Me.lbldescripcion.TabIndex = 50
        Me.lbldescripcion.Text = "Tratamiento descripcion"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(373, 290)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(332, 96)
        Me.txtdescripcion.TabIndex = 51
        Me.txtdescripcion.Text = ""
        '
        'txtcita
        '
        Me.txtcita.Location = New System.Drawing.Point(373, 264)
        Me.txtcita.Name = "txtcita"
        Me.txtcita.Size = New System.Drawing.Size(332, 20)
        Me.txtcita.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "ID cita"
        '
        'btningresarcita
        '
        Me.btningresarcita.Location = New System.Drawing.Point(507, 216)
        Me.btningresarcita.Name = "btningresarcita"
        Me.btningresarcita.Size = New System.Drawing.Size(75, 23)
        Me.btningresarcita.TabIndex = 55
        Me.btningresarcita.Text = "Ingresar cita"
        Me.btningresarcita.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(859, 217)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 56
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(859, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'guardarcitatratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 501)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresarcita)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcita)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.cmbpaciente)
        Me.Controls.Add(Me.txtdiagnostico)
        Me.Controls.Add(Me.lbldiagnoscito)
        Me.Controls.Add(Me.lblmotivo)
        Me.Controls.Add(Me.dptfecha)
        Me.Controls.Add(Me.lblfecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "guardarcitatratamiento"
        Me.Text = "Citas y Tratamientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btningresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmotivo As RichTextBox
    Friend WithEvents lblpaciente As Label
    Friend WithEvents cmbpaciente As ComboBox
    Friend WithEvents txtdiagnostico As RichTextBox
    Friend WithEvents lbldiagnoscito As Label
    Friend WithEvents lblmotivo As Label
    Friend WithEvents dptfecha As DateTimePicker
    Friend WithEvents lblfecha As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtdescripcion As RichTextBox
    Friend WithEvents txtcita As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btningresarcita As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
