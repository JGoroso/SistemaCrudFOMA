Imports System.Data.OleDb
Imports System.IO
Public Class frmConsultarVentas
    Private Sub frmConsultarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnVenta_Click_1(sender As Object, e As EventArgs) Handles btnVenta.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Ventas"

            DR = Comando.ExecuteReader

            dgvVentas.Rows.Clear()
            Dim NombreProducto As String = ""
            Dim NombreCliente As String = ""
            Dim fechaConsulta = FormatDateTime(dtpFecha.Value, DateFormat.ShortDate)

            If DR.HasRows Then

                Do While DR.Read


                    If DR("IdEmpleados") = cmbEmpleados.SelectedValue And DR("FechaVenta") = fechaConsulta Then

                        NombreProducto = BuscarProducto(DR("IdProducto"))
                        NombreCliente = BuscarCliente(DR("IdCliente"))

                        dgvVentas.Rows.Add(DR("IdVenta"), NombreProducto, NombreCliente)

                    End If

                Loop



            End If


        Catch
            MessageBox.Show(ErrorToString)
        End Try

        Conexion.Close()
    End Sub
End Class