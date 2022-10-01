<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnMedi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAnMedi))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtMedicamentosEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcionEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidantecedente = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescripcionEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentosEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(372, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Agregar Antecedentes Medicos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre del Paciente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(766, 298)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(766, 227)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(86, 39)
        Me.btnRegresar.TabIndex = 26
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(767, 166)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 37)
        Me.btnIngresar.TabIndex = 25
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtMedicamentosEnfermedad
        '
        Me.txtMedicamentosEnfermedad.Location = New System.Drawing.Point(446, 175)
        Me.txtMedicamentosEnfermedad.Multiline = True
        Me.txtMedicamentosEnfermedad.Name = "txtMedicamentosEnfermedad"
        Me.txtMedicamentosEnfermedad.Size = New System.Drawing.Size(309, 173)
        Me.txtMedicamentosEnfermedad.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Medicamientos de Enfermedad"
        '
        'txtDescripcionEnfermedad
        '
        Me.txtDescripcionEnfermedad.Location = New System.Drawing.Point(75, 175)
        Me.txtDescripcionEnfermedad.Multiline = True
        Me.txtDescripcionEnfermedad.Name = "txtDescripcionEnfermedad"
        Me.txtDescripcionEnfermedad.Size = New System.Drawing.Size(309, 173)
        Me.txtDescripcionEnfermedad.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Descripcion de Enfermedad"
        '
        'txtidantecedente
        '
        Me.txtidantecedente.Location = New System.Drawing.Point(669, 12)
        Me.txtidantecedente.Name = "txtidantecedente"
        Me.txtidantecedente.Size = New System.Drawing.Size(45, 20)
        Me.txtidantecedente.TabIndex = 28
        Me.txtidantecedente.Visible = False
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(459, 110)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 20)
        Me.txtcod.TabIndex = 29
        Me.txtcod.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(187, 110)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionEnfermedad, Me.MedicamentosEnfermedad})
        Me.DataGridView1.Location = New System.Drawing.Point(100, 418)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(665, 147)
        Me.DataGridView1.TabIndex = 31
        '
        'DescripcionEnfermedad
        '
        Me.DescripcionEnfermedad.HeaderText = "Descripcion Enfermedad"
        Me.DescripcionEnfermedad.Name = "DescripcionEnfermedad"
        Me.DescripcionEnfermedad.Width = 310
        '
        'MedicamentosEnfermedad
        '
        Me.MedicamentosEnfermedad.HeaderText = "MedicamentosEnfermedad"
        Me.MedicamentosEnfermedad.Name = "MedicamentosEnfermedad"
        Me.MedicamentosEnfermedad.Width = 310
        '
        'AddAnMedi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 595)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txtidantecedente)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtMedicamentosEnfermedad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcionEnfermedad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAnMedi"
        Me.Text = "Antecedentes Medicos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtMedicamentosEnfermedad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcionEnfermedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtidantecedente As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DescripcionEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents MedicamentosEnfermedad As DataGridViewTextBoxColumn
End Class
