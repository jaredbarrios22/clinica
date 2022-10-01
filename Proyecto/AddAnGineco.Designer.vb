<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnGineco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAnGineco))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmenarquia = New System.Windows.Forms.ComboBox()
        Me.cmbgestaciones = New System.Windows.Forms.ComboBox()
        Me.cmbpartos = New System.Windows.Forms.ComboBox()
        Me.cmbabortos = New System.Windows.Forms.ComboBox()
        Me.cmbcesareas = New System.Windows.Forms.ComboBox()
        Me.cmbhv = New System.Windows.Forms.ComboBox()
        Me.dateUltimaMenstruacion = New System.Windows.Forms.DateTimePicker()
        Me.datePosibleParto = New System.Windows.Forms.DateTimePicker()
        Me.txtembarazo = New System.Windows.Forms.TextBox()
        Me.dateUltimoParto = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtAnticos = New System.Windows.Forms.TextBox()
        Me.txtCicloMenstrual = New System.Windows.Forms.TextBox()
        Me.txtPapanicolau = New System.Windows.Forms.TextBox()
        Me.cmbRelaciones = New System.Windows.Forms.ComboBox()
        Me.Txtcod = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtfup = New System.Windows.Forms.TextBox()
        Me.txtfpp = New System.Windows.Forms.TextBox()
        Me.txtfur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(481, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Agregar Antecedentes Gineco-obstetrico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Menarquia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gestaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Partos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Abortos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cesareas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "HV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 369)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "FUR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "FPP"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 441)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Embarazo de:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "FUP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 508)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Anticos o inyecciones"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 538)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Ciclo Menstrual"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 569)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Papanicolau"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 610)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Relaciones Sexuales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(322, 652)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 26
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(199, 708)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(81, 39)
        Me.btnRegresar.TabIndex = 25
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(81, 652)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 37)
        Me.btnIngresar.TabIndex = 24
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre del Paciente"
        '
        'cmbmenarquia
        '
        Me.cmbmenarquia.FormattingEnabled = True
        Me.cmbmenarquia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cmbmenarquia.Location = New System.Drawing.Point(159, 146)
        Me.cmbmenarquia.Name = "cmbmenarquia"
        Me.cmbmenarquia.Size = New System.Drawing.Size(84, 21)
        Me.cmbmenarquia.TabIndex = 31
        '
        'cmbgestaciones
        '
        Me.cmbgestaciones.FormattingEnabled = True
        Me.cmbgestaciones.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbgestaciones.Location = New System.Drawing.Point(159, 185)
        Me.cmbgestaciones.Name = "cmbgestaciones"
        Me.cmbgestaciones.Size = New System.Drawing.Size(84, 21)
        Me.cmbgestaciones.TabIndex = 32
        '
        'cmbpartos
        '
        Me.cmbpartos.FormattingEnabled = True
        Me.cmbpartos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbpartos.Location = New System.Drawing.Point(159, 220)
        Me.cmbpartos.Name = "cmbpartos"
        Me.cmbpartos.Size = New System.Drawing.Size(84, 21)
        Me.cmbpartos.TabIndex = 33
        '
        'cmbabortos
        '
        Me.cmbabortos.FormattingEnabled = True
        Me.cmbabortos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbabortos.Location = New System.Drawing.Point(159, 257)
        Me.cmbabortos.Name = "cmbabortos"
        Me.cmbabortos.Size = New System.Drawing.Size(84, 21)
        Me.cmbabortos.TabIndex = 34
        '
        'cmbcesareas
        '
        Me.cmbcesareas.FormattingEnabled = True
        Me.cmbcesareas.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbcesareas.Location = New System.Drawing.Point(159, 296)
        Me.cmbcesareas.Name = "cmbcesareas"
        Me.cmbcesareas.Size = New System.Drawing.Size(84, 21)
        Me.cmbcesareas.TabIndex = 35
        '
        'cmbhv
        '
        Me.cmbhv.FormattingEnabled = True
        Me.cmbhv.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbhv.Location = New System.Drawing.Point(159, 333)
        Me.cmbhv.Name = "cmbhv"
        Me.cmbhv.Size = New System.Drawing.Size(84, 21)
        Me.cmbhv.TabIndex = 36
        '
        'dateUltimaMenstruacion
        '
        Me.dateUltimaMenstruacion.Location = New System.Drawing.Point(159, 369)
        Me.dateUltimaMenstruacion.Name = "dateUltimaMenstruacion"
        Me.dateUltimaMenstruacion.Size = New System.Drawing.Size(249, 20)
        Me.dateUltimaMenstruacion.TabIndex = 37
        '
        'datePosibleParto
        '
        Me.datePosibleParto.Location = New System.Drawing.Point(159, 406)
        Me.datePosibleParto.Name = "datePosibleParto"
        Me.datePosibleParto.Size = New System.Drawing.Size(249, 20)
        Me.datePosibleParto.TabIndex = 38
        '
        'txtembarazo
        '
        Me.txtembarazo.Location = New System.Drawing.Point(159, 441)
        Me.txtembarazo.Name = "txtembarazo"
        Me.txtembarazo.Size = New System.Drawing.Size(249, 20)
        Me.txtembarazo.TabIndex = 39
        '
        'dateUltimoParto
        '
        Me.dateUltimoParto.Location = New System.Drawing.Point(159, 474)
        Me.dateUltimoParto.Name = "dateUltimoParto"
        Me.dateUltimoParto.Size = New System.Drawing.Size(249, 20)
        Me.dateUltimoParto.TabIndex = 40
        '
        'txtAnticos
        '
        Me.txtAnticos.Location = New System.Drawing.Point(159, 508)
        Me.txtAnticos.Name = "txtAnticos"
        Me.txtAnticos.Size = New System.Drawing.Size(249, 20)
        Me.txtAnticos.TabIndex = 41
        '
        'txtCicloMenstrual
        '
        Me.txtCicloMenstrual.Location = New System.Drawing.Point(159, 535)
        Me.txtCicloMenstrual.Name = "txtCicloMenstrual"
        Me.txtCicloMenstrual.Size = New System.Drawing.Size(249, 20)
        Me.txtCicloMenstrual.TabIndex = 42
        '
        'txtPapanicolau
        '
        Me.txtPapanicolau.Location = New System.Drawing.Point(159, 566)
        Me.txtPapanicolau.Name = "txtPapanicolau"
        Me.txtPapanicolau.Size = New System.Drawing.Size(249, 20)
        Me.txtPapanicolau.TabIndex = 43
        '
        'cmbRelaciones
        '
        Me.cmbRelaciones.FormattingEnabled = True
        Me.cmbRelaciones.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbRelaciones.Location = New System.Drawing.Point(159, 610)
        Me.cmbRelaciones.Name = "cmbRelaciones"
        Me.cmbRelaciones.Size = New System.Drawing.Size(84, 21)
        Me.cmbRelaciones.TabIndex = 44
        '
        'Txtcod
        '
        Me.Txtcod.Location = New System.Drawing.Point(399, 108)
        Me.Txtcod.Name = "Txtcod"
        Me.Txtcod.Size = New System.Drawing.Size(78, 20)
        Me.Txtcod.TabIndex = 45
        Me.Txtcod.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(159, 104)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(84, 20)
        Me.txtnombre.TabIndex = 46
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(195, 652)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(85, 37)
        Me.btnactualizar.TabIndex = 47
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(399, 69)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(78, 20)
        Me.txtid.TabIndex = 48
        Me.txtid.Visible = False
        '
        'txtfup
        '
        Me.txtfup.Location = New System.Drawing.Point(414, 474)
        Me.txtfup.Name = "txtfup"
        Me.txtfup.Size = New System.Drawing.Size(100, 20)
        Me.txtfup.TabIndex = 49
        Me.txtfup.Visible = False
        '
        'txtfpp
        '
        Me.txtfpp.Location = New System.Drawing.Point(414, 403)
        Me.txtfpp.Name = "txtfpp"
        Me.txtfpp.Size = New System.Drawing.Size(100, 20)
        Me.txtfpp.TabIndex = 50
        Me.txtfpp.Visible = False
        '
        'txtfur
        '
        Me.txtfur.Location = New System.Drawing.Point(414, 369)
        Me.txtfur.Name = "txtfur"
        Me.txtfur.Size = New System.Drawing.Size(100, 20)
        Me.txtfur.TabIndex = 51
        Me.txtfur.Visible = False
        '
        'AddAnGineco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(563, 749)
        Me.Controls.Add(Me.txtfur)
        Me.Controls.Add(Me.txtfpp)
        Me.Controls.Add(Me.txtfup)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Txtcod)
        Me.Controls.Add(Me.cmbRelaciones)
        Me.Controls.Add(Me.txtPapanicolau)
        Me.Controls.Add(Me.txtCicloMenstrual)
        Me.Controls.Add(Me.txtAnticos)
        Me.Controls.Add(Me.dateUltimoParto)
        Me.Controls.Add(Me.txtembarazo)
        Me.Controls.Add(Me.datePosibleParto)
        Me.Controls.Add(Me.dateUltimaMenstruacion)
        Me.Controls.Add(Me.cmbhv)
        Me.Controls.Add(Me.cmbcesareas)
        Me.Controls.Add(Me.cmbabortos)
        Me.Controls.Add(Me.cmbpartos)
        Me.Controls.Add(Me.cmbgestaciones)
        Me.Controls.Add(Me.cmbmenarquia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAnGineco"
        Me.Text = "Antecedente Gineco-obstetrico "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbmenarquia As ComboBox
    Friend WithEvents cmbgestaciones As ComboBox
    Friend WithEvents cmbpartos As ComboBox
    Friend WithEvents cmbabortos As ComboBox
    Friend WithEvents cmbcesareas As ComboBox
    Friend WithEvents cmbhv As ComboBox
    Friend WithEvents dateUltimaMenstruacion As DateTimePicker
    Friend WithEvents datePosibleParto As DateTimePicker
    Friend WithEvents txtembarazo As TextBox
    Friend WithEvents dateUltimoParto As DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtAnticos As TextBox
    Friend WithEvents txtCicloMenstrual As TextBox
    Friend WithEvents txtPapanicolau As TextBox
    Friend WithEvents cmbRelaciones As ComboBox
    Friend WithEvents Txtcod As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtfup As TextBox
    Friend WithEvents txtfpp As TextBox
    Friend WithEvents txtfur As TextBox
End Class
