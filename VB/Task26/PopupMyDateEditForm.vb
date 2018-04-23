Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Controls

Namespace Task26
	Public Class PopupMyDateEditForm
		Inherits PopupDateEditForm
		Public Sub New(ByVal ownerEdit As MyDateEdit)
			MyBase.New(ownerEdit)
		End Sub

		Public Shadows ReadOnly Property OwnerEdit() As MyDateEdit
			Get
				Return TryCast(MyBase.OwnerEdit, MyDateEdit)
			End Get
		End Property

		Protected Overrides Function CreateCalendar() As DateEditCalendar
			Return New MyDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)
		End Function
	End Class
End Namespace
