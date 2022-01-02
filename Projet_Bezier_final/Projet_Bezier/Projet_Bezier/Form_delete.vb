Imports System.ComponentModel
Imports System.Globalization

Public Class Form_delete
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Dim crmLang As ComponentResourceManager = New ComponentResourceManager(GetType(Form_delete))

        For Each control In Me.Controls
            crmLang.ApplyResources(control, control.Name, New CultureInfo(Form1.language))
        Next control

        If (Form1.language = "fr-FR") Then
            CheckedListBox_choice.Items.Clear()
            CheckedListBox_choice.Items.Add("Supprimer toutes les captures d'écran (.jpg dans le répertoire par défaut)")
            CheckedListBox_choice.Items.Add("Supprimer tous les beziers (.txt dans le répertoire par défaut)")
        End If

    End Sub

    Public Sub getResult(ByRef delete_screenshot As Boolean, ByRef delete_files As Boolean)
        delete_screenshot = CheckedListBox_choice.GetItemChecked(0)
        delete_files = CheckedListBox_choice.GetItemChecked(1)
    End Sub

    Private Sub ButtonAccept_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click, ButtonAccept.Click
        If sender Is ButtonCancel Then
            DialogResult = DialogResult.Cancel
        Else
            DialogResult = DialogResult.OK
        End If

        Dispose()
    End Sub
End Class