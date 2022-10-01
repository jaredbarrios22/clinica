Imports System.Data.Odbc
Public Class AddAnGineco
    Public contar As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(idcodpacientecita)
        Txtcod.Text = idcodpacientecita
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
        If Txtcod.Text = "" Then

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
        Dim sql As String = "select count(*) idantecedentegineco from antecedente_gineco where idpaciente='" & Txtcod.Text & "'"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        contar = dr.GetString(0)
    End Sub

    Private Sub obtenerdatos()
        If contar > 0 Then
            Try
                Dim sql As String = "select * from antecedente_gineco
                where idpaciente='" & Txtcod.Text & "'"
                Dim cmd As New OdbcCommand(sql, conexion)
                cmd.CommandType = CommandType.Text
                Dim dr As OdbcDataReader = cmd.ExecuteReader()
                While dr.Read()
                    txtid.Text = dr.GetString(0)
                    Txtcod.Text = dr.GetString(1)
                    cmbmenarquia.Text = dr.GetString(2)
                    cmbgestaciones.Text = dr.GetString(3)
                    cmbpartos.Text = dr.GetString(4)
                    cmbabortos.Text = dr.GetString(5)
                    cmbcesareas.Text = dr.GetString(6)
                    cmbhv.Text = dr.GetString(7)
                    dateUltimaMenstruacion.Value = dr.GetString(8)
                    datePosibleParto.Value = dr.GetString(9)
                    txtembarazo.Text = dr.GetString(10)
                    dateUltimoParto.Value = dr.GetString(11)
                    txtAnticos.Text = dr.GetString(12)
                    txtCicloMenstrual.Text = dr.GetString(13)
                    txtPapanicolau.Text = dr.GetString(14)
                    cmbRelaciones.Text = dr.GetString(15)
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("no existe antecedente")
        End If
    End Sub

    Private Sub generaridantecedente()
        Dim sql As String = "select sq_antecedente_gineco.nextval from dual;"
        Dim cmd As New OdbcCommand(sql, conexion)
        cmd.CommandType = CommandType.Text
        Dim dr As OdbcDataReader = cmd.ExecuteReader()
        dr.Read()
        txtid.Text = dr.GetString(0)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Call generaridantecedente()
        Dim fecha As Date
        fecha = dateUltimaMenstruacion.Value
        txtfur.Text = fecha
        fechas = txtfur.Text

        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("insert into antecedente_gineco(idantecedentegineco, idpaciente, menarquia,gestaciones,fur)
                values ('" & txtid.Text & "','" & Txtcod.Text & "','" & cmbmenarquia.Text & "','" & cmbgestaciones.Text & "',?)")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                fecha = datePosibleParto.Value
                txtfpp.Text = fecha
                fechas = txtfpp.Text


                guardardatos("update  antecedente_gineco set partos=('" & cmbpartos.Text & "'),
                abortos=('" & cmbabortos.Text & "'), cesareas=('" & cmbcesareas.Text & "'),
                hv=('" & cmbhv.Text & "'),fpp=(?)
                where idpaciente='" & Txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                fecha = dateUltimoParto.Value
                txtfup.Text = fecha
                fechas = txtfup.Text

                guardardatos("update  antecedente_gineco set embarazode=('" & txtembarazo.Text & "'),
                relacionessexuales=('" & cmbRelaciones.Text & "'),acosinyeccion=('" & txtAnticos.Text & "'),
                ciclomenstrual=('" & txtCicloMenstrual.Text & "'),papanicolau=('" & txtPapanicolau.Text & "'), fup=(?)
                where idpaciente='" & Txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim fecha As Date
        fecha = dateUltimaMenstruacion.Value
        txtfur.Text = fecha
        fechas = txtfur.Text

        Try
            If MessageBox.Show("¿Seguro que desea insertar este registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                guardardatos("update  antecedente_gineco set 
                    menarquia=('" & cmbmenarquia.Text & "'),
                    gestaciones=('" & cmbgestaciones.Text & "'),
                    partos=('" & cmbpartos.Text & "'),
                    abortos=('" & cmbabortos.Text & "'),
                    fur=(?)
                    where idpaciente='" & Txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                fecha = datePosibleParto.Value
                txtfpp.Text = fecha
                fechas = txtfpp.Text


                guardardatos("update  antecedente_gineco set cesareas=('" & cmbcesareas.Text & "'),hv=('" & cmbhv.Text & "'),
                embarazode=('" & txtembarazo.Text & "'),acosinyeccion=('" & txtAnticos.Text & "'),fpp=(?)
                where idpaciente='" & Txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                fecha = dateUltimoParto.Value
                txtfup.Text = fecha
                fechas = txtfup.Text

                guardardatos("update antecedente_gineco set 
                ciclomenstrual=('" & txtCicloMenstrual.Text & "'),papanicolau=('" & txtPapanicolau.Text & "'), 
                relacionessexuales=('" & cmbRelaciones.Text & "'), fup=(?)
                where idpaciente='" & Txtcod.Text & "'")
                MessageBox.Show("Registro exitoso", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAnticos.Clear()
        txtCicloMenstrual.Clear()
        txtembarazo.Clear()
        txtfpp.Clear()
        txtfup.Clear()
        txtfur.Clear()
        txtid.Clear()
        txtnombre.Clear()
        txtPapanicolau.Clear()
        Txtcod.Clear()
        datePosibleParto.Value = Date.Today
        dateUltimaMenstruacion.Value = Date.Today
        dateUltimoParto.Value = Date.Today


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class
