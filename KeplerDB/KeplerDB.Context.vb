﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Dieser Code wurde aus einer Vorlage generiert.
'
'    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
'    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class KeplerDBEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=KeplerDBEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property AufgabenTab() As DbSet(Of AufgabenTab)
    Public Property BildTab() As DbSet(Of BildTab)
    Public Property HimmelskoerperTab() As DbSet(Of HimmelskoerperTab)
    Public Property HimmelskoerperTypenTab() As DbSet(Of HimmelskoerperTypenTab)
    Public Property LaenderTab() As DbSet(Of LaenderTab)
    Public Property RaumschiffeTab() As DbSet(Of RaumschiffeTab)
    Public Property SpektralklasseTab() As DbSet(Of SpektralklasseTab)
    Public Property Sterne_Planeten_MondeTab() As DbSet(Of Sterne_Planeten_MondeTab)
    Public Property UmlaufbahnenTab() As DbSet(Of UmlaufbahnenTab)
    Public Property UrlSammlungenTab() As DbSet(Of UrlSammlungenTab)

End Class
