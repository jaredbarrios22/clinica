Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirconexion()

    End Sub

    Private Sub AgendarCitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendarCitaToolStripMenuItem.Click
        CitaExpress.MdiParent = Me
        CitaExpress.Show()


    End Sub

    Private Sub LaboratoriosEspecialistasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PacienteNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VerCitasDelDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCitasDelDiaToolStripMenuItem.Click
        agendarcita.MdiParent = Me
        agendarcita.Show()


    End Sub

    Private Sub AgregarLaboratorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLaboratorioToolStripMenuItem.Click
        agregarlaboratorio.MdiParent = Me
        agregarlaboratorio.Show()


    End Sub

    Private Sub AgregarEspecialistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEspecialistaToolStripMenuItem.Click
        agregarespecialista.MdiParent = Me
        agregarespecialista.Show()


    End Sub

    Private Sub VerRefLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRefLaboratoriosToolStripMenuItem.Click
        veringresos.MdiParent = Me
        veringresos.Show()

    End Sub

    Private Sub VerRefEspecialistasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRefEspecialistasToolStripMenuItem.Click
        Verregespecialistas.MdiParent = Me
        Verregespecialistas.Show()


    End Sub

    Private Sub IngresarPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPacientesToolStripMenuItem.Click
        idcodpacientecita = ""
        ModificarPaciente.MdiParent = Me
        ModificarPaciente.Show()


    End Sub

    Private Sub VerPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPacientesToolStripMenuItem.Click
        verpacientes.MdiParent = Me
        verpacientes.Show()


    End Sub

    Private Sub GuardarDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        verdocumentos.MdiParent = Me
        verdocumentos.Show()


    End Sub

    Private Sub BuscarCitasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        buscarcitas.MdiParent = Me
        buscarcitas.Show()
    End Sub
End Class
