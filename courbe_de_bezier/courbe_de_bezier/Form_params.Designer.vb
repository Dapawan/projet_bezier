<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_params
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox_auto_incr_screenshot = New System.Windows.Forms.CheckBox()
        Me.TextBox_screenshot_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_screenshot_default_path = New System.Windows.Forms.TextBox()
        Me.Button_option_screen_path = New System.Windows.Forms.Button()
        Me.Button_option_file_path = New System.Windows.Forms.Button()
        Me.TextBox_file_default_path = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_file_name = New System.Windows.Forms.TextBox()
        Me.CheckBox_auto_incr_file = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capture d'écran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fichier"
        '
        'CheckBox_auto_incr_screenshot
        '
        Me.CheckBox_auto_incr_screenshot.AutoSize = True
        Me.CheckBox_auto_incr_screenshot.Location = New System.Drawing.Point(168, 85)
        Me.CheckBox_auto_incr_screenshot.Name = "CheckBox_auto_incr_screenshot"
        Me.CheckBox_auto_incr_screenshot.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox_auto_incr_screenshot.TabIndex = 1
        Me.CheckBox_auto_incr_screenshot.Text = "Auto-incrément"
        Me.CheckBox_auto_incr_screenshot.UseVisualStyleBackColor = True
        '
        'TextBox_screenshot_name
        '
        Me.TextBox_screenshot_name.Location = New System.Drawing.Point(62, 83)
        Me.TextBox_screenshot_name.Name = "TextBox_screenshot_name"
        Me.TextBox_screenshot_name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_screenshot_name.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Chemin d'enregistrement par défaut"
        '
        'TextBox_screenshot_default_path
        '
        Me.TextBox_screenshot_default_path.Location = New System.Drawing.Point(62, 135)
        Me.TextBox_screenshot_default_path.Name = "TextBox_screenshot_default_path"
        Me.TextBox_screenshot_default_path.Size = New System.Drawing.Size(352, 20)
        Me.TextBox_screenshot_default_path.TabIndex = 4
        '
        'Button_option_screen_path
        '
        Me.Button_option_screen_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_option_screen_path.Location = New System.Drawing.Point(420, 132)
        Me.Button_option_screen_path.Name = "Button_option_screen_path"
        Me.Button_option_screen_path.Size = New System.Drawing.Size(24, 23)
        Me.Button_option_screen_path.TabIndex = 5
        Me.Button_option_screen_path.Text = "..."
        Me.Button_option_screen_path.UseVisualStyleBackColor = True
        '
        'Button_option_file_path
        '
        Me.Button_option_file_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_option_file_path.Location = New System.Drawing.Point(420, 263)
        Me.Button_option_file_path.Name = "Button_option_file_path"
        Me.Button_option_file_path.Size = New System.Drawing.Size(24, 23)
        Me.Button_option_file_path.TabIndex = 11
        Me.Button_option_file_path.Text = "..."
        Me.Button_option_file_path.UseVisualStyleBackColor = True
        '
        'TextBox_file_default_path
        '
        Me.TextBox_file_default_path.Location = New System.Drawing.Point(62, 266)
        Me.TextBox_file_default_path.Name = "TextBox_file_default_path"
        Me.TextBox_file_default_path.Size = New System.Drawing.Size(352, 20)
        Me.TextBox_file_default_path.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Chemin d'enregistrement par défaut"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nom"
        '
        'TextBox_file_name
        '
        Me.TextBox_file_name.Location = New System.Drawing.Point(62, 214)
        Me.TextBox_file_name.Name = "TextBox_file_name"
        Me.TextBox_file_name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_file_name.TabIndex = 7
        '
        'CheckBox_auto_incr_file
        '
        Me.CheckBox_auto_incr_file.AutoSize = True
        Me.CheckBox_auto_incr_file.Location = New System.Drawing.Point(168, 216)
        Me.CheckBox_auto_incr_file.Name = "CheckBox_auto_incr_file"
        Me.CheckBox_auto_incr_file.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox_auto_incr_file.TabIndex = 6
        Me.CheckBox_auto_incr_file.Text = "Auto-incrément"
        Me.CheckBox_auto_incr_file.UseVisualStyleBackColor = True
        '
        'Form_params
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 312)
        Me.Controls.Add(Me.Button_option_file_path)
        Me.Controls.Add(Me.TextBox_file_default_path)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_file_name)
        Me.Controls.Add(Me.CheckBox_auto_incr_file)
        Me.Controls.Add(Me.Button_option_screen_path)
        Me.Controls.Add(Me.TextBox_screenshot_default_path)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_screenshot_name)
        Me.Controls.Add(Me.CheckBox_auto_incr_screenshot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_params"
        Me.Text = "Form_params"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox_auto_incr_screenshot As CheckBox
    Friend WithEvents TextBox_screenshot_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_screenshot_default_path As TextBox
    Friend WithEvents Button_option_screen_path As Button
    Friend WithEvents Button_option_file_path As Button
    Friend WithEvents TextBox_file_default_path As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_file_name As TextBox
    Friend WithEvents CheckBox_auto_incr_file As CheckBox
End Class
