<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PACEINTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCitasDelDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratoriosEspecialistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEspecialistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRefLaboratoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRefEspecialistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACEINTESToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.LaboratoriosEspecialistasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'PACEINTESToolStripMenuItem
        '
        Me.PACEINTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendarCitaToolStripMenuItem, Me.VerCitasDelDiaToolStripMenuItem})
        Me.PACEINTESToolStripMenuItem.Name = "PACEINTESToolStripMenuItem"
        Me.PACEINTESToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.PACEINTESToolStripMenuItem.Text = "Citas"
        '
        'AgendarCitaToolStripMenuItem
        '
        Me.AgendarCitaToolStripMenuItem.Name = "AgendarCitaToolStripMenuItem"
        Me.AgendarCitaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgendarCitaToolStripMenuItem.Text = "Agendar Cita"
        '
        'VerCitasDelDiaToolStripMenuItem
        '
        Me.VerCitasDelDiaToolStripMenuItem.Name = "VerCitasDelDiaToolStripMenuItem"
        Me.VerCitasDelDiaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerCitasDelDiaToolStripMenuItem.Text = "Ver citas del dia"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarPacientesToolStripMenuItem, Me.VerPacientesToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'IngresarPacientesToolStripMenuItem
        '
        Me.IngresarPacientesToolStripMenuItem.Name = "IngresarPacientesToolStripMenuItem"
        Me.IngresarPacientesToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.IngresarPacientesToolStripMenuItem.Text = "Ingresar Pacientes"
        '
        'VerPacientesToolStripMenuItem
        '
        Me.VerPacientesToolStripMenuItem.Name = "VerPacientesToolStripMenuItem"
        Me.VerPacientesToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerPacientesToolStripMenuItem.Text = "Ver pacientes"
        '
        'LaboratoriosEspecialistasToolStripMenuItem
        '
        Me.LaboratoriosEspecialistasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarLaboratorioToolStripMenuItem, Me.AgregarEspecialistaToolStripMenuItem, Me.VerRefLaboratoriosToolStripMenuItem, Me.VerRefEspecialistasToolStripMenuItem})
        Me.LaboratoriosEspecialistasToolStripMenuItem.Name = "LaboratoriosEspecialistasToolStripMenuItem"
        Me.LaboratoriosEspecialistasToolStripMenuItem.Size = New System.Drawing.Size(155, 20)
        Me.LaboratoriosEspecialistasToolStripMenuItem.Text = "Laboratorios/Especialistas"
        '
        'AgregarLaboratorioToolStripMenuItem
        '
        Me.AgregarLaboratorioToolStripMenuItem.Name = "AgregarLaboratorioToolStripMenuItem"
        Me.AgregarLaboratorioToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AgregarLaboratorioToolStripMenuItem.Text = "Laboratorios"
        '
        'AgregarEspecialistaToolStripMenuItem
        '
        Me.AgregarEspecialistaToolStripMenuItem.Name = "AgregarEspecialistaToolStripMenuItem"
        Me.AgregarEspecialistaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AgregarEspecialistaToolStripMenuItem.Text = "Especialistas"
        '
        'VerRefLaboratoriosToolStripMenuItem
        '
        Me.VerRefLaboratoriosToolStripMenuItem.Name = "VerRefLaboratoriosToolStripMenuItem"
        Me.VerRefLaboratoriosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.VerRefLaboratoriosToolStripMenuItem.Text = "Registro Ref. Laboratorios"
        '
        'VerRefEspecialistasToolStripMenuItem
        '
        Me.VerRefEspecialistasToolStripMenuItem.Name = "VerRefEspecialistasToolStripMenuItem"
        Me.VerRefEspecialistasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.VerRefEspecialistasToolStripMenuItem.Text = "Registro Ref. Especialistas"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(686, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Clinica Elias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents PACEINTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendarCitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCitasDelDiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarPacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaboratoriosEspecialistasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLaboratorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEspecialistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerRefLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerRefEspecialistasToolStripMenuItem As ToolStripMenuItem
End Class
