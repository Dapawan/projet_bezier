Public Class FormListDisplayBezier
    Public Sub New(ByRef list_bezier As List(Of Bezier))
        InitializeComponent()

        For Each bezier As Bezier In list_bezier
            RichTextBox1.SelectionColor = bezier.couleur
            RichTextBox1.AppendText(bezier.ToString() + vbNewLine)
        Next

    End Sub

End Class