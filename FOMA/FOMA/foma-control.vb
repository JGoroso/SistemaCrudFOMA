Imports System.Data.OleDb
Public Class Form1


    Private Sub btnDescargarNomina_Click(sender As Object, e As EventArgs) Handles btnDescargarNomina.Click
        Try


            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()


            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Clientes"

            DR = Comando.ExecuteReader

            If DR.HasRows Then

                FileOpen(1, "NominaClientesFOMA.txt", OpenMode.Output)

                Write(1, "Se han descargado los siguientes datos")
                WriteLine(1)
                WriteLine(1)


                Do While DR.Read

                    Write(1, DR("Id"))
                    Write(1, DR("Nombre"))
                    Write(1, DR("Domicilio"))
                    WriteLine(1, DR("Teléfono"))

                Loop

            End If




            MessageBox.Show("Descarga completa, revise la carpeta /debug")

        Catch
            MessageBox.Show(ErrorToString)
        End Try

        FileClose(1)
        Conexion.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmagregarCliente.Show()
    End Sub

    Private Sub btnCargarVenta_Click(sender As Object, e As EventArgs) Handles btnCargarVenta.Click
        frmCargarVentas.Show()
    End Sub

    Private Sub btnConsultarVenta_Click(sender As Object, e As EventArgs) Handles btnConsultarVenta.Click
        frmConsultarVentas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
