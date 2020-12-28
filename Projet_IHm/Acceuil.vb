Imports System.IO
Public Class Acceuil
    Public nbcandi As Integer
    Public listcandi = New List(Of Candidat)
    Public listepr = New List(Of String)
    Public listreg = New List(Of String)
    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nbcandi = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inscription1.Show()
        Me.Hide()
    End Sub
    Sub CreateCandidat(n As String, p As String, a As Integer, ad As String, c As Integer,
                       v As String, r As String, list As List(Of String))
        nbcandi += 1
        Dim t As Candidat
        t.numero = nbcandi
        t.nom = n
        t.prenom = p
        t.age = a
        t.adresse = ad
        t.code = c
        t.ville = v
        t.region = r
        t.ecrit = New List(Of String)
        t.ecrit.Add(list(0))
        t.ecrit.Add(list(1))
        t.ecrit.Add(list(2))
        t.ecrit.Add(list(3))
        t.oral = New List(Of String)
        t.oral.Add(list(4))
        t.oral.Add(list(5))
        t.oral.Add(list(6))
        t.facultative = list(7)
        listcandi.Add(t)
    End Sub
    Function getcandidat(n As Integer)
        Dim t As Candidat
        For Each Item As Candidat In listcandi
            If n = Item.numero Then
                t = Item
            End If
        Next
        Return t
    End Function
    Function getidentifiant(n As String)
        Dim t As Candidat
        For Each Item As Candidat In listcandi
            If n = Item.nom + " " + Item.prenom Then
                t = Item
            End If
        Next
        Return t
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modifier.Show()
        Me.Hide()
    End Sub

    Sub supprimer(t As Candidat)
        listcandi.remove(t)
    End Sub
    Sub modifiercandidat(t As Candidat)
        listcandi(t.numero - 1) = t
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        affichage.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Bilan.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        listepr.Add("Algorithmique")
        listepr.Add("Base de données")
        listepr.Add("Droit")
        listepr.Add("Expression")
        listepr.Add("Gestion")
        listepr.Add("Langage C")
        listepr.Add("Langage Java")
        listepr.Add("Mathématiques")
        listepr.Add("Programmation web")
        listepr.Add("Réseau")
        listepr.Add("Système")
        listepr.Add("Visual Basic .NET")

        listreg.Add("Auvergne")
        listreg.Add("Bordelais")
        listreg.Add("Bourgogne")
        listreg.Add("Bourgogne")
        listreg.Add("Corse")
        listreg.Add("Nord")
        listreg.Add("Normandie")
        listreg.Add("Paris")
        listreg.Add("Poitou")
        listreg.Add("Roussillon")

        For Each epr As String In listepr
            For Each reg As String In listreg

                Dim FILE_NAME As String = "C:\Users\Juju\Desktop\Projet_IHM\" + epr + " " + reg + ".txt"
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                For Each t As Candidat In listcandi
                    If t.region = reg Then
                        If t.ecrit(0) = epr Or t.ecrit(1) = epr Or t.ecrit(2) = epr Or
                            t.ecrit(3) = epr Or t.oral(0) = epr Or t.oral(1) = epr Or
                            t.oral(2) = epr Or t.facultative = epr Then
                            objWriter.Write(t.nom + " " + t.prenom + " " + t.numero.ToString)
                        End If
                    End If
                Next
                objWriter.Close()
            Next
        Next
        affichage.Close()
        Avantsuppresion.Close()
        Bilan.Close()
        BilanCandidat.Close()
        Bilanmatiere.Close()
        Inscription1.Close()
        Inscription2.Close()
        modification1.Close()
        modification2.Close()
        Modifier.Close()
        Recap.Close()
        Me.Close()
    End Sub
End Class