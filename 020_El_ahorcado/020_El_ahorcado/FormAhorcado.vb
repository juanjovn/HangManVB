Public Class frmAho
    Dim letras(32) As Button 'Array para gardar os botons de letras
    Dim contadorMuerte As Integer = 0
    Dim contadorWin As Integer = 0
    Dim contAcierto As Integer = 0 'Para a porcentaxe
    Dim contClicks As Integer = 0 'Para a porcentaxe, tendo o total de clicks
    Dim derrotas As Integer = 0
    Dim victorias As Integer = 0
    Dim gameOver As Boolean = False
    Dim img(7) As Image
    Dim paLabels() As Label
    Dim valorSeleccionado As String = ""
    Dim palabras() As String = {"CARIÑO", "ORDENADOR", "MANZANA", "AMANECER", "PUERTA", "XILÓFONO", "RATÓN", "COGER", "HABITACIÓN", "MÓVIL", "ATAÚD", "ESQUELETO", "SUSPENSO", "GALAXIA", "ESTRELLA", "ECLIPSE", "PIZARRA", "BORRADOR", "TEJADO", "CHORIZO", "PULPO", "PATATAS", "ALFOMBRA", "VASIJA", "CEREBELO", "CABELLO", "OÍDO", "PRÍNCIPE", "COJÍN", "PORTÁTIL", "MESA", "RATÓN", "ENCHUFE", "CARGADOR", "TECLADO", "PANTALLA", "CONEXIÓN", "PULSACIÓN", "ADAPTADOR", "PROYECTOR", "COCHE", "TELÉFONO", "MAÑANA", "COMPAÑÍA", "PARAGÜERO", "MALETÍN", "RUEDA", "LÁMPARA", "MÚSICA", "CARAMELO", "IMPOSICIÓN", "VENTANA", "GAVIOTA", "EXPOSICIÓN", "PANTALÓN", "PESADILLA", "DESAYUNO", "FOLLETÍN", "TORTILLA", "CAFÉ", "TELEVISIÓN", "DINAMITA", "SÚBITA", "ÉXITO", "ÉXTASIS", "MÓVIL", "ÍNDICE", "NABOS", "RAMONA", "SANTIAGO", "FUNDACIÓN", "CAMIÓN", "TRACTOR", "GIMNASIO", "ROMPEDORA", "BENZEMALO", "ZAMPABOLLOS", "BOLITA", "PINGÜINO", "BAÚL", "APROBADO", "REDUNDANTE", "AGUA", "PÉRDIDA", "RULETA", "ÁRABE", "CONSOLA", "BANANA", "PELOTA", "CORDA", "NEUMÁTICO", "INSIGNIA", "CARNICERÍA", "RELOJ", "COJÍN", "LUNES", "NOVIEMBRE", "CONEXIÓN", "MECÁNICO", "MALETÍN"}

    Private Sub frmAho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarLetras()
        cargarImagenes()

    End Sub

    Private Sub cargarLetras()
        Dim fila As Integer = 1
        For i As Integer = 0 To letras.Length - 1
            Dim b As Button = New Button 'boton actual
            Dim bA As Button = New Button 'boton anterior

            letras(i) = b
            b.Enabled = False
            b.Width = 45
            b.Height = 45
            b.FlatStyle = FlatStyle.Flat
            b.Font = New Font("Arial", 12.0F, FontStyle.Bold)
            b.BackColor = ColorTranslator.FromHtml("#E1E5C0")

            If i < 14 Then 'Antes do Ñ
                b.Text = Chr(65 + i)
            ElseIf i = 14 Then 'Engadimos o Ñ manualmente
                b.Text = "Ñ"
            ElseIf i < 27 Then
                b.Text = Chr(65 + i - 1) 'Sumamos un por mor de haber engadido o Ñ
            End If

            If i = 0 Then ' O primeiro boton
                b.Left = 20
                b.Top = 150
            ElseIf i Mod 9 <> 0 Then
                bA = letras(i - 1) 'boton anterior
                b.Top = bA.Top
                b.Left = bA.Left + bA.Width + 5
            Else 'Cambiamos de fila no elemento 9 para representar tres lineas de botons xa que son 27
                fila += 1
                bA = letras(i - 1)
                If fila = 4 Then
                    b.Left = 20 + bA.Width * (3 / 2) + 10
                Else
                    b.Left = 20
                End If
                b.Top = bA.Location.Y + bA.Height + 10 'cambio de fila, establecemos de padding superior a medida da ordenada do boton anterior mais a súa altura e 5 pixeles de separación

            End If

            AddHandler b.Click, AddressOf Me.boton_click 'Poñemos o handler de click no boton e indicamos que metodo ten que executar
            Me.Controls.Add(b)
        Next

        letras(27).Text = "Á"
        letras(28).Text = "É"
        letras(29).Text = "Í"
        letras(30).Text = "Ó"
        letras(31).Text = "Ú"
        letras(32).Text = "Ü"
    End Sub

    Private Sub boton_click()
        contClicks += 1
        Dim acierto As Boolean = False
        Dim letra As String = Me.ActiveControl.Text
        If Not gameOver Then
            Me.ActiveControl.BackColor = Color.WhiteSmoke
            Me.ActiveControl.Enabled = False

            For i As Integer = 0 To paLabels.Length - 1
                If letra = paLabels(i).Text Then
                    paLabels(i).ForeColor = Color.Black
                    contadorWin += 1
                    acierto = True
                End If
                If contadorWin = valorSeleccionado.Length Then
                    contAcierto += 1
                    gameOver = True
                    partidaAcabada(1)
                    Exit For
                End If
            Next
            If acierto Then
                contAcierto += 1
            End If
            If Not acierto Then
                contadorMuerte += 1
                picBoxHang.Image = img(contadorMuerte)
                If contadorMuerte = 6 Then
                    gameOver = True
                    partidaAcabada(2)
                End If

            End If
        End If
    End Sub

    Private Sub cargarImagenes()
        img(0) = My.Resources._0
        img(1) = My.Resources._1
        img(2) = My.Resources._2
        img(3) = My.Resources._3
        img(4) = My.Resources._4
        img(5) = My.Resources._5
        img(6) = My.Resources._6
    End Sub

    Private Sub btnPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrueba.Click
        If contadorMuerte < 7 Then
            contadorMuerte += 1
            picBoxHang.Image = img(contadorMuerte)
        End If
    End Sub

    'Escolle unha palabra random do array de palabras e redimensiona o array de labels segun a lonxitude da palabra
    Private Sub aleatorizar()
        Dim Rand As New Random()
        Dim indice As Integer = Rand.Next(0, palabras.Length - 1)
        valorSeleccionado = palabras(indice)
        lblPrueba.Text = valorSeleccionado
        ReDim paLabels(valorSeleccionado.Length - 1)


        For i As Integer = 0 To valorSeleccionado.Length - 1
            Dim p As Label = New Label
            p.Width = 45
            p.Height = 45
            p.FlatStyle = FlatStyle.Flat
            p.Font = New Font("Arial", 20, FontStyle.Bold)
            p.BackColor = ColorTranslator.FromHtml("#E1E5C0")
            p.ForeColor = ColorTranslator.FromHtml("#E1E5C0")
            p.TextAlign = 2
            p.Text = valorSeleccionado.Chars(i)

            If i = 0 Then
                p.Left = centrado()
            Else
                p.Left = paLabels(i - 1).Left + p.Width + 5
            End If
            p.Top = 420
            paLabels(i) = p
            Me.Controls.Add(p)
        Next

    End Sub

    Private Sub borraPalabra()
        If valorSeleccionado.Length > 0 Then
            For i As Integer = 0 To valorSeleccionado.Length - 1
                paLabels(i).Dispose()
            Next
        End If
    End Sub

    Private Sub mostrarPalabra()
        If valorSeleccionado.Length > 0 Then
            For i As Integer = 0 To valorSeleccionado.Length - 1
                paLabels(i).ForeColor = Color.Black
            Next
        End If
    End Sub

    Private Sub btnNuevoJuego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoJuego.Click
        resetearLetras()
        borraPalabra()
        aleatorizar()
        picBoxHang.Image = img(0)
        contadorMuerte = 0
        contadorWin = 0
        gameOver = False
        lblTit.Text = "EL AHORCADO"
        contAcierto = 0
        contClicks = 0
    End Sub

    Private Function centrado() As Integer
        Dim nLetras As Integer = valorSeleccionado.Length
        Dim medidaLetras As Integer = 50 * nLetras - 5
        Dim anchoFormulario = Me.Width
        Dim izquierda As Integer = (anchoFormulario - medidaLetras) / 2
        Return izquierda
    End Function

    Private Sub partidaAcabada(ByVal quienGano As Integer) 'Paramettro entrada: 1 jugador gana 2 jugador pierde
        If quienGano = 1 Then
            lblTit.Text = "VICTORIA!"
            victorias += 1
        Else
            lblTit.Text = "DERROTA :("
            mostrarPalabra()
            derrotas += 1
        End If
        frmResultados.lblValorGanadas.Text = victorias
        frmResultados.lblValorPerdidas.Text = derrotas
        frmResultados.lblValorTotales.Text = CInt(victorias + derrotas)
        frmResultados.lblValPorcentaje.Text = Str(CInt((contAcierto / contClicks) * 100)) + "%"
        frmResultados.ShowDialog()
    End Sub

    Private Sub resetearLetras()
        For i As Integer = 0 To letras.Length - 1
            letras(i).Enabled = True
            letras(i).BackColor = ColorTranslator.FromHtml("#E1E5C0")
        Next
    End Sub

    Private Sub btnRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRes.Click
        frmResultados.lblValorGanadas.Text = victorias
        frmResultados.lblValorPerdidas.Text = derrotas
        frmResultados.lblValorTotales.Text = CInt(victorias + derrotas)

        If contClicks > 0 Then 'Para non ter que facer unha division entre cero
            frmResultados.lblValPorcentaje.Text = Str(CInt((contAcierto / contClicks) * 100)) + "%"
        End If

        frmResultados.ShowDialog()
    End Sub
End Class
