<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inscription1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxnom = New System.Windows.Forms.TextBox()
        Me.boxprenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxadresse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxville = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Page d'inscription 1/2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom :"
        '
        'boxnom
        '
        Me.boxnom.Location = New System.Drawing.Point(143, 127)
        Me.boxnom.MaxLength = 15
        Me.boxnom.Name = "boxnom"
        Me.boxnom.Size = New System.Drawing.Size(75, 22)
        Me.boxnom.TabIndex = 2
        '
        'boxprenom
        '
        Me.boxprenom.Location = New System.Drawing.Point(367, 127)
        Me.boxprenom.MaxLength = 20
        Me.boxprenom.Name = "boxprenom"
        Me.boxprenom.Size = New System.Drawing.Size(100, 22)
        Me.boxprenom.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenom :"
        '
        'boxadresse
        '
        Me.boxadresse.Location = New System.Drawing.Point(143, 217)
        Me.boxadresse.MaxLength = 30
        Me.boxadresse.Name = "boxadresse"
        Me.boxadresse.Size = New System.Drawing.Size(324, 22)
        Me.boxadresse.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Adresse :"
        '
        'boxcode
        '
        Me.boxcode.Location = New System.Drawing.Point(143, 270)
        Me.boxcode.MaxLength = 5
        Me.boxcode.Name = "boxcode"
        Me.boxcode.Size = New System.Drawing.Size(324, 22)
        Me.boxcode.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Code Postal :"
        '
        'boxville
        '
        Me.boxville.Location = New System.Drawing.Point(143, 317)
        Me.boxville.MaxLength = 15
        Me.boxville.Name = "boxville"
        Me.boxville.Size = New System.Drawing.Size(324, 22)
        Me.boxville.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ville :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Age :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 43)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Abandonner"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(358, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 43)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Continuer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(143, 175)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(260, 17)
        Me.HScrollBar1.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Label5"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(192, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Temps restants :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Label11"
        '
        'Inscription1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.boxville)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxcode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxadresse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxprenom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxnom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inscription1"
        Me.Text = "Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents boxnom As TextBox
    Friend WithEvents boxprenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents boxadresse As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents boxcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents boxville As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
