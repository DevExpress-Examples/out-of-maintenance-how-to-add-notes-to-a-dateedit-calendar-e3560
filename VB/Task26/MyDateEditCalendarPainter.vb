Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Calendar

Namespace Task26
	Public Class MyDateEditCalendarPainter
		Inherits DateEditPainter
		Public Sub New(ByVal calendar As MyDateEditCalendar)
			MyBase.New(calendar)
		End Sub

		Public Shadows ReadOnly Property Calendar() As MyDateEditCalendar
			Get
				Return TryCast(MyBase.Calendar, MyDateEditCalendar)
			End Get
		End Property

		Public Overrides Sub DrawDayCellText(ByVal cell As DayNumberCellInfo, ByVal brush As Brush)
			MyBase.DrawDayCellText(cell, brush)
			If Calendar.Properties.HaveNote(cell.Date) Then
				DrawMarker(cell.Bounds, cell.Graphics)
			End If
		End Sub

		Protected Overridable Sub DrawMarker(ByVal Bounds As Rectangle, ByVal G As Graphics)
			Dim MarkerWidth As Integer = Bounds.Width / 4
			Dim Marker() As Point = { New Point(Bounds.Right - MarkerWidth, Bounds.Bottom), New Point(Bounds.Right, Bounds.Bottom - MarkerWidth), New Point(Bounds.Right, Bounds.Bottom) }
			G.DrawPolygon(Pens.Red, Marker)
		End Sub
	End Class
End Namespace
