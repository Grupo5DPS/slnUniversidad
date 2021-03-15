Public Class Form1

    Dim Servicio As New ServiceReference1.WebService1SoapClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Servicio.Listar().Tables(0)
    End Sub

    Private Sub Listaar()
        DataGridView1.DataSource = Servicio.Listar().Tables(0)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim aea() As String
        aea = Servicio.Agregar(txt1.Text, txt2.Text)
        lbl2.Text = aea(0).ToString()
        lbl3.Text = aea(1).ToString()
        Listaar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aea() As String
        aea = Servicio.Actualizar(txt1.Text, txt2.Text)
        lbl2.Text = aea(0).ToString()
        lbl3.Text = aea(1).ToString()
        Listaar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aea() As String
        aea = Servicio.Eliminar(txt1.Text)
        lbl2.Text = aea(0).ToString()
        lbl3.Text = aea(1).ToString()
        Listaar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DataGridView1.DataSource = Servicio.Buscar(txt1.Text, txt2.Text).Tables(0)

        Catch ex As Exception
            MessageBox.Show("No se encontraron resultados")
        End Try
    End Sub


End Class