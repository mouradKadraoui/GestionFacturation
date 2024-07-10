<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6_Etat_Vent_Périod
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
        Me.z_tot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.z_av = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.z_rst = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.nf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B_fer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_du = New System.Windows.Forms.DateTimePicker()
        Me.t_au = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z_tot
        '
        Me.z_tot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_tot.Location = New System.Drawing.Point(220, 582)
        Me.z_tot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_tot.Name = "z_tot"
        Me.z_tot.Size = New System.Drawing.Size(150, 37)
        Me.z_tot.TabIndex = 104
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(21, 585)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(190, 32)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Total Montant"
        '
        'z_av
        '
        Me.z_av.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_av.Location = New System.Drawing.Point(556, 574)
        Me.z_av.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_av.Name = "z_av"
        Me.z_av.Size = New System.Drawing.Size(140, 37)
        Me.z_av.TabIndex = 102
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(381, 585)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 32)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "TotalAvance"
        '
        'z_rst
        '
        Me.z_rst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z_rst.Location = New System.Drawing.Point(886, 577)
        Me.z_rst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.z_rst.Name = "z_rst"
        Me.z_rst.Size = New System.Drawing.Size(138, 37)
        Me.z_rst.TabIndex = 100
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(723, 580)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 32)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Total Reste"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-2, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 212)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "                     Societe VPIBF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vente Produits Informatique Bureautique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "         et Fourniture de Bureaux" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                          N°175"
        '
        'grid
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nf, Me.dt, Me.cin, Me.AV, Me.mf})
        Me.grid.Location = New System.Drawing.Point(6, 314)
        Me.grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 62
        Me.grid.Size = New System.Drawing.Size(1386, 191)
        Me.grid.TabIndex = 106
        '
        'nf
        '
        Me.nf.HeaderText = "Numéro Facture"
        Me.nf.MinimumWidth = 8
        Me.nf.Name = "nf"
        Me.nf.Width = 170
        '
        'dt
        '
        Me.dt.HeaderText = "Date Facture"
        Me.dt.MinimumWidth = 8
        Me.dt.Name = "dt"
        Me.dt.Width = 200
        '
        'cin
        '
        Me.cin.HeaderText = "CIN Client"
        Me.cin.MinimumWidth = 8
        Me.cin.Name = "cin"
        Me.cin.Width = 130
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
        'B_fer
        '
        Me.B_fer.BackColor = System.Drawing.Color.Lavender
        Me.B_fer.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_fer.Location = New System.Drawing.Point(470, 651)
        Me.B_fer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B_fer.Name = "B_fer"
        Me.B_fer.Size = New System.Drawing.Size(230, 52)
        Me.B_fer.TabIndex = 108
        Me.B_fer.Text = "Fermer"
        Me.B_fer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(792, 252)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 49)
        Me.Button1.TabIndex = 109
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(54, 255)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 32)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Du :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(402, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 32)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Au :"
        '
        't_du
        '
        Me.t_du.CustomFormat = "MM/dd/yyyy"
        Me.t_du.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.t_du.Location = New System.Drawing.Point(129, 258)
        Me.t_du.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.t_du.Name = "t_du"
        Me.t_du.Size = New System.Drawing.Size(228, 26)
        Me.t_du.TabIndex = 113
        '
        't_au
        '
        Me.t_au.CustomFormat = "MM/dd/yyyy"
        Me.t_au.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.t_au.Location = New System.Drawing.Point(500, 258)
        Me.t_au.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.t_au.Name = "t_au"
        Me.t_au.Size = New System.Drawing.Size(228, 26)
        Me.t_au.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(448, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 76)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Etat de Ventes Périodiques" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form6_Etat_Vent_Périod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1760, 977)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_au)
        Me.Controls.Add(Me.t_du)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_fer)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.z_tot)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.z_av)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.z_rst)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form6_Etat_Vent_Périod"
        Me.Text = "Form6_Etat_Vent_Périod"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents z_tot As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents z_av As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents z_rst As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents B_fer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_du As System.Windows.Forms.DateTimePicker
    Friend WithEvents t_au As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
