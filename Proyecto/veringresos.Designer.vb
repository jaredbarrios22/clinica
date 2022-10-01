<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class veringresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(veringresos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnorecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnofactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnombreemitir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbldocumentos = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.rnorecibo, Me.rnofactura, Me.rnombreemitir})
        Me.DataGridView1.Location = New System.Drawing.Point(199, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'cid
        '
        Me.cid.HeaderText = "NombreLaboratorio"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        '
        'rnorecibo
        '
        Me.rnorecibo.HeaderText = "Descripcion"
        Me.rnorecibo.Name = "rnorecibo"
        Me.rnorecibo.ReadOnly = True
        '
        'rnofactura
        '
        Me.rnofactura.HeaderText = "FechaEmision"
        Me.rnofactura.Name = "rnofactura"
        Me.rnofactura.ReadOnly = True
        '
        'rnombreemitir
        '
        Me.rnombreemitir.HeaderText = "Nombre Paciente"
        Me.rnombreemitir.Name = "rnombreemitir"
        Me.rnombreemitir.ReadOnly = True
        '
        'lbldocumentos
        '
        Me.lbldocumentos.AutoSize = True
        Me.lbldocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocumentos.Location = New System.Drawing.Point(343, 25)
        Me.lbldocumentos.Name = "lbldocumentos"
        Me.lbldocumentos.Size = New System.Drawing.Size(177, 13)
        Me.lbldocumentos.TabIndex = 1
        Me.lbldocumentos.Text = "Registro Referencias Emitidas"
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(381, 330)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 22)
        Me.btncerrar.TabIndex = 11
        Me.btncerrar.Text = "Regresar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'veringresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lbldocumentos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "veringresos"
        Me.Text = "veringresos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbldocumentos As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents cid As DataGridViewTextBoxColumn
    Friend WithEvents rnorecibo As DataGridViewTextBoxColumn
    Friend WithEvents rnofactura As DataGridViewTextBoxColumn
    Friend WithEvents rnombreemitir As DataGridViewTextBoxColumn
End Class
