<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10_Saisi_Nouv_Fournisseur
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.B_sup = New System.Windows.Forms.Button()
        Me.B_mod = New System.Windows.Forms.Button()
        Me.B_list = New System.Windows.Forms.Button()
        Me.B_anl = New System.Windows.Forms.Button()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.B_aj = New System.Windows.Forms.Button()
        Me.l_cat = New System.Windows.Forms.ComboBox()
        Me.z_nmst = New System.Windows.Forms.TextBox()
        Me.z_tl = New System.Windows.Forms.TextBox()
        Me.z_vil = New System.Windows.Forms.TextBox()
        Me.z_ad = New System.Windows.Forms.TextBox()
        Me.z_rc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.l_rech = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.z_email = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(114, 572)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1188, 275)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'B_sup
        '
        Me.B_sup.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sup.Location = New System.Drawing.Point(24, 97)
        Me.B_sup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_sup.Name = "B_sup"
        Me.B_sup.Size = New System.Drawing.Size(312, 58)
        Me.B_sup.TabIndex = 27
        Me.B_sup.Text = "Supprimer"
        Me.B_sup.UseVisualStyleBackColor = True
        '
        'B_mod
        '
        Me.B_mod.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_mod.Location = New System.Drawing.Point(345, 29)
        Me.B_mod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_mod.Name = "B_mod"
        Me.B_mod.Size = New System.Drawing.Size(312, 58)
        Me.B_mod.TabIndex = 26
        Me.B_mod.Text = "Modifier"
        Me.B_mod.UseVisualStyleBackColor = True
        '
        'B_list
        '
        Me.B_list.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_list.Location = New System.Drawing.Point(666, 29)
        Me.B_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_list.Name = "B_list"
        Me.B_list.Size = New System.Drawing.Size(328, 58)
        Me.B_list.TabIndex = 25
        Me.B_list.Text = "Liste Fournisseur"
        Me.B_list.UseVisualStyleBackColor = True
        '
        'B_anl
        '
        Me.B_anl.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_anl.Location = New System.Drawing.Point(345, 97)
        Me.B_anl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_anl.Name = "B_anl"
        Me.B_anl.Size = New System.Drawing.Size(312, 58)
        Me.B_anl.TabIndex = 24
        Me.B_anl.Text = "Annuler"
        Me.B_anl.UseVisualStyleBackColor = True
        '
        'B_fer
        '
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(666, 97)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(328, 58)
        Me.B_fer.TabIndex = 23
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = True
        '
        'B_aj
        '
        Me.B_aj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_aj.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_aj.Image = Global.WindowsApplication1.My.Resources.Resources.save_32
        Me.B_aj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_aj.Location = New System.Drawing.Point(24, 29)
        Me.B_aj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_aj.Name = "B_aj"
        Me.B_aj.Size = New System.Drawing.Size(312, 58)
        Me.B_aj.TabIndex = 22
        Me.B_aj.Text = "Ajouter"
        Me.B_aj.UseVisualStyleBackColor = True
        '
        'l_cat
        '
        Me.l_cat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cat.FormattingEnabled = True
        Me.l_cat.Location = New System.Drawing.Point(531, 314)
        Me.l_cat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_cat.Name = "l_cat"
        Me.l_cat.Size = New System.Drawing.Size(379, 38)
        Me.l_cat.TabIndex = 36
        '
        'z_nmst
        '
        Me.z_nmst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_nmst.Location = New System.Drawing.Point(531, 268)
        Me.z_nmst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_nmst.Name = "z_nmst"
        Me.z_nmst.Size = New System.Drawing.Size(379, 37)
        Me.z_nmst.TabIndex = 35
        '
        'z_tl
        '
        Me.z_tl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tl.Location = New System.Drawing.Point(531, 471)
        Me.z_tl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tl.Name = "z_tl"
        Me.z_tl.Size = New System.Drawing.Size(379, 37)
        Me.z_tl.TabIndex = 34
        '
        'z_vil
        '
        Me.z_vil.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_vil.Location = New System.Drawing.Point(531, 420)
        Me.z_vil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_vil.Name = "z_vil"
        Me.z_vil.Size = New System.Drawing.Size(379, 37)
        Me.z_vil.TabIndex = 33
        '
        'z_ad
        '
        Me.z_ad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ad.Location = New System.Drawing.Point(531, 369)
        Me.z_ad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_ad.Name = "z_ad"
        Me.z_ad.Size = New System.Drawing.Size(379, 37)
        Me.z_ad.TabIndex = 32
        '
        'z_rc
        '
        Me.z_rc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rc.Location = New System.Drawing.Point(531, 226)
        Me.z_rc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rc.Name = "z_rc"
        Me.z_rc.Size = New System.Drawing.Size(228, 37)
        Me.z_rc.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(202, 268)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 32)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Nom Societé"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(202, 317)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 32)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Catégorie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(202, 377)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Adresse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(202, 428)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 32)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ville"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(202, 478)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Téléphone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(202, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Registre Commercial"
        '
        'l_rech
        '
        Me.l_rech.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_rech.FormattingEnabled = True
        Me.l_rech.Location = New System.Drawing.Point(936, 317)
        Me.l_rech.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_rech.Name = "l_rech"
        Me.l_rech.Size = New System.Drawing.Size(223, 38)
        Me.l_rech.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(927, 263)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 48)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Rechercher"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 212)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(450, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(699, 38)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Saisi/Consulter et mise à jour d'un Fournisseur"
        '
        'z_email
        '
        Me.z_email.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_email.Location = New System.Drawing.Point(531, 522)
        Me.z_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_email.Name = "z_email"
        Me.z_email.Size = New System.Drawing.Size(379, 37)
        Me.z_email.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(202, 525)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 32)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "E-mail"
        '
        'Form10_Saisi_Nouv_Fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1604, 1106)
        Me.Controls.Add(Me.z_email)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_rech)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.l_cat)
        Me.Controls.Add(Me.z_nmst)
        Me.Controls.Add(Me.z_tl)
        Me.Controls.Add(Me.z_vil)
        Me.Controls.Add(Me.z_ad)
        Me.Controls.Add(Me.z_rc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form10_Saisi_Nouv_Fournisseur"
        Me.Text = "Form10_Saisi_Nouv_Fournisseur"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents B_sup As System.Windows.Forms.Button
    Friend WithEvents B_mod As System.Windows.Forms.Button
    Friend WithEvents B_list As System.Windows.Forms.Button
    Friend WithEvents B_anl As System.Windows.Forms.Button
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents B_aj As System.Windows.Forms.Button
    Friend WithEvents l_cat As System.Windows.Forms.ComboBox
    Friend WithEvents z_nmst As System.Windows.Forms.TextBox
    Friend WithEvents z_tl As System.Windows.Forms.TextBox
    Friend WithEvents z_vil As System.Windows.Forms.TextBox
    Friend WithEvents z_ad As System.Windows.Forms.TextBox
    Friend WithEvents z_rc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents l_rech As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents z_email As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
