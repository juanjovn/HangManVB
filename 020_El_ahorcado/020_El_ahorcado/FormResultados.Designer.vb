<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblGanadas = New System.Windows.Forms.Label()
        Me.lblValorGanadas = New System.Windows.Forms.Label()
        Me.lblPerdidas = New System.Windows.Forms.Label()
        Me.lblTotales = New System.Windows.Forms.Label()
        Me.lblValorPerdidas = New System.Windows.Forms.Label()
        Me.lblValorTotales = New System.Windows.Forms.Label()
        Me.lblPorcent = New System.Windows.Forms.Label()
        Me.lblValPorcentaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRes
        '
        Me.lblRes.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.lblRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes.Location = New System.Drawing.Point(134, 39)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(404, 107)
        Me.lblRes.TabIndex = 0
        Me.lblRes.Text = "Resultados"
        '
        'lblGanadas
        '
        Me.lblGanadas.Location = New System.Drawing.Point(69, 170)
        Me.lblGanadas.Name = "lblGanadas"
        Me.lblGanadas.Size = New System.Drawing.Size(196, 76)
        Me.lblGanadas.TabIndex = 1
        Me.lblGanadas.Text = "GANADAS:"
        '
        'lblValorGanadas
        '
        Me.lblValorGanadas.Location = New System.Drawing.Point(195, 170)
        Me.lblValorGanadas.Name = "lblValorGanadas"
        Me.lblValorGanadas.Size = New System.Drawing.Size(137, 80)
        Me.lblValorGanadas.TabIndex = 2
        Me.lblValorGanadas.Text = "0"
        '
        'lblPerdidas
        '
        Me.lblPerdidas.Location = New System.Drawing.Point(69, 270)
        Me.lblPerdidas.Name = "lblPerdidas"
        Me.lblPerdidas.Size = New System.Drawing.Size(263, 76)
        Me.lblPerdidas.TabIndex = 3
        Me.lblPerdidas.Text = "PERDIDAS"
        '
        'lblTotales
        '
        Me.lblTotales.Location = New System.Drawing.Point(69, 368)
        Me.lblTotales.Name = "lblTotales"
        Me.lblTotales.Size = New System.Drawing.Size(263, 76)
        Me.lblTotales.TabIndex = 4
        Me.lblTotales.Text = "Totales"
        '
        'lblValorPerdidas
        '
        Me.lblValorPerdidas.Location = New System.Drawing.Point(195, 270)
        Me.lblValorPerdidas.Name = "lblValorPerdidas"
        Me.lblValorPerdidas.Size = New System.Drawing.Size(137, 80)
        Me.lblValorPerdidas.TabIndex = 5
        Me.lblValorPerdidas.Text = "0"
        '
        'lblValorTotales
        '
        Me.lblValorTotales.Location = New System.Drawing.Point(195, 368)
        Me.lblValorTotales.Name = "lblValorTotales"
        Me.lblValorTotales.Size = New System.Drawing.Size(137, 80)
        Me.lblValorTotales.TabIndex = 6
        Me.lblValorTotales.Text = "0"
        '
        'lblPorcent
        '
        Me.lblPorcent.AutoSize = True
        Me.lblPorcent.Location = New System.Drawing.Point(69, 461)
        Me.lblPorcent.Name = "lblPorcent"
        Me.lblPorcent.Size = New System.Drawing.Size(149, 20)
        Me.lblPorcent.TabIndex = 7
        Me.lblPorcent.Text = "Porcentaje aciertos:"
        '
        'lblValPorcentaje
        '
        Me.lblValPorcentaje.AutoSize = True
        Me.lblValPorcentaje.Location = New System.Drawing.Point(265, 461)
        Me.lblValPorcentaje.Name = "lblValPorcentaje"
        Me.lblValPorcentaje.Size = New System.Drawing.Size(0, 20)
        Me.lblValPorcentaje.TabIndex = 8
        '
        'frmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 721)
        Me.Controls.Add(Me.lblValPorcentaje)
        Me.Controls.Add(Me.lblPorcent)
        Me.Controls.Add(Me.lblValorTotales)
        Me.Controls.Add(Me.lblValorPerdidas)
        Me.Controls.Add(Me.lblTotales)
        Me.Controls.Add(Me.lblPerdidas)
        Me.Controls.Add(Me.lblValorGanadas)
        Me.Controls.Add(Me.lblGanadas)
        Me.Controls.Add(Me.lblRes)
        Me.Name = "frmResultados"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRes As System.Windows.Forms.Label
    Friend WithEvents lblGanadas As System.Windows.Forms.Label
    Friend WithEvents lblValorGanadas As System.Windows.Forms.Label
    Friend WithEvents lblPerdidas As System.Windows.Forms.Label
    Friend WithEvents lblTotales As System.Windows.Forms.Label
    Friend WithEvents lblValorPerdidas As System.Windows.Forms.Label
    Friend WithEvents lblValorTotales As System.Windows.Forms.Label
    Friend WithEvents lblPorcent As System.Windows.Forms.Label
    Friend WithEvents lblValPorcentaje As System.Windows.Forms.Label
End Class
