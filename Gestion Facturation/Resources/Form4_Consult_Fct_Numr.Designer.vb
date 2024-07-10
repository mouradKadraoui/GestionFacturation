<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_Consult_Fct_Numr
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.z_np = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_nfct = New System.Windows.Forms.ComboBox()
        Me.z_cin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.R_no = New System.Windows.Forms.RadioButton()
        Me.R_ok = New System.Windows.Forms.RadioButton()
        Me.z_tcc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.B_maj = New System.Windows.Forms.Button()
        Me.z_ntc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.z_tva = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.z_tot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.z_rm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.z_av = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.z_rst = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.z_dtf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.z_mp = New System.Windows.Forms.TextBox()
        Me.cmdmodifier = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(286, 234)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(174, 32)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Date Facture"
        '
        'z_np
        '
        Me.z_np.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_np.Location = New System.Drawing.Point(548, 332)
        Me.z_np.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_np.Name = "z_np"
        Me.z_np.Size = New System.Drawing.Size(379, 37)
        Me.z_np.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(286, 342)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 32)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Nom & Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(498, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 76)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Consulter Facture par Numéro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-2, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 171)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'l_nfct
        '
        Me.l_nfct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_nfct.FormattingEnabled = True
        Me.l_nfct.Location = New System.Drawing.Point(548, 178)
        Me.l_nfct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_nfct.Name = "l_nfct"
        Me.l_nfct.Size = New System.Drawing.Size(379, 38)
        Me.l_nfct.TabIndex = 77
        '
        'z_cin
        '
        Me.z_cin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_cin.Location = New System.Drawing.Point(548, 282)
        Me.z_cin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_cin.Name = "z_cin"
        Me.z_cin.Size = New System.Drawing.Size(379, 37)
        Me.z_cin.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(285, 182)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 32)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "N° Facture"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(286, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 32)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "CIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(794, 605)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 32)
        Me.Label20.TabIndex = 109
        Me.Label20.Text = "Réglé"
        '
        'R_no
        '
        Me.R_no.AutoSize = True
        Me.R_no.Location = New System.Drawing.Point(812, 724)
        Me.R_no.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_no.Name = "R_no"
        Me.R_no.Size = New System.Drawing.Size(63, 24)
        Me.R_no.TabIndex = 108
        Me.R_no.TabStop = True
        Me.R_no.Text = "Non"
        Me.R_no.UseVisualStyleBackColor = True
        '
        'R_ok
        '
        Me.R_ok.AutoSize = True
        Me.R_ok.Location = New System.Drawing.Point(812, 667)
        Me.R_ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_ok.Name = "R_ok"
        Me.R_ok.Size = New System.Drawing.Size(58, 24)
        Me.R_ok.TabIndex = 107
        Me.R_ok.TabStop = True
        Me.R_ok.Text = "Oui"
        Me.R_ok.UseVisualStyleBackColor = True
        '
        'z_tcc
        '
        Me.z_tcc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tcc.Location = New System.Drawing.Point(551, 748)
        Me.z_tcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tcc.Name = "z_tcc"
        Me.z_tcc.Size = New System.Drawing.Size(232, 37)
        Me.z_tcc.TabIndex = 106
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(327, 748)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(156, 26)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Montant TCC"
        '
        'B_fer
        '
        Me.B_fer.BackColor = System.Drawing.Color.Lavender
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(43, 624)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(248, 52)
        Me.B_fer.TabIndex = 104
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = False
        '
        'B_maj
        '
        Me.B_maj.BackColor = System.Drawing.Color.Lavender
        Me.B_maj.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_maj.Location = New System.Drawing.Point(43, 545)
        Me.B_maj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_maj.Name = "B_maj"
        Me.B_maj.Size = New System.Drawing.Size(248, 52)
        Me.B_maj.TabIndex = 102
        Me.B_maj.Text = "Mise à Jour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.B_maj.UseVisualStyleBackColor = False
        '
        'z_ntc
        '
        Me.z_ntc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ntc.Location = New System.Drawing.Point(551, 647)
        Me.z_ntc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_ntc.Name = "z_ntc"
        Me.z_ntc.Size = New System.Drawing.Size(232, 37)
        Me.z_ntc.TabIndex = 100
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(326, 647)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(180, 26)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Net Commercial"
        '
        'z_tva
        '
        Me.z_tva.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tva.Location = New System.Drawing.Point(551, 698)
        Me.z_tva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tva.Name = "z_tva"
        Me.z_tva.Size = New System.Drawing.Size(232, 37)
        Me.z_tva.TabIndex = 98
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(327, 698)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 26)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "Montant TVA"
        '
        'z_tot
        '
        Me.z_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tot.Location = New System.Drawing.Point(551, 552)
        Me.z_tot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tot.Name = "z_tot"
        Me.z_tot.Size = New System.Drawing.Size(232, 37)
        Me.z_tot.TabIndex = 96
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(327, 548)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 26)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Total"
        '
        'z_rm
        '
        Me.z_rm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rm.Location = New System.Drawing.Point(551, 602)
        Me.z_rm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rm.Name = "z_rm"
        Me.z_rm.Size = New System.Drawing.Size(232, 37)
        Me.z_rm.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(327, 602)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 26)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "Remise"
        '
        'z_av
        '
        Me.z_av.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_av.Location = New System.Drawing.Point(903, 658)
        Me.z_av.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_av.Name = "z_av"
        Me.z_av.Size = New System.Drawing.Size(270, 37)
        Me.z_av.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(897, 535)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 26)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Mode de Payement"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(897, 619)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(230, 26)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Réglement ou Avance"
        '
        'z_rst
        '
        Me.z_rst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rst.Location = New System.Drawing.Point(897, 741)
        Me.z_rst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rst.Name = "z_rst"
        Me.z_rst.Size = New System.Drawing.Size(230, 37)
        Me.z_rst.TabIndex = 88
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(897, 702)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 26)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Reste"
        '
        'tot
        '
        Me.tot.HeaderText = "Total"
        Me.tot.MinimumWidth = 8
        Me.tot.Name = "tot"
        Me.tot.Width = 130
        '
        'qv
        '
        Me.qv.HeaderText = "Quantité Vendue"
        Me.qv.MinimumWidth = 8
        Me.qv.Name = "qv"
        Me.qv.Width = 160
        '
        'pu
        '
        Me.pu.HeaderText = "Prix Unitaire"
        Me.pu.MinimumWidth = 8
        Me.pu.Name = "pu"
        Me.pu.Width = 150
        '
        'des
        '
        Me.des.HeaderText = "Designation"
        Me.des.MinimumWidth = 8
        Me.des.Name = "des"
        Me.des.Width = 150
        '
        'ref
        '
        Me.ref.HeaderText = "Réference "
        Me.ref.MinimumWidth = 8
        Me.ref.Name = "ref"
        Me.ref.Width = 140
        '
        'ctg
        '
        Me.ctg.HeaderText = "Catégorie"
        Me.ctg.MinimumWidth = 8
        Me.ctg.Name = "ctg"
        Me.ctg.Width = 125
        '
        'grid
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctg, Me.ref, Me.des, Me.pu, Me.qv, Me.tot})
        Me.grid.Location = New System.Drawing.Point(4, 386)
        Me.grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 62
        Me.grid.Size = New System.Drawing.Size(1350, 135)
        Me.grid.TabIndex = 86
        '
        'z_dtf
        '
        Me.z_dtf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_dtf.Location = New System.Drawing.Point(548, 231)
        Me.z_dtf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_dtf.Name = "z_dtf"
        Me.z_dtf.Size = New System.Drawing.Size(379, 37)
        Me.z_dtf.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(50, 348)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 32)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Détail Facture"
        '
        'z_mp
        '
        Me.z_mp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_mp.Location = New System.Drawing.Point(903, 573)
        Me.z_mp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_mp.Name = "z_mp"
        Me.z_mp.Size = New System.Drawing.Size(241, 37)
        Me.z_mp.TabIndex = 112
        '
        'cmdmodifier
        '
        Me.cmdmodifier.BackColor = System.Drawing.Color.Lavender
        Me.cmdmodifier.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmodifier.Location = New System.Drawing.Point(43, 702)
        Me.cmdmodifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdmodifier.Name = "cmdmodifier"
        Me.cmdmodifier.Size = New System.Drawing.Size(248, 52)
        Me.cmdmodifier.TabIndex = 113
        Me.cmdmodifier.Text = "Modifier"
        Me.cmdmodifier.UseVisualStyleBackColor = False
        '
        'Form4_Consult_Fct_Numr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1371, 1075)
        Me.Controls.Add(Me.cmdmodifier)
        Me.Controls.Add(Me.z_mp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.z_dtf)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.R_no)
        Me.Controls.Add(Me.R_ok)
        Me.Controls.Add(Me.z_tcc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.B_maj)
        Me.Controls.Add(Me.z_ntc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.z_tva)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.z_tot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.z_rm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.z_av)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.z_rst)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.z_np)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_nfct)
        Me.Controls.Add(Me.z_cin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form4_Consult_Fct_Numr"
        Me.Text = "Form4_Consult_Fct_Numr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents z_np As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_nfct As System.Windows.Forms.ComboBox
    Friend WithEvents z_cin As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents R_no As System.Windows.Forms.RadioButton
    Friend WithEvents R_ok As System.Windows.Forms.RadioButton
    Friend WithEvents z_tcc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents B_maj As System.Windows.Forms.Button
    Friend WithEvents z_ntc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents z_tva As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents z_tot As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents z_rm As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents z_av As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents z_rst As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents z_dtf As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents z_mp As System.Windows.Forms.TextBox
    Friend WithEvents cmdmodifier As System.Windows.Forms.Button
End Class
