<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verdocumentoslegales
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnorecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnofactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rcita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rmonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblhasta = New System.Windows.Forms.Label()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker()
        Me.dtphasta = New System.Windows.Forms.DateTimePicker()
        Me.btnver = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rid, Me.rnorecibo, Me.rnofactura, Me.rnombre, Me.rfecha, Me.rcita, Me.rmonto})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'rid
        '
        Me.rid.HeaderText = "ID"
        Me.rid.Name = "rid"
        Me.rid.ReadOnly = True
        '
        'rnorecibo
        '
        Me.rnorecibo.HeaderText = "No. recibo"
        Me.rnorecibo.Name = "rnorecibo"
        Me.rnorecibo.ReadOnly = True
        '
        'rnofactura
        '
        Me.rnofactura.HeaderText = "No. factura"
        Me.rnofactura.Name = "rnofactura"
        Me.rnofactura.ReadOnly = True
        '
        'rnombre
        '
        Me.rnombre.HeaderText = "Nombre"
        Me.rnombre.Name = "rnombre"
        Me.rnombre.ReadOnly = True
        '
        'rfecha
        '
        Me.rfecha.HeaderText = "Fecha Emision"
        Me.rfecha.Name = "rfecha"
        Me.rfecha.ReadOnly = True
        '
        'rcita
        '
        Me.rcita.HeaderText = "Cita"
        Me.rcita.Name = "rcita"
        Me.rcita.ReadOnly = True
        '
        'rmonto
        '
        Me.rmonto.HeaderText = "Monto"
        Me.rmonto.Name = "rmonto"
        Me.rmonto.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documentos"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(58, 317)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(35, 13)
        Me.lblhasta.TabIndex = 11
        Me.lblhasta.Text = "Hasta"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(58, 291)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(38, 13)
        Me.lbldesde.TabIndex = 10
        Me.lbldesde.Text = "Desde"
        '
        'dtpdesde
        '
        Me.dtpdesde.Location = New System.Drawing.Point(103, 285)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpdesde.TabIndex = 9
        Me.dtpdesde.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'dtphasta
        '
        Me.dtphasta.Location = New System.Drawing.Point(103, 311)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(200, 20)
        Me.dtphasta.TabIndex = 8
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(370, 282)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(75, 23)
        Me.btnver.TabIndex = 7
        Me.btnver.Text = "Ver"
        Me.btnver.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(451, 282)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'verdocumentoslegales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.lblhasta)
        Me.Controls.Add(Me.lbldesde)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "verdocumentoslegales"
        Me.Text = "Documentos legales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rid As DataGridViewTextBoxColumn
    Friend WithEvents rnorecibo As DataGridViewTextBoxColumn
    Friend WithEvents rnofactura As DataGridViewTextBoxColumn
    Friend WithEvents rnombre As DataGridViewTextBoxColumn
    Friend WithEvents rfecha As DataGridViewTextBoxColumn
    Friend WithEvents rcita As DataGridViewTextBoxColumn
    Friend WithEvents rmonto As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents lblhasta As Label
    Friend WithEvents lbldesde As Label
    Friend WithEvents dtpdesde As DateTimePicker
    Friend WithEvents dtphasta As DateTimePicker
    Friend WithEvents btnver As Button
    Friend WithEvents btnlimpiar As Button
End Class
