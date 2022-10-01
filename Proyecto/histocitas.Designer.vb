<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class histocitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(histocitas))
        Me.txtcopaciente = New System.Windows.Forms.TextBox()
        Me.txtpaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MotivoCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcopaciente
        '
        Me.txtcopaciente.Location = New System.Drawing.Point(342, 37)
        Me.txtcopaciente.Name = "txtcopaciente"
        Me.txtcopaciente.Size = New System.Drawing.Size(100, 20)
        Me.txtcopaciente.TabIndex = 0
        Me.txtcopaciente.Visible = False
        '
        'txtpaciente
        '
        Me.txtpaciente.Location = New System.Drawing.Point(205, 37)
        Me.txtpaciente.Name = "txtpaciente"
        Me.txtpaciente.Size = New System.Drawing.Size(100, 20)
        Me.txtpaciente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Historial de citas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MotivoCita, Me.Diagnostico, Me.Tratamiento, Me.FechaCita})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1102, 312)
        Me.DataGridView1.TabIndex = 4
        '
        'MotivoCita
        '
        Me.MotivoCita.HeaderText = "MotivoCita"
        Me.MotivoCita.Name = "MotivoCita"
        Me.MotivoCita.Width = 300
        '
        'Diagnostico
        '
        Me.Diagnostico.HeaderText = "Diagnostico"
        Me.Diagnostico.Name = "Diagnostico"
        Me.Diagnostico.Width = 300
        '
        'Tratamiento
        '
        Me.Tratamiento.HeaderText = "Tratamiento"
        Me.Tratamiento.Name = "Tratamiento"
        Me.Tratamiento.Width = 300
        '
        'FechaCita
        '
        Me.FechaCita.HeaderText = "Fechacita"
        Me.FechaCita.Name = "FechaCita"
        Me.FechaCita.Width = 150
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(601, 44)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(94, 35)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.Text = "Regresar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'histocitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 450)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpaciente)
        Me.Controls.Add(Me.txtcopaciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "histocitas"
        Me.Text = "histocitas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcopaciente As TextBox
    Friend WithEvents txtpaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btncerrar As Button
    Friend WithEvents MotivoCita As DataGridViewTextBoxColumn
    Friend WithEvents Diagnostico As DataGridViewTextBoxColumn
    Friend WithEvents Tratamiento As DataGridViewTextBoxColumn
    Friend WithEvents FechaCita As DataGridViewTextBoxColumn
End Class
