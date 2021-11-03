Imports System.Drawing.Drawing2D

Public Class Bezier
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


    Public Sub New(p_deb As PointF, p_fin As PointF, p_tg_deb As PointF, p_tg_fin As PointF, nbr_segment As Single, couleur_courbe As Color)
        Me.p_deb = p_deb
        Me.p_fin = p_fin
        Me.p_tg_deb = p_tg_deb
        Me.p_tg_fin = p_tg_fin
        Me.nbr_segment = nbr_segment
        Me.couleur_courbe = couleur_courbe
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
            If (longueur_courbe = 0) Then
                longueur_courbe = getDistance()
            End If

            Return longueur_courbe
        End Get
        Set(value As Double)
            longueur_courbe = value
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

    Public Function getDistance(ByVal liste_points() As PointF)
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
    Public Function selectionPoint(ByVal point_de_selection As PointF) As PointF
        Dim point As PointF

        If (Me.p_deb.Equals(point_de_selection)) Then
            point = Me.p_deb
        ElseIf (Me.p_fin.Equals(point_de_selection)) Then
            point = Me.p_fin
        ElseIf (Me.p_tg_deb.Equals(point_de_selection)) Then
            point = Me.p_tg_deb
        ElseIf (Me.p_tg_fin.Equals(point_de_selection)) Then
            point = Me.p_tg_fin
        End If

        Return point
    End Function


End Class
