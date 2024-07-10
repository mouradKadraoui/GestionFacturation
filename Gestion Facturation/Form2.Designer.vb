<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.diag_vente = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.diag_vente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'diag_vente
        '
        ChartArea1.Name = "ChartArea1"
        Me.diag_vente.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.diag_vente.Legends.Add(Legend1)
        Me.diag_vente.Location = New System.Drawing.Point(173, 66)
        Me.diag_vente.Name = "diag_vente"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Label = "#PERCENT{P}"
        Series1.Legend = "Legend1"
        Series1.Name = "vente"
        Me.diag_vente.Series.Add(Series1)
        Me.diag_vente.Size = New System.Drawing.Size(300, 300)
        Me.diag_vente.TabIndex = 0
        Me.diag_vente.Text = "Chart1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 423)
        Me.Controls.Add(Me.diag_vente)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.diag_vente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents diag_vente As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
