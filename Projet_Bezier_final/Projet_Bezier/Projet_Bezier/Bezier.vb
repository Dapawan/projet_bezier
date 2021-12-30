Imports System.Drawing.Drawing2D
Public Class Bezier

    Enum pointEnum
        aucun
        p_deb
        p_fin
        p_tg_deb
        p_tg_fin
    End Enum


    ' Points de départ et de fin
    Public p_deb As PointF
    Public p_fin As PointF
    ' Points de tangente
    Public p_tg_deb As PointF
    Public p_tg_fin As PointF

    'Nbr segment
    Dim nbr_segment As Single
    'Couleur
    Dim couleur_courbe As Color
    'Nom
    Public nom As String
    ' Liste de points
    Dim liste_points As PointF()
    ' Longueur
    Dim longueur_courbe As Double
    ' Currently selected
    Dim selected As Boolean
    ' Hide / show
    Dim hide_show As Boolean
    Public Shared compteur_courbe As Single = 0
    ' Numéro bezier => Valeur unique => Permet l'identification
    Dim numero As Single

    Dim point_select As pointEnum
    Shared Function WriteAll(ByRef list_bezier As List(Of Bezier), ByVal path As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, False) ' Override file content
        file.Close()

        For Each bezier As Bezier In list_bezier
            Write(path, bezier)
        Next
    End Function

    Public Overrides Function ToString() As String
        Return ("courbe n° " + uid.ToString() + " nom : " + nom + "   pt_deb" + pointToString(p_deb) + " pt_fin" + pointToString(p_fin) + " pt_tg_deb" + pointToString(p_tg_deb) + " pt_tg_fin" + pointToString(p_tg_fin) + " couleur : " + ColorTranslator.ToHtml(couleur) + " nbr_seg = " + nombre_segment.ToString() + " longueur = " + longueur.ToString("0.0#") + " affiché : " + show.ToString())
    End Function


    Private Function pointToString(ByVal point As PointF)
        Return ("(" + point.X.ToString("0.0#") + " ; " + point.Y.ToString("0.0#") + ")")
    End Function

    'Public Function ToString
    Shared Sub Write(ByVal path As String, ByRef bezier As Bezier)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        Dim str As String = (bezier.p_deb.X.ToString() + ";" + bezier.p_deb.Y.ToString() + ";" + bezier.p_fin.X.ToString() + ";" + bezier.p_fin.Y.ToString() + ";" + bezier.p_tg_deb.X.ToString() + ";" + bezier.p_tg_deb.Y.ToString() + ";" + bezier.p_tg_fin.X.ToString() + ";" + bezier.p_tg_fin.Y.ToString() + ";" + bezier.couleur.ToArgb.ToString() + ";" + bezier.nombre_segment.ToString() + ";" + bezier.uid.ToString() + ";" + bezier.hide_show.ToString() + ";" + bezier.nom + ";" + bezier.currentlySelected.ToString())
        file.WriteLine(str)
        file.Close()
    End Sub


    Shared Function ReadAll(ByVal path As String)
        Dim list_bezier As List(Of Bezier) = New List(Of Bezier)

        Dim fileReader As String
        Dim array_string As String()
        Dim uid As Single = 0
        If System.IO.File.Exists(path) = True Then

            Dim objReader As New System.IO.StreamReader(path)

            Do While objReader.Peek() <> -1

                fileReader = objReader.ReadLine()
                array_string = fileReader.Split(";")
                Dim p_deb As PointF = New PointF(Single.Parse(array_string(0)), Single.Parse(array_string(1)))
                Dim p_fin As PointF = New PointF(Single.Parse(array_string(2)), Single.Parse(array_string(3)))
                Dim p_tg_deb As PointF = New PointF(Single.Parse(array_string(4)), Single.Parse(array_string(5)))
                Dim p_tg_fin As PointF = New PointF(Single.Parse(array_string(6)), Single.Parse(array_string(7)))
                Dim couleur As Color = Color.FromArgb(Integer.Parse(array_string(8))) 'FromName(array_string(8))
                Dim nombre_segment As Single = Single.Parse(array_string(9))
                uid = Single.Parse(array_string(10))
                Dim hide_show As Boolean = Boolean.Parse(array_string(11))
                Dim nom As String = (array_string(12))
                Dim currently_selected As Boolean = Boolean.Parse(array_string(13))
                ' Set UID courbe
                Dim bezier As Bezier = New Bezier(p_deb, p_fin, p_tg_deb, p_tg_fin, nombre_segment, couleur, nom) With {
                    .uid = uid,
                    .hide_show = hide_show,
                    .currentlySelected = currently_selected
                }
                list_bezier.Add(bezier)
            Loop

            objReader.Close()

            'Compteur courbe => Doit = dernière courbe UID + 1
            compteur_courbe = uid + 1
        End If

        Return list_bezier
    End Function
    Public Sub New(p_deb As PointF, p_fin As PointF, p_tg_deb As PointF, p_tg_fin As PointF, nbr_segment As Single, couleur_courbe As Color, ByVal nom As String)
        Me.p_deb = p_deb
        Me.p_fin = p_fin
        Me.p_tg_deb = p_tg_deb
        Me.p_tg_fin = p_tg_fin
        Me.nbr_segment = nbr_segment
        Me.couleur_courbe = couleur_courbe
        Me.nom = nom

        point_selectionne_enum = pointEnum.aucun
        Me.currentlySelected = True 'By default => New bezier is showed + selected
        Me.show = True
        Me.uid = compteur_courbe
        compteur_courbe += 1
    End Sub

    Public Property nombre_segment As Single
        Get
            Return nbr_segment
        End Get
        Set(value As Single)
            nbr_segment = value
        End Set
    End Property

    Public Property couleur As Color
        Get
            Return couleur_courbe
        End Get
        Set(value As Color)
            couleur_courbe = value
        End Set
    End Property

    Public Property points As PointF()
        Get
            liste_points = getPoints()
            Return liste_points
        End Get
        Set(value As PointF())
            liste_points = value
        End Set
    End Property

    Public Property longueur As Double
        Get
            longueur_courbe = getDistance()
            Return longueur_courbe
        End Get
        Set(value As Double)
            longueur_courbe = value
        End Set
    End Property

    Public Property point_selectionne_enum As pointEnum
        Get
            Return point_select
        End Get
        Set(value As pointEnum)
            point_select = value
        End Set
    End Property

    Public Property show As Boolean
        Get
            Return hide_show
        End Get
        Set(value As Boolean)
            hide_show = value
        End Set
    End Property

    Public Property currentlySelected As Boolean
        Get
            Return selected
        End Get
        Set(value As Boolean)
            selected = value
        End Set
    End Property

    Public Property uid As Single
        Get
            Return numero
        End Get
        Set(value As Single)
            numero = value
        End Set
    End Property

    Public Function getPoints() As PointF()
        Return getPoints(Me.nombre_segment)
    End Function

    Public Function getPoints(ByVal nbr_seg As Single) As PointF()
        ' We have 2 points for 1 seg
        Dim list_points(nbr_seg) As PointF
        Dim t As Double
        Dim point As PointF
        Dim seq As Single

        For seq = 0 To (nbr_seg)
            ' Calcule x et y suivant chaque endroit du segment
            If (seq = 0 Or (nbr_seg = 0)) Then
                t = 0
            Else
                t = seq / (nbr_seg)
            End If

            point = New PointF
            point.X = (Math.Pow((1 - t), 3) * p_deb.X) + (3 * t * Math.Pow((1 - t), 2) * p_tg_deb.X) + (3 * Math.Pow(t, 2) * (1 - t) * p_tg_fin.X) + Math.Pow(t, 3) * p_fin.X
            point.Y = (Math.Pow((1 - t), 3) * p_deb.Y) + (3 * t * Math.Pow((1 - t), 2) * p_tg_deb.Y) + (3 * Math.Pow(t, 2) * (1 - t) * p_tg_fin.Y) + Math.Pow(t, 3) * p_fin.Y
            list_points(seq) = point

        Next

        Return list_points
    End Function

    Public Function getDistance()
        Return getDistance(Me.getPoints())
    End Function

    Public Function getDistance(ByRef liste_points() As PointF)
        Dim distance As Double = 0
        If (liste_points.Length >= 2) Then
            For i As Single = 0 To liste_points.Length - 2
                ' sqrt( (x_a-x_b)² + (y_a-y_b)² )
                distance += Math.Sqrt(Math.Pow((liste_points(i).X - liste_points(i + 1).X), 2) + Math.Pow((liste_points(i).Y - liste_points(i + 1).Y), 2))
            Next
        End If

        Return distance
    End Function

    ' Retourne le point sélectionné parmis les 4 points du bezier
    Public Function selectionPoint(ByVal point_de_selection As PointF, ByRef point_selectionne As PointF) As Boolean
        Dim result As Boolean = True

        If (getRect(Me.p_deb, 0.1, 0.1).Contains(point_de_selection)) Then
            point_selectionne = Me.p_deb
            point_selectionne_enum = pointEnum.p_deb
        ElseIf (getRect(Me.p_fin, 0.1, 0.1).Contains(point_de_selection)) Then
            point_selectionne = Me.p_fin
            point_selectionne_enum = pointEnum.p_fin
        ElseIf (getRect(Me.p_tg_deb, 0.1, 0.1).Contains(point_de_selection)) Then
            point_selectionne = Me.p_tg_deb
            point_selectionne_enum = pointEnum.p_tg_deb
        ElseIf (getRect(Me.p_tg_fin, 0.1, 0.1).Contains(point_de_selection)) Then
            point_selectionne = Me.p_tg_fin
            point_selectionne_enum = pointEnum.p_tg_fin
        Else
            result = False
            point_selectionne_enum = pointEnum.aucun
        End If

        Return result
    End Function
    ' Retourne vrai si un bezier de la liste est sélectionné
    Public Function IsBezierSelected(ByRef list_bezier As List(Of Bezier))
        For Each bezier In list_bezier
            If bezier.currentlySelected.Equals(True) Then
                Return True
            End If
        Next
        Return False
    End Function


    'Retourne un rectangle contenant en son centre le point
    Private Function getRect(ByVal point As PointF, ByVal width As Double, ByVal height As Double) As RectangleF
        Return New RectangleF(point.X - (width / 2), point.Y - (width / 2), width, height)
    End Function

End Class
