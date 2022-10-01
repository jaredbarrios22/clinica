Imports System.Data.Odbc
Public Class genreferencialaboratorio
    Private Sub genreferencialaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        txtcodpaciente.Text = idcodpacientecita
        Call obtenerlaboratorios()
        Call obtenerdatos()
        Call obtenerpaciente()
    End Sub

    Private Sub obtenerlaboratorios()
        Try
            Dim sql As String = "select idlaboratorio, nombrelaboratorio from laboratorios_referidos"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                Cmbcodigolabs.Items.Add(dr.GetString(0))
                cmblaboratorio.Items.Add(dr.GetString(1))

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub obtenerdatos()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select labs.nombrelaboratorio, reflab.descripcion, reflab.fechaemision
        from laboratorios_referidos labs, paciente pa, referencia_laboratorio reflab
        where pa.idpaciente= reflab.idpaciente
        and reflab.idlaboratorio= labs.idlaboratorio
        and pa.idpaciente='" & txtcodpaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2))
        End While
    End Sub

    Private Sub obtenerpaciente()
        Dim sql As String = "select nombre||' '||apellido from paciente where idpaciente='" & txtcodpaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtpaciente.Text = dr.GetString(0)
    End Sub

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_referencia_laboratorio.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtcodreferencia.Text = dr.GetString(0)
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Call generaridantecedente()
        Dim fecha As Date
        fecha = fechaemisionselect.Value
        txtfecha.Text = fecha
        fechas = txtfecha.Text
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into referencia_laboratorio(idreferencia, idpaciente, idlaboratorio,descripcion,fechaemision)
                values('" & txtcodreferencia.Text & "','" & txtcodpaciente.Text & "','" & Cmbcodigolabs.Text &
                             "', '" & txtdescripcion.Text & "',?)")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call obtenerdatos()
    End Sub

    Private Sub cmblaboratorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblaboratorio.SelectedIndexChanged
        Cmbcodigolabs.SelectedIndex = cmblaboratorio.SelectedIndex

    End Sub

    Private Sub Cmbcodigolabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcodigolabs.SelectedIndexChanged
        cmblaboratorio.SelectedIndex = Cmbcodigolabs.SelectedIndex

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtcodpaciente.Clear()
        txtcodreferencia.Clear()
        txtdescripcion.Clear()
        txtfecha.Clear()
        txtpaciente.Clear()
        cmblaboratorio.Text = ""
        fechaemisionselect.Value = Date.Today()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class