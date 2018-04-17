Public Class Form1

    Public bmp As Bitmap
    Public gpx As Graphics

    Public Sphere As Sphere = New Sphere(New Vec(0, 0, -40), 4, New Vec(1.0, 0.32, 0.36))

    'Light Properties
    Public LightPosition As Vec = New Vec(0, 20, 0)
    Public LightPosition2 As Vec = New Vec(0, 20, 0)
    Public LightIntensity = New Vec(1.0, 1.0, 1.0)

    Public DiffuseColour As Vec
    Public SpecularColour As Vec
    Public Shininess As Double

    Public Ambient, Specular, Diffuse As Vec


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        gpx = Graphics.FromImage(bmp)
        Ambient = Sphere.colour * New Vec(1.0, 1.0, 1.0)
        DiffuseColour = Sphere.colour
        SpecularColour = New Vec(0.7, 0.7, 0.7)

        gpx.Clear(Color.Blue)

        Draw()
    End Sub

    Sub Draw()
        For i = 0 To bmp.Width - 1
            For j = 0 To bmp.Height - 1

                Dim pixNormX As Double = (i + 0.5) / bmp.Width
                Dim pixNormY As Double = (j + 0.5) / bmp.Height

                Dim imageAspectRatio As Double = bmp.Width / bmp.Height

                Dim pixRemapX = (2 * pixNormX - 1) * imageAspectRatio
                Dim pixRemapY = 1 - 2 * pixNormY

                Dim pixCameraX = pixRemapX * Math.Tan((30 * 3.1459 / 180) / 2)
                Dim pixCameraY = pixRemapY * Math.Tan((30 * 3.1459 / 180) / 2)

                Dim PCameraSpace As Vec = New Vec(pixCameraX, pixCameraY, -1)
                Dim rayOrigin As Vec = New Vec(0, 0, 0)
                Dim rayDiraction As Vec = PCameraSpace - rayOrigin
                rayDiraction = rayDiraction.Normalize

                Dim t0 As Double = 0.0

                Dim Hit As Boolean = Sphere.Intersection(t0, rayOrigin, rayDiraction)

                Dim minT As Double = t0

                If Hit Then

                    Dim p0 = rayOrigin + rayDiraction * t0

                    'Normal
                    Dim Normal As Vec = Sphere.CalculateNormal(p0, Shininess, DiffuseColour, SpecularColour) 'Calculate normal
                    Normal = Normal.Normalize

                    'Ambient
                    ' Ambient = Sphere.colour * New Vec(0.1, 0.1, 0.1)

                    'Diffuse
                    Dim LightRay As Vec = LightPosition - p0
                    LightRay = LightRay.Normalize

                    Diffuse = DiffuseColour * LightIntensity * GetMAX(0.0, LightRay.Dot(Normal))

                    'Specular
                    Dim Reflection As Vec = Normal * (2 * LightRay.Dot(Normal)) - LightRay
                    Reflection = Reflection.Normalize

                    Dim tst As Vec = rayOrigin - p0
                    Dim maxCalc As Double = GetMAX(0.0, Reflection.Dot(tst.Normalize))
                    Dim Specular As Vec = SpecularColour * LightIntensity * Shininess * Math.Pow(maxCalc, Shininess)


                    Dim LigtHit As Boolean = Sphere.Intersection(t0, p0 + (Normal * 0.0001F), LightRay)

                    Dim itot As Vec

                    'If LigtHit And t0 < minT Then
                    '    minT = t0
                    '    itot = Sphere.colour * Ambient
                    'Else
                    '    itot = Diffuse + Specular
                    'End If

                    itot = (Diffuse + Specular) * Ambient

                    bmp.SetPixel(i, j, CreateColorVector(New Vec(itot.x * 255, itot.y * 255, itot.z * 255)))
                Else
                    bmp.SetPixel(i, j, Color.White)
                End If

                'bmp.SetPixel(i, j, CreateColorVector(New Vec(rayDiraction.x * 255, rayDiraction.y * 255, rayDiraction.z * 255)))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Function CreateColorVector(clr As Vec) As Color
        Dim colRed, colGreen, colBlue As Double

        colRed = clr.x
        colGreen = clr.y
        colBlue = clr.z

        If colRed > 255 Then
            colRed = 255
        ElseIf colRed < 0 Then
            colRed = 0
        End If

        If colGreen > 255 Then
            colGreen = 255
        ElseIf colGreen < 0 Then
            colGreen = 0
        End If

        If colBlue > 255 Then
            colBlue = 255
        ElseIf colBlue < 0 Then
            colBlue = 0
        End If

        Return Color.FromArgb(CInt(colRed), CInt(colGreen), CInt(colBlue))
    End Function

    Function GetMAX(A As Double, B As Double) As Double
        If A < B Then
            Return B
        Else
            Return A
        End If
    End Function

    Private Sub Lighty_Scroll(sender As Object, e As EventArgs) Handles Lighty.Scroll
        LightPosition.y = Lighty.Value
        Draw()
    End Sub

    Private Sub Lightx_Scroll(sender As Object, e As EventArgs) Handles Lightx.Scroll
        LightPosition.x = Lightx.Value
        Draw()
    End Sub

    Private Sub Lightz_Scroll(sender As Object, e As EventArgs) Handles Lightz.Scroll
        LightPosition.z = Lightz.Value
        Draw()
    End Sub

    Private Sub Spherex_Scroll(sender As Object, e As EventArgs) Handles Spherex.Scroll
        Sphere.position.x = Spherex.Value
        Draw()
    End Sub

    Private Sub Spherey_Scroll(sender As Object, e As EventArgs) Handles Spherey.Scroll
        Sphere.position.y = Spherey.Value
        Draw()
    End Sub

    Private Sub Spherez_Scroll(sender As Object, e As EventArgs) Handles Spherez.Scroll
        Sphere.position.z = Spherez.Value
        Draw()
    End Sub

    Private Sub kaTB_Scroll(sender As Object, e As EventArgs) Handles kaTB.Scroll
        Ambient = Sphere.colour * New Vec(kaTB.Value / 10, kaTB.Value / 10, kaTB.Value / 10)
        Draw()
    End Sub

    Private Sub nTB_Scroll(sender As Object, e As EventArgs) Handles nTB.Scroll
        Shininess = nTB.Value
        Draw()
    End Sub

    Private Sub kdTB_Scroll(sender As Object, e As EventArgs) Handles kdTB.Scroll
        DiffuseColour = Sphere.colour * kdTB.Value / 10
        Draw()
    End Sub

    Private Sub ksTB_Scroll(sender As Object, e As EventArgs) Handles ksTB.Scroll
        SpecularColour = New Vec(ksTB.Value, ksTB.Value, ksTB.Value)
        Draw()
    End Sub
End Class

Public Class Sphere
    Public position As Vec
    Public radius As Double
    Public colour As Vec

    Sub New(position As Vec, radius As Double, colour As Vec)
        Me.position = position
        Me.radius = radius
        Me.colour = colour
    End Sub

    Public Function Intersection(ByRef t As Double, rayOrigin As Vec, rayDirection As Vec) As Boolean
        Dim L As Vec = position - rayOrigin
        Dim tca As Double = L.Dot(rayDirection)

        If tca < 0 Then
            Return False
        Else
            Dim s2 As Double = L.Dot(L) - (tca * tca)
            Dim s As Double = Math.Sqrt(s2)
            If s > radius Then
                Return False
            Else
                Dim thc As Double = Math.Sqrt((radius * radius) - s2)
                Dim t0 As Double = tca - thc
                t = t0
                Return True
            End If
        End If
    End Function

    Public Function CalculateNormal(p0 As Vec, ByRef shininess As Integer, ByRef diffuseColour As Vec, ByRef specularColour As Vec) As Vec

        'diffuseColour = colour
        'specularColour = New Vec(0.7, 0.7, 0.7)
        Return p0 - position
    End Function
End Class

Public Class Vec
    Public x, y, z As Double

    Public Sub New()
        x = 0
        y = 0
        z = 0
    End Sub

    Public Sub New(x As Double, y As Double, z As Double)
        Me.x = x
        Me.y = y
        Me.z = z
    End Sub

    Public Sub Translate(val As Double, axis As String)
        If axis = "x" Then
            x = val
        ElseIf axis = "y" Then
            y = val
        ElseIf axis = "z" Then
            z = val
        End If
    End Sub

    Public Function Normalize()
        Dim mg As Double
        mg = Math.Sqrt(x * x + y * y + z * z)
        Return New Vec(x / mg, y / mg, z / mg)
    End Function

    Public Shared Operator +(v As Vec, w As Vec) As Vec
        Return New Vec(v.x + w.x, v.y + w.y, v.z + w.z)
    End Operator

    Public Shared Operator -(v As Vec, w As Vec) As Vec
        Return New Vec(v.x - w.x, v.y - w.y, v.z - w.z)
    End Operator

    Public Shared Operator *(v As Vec, w As Vec) As Vec
        Return New Vec(v.x * w.x, v.y * w.y, v.z * w.z)
    End Operator

    Public Shared Operator *(v As Vec, f As Double) As Vec
        Return New Vec(v.x * f, v.y * f, v.z * f)
    End Operator

    Public Shared Operator /(v As Vec, f As Double) As Vec
        Return New Vec(v.x / f, v.y / f, v.z / f)
    End Operator

    Public Function Dot(w As Vec) As Double
        Return x * w.x + y * w.y + z * w.z
    End Function

End Class