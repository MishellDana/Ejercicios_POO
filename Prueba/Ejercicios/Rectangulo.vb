Public Class Rectangulo
    Public Largo As Double
    Public Ancho As Double

    Public Function CalcularArea() As Double
        Return Largo * Ancho
    End Function
    Public Sub MostrarResultado()
        Dim area As Double = CalcularArea()
        MessageBox.Show("El área del rectángulo es: " & area, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class