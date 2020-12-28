Public Class Avantsuppresion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim s As String = Modifier.ComboBox1.Text.Chars(0)
        If IsNumeric(s) = True Then
            i = CInt(s)
        End If
        Dim t As Candidat
        t = Acceuil.getcandidat(i)
        Label3.Text = t.numero
        Label5.Text = t.nom
        Label7.Text = t.prenom
        Label9.Text = t.age
        Label20.Text = t.adresse
        Label21.Text = t.code
        Label22.Text = t.ville
        Label23.Text = t.region
        Label17.Text = t.ecrit(0) + " " + t.ecrit(1) + "
" + t.ecrit(2) + " " + t.ecrit(3)
        Label18.Text = t.oral(0) + " " + t.oral(1) + " " + t.oral(2)
        Label19.Text = t.facultative

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Supprimer le candidat", "Confirmation demandee", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim t As Candidat
            t = Acceuil.getcandidat(Label3.Text)
            Acceuil.supprimer(t)
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class