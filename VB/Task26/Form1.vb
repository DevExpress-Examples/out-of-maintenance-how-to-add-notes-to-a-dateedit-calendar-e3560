Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace Task26
	Partial Public Class Form1
		Inherits Form
		Private DT As DataTable

		Public Sub New()
			InitializeComponent()

			DT = New DataTable()

			DT.Columns.Add("Event", GetType(String))
			DT.Columns.Add("Date", GetType(DateTime))

			DT.Rows.Add("Meeting", New DateTime(2011, 10, 18))
			DT.Rows.Add("Liza's b-day", New DateTime(2011, 10, 24))
			DT.Rows.Add("Cinema", New DateTime(2011, 10, 30))
			DT.Rows.Add("Halloween", New DateTime(2011, 10, 31))

			gridControl1.DataSource = DT

			myDateEdit1.DateTime = DateTime.Now
			myDateEdit1.Properties.AddNote(New Note(DateTime.Now, "Test", "Hello World"))

			repositoryItemMyDateEdit1.AddNote(New Note(New DateTime(2011, 10, 31), "Halloween", "=)"))
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			If checkEdit1.Checked Then
				myDateEdit1.Properties.VistaDisplayMode = DefaultBoolean.True
				repositoryItemMyDateEdit1.VistaDisplayMode = DefaultBoolean.True
			Else
				myDateEdit1.Properties.VistaDisplayMode = DefaultBoolean.False
				repositoryItemMyDateEdit1.VistaDisplayMode = DefaultBoolean.False
			End If
		End Sub
	End Class
End Namespace