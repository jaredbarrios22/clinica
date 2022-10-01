<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificarangineco
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Modidantegine = New System.Windows.Forms.ComboBox()
        Me.Idpaciente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Modmenar = New System.Windows.Forms.ComboBox()
        Me.ModGesta = New System.Windows.Forms.ComboBox()
        Me.Modpart = New System.Windows.Forms.ComboBox()
        Me.Modabort = New System.Windows.Forms.ComboBox()
        Me.ModCesa = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Modhv = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Modfur = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Modfpp = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Modembara = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Modfup = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Modantic = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Modciclo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Modpapa = New System.Windows.Forms.TextBox()
        Me.Modrelac = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btningresar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Antecedente Gineco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Paciente"
        '
        'Modidantegine
        '
        Me.Modidantegine.FormattingEnabled = True
        Me.Modidantegine.Location = New System.Drawing.Point(333, 62)
        Me.Modidantegine.Name = "Modidantegine"
        Me.Modidantegine.Size = New System.Drawing.Size(82, 21)
        Me.Modidantegine.TabIndex = 2
        '
        'Idpaciente
        '
        Me.Idpaciente.FormattingEnabled = True
        Me.Idpaciente.Location = New System.Drawing.Point(333, 98)
        Me.Idpaciente.Name = "Idpaciente"
        Me.Idpaciente.Size = New System.Drawing.Size(82, 21)
        Me.Idpaciente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Menarquia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gestaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Partos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Abortos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cesareas"
        '
        'Modmenar
        '
        Me.Modmenar.FormattingEnabled = True
        Me.Modmenar.Location = New System.Drawing.Point(333, 134)
        Me.Modmenar.Name = "Modmenar"
        Me.Modmenar.Size = New System.Drawing.Size(82, 21)
        Me.Modmenar.TabIndex = 9
        '
        'ModGesta
        '
        Me.ModGesta.FormattingEnabled = True
        Me.ModGesta.Location = New System.Drawing.Point(333, 167)
        Me.ModGesta.Name = "ModGesta"
        Me.ModGesta.Size = New System.Drawing.Size(82, 21)
        Me.ModGesta.TabIndex = 10
        '
        'Modpart
        '
        Me.Modpart.FormattingEnabled = True
        Me.Modpart.Location = New System.Drawing.Point(333, 205)
        Me.Modpart.Name = "Modpart"
        Me.Modpart.Size = New System.Drawing.Size(82, 21)
        Me.Modpart.TabIndex = 11
        '
        'Modabort
        '
        Me.Modabort.FormattingEnabled = True
        Me.Modabort.Location = New System.Drawing.Point(333, 242)
        Me.Modabort.Name = "Modabort"
        Me.Modabort.Size = New System.Drawing.Size(82, 21)
        Me.Modabort.TabIndex = 12
        '
        'ModCesa
        '
        Me.ModCesa.FormattingEnabled = True
        Me.ModCesa.Location = New System.Drawing.Point(333, 274)
        Me.ModCesa.Name = "ModCesa"
        Me.ModCesa.Size = New System.Drawing.Size(82, 21)
        Me.ModCesa.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "HV"
        '
        'Modhv
        '
        Me.Modhv.FormattingEnabled = True
        Me.Modhv.Location = New System.Drawing.Point(333, 314)
        Me.Modhv.Name = "Modhv"
        Me.Modhv.Size = New System.Drawing.Size(82, 21)
        Me.Modhv.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 356)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "FUR"
        '
        'Modfur
        '
        Me.Modfur.Location = New System.Drawing.Point(333, 349)
        Me.Modfur.Name = "Modfur"
        Me.Modfur.Size = New System.Drawing.Size(233, 20)
        Me.Modfur.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "FPP"
        '
        'Modfpp
        '
        Me.Modfpp.Location = New System.Drawing.Point(333, 384)
        Me.Modfpp.Name = "Modfpp"
        Me.Modfpp.Size = New System.Drawing.Size(233, 20)
        Me.Modfpp.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(178, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Embarazado de: "
        '
        'Modembara
        '
        Me.Modembara.Location = New System.Drawing.Point(333, 419)
        Me.Modembara.Name = "Modembara"
        Me.Modembara.Size = New System.Drawing.Size(233, 20)
        Me.Modembara.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(178, 468)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "FUP"
        '
        'Modfup
        '
        Me.Modfup.Location = New System.Drawing.Point(333, 461)
        Me.Modfup.Name = "Modfup"
        Me.Modfup.Size = New System.Drawing.Size(233, 20)
        Me.Modfup.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(180, 504)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Anticos o Inyecciones"
        '
        'Modantic
        '
        Me.Modantic.Location = New System.Drawing.Point(333, 501)
        Me.Modantic.Name = "Modantic"
        Me.Modantic.Size = New System.Drawing.Size(233, 20)
        Me.Modantic.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(180, 541)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Ciclo Mestrual"
        '
        'Modciclo
        '
        Me.Modciclo.Location = New System.Drawing.Point(333, 541)
        Me.Modciclo.Name = "Modciclo"
        Me.Modciclo.Size = New System.Drawing.Size(233, 20)
        Me.Modciclo.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(181, 588)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Papanicolau"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(178, 623)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Relaciones Sexuales"
        '
        'Modpapa
        '
        Me.Modpapa.Location = New System.Drawing.Point(333, 580)
        Me.Modpapa.Name = "Modpapa"
        Me.Modpapa.Size = New System.Drawing.Size(233, 20)
        Me.Modpapa.TabIndex = 30
        '
        'Modrelac
        '
        Me.Modrelac.FormattingEnabled = True
        Me.Modrelac.Location = New System.Drawing.Point(333, 615)
        Me.Modrelac.Name = "Modrelac"
        Me.Modrelac.Size = New System.Drawing.Size(121, 21)
        Me.Modrelac.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(144, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(597, 33)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Modificar Antecedentes Gineco-obstretico"
        '
        'Btningresar
        '
        Me.Btningresar.Location = New System.Drawing.Point(224, 664)
        Me.Btningresar.Name = "Btningresar"
        Me.Btningresar.Size = New System.Drawing.Size(75, 53)
        Me.Btningresar.TabIndex = 33
        Me.Btningresar.Text = "Ingresar"
        Me.Btningresar.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(508, 664)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 53)
        Me.Btnlimpiar.TabIndex = 34
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(390, 730)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(75, 59)
        Me.Btnregresar.TabIndex = 35
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Modificarangineco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 820)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btningresar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Modrelac)
        Me.Controls.Add(Me.Modpapa)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Modciclo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Modantic)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Modfup)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Modembara)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Modfpp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Modfur)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Modhv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ModCesa)
        Me.Controls.Add(Me.Modabort)
        Me.Controls.Add(Me.Modpart)
        Me.Controls.Add(Me.ModGesta)
        Me.Controls.Add(Me.Modmenar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Idpaciente)
        Me.Controls.Add(Me.Modidantegine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Modificarangineco"
        Me.Text = "Modificarangineco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Modidantegine As ComboBox
    Friend WithEvents Idpaciente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Modmenar As ComboBox
    Friend WithEvents ModGesta As ComboBox
    Friend WithEvents Modpart As ComboBox
    Friend WithEvents Modabort As ComboBox
    Friend WithEvents ModCesa As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Modhv As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Modfur As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Modfpp As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Modembara As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Modfup As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Modantic As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Modciclo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Modpapa As TextBox
    Friend WithEvents Modrelac As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Btningresar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Btnregresar As Button
End Class
