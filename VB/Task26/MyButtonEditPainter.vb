Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing

Namespace Task26
	Public Class MyDateEditPainter
		Inherits ButtonEditPainter
		Private fNoteIcon As Image

		Public Sub New()
			MyBase.New()
			Try
				fNoteIcon = Image.FromFile("NoteIcon.bmp")
			Catch
				fNoteIcon = Nothing
			End Try
		End Sub

		Public Overrides Sub Draw(ByVal info As ControlGraphicsInfoArgs)
			MyBase.Draw(info)
			DrawNoteIcon(info)
		End Sub

		Protected Overridable Sub DrawNoteIcon(ByVal info As ControlGraphicsInfoArgs)
			Dim VI As MyDateEditViewInfo = TryCast(info.ViewInfo, MyDateEditViewInfo)

			If VI.NoteIconRect <> Rectangle.Empty Then
				If fNoteIcon Is Nothing Then
					info.Graphics.FillEllipse(Brushes.Red, VI.NoteIconRect)
				Else
					info.Graphics.DrawImage(fNoteIcon, VI.NoteIconRect)
				End If
			End If
		End Sub
	End Class
End Namespace
