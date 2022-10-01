Imports System.Data.Odbc

Public Class agendarcita
    Private Sub agendarcita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerpacientes()
    End Sub

    Private Sub obtenerpacientes()
        Dim sql As String = "select  pa.idpaciente, pa.nombre||' '||pa.apellido nc, ci.idcita, decode(fechanac,null, 'Sin Edad',round((sysdate-pa.fechanac)/365,0)) edad
        from citas ci, paciente pa  
        where pa.idpaciente=ci.idpaciente
        and ci.fechacita=TRUNC(sysdate)
        order by nc;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            Cmbidpaciente.Items.Add(dr.GetString(0))
            cmbpaciente.Items.Add(dr.GetString(1))
            cmbidcita.Items.Add(dr.GetString(2))
            cmbedad.Items.Add(dr.GetString(3))
        End While


    End Sub

    Private Sub obteneridtratamiento()
        Dim sql As String = "select sq_tratamientos.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidtratamiento.Text = dr.GetString(0)

    End Sub
    Private Sub cmbpaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpaciente.SelectedIndexChanged
        Cmbidpaciente.SelectedIndex = cmbpaciente.SelectedIndex
        cmbedad.SelectedIndex = cmbpaciente.SelectedIndex
        cmbidcita.SelectedIndex = cmbpaciente.SelectedIndex
    End Sub

    Private Sub Cmbidpaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbidpaciente.SelectedIndexChanged
        cmbpaciente.SelectedIndex = Cmbidpaciente.SelectedIndex
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        obteneridtratamiento()
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("update citas set motivocita=('" & txtmotivo.Text & "'), diagnostico=('" & txtdiagnostico.Text & "') where idcita='" & cmbidcita.Text & "'")
                guardardatos("insert into tratamientos values('" & txtidtratamiento.Text & "','" & cmbidcita.Text & "','" & txttratamiento.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnbiografia_Click(sender As Object, e As EventArgs) Handles btnbiografia.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            ModificarPaciente.Show()
        End If


    End Sub

    Private Sub binanqui_Click(sender As Object, e As EventArgs) Handles binanqui.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddAnQuirurg.Show()
        End If

    End Sub

    Private Sub btnanale_Click(sender As Object, e As EventArgs) Handles btnanale.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddAnAlergias.Show()
        End If
    End Sub

    Private Sub btnanmed_Click(sender As Object, e As EventArgs) Handles btnanmed.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddAnMedi.Show()
        End If
    End Sub

    Private Sub btnanfam_Click(sender As Object, e As EventArgs) Handles btnanfam.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddAnFamiliares.Show()
        End If
    End Sub

    Private Sub btnexamen_Click(sender As Object, e As EventArgs) Handles btnexamen.Click

        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddExaFisico.Show()
        End If

    End Sub

    Private Sub btnrefesp_Click(sender As Object, e As EventArgs) Handles btnrefesp.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            genreferenciaespecialista.Show()
        End If
    End Sub

    Private Sub btnreflab_Click(sender As Object, e As EventArgs) Handles btnreflab.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            genreferencialaboratorio.Show()
        End If
    End Sub

    Private Sub btnhisci_Click(sender As Object, e As EventArgs) Handles btnhisci.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            histocitas.Show()
        End If
    End Sub

    Private Sub btnangineco_Click(sender As Object, e As EventArgs) Handles btnangineco.Click
        idcodpacientecita = Cmbidpaciente.Text
        If idcodpacientecita = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            AddAnGineco.Show()
        End If
    End Sub

    Private Sub btndoc_Click(sender As Object, e As EventArgs) Handles btndoc.Click
        idcitatraslado = cmbidcita.Text
        If idcitatraslado = "" Then
            MsgBox("Por favor seleccione un paciente")
        Else
            ingresodocumentolegal.Show()
        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtdiagnostico.Clear()
        txtidtratamiento.Clear()
        txtmotivo.Clear()
        txttratamiento.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class