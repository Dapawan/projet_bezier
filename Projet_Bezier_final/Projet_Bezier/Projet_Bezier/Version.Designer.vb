<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Version
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Version))
        Me.version_lb = New System.Windows.Forms.Label()
        Me.info_lb = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.distribution_lb = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'version_lb
        '
        Me.version_lb.AutoSize = True
        Me.version_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lb.Location = New System.Drawing.Point(154, 36)
        Me.version_lb.Name = "version_lb"
        Me.version_lb.Size = New System.Drawing.Size(79, 17)
        Me.version_lb.TabIndex = 1
        Me.version_lb.Text = "Description"
        '
        'info_lb
        '
        Me.info_lb.AutoSize = True
        Me.info_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_lb.Location = New System.Drawing.Point(214, 176)
        Me.info_lb.Name = "info_lb"
        Me.info_lb.Size = New System.Drawing.Size(31, 17)
        Me.info_lb.TabIndex = 1
        Me.info_lb.Text = "Info"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_Bezier.My.Resources.Resources.bezier_icon
        Me.PictureBox1.Location = New System.Drawing.Point(42, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'distribution_lb
        '
        Me.distribution_lb.AutoSize = True
        Me.distribution_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.distribution_lb.Location = New System.Drawing.Point(39, 176)
        Me.distribution_lb.Name = "distribution_lb"
        Me.distribution_lb.Size = New System.Drawing.Size(79, 17)
        Me.distribution_lb.TabIndex = 1
        Me.distribution_lb.Text = "Distribution"
        '
        'Version
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.distribution_lb)
        Me.Controls.Add(Me.info_lb)
        Me.Controls.Add(Me.version_lb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Version"
        Me.Text = "Version"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents version_lb As Label
    Friend WithEvents info_lb As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents distribution_lb As Label
End Class
