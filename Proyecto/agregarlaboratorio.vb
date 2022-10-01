Imports System.Data.Odbc
Public Class agregarlaboratorio
    Private Sub agregarlaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtenerdatos()

    End Sub

    Private Sub generaridlaboratorio()
        Dim sql As String = "select sq_agregarlaboratorio.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidlaboratorio.Text = dr.GetString(0)
    End Sub

    Private Sub obtenerdatos()
        DataGridView1.Rows.Clear()
        Try
            Dim sql As String = "select nombrelaboratorio, direccion, telefono from laboratorios_referidos"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Call generaridlaboratorio()
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into laboratorios_referidos values('" & txtidlaboratorio.Text & "',
                '" & txtnombrelab.Text & "','" & txtdireccion.Text & "', '" & txttelefono.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Call obtenerdatos()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtdireccion.Clear()
        txtidlaboratorio.Clear()
        txtnombrelab.Clear()
        txttelefono.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class