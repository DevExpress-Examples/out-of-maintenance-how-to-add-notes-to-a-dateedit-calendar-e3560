Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace Task26
	Public Class MyDateEditViewInfo
		Inherits DateEditViewInfo
		Private fNoteIconRect As Rectangle

		Public Property NoteIconRect() As Rectangle
			Get
				Return fNoteIconRect
			End Get
			Private Set(ByVal value As Rectangle)
				fNoteIconRect = value
			End Set
		End Property

		Public Sub New(ByVal item As RepositoryItemMyDateEdit)
			MyBase.New(item)
		End Sub

		Protected Shadows ReadOnly Property Item() As RepositoryItemMyDateEdit
			Get
				Return TryCast(MyBase.Item, RepositoryItemMyDateEdit)
			End Get
		End Property

		Protected Overrides Function CalcMaskBoxRect(ByVal content As Rectangle, ByRef emptyRect As Rectangle) As Rectangle
			Dim MaskBoxRect As Rectangle = MyBase.CalcMaskBoxRect(content, emptyRect)
			If Item.HaveActiveNotes Then
				MaskBoxRect.Width -= MaskBoxRect.Height
			End If
			Return MaskBoxRect
		End Function

		Protected Overridable Function CalcNoteIconRect() As Rectangle
			If Item.HaveActiveNotes Then
				Return New Rectangle(MaskBoxRect.Right, MaskBoxRect.Y, MaskBoxRect.Height, MaskBoxRect.Height)
			Else
				Return Rectangle.Empty
			End If
		End Function

		Protected Overrides Sub CalcRects()
			MyBase.CalcRects()
			NoteIconRect = CalcNoteIconRect()
		End Sub
	End Class
End Namespace
