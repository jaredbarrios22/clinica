Imports System.Data.Odbc
Public Class ModificarPaciente
    Private Sub ModificarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtenerrelaciones()
        Call obtenertiposangre()
        Txtcodpaciente.Text = idcodpacientecita
        If Txtcodpaciente.Text = "" Then
            btnnuevo.Enabled = True
            btningresar.Enabled = False
        Else
            btningresar.Enabled = True
            btnnuevo.Enabled = False
            Call obtenerpaciente()

        End If

    End Sub

    Private Sub obtenerrelaciones()
        Dim sql As String = "select * from relacion_sentimental"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            cmbidrelacion.Items.Add(dr.GetString(0))
            cmbrelacion.Items.Add(dr.GetString(1))
        End While
    End Sub

    Private Sub obtenertiposangre()
        Dim sql As String = "select * from tipo_sangre"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            cmbidtiposangre.Items.Add(dr.GetString(0))
            cmbtipodesangre.Items.Add(dr.GetString(1))
        End While
    End Sub

    Private Sub obtenerpaciente()
        Try
            Dim sql As String = "select pa.nombre, pa.apellido, pa.direccion, pa.fechanac, pa.ocupacion, rela.descripcion,
            pa.telefono, tisa.descripcion, pa.fecharegistro,pa.religion,pa.email
            from paciente pa
            left outer join tipo_sangre tisa on pa.tipodesangre=tisa.idtiposangre
            left outer join  relacion_sentimental rela
            on pa.relacion_sentimental=rela.idrelacion
            where idpaciente='" & Txtcodpaciente.Text & "'"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read
                txtnombre.Text = dr.GetString(0)
                txtapellido.Text = dr.GetString(1)
                txtdireccion.Text = dr.GetString(2)
                txtfechanac.Text = dr.GetString(3)
                dtpfechanacimiento.Value = dr.GetString(3)
                txtocupacion.Text = dr.GetString(4)
                cmbrelacion.Text = dr.GetString(5)
                txttelefono.Text = dr.GetString(6)
                cmbtipodesangre.Text = dr.GetString(7)
                txtfechareg.Text = dr.GetString(8)
                dtpfechareg.Value = dr.GetString(8)
                txtreligion.Text = dr.GetString(9)
                txtemail.Text = dr.GetString(10)
            End While
        Catch ex As Exception
            If ex.Message <> "No se puede convertir un objeto de tipo 'System.DBNull' al tipo 'System.String'." Then
                MsgBox(ex.Message)
            End If

        End Try


    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim fecha As Date
        fecha = dtpfechanacimiento.Value
        txtfechanac.Text = fecha
        fechas = txtfechanac.Text
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("update paciente set nombre=('" & txtnombre.Text & "'), apellido=('" & txtapellido.Text & "'), 
                direccion=('" & txtdireccion.Text & "'), ocupacion=('" & txtocupacion.Text & "'),
                relacion_sentimental=('" & cmbidrelacion.Text & "'), fechanac=(?)
                where idpaciente='" & Txtcodpaciente.Text & "'")

                fecha = dtpfechareg.Value
                txtfechareg.Text = fecha
                fechas = txtfechareg.Text
                guardardatos("update paciente set telefono=('" & txttelefono.Text & "'), tipodesangre=('" & cmbidtiposangre.Text & "'), 
                religion=('" & txtreligion.Text & "'), email=('" & txtemail.Text & "'),
                fecharegistro=(?)
                where idpaciente='" & Txtcodpaciente.Text & "'")

                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbtipodesangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipodesangre.SelectedIndexChanged
        cmbidtiposangre.SelectedIndex = cmbtipodesangre.SelectedIndex

    End Sub

    Private Sub cmbrelacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbrelacion.SelectedIndexChanged
        cmbidrelacion.SelectedIndex = cmbrelacion.SelectedIndex
    End Sub

    Private Sub btnvolvercita_Click(sender As Object, e As EventArgs) Handles btnvolvercita.Click

        Me.Hide()
        MDIParent1.Show()
    End Sub

    Private Sub generaridpaciente()
        Dim sql As String = "select sq_paciente.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        Txtcodpaciente.Text = dr.GetString(0)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Call generaridpaciente()
        Dim fecha As Date
        fecha = dtpfechanacimiento.Value
        txtfechanac.Text = fecha
        fechas = txtfechanac.Text
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into paciente
                (idpaciente,nombre,apellido,direccion,fechanac,ocupacion,relacion_sentimental,telefono,tipodesangre,religion,email)
                values ('" & Txtcodpaciente.Text & "','" & txtnombre.Text & "','" & txtapellido.Text & "',
                '" & txtdireccion.Text & "',?,'" & txtocupacion.Text & "','" & cmbidrelacion.Text & "',
                '" & txttelefono.Text & "','" & cmbidtiposangre.Text & "','" & txtreligion.Text & "','" & txtemail.Text & "')")

                fecha = dtpfechareg.Value
                txtfechareg.Text = fecha
                fechas = txtfechareg.Text
                guardardatos("update paciente set fecharegistro=(?)
                where idpaciente='" & Txtcodpaciente.Text & "'")

                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtapellido.Clear()
        txtdireccion.Clear()
        txtemail.Clear()
        txtfechanac.Clear()
        txtfechareg.Clear()
        txtnombre.Clear()
        txtocupacion.Clear()
        txtreligion.Clear()
        txttelefono.Clear()
        Txtcodpaciente.Clear()
        dtpfechanacimiento.Value = Date.Today
        dtpfechareg.Value = Date.Today
        cmbrelacion.Text = ""

    End Sub
End Class