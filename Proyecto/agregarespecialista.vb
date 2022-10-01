Imports System.Data.Odbc
Public Class agregarespecialista
    Private Sub agregarespecialista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtenerdatos()
    End Sub

    Private Sub generaridespecialista()
        Dim sql As String = "select sq_agregarespecialista.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtiddoctor.Text = dr.GetString(0)
    End Sub

    Private Sub obtenerdatos()
        DataGridView1.Rows.Clear()
        Try
            Dim sql As String = "select nombre, apellido, especialidad, telefono from doctores_especialistas"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Call generaridespecialista()
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into doctores_especialistas values('" & txtiddoctor.Text & "',
                '" & txtnombre.Text & "','" & txtapellido.Text & "', '" & txtespecialidad.Text & "', '" & txttelefono.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call obtenerdatos()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtapellido.Clear()
        txtespecialidad.Clear()
        txtiddoctor.Clear()
        txtnombre.Clear()
        txttelefono.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class