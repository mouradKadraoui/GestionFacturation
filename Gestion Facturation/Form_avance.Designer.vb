<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_avance
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
        Me.z_av = New System.Windows.Forms.TextBox()
        Me.z_dt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.z_nf = New System.Windows.Forms.TextBox()
        Me.B_ajout = New System.Windows.Forms.Button()
        Me.l_mp = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'z_av
        '
        Me.z_av.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_av.Location = New System.Drawing.Point(704, 380)
        Me.z_av.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_av.Name = "z_av"
        Me.z_av.Size = New System.Drawing.Size(379, 37)
        Me.z_av.TabIndex = 43
        '
        'z_dt
        '
        Me.z_dt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_dt.Location = New System.Drawing.Point(704, 460)
        Me.z_dt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_dt.Name = "z_dt"
        Me.z_dt.Size = New System.Drawing.Size(379, 37)
        Me.z_dt.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(375, 380)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 32)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Avance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(375, 468)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 32)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Date Avance"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 212)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(375, 302)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 32)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Numéro Facture"
        '
        'B_fer
        '
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(688, 737)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(312, 80)
        Me.B_fer.TabIndex = 48
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = True
        '
        'z_nf
        '
        Me.z_nf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_nf.Location = New System.Drawing.Point(704, 294)
        Me.z_nf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_nf.Name = "z_nf"
        Me.z_nf.Size = New System.Drawing.Size(379, 37)
        Me.z_nf.TabIndex = 49
        '
        'B_ajout
        '
        Me.B_ajout.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_ajout.Location = New System.Drawing.Point(270, 737)
        Me.B_ajout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_ajout.Name = "B_ajout"
        Me.B_ajout.Size = New System.Drawing.Size(312, 80)
        Me.B_ajout.TabIndex = 50
        Me.B_ajout.Text = "Ajouter"
        Me.B_ajout.UseVisualStyleBackColor = True
        '
        'l_mp
        '
        Me.l_mp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_mp.FormattingEnabled = True
        Me.l_mp.Location = New System.Drawing.Point(704, 555)
        Me.l_mp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_mp.Name = "l_mp"
        Me.l_mp.Size = New System.Drawing.Size(379, 38)
        Me.l_mp.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(388, 558)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(250, 32)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Mode de Payement"
        '
        'Form_avance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 868)
        Me.Controls.Add(Me.l_mp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.B_ajout)
        Me.Controls.Add(Me.z_nf)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.z_av)
        Me.Controls.Add(Me.z_dt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_avance"
        Me.Text = "Form_avance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents z_av As System.Windows.Forms.TextBox
    Friend WithEvents z_dt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents z_nf As System.Windows.Forms.TextBox
    Friend WithEvents B_ajout As System.Windows.Forms.Button
    Friend WithEvents l_mp As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
