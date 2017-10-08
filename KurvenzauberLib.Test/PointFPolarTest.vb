Imports System.Text
Imports System.Drawing

<TestClass()>
Public Class PointFPolarTest

    <TestMethod()>
    Public Sub CartesianToPolar_1()
        Dim PCart As New PointF With {.X = 1, .Y = 1}
        Dim PPol As New PointFPolar(PCart)

        Assert.AreEqual(PPol.PhiInGrad, 45.0F)
        Assert.AreEqual(PPol.Radius, CType(Math.Sqrt(2.0), Single))

    End Sub

    <TestMethod()>
    Public Sub CartesianToPolar_2()
        Dim PCart As New PointF With {.X = -1, .Y = 1}
        Dim PPol As New PointFPolar(PCart)

        Assert.AreEqual(PPol.PhiInGrad, 135.0F)
        Assert.AreEqual(PPol.Radius, CType(Math.Sqrt(2.0), Single))

    End Sub

    <TestMethod()>
    Public Sub CartesianToPolar_3()
        Dim PCart As New PointF With {.X = -1, .Y = -1}
        Dim PPol As New PointFPolar(PCart)

        Assert.AreEqual(PPol.PhiInGrad, 225.0F)
        Assert.AreEqual(PPol.Radius, CType(Math.Sqrt(2.0), Single))

    End Sub

    <TestMethod()>
    Public Sub CartesianToPolar_4()
        Dim PCart As New PointF With {.X = 1, .Y = -1}
        Dim PPol As New PointFPolar(PCart)

        Assert.AreEqual(PPol.PhiInGrad, 315.0F)
        Assert.AreEqual(PPol.Radius, CType(Math.Sqrt(2.0), Single))

    End Sub

    Function Round(v As Single) As Single
        Return CType(Math.Round(v, 4), Single)
    End Function


    <TestMethod()>
    Public Sub PolarToCartesian_1()

        Dim PPol As New PointFPolar(Math.Sqrt(2.0), Math.PI / 4)
        Dim PCart As PointF = PPol.ToPointF()

        Assert.AreEqual(Round(PCart.X), 1.0F)
        Assert.AreEqual(Round(PCart.Y), 1.0F)
    End Sub


    <TestMethod()>
    Public Sub PolarToCartesian_2()

        Dim PPol As New PointFPolar(Math.Sqrt(2.0), 3 * Math.PI / 4)
        Dim PCart As PointF = PPol.ToPointF()

        Assert.AreEqual(Round(PCart.X), -1.0F)
        Assert.AreEqual(Round(PCart.Y), 1.0F)
    End Sub

    <TestMethod()>
    Public Sub PolarToCartesian_3()

        Dim PPol As New PointFPolar(Math.Sqrt(2.0), 5 * Math.PI / 4)
        Dim PCart As PointF = PPol.ToPointF()

        Assert.AreEqual(Round(PCart.X), -1.0F)
        Assert.AreEqual(Round(PCart.Y), -1.0F)
    End Sub

    <TestMethod()>
    Public Sub PolarToCartesian_4()

        Dim PPol As New PointFPolar(Math.Sqrt(2.0), 7 * Math.PI / 4)
        Dim PCart As PointF = PPol.ToPointF()

        Assert.AreEqual(Round(PCart.X), 1.0F)
        Assert.AreEqual(Round(PCart.Y), -1.0F)
    End Sub



End Class
