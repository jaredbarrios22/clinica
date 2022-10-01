Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class CitaExpress
    Private Sub CitaExpress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtenerpacientes()
    End Sub

    Private Sub generaridpaciente()
        Dim sql As String = "select sq_paciente.nextval from dual"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtcodigo.Text = dr.GetString(0)
    End Sub

    Private Sub generaridcita()
        Dim sql As String = "select sq_citas.nextval from dual"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidcita.Text = dr.GetString(0)
    End Sub
    Private Sub obtenerpacientes()
        Dim sql As String = "select idpaciente, concat (apellido, concat(' , ', nombre))as NC  from paciente order by NC;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            cmbidpaciente.Items.Add(dr.GetString(0))
            cmbpaciente.Items.Add(dr.GetString(1))
        End While


    End Sub



    Private Sub dtpfecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpfecha.ValueChanged

    End Sub

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles Btningresar.Click

        Call generaridcita()
        Call generaridpaciente()
        Dim fecha As Date
        fecha = dtpfecha.Value
        Txtfecha.Text = fecha
        fechas = Txtfecha.Text
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into paciente (idpaciente,nombre,apellido)values('" & txtcodigo.Text & "','" & txtnombres.Text & "','" & txtapellidos.Text & "')")

                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call obtenerpacientes()
        
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into citas(idcita, idpaciente,fechacita)values('" & txtidcita.Text & "','" & txtcodigo.Text & "',?)")

                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtapellidos.Clear()
        txtcodigo.Clear()
        txtidcita.Clear()
        txtnombres.Clear()
        Txtfecha.Clear()
        dtpfecha.Value = Date.Today()

    End Sub

    Private Sub cmbpaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpaciente.SelectedIndexChanged
        cmbidpaciente.SelectedIndex = cmbpaciente.SelectedIndex

    End Sub

    Private Sub cmbidpaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbidpaciente.SelectedIndexChanged
        cmbpaciente.SelectedIndex = cmbidpaciente.SelectedIndex

    End Sub

    Private Sub Btningresocitape_Click(sender As Object, e As EventArgs) Handles Btningresocitape.Click
        Call generaridcita()
        Dim fecha As Date
        fecha = dtpfecha.Value
        Txtfecha.Text = fecha
        fechas = Txtfecha.Text

        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into citas(idcita, idpaciente,fechacita)values('" & txtidcita.Text & "','" & cmbidpaciente.Text & "',?)")

                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class