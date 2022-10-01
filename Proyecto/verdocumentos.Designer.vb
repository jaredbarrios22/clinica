<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verdocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verdocumentos))
        Me.lbldocumentos = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnorecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnofactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnombreemitir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelacionSentimental = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldocumentos
        '
        Me.lbldocumentos.AutoSize = True
        Me.lbldocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocumentos.Location = New System.Drawing.Point(27, 83)
        Me.lbldocumentos.Name = "lbldocumentos"
        Me.lbldocumentos.Size = New System.Drawing.Size(128, 13)
        Me.lbldocumentos.TabIndex = 15
        Me.lbldocumentos.Text = "Registro Documentos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.rnorecibo, Me.rnofactura, Me.rnombreemitir, Me.RelacionSentimental, Me.TipoSangre, Me.Paciente})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 269)
        Me.DataGridView1.TabIndex = 14
        '
        'cid
        '
        Me.cid.HeaderText = "NORecibo"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        '
        'rnorecibo
        '
        Me.rnorecibo.HeaderText = "NOFactura"
        Me.rnorecibo.Name = "rnorecibo"
        Me.rnorecibo.ReadOnly = True
        '
        'rnofactura
        '
        Me.rnofactura.HeaderText = "Emitido a Nombre de"
        Me.rnofactura.Name = "rnofactura"
        Me.rnofactura.ReadOnly = True
        '
        'rnombreemitir
        '
        Me.rnombreemitir.HeaderText = "Fecha Emision"
        Me.rnombreemitir.Name = "rnombreemitir"
        Me.rnombreemitir.ReadOnly = True
        '
        'RelacionSentimental
        '
        Me.RelacionSentimental.HeaderText = "Monto"
        Me.RelacionSentimental.Name = "RelacionSentimental"
        '
        'TipoSangre
        '
        Me.TipoSangre.HeaderText = "Nit"
        Me.TipoSangre.Name = "TipoSangre"
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'verdocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbldocumentos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "verdocumentos"
        Me.Text = "verdocumentos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldocumentos As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents cid As DataGridViewTextBoxColumn
    Friend WithEvents rnorecibo As DataGridViewTextBoxColumn
    Friend WithEvents rnofactura As DataGridViewTextBoxColumn
    Friend WithEvents rnombreemitir As DataGridViewTextBoxColumn
    Friend WithEvents RelacionSentimental As DataGridViewTextBoxColumn
    Friend WithEvents TipoSangre As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
End Class
