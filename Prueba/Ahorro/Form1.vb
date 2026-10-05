Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim miCuentaAhorro As New Rectangulo()
        Dim NuevoSaldo As Double

        miCuentaAhorro.Titular = txtTitular.Text
        miCuentaAhorro.Saldo = txtSaldo.Text
        miCuentaAhorro.Deposito = txtDeposito.Text

        NuevoSaldo = miCuentaAhorro.CalcularNuevoSaldo()
        lblResultado.Text = "Resultado: " & NuevoSaldo

        If NuevoSaldo >= 500 Then
            miCuentaAhorro.MostrarEstado()
            lblResultado.Text = "SALDO SUFICIENTE"
        Else
            lblResultado.Text = "SALDO INSUFICIENTE"

        End If
        miCuentaAhorro.MostrarEstado()

    End Sub
End Class