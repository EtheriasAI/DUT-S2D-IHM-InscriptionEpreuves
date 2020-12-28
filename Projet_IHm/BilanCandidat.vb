Public Class BilanCandidat
    Private Sub BilanCandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Candidat = Acceuil.getidentifiant(Bilan.ComboBox2.Text)
        Label2.Text = t.nom + t.prenom
        Label14.Text = t.numero
        Label15.Text = t.age
        Label16.Text = t.nom
        Label17.Text = t.prenom
        Label18.Text = t.adresse
        Label19.Text = t.code
        Label20.Text = t.ville
        Label21.Text = t.region
        Label22.Text = t.ecrit(0) + " " + t.ecrit(1) + "
" + t.ecrit(2) + " " + t.ecrit(3)
        Label23.Text = t.oral(0) + " " + t.oral(1) + " " + t.oral(2)
        Label24.Text = t.facultative
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class