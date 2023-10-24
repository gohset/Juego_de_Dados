Public Class Configuraciones

    Private Sub Configuraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = False

        lblayuda.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        CheckBox1.Parent = PictureBox1
        CheckBox2.Parent = PictureBox1
        CheckBox3.Parent = PictureBox1

        TextBox1.Visible = False

        lblayuda.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        CheckBox1.BackColor = Color.Transparent
        CheckBox2.BackColor = Color.Transparent
        CheckBox3.BackColor = Color.Transparent


        lblayuda.Left = 350
        Label1.Left = 370


        lblayuda.Top = 150
        Label1.Top = 280
    End Sub

    Private Sub btncolor_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncolor.Click
        ColorDialog1.ShowDialog()
        TextBox2.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btncolor2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncolor2.Click
        ColorDialog1.ShowDialog()
        TextBox3.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btncolor3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncolor3.Click
        ColorDialog1.ShowDialog()
        TextBox4.BackColor = ColorDialog1.Color
    End Sub

    Private Sub pictb_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictb_atras.Click
        Me.Hide()
        INICIO.Show()
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
End Class