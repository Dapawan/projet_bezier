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
        Me.CheckedListBox_choice = New System.Windows.Forms.CheckedListBox()
        Me.ButtonAccept = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox_choice
        '
        Me.CheckedListBox_choice.FormattingEnabled = True
        Me.CheckedListBox_choice.Items.AddRange(New Object() {"Remove all screenshots (using default path)", "Remove all beziers file (using default path)"})
        Me.CheckedListBox_choice.Location = New System.Drawing.Point(54, 35)
        Me.CheckedListBox_choice.Name = "CheckedListBox_choice"
        Me.CheckedListBox_choice.Size = New System.Drawing.Size(242, 34)
        Me.CheckedListBox_choice.TabIndex = 0
        '
        'ButtonAccept
        '
        Me.ButtonAccept.Location = New System.Drawing.Point(13, 83)
        Me.ButtonAccept.Name = "ButtonAccept"
        Me.ButtonAccept.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAccept.TabIndex = 1
        Me.ButtonAccept.Text = "Accept"
        Me.ButtonAccept.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(262, 83)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Form_delete
        '
        Me.AcceptButton = Me.ButtonAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(351, 118)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAccept)
        Me.Controls.Add(Me.CheckedListBox_choice)
        Me.Name = "Form_delete"
        Me.Text = "Form_delete"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox_choice As CheckedListBox
    Friend WithEvents ButtonAccept As Button
    Friend WithEvents ButtonCancel As Button
End Class
