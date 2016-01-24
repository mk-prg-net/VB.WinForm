''' <summary>
''' Definiert ein abgeschlossenes Intervall auf dem Zahlenstrahl
''' </summary>
''' <remarks></remarks>
Public Class Interval

    ' Konstruktoren
    Public Sub New(BeginInterval As Double, EndInterval As Double)
        _BeginInterval = BeginInterval
        _EndInterval = EndInterval
    End Sub


    Public ReadOnly Property BeginInterval As Double
        Get
            Return _BeginInterval
        End Get
    End Property
    Private _BeginInterval As Double

    Public ReadOnly Property EndInterval As Double
        Get
            Return _EndInterval
        End Get
    End Property
    Private _EndInterval As Double

    Public ReadOnly Property Length As Double
        Get
            Return EndInterval - BeginInterval
        End Get
    End Property




End Class
