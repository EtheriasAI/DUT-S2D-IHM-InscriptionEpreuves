Public Class Inscription1
    Public tps As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        tps = 60
        HScrollBar1.Maximum = 55
        HScrollBar1.Minimum = 18
        Label5.Text = HScrollBar1.Value
        Label9.Text = tps
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If boxnom.Text = "" Or boxprenom.Text = "" Or boxadresse.Text = "" Or boxville.Text = "" Or boxcode.Text = "" Then
            MsgBox("vous devez remplir toutes les cases")
            Exit Sub
        End If

        Inscription2.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label11.Text = DateTime.Now
        Label9.Text = tps
        tps -= 1
        If tps = 0 Then
            Timer1.Stop()
            Acceuil.Show()
            Me.Close()
        End If
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label5.Text = HScrollBar1.Value
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Close()
    End Sub
    Private Sub boxcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxcode.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
    End Sub
End Class