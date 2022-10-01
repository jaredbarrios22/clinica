Imports System.Data.Odbc
Public Class AddExaFisico
    Public contar As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        txtcod.Text = idcodpacientecita
        Call obtenerpaciente()
        Call obtenernoantecedente()
        Call obtenerdatos()


        If contar <= 0 Then
            btnIngresar.Enabled = True
            btnactualizar.Enabled = False
        Else
            btnIngresar.Enabled = False
            btnactualizar.Enabled = True
        End If

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
        Dim sql As String = "select count(*) idexamenfisico from examen_fisico where idpaciente='" & txtcod.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        contar = dr.GetString(0)
    End Sub

    Private Sub obtenerdatos()
        If contar > 0 Then
            Try
                Dim sql As String = "select * from examen_fisico
                where idpaciente='" & txtcod.Text & "'"
                Dim cmd As New OdbcCommand(sql, conexion)
                cmd.CommandType = CommandType.Text
                Dim dr As OdbcDataReader = cmd.ExecuteReader()
                While dr.Read()
                    txtidexamen.Text = dr.GetString(0)
                    txtcod.Text = dr.GetString(1)
                    txtPeso.Text = dr.GetString(2)
                    txtImpresionClinica.Text = dr.GetString(3)
                    txtUltrasonido.Text = dr.GetString(4)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("pendejo")
        End If
    End Sub

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_antecedentefam.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtidexamen.Text = dr.GetString(0)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Call generaridantecedente()
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into examen_fisico values('" & txtidexamen.Text & "','" & txtcod.Text & "'
                ,'" & txtPeso.Text & "', '" & txtImpresionClinica.Text & "','" & txtUltrasonido.Text & "')")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("update examen_fisico set peso=('" & txtPeso.Text & "'),
                impresionclinica=('" & txtImpresionClinica.Text & "'),
                ultrasonido=('" & txtUltrasonido.Text & "')where idpaciente='" & txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtcod.Clear()
        txtidexamen.Clear()
        txtImpresionClinica.Clear()
        txtnombre.Clear()
        txtPeso.Clear()
        txtUltrasonido.Clear()

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class