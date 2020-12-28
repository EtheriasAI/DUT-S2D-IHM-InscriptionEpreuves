Public Class Modifier
    Private Sub Modifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As String
        For Each Item In Acceuil.listcandi
            t = Item.numero.ToString + " " + Item.nom + " " + Item.prenom
            ComboBox1.Items.Add(t)
        Next
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Avantsuppresion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modification1.Show()
    End Sub
End Class