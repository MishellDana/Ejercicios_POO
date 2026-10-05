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
        Me.lblLargo = New System.Windows.Forms.Label()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.txtLargo = New System.Windows.Forms.TextBox()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLargo
        '
        Me.lblLargo.AutoSize = True
        Me.lblLargo.Location = New System.Drawing.Point(44, 49)
        Me.lblLargo.Name = "lblLargo"
        Me.lblLargo.Size = New System.Drawing.Size(37, 13)
        Me.lblLargo.TabIndex = 0
        Me.lblLargo.Text = "Largo:"
        '
        'lblAncho
        '
        Me.lblAncho.AutoSize = True
        Me.lblAncho.Location = New System.Drawing.Point(44, 99)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(41, 13)
        Me.lblAncho.TabIndex = 1
        Me.lblAncho.Text = "Ancho:"
        '
        'txtLargo
        '
        Me.txtLargo.Location = New System.Drawing.Point(111, 49)
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.Size = New System.Drawing.Size(233, 20)
        Me.txtLargo.TabIndex = 2
        Me.txtLargo.Text = "Ingresar Largo"
        Me.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAncho
        '
        Me.txtAncho.Location = New System.Drawing.Point(111, 96)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(233, 20)
        Me.txtAncho.TabIndex = 3
        Me.txtAncho.Text = "Ingresar Ancho"
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalcular.Location = New System.Drawing.Point(101, 177)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(227, 58)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "CALCULAR ÁREA"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResultado.Location = New System.Drawing.Point(139, 294)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(163, 31)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "Resultado: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 414)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtAncho)
        Me.Controls.Add(Me.txtLargo)
        Me.Controls.Add(Me.lblAncho)
        Me.Controls.Add(Me.lblLargo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLargo As Label
    Friend WithEvents lblAncho As Label
    Friend WithEvents txtLargo As TextBox
    Friend WithEvents txtAncho As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblResultado As Label
End Class
