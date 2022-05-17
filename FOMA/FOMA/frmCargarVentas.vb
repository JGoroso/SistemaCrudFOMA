Imports System.Data.OleDb
Public Class frmCargarVentas
    Private Sub frmCargarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Clientes"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            cmbClientes.DataSource = DS.Tables(0)
            cmbClientes.ValueMember = "Id"
            cmbClientes.DisplayMember = "Nombre"
        Catch
            MessageBox.Show(ErrorToString)
        End Try



        Conexion.Close() 'Carga de Clientes'

        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Empleados"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            cmbEmpleados.DataSource = DS.Tables(0)
            cmbEmpleados.ValueMember = "Id"
            cmbEmpleados.DisplayMember = "Nombre"
        Catch
            MessageBox.Show(ErrorToString)
        End Try

        Conexion.Close() 'Carga de empleados'

        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Productos"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            cmbProducto.DataSource = DS.Tables(0)
            cmbProducto.ValueMember = "IdProducto"
            cmbProducto.DisplayMember = "NombreProducto"
        Catch
            MessageBox.Show(ErrorToString)
        End Try

        Conexion.Close() 'Carga de Productos'

    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs)
        Try

            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()


            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Ventas"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = tabla.NewRow()



            If cmbClientes.Text.Equals("") = False And cmbEmpleados.Text.Equals("") = False And cmbProducto.Text.Equals("") = False Then

                Fila("IdProducto") = cmbProducto.SelectedValue
                Fila("IdCliente") = cmbClientes.SelectedValue
                Fila("IdEmpleados") = cmbEmpleados.SelectedValue
                Fila("FechaVenta") = FormatDateTime(dtpFecha.Value, DateFormat.ShortDate)

                tabla.Rows.Add(Fila)

                Dim CommandBuilder As New OleDbCommandBuilder(Adaptador)

                Adaptador.Update(DS)

                MessageBox.Show("Venta guardada con exito.")

            End If
        Catch
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
End Class