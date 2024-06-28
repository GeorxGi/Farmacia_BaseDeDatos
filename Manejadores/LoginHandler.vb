Imports MySql.Data.MySqlClient

Public Class LoginHandler
    Private Encrypter As New Encrypter()
#Region "Validadores de contraseña"
    ''' <summary>
    ''' Recibe una cadena y valida que esta cuente con las condiciones aplicadas
    ''' (Minúsculas, mayúsculas, números y caracteres especiales)
    ''' </summary>
    ''' <param name="password"></param>
    ''' <returns></returns>
    Private Function ValidPassword(ByVal password As String) As Boolean
        Return HasNumber(password) And HasSpecialChar(password) And HasMayus(password) And HasMinus(password)
    End Function
    Public Function HasNumber(ByVal password As String) As Boolean
        Return password.IndexOfAny("1234567890".ToCharArray) <> -1
    End Function
    Public Function HasSpecialChar(ByVal password As String) As Boolean
        Return password.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function
    Public Function HasMayus(ByVal password As String) As Boolean
        Return password.IndexOfAny("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function
    Public Function HasMinus(ByVal password As String) As Boolean
        Return password.IndexOfAny("abcdefghijklmnñopqrstuvwxyz".ToCharArray) <> -1
    End Function
#End Region
#Region "Manejadores de usuarios"
    ''' <summary>
    ''' Retorna el fullname del usuario en caso de que el inicio de sesión fuera exitoso, de lo contrario
    ''' retorna un string vacio
    ''' </summary>
    ''' <param name="Username"> Nombre de usuario</param>
    ''' <param name="Password"> Contraseña no encriptada</param>
    ''' <returns></returns>
    Public Function Login(ByVal Username As String, ByVal Password As String) As String
        Cursor.Current = Cursors.WaitCursor
        If (Username = "" Or Username = "Usuario  " Or Password = "" Or Password = "Contraseña  ") Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Información")

            Return ""
        Else
            Try
                Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + Username + "';", Conex)
                Dim Resultado = Comando.ExecuteReader
                Resultado.Read()
                If (Resultado.HasRows) Then
                    If (Resultado("password") = Encrypter.Encriptar_AES(Password)) Then
                        MsgBox("Bienvenid@ " + Resultado("fullname"), MsgBoxStyle.Information, "ACCESO")
                        Dim User As String = Resultado("fullname")
                        Resultado.Close()
                        Return User
                    Else
                        MsgBox("Contraseña incorrecta", MsgBoxStyle.Information, "ERROR")
                    End If
                Else
                    MsgBox("Usuario no encontrado", MsgBoxStyle.Exclamation, "ERROR")
                End If
                Resultado.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
        Cursor.Current = Cursors.Default
        Return ""
    End Function
    ''' <summary>
    ''' Registra los datos del usuario en la base de datos conectada, retorna un booleano de acuerdo a si la operacion
    ''' fue realizada correctamente o no
    ''' </summary>
    ''' <param name="Username"> Nombre de usuario</param>
    ''' <param name="Password"> Contraseña no encriptada</param>
    ''' <param name="ConfirmPass"> Confirmar contraseña</param>
    ''' <param name="Fullname"> Nombre completo del usuario</param>
    ''' <returns></returns>
    Public Function Register(ByVal Username As String, ByVal Password As String, ByVal ConfirmPass As String, ByVal Fullname As String) As Boolean
        Cursor.Current = Cursors.WaitCursor
        If (Username = "" Or Username = "Usuario  " Or Password = "" Or Password = "Contraseña  " Or Fullname = "" Or Fullname = "Nombre completo  ") Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Informacion")
        Else
            If (Not Password = ConfirmPass) Then
                MsgBox("Contraseñas no iguales", MsgBoxStyle.Information, "ERROR")
            Else
                If (Not ValidPassword(Password)) Then
                    MsgBox("Contraseña no cumple los requisitos", MsgBoxStyle.Information, "ERROR")
                Else
                    Try
                        Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + Username + "';", Conex)
                        Dim Resultado = Comando.ExecuteReader
                        Resultado.Read()
                        If (Resultado.HasRows) Then
                            MsgBox("Usuario ya registrado", MsgBoxStyle.Exclamation, "ERROR")
                            Resultado.Close()
                        Else
                            Resultado.Close()
                            Comando = New MySqlCommand("INSERT INTO usuarios (username,password,fullname) VALUES ('" + Username + "','" + Encrypter.Encriptar_AES(Password) + "','" + Fullname + "')", Conex)
                            Dim Busqueda = Comando.ExecuteNonQuery
                            MsgBox("Usuario registrado exitosamente", MsgBoxStyle.Information, "REGISTRADO")
                            Return True
                        End If
                        Resultado.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                    End Try
                End If
            End If
        End If
        Cursor.Current = Cursors.Default
        Return False
    End Function
#End Region
End Class
