Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim miRectangulo As New Rectangulo()
        Dim areaCalculada As Double

        miRectangulo.Largo = txtLargo.Text
        miRectangulo.Ancho = txtAncho.Text

        areaCalculada = miRectangulo.CalcularArea()
        lblResultado.Text = "Resultado: " & areaCalculada

        miRectangulo.MostrarResultado()

    End Sub
End Class
