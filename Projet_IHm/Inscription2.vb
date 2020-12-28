Imports System.IO
Public Class Inscription2
    Public tps As Integer
    Public valE As Integer = 0
    Public valO As Integer = 0
    Public Const valmaxE As Integer = 4
    Public Const valmaxO As Integer = 3
    Public mylist As New List(Of String)
    Private Sub Inscription2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tps = 90
        ComboBox2.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        Label9.Text = tps
        Label3.Text = Inscription1.boxnom.Text
        Label5.Text = Inscription1.boxprenom.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Acceuil.Show()
        Inscription1.Close()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If valE < valmaxE Or valO < valmaxO Or ComboBox1.SelectedIndex = -1 Or
            (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
            Exit Sub
        End If
        If RadioButton1.Checked = True And ComboBox2.SelectedIndex = -1 Then
            Exit Sub
        End If

        Plusultra(CheckBox1)
        Plusultra(CheckBox2)
        Plusultra(CheckBox3)
        Plusultra(CheckBox4)
        Plusultra(CheckBox5)
        Plusultra(CheckBox6)
        Plusultra(CheckBox7)
        Plusultra(CheckBox8)
        Plusultra(CheckBox9)
        Plusultra(CheckBox10)
        Plusultra(CheckBox11)
        Plusultra(CheckBox12)
        Plusultra(CheckBox15)
        Plusultra(CheckBox13)
        Plusultra(CheckBox14)
        Plusultra(CheckBox17)
        Plusultra(CheckBox18)
        Plusultra(CheckBox16)
        Plusultra(CheckBox19)
        Plusultra(CheckBox20)
        Plusultra(CheckBox21)

        If RadioButton1.Checked = True Then
            mylist.Add(ComboBox2.Text)
        Else
            mylist.Add("Pas d'epreuve facultative")
        End If

        Recap.Show()
        Me.Hide()

    End Sub
    Sub Plusultra(x)
        If x.Checked = True Then
            mylist.Add(x.Text)
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label12.Text = DateTime.Now
        Label11.Text = valmaxE - valE
        Label15.Text = valmaxO - valO
        Label9.Text = tps

        tps -= 1
        If tps = 0 Then
            Timer1.Stop()
            Acceuil.Show()
            Me.Hide()
        End If
    End Sub
    Sub LockEcrit(x As CheckBox)
        If valE >= valmaxE And x.Checked = False Then
            x.Enabled = False
        End If
        If valE < valmaxE Then
            x.Enabled = True
        End If
    End Sub
    Sub Lockoral(x As CheckBox)
        If valO >= valmaxO And x.Checked = False Then
            x.Enabled = False
        End If
        If valO < valmaxO Then
            x.Enabled = True
        End If
    End Sub
    Sub Locktoutecrit()
        LockEcrit(CheckBox1)
        LockEcrit(CheckBox2)
        LockEcrit(CheckBox3)
        LockEcrit(CheckBox4)
        LockEcrit(CheckBox5)
        LockEcrit(CheckBox6)
        LockEcrit(CheckBox7)
        LockEcrit(CheckBox8)
        LockEcrit(CheckBox9)
        LockEcrit(CheckBox10)
        LockEcrit(CheckBox11)
        LockEcrit(CheckBox12)
    End Sub
    Sub LockToutOral()
        Lockoral(CheckBox15)
        Lockoral(CheckBox13)
        Lockoral(CheckBox14)
        Lockoral(CheckBox17)
        Lockoral(CheckBox18)
        Lockoral(CheckBox16)
        Lockoral(CheckBox19)
        Lockoral(CheckBox20)
        Lockoral(CheckBox21)
    End Sub
    Sub majvalE(x As CheckBox)
        If x.Checked = True Then
            valE += 1
        Else
            valE -= 1
        End If
    End Sub
    Sub majvalO(x As CheckBox)
        If x.Checked = True Then
            valO += 1
        Else
            valO -= 1
        End If
    End Sub
    Sub unlockradio()
        If (valE = valmaxE And valO = valmaxO) Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
        End If
    End Sub
    Function finddouble(x As CheckBox, y As Integer)
        If x.Text = CheckBox3.Text Then
            If y = 0 Then
                Return CheckBox13
            Else Return CheckBox3
            End If
        End If
        If x.Text = CheckBox4.Text Then
            If y = 0 Then
                Return CheckBox14
            Else Return CheckBox4
            End If
        End If
        If x.Text = CheckBox5.Text Then
            If y = 0 Then
                Return CheckBox15
            Else Return CheckBox5
            End If
        End If
        If x.Text = CheckBox10.Text Then
            If y = 0 Then
                Return CheckBox17
            Else Return CheckBox10
            End If
        End If
        If x.Text = CheckBox11.Text Then
            If y = 0 Then
                Return CheckBox18
            Else Return CheckBox11
            End If
        End If
        If x.Text = CheckBox8.Text Then
            If y = 0 Then
                Return CheckBox16
            Else Return CheckBox8
            End If
        End If
    End Function
    Sub cmpE(x As CheckBox)
        If x.Checked Then
            finddouble(x, 0).Enabled = False
        End If
        If x.Checked = False And valO < valmaxO Then
            finddouble(x, 0).Enabled = True
        End If
    End Sub
    Sub cmpO(x As CheckBox)
        If x.Checked Then
            finddouble(x, 1).Enabled = False
        End If
        If x.Checked = False And valE < valmaxE Then
            finddouble(x, 1).Enabled = True
        End If
    End Sub
    Sub lockdouble()
        cmpE(CheckBox3)
        cmpE(CheckBox4)
        cmpE(CheckBox5)
        cmpE(CheckBox10)
        cmpE(CheckBox11)
        cmpE(CheckBox8)

        cmpO(CheckBox13)
        cmpO(CheckBox14)
        cmpO(CheckBox15)
        cmpO(CheckBox17)
        cmpO(CheckBox18)
        cmpO(CheckBox16)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        majvalE(CheckBox1)
        allcheck()
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        majvalE(CheckBox2)
        allcheck()
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        majvalE(CheckBox3)
        allcheck()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        majvalE(CheckBox4)
        allcheck()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        majvalE(CheckBox5)
        allcheck()
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        majvalE(CheckBox6)
        allcheck()
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        majvalE(CheckBox7)
        allcheck()
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        majvalE(CheckBox8)
        allcheck()
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        majvalE(CheckBox9)
        allcheck()
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        majvalE(CheckBox10)
        allcheck()
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        majvalE(CheckBox11)
        allcheck()
    End Sub
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        majvalE(CheckBox12)
        allcheck()
    End Sub
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        majvalO(CheckBox15)
        allcheck()
    End Sub
    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        majvalO(CheckBox13)
        allcheck()
    End Sub
    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        majvalO(CheckBox14)
        allcheck()
    End Sub
    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        majvalO(CheckBox17)
        allcheck()
    End Sub
    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        majvalO(CheckBox18)
        allcheck()
    End Sub
    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        majvalO(CheckBox16)
        allcheck()
    End Sub
    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        majvalO(CheckBox19)
        allcheck()
    End Sub
    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        majvalO(CheckBox20)
        allcheck()
    End Sub
    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        majvalO(CheckBox21)
        allcheck()
    End Sub
    Sub allcheck()
        Locktoutecrit()
        LockToutOral()
        unlockradio()
        lockdouble()
        facultatif()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox2.Enabled = True
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
    Sub listefin(x As CheckBox)
        If x.Checked = False Then
            ComboBox2.Items.Add(x.Text)
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Enabled = False
    End Sub
    Sub listefindouble(x As CheckBox, y As CheckBox)
        If x.Checked = False And y.Checked = False Then
            ComboBox2.Items.Add(x.Text)
        End If
    End Sub
End Class