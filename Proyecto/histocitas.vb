Imports System.Data.Odbc
Public Class histocitas
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub

    Private Sub histocitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcopaciente.Text = idcodpacientecita
        Call obtenerpaciente()
        Call llenardatos()
    End Sub

    Private Sub obtenerpaciente()


        Dim sql As String = "select nombre ||' '||apellido from paciente where idpaciente='" & txtcopaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtpaciente.Text = dr.GetString(0)


    End Sub

    Private Sub llenardatos()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select ci.motivocita, ci.diagnostico, tra.descripciontratamiento, ci.fechacita
    from paciente pa, citas ci, tratamientos tra
    where pa.idpaciente=ci.idpaciente
    and ci.idcita=tra.idcita
    and pa.idpaciente='" & txtcopaciente.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        While dr.Read()
            DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3))
        End While

    End Sub
End Class