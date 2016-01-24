Public Interface ICoffee

    ''' <summary>
    ''' Wenn true, dann bitte ein heißen Kaffee
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Hot As Boolean

    ''' <summary>
    ''' Wenn true, dann eine große Tasse liefern
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Big As Boolean

    ''' <summary>
    ''' Liefert eine Liste von Kaffeezusätzen
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Additive As Kafeezusatz()

End Interface
