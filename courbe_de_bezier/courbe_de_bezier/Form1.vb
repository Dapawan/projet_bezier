Imports System.Drawing.Drawing2D

Public Class Form1

    Dim drawer As Drawer
    Public Sub New()
        InitializeComponent()

        drawer = New Drawer(bezier_drawing)
        drawer.drawMarker()
        drawer.drawGrid()

        Dim bezier As New Bezier(New PointF(0, 0), New PointF(1, 1), New PointF(0.5, 1), New PointF(0.5, -1))

        drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        Dim list_point() As PointF = bezier.getPoints(30)

        drawer.drawLines(New Pen(Color.Blue), list_point)

    End Sub

    Private Sub bezier_drawing_MouseDown(sender As Object, e As MouseEventArgs) Handles bezier_drawing.MouseDown
        Dim mouse_point As Point = e.Location()

        Dim mouse_point_converted As PointF = drawer.conversionToMarker(mouse_point)

        NumericUpDownX.Value = mouse_point_converted.X
        NumericUpDownY.Value = mouse_point_converted.Y

        ' Dim mouse_point_converted_ As New PointF

        ' mouse_point_converted_.X = mouse_point_converted.X - 10
        ' mouse_point_converted_.Y = mouse_point_converted.Y - 10

        ' drawer.drawLine(New Pen(Color.Violet), mouse_point_converted, mouse_point_converted_)
    End Sub
End Class
