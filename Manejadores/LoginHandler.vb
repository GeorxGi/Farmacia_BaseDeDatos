Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Bcpg

Public Class LoginHandler
    'Retorna verdadero o false dependiendo de su la cadena ingresada cuenta con caracteres especiales, numeros, minusculas y mayusculas
    Private Function ValidPassword(password As String)
        Return password.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1 And password.IndexOfAny("1234567890".ToCharArray) <> -1 And password.IndexOfAny("abcdefghijklmnñopqrstuvwxyz".ToCharArray) <> -1 And password.IndexOfAny("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray) <> -1
    End Function
    'Retorna true o false dependiendo de si el proceso de inicio de sesión fue hecho exitosamente
    Public Function Login(Username As String, Password As String)
        If (Username = "" Or Password = "") Then
            MsgBox("Por favor, ingrese un dato", MsgBoxStyle.Information, "Información")
            Return False
        Else
            Try
                Dim Comando = New MySqlCommand("SELECT * FROM usuarios WHERE username = '" + Username + "';", Conex)
                Dim Resultado = Comando.ExecuteReader
                Resultado.Read()
                If (Resultado.HasRows) Then
                    If (Resultado("password") = Password) Then
                        MsgBox("Bienvenid@ " + Resultado("fullname"), MsgBoxStyle.Information, "ACCESO")
                        Resultado.Close()
                        Return True
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
        Return False
    End Function
    'Retorna true o false dependiendo de si el proceso de registro fue hecho exitosamente
    Public Function Register(Username As String, Password As String, ConfirmPass As String, Fullname As String)
        If (Username = "" Or Password = "" Or Fullname = "") Then
            MsgBox("Por favor, ingrese un dato", MsgBoxStyle.Information, "Informacion")
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
                    If (Password = ConfirmPass) Then
                        If (ValidPassword(Password)) Then
                            Comando = New MySqlCommand("INSERT INTO usuarios (username,password,fullname) VALUES ('" + Username + "','" + Password + "','" + Fullname + "')", Conex)
                            Dim Busqueda = Comando.ExecuteNonQuery
                            MsgBox("Usuario registrado exitosamente", MsgBoxStyle.Information, "REGISTRADO")
                            Return True
                        Else
                            MsgBox("Contraseña no cumple los requisitos", MsgBoxStyle.Information, "ERROR")
                        End If
                    Else
                            MsgBox("Contraseñas no iguales", MsgBoxStyle.Information, "ERROR")
                    End If
                End If
                Resultado.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
        Return False
    End Function
End Class
