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

    ' Liste de points
    Dim liste_points As PointF()
    ' Longueur
    Dim longueur_courbe As Double
    ' Currently selected
    Dim selected As Boolean
    ' Hide / show
    Dim hide_show As Boolean
    Shared compteur_courbe As Single = 0
    ' Numéro bezier => Valeur unique => Permet l'identification
    Dim numero As Single

    Dim point_select As pointEnum

    Public Sub New(p_deb As PointF, p_fin As PointF, p_tg_deb As PointF, p_tg_fin As PointF, nbr_segment As Single, couleur_courbe As Color)
        Me.p_deb = p_deb
        Me.p_fin = p_fin
        Me.p_tg_deb = p_tg_deb
        Me.p_tg_fin = p_tg_fin
        Me.nbr_segment = nbr_segment
        Me.couleur_courbe = couleur_courbe

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
