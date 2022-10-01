<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresodocumentolegal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresodocumentolegal))
        Me.txtnorecibo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtnofactura = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.txtidcita = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtiddocumento = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnorecibo
        '
        Me.txtnorecibo.Location = New System.Drawing.Point(159, 153)
        Me.txtnorecibo.Name = "txtnorecibo"
        Me.txtnorecibo.Size = New System.Drawing.Size(211, 20)
        Me.txtnorecibo.TabIndex = 0
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(159, 179)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(570, 20)
        Me.txtnombre.TabIndex = 1
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(159, 258)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(211, 20)
        Me.txtmonto.TabIndex = 2
        '
        'txtnofactura
        '
        Me.txtnofactura.Location = New System.Drawing.Point(518, 156)
        Me.txtnofactura.Name = "txtnofactura"
        Me.txtnofactura.Size = New System.Drawing.Size(211, 20)
        Me.txtnofactura.TabIndex = 3
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(159, 205)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(211, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. de recibo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "No. de factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha de emision"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Monto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Documento legal"
        '
        'btningresar
        '
        Me.btningresar.Location = New System.Drawing.Point(295, 284)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(75, 23)
        Me.btningresar.TabIndex = 23
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(654, 285)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 22)
        Me.btnlimpiar.TabIndex = 24
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'txtidcita
        '
        Me.txtidcita.Location = New System.Drawing.Point(53, 12)
        Me.txtidcita.Name = "txtidcita"
        Me.txtidcita.Size = New System.Drawing.Size(54, 20)
        Me.txtidcita.TabIndex = 25
        Me.txtidcita.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "NIT"
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(159, 230)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(211, 20)
        Me.txtnit.TabIndex = 27
        '
        'txtiddocumento
        '
        Me.txtiddocumento.Location = New System.Drawing.Point(684, 12)
        Me.txtiddocumento.Name = "txtiddocumento"
        Me.txtiddocumento.Size = New System.Drawing.Size(54, 20)
        Me.txtiddocumento.TabIndex = 28
        Me.txtiddocumento.Visible = False
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(376, 208)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(121, 20)
        Me.txtfecha.TabIndex = 29
        Me.txtfecha.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ingresodocumentolegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 338)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtiddocumento)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtidcita)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.txtnofactura)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtnorecibo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ingresodocumentolegal"
        Me.Text = "Ingresar Documento Legal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnorecibo As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtnofactura As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btningresar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtidcita As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnit As TextBox
    Friend WithEvents txtiddocumento As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Button1 As Button
End Class
