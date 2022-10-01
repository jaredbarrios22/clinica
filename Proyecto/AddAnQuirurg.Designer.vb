<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnQuirurg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAnQuirurg))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcionOperacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateOperacion = New System.Windows.Forms.DateTimePicker()
        Me.txtConsecuencias = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcorroboracion = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consecuencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fechaoperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtidantecedente = New System.Windows.Forms.TextBox()
        Me.Txtfecha = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Antecedentes Quirurgicos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripcion de Operacion"
        '
        'txtDescripcionOperacion
        '
        Me.txtDescripcionOperacion.Location = New System.Drawing.Point(94, 177)
        Me.txtDescripcionOperacion.Multiline = True
        Me.txtDescripcionOperacion.Name = "txtDescripcionOperacion"
        Me.txtDescripcionOperacion.Size = New System.Drawing.Size(309, 173)
        Me.txtDescripcionOperacion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(556, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Consecuencias"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de Operacion"
        '
        'dateOperacion
        '
        Me.dateOperacion.Location = New System.Drawing.Point(394, 379)
        Me.dateOperacion.Name = "dateOperacion"
        Me.dateOperacion.Size = New System.Drawing.Size(200, 20)
        Me.dateOperacion.TabIndex = 14
        '
        'txtConsecuencias
        '
        Me.txtConsecuencias.Location = New System.Drawing.Point(429, 177)
        Me.txtConsecuencias.Multiline = True
        Me.txtConsecuencias.Name = "txtConsecuencias"
        Me.txtConsecuencias.Size = New System.Drawing.Size(309, 173)
        Me.txtConsecuencias.TabIndex = 18
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(764, 207)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(764, 267)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(86, 39)
        Me.btnRegresar.TabIndex = 28
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(764, 149)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(86, 37)
        Me.btnIngresar.TabIndex = 27
        Me.btnIngresar.Text = "Ingresar operacion"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre del Paciente"
        '
        'Txtcorroboracion
        '
        Me.Txtcorroboracion.Location = New System.Drawing.Point(44, 12)
        Me.Txtcorroboracion.Name = "Txtcorroboracion"
        Me.Txtcorroboracion.Size = New System.Drawing.Size(100, 20)
        Me.Txtcorroboracion.TabIndex = 34
        Me.Txtcorroboracion.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Consecuencias, Me.Fechaoperacion})
        Me.DataGridView1.Location = New System.Drawing.Point(67, 438)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(773, 199)
        Me.DataGridView1.TabIndex = 35
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 300
        '
        'Consecuencias
        '
        Me.Consecuencias.HeaderText = "Consecuencias"
        Me.Consecuencias.Name = "Consecuencias"
        Me.Consecuencias.Width = 300
        '
        'Fechaoperacion
        '
        Me.Fechaoperacion.HeaderText = "Fechaoperacion"
        Me.Fechaoperacion.Name = "Fechaoperacion"
        Me.Fechaoperacion.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Operaciones Registradas"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(183, 105)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(289, 20)
        Me.txtnombre.TabIndex = 37
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(584, 105)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(163, 20)
        Me.txtcod.TabIndex = 38
        Me.txtcod.Visible = False
        '
        'txtidantecedente
        '
        Me.txtidantecedente.Location = New System.Drawing.Point(601, 12)
        Me.txtidantecedente.Name = "txtidantecedente"
        Me.txtidantecedente.Size = New System.Drawing.Size(53, 20)
        Me.txtidantecedente.TabIndex = 39
        Me.txtidantecedente.Visible = False
        '
        'Txtfecha
        '
        Me.Txtfecha.Location = New System.Drawing.Point(647, 379)
        Me.Txtfecha.Name = "Txtfecha"
        Me.Txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.Txtfecha.TabIndex = 40
        Me.Txtfecha.Visible = False
        '
        'AddAnQuirurg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 659)
        Me.Controls.Add(Me.Txtfecha)
        Me.Controls.Add(Me.txtidantecedente)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txtcorroboracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtConsecuencias)
        Me.Controls.Add(Me.dateOperacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcionOperacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAnQuirurg"
        Me.Text = "Antecedentes Quirurgicos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcionOperacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dateOperacion As DateTimePicker
    Friend WithEvents txtConsecuencias As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtcorroboracion As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtidantecedente As TextBox
    Friend WithEvents Txtfecha As TextBox
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Consecuencias As DataGridViewTextBoxColumn
    Friend WithEvents Fechaoperacion As DataGridViewTextBoxColumn
End Class
