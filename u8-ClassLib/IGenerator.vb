Public Interface IGenerator

    Function GenerateX(Interval As Interval, SampleCount As Integer) As Double()

    Function GenerateY(Interval As Interval, SampleCount As Integer) As Double()

End Interface
