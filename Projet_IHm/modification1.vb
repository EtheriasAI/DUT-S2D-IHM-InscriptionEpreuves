Public Class modification1
    Dim t As Candidat
    Private Sub modification1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim s As String = Modifier.ComboBox1.Text.Chars(0)
        If IsNumeric(s) = True Then
            i = CInt(s)
        End If
        t = Acceuil.getcandidat(i)
        HScrollBar1.Maximum = 55
        HScrollBar1.Minimum = 18
        HScrollBar1.Value = t.age
        Label5.Text = HScrollBar1.Value
        boxnom.Text = t.nom
        boxprenom.Text = t.prenom
        boxadresse.Text = t.adresse
        boxcode.Text = t.code
        boxville.Text = t.ville
    End Sub
    Function getcandidamodif()
        Return t
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        t.age = HScrollBar1.Value
        t.nom = boxnom.Text
        t.prenom = boxprenom.Text
        t.adresse = boxadresse.Text
        t.code = boxcode.Text
        t.ville = boxville.Text
        modification2.Show()
        Me.Hide()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label5.Text = HScrollBar1.Value
    End Sub
End Class