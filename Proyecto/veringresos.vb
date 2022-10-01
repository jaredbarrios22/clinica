Imports System.Data.Odbc
Public Class veringresos
    Private Sub veringresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call obtenerregistrosreflab()
    End Sub

    Private Sub obtenerregistrosreflab()
        Try
            Dim sql As String = "select labs.nombrelaboratorio, reflab.descripcion, reflab.fechaemision, pa.nombre
            From laboratorios_referidos labs, paciente pa, referencia_laboratorio reflab
            Where pa.idpaciente = reflab.idpaciente
            And reflab.idlaboratorio= labs.idlaboratorio"
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

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class