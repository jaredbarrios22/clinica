<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agendarcita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agendarcita))
        Me.txtdiagnostico = New System.Windows.Forms.RichTextBox()
        Me.lbldiagnoscito = New System.Windows.Forms.Label()
        Me.lblmotivo = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.cmbpaciente = New System.Windows.Forms.ComboBox()
        Me.txtmotivo = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnbiografia = New System.Windows.Forms.Button()
        Me.binanqui = New System.Windows.Forms.Button()
        Me.btnanmed = New System.Windows.Forms.Button()
        Me.btnanale = New System.Windows.Forms.Button()
        Me.btnexamen = New System.Windows.Forms.Button()
        Me.Cmbidpaciente = New System.Windows.Forms.ComboBox()
        Me.cmbidcita = New System.Windows.Forms.ComboBox()
        Me.cmbedad = New System.Windows.Forms.ComboBox()
        Me.txttratamiento = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidtratamiento = New System.Windows.Forms.TextBox()
        Me.btnanfam = New System.Windows.Forms.Button()
        Me.btnreflab = New System.Windows.Forms.Button()
        Me.btnrefesp = New System.Windows.Forms.Button()
        Me.btndoc = New System.Windows.Forms.Button()
        Me.btnhisci = New System.Windows.Forms.Button()
        Me.btnangineco = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdiagnostico
        '
        Me.txtdiagnostico.Location = New System.Drawing.Point(128, 235)
        Me.txtdiagnostico.Name = "txtdiagnostico"
        Me.txtdiagnostico.Size = New System.Drawing.Size(332, 96)
        Me.txtdiagnostico.TabIndex = 33
        Me.txtdiagnostico.Text = ""
        '
        'lbldiagnoscito
        '
        Me.lbldiagnoscito.AutoSize = True
        Me.lbldiagnoscito.Location = New System.Drawing.Point(21, 235)
        Me.lbldiagnoscito.Name = "lbldiagnoscito"
        Me.lbldiagnoscito.Size = New System.Drawing.Size(63, 13)
        Me.lbldiagnoscito.TabIndex = 31
        Me.lbldiagnoscito.Text = "Diagnostico"
        '
        'lblmotivo
        '
        Me.lblmotivo.AutoSize = True
        Me.lblmotivo.Location = New System.Drawing.Point(21, 133)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(39, 13)
        Me.lblmotivo.TabIndex = 30
        Me.lblmotivo.Text = "Motivo"
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(21, 77)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(49, 13)
        Me.lblpaciente.TabIndex = 35
        Me.lblpaciente.Text = "Paciente"
        '
        'cmbpaciente
        '
        Me.cmbpaciente.FormattingEnabled = True
        Me.cmbpaciente.Location = New System.Drawing.Point(128, 74)
        Me.cmbpaciente.Name = "cmbpaciente"
        Me.cmbpaciente.Size = New System.Drawing.Size(332, 21)
        Me.cmbpaciente.TabIndex = 34
        '
        'txtmotivo
        '
        Me.txtmotivo.Location = New System.Drawing.Point(128, 130)
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(332, 96)
        Me.txtmotivo.TabIndex = 36
        Me.txtmotivo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 31)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Cita"
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(115, 458)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(113, 38)
        Me.btningresar.TabIndex = 38
        Me.btningresar.Text = "Guardar Datos de Cita"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(290, 458)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(92, 38)
        Me.btnlimpiar.TabIndex = 39
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnbiografia
        '
        Me.btnbiografia.Location = New System.Drawing.Point(665, 428)
        Me.btnbiografia.Name = "btnbiografia"
        Me.btnbiografia.Size = New System.Drawing.Size(241, 48)
        Me.btnbiografia.TabIndex = 40
        Me.btnbiografia.Text = "Biografia del paciente"
        Me.btnbiografia.UseVisualStyleBackColor = True
        '
        'binanqui
        '
        Me.binanqui.Location = New System.Drawing.Point(608, 12)
        Me.binanqui.Name = "binanqui"
        Me.binanqui.Size = New System.Drawing.Size(156, 48)
        Me.binanqui.TabIndex = 41
        Me.binanqui.Text = "Antecedente Quirurgico Paciente"
        Me.binanqui.UseVisualStyleBackColor = True
        '
        'btnanmed
        '
        Me.btnanmed.Location = New System.Drawing.Point(785, 12)
        Me.btnanmed.Name = "btnanmed"
        Me.btnanmed.Size = New System.Drawing.Size(156, 49)
        Me.btnanmed.TabIndex = 42
        Me.btnanmed.Text = "Antecedente Medico Paciente"
        Me.btnanmed.UseVisualStyleBackColor = True
        '
        'btnanale
        '
        Me.btnanale.Location = New System.Drawing.Point(608, 93)
        Me.btnanale.Name = "btnanale"
        Me.btnanale.Size = New System.Drawing.Size(156, 53)
        Me.btnanale.TabIndex = 43
        Me.btnanale.Text = "Antecedente De Alergias del paciente"
        Me.btnanale.UseVisualStyleBackColor = True
        '
        'btnexamen
        '
        Me.btnexamen.Location = New System.Drawing.Point(785, 173)
        Me.btnexamen.Name = "btnexamen"
        Me.btnexamen.Size = New System.Drawing.Size(156, 53)
        Me.btnexamen.TabIndex = 44
        Me.btnexamen.Text = "Examen Físico Paciente"
        Me.btnexamen.UseVisualStyleBackColor = True
        '
        'Cmbidpaciente
        '
        Me.Cmbidpaciente.Enabled = False
        Me.Cmbidpaciente.FormattingEnabled = True
        Me.Cmbidpaciente.Location = New System.Drawing.Point(395, 12)
        Me.Cmbidpaciente.Name = "Cmbidpaciente"
        Me.Cmbidpaciente.Size = New System.Drawing.Size(65, 21)
        Me.Cmbidpaciente.TabIndex = 45
        Me.Cmbidpaciente.Visible = False
        '
        'cmbidcita
        '
        Me.cmbidcita.Enabled = False
        Me.cmbidcita.FormattingEnabled = True
        Me.cmbidcita.Location = New System.Drawing.Point(128, 12)
        Me.cmbidcita.Name = "cmbidcita"
        Me.cmbidcita.Size = New System.Drawing.Size(65, 21)
        Me.cmbidcita.TabIndex = 46
        Me.cmbidcita.Visible = False
        '
        'cmbedad
        '
        Me.cmbedad.FormattingEnabled = True
        Me.cmbedad.Location = New System.Drawing.Point(515, 74)
        Me.cmbedad.Name = "cmbedad"
        Me.cmbedad.Size = New System.Drawing.Size(65, 21)
        Me.cmbedad.TabIndex = 47
        Me.cmbedad.Visible = False
        '
        'txttratamiento
        '
        Me.txttratamiento.Location = New System.Drawing.Point(128, 342)
        Me.txttratamiento.Name = "txttratamiento"
        Me.txttratamiento.Size = New System.Drawing.Size(332, 96)
        Me.txttratamiento.TabIndex = 48
        Me.txttratamiento.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Tratamiento"
        '
        'txtidtratamiento
        '
        Me.txtidtratamiento.Location = New System.Drawing.Point(24, 400)
        Me.txtidtratamiento.Name = "txtidtratamiento"
        Me.txtidtratamiento.Size = New System.Drawing.Size(52, 20)
        Me.txtidtratamiento.TabIndex = 50
        Me.txtidtratamiento.Visible = False
        '
        'btnanfam
        '
        Me.btnanfam.Location = New System.Drawing.Point(785, 93)
        Me.btnanfam.Name = "btnanfam"
        Me.btnanfam.Size = New System.Drawing.Size(156, 53)
        Me.btnanfam.TabIndex = 51
        Me.btnanfam.Text = "Antecedente familiar del paciente"
        Me.btnanfam.UseVisualStyleBackColor = True
        '
        'btnreflab
        '
        Me.btnreflab.Location = New System.Drawing.Point(785, 249)
        Me.btnreflab.Name = "btnreflab"
        Me.btnreflab.Size = New System.Drawing.Size(156, 53)
        Me.btnreflab.TabIndex = 52
        Me.btnreflab.Text = "Referencia a Laboratorio"
        Me.btnreflab.UseVisualStyleBackColor = True
        '
        'btnrefesp
        '
        Me.btnrefesp.Location = New System.Drawing.Point(608, 249)
        Me.btnrefesp.Name = "btnrefesp"
        Me.btnrefesp.Size = New System.Drawing.Size(156, 53)
        Me.btnrefesp.TabIndex = 53
        Me.btnrefesp.Text = "Referencia a Especialista"
        Me.btnrefesp.UseVisualStyleBackColor = True
        '
        'btndoc
        '
        Me.btndoc.Location = New System.Drawing.Point(785, 342)
        Me.btndoc.Name = "btndoc"
        Me.btndoc.Size = New System.Drawing.Size(156, 51)
        Me.btndoc.TabIndex = 54
        Me.btndoc.Text = "Registrar Documento Cita"
        Me.btndoc.UseVisualStyleBackColor = True
        '
        'btnhisci
        '
        Me.btnhisci.Location = New System.Drawing.Point(608, 342)
        Me.btnhisci.Name = "btnhisci"
        Me.btnhisci.Size = New System.Drawing.Size(156, 53)
        Me.btnhisci.TabIndex = 55
        Me.btnhisci.Text = "Revisar Historial Citas"
        Me.btnhisci.UseVisualStyleBackColor = True
        '
        'btnangineco
        '
        Me.btnangineco.Location = New System.Drawing.Point(608, 173)
        Me.btnangineco.Name = "btnangineco"
        Me.btnangineco.Size = New System.Drawing.Size(156, 53)
        Me.btnangineco.TabIndex = 56
        Me.btnangineco.Text = "Antecedente Ginecoobstetricos"
        Me.btnangineco.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 37)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'agendarcita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(953, 530)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnangineco)
        Me.Controls.Add(Me.btnhisci)
        Me.Controls.Add(Me.btndoc)
        Me.Controls.Add(Me.btnrefesp)
        Me.Controls.Add(Me.btnreflab)
        Me.Controls.Add(Me.btnanfam)
        Me.Controls.Add(Me.txtidtratamiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttratamiento)
        Me.Controls.Add(Me.cmbedad)
        Me.Controls.Add(Me.cmbidcita)
        Me.Controls.Add(Me.Cmbidpaciente)
        Me.Controls.Add(Me.btnexamen)
        Me.Controls.Add(Me.btnanale)
        Me.Controls.Add(Me.btnanmed)
        Me.Controls.Add(Me.binanqui)
        Me.Controls.Add(Me.btnbiografia)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.cmbpaciente)
        Me.Controls.Add(Me.txtdiagnostico)
        Me.Controls.Add(Me.lbldiagnoscito)
        Me.Controls.Add(Me.lblmotivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agendarcita"
        Me.Text = "agendar cita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdiagnostico As RichTextBox
    Friend WithEvents lbldiagnoscito As Label
    Friend WithEvents lblmotivo As Label
    Friend WithEvents lblpaciente As Label
    Friend WithEvents cmbpaciente As ComboBox
    Friend WithEvents txtmotivo As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnbiografia As Button
    Friend WithEvents binanqui As Button
    Friend WithEvents btnanmed As Button
    Friend WithEvents btnanale As Button
    Friend WithEvents btnexamen As Button
    Friend WithEvents Cmbidpaciente As ComboBox
    Friend WithEvents cmbidcita As ComboBox
    Friend WithEvents cmbedad As ComboBox
    Friend WithEvents txttratamiento As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidtratamiento As TextBox
    Friend WithEvents btnanfam As Button
    Friend WithEvents btnreflab As Button
    Friend WithEvents btnrefesp As Button
    Friend WithEvents btndoc As Button
    Friend WithEvents btnhisci As Button
    Friend WithEvents btnangineco As Button
    Friend WithEvents Button1 As Button
End Class
