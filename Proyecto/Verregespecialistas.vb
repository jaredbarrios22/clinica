Imports System.Data.Odbc
Public Class Verregespecialistas
    Private Sub Verregespecialistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerregistrosreflab()
    End Sub

    Private Sub obtenerregistrosreflab()
        Try
            Dim sql As String = "select doces.nombre ||' '|| doces.apellido ||' '|| doces.especialidad, refes.fechaemision, refes.causa, pa.nombre
            from referencia_especialista refes, doctores_especialistas doces, paciente pa
            where pa.idpaciente= refes.idpaciente
            and refes.iddoctor= doces.iddoctor;"
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

    Private Sub lbldocumentos_Click(sender As Object, e As EventArgs) Handles lbldocumentos.Click

    End Sub
End Class