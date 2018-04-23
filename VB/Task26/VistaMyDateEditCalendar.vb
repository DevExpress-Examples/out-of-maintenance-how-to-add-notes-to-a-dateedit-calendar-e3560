Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils

Namespace Task26
	Public Class VistaMyDateEditCalendar
		Inherits VistaDateEditCalendar
		Private fNoteMenu As ContextMenu

		Public Sub New(ByVal item As RepositoryItemMyDateEdit, ByVal editDate As Object)
			MyBase.New(item, editDate)
			fNoteMenu = CreateNoteMenu()
		End Sub

		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property

		Protected Overridable ReadOnly Property TipController() As ToolTipController
			Get
				Return ToolTipController.DefaultController
			End Get
		End Property

		Protected Overrides Function CreatePainter() As DevExpress.XtraEditors.Drawing.DateEditPainter
			Return New VistaMyDateEditCalendarPainter(Me)
		End Function

		Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
			If e.Button = MouseButtons.Right Then
				Dim HI As CalendarHitInfo = GetHitInfo(e)
				If HI.InfoType = CalendarHitInfoType.Item Then
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

		Protected Overrides Sub OnHotObjectChanged(ByVal prevInfo As CalendarHitInfo, ByVal currInfo As CalendarHitInfo)
			MyBase.OnHotObjectChanged(prevInfo, currInfo)
			If currInfo.InfoType = CalendarHitInfoType.Item Then
				Dim Notes As List(Of Note) = Properties.GetDateNotes(currInfo.HitDate)
				If Notes.Count > 0 Then
					Dim NotesList As String = ""
					For Each N As Note In Notes
						NotesList &= N.Date.ToShortTimeString() & ": " & N.Name + ControlChars.Lf
					Next N
					TipController.ShowHint(NotesList, currInfo.HitDate.ToShortDateString() & ": " & Notes.Count & " Notes.", PointToScreen(currInfo.Pt))
					Return
				End If
			End If
			TipController.HideHint()
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
