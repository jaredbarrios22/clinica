<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnAlergias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAnAlergias))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcionAlergia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMedicamentoAlergia = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescripcionAlergia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentosAlergia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtcod = New System.Windows.Forms.TextBox()
        Me.txtidantecedente = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Antecedentes de Alergias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del Paciente"
        '
        'txtDescripcionAlergia
        '
        Me.txtDescripcionAlergia.Location = New System.Drawing.Point(66, 178)
        Me.txtDescripcionAlergia.Multiline = True
        Me.txtDescripcionAlergia.Name = "txtDescripcionAlergia"
        Me.txtDescripcionAlergia.Size = New System.Drawing.Size(309, 173)
        Me.txtDescripcionAlergia.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Descripcion de alergia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(536, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Medicamientos de Alergia"
        '
        'txtMedicamentoAlergia
        '
        Me.txtMedicamentoAlergia.Location = New System.Drawing.Point(434, 178)
        Me.txtMedicamentoAlergia.Multiline = True
        Me.txtMedicamentoAlergia.Name = "txtMedicamentoAlergia"
        Me.txtMedicamentoAlergia.Size = New System.Drawing.Size(309, 173)
        Me.txtMedicamentoAlergia.TabIndex = 15
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(750, 282)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(749, 237)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(87, 39)
        Me.btnRegresar.TabIndex = 19
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(750, 194)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 37)
        Me.btnIngresar.TabIndex = 18
        Me.btnIngresar.Text = "Ingresar Alergia"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionAlergia, Me.MedicamentosAlergia})
        Me.DataGridView1.Location = New System.Drawing.Point(71, 376)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(713, 153)
        Me.DataGridView1.TabIndex = 21
        '
        'DescripcionAlergia
        '
        Me.DescripcionAlergia.HeaderText = "DescripcionAlergia"
        Me.DescripcionAlergia.Name = "DescripcionAlergia"
        Me.DescripcionAlergia.Width = 320
        '
        'MedicamentosAlergia
        '
        Me.MedicamentosAlergia.HeaderText = "MedicamentosAlergia"
        Me.MedicamentosAlergia.Name = "MedicamentosAlergia"
        Me.MedicamentosAlergia.Width = 350
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(185, 120)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(218, 20)
        Me.Txtnombre.TabIndex = 22
        '
        'Txtcod
        '
        Me.Txtcod.Location = New System.Drawing.Point(497, 120)
        Me.Txtcod.Name = "Txtcod"
        Me.Txtcod.Size = New System.Drawing.Size(45, 20)
        Me.Txtcod.TabIndex = 23
        Me.Txtcod.Visible = False
        '
        'txtidantecedente
        '
        Me.txtidantecedente.Location = New System.Drawing.Point(750, 12)
        Me.txtidantecedente.Name = "txtidantecedente"
        Me.txtidantecedente.Size = New System.Drawing.Size(45, 20)
        Me.txtidantecedente.TabIndex = 24
        Me.txtidantecedente.Visible = False
        '
        'AddAnAlergias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 603)
        Me.Controls.Add(Me.txtidantecedente)
        Me.Controls.Add(Me.Txtcod)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtMedicamentoAlergia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcionAlergia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAnAlergias"
        Me.Text = "Antecedentes de Alergias"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcionAlergia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMedicamentoAlergia As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtcod As TextBox
    Friend WithEvents txtidantecedente As TextBox
    Friend WithEvents DescripcionAlergia As DataGridViewTextBoxColumn
    Friend WithEvents MedicamentosAlergia As DataGridViewTextBoxColumn
End Class
