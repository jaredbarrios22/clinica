Imports System.Data.Odbc
Public Class verdocumentos
    Private Sub verdocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verdocumento()
    End Sub

    Private Sub verdocumento()
        Try
            Dim sql As String = "select doc.norecibo, doc.nofactura, doc.nombreemitir, doc.fechaemision, doc.monto, doc.nit, pa.nombre
            from citas ci
            right outer join documento_legal doc
            on ci.idcita = doc.idcita
            left outer join paciente pa
            on ci.idpaciente=pa.idpaciente;"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            While dr.Read()
                DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()


    End Sub
End Class