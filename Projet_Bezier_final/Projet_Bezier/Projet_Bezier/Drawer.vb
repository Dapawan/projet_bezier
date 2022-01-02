Imports System.Drawing.Drawing2D

Public Class Drawer
    Dim bezier_drawing As PictureBox

    Public Sub New(bezier_drawing As PictureBox)
        Me.bezier_drawing = bezier_drawing

        HideShowGrid(False)

    End Sub

    Public Sub HideShowGrid(ByVal hide As Boolean)
        If Not bezier_drawing.BackgroundImage Is Nothing Then
            bezier_drawing.BackgroundImage.Dispose()
        End If

        Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        bezier_drawing.BackgroundImage = bmp
        'Draw on bg img
        drawMarker()
        If (hide.Equals(False)) Then
            drawGrid()
        End If

    End Sub

    Public Sub drawStringBezierList(ByRef img As Bitmap, ByRef bezier_list As List(Of Bezier), ByRef hidden_curves As Boolean)
        Dim str As String = "Légende : " + vbNewLine
        Dim coloredPen As New Pen(Color.Black)

        Using g As Graphics = Graphics.FromImage(img)
            g.DrawString(str, New Font("Tahoma", 11), coloredPen.Brush, New PointF(0, 0))
        End Using

        Dim cnt As Single = 1

        For Each bezier As Bezier In bezier_list
            If hidden_curves = False AndAlso bezier.show = False Then
                Continue For 'Skip hidden curves on legend
            End If
            coloredPen.Color = bezier.couleur
            Using g As Graphics = Graphics.FromImage(img)
                g.DrawString(bezier.ToString().Replace(" ", "  "), New Font("Tahoma", 11), coloredPen.Brush, New PointF(0, cnt * 14))
            End Using
            cnt += 1
        Next
    End Sub
    Public Sub clearDrawing()
        If Not bezier_drawing.Image Is Nothing Then
            bezier_drawing.Image.Dispose()
        End If

        Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
        bmp.MakeTransparent()
        bezier_drawing.Image = bmp
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
        ' Create a blank bitmap with the same dimensions
        Dim tempBitmap As Bitmap = New Bitmap(bezier_drawing.Image.Width, bezier_drawing.Image.Height)
        Using g As Graphics = Graphics.FromImage(tempBitmap)
            g.DrawBezier(pen, conversionFromMarker(bezier.p_deb), conversionFromMarker(bezier.p_tg_deb), conversionFromMarker(bezier.p_tg_fin), conversionFromMarker(bezier.p_fin))
        End Using
        bezier_drawing.Invalidate()
    End Sub

    ' Draw lines
    Public Sub drawLines(ByVal pen As Pen, ByRef list_points() As PointF)
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            g.DrawLines(pen, conversionFromMarker(list_points))
        End Using
    End Sub

    Public Sub drawString(ByVal pen As Pen, ByVal stringToDisplay As String, ByVal position As PointF, ByVal bg As Boolean)
        Dim img As Image = bezier_drawing.Image
        If (bg.Equals(True)) Then
            img = bezier_drawing.BackgroundImage
        End If
        Using g As Graphics = Graphics.FromImage(img)
            g.DrawString(stringToDisplay, New Font("Tahoma", 11), pen.Brush, conversionFromMarker(position))
        End Using
    End Sub

    Public Sub drawPoint(ByVal pen As Pen, ByVal position As PointF, ByVal width As Single, ByVal height As Single)
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            position = conversionFromMarker(position)
            g.FillRectangle(pen.Brush, position.X - (width / 2), position.Y - (height / 2), width, height)
        End Using
    End Sub

    Public Sub drawBeziers(ByRef bezier_list As List(Of Bezier), ByVal show_name As Boolean)
        ' We clear old drawing
        clearDrawing()

        For Each bezier In bezier_list
            If bezier.show.Equals(True) Then
                drawBezier(bezier, False, show_name)
            End If
        Next
    End Sub

    Public Sub drawBezier(ByRef bezier As Bezier, ByVal clear_drawing As Boolean, ByVal show_name As Boolean)
        If clear_drawing.Equals(True) Then
            ' We clear old drawing
            clearDrawing()
        End If

        'Dessine les tangentes
        Dim coloredPen As New Pen(bezier.couleur)
        If bezier.currentlySelected.Equals(True) Then
            coloredPen.Width = 2
        Else
            coloredPen.Width = 1
        End If

        ' Dessine la courbe
        drawLines(coloredPen, bezier.points)

        If show_name.Equals(True) Then
            ' Indique le nom de la courbe
            drawString(coloredPen, bezier.uid.ToString(), bezier.p_deb, False)
        End If

        ' Dessine les points
        drawPoint(coloredPen, bezier.p_deb, 5, 5)
        drawPoint(coloredPen, bezier.p_fin, 5, 5)

        drawPoint(coloredPen, bezier.p_tg_deb, 5, 5)
        drawPoint(coloredPen, bezier.p_tg_fin, 5, 5)

        If bezier.currentlySelected.Equals(True) Then
            coloredPen.Width = 2
        Else
            coloredPen.Width = 1
        End If
        coloredPen.DashStyle = DashStyle.DashDotDot
        drawLine(coloredPen, bezier.p_deb, bezier.p_tg_deb, False)

        drawLine(coloredPen, bezier.p_fin, bezier.p_tg_fin, False)
    End Sub

    ' Draw grid
    Public Sub drawGrid()
        ' First draw horizontal lines each step
        Dim coloredPen As New Pen(Color.Gray)

        coloredPen.DashStyle = DashStyle.Dash
        coloredPen.Color = Color.LightGray


        ' Then draw vertical lines each step
        For x As Double = -1 To 1 Step 0.05
            x = Math.Round(x, 2)
            If (x <> 0.0) Then
                drawLine(coloredPen, New PointF(x, 1), New PointF(x, -1), True)
            End If
        Next

        For y As Double = -1 To 1 Step 0.05
            y = Math.Round(y, 2)
            If (y <> 0.0) Then
                drawLine(coloredPen, New PointF(-1, y), New PointF(1, y), True)
            End If
        Next


        coloredPen.DashStyle = DashStyle.Solid
        coloredPen.Color = Color.Gray



        For x As Double = -1 To 1 Step 0.1
            x = Math.Round(x, 2)
            If (x <> 0.0) Then
                drawLine(coloredPen, New PointF(x, 1), New PointF(x, -1), True)
            End If
        Next

        For y As Double = -1 To 1 Step 0.1
            y = Math.Round(y, 2)
            If (y <> 0.0) Then
                drawLine(coloredPen, New PointF(-1, y), New PointF(1, y), True)
            End If
        Next


    End Sub

    Public Sub drawMarker()

        Dim coloredPen As New Pen(Color.Black)

        coloredPen.Width = 2

        drawLine(coloredPen, New PointF(-1, 0), New PointF(1, 0), True)
        drawLine(coloredPen, New PointF(0, -1), New PointF(0, 1), True)

        ' Draw arrow

        ' Right arrow
        drawLine(coloredPen, New PointF(1, 0), New PointF(0.95, 0.05), True)
        drawLine(coloredPen, New PointF(1, 0), New PointF(0.95, -0.05), True)

        ' Upper arrow
        drawLine(coloredPen, New PointF(0, 1), New PointF(0.05, 0.95), True)
        drawLine(coloredPen, New PointF(0, 1), New PointF(-0.05, 0.95), True)


        ' Draw values x position
        Dim x_pos As Double

        For x As Double = -1 To 1 Step 0.1
            x = Math.Round(x, 2)
            If (x < 0) Then
                x_pos = x - 0.04
            Else
                x_pos = x - 0.025
            End If
            If (x = 1) Then
                Continue For
            End If

            drawString(New Pen(Color.Black), x.ToString(), New PointF(x_pos, 0), True)
        Next

        ' Draw values y position
        Dim y_pos As Double

        For y As Double = -1 To 1 Step 0.1
            y = Math.Round(y, 2)

            If (y < 0) Then
                y_pos = y + 0.03
            Else
                y_pos = y + 0.03
            End If
            If (y = 0) Or (y = 1) Then
                Continue For
            End If

            drawString(New Pen(Color.Black), y.ToString(), New PointF(0, y_pos), True)
        Next

    End Sub

    ' Draw using marker point line
    Public Sub drawLine(ByVal pen As Pen, ByVal start_point_marker As PointF, ByVal end_point_marker As PointF, ByVal bg As Boolean)
        Dim img As Image = bezier_drawing.Image
        If (bg.Equals(True)) Then
            img = bezier_drawing.BackgroundImage
        End If
        Using g As Graphics = Graphics.FromImage(img)
            g.DrawLine(pen, conversionFromMarker(start_point_marker), conversionFromMarker(end_point_marker))
        End Using
    End Sub

    ' From -1 to +1 => To canvas
    Public Function conversionFromMarker(ByVal point As PointF) As PointF
        Dim convert_point As PointF
        ' First we change our -1 to +1 => 0 => 1 and then use our current size
        If (point.X + 1 = 0) Then
            convert_point.X = 0
        Else
            convert_point.X = ((point.X + 1) / 2) * bezier_drawing.Width
        End If

        If (1 - point.Y = 0) Then
            convert_point.Y = 1
        Else
            convert_point.Y = ((1 - point.Y) / 2) * bezier_drawing.Height
        End If

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
