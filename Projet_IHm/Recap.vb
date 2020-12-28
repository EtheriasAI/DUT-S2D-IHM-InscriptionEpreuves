Public Class Recap
    Private listiers As New List(Of String)
    Private Sub Recap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = Inscription1.boxnom.Text
        Label13.Text = Inscription1.boxprenom.Text
        Label14.Text = Inscription1.boxadresse.Text
        Label15.Text = Inscription1.boxville.Text
        Label16.Text = Inscription1.HScrollBar1.Value
        Label17.Text = Inscription1.boxcode.Text
        Label18.Text = Inscription2.ComboBox1.Text
        Label19.Text = Inscription2.mylist(0) + " " + Inscription2.mylist(1) + "
" + Inscription2.mylist(2) + " " + Inscription2.mylist(3)
        Label20.Text = Inscription2.mylist(4) + " " + Inscription2.mylist(5) + " " + Inscription2.mylist(6)
        Label21.Text = Inscription2.mylist(7)

        listiers = Inscription2.mylist

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.CreateCandidat(Inscription1.boxnom.Text, Inscription1.boxprenom.Text, Inscription1.HScrollBar1.Value,
                                Inscription1.boxadresse.Text, Inscription1.boxcode.Text, Inscription1.boxville.Text,
                                Inscription2.ComboBox1.Text, listiers)
        MsgBox("le numero de ce candidat est " + Acceuil.nbcandi.ToString)
        Acceuil.Show()
        Inscription1.Close()
        Inscription2.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inscription2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Acceuil.Show()
        Inscription1.Close()
        Inscription2.Close()
        Me.Close()
    End Sub
End Class