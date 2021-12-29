Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel


Public Class Form1

    Dim color As Color
    Dim tracePBW As Integer
    Dim tracePBH As Integer
    Dim tracePBI As Image
    Dim selectedNUD As NumericUpDown
    Dim savedValueNUD As Integer
    Dim clickOnNUD As Boolean
    Dim allowDrag As Boolean
    Public language As String = "fr-FR"


    Dim b As Bitmap
    Dim new_b As Bitmap
    Dim g As Graphics


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tracePBW = trace_pb.Width
        tracePBH = trace_pb.Height
        tracePBI = trace_pb.Image

        b = DirectCast(trace_pb.Image, Bitmap)
        new_b = New Bitmap(Projet_Bezier.My.Resources.Resources.BG, trace_pb.Width, trace_pb.Height)
        g = Graphics.FromImage(new_b)

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles zoom_in_btn.Click
        'tracePB.Size = New System.Drawing.Size(140, 140)
        tracePBW = tracePBW * 1.1
        tracePBH = tracePBH * 1.1

        trace_pb.Image = New Bitmap(tracePBI, tracePBW, tracePBH)


    End Sub

    Private Sub zoom_out_Click(sender As Object, e As EventArgs) Handles zoom_reset_btn.Click, hide_grid_btn.Click, zoom_out_btn.Click
        If tracePBW > trace_pb.Width Then 'block zoomout over the orignal resolution

            tracePBW = tracePBW / 1.1
            tracePBH = tracePBH / 1.1
            Dim imageTmp As Image

            imageTmp = New Bitmap(tracePBI,
                     tracePBW,
                     tracePBH)

            trace_pb.Image = Nothing
            trace_pb.Image = imageTmp

        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        trace_pb.Image.Dispose()
    End Sub



    Public Sub ZoomImage(ByRef ZoomValue As Int32)
        Dim original As Image
        'Get our original image
        original = trace_pb.Image

        'Create a new image based on the zoom parameters we require
        Dim zoomImage As New Bitmap(original, (Convert.ToInt32(original.Width * ZoomValue) / 100), (Convert.ToInt32(original.Height * ZoomValue / 100)))

        'Create a new graphics object based on the new image
        Dim converted As Graphics = Graphics.FromImage(zoomImage)

        'Clean up the image
        ' converted.InterpolationMode = InterpolationMode.HighQualityBicubic

        'Clear out the original image
        trace_pb.Image = Nothing

        'Display the new "zoomed" image
        trace_pb.Image = zoomImage

    End Sub


    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) _
     Handles curve_length_lb.Click

        Dim cDialog As New ColorDialog()
        cDialog.Color = curve_length_lb.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            curve_length_lb.BackColor = cDialog.Color ' update with user selected color.
            color = cDialog.Color

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles pick_color_btn.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = curve_length_lb.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_pb.BackColor = cDialog.Color ' update with user selected color.
            color = cDialog.Color

            'hexacode_tb.Text = "#" & String.Format("{0:00}", Hex(color.R)) & String.Format("{1:00}", Hex(color.G)) & String.Format("{2:00}", Hex(color.B))
            hexacode_tb.Text = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)

        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add_curve_btn.Click
        list_curve_clb.Items.Add("test")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        coord_large_tb.Enabled = False
    End Sub

    Private Sub onNudClick(sender As Object, e As EventArgs) Handles x_nud_start.Click,
        y_nud_start.Click,
        x_nud_end.Click,
        y_nud_end.Click,
        xtg_nud_start.Click,
        xtg_nud_end.Click,
        ytg_nud_start.Click,
        ytg_nud_end.Click
        nudBehaviour(sender)
    End Sub

    Private Sub resetColorNud()
        x_nud_start.BackColor = Color.White
        y_nud_start.BackColor = Color.White
        x_nud_end.BackColor = Color.White
        y_nud_end.BackColor = Color.White
        xtg_nud_start.BackColor = Color.White
        xtg_nud_end.BackColor = Color.White
        ytg_nud_start.BackColor = Color.White
        ytg_nud_end.BackColor = Color.White
    End Sub



    ' Private Sub coordLargeTB_Scroll(sender As Object, e As EventArgs) Handles coordLargeTB.Scroll
    'If Not selectedNUD Is Nothing Then
    '        selectedNUD.Value = coordLargeTB.Value / 10 + coordThinTB.Value / 100
    ' End If

    ' End Sub

    Private Sub coordTB_Scroll(sender As Object, e As EventArgs) Handles coord_large_tb.Scroll, coord_thin_tb.Scroll
        clickOnNUD = False
        If coord_large_tb.Value = 10 Then
            coord_thin_tb.Value = 0
            coord_thin_tb.Enabled = False
        Else
            coord_thin_tb.Enabled = True
        End If

        If Not selectedNUD Is Nothing Then
            selectedNUD.Value = coord_large_tb.Value / 10 + coord_thin_tb.Value / 100
        End If

    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles ytg_nud_start.ValueChanged, ytg_nud_end.ValueChanged, y_nud_start.ValueChanged, y_nud_end.ValueChanged, xtg_nud_start.ValueChanged, xtg_nud_end.ValueChanged, x_nud_start.ValueChanged, x_nud_end.ValueChanged
        If Not selectedNUD Is Nothing And clickOnNUD = True Then
            refreshScrollValues()
        End If
    End Sub

    Private Sub refreshScrollValues()

        coord_large_tb.Value = Math.Truncate(selectedNUD.Value * 10)
        coord_thin_tb.Value = (((selectedNUD.Value * 100) / 10) Mod 1) * 10

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        resetColorNud()
        coord_large_tb.Enabled = False
        coord_thin_tb.Enabled = False
    End Sub

    Private Sub x_nud_start_MouseCaptureChanged(sender As Object, e As EventArgs) Handles x_nud_start.MouseCaptureChanged
        sender.BackColor = Color.IndianRed
    End Sub

    Private Sub y_nud_start_Enter(sender As Object, e As EventArgs) Handles ytg_nud_start.Enter, ytg_nud_end.Enter, y_nud_start.Enter, y_nud_end.Enter, xtg_nud_start.Enter, xtg_nud_end.Enter, x_nud_start.Enter, x_nud_end.Enter
        nudBehaviour(sender)
    End Sub

    Private Sub nudBehaviour(sender As Object)
        resetColorNud()
        sender.BackColor = Color.LightGreen

        coord_large_tb.Enabled = True
        If sender.Value = 1 Then
            coord_thin_tb.Value = 0
            coord_thin_tb.Enabled = False
        Else
            coord_thin_tb.Enabled = True
        End If

        selectedNUD = sender

        If sender Is x_nud_start Then

        ElseIf sender Is y_nud_start Then

        ElseIf sender Is x_nud_end Then

        ElseIf sender Is y_nud_end Then

        ElseIf sender Is xtg_nud_start Then

        ElseIf sender Is xtg_nud_end Then

        ElseIf sender Is ytg_nud_start Then

        ElseIf sender Is ytg_nud_end Then

        End If

        clickOnNUD = True
        refreshScrollValues()
        savedValueNUD = sender.Value
    End Sub

    Private Sub coordThinTB_ValueChanged(sender As Object, e As EventArgs) Handles coord_thin_tb.ValueChanged, coord_large_tb.ValueChanged
        If coord_large_tb.Value = 10 Then
            LargeLB.Text = "1.00"
        ElseIf coord_large_tb.Value = 0 Then
            LargeLB.Text = (coord_large_tb.Value / 10).ToString
        Else
            LargeLB.Text = (coord_large_tb.Value / 10).ToString + "0"
        End If

        ThinLB.Text = coord_thin_tb.Value / 100
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delete_curve_btn.Click
        Dim bmp As New Bitmap(trace_pb.Width, trace_pb.Height)

        Dim b As Bitmap = DirectCast(trace_pb.Image, Bitmap)
        Dim new_b As New Bitmap(Projet_Bezier.My.Resources.Resources.BG, trace_pb.Width, trace_pb.Height)
        Dim g As Graphics = Graphics.FromImage(new_b)

        g.DrawImage(b, New Point(0, 5)) 'Moves the picture down by 5
        g.Save()


        trace_pb.Image = new_b
        trace_pb.Invalidate()
    End Sub

    Private Sub tracePB_DragDrop(sender As Object, e As DragEventArgs) Handles trace_pb.DragDrop
        Dim bmp As New Bitmap(trace_pb.Width, trace_pb.Height)

        Dim b As Bitmap = DirectCast(trace_pb.Image, Bitmap)
        Dim new_b As New Bitmap(Projet_Bezier.My.Resources.Resources.BG, trace_pb.Width, trace_pb.Height)
        Dim g As Graphics = Graphics.FromImage(new_b)

        g.DrawImage(b, New Point(0, 5)) 'Moves the picture down by 5
        g.Save()


        trace_pb.Image = new_b
        trace_pb.Invalidate()
    End Sub

    Private Sub tracePB_MouseDown(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseDown
        allowDrag = True
    End Sub

    Private Sub tracePB_MouseMove(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseMove
        'If allowDrag Then
        'Dim bmp As Bitmap
        ' If bmp Is Not Nothing Then
        '         bmp = New Bitmap(tracePB.Width, tracePB.Height)


        'g.DrawImage(b, New Point(e.X, e.Y)) 'Moves the picture down by 5
        ' g.Save()
        ' g.TranslateTransform(e.X, e.Y)
        ' tracePB.Image.Dispose()
        ' tracePB.Image = new_b
        ' tracePB.Invalidate()
        ' End If
        ' End If
    End Sub

    Private Sub tracePB_MouseUp(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseUp
        allowDrag = False
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles trace_pb.Paint
        ' e.Graphics.DrawImage(new_b)
    End Sub

    Private Sub hexacode_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles hexacode_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim color_read As String
            Try

                color_read = hexacode_tb.Text
                color_read = Replace(color_read, "#", "")
                If color_read.Length > 6 Then
                    ' MessageBox.Show("Too long")
                    Throw New Exception
                End If
                If color_read.Length < 6 Then
                    color_read = color_read.PadRight(6, "0")

                End If
                color_read = "#" & color_read

                'color.FromArgb(Decimal(hexacode_tb.Text))

                color = ColorTranslator.FromHtml(color_read)
                color_pb.BackColor = color ' update with user selected color.
                hexacode_tb.Text = color_read

            Catch ex As Exception
                MessageBox.Show("Code Hexa incorrect" & " et " & hexacode_tb.Text, "Erreur", MessageBoxButtons.OKCancel)
                color_pb.BackColor = Color.Black ' update with user selected color.
                hexacode_tb.Text = "#000000"
            End Try
        End If

    End Sub


    Private Sub Button14_Click(sender As Object, e As EventArgs)
        main_menu_ms.Visible = Not main_menu_ms.Visible
    End Sub

    Private Sub ChangeLanguage(ByVal Language As String)
        Me.language = Language

        Dim crmLang As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))

        'Change all Form1 Controls language
        Me.Text = "test"

        For Each control In Me.Controls
            crmLang.ApplyResources(control, control.Name, New CultureInfo(Language))
        Next control




        For Each c As ToolStripMenuItem In main_menu_ms.Items
            'Change Form1 StripMenuBar language
            crmLang.ApplyResources(c, c.Name, New CultureInfo(Language))

            'Change StripMenuBar Dropdown items language
            If c.HasDropDownItems Then
                For Each subitems As ToolStripMenuItem In c.DropDownItems
                    crmLang.ApplyResources(subitems, subitems.Name, New CultureInfo(Language))
                Next

            End If

        Next c


        ' crmLang.ApplyResources(main_menu_ms, main_menu_ms.Name, New CultureInfo(Language)) 'Set desired language

        'main_menu_ms.Items.Clear()


    End Sub

    Private Sub FrançaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrançaisToolStripMenuItem.Click
        ChangeLanguage("fr-FR")
    End Sub

    Private Sub AnglaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnglaisToolStripMenuItem.Click
        ChangeLanguage("en")
    End Sub

    Private Sub ControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlToolStripMenuItem.Click
        Control.Show()
    End Sub

    Private Sub VersionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionsToolStripMenuItem.Click
        Version.Show()
    End Sub

    Private Sub delete_file_btn_Click(sender As Object, e As EventArgs) Handles delete_file_btn.Click
        Dim current As CultureInfo = CultureInfo.CurrentCulture

        If current.Name.Equals("fr-FR") Then
            MessageBox.Show("Code Hexa incorrect", "Info", MessageBoxButtons.OKCancel)
        End If
    End Sub

    Private Sub NoticeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoticeToolStripMenuItem.Click
        Dim FByte() As Byte = My.Resources.Notice
        Dim path As String
        Dim name As String = "\Notice.pdf"

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
            If language.Equals("fr-FR") Then
                MessageBox.Show("La notice à été sauvegrder à l'endroit suivant : " & vbCrLf & path, "Information")
            Else
                MessageBox.Show("The notice was saved at the following location : " & vbCrLf & path, "Information")
            End If
            My.Computer.FileSystem.WriteAllBytes(path & name, FByte, True)
        End If

    End Sub
End Class
