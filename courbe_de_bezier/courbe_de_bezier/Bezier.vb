Imports System.Drawing.Drawing2D

Public Class Bezier
    ' Points de départ et de fin
    Public p_deb As PointF
    Public p_fin As PointF
    ' Points de tangente
    Public p_tg_deb As PointF
    Public p_tg_fin As PointF

    Public Sub New(p_deb As PointF, p_fin As PointF, p_tg_deb As PointF, p_tg_fin As PointF)
        Me.p_deb = p_deb
        Me.p_fin = p_fin
        Me.p_tg_deb = p_tg_deb
        Me.p_tg_fin = p_tg_fin
    End Sub

    Public Function getPoints(ByVal nbr_seg As Single) As PointF()
        ' We have 2 points for 1 seg
        Dim list_points(nbr_seg) As PointF
        Dim t As Double
        Dim point As PointF
        Dim seq As Single

        For seq = 0 To (nbr_seg)
            ' Calcule x et y suivant chaque endroit du segment
            t = seq / nbr_seg

            point = New PointF
            point.X = (Math.Pow((1 - t), 3) * p_deb.X) + (3 * t * Math.Pow((1 - t), 2) * p_tg_deb.X) + (3 * Math.Pow(t, 2) * (1 - t) * p_tg_fin.X) + Math.Pow(t, 3) * p_fin.X
            point.Y = (Math.Pow((1 - t), 3) * p_deb.Y) + (3 * t * Math.Pow((1 - t), 2) * p_tg_deb.Y) + (3 * Math.Pow(t, 2) * (1 - t) * p_tg_fin.Y) + Math.Pow(t, 3) * p_fin.Y
            list_points(seq) = point

        Next

        Return list_points
    End Function

End Class
