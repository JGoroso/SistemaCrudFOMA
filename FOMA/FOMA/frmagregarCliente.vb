Imports System.Data.OleDb
Public Class frmagregarCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try


            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()


            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Clientes"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = tabla.NewRow()

            If txtNombre.Text.Equals("") = False And txtDomicilio.Text.Equals("") = False And txtTelefono.Text.Equals("") = False Then

                Fila("Nombre") = txtNombre.Text
                    Fila("Domicilio") = txtDomicilio.Text


                Fila("Teléfono") = Convert.ToInt32(txtTelefono.Text)

                tabla.Rows.Add(Fila)


                Dim CommandBuilder As New OleDbCommandBuilder(Adaptador)
                    Adaptador.Update(DS)

                    MessageBox.Show("Cliente guardado con exito.")


                    txtNombre.Text = ""
                    txtDomicilio.Text = ""
                    txtTelefono.Text = ""

                Else
                    MessageBox.Show("Existen datos vacios.")
            End If


        Catch
            MessageBox.Show(ErrorToString)
        End Try


        Conexion.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo numeros")
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo numeros")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo letras")
        End If
    End Sub

End Class