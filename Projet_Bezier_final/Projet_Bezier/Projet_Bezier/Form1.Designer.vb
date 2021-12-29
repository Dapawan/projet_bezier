<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.x_nud_start = New System.Windows.Forms.NumericUpDown()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.curve_length_lb = New System.Windows.Forms.Label()
        Me.hexacode_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.list_curve_clb = New System.Windows.Forms.CheckedListBox()
        Me.y_nud_start = New System.Windows.Forms.NumericUpDown()
        Me.xtg_nud_start = New System.Windows.Forms.NumericUpDown()
        Me.ytg_nud_start = New System.Windows.Forms.NumericUpDown()
        Me.coord_extremity_lb = New System.Windows.Forms.Label()
        Me.x_X_lb_start = New System.Windows.Forms.Label()
        Me.y_Y_lb_start = New System.Windows.Forms.Label()
        Me.xtg_X_lb_start = New System.Windows.Forms.Label()
        Me.ytg_Y_lb_start = New System.Windows.Forms.Label()
        Me.coord_tan_lb = New System.Windows.Forms.Label()
        Me.curve_lenght_L_lb = New System.Windows.Forms.Label()
        Me.coord_large_tb = New System.Windows.Forms.TrackBar()
        Me.y_Y_lb_end = New System.Windows.Forms.Label()
        Me.x_X_lb_end = New System.Windows.Forms.Label()
        Me.y_nud_end = New System.Windows.Forms.NumericUpDown()
        Me.x_nud_end = New System.Windows.Forms.NumericUpDown()
        Me.ytg_Y_lb_end = New System.Windows.Forms.Label()
        Me.xtg_X_lb_end = New System.Windows.Forms.Label()
        Me.ytg_nud_end = New System.Windows.Forms.NumericUpDown()
        Me.xtg_nud_end = New System.Windows.Forms.NumericUpDown()
        Me.point_begin_ext_lb = New System.Windows.Forms.Label()
        Me.point_end_ext_lb = New System.Windows.Forms.Label()
        Me.point_end_tan_lb = New System.Windows.Forms.Label()
        Me.point_begin_tan_lb = New System.Windows.Forms.Label()
        Me.coord_thin_tb = New System.Windows.Forms.TrackBar()
        Me.diz_selector_lb = New System.Windows.Forms.Label()
        Me.cent_selector_lb = New System.Windows.Forms.Label()
        Me.LargeLB = New System.Windows.Forms.Label()
        Me.ThinLB = New System.Windows.Forms.Label()
        Me.seg_number_S_lb = New System.Windows.Forms.Label()
        Me.seg_number_lb = New System.Windows.Forms.Label()
        Me.segment_nud = New System.Windows.Forms.NumericUpDown()
        Me.selected_tb = New System.Windows.Forms.TextBox()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirBezierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerBezierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerFichiersBezierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrendreUnCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParcourirCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterCourbeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasquerCourbeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerCourbeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToutesLesCourbesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouleurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.main_menu_ms = New System.Windows.Forms.MenuStrip()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomDefautToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherGrilleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoCoubesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoCourbesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoticeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LangueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrançaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnglaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.x_Xind_lb_start = New System.Windows.Forms.Label()
        Me.y_Yind_lb_start = New System.Windows.Forms.Label()
        Me.xtg_Xind_lb_start = New System.Windows.Forms.Label()
        Me.ytg_Yind_lb_start = New System.Windows.Forms.Label()
        Me.ytg_Yind_lb_end = New System.Windows.Forms.Label()
        Me.xtg_Xind_lb_end = New System.Windows.Forms.Label()
        Me.y_Yind_lb_end = New System.Windows.Forms.Label()
        Me.x_Xind_lb_end = New System.Windows.Forms.Label()
        Me.curve_lenght_OUTPUT_lb = New System.Windows.Forms.Label()
        Me.parameter_btn = New System.Windows.Forms.Button()
        Me.save_file_btn = New System.Windows.Forms.Button()
        Me.browse_screenshot_btn = New System.Windows.Forms.Button()
        Me.load_file_btn = New System.Windows.Forms.Button()
        Me.curve_list_btn = New System.Windows.Forms.Button()
        Me.curve_info_btn = New System.Windows.Forms.Button()
        Me.hide_curve_btn = New System.Windows.Forms.Button()
        Me.delete_all_curve_btn = New System.Windows.Forms.Button()
        Me.color_pb = New System.Windows.Forms.PictureBox()
        Me.pick_color_btn = New System.Windows.Forms.Button()
        Me.take_screenshot_btn = New System.Windows.Forms.Button()
        Me.delete_curve_btn = New System.Windows.Forms.Button()
        Me.add_curve_btn = New System.Windows.Forms.Button()
        Me.delete_file_btn = New System.Windows.Forms.Button()
        Me.zoom_out_btn = New System.Windows.Forms.Button()
        Me.hide_grid_btn = New System.Windows.Forms.Button()
        Me.zoom_reset_btn = New System.Windows.Forms.Button()
        Me.zoom_in_btn = New System.Windows.Forms.Button()
        Me.trace_pb = New System.Windows.Forms.PictureBox()
        Me.curve_select_name_lb = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.x_nud_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.y_nud_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtg_nud_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ytg_nud_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coord_large_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.y_nud_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_nud_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ytg_nud_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xtg_nud_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coord_thin_tb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segment_nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main_menu_ms.SuspendLayout()
        CType(Me.color_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trace_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'x_nud_start
        '
        Me.x_nud_start.DecimalPlaces = 2
        resources.ApplyResources(Me.x_nud_start, "x_nud_start")
        Me.x_nud_start.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.x_nud_start.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.x_nud_start.Name = "x_nud_start"
        '
        'curve_length_lb
        '
        resources.ApplyResources(Me.curve_length_lb, "curve_length_lb")
        Me.curve_length_lb.Name = "curve_length_lb"
        '
        'hexacode_tb
        '
        resources.ApplyResources(Me.hexacode_tb, "hexacode_tb")
        Me.hexacode_tb.Name = "hexacode_tb"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'list_curve_clb
        '
        resources.ApplyResources(Me.list_curve_clb, "list_curve_clb")
        Me.list_curve_clb.FormattingEnabled = True
        Me.list_curve_clb.Name = "list_curve_clb"
        '
        'y_nud_start
        '
        Me.y_nud_start.DecimalPlaces = 2
        resources.ApplyResources(Me.y_nud_start, "y_nud_start")
        Me.y_nud_start.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.y_nud_start.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.y_nud_start.Name = "y_nud_start"
        '
        'xtg_nud_start
        '
        Me.xtg_nud_start.DecimalPlaces = 2
        resources.ApplyResources(Me.xtg_nud_start, "xtg_nud_start")
        Me.xtg_nud_start.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.xtg_nud_start.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.xtg_nud_start.Name = "xtg_nud_start"
        '
        'ytg_nud_start
        '
        Me.ytg_nud_start.DecimalPlaces = 2
        resources.ApplyResources(Me.ytg_nud_start, "ytg_nud_start")
        Me.ytg_nud_start.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ytg_nud_start.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ytg_nud_start.Name = "ytg_nud_start"
        '
        'coord_extremity_lb
        '
        resources.ApplyResources(Me.coord_extremity_lb, "coord_extremity_lb")
        Me.coord_extremity_lb.Name = "coord_extremity_lb"
        '
        'x_X_lb_start
        '
        resources.ApplyResources(Me.x_X_lb_start, "x_X_lb_start")
        Me.x_X_lb_start.Name = "x_X_lb_start"
        '
        'y_Y_lb_start
        '
        resources.ApplyResources(Me.y_Y_lb_start, "y_Y_lb_start")
        Me.y_Y_lb_start.Name = "y_Y_lb_start"
        '
        'xtg_X_lb_start
        '
        resources.ApplyResources(Me.xtg_X_lb_start, "xtg_X_lb_start")
        Me.xtg_X_lb_start.Name = "xtg_X_lb_start"
        '
        'ytg_Y_lb_start
        '
        resources.ApplyResources(Me.ytg_Y_lb_start, "ytg_Y_lb_start")
        Me.ytg_Y_lb_start.Name = "ytg_Y_lb_start"
        '
        'coord_tan_lb
        '
        resources.ApplyResources(Me.coord_tan_lb, "coord_tan_lb")
        Me.coord_tan_lb.Name = "coord_tan_lb"
        '
        'curve_lenght_L_lb
        '
        resources.ApplyResources(Me.curve_lenght_L_lb, "curve_lenght_L_lb")
        Me.curve_lenght_L_lb.Name = "curve_lenght_L_lb"
        '
        'coord_large_tb
        '
        resources.ApplyResources(Me.coord_large_tb, "coord_large_tb")
        Me.coord_large_tb.Name = "coord_large_tb"
        '
        'y_Y_lb_end
        '
        resources.ApplyResources(Me.y_Y_lb_end, "y_Y_lb_end")
        Me.y_Y_lb_end.Name = "y_Y_lb_end"
        '
        'x_X_lb_end
        '
        resources.ApplyResources(Me.x_X_lb_end, "x_X_lb_end")
        Me.x_X_lb_end.Name = "x_X_lb_end"
        '
        'y_nud_end
        '
        Me.y_nud_end.DecimalPlaces = 2
        resources.ApplyResources(Me.y_nud_end, "y_nud_end")
        Me.y_nud_end.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.y_nud_end.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.y_nud_end.Name = "y_nud_end"
        '
        'x_nud_end
        '
        Me.x_nud_end.DecimalPlaces = 2
        resources.ApplyResources(Me.x_nud_end, "x_nud_end")
        Me.x_nud_end.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.x_nud_end.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.x_nud_end.Name = "x_nud_end"
        '
        'ytg_Y_lb_end
        '
        resources.ApplyResources(Me.ytg_Y_lb_end, "ytg_Y_lb_end")
        Me.ytg_Y_lb_end.Name = "ytg_Y_lb_end"
        '
        'xtg_X_lb_end
        '
        resources.ApplyResources(Me.xtg_X_lb_end, "xtg_X_lb_end")
        Me.xtg_X_lb_end.Name = "xtg_X_lb_end"
        '
        'ytg_nud_end
        '
        Me.ytg_nud_end.DecimalPlaces = 2
        resources.ApplyResources(Me.ytg_nud_end, "ytg_nud_end")
        Me.ytg_nud_end.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ytg_nud_end.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ytg_nud_end.Name = "ytg_nud_end"
        '
        'xtg_nud_end
        '
        Me.xtg_nud_end.DecimalPlaces = 2
        resources.ApplyResources(Me.xtg_nud_end, "xtg_nud_end")
        Me.xtg_nud_end.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.xtg_nud_end.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.xtg_nud_end.Name = "xtg_nud_end"
        '
        'point_begin_ext_lb
        '
        resources.ApplyResources(Me.point_begin_ext_lb, "point_begin_ext_lb")
        Me.point_begin_ext_lb.Name = "point_begin_ext_lb"
        '
        'point_end_ext_lb
        '
        resources.ApplyResources(Me.point_end_ext_lb, "point_end_ext_lb")
        Me.point_end_ext_lb.Name = "point_end_ext_lb"
        '
        'point_end_tan_lb
        '
        resources.ApplyResources(Me.point_end_tan_lb, "point_end_tan_lb")
        Me.point_end_tan_lb.Name = "point_end_tan_lb"
        '
        'point_begin_tan_lb
        '
        resources.ApplyResources(Me.point_begin_tan_lb, "point_begin_tan_lb")
        Me.point_begin_tan_lb.Name = "point_begin_tan_lb"
        '
        'coord_thin_tb
        '
        resources.ApplyResources(Me.coord_thin_tb, "coord_thin_tb")
        Me.coord_thin_tb.Maximum = 9
        Me.coord_thin_tb.Name = "coord_thin_tb"
        '
        'diz_selector_lb
        '
        resources.ApplyResources(Me.diz_selector_lb, "diz_selector_lb")
        Me.diz_selector_lb.Name = "diz_selector_lb"
        '
        'cent_selector_lb
        '
        resources.ApplyResources(Me.cent_selector_lb, "cent_selector_lb")
        Me.cent_selector_lb.Name = "cent_selector_lb"
        '
        'LargeLB
        '
        resources.ApplyResources(Me.LargeLB, "LargeLB")
        Me.LargeLB.Name = "LargeLB"
        '
        'ThinLB
        '
        resources.ApplyResources(Me.ThinLB, "ThinLB")
        Me.ThinLB.Name = "ThinLB"
        '
        'seg_number_S_lb
        '
        resources.ApplyResources(Me.seg_number_S_lb, "seg_number_S_lb")
        Me.seg_number_S_lb.Name = "seg_number_S_lb"
        '
        'seg_number_lb
        '
        resources.ApplyResources(Me.seg_number_lb, "seg_number_lb")
        Me.seg_number_lb.Name = "seg_number_lb"
        '
        'segment_nud
        '
        resources.ApplyResources(Me.segment_nud, "segment_nud")
        Me.segment_nud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.segment_nud.Name = "segment_nud"
        Me.segment_nud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'selected_tb
        '
        resources.ApplyResources(Me.selected_tb, "selected_tb")
        Me.selected_tb.Name = "selected_tb"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirBezierToolStripMenuItem, Me.EnregistrerBezierToolStripMenuItem, Me.SupprimerFichiersBezierToolStripMenuItem, Me.PrendreUnCaptureToolStripMenuItem, Me.ParcourirCaptureToolStripMenuItem, Me.ParamètresToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        resources.ApplyResources(Me.FichierToolStripMenuItem, "FichierToolStripMenuItem")
        '
        'OuvrirBezierToolStripMenuItem
        '
        Me.OuvrirBezierToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.computer_folder_open_resized_3_color
        Me.OuvrirBezierToolStripMenuItem.Name = "OuvrirBezierToolStripMenuItem"
        resources.ApplyResources(Me.OuvrirBezierToolStripMenuItem, "OuvrirBezierToolStripMenuItem")
        '
        'EnregistrerBezierToolStripMenuItem
        '
        Me.EnregistrerBezierToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.save_resized_color_2
        Me.EnregistrerBezierToolStripMenuItem.Name = "EnregistrerBezierToolStripMenuItem"
        resources.ApplyResources(Me.EnregistrerBezierToolStripMenuItem, "EnregistrerBezierToolStripMenuItem")
        '
        'SupprimerFichiersBezierToolStripMenuItem
        '
        Me.SupprimerFichiersBezierToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.recycle_bin_line_resized_color
        Me.SupprimerFichiersBezierToolStripMenuItem.Name = "SupprimerFichiersBezierToolStripMenuItem"
        resources.ApplyResources(Me.SupprimerFichiersBezierToolStripMenuItem, "SupprimerFichiersBezierToolStripMenuItem")
        '
        'PrendreUnCaptureToolStripMenuItem
        '
        Me.PrendreUnCaptureToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.camera_aperture
        Me.PrendreUnCaptureToolStripMenuItem.Name = "PrendreUnCaptureToolStripMenuItem"
        resources.ApplyResources(Me.PrendreUnCaptureToolStripMenuItem, "PrendreUnCaptureToolStripMenuItem")
        '
        'ParcourirCaptureToolStripMenuItem
        '
        Me.ParcourirCaptureToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.pictures_resized_color
        Me.ParcourirCaptureToolStripMenuItem.Name = "ParcourirCaptureToolStripMenuItem"
        resources.ApplyResources(Me.ParcourirCaptureToolStripMenuItem, "ParcourirCaptureToolStripMenuItem")
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.settings_gear_color_2
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        resources.ApplyResources(Me.ParamètresToolStripMenuItem, "ParamètresToolStripMenuItem")
        '
        'EditionsToolStripMenuItem
        '
        Me.EditionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterCourbeToolStripMenuItem, Me.MasquerCourbeToolStripMenuItem, Me.SupprimerCourbeToolStripMenuItem, Me.SupprimerToutesLesCourbesToolStripMenuItem, Me.CouleurToolStripMenuItem})
        Me.EditionsToolStripMenuItem.Name = "EditionsToolStripMenuItem"
        resources.ApplyResources(Me.EditionsToolStripMenuItem, "EditionsToolStripMenuItem")
        '
        'AjouterCourbeToolStripMenuItem
        '
        Me.AjouterCourbeToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.collapse_plus
        Me.AjouterCourbeToolStripMenuItem.Name = "AjouterCourbeToolStripMenuItem"
        resources.ApplyResources(Me.AjouterCourbeToolStripMenuItem, "AjouterCourbeToolStripMenuItem")
        '
        'MasquerCourbeToolStripMenuItem
        '
        Me.MasquerCourbeToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.check_mark_box_line
        Me.MasquerCourbeToolStripMenuItem.Name = "MasquerCourbeToolStripMenuItem"
        resources.ApplyResources(Me.MasquerCourbeToolStripMenuItem, "MasquerCourbeToolStripMenuItem")
        '
        'SupprimerCourbeToolStripMenuItem
        '
        Me.SupprimerCourbeToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.expand_minus
        Me.SupprimerCourbeToolStripMenuItem.Name = "SupprimerCourbeToolStripMenuItem"
        resources.ApplyResources(Me.SupprimerCourbeToolStripMenuItem, "SupprimerCourbeToolStripMenuItem")
        '
        'SupprimerToutesLesCourbesToolStripMenuItem
        '
        Me.SupprimerToutesLesCourbesToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.close_window
        Me.SupprimerToutesLesCourbesToolStripMenuItem.Name = "SupprimerToutesLesCourbesToolStripMenuItem"
        resources.ApplyResources(Me.SupprimerToutesLesCourbesToolStripMenuItem, "SupprimerToutesLesCourbesToolStripMenuItem")
        '
        'CouleurToolStripMenuItem
        '
        Me.CouleurToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.paint_brush_drawing_color_v2
        Me.CouleurToolStripMenuItem.Name = "CouleurToolStripMenuItem"
        resources.ApplyResources(Me.CouleurToolStripMenuItem, "CouleurToolStripMenuItem")
        '
        'main_menu_ms
        '
        Me.main_menu_ms.BackColor = System.Drawing.Color.Transparent
        Me.main_menu_ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionsToolStripMenuItem, Me.AffichageToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.main_menu_ms, "main_menu_ms")
        Me.main_menu_ms.Name = "main_menu_ms"
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.ZoomToolStripMenuItem1, Me.ZoomDefautToolStripMenuItem, Me.AfficherGrilleToolStripMenuItem, Me.InfoCoubesToolStripMenuItem, Me.InfoCourbesToolStripMenuItem})
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        resources.ApplyResources(Me.AffichageToolStripMenuItem, "AffichageToolStripMenuItem")
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_color
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        resources.ApplyResources(Me.ZoomToolStripMenuItem, "ZoomToolStripMenuItem")
        '
        'ZoomToolStripMenuItem1
        '
        Me.ZoomToolStripMenuItem1.Image = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_out_color
        Me.ZoomToolStripMenuItem1.Name = "ZoomToolStripMenuItem1"
        resources.ApplyResources(Me.ZoomToolStripMenuItem1, "ZoomToolStripMenuItem1")
        '
        'ZoomDefautToolStripMenuItem
        '
        Me.ZoomDefautToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_reset_color
        Me.ZoomDefautToolStripMenuItem.Name = "ZoomDefautToolStripMenuItem"
        resources.ApplyResources(Me.ZoomDefautToolStripMenuItem, "ZoomDefautToolStripMenuItem")
        '
        'AfficherGrilleToolStripMenuItem
        '
        Me.AfficherGrilleToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.grid_2_color
        Me.AfficherGrilleToolStripMenuItem.Name = "AfficherGrilleToolStripMenuItem"
        resources.ApplyResources(Me.AfficherGrilleToolStripMenuItem, "AfficherGrilleToolStripMenuItem")
        '
        'InfoCoubesToolStripMenuItem
        '
        Me.InfoCoubesToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.info
        Me.InfoCoubesToolStripMenuItem.Name = "InfoCoubesToolStripMenuItem"
        resources.ApplyResources(Me.InfoCoubesToolStripMenuItem, "InfoCoubesToolStripMenuItem")
        '
        'InfoCourbesToolStripMenuItem
        '
        Me.InfoCourbesToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.list_view_resized_3_color_2
        Me.InfoCourbesToolStripMenuItem.Name = "InfoCourbesToolStripMenuItem"
        resources.ApplyResources(Me.InfoCourbesToolStripMenuItem, "InfoCourbesToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlToolStripMenuItem, Me.NoticeToolStripMenuItem, Me.VersionsToolStripMenuItem, Me.LangueToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.ctrl_control_button
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        resources.ApplyResources(Me.ControlToolStripMenuItem, "ControlToolStripMenuItem")
        '
        'NoticeToolStripMenuItem
        '
        Me.NoticeToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.article
        Me.NoticeToolStripMenuItem.Name = "NoticeToolStripMenuItem"
        resources.ApplyResources(Me.NoticeToolStripMenuItem, "NoticeToolStripMenuItem")
        '
        'VersionsToolStripMenuItem
        '
        Me.VersionsToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.open_book
        Me.VersionsToolStripMenuItem.Name = "VersionsToolStripMenuItem"
        resources.ApplyResources(Me.VersionsToolStripMenuItem, "VersionsToolStripMenuItem")
        '
        'LangueToolStripMenuItem
        '
        Me.LangueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrançaisToolStripMenuItem, Me.AnglaisToolStripMenuItem})
        Me.LangueToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.earth
        Me.LangueToolStripMenuItem.Name = "LangueToolStripMenuItem"
        resources.ApplyResources(Me.LangueToolStripMenuItem, "LangueToolStripMenuItem")
        '
        'FrançaisToolStripMenuItem
        '
        Me.FrançaisToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.fr_language
        Me.FrançaisToolStripMenuItem.Name = "FrançaisToolStripMenuItem"
        resources.ApplyResources(Me.FrançaisToolStripMenuItem, "FrançaisToolStripMenuItem")
        '
        'AnglaisToolStripMenuItem
        '
        Me.AnglaisToolStripMenuItem.Image = Global.Projet_Bezier.My.Resources.Resources.en_language
        Me.AnglaisToolStripMenuItem.Name = "AnglaisToolStripMenuItem"
        resources.ApplyResources(Me.AnglaisToolStripMenuItem, "AnglaisToolStripMenuItem")
        '
        'x_Xind_lb_start
        '
        resources.ApplyResources(Me.x_Xind_lb_start, "x_Xind_lb_start")
        Me.x_Xind_lb_start.BackColor = System.Drawing.Color.Transparent
        Me.x_Xind_lb_start.Name = "x_Xind_lb_start"
        '
        'y_Yind_lb_start
        '
        resources.ApplyResources(Me.y_Yind_lb_start, "y_Yind_lb_start")
        Me.y_Yind_lb_start.BackColor = System.Drawing.Color.Transparent
        Me.y_Yind_lb_start.Name = "y_Yind_lb_start"
        '
        'xtg_Xind_lb_start
        '
        resources.ApplyResources(Me.xtg_Xind_lb_start, "xtg_Xind_lb_start")
        Me.xtg_Xind_lb_start.BackColor = System.Drawing.Color.Transparent
        Me.xtg_Xind_lb_start.Name = "xtg_Xind_lb_start"
        '
        'ytg_Yind_lb_start
        '
        resources.ApplyResources(Me.ytg_Yind_lb_start, "ytg_Yind_lb_start")
        Me.ytg_Yind_lb_start.BackColor = System.Drawing.Color.Transparent
        Me.ytg_Yind_lb_start.Name = "ytg_Yind_lb_start"
        '
        'ytg_Yind_lb_end
        '
        resources.ApplyResources(Me.ytg_Yind_lb_end, "ytg_Yind_lb_end")
        Me.ytg_Yind_lb_end.BackColor = System.Drawing.Color.Transparent
        Me.ytg_Yind_lb_end.Name = "ytg_Yind_lb_end"
        '
        'xtg_Xind_lb_end
        '
        resources.ApplyResources(Me.xtg_Xind_lb_end, "xtg_Xind_lb_end")
        Me.xtg_Xind_lb_end.BackColor = System.Drawing.Color.Transparent
        Me.xtg_Xind_lb_end.Name = "xtg_Xind_lb_end"
        '
        'y_Yind_lb_end
        '
        resources.ApplyResources(Me.y_Yind_lb_end, "y_Yind_lb_end")
        Me.y_Yind_lb_end.BackColor = System.Drawing.Color.Transparent
        Me.y_Yind_lb_end.Name = "y_Yind_lb_end"
        '
        'x_Xind_lb_end
        '
        resources.ApplyResources(Me.x_Xind_lb_end, "x_Xind_lb_end")
        Me.x_Xind_lb_end.BackColor = System.Drawing.Color.Transparent
        Me.x_Xind_lb_end.Name = "x_Xind_lb_end"
        '
        'curve_lenght_OUTPUT_lb
        '
        resources.ApplyResources(Me.curve_lenght_OUTPUT_lb, "curve_lenght_OUTPUT_lb")
        Me.curve_lenght_OUTPUT_lb.Name = "curve_lenght_OUTPUT_lb"
        '
        'parameter_btn
        '
        Me.parameter_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.settings_gear_color_2
        resources.ApplyResources(Me.parameter_btn, "parameter_btn")
        Me.parameter_btn.Name = "parameter_btn"
        Me.parameter_btn.UseVisualStyleBackColor = True
        '
        'save_file_btn
        '
        Me.save_file_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.save_resized_color_2
        resources.ApplyResources(Me.save_file_btn, "save_file_btn")
        Me.save_file_btn.Name = "save_file_btn"
        Me.save_file_btn.UseVisualStyleBackColor = True
        '
        'browse_screenshot_btn
        '
        Me.browse_screenshot_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.pictures_resized_color
        resources.ApplyResources(Me.browse_screenshot_btn, "browse_screenshot_btn")
        Me.browse_screenshot_btn.Name = "browse_screenshot_btn"
        Me.browse_screenshot_btn.UseVisualStyleBackColor = True
        '
        'load_file_btn
        '
        Me.load_file_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.computer_folder_open_resized_3_color
        resources.ApplyResources(Me.load_file_btn, "load_file_btn")
        Me.load_file_btn.Name = "load_file_btn"
        Me.load_file_btn.UseVisualStyleBackColor = True
        '
        'curve_list_btn
        '
        Me.curve_list_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.list_view_resized_3_color_2
        resources.ApplyResources(Me.curve_list_btn, "curve_list_btn")
        Me.curve_list_btn.Name = "curve_list_btn"
        Me.curve_list_btn.UseVisualStyleBackColor = True
        '
        'curve_info_btn
        '
        Me.curve_info_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.info_color
        resources.ApplyResources(Me.curve_info_btn, "curve_info_btn")
        Me.curve_info_btn.Name = "curve_info_btn"
        Me.curve_info_btn.UseVisualStyleBackColor = True
        '
        'hide_curve_btn
        '
        Me.hide_curve_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.check_mark_box_line
        resources.ApplyResources(Me.hide_curve_btn, "hide_curve_btn")
        Me.hide_curve_btn.Name = "hide_curve_btn"
        Me.hide_curve_btn.UseVisualStyleBackColor = True
        '
        'delete_all_curve_btn
        '
        Me.delete_all_curve_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.close_window
        resources.ApplyResources(Me.delete_all_curve_btn, "delete_all_curve_btn")
        Me.delete_all_curve_btn.Name = "delete_all_curve_btn"
        Me.delete_all_curve_btn.UseVisualStyleBackColor = True
        '
        'color_pb
        '
        Me.color_pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.color_pb, "color_pb")
        Me.color_pb.Name = "color_pb"
        Me.color_pb.TabStop = False
        '
        'pick_color_btn
        '
        Me.pick_color_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.paint_brush_drawing_color_v2
        resources.ApplyResources(Me.pick_color_btn, "pick_color_btn")
        Me.pick_color_btn.Name = "pick_color_btn"
        Me.pick_color_btn.UseVisualStyleBackColor = True
        '
        'take_screenshot_btn
        '
        Me.take_screenshot_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.camera_aperture
        resources.ApplyResources(Me.take_screenshot_btn, "take_screenshot_btn")
        Me.take_screenshot_btn.Name = "take_screenshot_btn"
        Me.take_screenshot_btn.UseVisualStyleBackColor = True
        '
        'delete_curve_btn
        '
        Me.delete_curve_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.expand_minus
        resources.ApplyResources(Me.delete_curve_btn, "delete_curve_btn")
        Me.delete_curve_btn.Name = "delete_curve_btn"
        Me.delete_curve_btn.UseVisualStyleBackColor = True
        '
        'add_curve_btn
        '
        Me.add_curve_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.collapse_plus
        resources.ApplyResources(Me.add_curve_btn, "add_curve_btn")
        Me.add_curve_btn.Name = "add_curve_btn"
        Me.add_curve_btn.UseVisualStyleBackColor = True
        '
        'delete_file_btn
        '
        Me.delete_file_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.recycle_bin_line_resized_color
        resources.ApplyResources(Me.delete_file_btn, "delete_file_btn")
        Me.delete_file_btn.Name = "delete_file_btn"
        Me.delete_file_btn.UseVisualStyleBackColor = True
        '
        'zoom_out_btn
        '
        Me.zoom_out_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_out_color
        resources.ApplyResources(Me.zoom_out_btn, "zoom_out_btn")
        Me.zoom_out_btn.Name = "zoom_out_btn"
        Me.zoom_out_btn.UseVisualStyleBackColor = True
        '
        'hide_grid_btn
        '
        Me.hide_grid_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.grid_2_color
        resources.ApplyResources(Me.hide_grid_btn, "hide_grid_btn")
        Me.hide_grid_btn.Name = "hide_grid_btn"
        Me.hide_grid_btn.UseVisualStyleBackColor = True
        '
        'zoom_reset_btn
        '
        Me.zoom_reset_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_reset_color
        resources.ApplyResources(Me.zoom_reset_btn, "zoom_reset_btn")
        Me.zoom_reset_btn.Name = "zoom_reset_btn"
        Me.zoom_reset_btn.UseVisualStyleBackColor = True
        '
        'zoom_in_btn
        '
        Me.zoom_in_btn.BackgroundImage = Global.Projet_Bezier.My.Resources.Resources.magnifier_glass_zoom_color
        resources.ApplyResources(Me.zoom_in_btn, "zoom_in_btn")
        Me.zoom_in_btn.Name = "zoom_in_btn"
        Me.zoom_in_btn.UseVisualStyleBackColor = True
        '
        'trace_pb
        '
        Me.trace_pb.BackColor = System.Drawing.SystemColors.ControlDark
        Me.trace_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trace_pb.Image = Global.Projet_Bezier.My.Resources.Resources.BG
        resources.ApplyResources(Me.trace_pb, "trace_pb")
        Me.trace_pb.Name = "trace_pb"
        Me.trace_pb.TabStop = False
        '
        'curve_select_name_lb
        '
        resources.ApplyResources(Me.curve_select_name_lb, "curve_select_name_lb")
        Me.curve_select_name_lb.Name = "curve_select_name_lb"
        '
        'FolderBrowserDialog1
        '
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.curve_lenght_OUTPUT_lb)
        Me.Controls.Add(Me.x_Xind_lb_end)
        Me.Controls.Add(Me.y_Yind_lb_end)
        Me.Controls.Add(Me.xtg_Xind_lb_end)
        Me.Controls.Add(Me.ytg_Yind_lb_end)
        Me.Controls.Add(Me.ytg_Yind_lb_start)
        Me.Controls.Add(Me.ytg_nud_start)
        Me.Controls.Add(Me.xtg_Xind_lb_start)
        Me.Controls.Add(Me.xtg_nud_start)
        Me.Controls.Add(Me.y_Yind_lb_start)
        Me.Controls.Add(Me.y_nud_start)
        Me.Controls.Add(Me.curve_select_name_lb)
        Me.Controls.Add(Me.main_menu_ms)
        Me.Controls.Add(Me.parameter_btn)
        Me.Controls.Add(Me.selected_tb)
        Me.Controls.Add(Me.list_curve_clb)
        Me.Controls.Add(Me.segment_nud)
        Me.Controls.Add(Me.seg_number_S_lb)
        Me.Controls.Add(Me.seg_number_lb)
        Me.Controls.Add(Me.save_file_btn)
        Me.Controls.Add(Me.browse_screenshot_btn)
        Me.Controls.Add(Me.load_file_btn)
        Me.Controls.Add(Me.ThinLB)
        Me.Controls.Add(Me.LargeLB)
        Me.Controls.Add(Me.cent_selector_lb)
        Me.Controls.Add(Me.diz_selector_lb)
        Me.Controls.Add(Me.coord_thin_tb)
        Me.Controls.Add(Me.point_end_tan_lb)
        Me.Controls.Add(Me.point_end_ext_lb)
        Me.Controls.Add(Me.point_begin_tan_lb)
        Me.Controls.Add(Me.point_begin_ext_lb)
        Me.Controls.Add(Me.ytg_Y_lb_end)
        Me.Controls.Add(Me.xtg_X_lb_end)
        Me.Controls.Add(Me.ytg_nud_end)
        Me.Controls.Add(Me.xtg_nud_end)
        Me.Controls.Add(Me.y_Y_lb_end)
        Me.Controls.Add(Me.y_nud_end)
        Me.Controls.Add(Me.x_nud_end)
        Me.Controls.Add(Me.coord_large_tb)
        Me.Controls.Add(Me.curve_lenght_L_lb)
        Me.Controls.Add(Me.curve_list_btn)
        Me.Controls.Add(Me.curve_info_btn)
        Me.Controls.Add(Me.coord_tan_lb)
        Me.Controls.Add(Me.ytg_Y_lb_start)
        Me.Controls.Add(Me.xtg_X_lb_start)
        Me.Controls.Add(Me.y_Y_lb_start)
        Me.Controls.Add(Me.coord_extremity_lb)
        Me.Controls.Add(Me.hide_curve_btn)
        Me.Controls.Add(Me.delete_all_curve_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.color_pb)
        Me.Controls.Add(Me.pick_color_btn)
        Me.Controls.Add(Me.hexacode_tb)
        Me.Controls.Add(Me.curve_length_lb)
        Me.Controls.Add(Me.take_screenshot_btn)
        Me.Controls.Add(Me.delete_curve_btn)
        Me.Controls.Add(Me.add_curve_btn)
        Me.Controls.Add(Me.delete_file_btn)
        Me.Controls.Add(Me.zoom_out_btn)
        Me.Controls.Add(Me.hide_grid_btn)
        Me.Controls.Add(Me.zoom_reset_btn)
        Me.Controls.Add(Me.x_nud_start)
        Me.Controls.Add(Me.zoom_in_btn)
        Me.Controls.Add(Me.trace_pb)
        Me.Controls.Add(Me.x_Xind_lb_start)
        Me.Controls.Add(Me.x_X_lb_end)
        Me.Controls.Add(Me.x_X_lb_start)
        Me.MainMenuStrip = Me.main_menu_ms
        Me.Name = "Form1"
        CType(Me.x_nud_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.y_nud_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtg_nud_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ytg_nud_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coord_large_tb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.y_nud_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_nud_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ytg_nud_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xtg_nud_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coord_thin_tb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segment_nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main_menu_ms.ResumeLayout(False)
        Me.main_menu_ms.PerformLayout()
        CType(Me.color_pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trace_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trace_pb As PictureBox
    Friend WithEvents zoom_in_btn As Button
    Friend WithEvents x_nud_start As NumericUpDown
    Friend WithEvents zoom_reset_btn As Button
    Friend WithEvents add_curve_btn As Button
    Friend WithEvents delete_curve_btn As Button
    Friend WithEvents take_screenshot_btn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents curve_length_lb As Label
    Friend WithEvents hexacode_tb As TextBox
    Friend WithEvents pick_color_btn As Button
    Friend WithEvents color_pb As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents list_curve_clb As CheckedListBox
    Friend WithEvents y_nud_start As NumericUpDown
    Friend WithEvents xtg_nud_start As NumericUpDown
    Friend WithEvents ytg_nud_start As NumericUpDown
    Friend WithEvents delete_all_curve_btn As Button
    Friend WithEvents hide_curve_btn As Button
    Friend WithEvents coord_extremity_lb As Label
    Friend WithEvents x_X_lb_start As Label
    Friend WithEvents y_Y_lb_start As Label
    Friend WithEvents xtg_X_lb_start As Label
    Friend WithEvents ytg_Y_lb_start As Label
    Friend WithEvents coord_tan_lb As Label
    Friend WithEvents curve_info_btn As Button
    Friend WithEvents delete_file_btn As Button
    Friend WithEvents curve_lenght_L_lb As Label
    Friend WithEvents coord_large_tb As TrackBar
    Friend WithEvents y_Y_lb_end As Label
    Friend WithEvents x_X_lb_end As Label
    Friend WithEvents y_nud_end As NumericUpDown
    Friend WithEvents x_nud_end As NumericUpDown
    Friend WithEvents ytg_Y_lb_end As Label
    Friend WithEvents xtg_X_lb_end As Label
    Friend WithEvents ytg_nud_end As NumericUpDown
    Friend WithEvents xtg_nud_end As NumericUpDown
    Friend WithEvents point_begin_ext_lb As Label
    Friend WithEvents point_end_ext_lb As Label
    Friend WithEvents point_end_tan_lb As Label
    Friend WithEvents point_begin_tan_lb As Label
    Friend WithEvents coord_thin_tb As TrackBar
    Friend WithEvents diz_selector_lb As Label
    Friend WithEvents cent_selector_lb As Label
    Friend WithEvents LargeLB As Label
    Friend WithEvents ThinLB As Label
    Friend WithEvents load_file_btn As Button
    Friend WithEvents browse_screenshot_btn As Button
    Friend WithEvents save_file_btn As Button
    Friend WithEvents seg_number_S_lb As Label
    Friend WithEvents seg_number_lb As Label
    Friend WithEvents segment_nud As NumericUpDown
    Friend WithEvents selected_tb As TextBox
    Friend WithEvents parameter_btn As Button
    Friend WithEvents curve_list_btn As Button
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirBezierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerBezierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerFichiersBezierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrendreUnCaptureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParcourirCaptureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterCourbeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasquerCourbeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerCourbeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToutesLesCourbesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents main_menu_ms As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents x_Xind_lb_start As Label
    Friend WithEvents y_Yind_lb_start As Label
    Friend WithEvents xtg_Xind_lb_start As Label
    Friend WithEvents ytg_Yind_lb_start As Label
    Friend WithEvents AffichageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZoomDefautToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherGrilleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoCoubesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LangueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrançaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnglaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ytg_Yind_lb_end As Label
    Friend WithEvents xtg_Xind_lb_end As Label
    Friend WithEvents y_Yind_lb_end As Label
    Friend WithEvents x_Xind_lb_end As Label
    Friend WithEvents curve_lenght_OUTPUT_lb As Label
    Friend WithEvents zoom_out_btn As Button
    Friend WithEvents hide_grid_btn As Button
    Friend WithEvents InfoCourbesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoticeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouleurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents curve_select_name_lb As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
