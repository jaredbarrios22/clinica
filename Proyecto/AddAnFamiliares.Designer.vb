<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnFamiliares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAnFamiliares))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescripcionfam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescripcionAntecedente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtidantecedente = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Antecedentes Familiares"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cod Paciente"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre del Paciente"
        '
        'txtdescripcionfam
        '
        Me.txtdescripcionfam.Location = New System.Drawing.Point(173, 137)
        Me.txtdescripcionfam.Multiline = True
        Me.txtdescripcionfam.Name = "txtdescripcionfam"
        Me.txtdescripcionfam.Size = New System.Drawing.Size(302, 140)
        Me.txtdescripcionfam.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Descripcion de Antecedente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(544, 164)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 37)
        Me.btnLimpiar.TabIndex = 23
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(544, 228)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(86, 35)
        Me.btnRegresar.TabIndex = 22
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(544, 101)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 37)
        Me.btnIngresar.TabIndex = 21
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionAntecedente})
        Me.DataGridView1.Location = New System.Drawing.Point(79, 315)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 167)
        Me.DataGridView1.TabIndex = 24
        '
        'DescripcionAntecedente
        '
        Me.DescripcionAntecedente.HeaderText = "DescripcionAntecedente"
        Me.DescripcionAntecedente.Name = "DescripcionAntecedente"
        Me.DescripcionAntecedente.Width = 500
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(163, 94)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(211, 20)
        Me.txtnombre.TabIndex = 25
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(457, 94)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(47, 20)
        Me.txtcod.TabIndex = 26
        Me.txtcod.Visible = False
        '
        'txtidantecedente
        '
        Me.txtidantecedente.Location = New System.Drawing.Point(509, 12)
        Me.txtidantecedente.Name = "txtidantecedente"
        Me.txtidantecedente.Size = New System.Drawing.Size(47, 20)
        Me.txtidantecedente.TabIndex = 27
        Me.txtidantecedente.Visible = False
        '
        'AddAnFamiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 526)
        Me.Controls.Add(Me.txtidantecedente)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtdescripcionfam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddAnFamiliares"
        Me.Text = "Antecedentes Familiares"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdescripcionfam As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DescripcionAntecedente As DataGridViewTextBoxColumn
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents txtidantecedente As TextBox
End Class
