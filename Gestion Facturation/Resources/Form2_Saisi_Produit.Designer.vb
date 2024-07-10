<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_saisi_produit
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_ctg = New System.Windows.Forms.ComboBox()
        Me.z_des = New System.Windows.Forms.TextBox()
        Me.z_qt = New System.Windows.Forms.TextBox()
        Me.z_pu = New System.Windows.Forms.TextBox()
        Me.z_ref = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.l_rech = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.B_sup = New System.Windows.Forms.Button()
        Me.B_mod = New System.Windows.Forms.Button()
        Me.B_list = New System.Windows.Forms.Button()
        Me.B_anl = New System.Windows.Forms.Button()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.B_aj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(396, 189)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(634, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saisi/Consulter et mise à jour d'un Produit"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-2, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 212)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'l_ctg
        '
        Me.l_ctg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_ctg.FormattingEnabled = True
        Me.l_ctg.Location = New System.Drawing.Point(422, 454)
        Me.l_ctg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_ctg.Name = "l_ctg"
        Me.l_ctg.Size = New System.Drawing.Size(379, 38)
        Me.l_ctg.TabIndex = 27
        '
        'z_des
        '
        Me.z_des.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_des.Location = New System.Drawing.Point(422, 369)
        Me.z_des.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_des.Name = "z_des"
        Me.z_des.Size = New System.Drawing.Size(379, 37)
        Me.z_des.TabIndex = 26
        '
        'z_qt
        '
        Me.z_qt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_qt.Location = New System.Drawing.Point(422, 609)
        Me.z_qt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_qt.Name = "z_qt"
        Me.z_qt.Size = New System.Drawing.Size(379, 37)
        Me.z_qt.TabIndex = 24
        '
        'z_pu
        '
        Me.z_pu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_pu.Location = New System.Drawing.Point(422, 528)
        Me.z_pu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_pu.Name = "z_pu"
        Me.z_pu.Size = New System.Drawing.Size(379, 37)
        Me.z_pu.TabIndex = 23
        '
        'z_ref
        '
        Me.z_ref.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ref.Location = New System.Drawing.Point(422, 294)
        Me.z_ref.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_ref.Name = "z_ref"
        Me.z_ref.Size = New System.Drawing.Size(228, 37)
        Me.z_ref.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(160, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 32)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Designation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(160, 454)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 32)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Catégorie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(160, 537)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 32)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Prix Unitaire"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(160, 617)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 32)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Quantité Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(160, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Référence Produit"
        '
        'l_rech
        '
        Me.l_rech.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_rech.FormattingEnabled = True
        Me.l_rech.Location = New System.Drawing.Point(832, 369)
        Me.l_rech.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_rech.Name = "l_rech"
        Me.l_rech.Size = New System.Drawing.Size(223, 38)
        Me.l_rech.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(824, 315)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 48)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Rechercher"
        '
        'B_sup
        '
        Me.B_sup.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_sup.Location = New System.Drawing.Point(36, 760)
        Me.B_sup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_sup.Name = "B_sup"
        Me.B_sup.Size = New System.Drawing.Size(276, 71)
        Me.B_sup.TabIndex = 36
        Me.B_sup.Text = "Supprimer"
        Me.B_sup.UseVisualStyleBackColor = True
        '
        'B_mod
        '
        Me.B_mod.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_mod.Location = New System.Drawing.Point(422, 680)
        Me.B_mod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_mod.Name = "B_mod"
        Me.B_mod.Size = New System.Drawing.Size(276, 71)
        Me.B_mod.TabIndex = 35
        Me.B_mod.Text = "Modifier"
        Me.B_mod.UseVisualStyleBackColor = True
        '
        'B_list
        '
        Me.B_list.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_list.Location = New System.Drawing.Point(818, 680)
        Me.B_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_list.Name = "B_list"
        Me.B_list.Size = New System.Drawing.Size(276, 71)
        Me.B_list.TabIndex = 34
        Me.B_list.Text = "Liste Produit"
        Me.B_list.UseVisualStyleBackColor = True
        '
        'B_anl
        '
        Me.B_anl.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_anl.Location = New System.Drawing.Point(422, 760)
        Me.B_anl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_anl.Name = "B_anl"
        Me.B_anl.Size = New System.Drawing.Size(276, 71)
        Me.B_anl.TabIndex = 33
        Me.B_anl.Text = "Annuler"
        Me.B_anl.UseVisualStyleBackColor = True
        '
        'B_fer
        '
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(818, 760)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(276, 71)
        Me.B_fer.TabIndex = 32
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = True
        '
        'B_aj
        '
        Me.B_aj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.B_aj.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_aj.Image = Global.WindowsApplication1.My.Resources.Resources.save_32
        Me.B_aj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_aj.Location = New System.Drawing.Point(36, 680)
        Me.B_aj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_aj.Name = "B_aj"
        Me.B_aj.Size = New System.Drawing.Size(276, 71)
        Me.B_aj.TabIndex = 31
        Me.B_aj.Text = "Ajouter"
        Me.B_aj.UseVisualStyleBackColor = True
        '
        'Form_saisi_produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1430, 1106)
        Me.Controls.Add(Me.B_sup)
        Me.Controls.Add(Me.B_mod)
        Me.Controls.Add(Me.B_list)
        Me.Controls.Add(Me.B_anl)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.B_aj)
        Me.Controls.Add(Me.l_rech)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.l_ctg)
        Me.Controls.Add(Me.z_des)
        Me.Controls.Add(Me.z_qt)
        Me.Controls.Add(Me.z_pu)
        Me.Controls.Add(Me.z_ref)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_saisi_produit"
        Me.Text = "Form_Saisi_produit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_ctg As System.Windows.Forms.ComboBox
    Friend WithEvents z_des As System.Windows.Forms.TextBox
    Friend WithEvents z_qt As System.Windows.Forms.TextBox
    Friend WithEvents z_pu As System.Windows.Forms.TextBox
    Friend WithEvents z_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents l_rech As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents B_sup As System.Windows.Forms.Button
    Friend WithEvents B_mod As System.Windows.Forms.Button
    Friend WithEvents B_list As System.Windows.Forms.Button
    Friend WithEvents B_anl As System.Windows.Forms.Button
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents B_aj As System.Windows.Forms.Button
End Class
