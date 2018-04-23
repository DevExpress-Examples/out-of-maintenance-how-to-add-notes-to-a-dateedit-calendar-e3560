Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Calendar

Namespace Task26
	Friend Class VistaMyDateEditCalendarPainter
		Inherits VistaDateEditPainter
		Public Sub New(ByVal calendar As VistaMyDateEditCalendar)
			MyBase.New(calendar)
		End Sub

		Public Shadows ReadOnly Property Calendar() As VistaMyDateEditCalendar
			Get
				Return TryCast(MyBase.Calendar, VistaMyDateEditCalendar)
			End Get
		End Property

		Protected Overrides Sub DrawDayCell(ByVal info As CalendarObjectInfoArgs, ByVal cell As DayNumberCellInfo)
			MyBase.DrawDayCell(info, cell)
			If Calendar.Properties.HaveNote(cell.Date) Then
				DrawMarker(cell.Bounds, info.Graphics)
			End If
		End Sub

		Protected Overridable Sub DrawMarker(ByVal Bounds As Rectangle, ByVal G As Graphics)
			Dim MarkerWidth As Integer = Bounds.Width \ 4
			Dim Marker() As Point = { New Point(Bounds.Right - MarkerWidth, Bounds.Bottom), New Point(Bounds.Right, Bounds.Bottom - MarkerWidth), New Point(Bounds.Right, Bounds.Bottom) }
			G.DrawPolygon(Pens.Red, Marker)
		End Sub
	End Class
End Namespace
