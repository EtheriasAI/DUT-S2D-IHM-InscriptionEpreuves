Public Class Bilanmatiere
    Private Sub Bilanmatiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Bilan.ComboBox1.Text
        Dim y As Integer = 0
        For Each x As Candidat In Acceuil.listcandi
            If x.ecrit(0) = Label2.Text Or x.ecrit(1) = Label2.Text Or x.ecrit(2) = Label2.Text Or
                x.ecrit(3) = Label2.Text Or x.oral(0) = Label2.Text Or x.oral(1) = Label2.Text Or
                x.oral(2) = Label2.Text Or x.facultative = Label2.Text Then
                ListView1.Items.Add(x.region)
                ListView1.Items(y).SubItems.Add(x.nom)
                ListView1.Items(y).SubItems.Add(x.prenom)
                y += 1
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class