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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_params))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_screenshot_name = New System.Windows.Forms.TextBox()
        Me.TextBox_file_name = New System.Windows.Forms.TextBox()
        Me.TextBox_file_default_path = New System.Windows.Forms.TextBox()
        Me.TextBox_screenshot_default_path = New System.Windows.Forms.TextBox()
        Me.Button_option_screen_path = New System.Windows.Forms.Button()
        Me.Button_option_file_path = New System.Windows.Forms.Button()
        Me.CheckBox_auto_incr_screenshot = New System.Windows.Forms.CheckBox()
        Me.CheckBox_auto_incr_file = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxHiddenCurves = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'TextBox_screenshot_name
        '
        resources.ApplyResources(Me.TextBox_screenshot_name, "TextBox_screenshot_name")
        Me.TextBox_screenshot_name.Name = "TextBox_screenshot_name"
        '
        'TextBox_file_name
        '
        resources.ApplyResources(Me.TextBox_file_name, "TextBox_file_name")
        Me.TextBox_file_name.Name = "TextBox_file_name"
        '
        'TextBox_file_default_path
        '
        resources.ApplyResources(Me.TextBox_file_default_path, "TextBox_file_default_path")
        Me.TextBox_file_default_path.Name = "TextBox_file_default_path"
        '
        'TextBox_screenshot_default_path
        '
        resources.ApplyResources(Me.TextBox_screenshot_default_path, "TextBox_screenshot_default_path")
        Me.TextBox_screenshot_default_path.Name = "TextBox_screenshot_default_path"
        '
        'Button_option_screen_path
        '
        resources.ApplyResources(Me.Button_option_screen_path, "Button_option_screen_path")
        Me.Button_option_screen_path.Name = "Button_option_screen_path"
        Me.Button_option_screen_path.UseVisualStyleBackColor = True
        '
        'Button_option_file_path
        '
        resources.ApplyResources(Me.Button_option_file_path, "Button_option_file_path")
        Me.Button_option_file_path.Name = "Button_option_file_path"
        Me.Button_option_file_path.UseVisualStyleBackColor = True
        '
        'CheckBox_auto_incr_screenshot
        '
        resources.ApplyResources(Me.CheckBox_auto_incr_screenshot, "CheckBox_auto_incr_screenshot")
        Me.CheckBox_auto_incr_screenshot.Name = "CheckBox_auto_incr_screenshot"
        Me.CheckBox_auto_incr_screenshot.UseVisualStyleBackColor = True
        '
        'CheckBox_auto_incr_file
        '
        resources.ApplyResources(Me.CheckBox_auto_incr_file, "CheckBox_auto_incr_file")
        Me.CheckBox_auto_incr_file.Name = "CheckBox_auto_incr_file"
        Me.CheckBox_auto_incr_file.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'CheckBoxHiddenCurves
        '
        resources.ApplyResources(Me.CheckBoxHiddenCurves, "CheckBoxHiddenCurves")
        Me.CheckBoxHiddenCurves.Name = "CheckBoxHiddenCurves"
        Me.CheckBoxHiddenCurves.UseVisualStyleBackColor = True
        '
        'Form_params
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckBoxHiddenCurves)
        Me.Controls.Add(Me.CheckBox_auto_incr_file)
        Me.Controls.Add(Me.CheckBox_auto_incr_screenshot)
        Me.Controls.Add(Me.Button_option_file_path)
        Me.Controls.Add(Me.Button_option_screen_path)
        Me.Controls.Add(Me.TextBox_screenshot_default_path)
        Me.Controls.Add(Me.TextBox_file_default_path)
        Me.Controls.Add(Me.TextBox_file_name)
        Me.Controls.Add(Me.TextBox_screenshot_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_params"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_screenshot_name As TextBox
    Friend WithEvents TextBox_file_name As TextBox
    Friend WithEvents TextBox_file_default_path As TextBox
    Friend WithEvents TextBox_screenshot_default_path As TextBox
    Friend WithEvents Button_option_screen_path As Button
    Friend WithEvents Button_option_file_path As Button
    Friend WithEvents CheckBox_auto_incr_screenshot As CheckBox
    Friend WithEvents CheckBox_auto_incr_file As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxHiddenCurves As CheckBox
End Class
