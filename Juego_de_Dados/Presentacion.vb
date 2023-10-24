Public Class Presentacion

    Private Sub Presentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Me.WindowState = FormWindowState.Maximized
        Me.Opacity = 50
        Me.FormBorderStyle = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Interval = 3000
        Timer1.Stop()
        INICIO.Show()
        Me.Hide()
    End Sub
End Class