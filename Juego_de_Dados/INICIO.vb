
Public Class INICIO

    Private Sub INICIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label1.Visible = False
        ' Opciones.Show()
        ' Opciones.TopMost = True '....Hace que el formulario llamado [ Opciones ] este al frente del formulario [ Inicio ]
        Me.FormBorderStyle = False

        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox10.Visible = False

        txtjugador1.Visible = False
        txtjugador2.Visible = False
        Pictb_dificultad2.Image = My.Resources.boton_dificultad2

        GroupBox1.BackColor = Color.SlateBlue
        GroupBox2.BackColor = Color.SlateBlue
        GroupBox3.BackColor = Color.SlateBlue
        GroupBox4.BackColor = Color.SlateBlue
        GroupBox5.BackColor = Color.SlateBlue
        GroupBox6.BackColor = Color.SlateBlue
        GroupBox7.BackColor = Color.BlueViolet
        GroupBox8.BackColor = Color.BlueViolet
        GroupBox9.BackColor = Color.BlueViolet
        GroupBox10.BackColor = Color.BlueViolet

        '************************************************************************************************
        lblmin.Visible = False

        lblmin.ForeColor = Color.White
        '***********************************
        lblmin.Parent = PictureBox1

        lblmin.BackColor = Color.Transparent
        '***********************************
        Groubmini.Parent = PictureBox1

        Groubmini.BackColor = Color.Transparent
        '***********************************
        Pictb_dados2.Visible = False
        '************************************************************************************************
    End Sub

    Private Sub Pictbmin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictbmin.MouseHover
        lblmin.Visible = True
    End Sub

    Private Sub Pictbmin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictbmin.MouseLeave
        lblmin.Visible = False
    End Sub

    Private Sub Pictbmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictbmin.Click

        Me.WindowState = vbNormalFocus 'Para nimimizar el formulario.................

    End Sub



    Private Sub Pictb_cerrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_cerrar1.Click
        Me.Close()

        Presentacion.Close()
    End Sub

    '.................................... BOTON CERRAR ..................................................

    Private Sub Pictb_cerrar1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_cerrar1.MouseHover
        Pictb_cerrar1.Size = New Size(54, 47)
        GroupBox1.Size = New Size(71, 62)
        GroupBox1.BackColor = Color.Red
        Pictb_cerrar1.Image = My.Resources.boton_cerrar2_2
    End Sub

    Private Sub Pictb_cerrar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_cerrar1.MouseLeave
        Pictb_cerrar1.Size = New Size(44, 37)
        GroupBox1.Size = New Size(61, 52)
        GroupBox1.BackColor = Color.SlateBlue
        Pictb_cerrar1.Image = My.Resources.boton_cerrar2
    End Sub

    '.................................... BOTON INICIAR PARTIDA ...........................................

    Private Sub Pictb_Iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_Iniciar.Click
        'Ociones_Juego.Show()
        Label1.Visible = True
        Pictb_Iniciar.Visible = False

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False

        GroupBox7.Visible = True
        GroupBox8.Visible = True
        GroupBox9.Visible = True
        GroupBox10.Visible = True

        txtjugador1.Visible = True
        txtjugador2.Visible = True
        PictureBox1.Image = My.Resources.fondo2
        ' Me.Hide()
    End Sub

    Private Sub Pictb_Iniciar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_Iniciar.MouseHover
        Pictb_Iniciar.Size = New Size(119, 124)
        GroupBox6.Size = New Size(138, 153)

        GroupBox6.BackColor = Color.Blue
        Pictb_Iniciar.Image = My.Resources.boton_iniciar2
    End Sub

    Private Sub Pictb_Iniciar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_Iniciar.MouseLeave
        Pictb_Iniciar.Size = New Size(109, 114)
        GroupBox6.Size = New Size(128, 143)

        GroupBox6.BackColor = Color.SlateBlue
        Pictb_Iniciar.Image = My.Resources.boton_iniciar
    End Sub

    '.................................... BOTON OPCIONES ..................................................

    Private Sub Pictb_opciones_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_opciones.MouseHover
        Pictb_opciones.Size = New Size(119, 124)
        GroupBox5.Size = New Size(138, 153)

        GroupBox5.BackColor = Color.Lime
        Pictb_opciones.Image = My.Resources.boton_configuracion2
    End Sub

    Private Sub Pictb_opciones_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_opciones.MouseLeave
        Pictb_opciones.Size = New Size(109, 114)
        GroupBox5.Size = New Size(128, 143)

        GroupBox5.BackColor = Color.SlateBlue
        Pictb_opciones.Image = My.Resources.boton_configuracion
    End Sub

    '.................................... BOTON ESTADISTICA ..................................................

    Private Sub Pictb_estadistica_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_estadistica.MouseHover
        Pictb_estadistica.Size = New Size(119, 124)
        GroupBox4.Size = New Size(138, 153)

        GroupBox4.BackColor = Color.Blue
        Pictb_estadistica.Image = My.Resources.boton_estadistica2
    End Sub

    Private Sub Pictb_estadistica_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_estadistica.MouseLeave
        Pictb_estadistica.Size = New Size(109, 114)
        GroupBox4.Size = New Size(128, 143)

        GroupBox4.BackColor = Color.SlateBlue
        Pictb_estadistica.Image = My.Resources.boton_estadistica
    End Sub

    '.................................... BOTON AYUDA ..................................................

    Private Sub Pictb_ayuda_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_ayuda.MouseHover
        Pictb_ayuda.Size = New Size(119, 124)
        GroupBox3.Size = New Size(138, 153)

        GroupBox3.BackColor = Color.Blue
        Pictb_ayuda.Image = My.Resources.boton_ayuda2
    End Sub

    Private Sub Pictb_ayuda_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_ayuda.MouseLeave
        Pictb_ayuda.Size = New Size(109, 114)
        GroupBox3.Size = New Size(128, 143)

        GroupBox3.BackColor = Color.SlateBlue
        Pictb_ayuda.Image = My.Resources.boton_ayuda
    End Sub

    '.................................... BOTON ACERCA DE ..................................................

    Private Sub Pictb_acerca_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_acerca.MouseHover
        Pictb_acerca.Size = New Size(119, 124)
        GroupBox2.Size = New Size(138, 153)

        GroupBox2.BackColor = Color.Blue
        Pictb_acerca.Image = My.Resources.boton_acerca_de2
    End Sub

    Private Sub Pictb_acerca_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_acerca.MouseLeave
        Pictb_acerca.Size = New Size(109, 114)
        GroupBox2.Size = New Size(128, 143)

        GroupBox2.BackColor = Color.SlateBlue
        Pictb_acerca.Image = My.Resources.boton_acerca_de
    End Sub



    '******************************************* OPCIONES DEL JUEGO **************************************************

    '****************************************** EVENTO MouseHover & Leave *******************************************
    Private Sub Pictb_dificultad_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad.MouseHover
        Pictb_dificultad.Size = New Size(119, 124)
        GroupBox9.Size = New Size(138, 153)

        GroupBox9.BackColor = Color.Blue
        ' Pictb_dificultad.Image = My.Resources.boton_ayuda
    End Sub

    Private Sub Pictb_dificultad_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad.MouseLeave
        Pictb_dificultad.Size = New Size(109, 114)
        GroupBox9.Size = New Size(128, 143)

        GroupBox9.BackColor = Color.BlueViolet
        'Pictb_dificultad.Image = My.Resources.boton_dificultad
    End Sub

    Private Sub Pictb_dados_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dados.MouseHover
        Pictb_dados.Size = New Size(119, 124)
        GroupBox7.Size = New Size(138, 153)

        GroupBox7.BackColor = Color.Blue
    End Sub

    Private Sub Pictb_dados_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dados.MouseLeave
        Pictb_dados.Size = New Size(109, 114)
        GroupBox7.Size = New Size(128, 143)

        GroupBox7.BackColor = Color.BlueViolet
    End Sub

    '****************************************** EVENTO CLIC *********************************************************
    Private Sub Pictb_dificultad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad.Click
        Pictb_dificultad2.Show()
        Pictb_dificultad.Hide()
    End Sub

    Private Sub Pictb_dificultad2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad2.Click
        Pictb_dificultad.Show()
        Pictb_dificultad2.Hide()
    End Sub

    Private Sub pictb_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_atras.Click
        Pictb_Iniciar.Visible = True

        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        GroupBox4.Visible = True
        GroupBox5.Visible = True
        GroupBox6.Visible = True

        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox10.Visible = False

        txtjugador1.Visible = False
        txtjugador2.Visible = False

        Label1.Visible = False

        PictureBox1.Image = My.Resources.fondo1
    End Sub

    '*****************************************************************************************************************
    Private Sub Pictb_dados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_dados.Click
        Pictb_dados2.Show()
        Pictb_dados.Hide()
    End Sub

    Private Sub Pictb_dados2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dados2.Click
        Pictb_dados.Show()
        Pictb_dados2.Hide()
    End Sub

    '****************************************** EVENTO MouseHover & Leave 2 *********************************************
    Private Sub Pictb_dificultad2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad2.MouseHover
        Pictb_dificultad2.Size = New Size(119, 124)
        GroupBox9.Size = New Size(138, 153)

        GroupBox9.BackColor = Color.Blue
    End Sub

    Private Sub Pictb_dificultad2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dificultad2.MouseLeave
        Pictb_dificultad2.Size = New Size(109, 114)
        GroupBox9.Size = New Size(128, 143)

        GroupBox9.BackColor = Color.BlueViolet
    End Sub

    Private Sub Pictb_dados2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dados2.MouseHover
        Pictb_dados2.Size = New Size(119, 124)
        GroupBox7.Size = New Size(138, 153)

        GroupBox7.BackColor = Color.Blue
    End Sub

    Private Sub Pictb_dados2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_dados2.MouseLeave
        Pictb_dados2.Size = New Size(109, 114)
        GroupBox7.Size = New Size(128, 143)

        GroupBox7.BackColor = Color.BlueViolet
    End Sub

    Private Sub pictb_atras_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_atras.MouseHover
        pictb_atras.Size = New Size(54, 47)
        GroupBox10.Size = New Size(71, 62)

        GroupBox10.BackColor = Color.Blue
    End Sub

    Private Sub pictb_atras_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_atras.MouseLeave
        pictb_atras.Size = New Size(44, 37)
        GroupBox10.Size = New Size(61, 52)

        GroupBox10.BackColor = Color.BlueViolet
    End Sub

    '****************************************** BOTON JUGAR *********************************************************
    Private Sub Pictb_jugar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_jugar.MouseHover
        Pictb_jugar.Size = New Size(119, 124)
        GroupBox8.Size = New Size(138, 153)

        GroupBox8.BackColor = Color.Blue
    End Sub

    Private Sub Pictb_jugar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictb_jugar.MouseLeave
        Pictb_jugar.Size = New Size(109, 114)
        GroupBox8.Size = New Size(128, 143)

        GroupBox8.BackColor = Color.BlueViolet
    End Sub

    Private Sub Pictb_jugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_jugar.Click
        '---------------------------------------------------------------------------------
        If Configuraciones.CheckBox1.Checked = False Then
            Rum_Juego.PictureBox2.BackColor = Configuraciones.TextBox2.BackColor
        End If

        If Configuraciones.CheckBox1.Checked = True Then
            Rum_Juego.PictureBox2.BackColor = Color.White
        End If
        '---------------------------------------------------------------------------------
        If Configuraciones.CheckBox2.Checked = False Then
            Rum_Juego.rjugador1.ForeColor = Configuraciones.TextBox3.BackColor
            Rum_Juego.rjugador2.ForeColor = Configuraciones.TextBox3.BackColor
      
        End If
        If Configuraciones.CheckBox2.Checked = True Then
            Rum_Juego.rjugador1.ForeColor = Color.White
            Rum_Juego.rjugador2.ForeColor = Color.White
        End If
        '---------------------------------------------------------------------------------
        If Configuraciones.CheckBox3.Checked = False Then
            Rum_Juego.Label1.ForeColor = Configuraciones.TextBox4.BackColor
            Rum_Juego.Label2.ForeColor = Configuraciones.TextBox4.BackColor
            Rum_Juego.Label4.ForeColor = Configuraciones.TextBox4.BackColor
            Rum_Juego.Label5.ForeColor = Configuraciones.TextBox4.BackColor
            Rum_Juego.Label6.ForeColor = Configuraciones.TextBox4.BackColor
            Rum_Juego.Label9.ForeColor = Configuraciones.TextBox4.BackColor

        End If
        If Configuraciones.CheckBox3.Checked = True Then
            Rum_Juego.Label1.ForeColor = Color.White
            Rum_Juego.Label2.ForeColor = Color.White
            Rum_Juego.Label4.ForeColor = Color.White
            Rum_Juego.Label5.ForeColor = Color.White
            Rum_Juego.Label6.ForeColor = Color.White
            Rum_Juego.Label9.ForeColor = Color.White
        End If
        '---------------------------------------------------------------------------------

        If Pictb_dados2.Visible = True Then
            Rum_Juego.PictureBox4.Visible = False

            Rum_Juego.PictureBox3.Left = 600
            Rum_Juego.Pictb_dado1.Left = 600
            Rum_Juego.txtn1.Left = 660
            ' Rum_Juego.txtn1.Visible = False
        End If
        Rum_Juego.Show()
    End Sub

    Private Sub Pictb_ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_ayuda.Click
        Configuraciones.Show()
        Me.Hide()

        Configuraciones.lblayuda.Visible = True
        Configuraciones.TextBox1.Visible = True
        Configuraciones.lblayuda.Visible = True

        Configuraciones.Label1.Visible = False
        Configuraciones.Label2.Visible = False
        Configuraciones.Label3.Visible = False
        Configuraciones.Label4.Visible = False
        Configuraciones.Label5.Visible = False

        Configuraciones.TextBox2.Visible = False
        Configuraciones.TextBox3.Visible = False
        Configuraciones.TextBox4.Visible = False

        Configuraciones.btncolor.Visible = False
        Configuraciones.btncolor2.Visible = False
        Configuraciones.btncolor3.Visible = False

        Configuraciones.CheckBox1.Visible = False
        Configuraciones.CheckBox2.Visible = False
        Configuraciones.CheckBox3.Visible = False

    End Sub

    Private Sub Pictb_opciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_opciones.Click
        Configuraciones.Show()
        Me.Hide()

        Configuraciones.lblayuda.Visible = False
        Configuraciones.TextBox1.Visible = False
        Configuraciones.lblayuda.Visible = False

        Configuraciones.Label1.Visible = True
        Configuraciones.Label2.Visible = True
        Configuraciones.Label3.Visible = True
        Configuraciones.Label4.Visible = True
        Configuraciones.Label5.Visible = True

        Configuraciones.TextBox2.Visible = True
        Configuraciones.TextBox3.Visible = True
        Configuraciones.TextBox4.Visible = True

        Configuraciones.btncolor.Visible = True
        Configuraciones.btncolor2.Visible = True
        Configuraciones.btncolor3.Visible = True

        Configuraciones.CheckBox1.Visible = True
        Configuraciones.CheckBox2.Visible = True
        Configuraciones.CheckBox3.Visible = True
    End Sub

    Private Sub Pictb_estadistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_estadistica.Click
        MsgBox("Opcion no disponible por el momento", MsgBoxStyle.Exclamation, "Error")
    End Sub

    Private Sub Pictb_acerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_acerca.Click
        MsgBox("Opcion no disponible por el momento", MsgBoxStyle.Exclamation, "Error")
    End Sub
End Class