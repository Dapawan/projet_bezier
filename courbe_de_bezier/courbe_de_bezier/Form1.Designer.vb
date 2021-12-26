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
        Me.NumericUpDown_y_deb = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown_x_deb = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown_x_deb_tg = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_y_deb_tg = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown_segment = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_longueur = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown_y_fin = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_x_fin = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown_x_fin_tg = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_y_fin_tg = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxColor = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.bezier_drawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_y_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_x_deb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_x_deb_tg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_y_deb_tg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_segment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_longueur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_y_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_x_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_x_fin_tg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_y_fin_tg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bezier_drawing
        '
        Me.bezier_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bezier_drawing.Location = New System.Drawing.Point(22, 21)
        Me.bezier_drawing.Name = "bezier_drawing"
        Me.bezier_drawing.Size = New System.Drawing.Size(900, 600)
        Me.bezier_drawing.TabIndex = 0
        Me.bezier_drawing.TabStop = False
        '
        'NumericUpDown_y_deb
        '
        Me.NumericUpDown_y_deb.DecimalPlaces = 2
        Me.NumericUpDown_y_deb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_y_deb.Location = New System.Drawing.Point(1091, 114)
        Me.NumericUpDown_y_deb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_y_deb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_y_deb.Name = "NumericUpDown_y_deb"
        Me.NumericUpDown_y_deb.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_y_deb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(944, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x_deb"
        '
        'NumericUpDown_x_deb
        '
        Me.NumericUpDown_x_deb.DecimalPlaces = 2
        Me.NumericUpDown_x_deb.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_x_deb.Location = New System.Drawing.Point(947, 114)
        Me.NumericUpDown_x_deb.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_x_deb.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_x_deb.Name = "NumericUpDown_x_deb"
        Me.NumericUpDown_x_deb.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_x_deb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1088, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "y_deb"
        '
        'NumericUpDown_x_deb_tg
        '
        Me.NumericUpDown_x_deb_tg.DecimalPlaces = 2
        Me.NumericUpDown_x_deb_tg.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_x_deb_tg.Location = New System.Drawing.Point(947, 252)
        Me.NumericUpDown_x_deb_tg.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_x_deb_tg.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_x_deb_tg.Name = "NumericUpDown_x_deb_tg"
        Me.NumericUpDown_x_deb_tg.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_x_deb_tg.TabIndex = 1
        '
        'NumericUpDown_y_deb_tg
        '
        Me.NumericUpDown_y_deb_tg.DecimalPlaces = 2
        Me.NumericUpDown_y_deb_tg.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_y_deb_tg.Location = New System.Drawing.Point(1091, 252)
        Me.NumericUpDown_y_deb_tg.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_y_deb_tg.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_y_deb_tg.Name = "NumericUpDown_y_deb_tg"
        Me.NumericUpDown_y_deb_tg.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_y_deb_tg.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(944, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "x_deb_tg"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1088, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "y_deb_tg"
        '
        'NumericUpDown_segment
        '
        Me.NumericUpDown_segment.Location = New System.Drawing.Point(947, 454)
        Me.NumericUpDown_segment.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_segment.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_segment.Name = "NumericUpDown_segment"
        Me.NumericUpDown_segment.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_segment.TabIndex = 1
        Me.NumericUpDown_segment.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(944, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "nbr_segment"
        '
        'NumericUpDown_longueur
        '
        Me.NumericUpDown_longueur.DecimalPlaces = 3
        Me.NumericUpDown_longueur.Location = New System.Drawing.Point(1091, 454)
        Me.NumericUpDown_longueur.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown_longueur.Name = "NumericUpDown_longueur"
        Me.NumericUpDown_longueur.ReadOnly = True
        Me.NumericUpDown_longueur.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_longueur.TabIndex = 1
        Me.NumericUpDown_longueur.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1088, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "longueur"
        '
        'NumericUpDown_y_fin
        '
        Me.NumericUpDown_y_fin.DecimalPlaces = 2
        Me.NumericUpDown_y_fin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_y_fin.Location = New System.Drawing.Point(1091, 160)
        Me.NumericUpDown_y_fin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_y_fin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_y_fin.Name = "NumericUpDown_y_fin"
        Me.NumericUpDown_y_fin.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_y_fin.TabIndex = 1
        '
        'NumericUpDown_x_fin
        '
        Me.NumericUpDown_x_fin.DecimalPlaces = 2
        Me.NumericUpDown_x_fin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_x_fin.Location = New System.Drawing.Point(947, 160)
        Me.NumericUpDown_x_fin.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_x_fin.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_x_fin.Name = "NumericUpDown_x_fin"
        Me.NumericUpDown_x_fin.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_x_fin.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(944, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "x_fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1088, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "y_fin"
        '
        'NumericUpDown_x_fin_tg
        '
        Me.NumericUpDown_x_fin_tg.DecimalPlaces = 2
        Me.NumericUpDown_x_fin_tg.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_x_fin_tg.Location = New System.Drawing.Point(947, 305)
        Me.NumericUpDown_x_fin_tg.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_x_fin_tg.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_x_fin_tg.Name = "NumericUpDown_x_fin_tg"
        Me.NumericUpDown_x_fin_tg.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_x_fin_tg.TabIndex = 1
        '
        'NumericUpDown_y_fin_tg
        '
        Me.NumericUpDown_y_fin_tg.DecimalPlaces = 2
        Me.NumericUpDown_y_fin_tg.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown_y_fin_tg.Location = New System.Drawing.Point(1091, 305)
        Me.NumericUpDown_y_fin_tg.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_y_fin_tg.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDown_y_fin_tg.Name = "NumericUpDown_y_fin_tg"
        Me.NumericUpDown_y_fin_tg.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown_y_fin_tg.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(944, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "x_fin_tg"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1088, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "y_fin_tg"
        '
        'ComboBoxColor
        '
        Me.ComboBoxColor.FormattingEnabled = True
        Me.ComboBoxColor.Items.AddRange(New Object() {"Rouge", "Bleu", "Vert"})
        Me.ComboBoxColor.Location = New System.Drawing.Point(947, 506)
        Me.ComboBoxColor.Name = "ComboBoxColor"
        Me.ComboBoxColor.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxColor.TabIndex = 3
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(1074, 506)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(178, 94)
        Me.CheckedListBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(947, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(947, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(934, 626)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Show detail"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1015, 626)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Save_img"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1177, 626)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Read"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1096, 626)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 23)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Save_courbe"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.ComboBoxColor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown_y_fin_tg)
        Me.Controls.Add(Me.NumericUpDown_y_deb_tg)
        Me.Controls.Add(Me.NumericUpDown_longueur)
        Me.Controls.Add(Me.NumericUpDown_segment)
        Me.Controls.Add(Me.NumericUpDown_x_fin_tg)
        Me.Controls.Add(Me.NumericUpDown_x_deb_tg)
        Me.Controls.Add(Me.NumericUpDown_x_fin)
        Me.Controls.Add(Me.NumericUpDown_y_fin)
        Me.Controls.Add(Me.NumericUpDown_x_deb)
        Me.Controls.Add(Me.NumericUpDown_y_deb)
        Me.Controls.Add(Me.bezier_drawing)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bezier_drawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_y_deb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_x_deb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_x_deb_tg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_y_deb_tg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_segment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_longueur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_y_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_x_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_x_fin_tg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_y_fin_tg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bezier_drawing As PictureBox
    Friend WithEvents NumericUpDown_y_deb As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown_x_deb As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown_x_deb_tg As NumericUpDown
    Friend WithEvents NumericUpDown_y_deb_tg As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown_segment As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_longueur As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown_y_fin As NumericUpDown
    Friend WithEvents NumericUpDown_x_fin As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown_x_fin_tg As NumericUpDown
    Friend WithEvents NumericUpDown_y_fin_tg As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxColor As ComboBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
End Class
