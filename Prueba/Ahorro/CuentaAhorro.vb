Public Class Rectangulo
    Public Titular As String
    Public Saldo As Double
    Public Deposito As Double

    Public Function CalcularNuevoSaldo() As Double
        Return Deposito + Saldo
    End Function
    Public Sub MostrarEstado()
        Dim nuevosaldo As Double = CalcularNuevoSaldo()
        MessageBox.Show("El nuevo saldo es: " & nuevosaldo, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class