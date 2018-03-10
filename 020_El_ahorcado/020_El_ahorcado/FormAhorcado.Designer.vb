<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAho
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
        Me.btnNuevoJuego = New System.Windows.Forms.Button()
        Me.picBoxHang = New System.Windows.Forms.PictureBox()
        Me.btnPrueba = New System.Windows.Forms.Button()
        Me.lblFondo = New System.Windows.Forms.Label()
        Me.btnRes = New System.Windows.Forms.Button()
        Me.lblPrueba = New System.Windows.Forms.Label()
        Me.lblTit = New System.Windows.Forms.Label()
        CType(Me.picBoxHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevoJuego
        '
        Me.btnNuevoJuego.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevoJuego.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevoJuego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnNuevoJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnNuevoJuego.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoJuego.Location = New System.Drawing.Point(49, 759)
        Me.btnNuevoJuego.Name = "btnNuevoJuego"
        Me.btnNuevoJuego.Size = New System.Drawing.Size(300, 83)
        Me.btnNuevoJuego.TabIndex = 2
        Me.btnNuevoJuego.Text = "Nuevo Juego"
        Me.btnNuevoJuego.UseVisualStyleBackColor = False
        '
        'picBoxHang
        '
        Me.picBoxHang.BackColor = System.Drawing.Color.Transparent
        Me.picBoxHang.BackgroundImage = Global._020_El_ahorcado.My.Resources.Resources.background
        Me.picBoxHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBoxHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBoxHang.Image = Global._020_El_ahorcado.My.Resources.Resources._6
        Me.picBoxHang.Location = New System.Drawing.Point(743, 70)
        Me.picBoxHang.Name = "picBoxHang"
        Me.picBoxHang.Size = New System.Drawing.Size(339, 505)
        Me.picBoxHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxHang.TabIndex = 1
        Me.picBoxHang.TabStop = False
        '
        'btnPrueba
        '
        Me.btnPrueba.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrueba.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrueba.Location = New System.Drawing.Point(926, 759)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.Size = New System.Drawing.Size(166, 83)
        Me.btnPrueba.TabIndex = 3
        Me.btnPrueba.Text = "Prueba"
        Me.btnPrueba.UseVisualStyleBackColor = False
        '
        'lblFondo
        '
        Me.lblFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFondo.Location = New System.Drawing.Point(731, 60)
        Me.lblFondo.Name = "lblFondo"
        Me.lblFondo.Size = New System.Drawing.Size(361, 532)
        Me.lblFondo.TabIndex = 4
        '
        'btnRes
        '
        Me.btnRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRes.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRes.Location = New System.Drawing.Point(376, 759)
        Me.btnRes.Name = "btnRes"
        Me.btnRes.Size = New System.Drawing.Size(300, 83)
        Me.btnRes.TabIndex = 6
        Me.btnRes.Text = "Resultado"
        Me.btnRes.UseVisualStyleBackColor = False
        '
        'lblPrueba
        '
        Me.lblPrueba.BackColor = System.Drawing.Color.White
        Me.lblPrueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrueba.Location = New System.Drawing.Point(822, 9)
        Me.lblPrueba.Name = "lblPrueba"
        Me.lblPrueba.Size = New System.Drawing.Size(218, 32)
        Me.lblPrueba.TabIndex = 7
        Me.lblPrueba.Text = "Prueba"
        Me.lblPrueba.Visible = False
        '
        'lblTit
        '
        Me.lblTit.Font = New System.Drawing.Font("Arial Black", 33.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTit.Location = New System.Drawing.Point(67, 60)
        Me.lblTit.Name = "lblTit"
        Me.lblTit.Size = New System.Drawing.Size(595, 163)
        Me.lblTit.TabIndex = 8
        Me.lblTit.Text = "EL AHORCADO"
        '
        'frmAho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 893)
        Me.Controls.Add(Me.lblTit)
        Me.Controls.Add(Me.lblPrueba)
        Me.Controls.Add(Me.btnRes)
        Me.Controls.Add(Me.btnPrueba)
        Me.Controls.Add(Me.btnNuevoJuego)
        Me.Controls.Add(Me.picBoxHang)
        Me.Controls.Add(Me.lblFondo)
        Me.Name = "frmAho"
        Me.Text = "El Ahorcado"
        CType(Me.picBoxHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBoxHang As System.Windows.Forms.PictureBox
    Friend WithEvents btnNuevoJuego As System.Windows.Forms.Button
    Friend WithEvents btnPrueba As System.Windows.Forms.Button
    Friend WithEvents lblFondo As System.Windows.Forms.Label
    Friend WithEvents btnRes As System.Windows.Forms.Button
    Friend WithEvents lblPrueba As System.Windows.Forms.Label
    Friend WithEvents lblTit As System.Windows.Forms.Label

End Class
