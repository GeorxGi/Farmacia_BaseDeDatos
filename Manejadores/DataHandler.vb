Imports System.Runtime.ConstrainedExecution
Imports Google.Protobuf.Reflection.SourceCodeInfo.Types
Imports MySql.Data.MySqlClient
Public Class DataHandler
#Region "Client Handler"
    Public Function ClientRegister(ByVal Name As String, ByVal Ced As String, ByVal Location As String, ByVal PhoneNumber As String) As Boolean
        If (Name = "" Or Name = "Nombre  " Or Ced.Length = 1 Or Location = "" Or Location = "Ubicación  " Or PhoneNumber = "" Or PhoneNumber = "Número de teléfono  ") Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Informacion")
            Return False
        Else
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim Comando = New MySqlCommand("SELECT * FROM clientes WHERE ced = '" + Ced + "';", Conex)
                Dim Resultado = Comando.ExecuteReader
                Resultado.Read()
                If (Resultado.HasRows) Then
                    MsgBox("Cliente ya registrado", MsgBoxStyle.Information, "Informacion")
                    Resultado.Close()
                Else
                    Resultado.Close()
                    Comando = New MySqlCommand("INSERT INTO clientes (name,ced,location,phone_number) VALUES ('" + Name + "','" + Ced + "','" + Location + "'," + PhoneNumber + ");", Conex)
                    Dim Registro = Comando.ExecuteNonQuery
                    MsgBox("Cliente registrado correctamente", MsgBoxStyle.Information, "Registrado")
                    Return True
                End If
                Resultado.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
        Cursor.Current = Cursors.Default
        Return False
    End Function

    ''' <summary>
    ''' Busca a un cliente en la base de datos, retorna "Nothing" si no se encuentra
    ''' Retorna al cliente si este existe
    ''' </summary>
    ''' <param name="Ced">Identificacion del cliente</param>
    ''' <returns></returns>
    Public Function SearchClient(ByVal Ced As String) As List(Of Object)
        'No saben cuanto tiempo me tomó crear esto
        If (Ced.Length = 1) Then
            Return Nothing
        Else
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim Comando = New MySqlCommand("SELECT * FROM clientes WHERE ced = '" + Ced + "';", Conex)
                Dim Resultado = Comando.ExecuteReader
                Resultado.Read()
                If (Resultado.HasRows) Then
                    Cursor.Current = Cursors.Default
                    Dim retorno As New List(Of Object)
                    retorno.AddRange({Resultado("client_id"), Resultado("name"), Resultado("ced"), Resultado("location"), Resultado("phone_number")})
                    Resultado.Close()
                    Return retorno
                End If
                Resultado.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
            Cursor.Current = Cursors.Default
            Return Nothing
        End If
    End Function
    Public Function EditClient(id As String, Name As String, Ced As String, Location As String, PhoneNumber As String) As Boolean
        If (Name = "" Or Ced = "" Or Location = "" Or PhoneNumber = "") Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Informacion")
            Return False
        Else
            Try
                Dim Comando = New MySqlCommand("UPDATE clientes SET name='" + Name + "', ced='" + Ced + "', location='" + Location + "', phone_number='" + PhoneNumber + "' WHERE client_id = " + id + ";", Conex)
                Dim ejecutor = Comando.ExecuteNonQuery()
                MsgBox("Modificación realizada correctamente", MsgBoxStyle.Information, "Información")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
        Return False
    End Function
#End Region
#Region "Lists"
    ''' <summary>
    ''' Recibe la identificación del cliente y realiza una búsqueda de todos los clientes
    ''' cuya identificación posea relación (autocompletado)
    ''' </summary>
    ''' <param name="Ced"></param>
    ''' <returns></returns>
    Public Function ListOfClients(ByVal Ced As String) As DataTable
        Try
            Dim Comando As String = "SELECT * FROM clientes WHERE ced REGEXP '^' '" + Ced + "';"
            Dim Adaptador As MySqlDataAdapter
            Dim tablaDatos As New DataTable
            Adaptador = New MySqlDataAdapter(Comando, Conex)
            Adaptador.Fill(tablaDatos)
            Return tablaDatos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Retorna una tabla de datos con todos los datos de los usuarios salvo la contraseña
    ''' </summary>
    ''' <returns></returns>
    Public Function ListOfUsers() As DataTable
        Try
            Dim Comando As String = "SELECT user_id,username,fullname FROM usuarios;"
            Dim Adaptador As MySqlDataAdapter
            Dim tablaDatos As New DataTable
            Adaptador = New MySqlDataAdapter(Comando, Conex)
            Adaptador.Fill(tablaDatos)
            Return tablaDatos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return Nothing
    End Function
    ''' <summary>
    ''' Recibe el nombre del producto y retorna una tabla de datos
    ''' </summary>
    ''' <param name="Name">Nombre del producto a buscar</param>
    ''' <returns></returns>
    Public Function ListOfProducts(ByVal Name As String) As DataTable
        Try
            Dim Comando As String = "SELECT * FROM productos WHERE name REGEXP '^' '" + Name + "';"
            Dim Adaptador As MySqlDataAdapter
            Dim tablaDatos As New DataTable
            Adaptador = New MySqlDataAdapter(Comando, Conex)
            Adaptador.Fill(tablaDatos)
            Return tablaDatos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return Nothing
    End Function
#End Region

    ''' <summary>
    ''' Registra los datos ingresados del producto en la base de datos, si el producto ya existe
    ''' Solicita permisos para incrementar la cantidad y modificar el precio
    ''' </summary>
    ''' <param name="name">Nombre del producto</param>
    ''' <param name="lab">Laboratorio del producto</param>
    ''' <param name="presentation">Presentación del producto</param>
    ''' <param name="amount">Cantidad en inventario</param>
    ''' <param name="price">Precio</param>
    ''' <returns></returns>
    Public Function RegisterProduct(ByVal name As String, ByVal lab As String, ByVal presentation As String, ByVal amount As String, ByVal price As String) As Boolean
        If (name = "" Or name = "Nombre  " Or lab = "" Or lab = "Laboratorio  " Or presentation = "" Or amount = 0 Or price = 0) Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Informacion")
            Return False
        Else
            Try
                Dim Comando = New MySqlCommand("SELECT * FROM productos WHERE (name = '" + name + "') AND (lab='" + lab + "') AND (presentation='" + presentation + "');", Conex)
                Dim busqueda = Comando.ExecuteReader
                busqueda.Read()
                If (busqueda.HasRows) Then
                    Dim newAmount As Integer = busqueda("amount") + Convert.ToInt32(amount)
                    Dim id As String = busqueda("prod_id")
                    busqueda.Close()
                    If (MsgBox("Producto ya registrado. ¿Desea registrar nuevo lote y precio?", MsgBoxStyle.YesNo, "Información") = vbYes) Then
                        Comando = New MySqlCommand("UPDATE productos SET amount='" + Convert.ToString(newAmount) + "', price='" + price + "' WHERE prod_id = " + id + ";", Conex)
                        Dim ejecutor = Comando.ExecuteNonQuery()
                        MsgBox("Actualizado correctamente", MsgBoxStyle.Information, "Informacion")
                        Return True
                    End If

                    Return False
                Else
                    busqueda.Close()
                    Comando = New MySqlCommand("INSERT INTO productos (name,lab,presentation,amount,price) VALUES ('" + name + "','" + lab + "','" + presentation + "','" + amount + "','" + price + "');", Conex)
                    Dim Registro = Comando.ExecuteNonQuery
                    MsgBox("Producto registrado correctamente", MsgBoxStyle.Information, "Informacion")
                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            Return False
        End If
    End Function

    ''' <summary>
    ''' Modifica el producto indicado
    ''' </summary>
    ''' <param name="id">ID del producto en la base de datos</param>
    ''' <param name="name">Nombre del producto</param>
    ''' <param name="lab">Laboratorio del producto</param>
    ''' <param name="present">Presentación del producto</param>
    ''' <returns></returns>
    Public Function EditProduct(ByVal id As String, ByVal name As String, ByVal lab As String, ByVal present As String) As Boolean
        If (name = "" Or lab = "" Or present = "") Then
            MsgBox("Por favor, rellene los datos", MsgBoxStyle.Information, "Informacion")
            Return False
        Else
            Try
                Dim Comando = New MySqlCommand("UPDATE productos SET name='" + name + "', lab='" + lab + "', presentation='" + present + "' WHERE prod_id = " + id + ";", Conex)
                Dim ejecutor = Comando.ExecuteNonQuery()
                MsgBox("Modificación realizada correctamente", MsgBoxStyle.Information, "Informacion")
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
        Return False
    End Function

End Class
