Public Class Pausa

    Private Sub Pausa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = False

        Groub_reiniciarp.BackColor = Color.Blue
        Groub_continuar.BackColor = Color.Blue
        Groub_menuP.BackColor = Color.Blue
        Groub_atras.BackColor = Color.Blue
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------
    '........................................ Evento MouseHover & MouseLeave ...............................................
    '-----------------------------------------------------------------------------------------------------------------------

    Private Sub pictb_reiniciarp_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_reiniciarp.MouseHover
        Groub_reiniciarp.Size = New Size(138, 153)
        pictb_reiniciarp.Size = New Size(119, 124)

        Groub_reiniciarp.BackColor = Color.Lime
        pictb_reiniciarp.Image = My.Resources.boton_reiniciar2
    End Sub

    Private Sub pictb_reiniciarp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_reiniciarp.MouseLeave
        Groub_reiniciarp.Size = New Size(128, 143)
        pictb_reiniciarp.Size = New Size(109, 114)

        Groub_reiniciarp.BackColor = Color.Blue
        pictb_reiniciarp.Image = My.Resources.boton_reiniciar
    End Sub

    Private Sub pictb_continuar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_continuar.MouseHover
        Groub_continuar.Size = New Size(138, 153)
        pictb_continuar.Size = New Size(119, 124)

        Groub_continuar.BackColor = Color.Lime
        pictb_continuar.Image = My.Resources.boton_rcontinua2r
    End Sub

    Private Sub pictb_continuar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_continuar.MouseLeave
        Groub_continuar.Size = New Size(128, 143)
        pictb_continuar.Size = New Size(109, 114)

        Groub_continuar.BackColor = Color.Blue
        pictb_continuar.Image = My.Resources.boton_rcontinuar
    End Sub

    Private Sub pictb_menuP_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_menuP.MouseHover
        Groub_menuP.Size = New Size(138, 153)
        pictb_menuP.Size = New Size(119, 124)

        Groub_menuP.BackColor = Color.Lime
        pictb_menuP.Image = My.Resources.boton_rmenuPrincipal2
    End Sub

    Private Sub pictb_menuP_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_menuP.MouseLeave
        Groub_menuP.Size = New Size(128, 143)
        pictb_menuP.Size = New Size(109, 114)

        Groub_menuP.BackColor = Color.Blue
        pictb_menuP.Image = My.Resources.boton_rmenuPrincipal
    End Sub

    Private Sub pictb_atras_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_atras.MouseHover
        pictb_atras.Size = New Size(54, 47)
        Groub_atras.Size = New Size(71, 62)

        Groub_atras.BackColor = Color.Lime
    End Sub

    Private Sub pictb_atras_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_atras.MouseLeave
        pictb_atras.Size = New Size(44, 37)
        Groub_atras.Size = New Size(61, 52)

        Groub_atras.BackColor = Color.Blue
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------
    '...................................................... Evento Clic ....................................................
    '-----------------------------------------------------------------------------------------------------------------------

    Private Sub pictb_reiniciarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_reiniciarp.Click
        '---------------------------
        Rum_Juego.Label3.Text = ""
        Rum_Juego.lblan2.Text = "0"
        Rum_Juego.lblan1.Text = "0"
        Rum_Juego.lblacer1.Text = "0"
        Rum_Juego.lblacer2.Text = "0"
        Rum_Juego.lblpuntos1.Text = "0"
        Rum_Juego.lblpuntos2.Text = "0"
        '---------------------------
        Rum_Juego.sota3 = 0
        Rum_Juego.sota4 = 0
        Rum_Juego.d = 0
        Rum_Juego.c = 0
        Rum_Juego.acu1 = 0
        Rum_Juego.acu2 = 0
        Rum_Juego.total = 0
        Rum_Juego.total3 = 0
        Rum_Juego.s1 = 0
        Rum_Juego.s2 = 0
        Rum_Juego.z1 = 0
        Rum_Juego.z2 = 0

        Rum_Juego.Show()

        Rum_Juego.pictb_pausa.Enabled = False
        Rum_Juego.pictb_tirar.Enabled = True
        Rum_Juego.pictb_tirar2.Enabled = True
        Me.Close()

    End Sub

    Private Sub pictb_continuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_continuar.Click
        Rum_Juego.Show()
        Me.Close()
    End Sub

    Private Sub pictb_menuP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_menuP.Click
        Dim respuesta As Byte

        respuesta = MsgBox("Se borrará todo el progreso, Desea continual", vbYesNo)
        If respuesta = vbYes Then
            Rum_Juego.Label3.Text = ""
            Rum_Juego.lblan2.Text = "0"
            Rum_Juego.lblan1.Text = "0"
            Rum_Juego.lblacer1.Text = "0"
            Rum_Juego.lblacer2.Text = "0"
            Rum_Juego.lblpuntos1.Text = "0"
            Rum_Juego.lblpuntos2.Text = "0"
            INICIO.txtjugador1.Text = "Jugador1"
            INICIO.txtjugador2.Text = "Jugador2"
            '---------------------------
            Rum_Juego.sota3 = 0
            Rum_Juego.sota4 = 0
            Rum_Juego.d = 0
            Rum_Juego.c = 0
            Rum_Juego.acu1 = 0
            Rum_Juego.acu2 = 0
            Rum_Juego.total = 0
            Rum_Juego.total3 = 0

            Rum_Juego.Show()

            Rum_Juego.pictb_pausa.Enabled = False
            Rum_Juego.pictb_tirar.Enabled = True
            Rum_Juego.pictb_tirar2.Enabled = True

            INICIO.Show()
            INICIO.Pictb_Iniciar.Visible = True

            INICIO.GroupBox1.Visible = True
            INICIO.GroupBox2.Visible = True
            INICIO.GroupBox3.Visible = True
            INICIO.GroupBox4.Visible = True
            INICIO.GroupBox5.Visible = True
            INICIO.GroupBox6.Visible = True

            INICIO.GroupBox7.Visible = False
            INICIO.GroupBox8.Visible = False
            INICIO.GroupBox9.Visible = False
            INICIO.GroupBox10.Visible = False

            INICIO.txtjugador1.Visible = False
            INICIO.txtjugador2.Visible = False
            INICIO.PictureBox1.Image = My.Resources.fondo1

            Me.Close()
            Rum_Juego.Close()
        End If
    End Sub

    Private Sub pictb_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_atras.Click
        Me.Close()
    End Sub
End Class