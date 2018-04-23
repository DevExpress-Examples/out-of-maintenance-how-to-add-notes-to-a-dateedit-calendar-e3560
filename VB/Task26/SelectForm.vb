Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace Task26
	Partial Public Class SelectForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Function SelectNotes(ByVal Notes As List(Of Note)) As List(Of Note)
			Text = "Select Notes"

			Dim Res As New List(Of Note)()

			LBSelect.Items.Clear()
			LBSelect.SelectionMode = SelectionMode.MultiSimple


			For Each N As Note In Notes
				LBSelect.Items.Add(N.Name)
			Next N

			If ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				For Each i As Integer In LBSelect.SelectedIndices
					Res.Add(Notes(i))
				Next i
			End If

			Return Res
		End Function

		Public Function SelectNote(ByVal Notes As List(Of Note)) As Integer
			Text = "Select Note"

			LBSelect.Items.Clear()
			LBSelect.SelectionMode = SelectionMode.One

			For Each N As Note In Notes
				LBSelect.Items.Add(N.Name)
			Next N

			If ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Return LBSelect.SelectedIndex
			End If
			Return -1
		End Function
	End Class
End Namespace