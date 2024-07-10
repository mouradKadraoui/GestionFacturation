<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_nouvl_Facture
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
        Me.l_cin = New System.Windows.Forms.ComboBox()
        Me.z_des = New System.Windows.Forms.TextBox()
        Me.z_nfct = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_ctg = New System.Windows.Forms.ComboBox()
        Me.z_ad = New System.Windows.Forms.TextBox()
        Me.z_np = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.l_ref = New System.Windows.Forms.ComboBox()
        Me.z_rst = New System.Windows.Forms.TextBox()
        Me.z_pu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.l_mp = New System.Windows.Forms.ComboBox()
        Me.z_av = New System.Windows.Forms.TextBox()
        Me.z_qtv = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.ctg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.z_tot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.z_rm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.z_ntc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.z_tva = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.B_nf = New System.Windows.Forms.Button()
        Me.B_ef = New System.Windows.Forms.Button()
        Me.B_af = New System.Windows.Forms.Button()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.z_tcc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.R_ok = New System.Windows.Forms.RadioButton()
        Me.R_no = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.z_dat = New System.Windows.Forms.TextBox()
        Me.z_qsk = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_cin
        '
        Me.l_cin.BackColor = System.Drawing.Color.White
        Me.l_cin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cin.FormattingEnabled = True
        Me.l_cin.Location = New System.Drawing.Point(562, 151)
        Me.l_cin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_cin.Name = "l_cin"
        Me.l_cin.Size = New System.Drawing.Size(136, 38)
        Me.l_cin.TabIndex = 33
        '
        'z_des
        '
        Me.z_des.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_des.Location = New System.Drawing.Point(382, 329)
        Me.z_des.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_des.Name = "z_des"
        Me.z_des.Size = New System.Drawing.Size(182, 37)
        Me.z_des.TabIndex = 32
        '
        'z_nfct
        '
        Me.z_nfct.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_nfct.Location = New System.Drawing.Point(158, 158)
        Me.z_nfct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_nfct.Name = "z_nfct"
        Me.z_nfct.Size = New System.Drawing.Size(210, 37)
        Me.z_nfct.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(398, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 34)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cin Client"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(-3, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 26)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "N° Facture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(376, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 26)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Designation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(615, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(427, 38)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Saisi d'une nouvelle Facture" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, -5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 151)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'l_ctg
        '
        Me.l_ctg.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_ctg.FormattingEnabled = True
        Me.l_ctg.Location = New System.Drawing.Point(9, 332)
        Me.l_ctg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_ctg.Name = "l_ctg"
        Me.l_ctg.Size = New System.Drawing.Size(184, 38)
        Me.l_ctg.TabIndex = 41
        '
        'z_ad
        '
        Me.z_ad.BackColor = System.Drawing.Color.White
        Me.z_ad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ad.Location = New System.Drawing.Point(562, 234)
        Me.z_ad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_ad.Name = "z_ad"
        Me.z_ad.Size = New System.Drawing.Size(136, 37)
        Me.z_ad.TabIndex = 40
        '
        'z_np
        '
        Me.z_np.BackColor = System.Drawing.Color.White
        Me.z_np.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_np.Location = New System.Drawing.Point(562, 191)
        Me.z_np.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_np.Name = "z_np"
        Me.z_np.Size = New System.Drawing.Size(136, 37)
        Me.z_np.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Catégorie"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(399, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 34)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nom & Prénom"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(399, 234)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 34)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Adresse"
        '
        'l_ref
        '
        Me.l_ref.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_ref.FormattingEnabled = True
        Me.l_ref.Location = New System.Drawing.Point(222, 332)
        Me.l_ref.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_ref.Name = "l_ref"
        Me.l_ref.Size = New System.Drawing.Size(132, 38)
        Me.l_ref.TabIndex = 47
        '
        'z_rst
        '
        Me.z_rst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rst.Location = New System.Drawing.Point(831, 760)
        Me.z_rst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rst.Name = "z_rst"
        Me.z_rst.Size = New System.Drawing.Size(276, 37)
        Me.z_rst.TabIndex = 46
        '
        'z_pu
        '
        Me.z_pu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_pu.Location = New System.Drawing.Point(576, 329)
        Me.z_pu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_pu.Name = "z_pu"
        Me.z_pu.Size = New System.Drawing.Size(187, 37)
        Me.z_pu.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(216, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 26)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Référence"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(573, 291)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 26)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Prix Unitaire"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(831, 721)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 32)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Reste"
        '
        'l_mp
        '
        Me.l_mp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_mp.FormattingEnabled = True
        Me.l_mp.Location = New System.Drawing.Point(831, 569)
        Me.l_mp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_mp.Name = "l_mp"
        Me.l_mp.Size = New System.Drawing.Size(276, 38)
        Me.l_mp.TabIndex = 53
        '
        'z_av
        '
        Me.z_av.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_av.Location = New System.Drawing.Point(831, 669)
        Me.z_av.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_av.Name = "z_av"
        Me.z_av.Size = New System.Drawing.Size(276, 37)
        Me.z_av.TabIndex = 52
        '
        'z_qtv
        '
        Me.z_qtv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_qtv.Location = New System.Drawing.Point(784, 329)
        Me.z_qtv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_qtv.Name = "z_qtv"
        Me.z_qtv.Size = New System.Drawing.Size(163, 37)
        Me.z_qtv.TabIndex = 51
        Me.z_qtv.Text = "0"
        Me.z_qtv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(825, 530)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(250, 32)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Mode de Payement"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(778, 283)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(185, 26)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Quantité Vendue"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(825, 627)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(277, 32)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Réglement ou Avance"
        '
        'grid
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctg, Me.ref, Me.des, Me.pu, Me.qv, Me.tot})
        Me.grid.Location = New System.Drawing.Point(9, 385)
        Me.grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 62
        Me.grid.Size = New System.Drawing.Size(1041, 115)
        Me.grid.TabIndex = 54
        '
        'ctg
        '
        Me.ctg.HeaderText = "Catégorie"
        Me.ctg.MinimumWidth = 8
        Me.ctg.Name = "ctg"
        Me.ctg.Width = 125
        '
        'ref
        '
        Me.ref.HeaderText = "Réference "
        Me.ref.MinimumWidth = 8
        Me.ref.Name = "ref"
        Me.ref.Width = 140
        '
        'des
        '
        Me.des.HeaderText = "Designation"
        Me.des.MinimumWidth = 8
        Me.des.Name = "des"
        Me.des.Width = 150
        '
        'pu
        '
        Me.pu.HeaderText = "Prix Unitaire"
        Me.pu.MinimumWidth = 8
        Me.pu.Name = "pu"
        Me.pu.Width = 150
        '
        'qv
        '
        Me.qv.HeaderText = "Quantité Vendue"
        Me.qv.MinimumWidth = 8
        Me.qv.Name = "qv"
        Me.qv.Width = 160
        '
        'tot
        '
        Me.tot.HeaderText = "Total"
        Me.tot.MinimumWidth = 8
        Me.tot.Name = "tot"
        Me.tot.Width = 130
        '
        'z_tot
        '
        Me.z_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tot.Location = New System.Drawing.Point(522, 525)
        Me.z_tot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tot.Name = "z_tot"
        Me.z_tot.Size = New System.Drawing.Size(134, 37)
        Me.z_tot.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(345, 528)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 26)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Total"
        '
        'z_rm
        '
        Me.z_rm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rm.Location = New System.Drawing.Point(522, 579)
        Me.z_rm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rm.Name = "z_rm"
        Me.z_rm.Size = New System.Drawing.Size(134, 37)
        Me.z_rm.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(345, 585)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 26)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Remise"
        '
        'z_ntc
        '
        Me.z_ntc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_ntc.Location = New System.Drawing.Point(522, 626)
        Me.z_ntc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_ntc.Name = "z_ntc"
        Me.z_ntc.Size = New System.Drawing.Size(134, 37)
        Me.z_ntc.TabIndex = 62
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(343, 633)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(180, 26)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Net Commercial"
        '
        'z_tva
        '
        Me.z_tva.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tva.Location = New System.Drawing.Point(523, 674)
        Me.z_tva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tva.Name = "z_tva"
        Me.z_tva.Size = New System.Drawing.Size(134, 37)
        Me.z_tva.TabIndex = 60
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(342, 680)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 26)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Montant TVA"
        '
        'B_nf
        '
        Me.B_nf.BackColor = System.Drawing.Color.Lavender
        Me.B_nf.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_nf.Location = New System.Drawing.Point(4, 519)
        Me.B_nf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_nf.Name = "B_nf"
        Me.B_nf.Size = New System.Drawing.Size(312, 52)
        Me.B_nf.TabIndex = 63
        Me.B_nf.Text = "Nouvelle Facture"
        Me.B_nf.UseVisualStyleBackColor = False
        '
        'B_ef
        '
        Me.B_ef.BackColor = System.Drawing.Color.Lavender
        Me.B_ef.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_ef.Location = New System.Drawing.Point(4, 591)
        Me.B_ef.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_ef.Name = "B_ef"
        Me.B_ef.Size = New System.Drawing.Size(312, 52)
        Me.B_ef.TabIndex = 64
        Me.B_ef.Text = "Enregistrer Facture"
        Me.B_ef.UseVisualStyleBackColor = False
        '
        'B_af
        '
        Me.B_af.BackColor = System.Drawing.Color.Lavender
        Me.B_af.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_af.Location = New System.Drawing.Point(4, 665)
        Me.B_af.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_af.Name = "B_af"
        Me.B_af.Size = New System.Drawing.Size(312, 52)
        Me.B_af.TabIndex = 65
        Me.B_af.Text = "Annuler Facture"
        Me.B_af.UseVisualStyleBackColor = False
        '
        'B_fer
        '
        Me.B_fer.BackColor = System.Drawing.Color.Lavender
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(2, 733)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(312, 52)
        Me.B_fer.TabIndex = 66
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = False
        '
        'z_tcc
        '
        Me.z_tcc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tcc.Location = New System.Drawing.Point(523, 719)
        Me.z_tcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tcc.Name = "z_tcc"
        Me.z_tcc.Size = New System.Drawing.Size(134, 37)
        Me.z_tcc.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(339, 726)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(156, 26)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Montant TCC"
        '
        'R_ok
        '
        Me.R_ok.AutoSize = True
        Me.R_ok.Location = New System.Drawing.Point(731, 637)
        Me.R_ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_ok.Name = "R_ok"
        Me.R_ok.Size = New System.Drawing.Size(58, 24)
        Me.R_ok.TabIndex = 69
        Me.R_ok.TabStop = True
        Me.R_ok.Text = "Oui"
        Me.R_ok.UseVisualStyleBackColor = True
        '
        'R_no
        '
        Me.R_no.AutoSize = True
        Me.R_no.Location = New System.Drawing.Point(731, 690)
        Me.R_no.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.R_no.Name = "R_no"
        Me.R_no.Size = New System.Drawing.Size(63, 24)
        Me.R_no.TabIndex = 70
        Me.R_no.TabStop = True
        Me.R_no.Text = "Non"
        Me.R_no.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(697, 575)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 32)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "Réglé"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(-3, 209)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 26)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Date Facture"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(958, 322)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 49)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'z_dat
        '
        Me.z_dat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_dat.Location = New System.Drawing.Point(158, 209)
        Me.z_dat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_dat.Name = "z_dat"
        Me.z_dat.Size = New System.Drawing.Size(210, 37)
        Me.z_dat.TabIndex = 75
        '
        'z_qsk
        '
        Me.z_qsk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_qsk.Location = New System.Drawing.Point(523, 766)
        Me.z_qsk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_qsk.Name = "z_qsk"
        Me.z_qsk.Size = New System.Drawing.Size(139, 37)
        Me.z_qsk.TabIndex = 81
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(342, 769)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(150, 26)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Quntité stock"
        '
        'Form3_nouvl_Facture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1557, 1106)
        Me.Controls.Add(Me.z_qsk)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.z_dat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.R_no)
        Me.Controls.Add(Me.R_ok)
        Me.Controls.Add(Me.z_tcc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.B_af)
        Me.Controls.Add(Me.B_ef)
        Me.Controls.Add(Me.B_nf)
        Me.Controls.Add(Me.z_ntc)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.z_tva)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.z_tot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.z_rm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.l_mp)
        Me.Controls.Add(Me.z_av)
        Me.Controls.Add(Me.z_qtv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.l_ref)
        Me.Controls.Add(Me.z_rst)
        Me.Controls.Add(Me.z_pu)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.l_ctg)
        Me.Controls.Add(Me.z_ad)
        Me.Controls.Add(Me.z_np)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_cin)
        Me.Controls.Add(Me.z_des)
        Me.Controls.Add(Me.z_nfct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form3_nouvl_Facture"
        Me.Text = "Form3_Nouvelle_Facture"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_cin As System.Windows.Forms.ComboBox
    Friend WithEvents z_des As System.Windows.Forms.TextBox
    Friend WithEvents z_nfct As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_ctg As System.Windows.Forms.ComboBox
    Friend WithEvents z_ad As System.Windows.Forms.TextBox
    Friend WithEvents z_np As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents l_ref As System.Windows.Forms.ComboBox
    Friend WithEvents z_rst As System.Windows.Forms.TextBox
    Friend WithEvents z_pu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents l_mp As System.Windows.Forms.ComboBox
    Friend WithEvents z_av As System.Windows.Forms.TextBox
    Friend WithEvents z_qtv As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents z_tot As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents z_rm As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents z_ntc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents z_tva As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents B_nf As System.Windows.Forms.Button
    Friend WithEvents B_ef As System.Windows.Forms.Button
    Friend WithEvents B_af As System.Windows.Forms.Button
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents z_tcc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents R_ok As System.Windows.Forms.RadioButton
    Friend WithEvents R_no As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ctg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents z_dat As System.Windows.Forms.TextBox
    Friend WithEvents z_qsk As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
