Imports MySql.Data
Imports MySql.Data.MySqlClient
Module Conexion
    Public Conex As MySqlConnection
    'Este método intenta conectar a la base de datos local
    Sub Conectar()
        'Dim es un tipo de variable genérica'
        Dim Conestr = "Server = localhost; Database = farmacia; Port = 3306; user id = root; password = ;"
        Try
            Conex = New MySqlConnection(Conestr)
            Conex.ConnectionString = Conestr
            Conex.Open()
            MsgBox("Conexion exitosa", MsgBoxStyle.Information, "BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
