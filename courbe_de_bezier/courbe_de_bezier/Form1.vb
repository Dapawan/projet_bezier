Imports System.Drawing.Drawing2D

Public Class Form1

    Dim drawer As Drawer
    Dim bezier As Bezier 'Current bezier
    Dim bezier_list As New List(Of Bezier)

    Dim numeric_indicator_value_changed_trigger As Boolean = False
    Dim check_selected_index_value_changed_trigger As Boolean = False

    Dim show_name_bezier As Boolean = True

    Public Sub New()
        InitializeComponent()

        drawer = New Drawer(bezier_drawing)

        AddBezier()

        ComboBoxColor.SelectedIndex = 0
        ' drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        ' NumericUpDown_longueur.Value = bezier.getDistance(

        ' Save img 
        ' drawer.saveDrawing()

    End Sub

    Private Sub bezier_drawing_MouseDown(sender As Object, e As MouseEventArgs) Handles bezier_drawing.MouseDown
        Dim mouse_point As Point = e.Location()

        Dim mouse_point_converted As PointF = drawer.conversionToMarker(mouse_point)



        Dim point As PointF
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
        ' Dim mouse_point_converted_ As New PointF

        ' mouse_point_converted_.X = mouse_point_converted.X - 10
        ' mouse_point_converted_.Y = mouse_point_converted.Y - 10

        ' drawer.drawLine(New Pen(Color.Violet), mouse_point_converted, mouse_point_converted_)
    End Sub

    Private Sub NumericUpDown_segment_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_segment.ValueChanged, NumericUpDown_longueur.ValueChanged
        If drawer Is Nothing Then
            Return
        End If

        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        bezier.nombre_segment = NumericUpDown_segment.Value

        drawer.drawBeziers(bezier_list, show_name_bezier)
        ' drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        NumericUpDown_longueur.Value = bezier.longueur
    End Sub

    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_x_deb.ValueChanged, NumericUpDown_y_deb.ValueChanged, NumericUpDown_y_fin.ValueChanged, NumericUpDown_x_fin.ValueChanged, NumericUpDown_x_deb_tg.ValueChanged, NumericUpDown_y_deb_tg.ValueChanged, NumericUpDown_x_fin_tg.ValueChanged, NumericUpDown_y_fin_tg.ValueChanged
        If (numeric_indicator_value_changed_trigger = False) Then
            Return
        End If

        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If


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

        drawer.drawBeziers(bezier_list, show_name_bezier)
        ' drawer.drawBezierFromLib(New Pen(Color.Red), bezier)

        NumericUpDown_longueur.Value = bezier.longueur

    End Sub

    'Quand la souris se déplace
    Private Sub bezier_drawing_MouseMove(sender As Object, e As MouseEventArgs) Handles bezier_drawing.MouseMove
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
                        NumericUpDown_x_deb.Value = bezier.p_deb.X
                        NumericUpDown_y_deb.Value = bezier.p_deb.Y
                        NumericUpDown_longueur.Value = bezier.longueur
                    Case Bezier.pointEnum.p_fin
                        bezier.p_fin = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_fin, 10, 10)
                        NumericUpDown_x_fin.Value = bezier.p_fin.X
                        NumericUpDown_y_fin.Value = bezier.p_fin.Y
                        NumericUpDown_longueur.Value = bezier.longueur
                    Case Bezier.pointEnum.p_tg_deb
                        bezier.p_tg_deb = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_tg_deb, 10, 10)
                        NumericUpDown_x_deb_tg.Value = bezier.p_tg_deb.X
                        NumericUpDown_y_deb_tg.Value = bezier.p_tg_deb.Y
                        NumericUpDown_longueur.Value = bezier.longueur
                    Case Bezier.pointEnum.p_tg_fin
                        bezier.p_tg_fin = mouse_point_converted
                        drawer.drawPoint(New Pen(Color.Red), bezier.p_tg_fin, 10, 10)
                        NumericUpDown_x_fin_tg.Value = bezier.p_tg_fin.X
                        NumericUpDown_y_fin_tg.Value = bezier.p_tg_fin.Y
                        NumericUpDown_longueur.Value = bezier.longueur
                End Select
                'Ralenti
                'NumericUpDown_longueur.Value = bezier.getDistance()
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
    Private Sub bezier_drawing_MouseUp(sender As Object, e As MouseEventArgs) Handles bezier_drawing.MouseUp
        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        'Déselectionne le point
        bezier.point_selectionne_enum = Bezier.pointEnum.aucun
        drawer.drawBeziers(bezier_list, show_name_bezier)

        NumericUpDown_longueur.Value = bezier.getDistance()
    End Sub

    Private Sub ComboBoxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColor.SelectedIndexChanged
        If bezier Is Nothing Then 'Do nothing if there isn't any bezier selected
            Return
        End If

        bezier.couleur = getColorCombobox()

        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        'Get new selected item
        ' Dim test As Object = CheckedListBox1.SelectedItem
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

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedItem Is Nothing Then
            Return
        End If
        ' Avoid trigger 
        If check_selected_index_value_changed_trigger.Equals(False) Then
            Return
        End If

        'Get back uid from string
        Dim uid As Single = Single.Parse(CheckedListBox1.SelectedItem)
        For Each bezier_tmp In bezier_list
            If bezier_tmp.uid.Equals(uid) Then
                SetSelectedBezier(bezier_tmp, False) ' Don't select item => It's already done
                Return 'Do it only once
            End If
        Next
    End Sub

    'Ajout de courbe de bezier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBezier()
    End Sub

    ' Show bezier name on each
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        show_name_bezier = Not show_name_bezier
        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    ' Save jpeg
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        drawer.saveDrawing()
    End Sub

    Private Sub AddBezier()

        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        Dim bezier_tmp As New Bezier(New PointF(0, 0), New PointF(0.5, -0.5), New PointF(0.5, 0.8), New PointF(0.5, -0.8), NumericUpDown_segment.Value, getColorCombobox())
        bezier_list.Add(bezier_tmp)

        ' Add it through our list display
        CheckedListBox1.Items.Add(bezier_tmp.uid.ToString()) ' "Courbe de bézier n° " + Bezier.uid.ToString())
        CheckedListBox1.SetItemChecked(bezier_list.Count() - 1, True) ' Set default checked


        SetSelectedBezier(bezier_tmp, True)
        check_selected_index_value_changed_trigger = True

        drawer.drawBeziers(bezier_list, show_name_bezier)
    End Sub

    Private Sub UnSelectBezier()
        Dim index As Single
        'Avoid selected index trigger
        check_selected_index_value_changed_trigger = False

        index = getIndexListBox(bezier.uid.ToString())
        If index.Equals(-1) Then
            MessageBox.Show("Error index not found on list ")
            Return
        End If
        CheckedListBox1.SetSelected(index, False) ' Unselect it

        bezier.currentlySelected = False
        allowUserCtrl(False)
        bezier = Nothing

        check_selected_index_value_changed_trigger = True
    End Sub

    Private Sub allowUserCtrl(ByVal enable As Boolean)
        NumericUpDown_segment.Enabled = enable
        NumericUpDown_x_deb.Enabled = enable
        NumericUpDown_y_deb.Enabled = enable
        NumericUpDown_x_fin.Enabled = enable
        NumericUpDown_y_fin.Enabled = enable
        NumericUpDown_x_deb_tg.Enabled = enable
        NumericUpDown_x_fin_tg.Enabled = enable
        NumericUpDown_y_deb_tg.Enabled = enable
        NumericUpDown_y_fin_tg.Enabled = enable
        ComboBoxColor.Enabled = enable
    End Sub


    Private Sub SetSelectedBezier(ByRef bezier_selected As Bezier, ByVal set_selected_item As Boolean)
        If bezier_selected.Equals(bezier) Then
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
        ' Set bezier selected as this one 
        bezier = bezier_selected
        ' Refresh display
        NumericUpDown_x_deb.Value = bezier.p_deb.X
        NumericUpDown_y_deb.Value = bezier.p_deb.Y

        NumericUpDown_x_fin.Value = bezier.p_fin.X
        NumericUpDown_y_fin.Value = bezier.p_fin.Y

        NumericUpDown_x_deb_tg.Value = bezier.p_tg_deb.X
        NumericUpDown_y_deb_tg.Value = bezier.p_tg_deb.Y

        NumericUpDown_x_fin_tg.Value = bezier.p_tg_fin.X
        NumericUpDown_y_fin_tg.Value = bezier.p_tg_fin.Y

        NumericUpDown_segment.Value = bezier.nombre_segment
        NumericUpDown_longueur.Value = bezier.longueur

        Dim i As Single = 0
        Dim index As Single
        If set_selected_item.Equals(True) Then
            ' Set item as selected
            For i = 0 To CheckedListBox1.Items.Count - 1 ' Deselect all
                CheckedListBox1.SetSelected(i, False)
            Next
            index = getIndexListBox(bezier.uid.ToString())
            If index.Equals(-1) Then
                MessageBox.Show("Error index not found on list ")
                Return
            End If
            CheckedListBox1.SetSelected(index, True) ' Select it

        End If

        numeric_indicator_value_changed_trigger = True
        check_selected_index_value_changed_trigger = True
    End Sub

    ' Return index on list box of specified uid
    Private Function getIndexListBox(ByVal uid As String)
        Dim i As Single = 0
        For Each item In CheckedListBox1.Items
            If item.Equals(bezier.uid.ToString()) Then
                Return i
            End If
            i += 1
        Next
        Return -1 'Not found
    End Function

    Private Function getColorCombobox()
        If ComboBoxColor.SelectedItem Is Nothing Then
            Return Color.Black
        End If

        If ComboBoxColor.SelectedItem.Equals("Rouge") Then
            Return Color.Red
        ElseIf ComboBoxColor.SelectedItem.Equals("Bleu") Then
            Return Color.Blue
        ElseIf ComboBoxColor.SelectedItem.Equals("Vert") Then
            Return Color.Green
        End If

        Return Color.Black
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Remove selected bezier
        Dim index As Single

        If CheckedListBox1.Items.Count <> 0 Then
            ' We can remove this bezier

            index = getIndexListBox(bezier.uid.ToString())
            If index.Equals(-1) Then
                MessageBox.Show("Error index not found on list (remove)")
                Return
            End If


            'Avoid selected index trigger
            check_selected_index_value_changed_trigger = False

            CheckedListBox1.Items.RemoveAt(index)
            bezier_list.Remove(bezier)

            check_selected_index_value_changed_trigger = True


            drawer.drawBeziers(bezier_list, show_name_bezier)
        End If
    End Sub
End Class
