Imports System.Data.Odbc
Module conexionmodulo

    Public conexion As OdbcConnection
    Public comando As OdbcCommand
    Public fechas As Date = Today.Date
    Public fechas2 As Date = Today.Date
    Public idcodpacientecita As String
    Public idcitatraslado As String



    Public Sub abrirconexion()
        conexion = New OdbcConnection
        conexion.ConnectionString = "Dsn=oracleclient;UID=josueclinica;PWD=marzo2000;DATABASE=USERS.DBF"


        Try
            conexion.Open()
            MsgBox("Exito", MsgBoxStyle.OkOnly
                   )
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Public Sub guardardatos(ByVal cadena As String)
        comando = New OdbcCommand(cadena, conexion)
        comando.Parameters.Add("?FECHA", OdbcType.DateTime).Value = fechas
        comando.Parameters.Add("¿fe", OdbcType.DateTime).Value = fechas2
        comando.ExecuteNonQuery()
    End Sub
End Module
