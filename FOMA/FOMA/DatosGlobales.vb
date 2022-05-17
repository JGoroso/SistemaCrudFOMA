Imports System.Data.OleDb

Module DatosGlobales

    Public Conexion As New OleDbConnection
    Public Comando As New OleDb.OleDbCommand
    Public Adaptador As New OleDb.OleDbDataAdapter

    Public DR As OleDbDataReader
    Public DS As DataSet

    Public CadenaDeConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dbfoma.mdb;Persist Security Info=False;"


    Public Function BuscarProducto(id As Integer) As String
        Dim producto As String = ""
        Dim ConexionProducto As New OleDbConnection
        Dim ComandoProducto As New OleDbCommand
        Dim DRProducto As OleDbDataReader

        ConexionProducto.ConnectionString = CadenaDeConexion
        ConexionProducto.Open()

        ComandoProducto.Connection = ConexionProducto
        ComandoProducto.CommandType = CommandType.TableDirect
        ComandoProducto.CommandText = "Productos"

        DRProducto = ComandoProducto.ExecuteReader

        If DRProducto.HasRows Then
            While DRProducto.Read
                If DRProducto("IdProducto") = id Then
                    producto = DRProducto("NombreProducto")
                    Exit While
                End If
            End While
        End If
        ConexionProducto.Close()
        Return producto
    End Function


    Public Function BuscarCliente(id As Integer) As String
        Dim nombre As String = ""
        Dim ConexionCliente As New OleDbConnection
        Dim ComandoCliente As New OleDbCommand
        Dim DRCliente As OleDbDataReader

        ConexionCliente.ConnectionString = CadenaDeConexion
        ConexionCliente.Open()

        ComandoCliente.Connection = ConexionCliente
        ComandoCliente.CommandType = CommandType.TableDirect
        ComandoCliente.CommandText = "Clientes"

        DRCliente = ComandoCliente.ExecuteReader

        If DRCliente.HasRows Then
            While DRCliente.Read
                If DRCliente("Id") = id Then
                    nombre = DRCliente("Nombre")
                    Exit While
                End If
            End While
        End If

        ConexionCliente.Close()
        Return nombre
    End Function

End Module
