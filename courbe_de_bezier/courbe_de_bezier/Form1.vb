Imports System.Drawing.Drawing2D

Public Class Form1

    Dim drawer As Drawer
    Dim bezier As Bezier

    Public Sub New()
        InitializeComponent()

        drawer = New Drawer(bezier_drawing)

        bezier = New Bezier(New PointF(0, 0), New PointF(1, 1), New PointF(0.5, 0.8), New PointF(0.5, -0.8), NumericUpDown_segment.Value, Color.Blue)

        NumericUpDown_x_deb.Value = bezier.p_deb.X
        NumericUpDown_y_deb.Value = bezier.p_deb.Y

        NumericUpDown_x_fin.Value = bezier.p_fin.X
        NumericUpDown_y_fin.Value = bezier.p_fin.Y

        NumericUpDown_x_deb_tg.Value = bezier.p_tg_deb.X
        NumericUpDown_y_deb_tg.Value = bezier.p_tg_deb.Y

        NumericUpDown_x_fin_tg.Value = bezier.p_tg_fin.X
        NumericUpDown_y_fin_tg.Value = bezier.p_tg_fin.Y


        drawer.drawBezier(bezier)
        drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        NumericUpDown_longueur.Value = bezier.getDistance()

        ' Save img 
        ' drawer.saveDrawing()

    End Sub

    Private Sub bezier_drawing_MouseDown(sender As Object, e As MouseEventArgs) Handles bezier_drawing.MouseDown
        Dim mouse_point As Point = e.Location()

        Dim mouse_point_converted As PointF = drawer.conversionToMarker(mouse_point)



        Dim mouse_point_selected As PointF = bezier.selectionPoint(mouse_point_converted)

        If (not mouse_point_selected.IsEmpty) Then
            drawer.drawPoint(New Pen(Color.Red), mouse_point_selected, 10, 10)
        End If

        ' Dim mouse_point_converted_ As New PointF

        ' mouse_point_converted_.X = mouse_point_converted.X - 10
        ' mouse_point_converted_.Y = mouse_point_converted.Y - 10

        ' drawer.drawLine(New Pen(Color.Violet), mouse_point_converted, mouse_point_converted_)
    End Sub

    Private Sub NumericUpDown_segment_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_segment.ValueChanged, NumericUpDown_longueur.ValueChanged
        If drawer Is Nothing Then
            Return
        End If

        bezier.nombre_segment = NumericUpDown_segment.Value

        drawer.drawBezier(bezier)
        drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        NumericUpDown_longueur.Value = bezier.longueur
    End Sub

    Private Sub NumericUpDown_x_deb_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_x_deb.ValueChanged, NumericUpDown_y_deb.ValueChanged, NumericUpDown_y_fin.ValueChanged, NumericUpDown_x_fin.ValueChanged, NumericUpDown_x_deb_tg.ValueChanged, NumericUpDown_y_deb_tg.ValueChanged, NumericUpDown_x_fin_tg.ValueChanged, NumericUpDown_y_fin_tg.ValueChanged
        Dim obj As System.Windows.Forms.NumericUpDown = DirectCast(sender, System.Windows.Forms.NumericUpDown)

        If (obj Is NumericUpDown_x_deb) Then
            bezier.p_deb.X = NumericUpDown_x_deb.Value
        ElseIf (obj Is NumericUpDown_y_deb) Then
            bezier.p_deb.Y = NumericUpDown_y_deb.Value
        ElseIf (obj Is NumericUpDown_x_deb_tg) Then
            bezier.p_tg_deb.X = NumericUpDown_x_deb_tg.Value
        ElseIf (obj Is NumericUpDown_y_deb_tg) Then
            bezier.p_tg_deb.Y = NumericUpDown_y_deb_tg.Value
        ElseIf (obj Is NumericUpDown_x_fin_tg) Then
            bezier.p_tg_fin.X = NumericUpDown_x_fin_tg.Value
        ElseIf (obj Is NumericUpDown_y_fin_tg) Then
            bezier.p_tg_fin.Y = NumericUpDown_y_fin_tg.Value
        ElseIf (obj Is NumericUpDown_x_fin) Then
            bezier.p_fin.X = NumericUpDown_x_fin.Value
        ElseIf (obj Is NumericUpDown_y_fin) Then
            bezier.p_fin.Y = NumericUpDown_y_fin.Value
        End If

        drawer.drawBezier(bezier)
        drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        NumericUpDown_longueur.Value = bezier.longueur

    End Sub
End Class
