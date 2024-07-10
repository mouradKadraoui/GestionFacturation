<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Saisi_Client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.z_cin = New System.Windows.Forms.TextBox()
        Me.z_ad = New System.Windows.Forms.TextBox()
        Me.z_vil = New System.Windows.Forms.TextBox()
        Me.z_tl = New System.Windows.Forms.TextBox()
        Me.z_np = New System.Windows.Forms.TextBox()
        Me.l_prf = New System.Windows.Forms.ComboBox()
        Me.l_rech = New System.Windows.Forms.ComboBox()
        Me.B_aj = New System.Windows.Forms.Button()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.B_anl = New System.Windows.Forms.Button()
        Me.B_list = New System.Windows.Forms.Button()
        Me.B_mod = New System.Windows.Forms.Button()
        Me.B_sup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 138)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "                     Societe FL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " & _
            "      et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(333, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saisi/Consulter et mise à jour d'un Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ville"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(41, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Adresse"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(41, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Profession"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(41, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nom && Prénom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(540, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 32)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Rechercher"
        '
        'z_cin
        '
        Me.z_cin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_cin.Location = New System.Drawing.Point(215, 196)
        Me.z_cin.Name = "z_cin"
        Me.z_cin.Size = New System.Drawing.Size(153, 27)
        Me.z_cin.TabIndex = 10
        '
        'z_ad
        '
        Me.z_ad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ad.Location = New System.Drawing.Point(215, 296)
        Me.z_ad.Name = "z_ad"
        Me.z_ad.Size = New System.Drawing.Size(254, 27)
        Me.z_ad.TabIndex = 11
        '
        'z_vil
        '
        Me.z_vil.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_vil.Location = New System.Drawing.Point(215, 329)
        Me.z_vil.Name = "z_vil"
        Me.z_vil.Size = New System.Drawing.Size(254, 27)
        Me.z_vil.TabIndex = 12
        '
        'z_tl
        '
        Me.z_tl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tl.Location = New System.Drawing.Point(215, 362)
        Me.z_tl.Name = "z_tl"
        Me.z_tl.Size = New System.Drawing.Size(254, 27)
        Me.z_tl.TabIndex = 13
        '
        'z_np
        '
        Me.z_np.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_np.Location = New System.Drawing.Point(215, 229)
        Me.z_np.Name = "z_np"
        Me.z_np.Size = New System.Drawing.Size(254, 27)
        Me.z_np.TabIndex = 14
        '
        'l_prf
        '
        Me.l_prf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_prf.FormattingEnabled = True
        Me.l_prf.Location = New System.Drawing.Point(215, 262)
        Me.l_prf.Name = "l_prf"
        Me.l_prf.Size = New System.Drawing.Size(254, 28)
        Me.l_prf.TabIndex = 15
        '
        'l_rech
        '
        Me.l_rech.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_rech.FormattingEnabled = True
        Me.l_rech.Location = New System.Drawing.Point(534, 229)
        Me.l_rech.Name = "l_rech"
        Me.l_rech.Size = New System.Drawing.Size(150, 28)
        Me.l_rech.TabIndex = 16
        '
        'B_aj
        '
        Me.B_aj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_aj.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_aj.Image = Global.WindowsApplication1.My.Resources.Resources.save_32
        Me.B_aj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_aj.Location = New System.Drawing.Point(16, 19)
        Me.B_aj.Name = "B_aj"
        Me.B_aj.Size = New System.Drawing.Size(190, 41)
        Me.B_aj.TabIndex = 22
        Me.B_aj.Text = "Ajouter"
        Me.B_aj.UseVisualStyleBackColor = True
        '
        'B_fer
        '
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(450, 66)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(190, 41)
        Me.B_fer.TabIndex = 23
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = True
        '
        'B_anl
        '
        Me.B_anl.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_anl.Location = New System.Drawing.Point(231, 66)
        Me.B_anl.Name = "B_anl"
        Me.B_anl.Size = New System.Drawing.Size(190, 41)
        Me.B_anl.TabIndex = 24
        Me.B_anl.Text = "Annuler"
        Me.B_anl.UseVisualStyleBackColor = True
        '
        'B_list
        '
        Me.B_list.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_list.Location = New System.Drawing.Point(450, 19)
        Me.B_list.Name = "B_list"
        Me.B_list.Size = New System.Drawing.Size(190, 41)
        Me.B_list.TabIndex = 25
        Me.B_list.Text = "Liste Client"
        Me.B_list.UseVisualStyleBackColor = True
        '
        'B_mod
        '
        Me.B_mod.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_mod.Location = New System.Drawing.Point(231, 19)
        Me.B_mod.Name = "B_mod"
        Me.B_mod.Size = New System.Drawing.Size(190, 41)
        Me.B_mod.TabIndex = 26
        Me.B_mod.Text = "Modifier"
        Me.B_mod.UseVisualStyleBackColor = True
        '
        'B_sup
        '
        Me.B_sup.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sup.Location = New System.Drawing.Point(16, 66)
        Me.B_sup.Name = "B_sup"
        Me.B_sup.Size = New System.Drawing.Size(190, 41)
        Me.B_sup.TabIndex = 27
        Me.B_sup.Text = "Supprimer"
        Me.B_sup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.B_sup)
        Me.GroupBox1.Controls.Add(Me.B_mod)
        Me.GroupBox1.Controls.Add(Me.B_list)
        Me.GroupBox1.Controls.Add(Me.B_anl)
        Me.GroupBox1.Controls.Add(Me.B_fer)
        Me.GroupBox1.Controls.Add(Me.B_aj)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 117)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Form_Saisi_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 800)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.l_rech)
        Me.Controls.Add(Me.l_prf)
        Me.Controls.Add(Me.z_np)
        Me.Controls.Add(Me.z_tl)
        Me.Controls.Add(Me.z_vil)
        Me.Controls.Add(Me.z_ad)
        Me.Controls.Add(Me.z_cin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Saisi_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saisi Client"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents z_cin As System.Windows.Forms.TextBox
    Friend WithEvents z_ad As System.Windows.Forms.TextBox
    Friend WithEvents z_vil As System.Windows.Forms.TextBox
    Friend WithEvents z_tl As System.Windows.Forms.TextBox
    Friend WithEvents z_np As System.Windows.Forms.TextBox
    Friend WithEvents l_prf As System.Windows.Forms.ComboBox
    Friend WithEvents l_rech As System.Windows.Forms.ComboBox
    Friend WithEvents B_aj As System.Windows.Forms.Button
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents B_anl As System.Windows.Forms.Button
    Friend WithEvents B_list As System.Windows.Forms.Button
    Friend WithEvents B_mod As System.Windows.Forms.Button
    Friend WithEvents B_sup As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
