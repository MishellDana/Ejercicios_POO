<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitular = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitular
        '
        Me.lblTitular.AutoSize = True
        Me.lblTitular.Location = New System.Drawing.Point(36, 50)
        Me.lblTitular.Name = "lblTitular"
        Me.lblTitular.Size = New System.Drawing.Size(42, 13)
        Me.lblTitular.TabIndex = 0
        Me.lblTitular.Text = "Titular: "
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(36, 92)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(67, 13)
        Me.lblSaldo.TabIndex = 1
        Me.lblSaldo.Text = "Saldo Inicial:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(36, 140)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(98, 13)
        Me.lblDeposito.TabIndex = 2
        Me.lblDeposito.Text = "Monto a depositar: "
        '
        'txtTitular
        '
        Me.txtTitular.Location = New System.Drawing.Point(135, 50)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(170, 20)
        Me.txtTitular.TabIndex = 3
        Me.txtTitular.Text = "Ingresar Nombre"
        Me.txtTitular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(135, 85)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(170, 20)
        Me.txtSaldo.TabIndex = 4
        Me.txtSaldo.Text = "Ingresar Saldo"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDeposito
        '
        Me.txtDeposito.Location = New System.Drawing.Point(135, 137)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(170, 20)
        Me.txtDeposito.TabIndex = 5
        Me.txtDeposito.Text = "Ingresar Depósito"
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(73, 213)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(297, 57)
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(205, 323)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(58, 13)
        Me.lblResultado.TabIndex = 7
        Me.lblResultado.Text = "Resultado:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 426)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.lblDeposito)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblTitular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitular As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblDeposito As Label
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents lblResultado As Label
End Class
