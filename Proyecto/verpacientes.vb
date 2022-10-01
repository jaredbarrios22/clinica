Imports System.Data.Odbc
Public Class verpacientes
    Private Sub verpacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call verpacientes()
    End Sub

    Private Sub verpacientes()
        Try
            Dim sql As String = "select pa.nombre||' '|| pa.apellido, pa.direccion, pa.fechanac, pa.ocupacion,rese.descripcion, tisa.descripcion
            from paciente pa, relacion_sentimental rese, tipo_sangre tisa
            where pa.tipodesangre=tisa.idtiposangre
            and pa.relacion_sentimental=rese.idrelacion;"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5))
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