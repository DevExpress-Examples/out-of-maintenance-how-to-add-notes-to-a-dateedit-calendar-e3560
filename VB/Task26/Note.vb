Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Text

Namespace Task26
	Public Class Note
		Implements INotifyPropertyChanged
		Private fDate As DateTime
		Private fName As String
		Private fText As String

		Public Sub New()
			Me.New(DateTime.Now)
		End Sub

		Public Sub New(ByVal [Date] As DateTime)
			Me.New([Date], "Unnamed", "")
		End Sub

		Public Sub New(ByVal [Date] As DateTime, ByVal Name As String, ByVal Text As String)
			fDate = [Date]
			fName = Name
			fText = Text
		End Sub

		Public Overridable Property [Date]() As DateTime
			Get
				Return fDate
			End Get
			Set(ByVal value As DateTime)
				If value <> fDate Then
					fDate = value
					RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Date"))
				End If
			End Set
		End Property

		Public Overridable Property Name() As String
			Get
				Return fName
			End Get
			Set(ByVal value As String)
				If value <> fName Then
					fName = value
					RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Name"))
				End If
			End Set
		End Property

		Public Overridable Property Text() As String
			Get
				Return fText
			End Get
			Set(ByVal value As String)
				If value <> fText Then
					fText = value
					RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Text"))
				End If
			End Set
		End Property

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		#End Region
	End Class
End Namespace
