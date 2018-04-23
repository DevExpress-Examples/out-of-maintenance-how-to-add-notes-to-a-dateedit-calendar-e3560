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
	Partial Public Class NoteForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal N As Note)
			InitializeComponent()
			TxName.DataBindings.Add("EditValue", N, "Name")
			MMText.DataBindings.Add("EditValue", N, "Text")
			DtEdDate.DataBindings.Add("DateTime", N, "Date")
		End Sub
	End Class
End Namespace