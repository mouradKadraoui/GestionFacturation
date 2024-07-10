<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5_Etat_Payement
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_an = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.nf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.an = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.z_av = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.z_rst = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.z_tot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.B_fer = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(554, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 114)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Etat Payement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 212)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'l_an
        '
        Me.l_an.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_an.FormattingEnabled = True
        Me.l_an.Location = New System.Drawing.Point(556, 268)
        Me.l_an.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.l_an.Name = "l_an"
        Me.l_an.Size = New System.Drawing.Size(235, 38)
        Me.l_an.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(310, 268)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 32)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Pour l'année"
        '
        'grid
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nf, Me.dt, Me.AV, Me.mf, Me.an})
        Me.grid.Location = New System.Drawing.Point(9, 320)
        Me.grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 62
        Me.grid.Size = New System.Drawing.Size(1236, 192)
        Me.grid.TabIndex = 87
        '
        'nf
        '
        Me.nf.HeaderText = "Numéro Facture"
        Me.nf.MinimumWidth = 8
        Me.nf.Name = "nf"
        Me.nf.Width = 200
        '
        'dt
        '
        Me.dt.HeaderText = "Date Facture"
        Me.dt.MinimumWidth = 8
        Me.dt.Name = "dt"
        Me.dt.Width = 200
        '
        'AV
        '
        Me.AV.HeaderText = "Avance"
        Me.AV.MinimumWidth = 8
        Me.AV.Name = "AV"
        Me.AV.Width = 180
        '
        'mf
        '
        Me.mf.HeaderText = "Montant Facture"
        Me.mf.MinimumWidth = 8
        Me.mf.Name = "mf"
        Me.mf.Width = 200
        '
        'an
        '
        Me.an.HeaderText = "année"
        Me.an.MinimumWidth = 8
        Me.an.Name = "an"
        Me.an.Width = 150
        '
        'z_av
        '
        Me.z_av.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_av.Location = New System.Drawing.Point(560, 562)
        Me.z_av.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_av.Name = "z_av"
        Me.z_av.Size = New System.Drawing.Size(176, 37)
        Me.z_av.TabIndex = 95
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(385, 570)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 32)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "TotalAvance"
        '
        'z_rst
        '
        Me.z_rst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rst.Location = New System.Drawing.Point(926, 558)
        Me.z_rst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rst.Name = "z_rst"
        Me.z_rst.Size = New System.Drawing.Size(130, 37)
        Me.z_rst.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(763, 565)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 32)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Total Reste"
        '
        'z_tot
        '
        Me.z_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tot.Location = New System.Drawing.Point(220, 565)
        Me.z_tot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tot.Name = "z_tot"
        Me.z_tot.Size = New System.Drawing.Size(150, 37)
        Me.z_tot.TabIndex = 98
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(20, 573)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(190, 32)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Total Montant"
        '
        'B_fer
        '
        Me.B_fer.BackColor = System.Drawing.Color.Lavender
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(427, 638)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(282, 58)
        Me.B_fer.TabIndex = 106
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = False
        '
        'Form5_Etat_Payement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1641, 857)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.z_tot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.z_av)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.z_rst)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_an)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form5_Etat_Payement"
        Me.Text = "Form1"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_an As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents z_av As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents z_rst As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents z_tot As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents nf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents an As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
