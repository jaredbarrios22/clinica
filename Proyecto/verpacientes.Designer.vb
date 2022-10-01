<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verpacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(verpacientes))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lbldocumentos = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnorecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnofactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnombreemitir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelacionSentimental = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSangre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(380, 367)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 22)
        Me.btncerrar.TabIndex = 14
        Me.btncerrar.Text = "Regresar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'lbldocumentos
        '
        Me.lbldocumentos.AutoSize = True
        Me.lbldocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocumentos.Location = New System.Drawing.Point(365, 49)
        Me.lbldocumentos.Name = "lbldocumentos"
        Me.lbldocumentos.Size = New System.Drawing.Size(114, 13)
        Me.lbldocumentos.TabIndex = 13
        Me.lbldocumentos.Text = "Registro Pacientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.rnorecibo, Me.rnofactura, Me.rnombreemitir, Me.RelacionSentimental, Me.TipoSangre})
        Me.DataGridView1.Location = New System.Drawing.Point(85, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 269)
        Me.DataGridView1.TabIndex = 12
        '
        'cid
        '
        Me.cid.HeaderText = "Nombre Completo"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        '
        'rnorecibo
        '
        Me.rnorecibo.HeaderText = "Direccion"
        Me.rnorecibo.Name = "rnorecibo"
        Me.rnorecibo.ReadOnly = True
        '
        'rnofactura
        '
        Me.rnofactura.HeaderText = "FechaNacimiento"
        Me.rnofactura.Name = "rnofactura"
        Me.rnofactura.ReadOnly = True
        '
        'rnombreemitir
        '
        Me.rnombreemitir.HeaderText = "Ocupacion"
        Me.rnombreemitir.Name = "rnombreemitir"
        Me.rnombreemitir.ReadOnly = True
        '
        'RelacionSentimental
        '
        Me.RelacionSentimental.HeaderText = "RelacionSentimental"
        Me.RelacionSentimental.Name = "RelacionSentimental"
        '
        'TipoSangre
        '
        Me.TipoSangre.HeaderText = "TipoSangre"
        Me.TipoSangre.Name = "TipoSangre"
        '
        'verpacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lbldocumentos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "verpacientes"
        Me.Text = "verpacientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents lbldocumentos As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cid As DataGridViewTextBoxColumn
    Friend WithEvents rnorecibo As DataGridViewTextBoxColumn
    Friend WithEvents rnofactura As DataGridViewTextBoxColumn
    Friend WithEvents rnombreemitir As DataGridViewTextBoxColumn
    Friend WithEvents RelacionSentimental As DataGridViewTextBoxColumn
    Friend WithEvents TipoSangre As DataGridViewTextBoxColumn
End Class
