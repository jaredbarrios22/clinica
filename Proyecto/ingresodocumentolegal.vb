Imports System.Data.Odbc
Public Class ingresodocumentolegal
    Private Sub ingresodocumentolegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidcita.Text = idcitatraslado
    End Sub

    Private Sub generarid()
        Try
            Dim sql As String = "select sq_iddocumento.nextval from dual;"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            txtiddocumento.Text = dr.GetString(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        generarid()
        Dim fecha As Date
        fecha = dtpfecha.Value
        txtfecha.Text = fecha
        fechas = txtfecha.Text
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into documento_legal values('" & txtiddocumento.Text & "','" & txtnorecibo.Text & "',
                '" & txtnofactura.Text & "','" & txtnombre.Text & "',?,'" & txtidcita.Text & "','" & txtmonto.Text & "',
                '" & txtnit.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtfecha.Clear()
        txtidcita.Clear()
        txtiddocumento.Clear()
        txtmonto.Clear()
        txtnit.Clear()
        txtnofactura.Clear()
        txtnombre.Clear()
        txtnorecibo.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class