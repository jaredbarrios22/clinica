Public Class guardarcitatratamiento
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        cmbpaciente.Text = ""
        dptfecha.Value = Date.Today()
        txtmotivo.Clear()
        txtdiagnostico.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtcita.Clear()
        txtdescripcion.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class