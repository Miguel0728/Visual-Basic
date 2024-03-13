Public Class Form1
    'Miguel A. Melendez Hernandez
    'Y00598196

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' VARIABLES

        Dim nota1, nota2, nota3, nota4, promedio As Double
        Dim NotaFinal As Double
        Dim Mensaje As String
        Dim Nota As String

        ' VALIDACION DE DATOS
        Try
            nota1 = txtNota1.Text
            nota2 = txtNota2.Text
            nota3 = txtNota3.Text
            nota4 = txtNota4.Text

        Catch ex As Exception

            MessageBox.Show("Please enter a number")


        End Try
        promedio = (nota1 + nota2 + nota3 + nota4) / 100
        NotaFinal = (nota1 + nota2 + nota3 + nota4) / 4

        ' CASE DE NOTA FINAL

        Select Case NotaFinal

            Case 95 To 100
                Nota = "A"
                Mensaje = "APROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota

            Case 90 To 94
                Nota = "A"
                Mensaje = "DESAPROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota

            Case 80 To 89
                Nota = "B"
                Mensaje = "DESAPROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota
            Case 70 To 79
                Nota = "C"
                Mensaje = "DESAPROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota
            Case 60 To 69
                Nota = "D"
                Mensaje = "DESAPROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota
            Case 0 To 59
                Nota = "F"
                Mensaje = "DESAPROBADO!"
                lblPromedio.Text = promedio
                lblMensaje.Text = Mensaje
                lblNotaFinal.Text = NotaFinal
                lblnota.Text = Nota
            Case Else
                MessageBox.Show("Invalid Score")
        End Select


    End Sub

    'BOTON DE CLEAR
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNota1.Clear()
        txtNota2.Clear()
        txtNota3.Clear()
        txtNota4.Clear()
        txtName.Clear()
        txtApellido.Clear()
        txtNumEstudiante.Clear()
        lblMensaje.Text = ""
        lblNotaFinal.Text = ""
        lblPromedio.Text = ""
        lblnota.Text = ""
    End Sub

    'BOTON SALIR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class
