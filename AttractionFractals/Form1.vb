Public Class Form1
    Public attractionPoints = New List(Of AttractionPoint)
    Public unknown = New AttractionPoint(0, 0, Color.Black)

    Public sizeX As Integer = 100, sizeY As Integer = 100
    Private Const tolerance = 10

    Private Sub DrawFractal_Click(sender As Object, e As EventArgs) Handles DrawFractal.Click
        Dim b = New Bitmap(sizeX, sizeY)

        'Debug
        attractionPoints.add(New AttractionPoint(80, 80, Color.FromArgb(0, 255, 0)))
        attractionPoints.add(New AttractionPoint(20, 20, Color.FromArgb(255, 0, 0)))

        For x = 0 To sizeX - 1
            For y = 0 To sizeY - 1
                Dim iterX = CDbl(x), iterY = CDbl(y)
                Dim curPoint As Point
                Dim landedAt As AttractionPoint
                Dim counter = 0
                While True
                    curPoint = New Point(iterX, iterY)
                    For Each p In attractionPoints
                        If curPoint.distanceTo(p) < tolerance Then
                            landedAt = p
                            Exit While
                        End If
                    Next
                    Dim newX = iterX, newY = iterY
                    For Each p In attractionPoints
                        Dim dist = curPoint.distanceTo(p) / 10
                        newX += (p.x - iterX) / Math.Pow(dist + 1, 2)
                        newY += (p.y - iterY) / (dist + 1)
                    Next
                    iterX = newX
                    iterY = newY
                    counter += 1
                    If counter > 1000 Then
                        landedAt = unknown
                        Exit While
                    End If
                End While
                CreateGraphics.DrawRectangle(New Pen(landedAt.color, 1), x, y, 1, 1)
                Application.DoEvents()
                Debug.Print(CStr(x) + ", " + CStr(y))
            Next
        Next

        CreateGraphics.DrawImage(b, 0, 0)
    End Sub

    Private Sub addPoint_Click(sender As Object, e As EventArgs) Handles addPoint.Click
        Dim x = CDbl(InputBox("Please enter the x coordinate:"))
        Dim y = CDbl(InputBox("Please enter the y coordinate:"))
        Dim r = CInt(InputBox("Please enter the red value:"))
        Dim g = CInt(InputBox("Please enter the green value:"))
        Dim b = CInt(InputBox("Please enter the blue value:"))
        Dim p = New AttractionPoint(x, y, Color.FromArgb(r, g, b))
        attractionPoints.Add(p)
        attPointsList.Items.Add(p)
    End Sub

    Private Sub delPoint_Click(sender As Object, e As EventArgs) Handles delPoint.Click
        attractionPoints.Remove(attPointsList.SelectedItem)
        attPointsList.Items.Remove(attPointsList.SelectedItem)
    End Sub
End Class
