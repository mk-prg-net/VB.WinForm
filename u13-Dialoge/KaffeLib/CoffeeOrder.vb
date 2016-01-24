''' <summary>
''' IMplementiert ICoffee zur Übertragung von BEstelldaten 
''' </summary>
''' <remarks></remarks>
''' 
' Durch Serializable- Attribut wird die Klasse für den XmlSerialisierer freigeschaltet
<Serializable> _
<System.Xml.Serialization.XmlInclude(GetType(Kafeezusatz))> _
<System.Xml.Serialization.XmlInclude(GetType(Zucker))> _
<System.Xml.Serialization.XmlInclude(GetType(Milch))> _
<System.Xml.Serialization.XmlInclude(GetType(Sahne))> _
<System.Xml.Serialization.XmlInclude(GetType(Schokolade))> _
Public Class CoffeeOrder
    Implements ICoffee

    ''' <summary>
    ''' PArameterloser Konstruktor wird vom Serialisierer benötigt
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Erstellt aus einer vorhandenen Order eine Kopie 
    ''' </summary>
    ''' <param name="order"></param>
    ''' <remarks></remarks>
    Public Sub New(order As ICoffee)
        Hot = order.Hot
        Big = order.Big
        Additive = order.Additive
    End Sub

    Private _Kaffeezusaetze() As Kafeezusatz


    Public Property Additive As Kafeezusatz() Implements ICoffee.Additive
        Get
            Return _Kaffeezusaetze
        End Get
        Set(value As Kafeezusatz())
            _Kaffeezusaetze = value
        End Set
    End Property


    Public Property Big As Boolean Implements ICoffee.Big

    Public Property Hot As Boolean Implements ICoffee.Hot


    Public Overrides Function ToString() As String
        Dim bestellung As String = "Sie haben bestellt: " + vbCrLf

        If Big Then
            bestellung += "große Tasse" + vbCrLf
        Else
            bestellung += "kleine Tasse" + vbCrLf
        End If

        If Hot Then
            bestellung += "Temperatur: heiss" + vbCrLf
        Else
            bestellung += "Temperatur: kalt" + vbCrLf
        End If

        bestellung += "Zusätze: "

        For Each Add In Additive
            bestellung += Add.Name + ", "
        Next

        Return bestellung
    End Function

End Class
