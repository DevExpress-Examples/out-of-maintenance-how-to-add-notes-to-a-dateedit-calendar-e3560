Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Controls

Namespace Task26
	Public Class VistaPopupMyDateEditForm
		Inherits VistaPopupDateEditForm
		Public Sub New(ByVal ownerEdit As MyDateEdit)
			MyBase.New(ownerEdit)
		End Sub

		Public Shadows ReadOnly Property OwnerEdit() As MyDateEdit
			Get
				Return TryCast(MyBase.OwnerEdit, MyDateEdit)
			End Get
		End Property

		Protected Overrides Function CreateCalendar() As DateEditCalendar
			Return New VistaMyDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue)
		End Function

	End Class
End Namespace