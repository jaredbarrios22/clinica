<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verregespecialistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verregespecialistas))
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.lbldocumentos = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnofactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnorecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnombreemitir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(390, 368)
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
        Me.lbldocumentos.Location = New System.Drawing.Point(344, 21)
        Me.lbldocumentos.Name = "lbldocumentos"
        Me.lbldocumentos.Size = New System.Drawing.Size(183, 13)
        Me.lbldocumentos.TabIndex = 13
        Me.lbldocumentos.Text = "Registro Especialistas Emitidos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.rnofactura, Me.rnorecibo, Me.rnombreemitir})
        Me.DataGridView1.Location = New System.Drawing.Point(199, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 269)
        Me.DataGridView1.TabIndex = 12
        '
        'cid
        '
        Me.cid.HeaderText = "NombreEspecialista"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        '
        'rnofactura
        '
        Me.rnofactura.HeaderText = "FechaEmision"
        Me.rnofactura.Name = "rnofactura"
        Me.rnofactura.ReadOnly = True
        '
        'rnorecibo
        '
        Me.rnorecibo.HeaderText = "Descripcion"
        Me.rnorecibo.Name = "rnorecibo"
        Me.rnorecibo.ReadOnly = True
        '
        'rnombreemitir
        '
        Me.rnombreemitir.HeaderText = "Nombre Paciente"
        Me.rnombreemitir.Name = "rnombreemitir"
        Me.rnombreemitir.ReadOnly = True
        '
        'Verregespecialistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.lbldocumentos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Verregespecialistas"
        Me.Text = "Verregespecialistas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncerrar As Button
    Friend WithEvents lbldocumentos As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cid As DataGridViewTextBoxColumn
    Friend WithEvents rnofactura As DataGridViewTextBoxColumn
    Friend WithEvents rnorecibo As DataGridViewTextBoxColumn
    Friend WithEvents rnombreemitir As DataGridViewTextBoxColumn
End Class
