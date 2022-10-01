Imports System.Data.Odbc
Public Class AddAnAlergias

    Public contar As Integer
    Private Sub AddAnAlergias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        Txtcod.Text = idcodpacientecita
        Call obtenerpaciente()
        Call obtenernoantecedente()
        Call obtenerdatos()
    End Sub

    Private Sub obtenerpaciente()
        If txtcod.Text = "" Then

        Else
            Dim sql As String = "select nombre ||' '||apellido from paciente where idpaciente='" & Txtcod.Text & "'"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            txtnombre.Text = dr.GetString(0)
        End If

    End Sub

    Public Sub obtenernoantecedente()
        Dim sql As String = "select count(*) idantecedentealergia from antecedente_alergias where idpaciente='" & Txtcod.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        contar = dr.GetString(0)

    End Sub

    Private Sub obtenerdatos()
        If contar > 0 Then
            Try


                DataGridView1.Rows.Clear()
                Dim sql As String = "select descripcionalergia, medicamentosalergia
                from antecedente_alergias
                where idpaciente='" & Txtcod.Text & "'"
                Dim cmd As New OdbcCommand(sql, conexion)
                cmd.CommandType = CommandType.Text
                Dim dr As OdbcDataReader = cmd.ExecuteReader()
                While dr.Read()
                    DataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("pendejo")
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Call generaridantecedente()
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into antecedente_alergias values('" & txtidantecedente.Text & "','" & Txtcod.Text & "','" & txtDescripcionAlergia.Text &
                             "', '" & txtMedicamentoAlergia.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call obtenernoantecedente()
        Call obtenerdatos()
    End Sub

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_antecedenteale.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidantecedente.Text = dr.GetString(0)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescripcionAlergia.Clear()
        txtidantecedente.Clear()
        txtMedicamentoAlergia.Clear()
        Txtcod.Clear()
        Txtnombre.Clear()


    End Sub
End Class