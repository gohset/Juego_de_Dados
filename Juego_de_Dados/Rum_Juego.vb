Imports System.IO
Public Class Rum_Juego
    Dim a, b, a2, b2, t, t2 As Integer
    Public d, c, acu1, acu2, s1, s2 As Integer
    Public total, total2, total3, sota, sota2, sota3, sota4 As Integer
    Dim acumulador1 As Integer
    Public z1, z2, k1, k2 As Integer
    Dim ku As Integer = 2


    Private Sub Rum_Juego_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("Juego_dados.swf"))
        Groubmini.BackColor = Color.Blue
        lblmin.Visible = False

        'If Configuraciones.CheckBox1.Checked = False Then
        '    PictureBox2.BackColor = Configuraciones.TextBox2.BackColor
        'ElseIf Configuraciones.CheckBox1.Checked = True Then
        '    PictureBox2.BackColor = Color.White
        'End If

        'If Configuraciones.CheckBox2.Checked = False Then
        '    rjugador1.ForeColor = Configuraciones.TextBox3.BackColor
        '    rjugador2.ForeColor = Configuraciones.TextBox3.BackColor
        'Else
        '    rjugador1.ForeColor = Color.White
        '    rjugador2.ForeColor = Color.White
        'End If


        txtn1.Visible = False
        txtn2.Visible = False
        Label3.Parent = PictureBox2
        Label3.BackColor = Color.Transparent
        'pictb_pausa.Enabled = False

        Groub_tirar.BackColor = Color.BlueViolet
        Groub_pausa.BackColor = Color.BlueViolet

        Label3.Top = 60
        Label3.Left = 240

        rjugador1.Text = INICIO.txtjugador1.Text
        rjugador2.Text = INICIO.txtjugador2.Text

        rjugador1.Parent = PictureBox1
        rjugador2.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label6.Parent = PictureBox1

        rjugador1.BackColor = Color.Transparent
        rjugador2.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent

        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label9.Parent = PictureBox1

        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent

        'INICIO.Pictb_dados2.Visible = False
        If INICIO.Pictb_dados2.Visible = True Then
            Pictb_dado2.Visible = False
            txtn2.Visible = False
        Else
            Pictb_dado2.Visible = True
            'txtn2.Visible = True

        End If
    End Sub

    Private Sub pictb_pausa_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_pausa.MouseHover
        Groub_pausa.Size = New Size(124, 81)
        pictb_pausa.Size = New Size(105, 65)

        Groub_pausa.BackColor = Color.Lime
        pictb_pausa.Image = My.Resources.boton_pausa2
    End Sub

    Private Sub pictb_pausa_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_pausa.MouseLeave
        Groub_pausa.Size = New Size(114, 71)
        pictb_pausa.Size = New Size(95, 55)

        Groub_pausa.BackColor = Color.BlueViolet
        pictb_pausa.Image = My.Resources.boton_pausa
    End Sub

    Private Sub pictb_tirar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_tirar.MouseHover
        Groub_tirar.Size = New Size(124, 81)
        pictb_tirar.Size = New Size(105, 65)

        Groub_tirar.BackColor = Color.Lime
        pictb_tirar.Image = My.Resources.boton_tirar2
    End Sub

    Private Sub pictb_tirar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_tirar.MouseLeave
        Groub_pausa.Size = New Size(114, 71)
        pictb_tirar.Size = New Size(95, 55)

        Groub_tirar.BackColor = Color.BlueViolet
        pictb_tirar.Image = My.Resources.boton_tirar
    End Sub

    Private Sub pictb_tirar2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_tirar2.MouseHover
        pictb_tirar2.Size = New Size(105, 65)
        pictb_tirar2.Image = My.Resources.boton_tirar2
    End Sub

    Private Sub pictb_tirar2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_tirar2.MouseLeave
        pictb_tirar2.Size = New Size(95, 55)
        pictb_tirar2.Image = My.Resources.boton_tirar
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '********************************************* Boton tirar 1 **************************************************
    '--------------------------------------------------------------------------------------------------------------
    Sub j1()
        ' If ku = 10 Then
        If Timer1.Enabled = True Then
            'If Val(TextBox1.Text) = 14 Then

            If INICIO.Pictb_dados.Visible = True Then
                sota3 = sota3 + 1 '............ cantidad de lanzamientos a realizarse .................

                If sota3 <= 3 Then

                    INICIO.Pictb_dados2.Visible = False
                    'd = d + 1
                    'lblan1.Text = d
                    lblan1.Text = sota3

                    Label3.Text = rjugador1.Text
                    ' a = Int((6) * Rnd()) + 1
                    Dim aleat As New Random
                    a = aleat.Next(1, 6)

                    If a = 1 Then
                        Pictb_dado1.Image = My.Resources.dado1_1
                    ElseIf a = 2 Then
                        Pictb_dado1.Image = My.Resources.dado2_2
                    ElseIf a = 3 Then
                        Pictb_dado1.Image = My.Resources.dado3_3
                    ElseIf a = 4 Then
                        Pictb_dado1.Image = My.Resources.dado4_4
                    ElseIf a = 5 Then
                        Pictb_dado1.Image = My.Resources.dado5_5
                    ElseIf a = 6 Then
                        Pictb_dado1.Image = My.Resources.dado6_6
                    End If
                    '**********************************************
                    txtn1.Text = a
                    s1 = a + b
                    lblacer1.Text = acu1

                    '**********************************************
                    ' Dim aleat2 As New Random
                    b = Int((6) * Rnd() + 1)

                    If b = 1 Then
                        Pictb_dado2.Image = My.Resources.dado1_1
                    ElseIf b = 2 Then
                        Pictb_dado2.Image = My.Resources.dado2_2
                    ElseIf b = 3 Then
                        Pictb_dado2.Image = My.Resources.dado3_3
                    ElseIf b = 4 Then
                        Pictb_dado2.Image = My.Resources.dado4_4
                    ElseIf b = 5 Then
                        Pictb_dado2.Image = My.Resources.dado5_5
                    ElseIf b = 6 Then
                        Pictb_dado2.Image = My.Resources.dado6_6
                    End If
                    '____________________________________________
                    '____________________________________________


                    txtn2.Text = b
                    s1 = a + b
                    acu1 = acu1 + s1 '................... ACUMULAR PUNTOS <<<<<<<<<
                    lblacer1.Text = acu1

                    pictb_tirar.Visible = False
                    pictb_tirar2.Visible = True '..........................PUNTOS <<<<<<

                    '**************************************************
                    total2 = s1 '........... variable ..... Para comparar..y saber quien gana el punto......
                    's1 = 0
                    '**************************************************
                    '____________________________________________
                    '----------------------------------------------------------------------------------------------------
                    'Si al lanzar los dados..y ambos participantes sacan la misma cantidad de puntos, siendo el caso ha 
                    'ninguno se les dara el punto y al total de lanzaminetos se le resta 1.....ya que cuando sacan igual
                    'en puntos no cuenta.....................
                    '----------------------------------------------------------------------------------------------------
                    sota = Val(lblan1.Text)
                    sota2 = Val(lblan2.Text)

                    If sota3 = 1 And sota4 = 1 And s1 = s2 Then
                        sota3 = 0
                        sota4 = 0

                        lblan1.Text = sota3
                        lblan2.Text = sota4
                        '-----------------------
                        'd = 1
                        'lblan1.Text = d
                        'c = c + 1
                        'lblan2.Text = c
                        '-----------------------
                    End If

                    If sota3 = 2 And sota4 = 2 And s1 = s2 Then
                        sota3 = sota3 - 1
                        sota4 = sota4 - 1

                        s1 = 0
                        s2 = 0
                        lblan1.Text = sota3
                        lblan2.Text = sota4
                    End If

                    If sota3 = 3 And sota4 = 3 And s1 = s2 Then
                        sota3 = sota3 - 1
                        sota4 = sota4 - 1

                        s1 = 0
                        s2 = 0
                        lblan1.Text = sota3
                        lblan2.Text = sota4
                    End If
                    '********************************************************-----------------
                    'Timer1.Start()
                    'If ku = 4 Then
                    '    Timer1.Stop()
                    'End If
                End If '<<<<<<<<<<<<<<<<<<<<<<
            End If

            'Timer1
        End If
        '********************************************************-----------------

        '-------------------------------------------------------------------------------------------------------------
        'Este es el codigo del mismo boton picture 2 que aparece al precionar el q esta encima es decir...el picture 1
        'Este codigo se habilitara cuando el usuario elija [ jugar con UN solo DADO ].................................
        '-------------------------------------------------------------------------------------------------------------


        If INICIO.Pictb_dados2.Visible = True Then
            PictureBox4.Visible = False
            INICIO.Pictb_dados.Visible = False
            Pictb_dado2.Visible = False
            'txtn2.Visible = False
            '------------------------------------
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            Timer1.Start()
            '------------------------------------
            If ku = 14 Then
                sota3 = sota3 + 1
                If sota3 <= 3 Then

                    d = d + 1
                    lblan1.Text = d
                    ' End If

                    Label3.Text = rjugador1.Text

                    Dim aleat As New Random
                    a = aleat.Next(1, 6)
                    'a = Int((6) * Rnd()) + 1
                    If a = 1 Then
                        Pictb_dado1.Image = My.Resources.dado1_1
                    ElseIf a = 2 Then
                        Pictb_dado1.Image = My.Resources.dado2_2
                    ElseIf a = 3 Then
                        Pictb_dado1.Image = My.Resources.dado3_3
                    ElseIf a = 4 Then
                        Pictb_dado1.Image = My.Resources.dado4_4
                    ElseIf a = 5 Then
                        Pictb_dado1.Image = My.Resources.dado5_5
                    ElseIf a = 6 Then
                        Pictb_dado1.Image = My.Resources.dado6_6
                    End If
                    txtn1.Text = a 'INICIO visuvel=false ...pictb_tirar
                    s1 = a
                    acu1 = acu1 + s1
                    lblacer1.Text = acu1

                    pictb_tirar.Visible = False
                    pictb_tirar2.Visible = True
                    '**********************************************
                End If
            End If

            'Timer1
        End If
    End Sub
    Private Sub pictb_tirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_tirar.Click
        '------------------------------------
        Timer1.Enabled = False
        Timer1.Start()
        '------------------------------------

    End Sub
    '--------------------------------------------------------------------------------------------------------------
    '********************************************* Boton tirar 2 **************************************************
    '--------------------------------------------------------------------------------------------------------------
    Sub j2()
        ' If ku = 10 Then
        If Timer2.Enabled = True Then
            'If Val(TextBox1.Text) = 14 Then

            If INICIO.Pictb_dados.Visible = True Then
                INICIO.Pictb_dados2.Visible = False

                sota4 = sota4 + 1 '............ cantidad de lanzamientos a realizarse .................
                If sota4 <= 3 Then

                    'c = c + 1
                    'lblan2.Text = c
                    lblan2.Text = sota4

                    Label3.Text = rjugador2.Text

                    Dim aleat3 As New Random
                    a2 = aleat3.Next(1, 6)
                    'a2 = Int((6) * Rnd()) + 1

                    If a2 = 1 Then
                        Pictb_dado1.Image = My.Resources.dado1_1
                    ElseIf a2 = 2 Then
                        Pictb_dado1.Image = My.Resources.dado2_2
                    ElseIf a2 = 3 Then
                        Pictb_dado1.Image = My.Resources.dado3_3
                    ElseIf a2 = 4 Then
                        Pictb_dado1.Image = My.Resources.dado4_4
                    ElseIf a2 = 5 Then
                        Pictb_dado1.Image = My.Resources.dado5_5
                    ElseIf a2 = 6 Then
                        Pictb_dado1.Image = My.Resources.dado6_6
                    End If
                    txtn1.Text = a2
                    s2 = a2 + b2
                    'acu2 = acu2 + s2
                    'lblacer2.Text = acu2
                    '**********************************************

                    b2 = Int((6 - 1 + 1) * Rnd()) + 1


                    If b2 = 1 Then
                        Pictb_dado2.Image = My.Resources.dado1_1
                    ElseIf b2 = 2 Then
                        Pictb_dado2.Image = My.Resources.dado2_2
                    ElseIf b2 = 3 Then
                        Pictb_dado2.Image = My.Resources.dado3_3
                    ElseIf b2 = 4 Then
                        Pictb_dado2.Image = My.Resources.dado4_4
                    ElseIf b2 = 5 Then
                        Pictb_dado2.Image = My.Resources.dado5_5
                    ElseIf b2 = 6 Then
                        Pictb_dado2.Image = My.Resources.dado6_6
                    End If

                    '__________________________________________>>>>>>>>>>>>>>>>> TODO SUCEDE AQUI <<<<<<<<<<<<<<<<<<<<<<<


                    txtn2.Text = b2
                    s2 = a2 + b2
                    acu2 = acu2 + s2 '................... ACUMULAR PUNTOS <<<<<<<<<
                    lblacer2.Text = acu2

                    pictb_tirar.Visible = True
                    pictb_tirar2.Visible = False '......................PUNTOS <<<<<<<

                    If total2 > s2 Then '.................. [[[ REALIZANDO COMPARACIÒN ]]] <<<<<<<<<<<<

                        total = total + 1 '+ Val(lblpuntos1)
                        lblpuntos1.Text = total
                    End If
                    If s2 > total2 Then
                        total3 = total3 + 1
                        lblpuntos2.Text = total3
                    End If

                    '__________________________________________
                    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<                    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    '.............................................. LOGICA DEL JUEGO <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<                    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                    sota = Val(lblan1.Text)
                    sota2 = Val(lblan2.Text)
                    'If Val(lblpuntos1.Text) = Val(lblpuntos2.Text) Then
                    '    sota4 = sota4 - 1
                    '    sota3 = sota3 - 1
                    'End If
                    '-----------------------------------------------------------------------------------------------------------
                    '..................Elije el ganador, cuando ambos jugadores hallan realizado sus 3 tiros....................
                    '-----------------------------------------------------------------------------------------------------------

                    If sota = 3 And sota2 = 3 Then
                        If s1 <> s2 Then

                            If Val(lblpuntos1.Text) > Val(lblpuntos2.Text) Then
                                MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                                MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")
                                pictb_tirar.Enabled = False
                                pictb_tirar2.Enabled = False
                                pictb_pausa.Enabled = True
                            End If
                            If Val(lblpuntos2.Text) > Val(lblpuntos1.Text) Then
                                MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                                MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                                pictb_tirar.Enabled = False
                                pictb_tirar2.Enabled = False
                                pictb_pausa.Enabled = True
                            End If
                        Else
                            'sota3 = sota3 - 1
                            'sota4 = sota4 - 1

                            's1 = 0
                            's2 = 0
                            'lblan1.Text = sota3
                            'lblan2.Text = sota4
                        End If
                    End If

                    '---------------------------------------------------------------------------------------------------------
                    '........................Elije el ganador, cuando ambos jugadores hallan realizado 2 tiros.................
                    '...................................y el otro tenga 2 puntos mas que el otro...............................
                    '---------------------------------------------------------------------------------------------------------
                    If sota = 2 And sota2 = 2 Then

                        If Val(lblpuntos1.Text) = 2 And Val(lblpuntos2.Text) = 0 Then
                            MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                            MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")
                            pictb_tirar.Enabled = False
                            pictb_tirar2.Enabled = False
                            pictb_pausa.Enabled = True
                        End If
                        If Val(lblpuntos2.Text) = 2 And Val(lblpuntos1.Text) = 0 Then
                            MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                            MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                            pictb_tirar.Enabled = False
                            pictb_tirar2.Enabled = False
                            pictb_pausa.Enabled = True
                        End If
                        '----------------------------------------------------------------------------------------------
                        If Val(lblan1.Text) = 3 And Val(lblpuntos1.Text) = 2 And Val(lblpuntos2.Text) = 1 Then
                            MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                            MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")
                            pictb_tirar.Enabled = False
                            pictb_tirar2.Enabled = False
                            pictb_pausa.Enabled = True
                        End If
                        If Val(lblan1.Text) = 3 And Val(lblpuntos2.Text) = 1 And Val(lblpuntos1.Text) = 2 Then
                            MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                            MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                            pictb_tirar.Enabled = False
                            pictb_tirar2.Enabled = False
                            pictb_pausa.Enabled = True
                        End If

                    End If

                    '----------------------------------------------------------------------------------------------------
                    'Si al lanzar los dados..y ambos participantes sacan la misma cantidad de puntos, siendo el caso ha 
                    'ninguno se les dara el punto y al total de lanzaminetos se le resta 1.....ya que cuando sacan igual
                    'en puntos no cuenta.....................
                    '----------------------------------------------------------------------------------------------------
                    If s1 = s2 Then
                        sota3 = sota3 - 1
                        sota4 = sota4 - 1
                        lblan1.Text = sota3
                        lblan2.Text = sota4
                    End If

                    'If sota3 = 1 And sota4 = 1 And s1 = s2 Then
                    '    sota3 = 0
                    '    sota4 = 0

                    '    lblan1.Text = sota3
                    '    lblan2.Text = sota4
                    '    '-----------------------
                    '    'd = 1
                    '    'lblan1.Text = d
                    '    'c = c + 1
                    '    'lblan2.Text = c
                    '    '-----------------------
                    'End If

                    'If sota3 = 2 And sota4 = 2 And s1 = s2 Then
                    '    sota3 = sota3 - 1
                    '    sota4 = sota4 - 1

                    '    s1 = 0
                    '    s2 = 0
                    '    lblan1.Text = sota3
                    '    lblan2.Text = sota4
                    'End If

                    'If sota3 = 3 And sota4 = 3 And s1 = s2 Then
                    '    sota3 = sota3 - 1
                    '    sota4 = sota4 - 1

                    '    s1 = 0
                    '    s2 = 0
                    '    lblan1.Text = sota3
                    '    lblan2.Text = sota4
                    'End If

                    'Timer2.Start()
                    'If ku = 4 Then
                    '    Timer2.Stop()
                    'End If

                End If
            End If

            'Timer1
        End If

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<      .........      >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '..............................................     .........      <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<      ........       >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        '-------------------------------------------------------------------------------------------------------------
        'Este es el codigo del mismo boton picture 2 que aparece al precionar el q esta encima es decir...el picture 1
        'Este codigo se habilitara cuando el usuario elija [ jugar con UN solo DADO ].................................
        '-------------------------------------------------------------------------------------------------------------
        '------------------------------------
        'PictureBox3.Visible = True
        'PictureBox4.Visible = True
        'Timer1.Start() '....................................................... <<< TIMER1 >>>
        ''------------------------------------
        'If ku = 14 Then
        If INICIO.Pictb_dados2.Visible = True Then
            PictureBox4.Visible = False
            INICIO.Pictb_dados.Visible = False
            Pictb_dado2.Visible = False
            'txtn2.Visible = False

            '------------------------------------
            sota4 = sota4 + 1
            If sota4 <= 3 Then
                c = c + 1
                lblan2.Text = c
                Label3.Text = rjugador2.Text

                Dim aleat As New Random
                a2 = aleat.Next(1, 6)
                'a2 = Int((6 - 1 + 1) * Rnd()) + 1

                If a2 = 1 Then
                    Pictb_dado1.Image = My.Resources.dado1_1
                ElseIf a2 = 2 Then
                    Pictb_dado1.Image = My.Resources.dado2_2
                ElseIf a2 = 3 Then
                    Pictb_dado1.Image = My.Resources.dado3_3
                ElseIf a2 = 4 Then
                    Pictb_dado1.Image = My.Resources.dado4_4
                ElseIf a2 = 5 Then
                    Pictb_dado1.Image = My.Resources.dado5_5
                ElseIf a2 = 6 Then
                    Pictb_dado1.Image = My.Resources.dado6_6
                End If
                txtn2.Text = a2
                s2 = a2
                acu2 = acu2 + s2
                lblacer2.Text = acu2
                '**********************************************

                pictb_tirar.Visible = True
                pictb_tirar2.Visible = False
                '********************************************************------------------
                If s1 > s2 Then
                    z1 = z1 + 1
                    lblpuntos1.Text = z1
                End If
                If s2 > s1 Then
                    z2 = z2 + 1
                    lblpuntos2.Text = z2
                End If
                If s1 = s2 Then
                    sota3 = sota3 - 1
                    sota4 = sota4 - 1
                    d = d - 1
                    c = c - 1

                    lblan1.Text = d
                    lblan2.Text = c
                End If
                If Val(lblan2.Text) = 2 And Val(lblpuntos1.Text) = 2 And Val(lblpuntos2.Text) = 0 Then
                    MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
                If Val(lblan2.Text) = 2 And Val(lblpuntos2.Text) = 2 And Val(lblpuntos1.Text) = 0 Then
                    MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
                '----------------------------------------------------------------------------------------------
                If Val(lblan2.Text) = 3 And Val(lblpuntos2.Text) = 2 And Val(lblpuntos1.Text) = 1 Then
                    MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
                If Val(lblan2.Text) = 3 And Val(lblpuntos2.Text) = 1 And Val(lblpuntos1.Text) = 2 Then
                    MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
                '-------------------------------------------------------------------------------------------------
                If Val(lblan2.Text) = 3 And Val(lblpuntos1.Text) = 2 And Val(lblpuntos2.Text) = 0 Then
                    MsgBox(rjugador1.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
                If Val(lblan2.Text) = 3 And Val(lblpuntos2.Text) = 2 And Val(lblpuntos1.Text) = 0 Then
                    MsgBox(rjugador2.Text & "...Ganador (a)", MsgBoxStyle.Information, "El jugador ganador es")
                    MsgBox("Fin del Juego", MsgBoxStyle.Exclamation, "Finish")

                    pictb_tirar.Enabled = False
                    pictb_tirar2.Enabled = False
                    pictb_pausa.Enabled = True
                End If
            End If
        End If


        'timer1
        'End If
    End Sub

    Private Sub pictb_tirar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictb_tirar2.Click
        '------------------------------------
        Timer2.Enabled = False
        Timer2.Start()
        '------------------------------------

    End Sub

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

    Private Sub Pictb_cerrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictb_cerrar1.Click
        Me.Close()
        INICIO.Close()
        Presentacion.Close()
        Configuraciones.Close()
    End Sub

    Private Sub pictb_pausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_pausa.Click
        Pausa.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If INICIO.Pictb_dados2.Visible = True Then
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            ku = ku + 1
            TextBox1.Text = ku
            If ku = 2 Then
                PictureBox3.Image = My.Resources.dado4_4
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 4 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 6 Then
                PictureBox3.Image = My.Resources.dado5_5
                PictureBox4.Image = My.Resources.dado3_3
                TextBox1.Text = ku
            ElseIf ku = 8 Then
                PictureBox3.Image = My.Resources.dado3_3
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 10 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado5_5
                TextBox1.Text = ku
            ElseIf ku = 12 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 14 Then
                PictureBox3.Image = My.Resources.dado1_1
                PictureBox4.Image = My.Resources.dado4_4
                TextBox1.Text = ku
                j1()
                Timer1.Enabled = True
                Timer1.Stop()

                ku = 0
                'TextBox1.Text = ku
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                'Timer1.Start()
            End If
        End If

        If INICIO.Pictb_dados.Visible = True Then
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            ku = ku + 1
            TextBox1.Text = ku
            If ku = 2 Then
                PictureBox3.Image = My.Resources.dado4_4
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 4 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 6 Then
                PictureBox3.Image = My.Resources.dado5_5
                PictureBox4.Image = My.Resources.dado3_3
                TextBox1.Text = ku
            ElseIf ku = 8 Then
                PictureBox3.Image = My.Resources.dado3_3
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 10 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado5_5
                TextBox1.Text = ku
            ElseIf ku = 12 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 14 Then
                PictureBox3.Image = My.Resources.dado1_1
                PictureBox4.Image = My.Resources.dado4_4
                TextBox1.Text = ku
                j1()
                Timer1.Enabled = True
                Timer1.Stop()

                ku = 0
                'TextBox1.Text = ku
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                'Timer1.Start()
            End If
        End If
       
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If INICIO.Pictb_dados2.Visible = True Then
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            ku = ku + 1
            TextBox1.Text = ku
            If ku = 2 Then
                PictureBox3.Image = My.Resources.dado4_4
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 4 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 6 Then
                PictureBox3.Image = My.Resources.dado5_5
                PictureBox4.Image = My.Resources.dado3_3
                TextBox1.Text = ku
            ElseIf ku = 8 Then
                PictureBox3.Image = My.Resources.dado3_3
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 10 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado5_5
                TextBox1.Text = ku
            ElseIf ku = 12 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 14 Then
                PictureBox3.Image = My.Resources.dado1_1
                PictureBox4.Image = My.Resources.dado4_4
                TextBox1.Text = ku
                j2()
                Timer2.Enabled = True
                Timer2.Stop()

                ku = 0
                'TextBox2.Text = ku
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                'Timer2.Start()
            End If
        End If

        If INICIO.Pictb_dados.Visible = True Then
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            ku = ku + 1
            TextBox1.Text = ku
            If ku = 2 Then
                PictureBox3.Image = My.Resources.dado4_4
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 4 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 6 Then
                PictureBox3.Image = My.Resources.dado5_5
                PictureBox4.Image = My.Resources.dado3_3
                TextBox1.Text = ku
            ElseIf ku = 8 Then
                PictureBox3.Image = My.Resources.dado3_3
                PictureBox4.Image = My.Resources.dado1_1
                TextBox1.Text = ku
            ElseIf ku = 10 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado5_5
                TextBox1.Text = ku
            ElseIf ku = 12 Then
                PictureBox3.Image = My.Resources.dado2_2
                PictureBox4.Image = My.Resources.dado6_6
                TextBox1.Text = ku
            ElseIf ku = 14 Then
                PictureBox3.Image = My.Resources.dado1_1
                PictureBox4.Image = My.Resources.dado4_4
                TextBox1.Text = ku
                j2()
                Timer2.Enabled = True
                Timer2.Stop()

                ku = 0
                'TextBox1.Text = ku
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                'Timer1.Start()
            End If
        End If
    End Sub

    Private Sub Pictbmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pictbmin.Click
        Me.WindowState = vbNormalFocus 'Para nimimizar el formulario.................
        INICIO.WindowState = vbNormalFocus
    End Sub

    Private Sub Pictbmin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictbmin.MouseHover
        lblmin.Visible = True
        Groubmini.BackColor = Color.Lime

        lblmin.Parent = PictureBox1
        lblmin.BackColor = Color.Transparent
        lblmin.ForeColor = Color.White
    End Sub

    Private Sub Pictbmin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pictbmin.MouseLeave
        lblmin.Visible = False
        Groubmini.BackColor = Color.Blue
    End Sub
End Class