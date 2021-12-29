<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control))
        Me.control_pb = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.control_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'control_pb
        '
        Me.control_pb.Image = Global.Projet_Bezier.My.Resources.Resources.Control_v5
        Me.control_pb.Location = New System.Drawing.Point(6, 2)
        Me.control_pb.Name = "control_pb"
        Me.control_pb.Size = New System.Drawing.Size(610, 675)
        Me.control_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.control_pb.TabIndex = 0
        Me.control_pb.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(207, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 1
        '
        'Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.control_pb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Control"
        Me.Text = "Control"
        CType(Me.control_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents control_pb As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
