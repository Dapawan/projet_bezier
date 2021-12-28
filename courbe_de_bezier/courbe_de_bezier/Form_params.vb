﻿Public Class Form_params

    Dim filename_screenshot As String
    Dim auto_incr_screenshot As Boolean
    Dim default_path_screenshot As String
    Dim filename_file As String
    Dim auto_incr_file As Boolean
    Dim default_path_file As String

    Public Sub New(ByRef filename_screenshot As String, ByRef auto_incr_screenshot As Boolean, ByRef default_path_screenshot As String, ByRef filename_file As String, ByRef auto_incr_file As Boolean, ByRef default_path_file As String)
        InitializeComponent()

        Me.filename_screenshot = filename_screenshot
        Me.auto_incr_screenshot = auto_incr_screenshot
        Me.default_path_screenshot = default_path_screenshot
        Me.filename_file = filename_file
        Me.auto_incr_file = auto_incr_file
        Me.default_path_file = default_path_file

        ' Set default path in case of nothing specified
        defaultPaths((Me.default_path_file.Length.Equals(0)), (Me.default_path_screenshot.Length.Equals(0)))

        refreshValuesDisplayed()

    End Sub

    ' 3 états :
    ' => Case auto-incr décochée : On ouvre l'explo de fichier pour choisir path + filename
    ' => Case auto-incr cochée :
    '   => Filename spécifié : On enregistre dans le path + incr du nom s'il existe déjà 
    '   => Filename empty : Filename au format "bezier"/"screen" + date + [extension]
    ' Attention : On doit forcément avoir un path

    Public Sub getValues(ByRef filename_screenshot As String, ByRef auto_incr_screenshot As Boolean, ByRef default_path_screenshot As String, ByRef filename_file As String, ByRef auto_incr_file As Boolean, ByRef default_path_file As String)
        filename_screenshot = Me.filename_screenshot
        auto_incr_screenshot = Me.auto_incr_screenshot
        default_path_screenshot = Me.default_path_screenshot
        filename_file = Me.filename_file
        auto_incr_file = Me.auto_incr_file
        default_path_file = Me.default_path_file
    End Sub

    Private Sub refreshValuesDisplayed()
        TextBox_screenshot_name.Text = Me.filename_screenshot
        CheckBox_auto_incr_screenshot.Checked = Me.auto_incr_screenshot
        TextBox_screenshot_default_path.Text = Me.default_path_screenshot

        TextBox_file_name.Text = Me.filename_file
        CheckBox_auto_incr_file.Checked = Me.auto_incr_file
        TextBox_file_default_path.Text = Me.default_path_file
    End Sub

    Private Sub defaultPaths(ByVal default_path_file As Boolean, ByVal default_path_screen As Boolean)
        If (default_path_file.Equals(True)) Then
            Me.default_path_file = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End If

        If (default_path_screen.Equals(True)) Then
            Me.default_path_screenshot = My.Computer.FileSystem.SpecialDirectories.MyPictures
        End If

    End Sub

    Private Sub Button_option_path_Click(sender As Object, e As EventArgs) Handles Button_option_screen_path.Click, Button_option_file_path.Click
        Dim path_result As String = ""

        Dim path As String
        Dim title As String
        Dim btn = MessageBoxButtons.YesNo
        Dim ico = MessageBoxIcon.Information

        Dim sfdPic As New FolderBrowserDialog()

        If sender Is Button_option_screen_path Then
            path = Me.default_path_screenshot
            title = "Répertoire d'enregistrement des images de courbes"
        Else
            path = Me.default_path_file
            title = "Répertoire d'enregistrement des données de courbes"
        End If

        Try

            With sfdPic
                .SelectedPath = path
                .ShowNewFolderButton = True
                .Description = title

                If .ShowDialog = DialogResult.OK Then
                    path_result = sfdPic.SelectedPath
                Else
                    Return
                End If

            End With
        Catch ex As Exception
            MessageBox.Show("Error: -> " & ex.Message.ToString())
        Finally
            sfdPic.Dispose()
        End Try

        'Override path only in case of we have something => otherwise we keep default values
        If (path_result.Length <> 0) Then
            If sender Is Button_option_screen_path Then
                Me.default_path_screenshot = path_result
            Else
                Me.default_path_file = path_result
            End If
        End If

        refreshValuesDisplayed()

    End Sub

    Private Sub Textbox_filename(sender As Object, e As EventArgs) Handles TextBox_screenshot_name.TextChanged, TextBox_file_name.TextChanged
        Dim filename As String = ""

        If sender Is TextBox_screenshot_name Then
            filename = TextBox_screenshot_name.Text
        Else
            filename = TextBox_file_name.Text
        End If

        If (filename.Intersect(System.IO.Path.GetInvalidFileNameChars()).Any()) Then
            MessageBox.Show("Invalid filename !")
            refreshValuesDisplayed()
        Else
            If sender Is TextBox_screenshot_name Then
                Me.filename_screenshot = filename
            Else
                Me.filename_file = filename
            End If
        End If


    End Sub

    Private Sub TextBox_Path(sender As Object, e As EventArgs) Handles TextBox_screenshot_default_path.TextChanged, TextBox_file_default_path.TextChanged
        Dim path As String = ""

        If sender Is TextBox_screenshot_default_path Then
            path = TextBox_screenshot_default_path.Text
        Else
            path = TextBox_file_default_path.Text
        End If

        If (System.IO.Directory.Exists(path).Equals(False)) Then
            MessageBox.Show("Directory doesn't exist")
            refreshValuesDisplayed()
        Else
            If sender Is TextBox_screenshot_name Then
                Me.default_path_screenshot = path
            Else
                Me.default_path_file = path
            End If
        End If

    End Sub
End Class