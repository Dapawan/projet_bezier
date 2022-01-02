<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_delete))
        Me.CheckedListBox_choice = New System.Windows.Forms.CheckedListBox()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox_choice
        '
        Me.CheckedListBox_choice.FormattingEnabled = True
        Me.CheckedListBox_choice.Items.AddRange(New Object() {resources.GetString("CheckedListBox_choice.Items"), resources.GetString("CheckedListBox_choice.Items1")})
        resources.ApplyResources(Me.CheckedListBox_choice, "CheckedListBox_choice")
        Me.CheckedListBox_choice.Name = "CheckedListBox_choice"
        '
        'ButtonAccept
        '
        resources.ApplyResources(Me.ButtonAccept, "ButtonAccept")
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Form_delete
        '
        Me.AcceptButton = Me.ButtonAccept
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.CheckedListBox_choice)
        Me.Name = "Form_delete"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox_choice As CheckedListBox
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents ButtonCancel As Button
End Class
