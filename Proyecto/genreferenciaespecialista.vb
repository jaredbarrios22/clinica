Imports System.Data.Odbc
Public Class genreferenciaespecialista
    Private Sub genreferenciaespecialista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        txtcodpaciente.Text = idcodpacientecita
        Call obtenerdoctores()
        Call obtenerdatos()
        Call obtenerpaciente()
    End Sub

    Private Sub obtenerdoctores()
        Try
            Dim sql As String = "select iddoctor, nombre ||' '||apellido||' '||especialidad from doctores_especialistas"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                cmbcodigodoctor.Items.Add(dr.GetString(0))
                cmbespecialista.Items.Add(dr.GetString(1))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub obtenerdatos()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select doces.nombre ||' '|| doces.apellido ||' '|| doces.especialidad, refes.fechaemision, refes.causa 
        from referencia_especialista refes, doctores_especialistas doces, paciente pa
        where pa.idpaciente= refes.idpaciente
        and refes.iddoctor= doces.iddoctor
        and pa.idpaciente='" & txtcodpaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2))
        End While
    End Sub

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_referencia_especialista.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtcodreferencia.Text = dr.GetString(0)
    End Sub
    Private Sub obtenerpaciente()
        Dim sql As String = "select nombre||' '||apellido from paciente where idpaciente='" & txtcodpaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtpaciente.Text = dr.GetString(0)
    End Sub


    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Call generaridantecedente()
        Dim fecha As Date
        fecha = fechaemisionselect.Value
        Txtfecha.Text = fecha
        fechas = Txtfecha.Text
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into referencia_especialista(idreferencia, iddoctor, idpaciente,causa,fechaemision)
                values('" & txtcodreferencia.Text & "','" & cmbcodigodoctor.Text & "','" & txtcodpaciente.Text &
                             "', '" & txtcausa.Text & "',?)")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call obtenerdatos()
    End Sub

    Private Sub cmbespecialista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbespecialista.SelectedIndexChanged
        cmbcodigodoctor.SelectedIndex = cmbespecialista.SelectedIndex
    End Sub

    Private Sub cmbcodigodoctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcodigodoctor.SelectedIndexChanged
        cmbespecialista.SelectedIndex = cmbcodigodoctor.SelectedIndex
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcausa.Clear()
        txtcodpaciente.Clear()
        txtcodreferencia.Clear()
        txtfecha.Clear()
        txtpaciente.Clear()
        fechaemisionselect.Value = Date.Today()
        cmbespecialista.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class