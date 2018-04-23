Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils

Namespace Task26
	Public Class MyDateEditCalendar
		Inherits DateEditCalendar
		Private fLastHitInfoDate As DateTime
		Private fNoteMenu As ContextMenu

		Public Sub New(ByVal item As RepositoryItemMyDateEdit, ByVal editDate As Object)
			MyBase.New(item, editDate)
			fLastHitInfoDate = New DateTime()
			fNoteMenu = CreateNoteMenu()
		End Sub

		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property

		Protected Overrides Function CreatePainter() As DateEditPainter
			Return New MyDateEditCalendarPainter(Me)
		End Function

		Protected Overridable ReadOnly Property TipController() As ToolTipController
			Get
				Return ToolTipController.DefaultController
			End Get
		End Property

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Right Then
				Dim HI As CalendarHitInfo = GetHitInfo(e)
				If HI.InfoType = CalendarHitInfoType.MonthNumber Then
					Me.DateTime = HI.HitDate
					Dim NotEmpty As Boolean = Properties.HaveNote(HI.HitDate)
					fNoteMenu.MenuItems(1).Enabled = NotEmpty
					fNoteMenu.MenuItems(2).Enabled = NotEmpty
					fNoteMenu.Show(Me, e.Location)
				End If
			Else
				MyBase.OnMouseUp(e)
			End If
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Dim HI As CalendarHitInfo = GetHitInfo(e)
			If HI.InfoType = CalendarHitInfoType.MonthNumber Then
				If HI.HitDate <> fLastHitInfoDate Then
					fLastHitInfoDate = HI.HitDate
					Dim Notes As List(Of Note) = Properties.GetDateNotes(HI.HitDate)
					If Notes.Count > 0 Then
						Dim NotesList As String = ""
						For Each N As Note In Notes
							NotesList &= N.Date.ToShortTimeString() & ": " & N.Name + ControlChars.Lf
						Next N
						TipController.ShowHint(NotesList, HI.HitDate.ToShortDateString() & ": " & Notes.Count & " Notes.", PointToScreen(e.Location))
						Return
					Else
						TipController.HideHint()
					End If
				End If
			Else
				TipController.HideHint()
			End If
		End Sub

		Protected Overridable Function CreateNoteMenu() As ContextMenu
			Dim CM As New ContextMenu()
			CM.MenuItems.Add(New MenuItem("Add Note...", New EventHandler(AddressOf OnMenuAddNote_Click)))

			CM.MenuItems.Add(New MenuItem("Edit...", New EventHandler(AddressOf OnMenuEditNote_Click)))
			CM.MenuItems.Add(New MenuItem("Delete...", New EventHandler(AddressOf OnMenuDeleteNote_Click)))

			Return CM
		End Function

		Protected Overridable Sub OnMenuAddNote_Click(ByVal sender As Object, ByVal e As EventArgs)
			Properties.AddNote(DateTime)
		End Sub

		Protected Overridable Sub OnMenuEditNote_Click(ByVal sender As Object, ByVal e As EventArgs)
			Properties.EditNotes(DateTime)
		End Sub

		Protected Overridable Sub OnMenuDeleteNote_Click(ByVal sender As Object, ByVal e As EventArgs)
			Properties.DeleteNotes(DateTime)
		End Sub
	End Class
End Namespace
