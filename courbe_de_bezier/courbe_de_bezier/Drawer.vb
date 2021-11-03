Imports System.Drawing.Drawing2D

Public Class Drawer
    Dim bezier_drawing As PictureBox

    Public Sub New(bezier_drawing As PictureBox)
        Me.bezier_drawing = bezier_drawing
    End Sub

    ' Draw bezier using lib
    Public Sub drawBezierFromLib(ByVal pen As Pen, ByVal bezier As Bezier)
        If bezier_drawing.Image Is Nothing Then
            Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            bezier_drawing.Image = bmp
        End If
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            g.DrawBezier(pen, conversionFromMarker(bezier.p_deb), conversionFromMarker(bezier.p_tg_deb), conversionFromMarker(bezier.p_tg_fin), conversionFromMarker(bezier.p_fin))
        End Using
        bezier_drawing.Invalidate()
    End Sub

    ' Draw lines
    Public Sub drawLines(ByVal pen As Pen, ByVal list_points() As PointF)
        If bezier_drawing.Image Is Nothing Then
            Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            bezier_drawing.Image = bmp
        End If
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            g.DrawLines(pen, conversionFromMarker(list_points))
        End Using
        bezier_drawing.Invalidate()
    End Sub

    ' Draw grid
    Public Sub drawGrid()
        ' First draw horizontal lines each step
        Dim coloredPen As New Pen(Color.Gray)

        coloredPen.DashStyle = DashStyle.Dash

        For x As Double = -1 To 1 Step 0.1
            x = Math.Round(x, 2)
            If (x <> 0.0) Then
                drawLine(coloredPen, New PointF(x, 1), New PointF(x, -1))
            End If
        Next

        ' Then draw vertical lines each step
        For y As Double = -1 To 1 Step 0.1
            y = Math.Round(y, 2)
            If (y <> 0.0) Then
                drawLine(coloredPen, New PointF(-1, y), New PointF(1, y))
            End If
        Next
    End Sub

    Public Sub drawMarker()
        drawLine(Pens.Black, New PointF(-1, 0), New PointF(1, 0))
        drawLine(Pens.Black, New PointF(0, -1), New PointF(0, 1))

        ' Draw arrow

        ' Right arrow
        drawLine(Pens.Black, New PointF(1, 0), New PointF(0.95, 0.05))
        drawLine(Pens.Black, New PointF(1, 0), New PointF(0.95, -0.05))

        ' Upper arrow
        drawLine(Pens.Black, New PointF(0, 1), New PointF(0.05, 0.95))
        drawLine(Pens.Black, New PointF(0, 1), New PointF(-0.05, 0.95))
    End Sub

    ' Draw using marker point line
    Public Sub drawLine(ByVal pen As Pen, ByVal start_point_marker As PointF, ByVal end_point_marker As PointF)

        If bezier_drawing.Image Is Nothing Then
            Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            bezier_drawing.Image = bmp
        End If
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            g.DrawLine(pen, conversionFromMarker(start_point_marker), conversionFromMarker(end_point_marker))
        End Using
        bezier_drawing.Invalidate()

    End Sub

    ' From -1 to +1 => To canvas
    Public Function conversionFromMarker(ByVal point As PointF) As PointF
        Dim convert_point As PointF
        ' First we change our -1 to +1 => 0 => 1 and then use our current size
        convert_point.X = ((point.X + 1) / 2) * bezier_drawing.Width
        convert_point.Y = ((1 - point.Y) / 2) * bezier_drawing.Height

        Return convert_point
    End Function

    Public Function conversionFromMarker(ByVal list_point() As PointF) As PointF()
        Dim convert_list_point(list_point.Length - 1) As PointF
        Dim i As Single = 0

        For Each point As PointF In list_point
            convert_list_point(i) = conversionFromMarker(point)
            i += 1
        Next

        Return convert_list_point
    End Function

    ' From canvas to -1 and +1
    Public Function conversionToMarker(ByVal point As PointF) As PointF
        Dim convert_point As PointF

        ' Value between 0 and max
        If (point.X = 0) Then
            convert_point.X = 0
        Else
            convert_point.X = ((point.X / bezier_drawing.Width) * 2) - 1
        End If

        If (point.Y = 0) Then
            convert_point.Y = 1
        Else
            convert_point.Y = 1 - ((point.Y / bezier_drawing.Height) * 2) ' Y = 1 => 0 
        End If

        Return convert_point
    End Function
End Class
