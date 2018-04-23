Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils

Namespace Task26
   <UserRepositoryItem("RegisterMyDateEdit")> _
   Public Class RepositoryItemMyDateEdit
	   Inherits RepositoryItemDateEdit
		Private fNotes As List(Of Note)
		Private fActiveNotes As List(Of Note)
		Private fNoteForm As NoteForm
		Private fSelectForm As SelectForm

	   Shared Sub New()
		   RegisterMyDateEdit()
	   End Sub

		Public Sub New()
			fNotes = New List(Of Note)()
			fActiveNotes = New List(Of Note)()
			fSelectForm = New SelectForm()
		End Sub

		Public Const MyDateEditName As String = "MyDateEdit"

	   Public ReadOnly Property IsVistaDisplay() As Boolean
		   Get
			   Return IsVistaDisplayMode()
		   End Get
	   End Property

	   Public Overrides ReadOnly Property EditorTypeName() As String
		   Get
			   Return MyDateEditName
		   End Get
	   End Property

		Public Shared Sub RegisterMyDateEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyDateEditName, GetType(MyDateEdit), GetType(RepositoryItemMyDateEdit), GetType(MyDateEditViewInfo), New MyDateEditPainter(), True))
		End Sub

		Public Overridable ReadOnly Property Notes() As List(Of Note)
			Get
				Return fNotes
			End Get
		End Property

		Public Overridable ReadOnly Property ActiveNotes() As List(Of Note)
			Get
				Return fActiveNotes
			End Get
		End Property

		Protected Overridable ReadOnly Property EditorDate() As DateTime
			Get
				If OwnerEdit Is Nothing Then
					Return New DateTime()
				Else
					Return OwnerEdit.DateTime
				End If
			End Get
		End Property

		Public ReadOnly Property HaveActiveNotes() As Boolean
			Get
				Return ActiveNotes.Count > 0
			End Get
		End Property

		Public Overridable Function GetDateNotes(ByVal [Date] As DateTime) As List(Of Note)
			Dim Res As New List(Of Note)()

			For Each N As Note In Notes
				If N.Date.Date = [Date].Date Then
					Res.Add(N)
				End If
			Next N

			Return Res
		End Function

	   Public Sub AddNote(ByVal N As Note)
		   Notes.Add(N)
		   CheckNotes()
	   End Sub

	   Public Sub AddNote()
			AddNote(EditorDate)
	   End Sub

	   Public Overridable Sub AddNote(ByVal [Date] As DateTime)
		   Dim NewNote As New Note([Date].Date)
		   fNoteForm = New NoteForm(NewNote)
		   If fNoteForm.ShowDialog() = DialogResult.OK Then
			   Notes.Add(NewNote)
			   CheckNotes()
		   End If
		   fNoteForm.Dispose()
	   End Sub

		Public Sub EditNote(ByVal N As Note)
			Dim Index As Integer = Notes.IndexOf(N)
			If Index >= 0 Then
				EditNote(Index)
			End If
		End Sub

	   Public Overridable Sub EditNote(ByVal Index As Integer)
		   If (Index >= 0) AndAlso (Index < Notes.Count) Then
			   Dim Tmp As Note = Notes(Index)
			   fNoteForm = New NoteForm(Tmp)
			   If fNoteForm.ShowDialog() = DialogResult.OK Then
				   Notes(Index) = Tmp
				   CheckNotes()
			   End If
			   fNoteForm.Dispose()
		   End If
	   End Sub

		Public Overridable Sub EditNotes(ByVal [Date] As DateTime)
			Dim LN As List(Of Note) = GetDateNotes([Date])

			If LN.Count > 0 Then
				If LN.Count = 1 Then
					EditNote(LN(0))
				Else
					Dim SelIndex As Integer = fSelectForm.SelectNote(LN)
					EditNote(SelIndex)
				End If
			End If
		End Sub

		Public Overridable Function HaveNote(ByVal [Date] As DateTime) As Boolean
			For Each N As Note In Notes
				If N.Date.Date = [Date].Date Then
					Return True
				End If
			Next N
			Return False
		End Function

	   Public Overridable Sub DeleteNotes(ByVal [Date] As DateTime)
			Dim LN As List(Of Note) = GetDateNotes([Date])

			If LN.Count > 0 Then
				If LN.Count = 1 Then
					Notes.Remove(LN(0))
				Else
					Dim Selection As List(Of Note) = fSelectForm.SelectNotes(LN)
					For Each N As Note In Selection
						If ActiveNotes.Contains(N) Then
							ActiveNotes.Remove(N)
						End If
						Notes.Remove(N)
					Next N
				End If
				CheckNotes()
			End If
	   End Sub

		Public Overridable Sub CheckNotes()
			Dim LN As List(Of Note) = GetDateNotes(EditorDate)

			For i As Integer = ActiveNotes.Count-1 To 0 Step -1
				If ActiveNotes(i).Date.Date <> EditorDate.Date Then
					ActiveNotes.RemoveAt(i)
				End If
			Next i

			For Each N As Note In LN
				If (N.Date.Date = EditorDate.Date) AndAlso (Not ActiveNotes.Contains(N)) Then
					ActiveNotes.Add(N)
				End If
			Next N
		End Sub

	   Protected Friend Overridable Sub OnNoteIconClicked()
		   If ActiveNotes.Count > 0 Then
			   Dim Index As Integer = If((ActiveNotes.Count = 1), 0, fSelectForm.SelectNote(ActiveNotes))
			   EditNote(ActiveNotes(Index))
		   End If
	   End Sub

		Public Overrides Function CreateViewInfo() As BaseEditViewInfo
			Return New MyDateEditViewInfo(Me)
		End Function

	   Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemMyDateEdit = TryCast(item, RepositoryItemMyDateEdit)
				If source Is Nothing Then
					Return
				End If

				fNotes = source.fNotes
			Finally
				EndUpdate()
			End Try
	   End Sub

	   Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
		   If disposing Then
			   fSelectForm.Dispose()
		   End If
	   End Sub
   End Class
End Namespace
