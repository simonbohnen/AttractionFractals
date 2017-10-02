Public Class Point
    Public x As Double, y As Double

    Public Sub New(newX As Double, newY As Double)
        x = newX
        y = newY
    End Sub

    Public Function distanceTo(p As Point) As Double
        Return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2))
    End Function
End Class
