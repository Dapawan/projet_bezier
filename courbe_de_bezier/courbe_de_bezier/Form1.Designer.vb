<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bezier_drawing = New System.Windows.Forms.PictureBox()
        Me.NumericUpDownY = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownX = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.bezier_drawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bezier_drawing
        '
        Me.bezier_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bezier_drawing.Location = New System.Drawing.Point(22, 21)
        Me.bezier_drawing.Name = "bezier_drawing"
        Me.bezier_drawing.Size = New System.Drawing.Size(598, 304)
        Me.bezier_drawing.TabIndex = 0
        Me.bezier_drawing.TabStop = False
        '
        'NumericUpDownY
        '
        Me.NumericUpDownY.DecimalPlaces = 2
        Me.NumericUpDownY.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownY.Location = New System.Drawing.Point(165, 346)
        Me.NumericUpDownY.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownY.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDownY.Name = "NumericUpDownY"
        Me.NumericUpDownY.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownY.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x"
        '
        'NumericUpDownX
        '
        Me.NumericUpDownX.DecimalPlaces = 2
        Me.NumericUpDownX.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownX.Location = New System.Drawing.Point(22, 346)
        Me.NumericUpDownX.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownX.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDownX.Name = "NumericUpDownX"
        Me.NumericUpDownX.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownX.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "y"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownX)
        Me.Controls.Add(Me.NumericUpDownY)
        Me.Controls.Add(Me.bezier_drawing)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bezier_drawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bezier_drawing As PictureBox
    Friend WithEvents NumericUpDownY As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDownX As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
