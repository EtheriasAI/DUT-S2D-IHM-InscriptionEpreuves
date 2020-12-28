Public Class Bilan
    Private Sub Bilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As String
        For Each Item In Acceuil.listcandi
            t = Item.nom + " " + Item.prenom
            ComboBox2.Items.Add(t)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BilanCandidat.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Bilanmatiere.Show()
    End Sub
End Class