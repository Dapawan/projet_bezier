Public Class Form_delete
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