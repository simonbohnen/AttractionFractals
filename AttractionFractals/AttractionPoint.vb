Public Class AttractionPoint
    Inherits Point

    Public color As Color

    Public Sub New(newX As Double, newY As Double, newColor As Color)
        MyBase.New(newX, newY)
        color = newColor
    End Sub
End Class
