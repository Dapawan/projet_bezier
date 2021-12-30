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

    Dim ToolTip1 As System.Windows.Forms.ToolTip
    Dim drawer As Drawer
    Dim bezier As Bezier 'Current bezier
    Dim bezier_list As New List(Of Bezier)

    Dim numeric_indicator_value_changed_trigger As Boolean = False
    Dim check_selected_index_value_changed_trigger As Boolean = False
    Dim name_changed_trigger As Boolean = True

    Dim show_name_bezier As Boolean = True

    'Params window => Only once
    Dim form_params As Form_params

    Dim pattern_print_length As String = "0.00"
    Dim hide_show_grid As Boolean = False

    ' Params 
    Dim filename_screenshot As String = ""
    Dim auto_incr_screenshot As Boolean
    Dim default_path_screenshot As String = ""
    Dim filename_file As String = ""
    Dim auto_incr_file As Boolean
    Dim default_path_file As String = ""


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        tracePBW = trace_pb.Width
        tracePBH = trace_pb.Height
        tracePBI = trace_pb.Image

        'trace_pb.BackgroundImage = New Bitmap(Projet_Bezier.My.Resources.Resources.BG, trace_pb.Width, trace_pb.Height)
        '
        setToolTipButton()

        drawer = New Drawer(trace_pb)

        AddBezier()

        My.Settings.Reload()

        If (My.Settings.file_path.Length.Equals(0) And My.Settings.screenshot_path.Length.Equals(0)) Then
            ' SET DEFAULT VALUES
            'Init value params
            form_params = New Form_params(filename_screenshot, auto_incr_screenshot, default_path_screenshot, filename_file, auto_incr_file, default_path_file)

            form_params.Owner = Me
            'Get back parameters
            form_params.getValues(filename_screenshot, auto_incr_screenshot, default_path_screenshot, filename_file, auto_incr_file, default_path_file)

            save_settings()
        Else
            'Restore saved params

            filename_screenshot = My.Settings.screenshot_name
            auto_incr_screenshot = My.Settings.screenshot_auto_incr
            default_path_screenshot = My.Settings.screenshot_path

            filename_file = My.Settings.file_name
            auto_incr_file = My.Settings.file_auto_incr
            default_path_file = My.Settings.file_path
        End If

    End Sub

    Private Sub save_settings()
        My.Settings.screenshot_name = filename_screenshot
        My.Settings.screenshot_auto_incr = auto_incr_screenshot
        My.Settings.screenshot_path = default_path_screenshot

        My.Settings.file_name = filename_file
        My.Settings.file_auto_incr = auto_incr_file
        My.Settings.file_path = default_path_file

        My.Settings.Save()
    End Sub

    Private Sub removeFilesPattern(ByVal screenshot As Boolean)
        'On a besoin du pattern
        'Regarder avec l'auto incr
        Dim pattern As String = ""
        Dim path As String = ""

        If screenshot.Equals(True) Then
            path = default_path_screenshot
            pattern = "*.jpg"
        Else
            path = default_path_file
            pattern = "*.txt"
        End If

        Dim list_files As String() = System.IO.Directory.GetFiles(path, pattern, System.IO.SearchOption.TopDirectoryOnly)

        For Each filename As String In list_files
            My.Computer.FileSystem.DeleteFile(
              filename,
              FileIO.UIOption.OnlyErrorDialogs,
              FileIO.RecycleOption.SendToRecycleBin,
              FileIO.UICancelOption.ThrowException)
        Next



        'On fait la recherche des fichiers et on suppr
    End Sub

    Private Sub bezier_drawing_MouseDown(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseDown
        Dim mouse_point As Point = e.Location()

        Dim mouse_point_converted As PointF = drawer.conversionToMarker(mouse_point)


        ' First we check if the current selected curve is still selected
        Dim point As PointF

        If (Not bezier Is Nothing AndAlso bezier.currentlySelected = True) Then
            If (bezier.selectionPoint(mouse_point_converted, point) = True) Then
                'Our bezier is still selected
                drawer.clearDrawing()
                drawer.drawBeziers(bezier_list, show_name_bezier)
                drawer.drawPoint(New Pen(Color.Red), point, 10, 10)
                Return
            End If
        End If

        For Each bezier_tmp In bezier_list
            If (bezier_tmp.show.Equals(True)) Then
                If (bezier_tmp.selectionPoint(mouse_point_converted, point) = True) Then
                    ' New bezier selected
                    If bezier Is Nothing OrElse Not bezier.Equals(bezier_tmp) Then
                        SetSelectedBezier(bezier_tmp, True) 'Set new current bezier + set as selected item
                    End If

                    If (bezier_tmp.point_selectionne_enum <> Bezier.pointEnum.aucun) Then
                        drawer.clearDrawing()
                        drawer.drawBeziers(bezier_list, show_name_bezier)

                    End If
                    drawer.drawPoint(New Pen(Color.Red), point, 10, 10)
                    Return ' Do it only once
                End If
            End If
        Next

        ' Nothing selected 
        UnSelectBezier()
        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub NumericUpDown_segment_ValueChanged(sender As Object, e As EventArgs) Handles segment_nud.ValueChanged
        If drawer Is Nothing Then
            Return
        End If

        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        bezier.nombre_segment = segment_nud.Value

        drawer.drawBeziers(bezier_list, show_name_bezier)
        ' drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles x_nud_start.ValueChanged, y_nud_start.ValueChanged, y_nud_end.ValueChanged, x_nud_end.ValueChanged, xtg_nud_start.ValueChanged, ytg_nud_start.ValueChanged, xtg_nud_end.ValueChanged, ytg_nud_end.ValueChanged
        If (numeric_indicator_value_changed_trigger = False) Then
            Return
        End If

        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If


        Dim obj As System.Windows.Forms.NumericUpDown = DirectCast(sender, System.Windows.Forms.NumericUpDown)

        If (obj Is x_nud_start) Then
            bezier.p_deb.X = x_nud_start.Value
        ElseIf (obj Is y_nud_start) Then
            bezier.p_deb.Y = y_nud_start.Value
        ElseIf (obj Is xtg_nud_start) Then
            bezier.p_tg_deb.X = xtg_nud_start.Value
        ElseIf (obj Is ytg_nud_start) Then
            bezier.p_tg_deb.Y = ytg_nud_start.Value
        ElseIf (obj Is xtg_nud_end) Then
            bezier.p_tg_fin.X = xtg_nud_end.Value
        ElseIf (obj Is ytg_nud_end) Then
            bezier.p_tg_fin.Y = ytg_nud_end.Value
        ElseIf (obj Is x_nud_end) Then
            bezier.p_fin.X = x_nud_end.Value
        ElseIf (obj Is y_nud_end) Then
            bezier.p_fin.Y = y_nud_end.Value
        End If

        drawer.drawBeziers(bezier_list, show_name_bezier)
        ' drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)

    End Sub

    'Quand la souris se déplace
    Private Sub bezier_drawing_MouseMove(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseMove
        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        Dim mouse_point As Point
        Dim mouse_point_converted As PointF

        If (bezier.point_selectionne_enum <> Bezier.pointEnum.aucun) Then
            numeric_indicator_value_changed_trigger = False
            mouse_point = e.Location()
            mouse_point_converted = drawer.conversionToMarker(mouse_point)

            drawer.drawBeziers(bezier_list, show_name_bezier)
            Try
                Select Case bezier.point_selectionne_enum
                    Case Bezier.pointEnum.p_deb
                        bezier.p_deb = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_deb, 10, 10)
                        x_nud_start.Value = bezier.p_deb.X
                        y_nud_start.Value = bezier.p_deb.Y
                        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
                    Case Bezier.pointEnum.p_fin
                        bezier.p_fin = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_fin, 10, 10)
                        x_nud_end.Value = bezier.p_fin.X
                        y_nud_end.Value = bezier.p_fin.Y
                        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
                    Case Bezier.pointEnum.p_tg_deb
                        bezier.p_tg_deb = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_tg_deb, 10, 10)
                        xtg_nud_start.Value = bezier.p_tg_deb.X
                        ytg_nud_start.Value = bezier.p_tg_deb.Y
                        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
                    Case Bezier.pointEnum.p_tg_fin
                        bezier.p_tg_fin = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_tg_fin, 10, 10)
                        xtg_nud_end.Value = bezier.p_tg_fin.X
                        ytg_nud_end.Value = bezier.p_tg_fin.Y
                        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
                End Select
                'Ralenti
                'curve_lenght_OUTPUT_lb.Text = bezier.getDistance()
            Catch ex As ArgumentOutOfRangeException
                MessageBox.Show("Error:  " & ex.Message.ToString())

                'Déselectionne le point
                bezier.point_selectionne_enum = Bezier.pointEnum.aucun
                drawer.drawBeziers(bezier_list, show_name_bezier)
            End Try

        Else
            numeric_indicator_value_changed_trigger = True
        End If

    End Sub

    'Quand le clic gauche est relaché
    Private Sub bezier_drawing_MouseUp(sender As Object, e As MouseEventArgs) Handles trace_pb.MouseUp
        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        'Déselectionne le point
        bezier.point_selectionne_enum = Bezier.pointEnum.aucun
        drawer.drawBeziers(bezier_list, show_name_bezier)

        curve_lenght_OUTPUT_lb.Text = bezier.getDistance()
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles list_curve_clb.ItemCheck
        Dim state As CheckState = e.NewValue
        Dim index As Integer = e.Index

        If state.Equals(CheckState.Checked) Then
            bezier_list.ElementAt(index).show = True
            ' Set new shown bezier as current bezier
            SetSelectedBezier(bezier_list.ElementAt(index), True)
        Else
            bezier_list.ElementAt(index).show = False
            bezier_list.ElementAt(index).point_selectionne_enum = Bezier.pointEnum.aucun
        End If

        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_curve_clb.SelectedIndexChanged
        If list_curve_clb.SelectedItem Is Nothing Then
            Return
        End If
        ' Avoid trigger 
        If check_selected_index_value_changed_trigger.Equals(False) Then
            Return
        End If

        'Get back uid from string
        For Each bezier_tmp In bezier_list
            If getItemListName(bezier_tmp).Equals(list_curve_clb.SelectedItem) Then
                SetSelectedBezier(bezier_tmp, False) ' Don't select item => It's already done
                drawer.drawBeziers(bezier_list, show_name_bezier)
                Return 'Do it only once
            End If
        Next


    End Sub


    Private Sub AddBezier()

        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        Dim bezier_tmp As New Bezier(New PointF(0, 0), New PointF(0.5, -0.5), New PointF(0.5, 0.8), New PointF(0.5, -0.8), segment_nud.Value, ColorTranslator.FromHtml(hexacode_tb.Text), selected_tb.Text)
        bezier_list.Add(bezier_tmp)

        ' Add it through our list display
        list_curve_clb.Items.Add(getItemListName(bezier_tmp)) ' "Courbe de bézier n° " + Bezier.uid.ToString())
        list_curve_clb.SetItemChecked(bezier_list.Count() - 1, True) ' Set default checked


        SetSelectedBezier(bezier_tmp, True)
        check_selected_index_value_changed_trigger = True

        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub UnSelectBezier()
        If bezier Is Nothing Then
            Return
        End If

        Dim index As Single
        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        index = getIndexListBox(bezier.uid.ToString())
        If index.Equals(-1) Then
            MessageBox.Show("Error index not found on list ")
            Return
        End If
        list_curve_clb.SetSelected(index, False) ' Unselect it

        bezier.currentlySelected = False
        allowUserCtrl(False)
        bezier = Nothing

        check_selected_index_value_changed_trigger = True
    End Sub

    Private Sub allowUserCtrl(ByVal enable As Boolean)
        segment_nud.Enabled = enable
        x_nud_start.Enabled = enable
        y_nud_start.Enabled = enable
        x_nud_end.Enabled = enable
        y_nud_end.Enabled = enable
        xtg_nud_start.Enabled = enable
        xtg_nud_end.Enabled = enable
        ytg_nud_start.Enabled = enable
        ytg_nud_end.Enabled = enable
        pick_color_btn.Enabled = enable
        hexacode_tb.Enabled = enable
        coord_large_tb.Enabled = enable
        coord_thin_tb.Enabled = enable
        selected_tb.Enabled = enable
    End Sub


    Private Sub SetSelectedBezier(ByRef bezier_selected As Bezier, ByVal set_selected_item As Boolean)
        If Not bezier Is Nothing AndAlso bezier_selected.uid.Equals(bezier.uid) Then
            Return
        End If

        bezier_selected.currentlySelected = True

        If (Not bezier Is Nothing) Then
            bezier.currentlySelected = False

            ' Avoid pt control on the last bezier
            bezier.point_selectionne_enum = Bezier.pointEnum.aucun
        End If

        allowUserCtrl(True)

        ' Avoid numeric trigger
        numeric_indicator_value_changed_trigger = False
        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False
        'Avoid text changed trigger on name
        name_changed_trigger = False

        ' Set bezier selected as this one 
        bezier = bezier_selected
        bezier.currentlySelected = True
        ' Refresh display
        x_nud_start.Value = bezier.p_deb.X
        y_nud_start.Value = bezier.p_deb.Y

        x_nud_end.Value = bezier.p_fin.X
        y_nud_end.Value = bezier.p_fin.Y

        xtg_nud_start.Value = bezier.p_tg_deb.X
        ytg_nud_start.Value = bezier.p_tg_deb.Y

        xtg_nud_end.Value = bezier.p_tg_fin.X
        ytg_nud_end.Value = bezier.p_tg_fin.Y

        segment_nud.Value = bezier.nombre_segment
        curve_lenght_OUTPUT_lb.Text = bezier.longueur.ToString(pattern_print_length)
        selected_tb.Text = bezier.nom


        Dim i As Single = 0
        Dim index As Single
        If set_selected_item.Equals(True) Then
            ' Set item as selected
            For i = 0 To list_curve_clb.Items.Count - 1 ' Deselect all
                list_curve_clb.SetSelected(i, False)
            Next
            index = getIndexListBox(bezier.uid.ToString())
            If index.Equals(-1) Then
                MessageBox.Show("Error index not found on list ")
                Return
            End If
            list_curve_clb.SetSelected(index, True) ' Select it

        End If

        numeric_indicator_value_changed_trigger = True
        check_selected_index_value_changed_trigger = True
        name_changed_trigger = True
    End Sub

    ' Return index on list box of specified uid
    Private Function getIndexListBox(ByVal uid As String)
        Dim i As Single = 0
        'For Each item In list_curve_clb.Items
        'If item.Equals(bezier.uid.ToString()) Then
        'Return i
        'End If
        'i += 1
        'Next

        For Each item In list_curve_clb.Items
            If item.Equals(getItemListName(bezier)) Then
                Return i
            End If
            i += 1
        Next

        Return -1 'Not found
    End Function

    Private Function getItemListName(ByRef bezier_tmp As Bezier) As String
        Return (bezier_tmp.uid.ToString() + " : " + bezier_tmp.nom)
    End Function

    'Ajout de courbe de bezier
    Private Sub AddCurve_Click(sender As Object, e As EventArgs) Handles add_curve_btn.Click, AjouterCourbeToolStripMenuItem.Click
        AddBezier()
    End Sub
    'Remove bezier
    Private Sub DeleteCurve_Click(sender As Object, e As EventArgs) Handles delete_curve_btn.Click, SupprimerCourbeToolStripMenuItem.Click
        'Remove selected bezier
        Dim index As Single

        If list_curve_clb.Items.Count <> 0 Then
            ' We can remove this bezier

            index = getIndexListBox(bezier.uid.ToString())
            If index.Equals(-1) Then
                MessageBox.Show("Error index not found on list (remove)")
                Return
            End If


            'Avoid selected index trigger
            check_selected_index_value_changed_trigger = False

            list_curve_clb.Items.RemoveAt(index)
            bezier_list.Remove(bezier)

            check_selected_index_value_changed_trigger = True


            drawer.drawBeziers(bezier_list, show_name_bezier)
        End If
    End Sub
    ' Show bezier name on each
    Private Sub CurveInfo_Click(sender As Object, e As EventArgs) Handles curve_info_btn.Click, InfoCoubesToolStripMenuItem.Click
        show_name_bezier = Not show_name_bezier
        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    ' Save jpeg
    Private Sub TakeScreenshot_Click(sender As Object, e As EventArgs) Handles take_screenshot_btn.Click, PrendreUnCaptureToolStripMenuItem.Click
        ' Si nom empty => On ouvre l'explorateur et l'utiisateur choisit
        If (auto_incr_screenshot.Equals(False)) Then
            drawer.saveDrawing(default_path_screenshot)
        Else
            ' Auto-incr checked
            Dim complete_path As String = Form_params.getCompleteFilename(default_path_screenshot, True, filename_screenshot)
            Dim img As Bitmap = DrawFilledRectangle(1280, trace_pb.Image.Height)
            drawer.drawStringBezierList(img, bezier_list)
            CombineImages(CombineBG_FG(trace_pb.BackgroundImage, trace_pb.Image), img).Save(complete_path, Imaging.ImageFormat.Jpeg)
            MessageBox.Show("Courbe enregistrée avec succès à : " + complete_path)
        End If

    End Sub


    ' Read
    Private Sub LoadFile_Click(sender As Object, e As EventArgs) Handles load_file_btn.Click, OuvrirBezierToolStripMenuItem.Click

        Dim sfdPic As New OpenFileDialog()
        Dim Path As String = default_path_file

        Dim title As String = "Ouvrir l'ensemble de courbes"
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information

        Try

            With sfdPic
                .Title = "Ouvre les courbes sous"
                .Filter = "Fichiers texte (*.txt)|*.txt"
                .AddExtension = True
                .DefaultExt = ".txt"
                '.FileName = "ma_liste_de_courbes.txt"
                .ValidateNames = True
                .InitialDirectory = Path
                .RestoreDirectory = True
                .CheckFileExists = True
                .ReadOnlyChecked = True
                .CheckPathExists = True

                If .ShowDialog = DialogResult.OK Then
                    bezier_list = Bezier.ReadAll(sfdPic.FileName)
                    MessageBox.Show("Courbes lues avec succès à : " + sfdPic.FileName)
                Else
                    Return
                End If

            End With
        Catch ex As Exception
            MessageBox.Show("Error: Reading Failed -> " & ex.Message.ToString())
            Return
        Finally
            sfdPic.Dispose()
        End Try

        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        'Clear all last items 
        list_curve_clb.Items.Clear()

        For Each bezier_tmp As Bezier In bezier_list
            ' Add it through our list display
            list_curve_clb.Items.Add(getItemListName(bezier_tmp)) ' "Courbe de bézier n° " + Bezier.uid.ToString())
            list_curve_clb.SetItemChecked(list_curve_clb.Items.Count() - 1, bezier_tmp.show) ' Set default checked
        Next

        SetSelectedBezier(bezier_list(bezier_list.Count - 1), True)


        check_selected_index_value_changed_trigger = True

        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    'Save bezier list
    Private Sub SaveFile_Click(sender As Object, e As EventArgs) Handles save_file_btn.Click, EnregistrerBezierToolStripMenuItem.Click
        ' Using params for file section

        ' Si nom empty => On ouvre l'explorateur et l'utiisateur choisit
        If (auto_incr_file.Equals(False)) Then
            Dim sfdPic As New SaveFileDialog()
            Dim Path As String = default_path_file

            Dim title As String = "Sauvegarde des courbes"
            Dim btn = MessageBoxButtons.YesNo
            Dim ico = MessageBoxIcon.Information

            Try

                With sfdPic
                    .Title = "Enregistre les courbes sous"
                    .Filter = "Fichiers texte (*.txt)|*.txt"
                    .AddExtension = True
                    .DefaultExt = ".txt"
                    .FileName = "ma_liste_de_courbes.txt"
                    .ValidateNames = True
                    .OverwritePrompt = True
                    .InitialDirectory = Path
                    .RestoreDirectory = True

                    If .ShowDialog = DialogResult.OK Then
                        Bezier.WriteAll(bezier_list, sfdPic.FileName)
                        MessageBox.Show("Courbe enregistrée avec succès à : " + sfdPic.FileName)
                    Else
                        Return
                    End If

                End With
            Catch ex As Exception
                MessageBox.Show("Error: Saving Failed -> " & ex.Message.ToString())
            Finally
                sfdPic.Dispose()
            End Try
        Else
            ' Auto-incr checked
            Dim complete_path As String = Form_params.getCompleteFilename(default_path_file, False, filename_file)
            Bezier.WriteAll(bezier_list, complete_path)
            MessageBox.Show("Courbe enregistrée avec succès à : " + complete_path)

        End If

    End Sub

    Private Sub Button_params_Click(sender As Object, e As EventArgs) Handles parameter_btn.Click, ParamètresToolStripMenuItem.Click
        form_params = New Form_params(filename_screenshot, auto_incr_screenshot, default_path_screenshot, filename_file, auto_incr_file, default_path_file)

        form_params.Owner = Me

        ' We can only interact with this dialog ! 
        form_params.ShowDialog()

        'Get back parameters
        form_params.getValues(filename_screenshot, auto_incr_screenshot, default_path_screenshot, filename_file, auto_incr_file, default_path_file)

        save_settings()
    End Sub

    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles delete_file_btn.Click, SupprimerFichiersBezierToolStripMenuItem.Click
        Dim form As Form_delete = New Form_delete()

        form.Owner = Me

        If (form.ShowDialog() = DialogResult.OK) Then
            Dim delete_screenshot As Boolean
            Dim delete_files As Boolean

            form.getResult(delete_screenshot, delete_files)

            'Remove screenshots
            If (delete_screenshot.Equals(True)) Then
                Dim result As DialogResult = MessageBox.Show("Do you really want to remove all .jpeg files in " + default_path_screenshot + "?", "REMOVE", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    removeFilesPattern(True)
                    MessageBox.Show("Files .jpeg removed successfully")
                Else
                    MessageBox.Show("Operation cancelled")
                End If

            End If

            'Removes files
            If (delete_files.Equals(True)) Then
                Dim result As DialogResult = MessageBox.Show("Do you really want to remove all .txt files in " + default_path_file + "?", "REMOVE", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    removeFilesPattern(False)
                    MessageBox.Show("Files .txt removed successfully")
                Else
                    MessageBox.Show("Operation cancelled")
                End If

            End If
        End If



    End Sub

    Private Sub Button_list_bezier_Click(sender As Object, e As EventArgs) Handles curve_list_btn.Click, InfoCourbesToolStripMenuItem.Click
        Dim form As FormListDisplayBezier = New FormListDisplayBezier(bezier_list)

        form.Owner = Me
        form.ShowDialog()

    End Sub

    Public Function CombineBG_FG(ByRef bg As Image, ByRef fg As Image) As Image
        If (bg.Width <> fg.Width Or bg.Height <> fg.Height) Then
            Return Nothing
        End If

        Dim bmp As New Bitmap(bg.Width, bg.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(bg, 0, 0, bg.Width, bg.Height)
        g.DrawImage(fg, 0, 0, bg.Width, bg.Width)
        g.Dispose()

        Return bmp
    End Function

    Public Function CombineImages(ByVal img1 As Image, ByVal img2 As Image) As Image
        Dim bmp As New Bitmap(Math.Max(img1.Width, img2.Width), img1.Height + img2.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.DrawImage(img1, 0, 0, img2.Width, img1.Height)
        g.DrawImage(img2, 0, img1.Height, img2.Width, img2.Width)
        g.Dispose()

        Return bmp
    End Function

    Private Function DrawFilledRectangle(ByVal x As Integer, ByVal y As Integer)
        Dim bmp As Bitmap = New Bitmap(x, y)
        Using graph As Graphics = Graphics.FromImage(bmp)
            Dim ImageSize As Rectangle = New Rectangle(0, 0, x, y)
            graph.FillRectangle(Brushes.White, ImageSize)
        End Using
        Return bmp
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles zoom_in_btn.Click
        'tracePB.Size = New System.Drawing.Size(140, 140)
        tracePBW = tracePBW * 1.1
        tracePBH = tracePBH * 1.1

        trace_pb.Image = New Bitmap(tracePBI, tracePBW, tracePBH)


    End Sub

    Private Sub zoom_out_Click(sender As Object, e As EventArgs) Handles zoom_reset_btn.Click, zoom_out_btn.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles pick_color_btn.Click, CouleurToolStripMenuItem.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = curve_length_lb.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_pb.BackColor = cDialog.Color ' update with user selected color.
            color = cDialog.Color

            'hexacode_tb.Text = "#" & String.Format("{0:00}", Hex(color.R)) & String.Format("{1:00}", Hex(color.G)) & String.Format("{2:00}", Hex(color.B))
            hexacode_tb.Text = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)

            'Change color
            bezier.couleur = color

            drawer.drawBeziers(bezier_list, show_name_bezier)

        End If
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

                'Change color
                bezier.couleur = color

                drawer.drawBeziers(bezier_list, show_name_bezier)

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

        setToolTipButton()

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

    Private Sub setToolTipButton()
        Dim button_list As Button() = {load_file_btn, save_file_btn, take_screenshot_btn, browse_screenshot_btn, delete_file_btn, zoom_in_btn, zoom_out_btn, zoom_reset_btn, hide_grid_btn, add_curve_btn, hide_curve_btn, delete_curve_btn, delete_all_curve_btn, curve_info_btn, curve_list_btn, parameter_btn, pick_color_btn}
        Dim french_text_list As String() = {"Ouvrir Bezier", "Enregistrer Bezier", "Prendre une capture", "Parcourir les captures", "Supprimer fichiers Bezier", "Zoom +", "Zoom -", "Zoom défaut", "Afficher/ Cacher grille", "Ajouter courbe", "Masquer courbe", "Supprimer courbe", "Supprimer toutes les courbes", "Numéro courbes", "Info courbes", "Paramètres", "Choix couleur courbe"}
        Dim english_text_list As String() = {"Open Bezier", "Save Bezier", "Take screenshot", "Browse screenshots", "Delete Bezier File", "Zoom +", "Zoom -", "Zoom default", "Show/ Hide grid", "Add curve", "Hide curve", "Delete curve", "Delete all curves", "Curves index", "Curves list info", "Settings", "Curves color"}

        If (Not ToolTip1 Is Nothing) Then
            ToolTip1.Dispose()
        End If

        ToolTip1 = New System.Windows.Forms.ToolTip()

        ToolTip1.RemoveAll()

        For i As Single = 0 To button_list.Length - 1
            If (Me.language.Equals("fr-FR")) Then
                ToolTip1.SetToolTip(button_list(i), french_text_list(i))
            Else
                ToolTip1.SetToolTip(button_list(i), english_text_list(i))
            End If

        Next
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

    Private Sub NoticeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoticeToolStripMenuItem.Click
        Dim FByte() As Byte = My.Resources.Notice
        Dim path As String
        Dim name As String = "\Notice.pdf"

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            path = FolderBrowserDialog1.SelectedPath
            If language.Equals("fr-FR") Then
                MessageBox.Show("La notice à été sauvegarder à l'endroit suivant : " & vbCrLf & path, "Information")
            Else
                MessageBox.Show("The notice was saved at the following location : " & vbCrLf & path, "Information")
            End If
            My.Computer.FileSystem.WriteAllBytes(path & name, FByte, True)
        End If

    End Sub

    Private Sub browse_screenshot_btn_Click(sender As Object, e As EventArgs) Handles browse_screenshot_btn.Click, ParcourirCaptureToolStripMenuItem.Click
        Process.Start("explorer.exe", String.Format("/n, /e, {0}", default_path_screenshot)) 'Open explorer with screenshot path
    End Sub

    Private Sub hide_grid_btn_Click(sender As Object, e As EventArgs) Handles hide_grid_btn.Click, AfficherGrilleToolStripMenuItem.Click
        hide_show_grid = Not hide_show_grid
        drawer.HideShowGrid(hide_show_grid)
    End Sub

    Private Sub hide_curve_btn_Click(sender As Object, e As EventArgs) Handles hide_curve_btn.Click, MasquerCourbeToolStripMenuItem.Click
        check_selected_index_value_changed_trigger = False

        Dim index As Integer = getIndexListBox(bezier.uid)

        If index = -1 Then
            Return
        End If

        If bezier.show.Equals(False) Then
            bezier.show = True
            ' Set new shown bezier as current bezier
            SetSelectedBezier(bezier, True)
        Else
            bezier.show = False
            bezier.point_selectionne_enum = Bezier.pointEnum.aucun
        End If

        list_curve_clb.SetItemChecked(index, bezier.show)

        drawer.drawBeziers(bezier_list, show_name_bezier)
        check_selected_index_value_changed_trigger = True
    End Sub

    Private Sub delete_all_curve_btn_Click(sender As Object, e As EventArgs) Handles delete_all_curve_btn.Click, SupprimerToutesLesCourbesToolStripMenuItem.Click
        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        list_curve_clb.Items.Clear()
        bezier_list.Clear()
        Bezier.compteur_courbe = 0 'Reset counter
        check_selected_index_value_changed_trigger = True


        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub selected_tb_TextChanged(sender As Object, e As EventArgs) Handles selected_tb.TextChanged
        If (bezier Is Nothing Or name_changed_trigger = False) Then
            Return
        End If

        'Update list item
        Dim index As Integer = getIndexListBox(bezier.uid)

        bezier.nom = selected_tb.Text 'Change name after getting index (depend of name)

        check_selected_index_value_changed_trigger = False
        list_curve_clb.Items(index) = getItemListName(bezier)
        check_selected_index_value_changed_trigger = True
    End Sub
End Class
