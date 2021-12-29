Imports System.Globalization
Imports System.ComponentModel
Imports System.Threading

Public Class Version
    Private Sub Version_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim current As CultureInfo = CultureInfo.CurrentCulture


        'If current.Name.Equals("Fr-fr") Then
        '  MessageBox.Show("Code Hexa incorrect", "Info", MessageBoxButtons.OKCancel)
        ' End If

        Dim distribution As String = My.Resources.Resources.Distribution
        distribution_lb.Text = distribution

        If Form1.language.Equals("fr-FR") Then
            Dim content As String = My.Resources.Resources.Version
            Dim info As String = My.Resources.Resources.Info_version

            version_lb.Text = content
            info_lb.Text = info

        Else
            Dim content As String = My.Resources.Resources.Version_EN
            Dim info As String = My.Resources.Resources.Info_version_EN

            version_lb.Text = content
            info_lb.Text = info
        End If
    End Sub
End Class