Public Class modification2
    Dim t As Candidat
    Public valE As Integer = 0
    Public valO As Integer = 0
    Public Const valmaxE As Integer = 4
    Public Const valmaxO As Integer = 3
    Private Sub modification2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t = modification1.getcandidamodif()
        Label4.Text = t.nom
        Label5.Text = t.prenom
        ComboBox1.SelectedItem = t.region


        If t.facultative <> "Pas d'epreuve facultative" Then
            RadioButton1.Checked = True
            ComboBox2.SelectedItem = t.facultative
        Else
            RadioButton2.Checked = True
        End If
        Dim cpt As Integer = -9
        For Each x As CheckBox In Me.Controls.OfType(Of CheckBox)()
            For Each Item As String In t.ecrit
                If x.Text = Item And cpt >= 0 Then
                    x.Checked = True
                End If
            Next
            For Each Item As String In t.oral
                If x.Text = Item And cpt < 0 Then
                    x.Checked = True
                End If
            Next
            cpt += 1
        Next
        facultatif()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cpt As Integer = 0
        Dim nbE As Integer = 0
        Dim nbO As Integer = 0
        For Each x As CheckBox In Me.Controls.OfType(Of CheckBox)()
            If x.Checked = True Then
                If cpt >= 9 Then
                    nbE += 1
                End If
                If cpt < 9 Then
                    nbO += 1
                End If
            End If
            cpt += 1
        Next
        cpt = 0
        If nbO <> 3 Then
            MsgBox("Vous devez resélectionner 4 épreuves écrites et 3 épreuves orales")
            Exit Sub
        End If
        t.ecrit.Clear()
        t.oral.Clear()
        For Each x As CheckBox In Me.Controls.OfType(Of CheckBox)()
            If x.Checked = True Then
                If cpt > 9 Then
                    t.ecrit.Add(x.Text)
                End If
                If cpt <= 9 Then
                    t.oral.Add(x.Text)
                End If
            End If
            cpt += 1
        Next

        If RadioButton1.Checked = True Then
            t.facultative = ComboBox2.Text
        Else
            t.facultative = "Pas d'epreuve facultative"
        End If

        Acceuil.modifiercandidat(t)
        modification1.Close()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        modification1.Close()
        Me.Close()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox2.Enabled = True
        ComboBox2.Items.Clear()
        facultatif()
    End Sub
    Sub facultatif()
        ComboBox2.Items.Clear()
        listefin(CheckBox1)
        listefin(CheckBox2)
        listefindouble(CheckBox3, CheckBox13)
        listefindouble(CheckBox4, CheckBox14)
        listefindouble(CheckBox5, CheckBox15)
        listefin(CheckBox6)
        listefin(CheckBox7)
        listefindouble(CheckBox8, CheckBox16)
        listefin(CheckBox9)
        listefindouble(CheckBox10, CheckBox17)
        listefindouble(CheckBox11, CheckBox18)
        listefin(CheckBox12)
        listefin(CheckBox19)
        listefin(CheckBox20)
        listefin(CheckBox21)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Enabled = False
    End Sub

    Sub listefindouble(x As CheckBox, y As CheckBox)
        If x.Checked = False And y.Checked = False Then
            ComboBox2.Items.Add(x.Text)
        End If
    End Sub
    Sub listefin(x As CheckBox)
        If x.Checked = False Then
            ComboBox2.Items.Add(x.Text)
        End If
    End Sub
End Class