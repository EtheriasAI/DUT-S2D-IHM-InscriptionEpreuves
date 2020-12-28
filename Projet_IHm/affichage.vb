Public Class affichage
    Private Sub affichage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each x As Candidat In Acceuil.listcandi
            ListView1.Items.Add(x.numero)
            ListView1.Items(x.numero - 1).SubItems.Add(x.nom)
            ListView1.Items(x.numero - 1).SubItems.Add(x.prenom)
            ListView1.Items(x.numero - 1).SubItems.Add(change(x.ecrit(0)) + " " + change(x.ecrit(1)) + " " + change(x.ecrit(2)) + " " + change(x.ecrit(3)))
            ListView1.Items(x.numero - 1).SubItems.Add(change(x.oral(0)) + " " + change(x.oral(1)) + " " + change(x.oral(2)))
            ListView1.Items(x.numero - 1).SubItems.Add(change(x.facultative))
        Next
    End Sub
    Function change(x As String)
        If x = "Algorithme" Then
            Return "ALG"
        End If
        If x = "Base de données" Then
            Return "BDD"
        End If
        If x = "Droit" Then
            Return "DRT"
        End If
        If x = "Expression" Then
            Return "EXP"
        End If
        If x = "Gestion" Then
            Return "GST"
        End If
        If x = "Langage C" Then
            Return "LGC"
        End If
        If x = "Langage Java" Then
            Return "LGJ"
        End If
        If x = "Mathématiques" Then
            Return "MAT"
        End If
        If x = "Programmation web" Then
            Return "PGW"
        End If
        If x = "Réseau" Then
            Return "RES"
        End If
        If x = "Système" Then
            Return "SYS"
        End If
        If x = "Visual Basic .NET" Then
            Return "VBN"
        End If
        If x = "Anglais" Then
            Return "ANG"
        End If
        If x = "Chinois" Then
            Return "CHN"
        End If
        If x = "Espagnol" Then
            Return "ESP"
        End If
        If x = "Pas d'epreuve facultative" Then
            Return "-"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class