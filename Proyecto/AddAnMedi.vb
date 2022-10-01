Imports System.Data.Odbc
Public Class AddAnMedi

    Public contar As Integer

    Private Sub AddAnMedi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        txtcod.Text = idcodpacientecita
        Call obtenerpaciente()
        Call obtenernoantecedente()
        Call obtenerdatos()
    End Sub

    Private Sub obtenerpaciente()
        If txtcod.Text = "" Then

        Else
            Dim sql As String = "select nombre ||' '||apellido from paciente where idpaciente='" & txtcod.Text & "'"
            Dim cmd As New OdbcCommand(sql, conexion)
            cmd.CommandType = CommandType.Text
            Dim dr As OdbcDataReader = cmd.ExecuteReader()
            dr.Read()
            txtnombre.Text = dr.GetString(0)
        End If

    End Sub

    Public Sub obtenernoantecedente()
        Dim sql As String = "select count(*) idantecedentemedico from antecedente_medicos where idpaciente='" & txtcod.Text & "'"
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
                Dim sql As String = "select descripcionenfermedad, medicamentosenfermedad
                from antecedente_medicos
                where idpaciente='" & txtcod.Text & "'"
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

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_antecedentemed.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidantecedente.Text = dr.GetString(0)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Call generaridantecedente()
        Try

            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into antecedente_medicos values('" & txtidantecedente.Text & "','" & txtcod.Text & "','" & txtDescripcionEnfermedad.Text &
                             "', '" & txtMedicamentosEnfermedad.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call obtenernoantecedente()
        Call obtenerdatos()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtcod.Clear()
        txtDescripcionEnfermedad.Clear()
        txtidantecedente.Clear()
        txtMedicamentosEnfermedad.Clear()
        txtnombre.Clear()

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class