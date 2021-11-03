Imports System.Drawing.Drawing2D

Public Class Drawer
    Dim bezier_drawing As PictureBox

    Public Sub New(bezier_drawing As PictureBox)
        Me.bezier_drawing = bezier_drawing
    End Sub


    Public Sub saveDrawing()
        If bezier_drawing.Image Is Nothing Then
            Return
        Else
            Dim sfdPic As New SaveFileDialog()
            Dim Path As String = "C:\Bureau"
            Dim Dir As String = System.IO.Path.GetDirectoryName(Path)

            Dim title As String = "Code A Minute - iBasskung."
            Dim btn = MessageBoxButtons.YesNo
            Dim ico = MessageBoxIcon.Information

            Try
                If Not System.IO.Directory.Exists(Dir) Then
                    System.IO.Directory.CreateDirectory(Dir)
                End If

                With sfdPic
                    .Title = "Enregistre la courbe sous"
                    .Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp"
                    .AddExtension = True
                    .DefaultExt = ".jpg"
                    .FileName = "maCourbe.jpg"
                    .ValidateNames = True
                    .OverwritePrompt = True
                    .InitialDirectory = Dir
                    .RestoreDirectory = True

                    If .ShowDialog = DialogResult.OK Then
                        If .FilterIndex = 1 Then
                            bezier_drawing.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Jpeg)
                            MessageBox.Show("Courbe enregistrée avec succès à : " + sfdPic.FileName)
                        ElseIf .FilterIndex = 2 Then
                            bezier_drawing.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Png)
                            MessageBox.Show("Courbe enregistrée avec succès à : " + sfdPic.FileName)
                        ElseIf .FilterIndex = 3 Then
                            bezier_drawing.Image.Save(sfdPic.FileName, Imaging.ImageFormat.Bmp)
                            MessageBox.Show("Courbe enregistrée avec succès à : " + sfdPic.FileName)
                        End If
                    Else
                        Return
                    End If

                End With
            Catch ex As Exception
                MessageBox.Show("Error: Saving Image Failed ->> " & ex.Message.ToString())
            Finally
                sfdPic.Dispose()
            End Try
        End If
    End Sub

    Public Sub clearDrawing()
        Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
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

    Public Sub drawString(ByVal pen As Pen, ByVal stringToDisplay As String, ByVal position As PointF)
        If bezier_drawing.Image Is Nothing Then
            Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            bezier_drawing.Image = bmp
        End If
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            g.DrawString(stringToDisplay, New Font("Tahoma", 11), pen.Brush, conversionFromMarker(position))
        End Using
        bezier_drawing.Invalidate()
    End Sub

    Public Sub drawPoint(ByVal pen As Pen, ByVal position As PointF, ByVal width As Single, ByVal height As Single)
        If bezier_drawing.Image Is Nothing Then
            Dim bmp As New Bitmap(bezier_drawing.Width, bezier_drawing.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            bezier_drawing.Image = bmp
        End If
        Using g As Graphics = Graphics.FromImage(bezier_drawing.Image)
            position = conversionFromMarker(position)
            g.FillRectangle(pen.Brush, position.X - (width / 2), position.Y - (height / 2), width, height)
        End Using
        bezier_drawing.Invalidate()
    End Sub

    Public Sub drawBezier(ByVal bezier As Bezier)
        ' We clear old drawing
        clearDrawing()
        drawMarker()
        drawGrid()

        ' Dessine la courbe
        drawLines(New Pen(bezier.couleur), bezier.points)
        ' Dessine les points
        drawPoint(New Pen(bezier.couleur), bezier.p_deb, 5, 5)
        drawPoint(New Pen(bezier.couleur), bezier.p_fin, 5, 5)

        drawPoint(New Pen(bezier.couleur), bezier.p_tg_deb, 5, 5)
        drawPoint(New Pen(bezier.couleur), bezier.p_tg_fin, 5, 5)
        'Dessine les tangentes
        Dim coloredPen As New Pen(bezier.couleur)

        coloredPen.DashStyle = DashStyle.DashDotDot
        drawLine(coloredPen, bezier.p_deb, bezier.p_tg_deb)

        drawLine(coloredPen, bezier.p_fin, bezier.p_tg_fin)
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
                drawLine(coloredPen, New PointF(x, 1), New PointF(x, -1))
            End If
        Next

        For y As Double = -1 To 1 Step 0.05
            y = Math.Round(y, 2)
            If (y <> 0.0) Then
                drawLine(coloredPen, New PointF(-1, y), New PointF(1, y))
            End If
        Next


        coloredPen.DashStyle = DashStyle.Solid
        coloredPen.Color = Color.Gray



        For x As Double = -1 To 1 Step 0.1
            x = Math.Round(x, 2)
            If (x <> 0.0) Then
                drawLine(coloredPen, New PointF(x, 1), New PointF(x, -1))
            End If
        Next

        For y As Double = -1 To 1 Step 0.1
            y = Math.Round(y, 2)
            If (y <> 0.0) Then
                drawLine(coloredPen, New PointF(-1, y), New PointF(1, y))
            End If
        Next


    End Sub

    Public Sub drawMarker()

        Dim coloredPen As New Pen(Color.Black)

        coloredPen.Width = 2

        drawLine(coloredPen, New PointF(-1, 0), New PointF(1, 0))
        drawLine(coloredPen, New PointF(0, -1), New PointF(0, 1))

        ' Draw arrow

        ' Right arrow
        drawLine(coloredPen, New PointF(1, 0), New PointF(0.95, 0.05))
        drawLine(coloredPen, New PointF(1, 0), New PointF(0.95, -0.05))

        ' Upper arrow
        drawLine(coloredPen, New PointF(0, 1), New PointF(0.05, 0.95))
        drawLine(coloredPen, New PointF(0, 1), New PointF(-0.05, 0.95))


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

            drawString(New Pen(Color.Black), x.ToString(), New PointF(x_pos, 0))
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

            drawString(New Pen(Color.Black), y.ToString(), New PointF(0, y_pos))
        Next

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
