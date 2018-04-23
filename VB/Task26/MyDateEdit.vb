Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu

Namespace Task26
	Public Class MyDateEdit
		Inherits DateEdit

		Shared Sub New()
			RepositoryItemMyDateEdit.RegisterMyDateEdit()
		End Sub

		Public Sub New()
		End Sub

		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.IsVistaDisplay Then
				Return New VistaPopupMyDateEditForm(Me)
			Else
				Return New PopupMyDateEditForm(Me)
			End If
		End Function

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyDateEdit.MyDateEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyDateEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyDateEdit)
			End Get
		End Property

		Public Shadows ReadOnly Property ViewInfo() As MyDateEditViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, MyDateEditViewInfo)
			End Get
		End Property

		Protected Overrides Function CreateMenu() As DXPopupMenu
			Dim Mn As DXPopupMenu = MyBase.CreateMenu()
			Dim MenuAdd As New DXMenuItem("Add Note...", New EventHandler(AddressOf OnMenuAdd_Click))
			MenuAdd.BeginGroup = True
			Mn.Items.Add(MenuAdd)
			Return Mn
		End Function

		Protected Overridable Sub OnMenuAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
			Properties.AddNote(DateTime)
		End Sub

		Protected Overrides Sub OnEditValueChanged()
			MyBase.OnEditValueChanged()
			Properties.CheckNotes()
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
			MyBase.OnMouseDown(e)
			If e.Button = MouseButtons.Left Then
				If ViewInfo.NoteIconRect.Contains(e.Location) Then
					Properties.OnNoteIconClicked()
				End If
			End If
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If ViewInfo.NoteIconRect.Contains(e.Location) Then
				Dim NotesList As String = ""
				For Each N As Note In Properties.ActiveNotes
					NotesList &= N.Date.ToShortTimeString() & ": " & N.Name + ControlChars.Lf
				Next N
				ToolTipController.DefaultController.ShowHint(NotesList, "You have " & Properties.ActiveNotes.Count & " active notes!", PointToScreen(e.Location))
			End If
		End Sub
	End Class
End Namespace
