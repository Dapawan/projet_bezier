Public Class Control

    Private Sub control_pb_MouseWheel(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles control_pb.MouseWheel
        control_pb.Width += CInt(control_pb.Width * e.Delta / 1000)
        control_pb.Height += CInt(control_pb.Height * e.Delta / 1000)

        Text = CStr(control_pb.Left) & " - " & CStr(control_pb.Top) & " - " & CStr(control_pb.Width)

    End Sub




    Private WithEvents Pic1 As New PictureBox With {.Parent = Me, .Dock = DockStyle.Fill}
        Private Corner As New PointF(0, 0)
        Private MouseDownPt, MouseMovePt, MouseDownCornerPt As New PointF
    Private SourcePic As New Bitmap("C:\Users\xychr\source\repos\Projet_Bezier\Projet_Bezier\icon\Control-v5.png")
    Private ScaleWidth As Double = SourcePic.Width
        Private ScaleRatio As Double

        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
            Text = "MW Zoom - LMB Drag"
            Form2_Resize(0, Nothing)
        End Sub

        Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            SetScaleRatio(New MouseEventArgs(0, 0, 0, 0, 0))
            Pic1.Invalidate()
        End Sub

        Private Sub Pic1_Paint(sender As Object, e As PaintEventArgs) Handles Pic1.Paint

            With e.Graphics
                .Clear(Color.White)
                .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                Dim sf As Single = CSng(Pic1.ClientRectangle.Width / ScaleWidth)
                .ScaleTransform(sf, sf)
                .TranslateTransform(-Corner.X, -Corner.Y)

                .DrawImage(SourcePic, New Rectangle(0, 0, SourcePic.Width, SourcePic.Height))

            End With
        End Sub

        Private Sub Pic1_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic1.MouseDown
            MouseDownPt = e.Location
            MouseMovePt = e.Location
            MouseDownCornerPt = Corner
        End Sub

        Private Sub Pic1_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic1.MouseMove
            MouseMovePt = e.Location

            If e.Button = MouseButtons.Left Then
                'drag the screen
                Dim sf As Double = Pic1.ClientSize.Width / ScaleWidth
                Dim x As Integer = CInt(MouseDownCornerPt.X - ((MouseMovePt.X - MouseDownPt.X) / sf))
                Dim y As Integer = CInt(MouseDownCornerPt.Y - ((MouseMovePt.Y - MouseDownPt.Y) / sf))
                Corner = New Point(x, y)
                Pic1.Invalidate()
            End If
        End Sub

        Private Sub Pic1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Pic1.MouseWheel
            SetScaleRatio(e)
            Pic1.Invalidate()
        End Sub

        Private Sub Pic1_MouseEnter(sender As Object, e As EventArgs) Handles Pic1.MouseEnter
            If Not Pic1.Focused Then Pic1.Focus()
        End Sub

        Private Sub SetScaleRatio(e As MouseEventArgs)
            Dim x, y, s2 As Double
            Dim w As Double = ClientSize.Width
            Dim s As Double = CSng(ScaleWidth)

            If ScaleRatio <> 0 Then
                'calc mouse position in scaleunits
                x = Corner.X + (e.X * ScaleRatio)
                y = Corner.Y + (e.Y * ScaleRatio)

                'calc new scale and view centered on mouse position
                s2 = s - (Math.Sign(e.Delta) * s / 12)
                ScaleRatio = s2 / w
                ScaleWidth = s2
                Corner.X = CSng(x - (e.X * ScaleRatio))
                Corner.Y = CSng(y - (e.Y * ScaleRatio))
            Else
                ScaleRatio = s / w
            End If
        End Sub
End Class