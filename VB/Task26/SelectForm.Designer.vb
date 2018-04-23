Imports Microsoft.VisualBasic
Imports System
Namespace Task26
	Partial Public Class SelectForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.LBSelect = New DevExpress.XtraEditors.ListBoxControl()
			Me.BtOk = New DevExpress.XtraEditors.SimpleButton()
			Me.BtCancel = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.LBSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' LBSelect
			' 
			Me.LBSelect.Location = New System.Drawing.Point(12, 12)
			Me.LBSelect.Name = "LBSelect"
			Me.LBSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
			Me.LBSelect.Size = New System.Drawing.Size(173, 204)
			Me.LBSelect.TabIndex = 0
			' 
			' BtOk
			' 
			Me.BtOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.BtOk.Location = New System.Drawing.Point(110, 222)
			Me.BtOk.Name = "BtOk"
			Me.BtOk.Size = New System.Drawing.Size(75, 23)
			Me.BtOk.TabIndex = 1
			Me.BtOk.Text = "Ok"
			' 
			' BtCancel
			' 
			Me.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.BtCancel.Location = New System.Drawing.Point(12, 222)
			Me.BtCancel.Name = "BtCancel"
			Me.BtCancel.Size = New System.Drawing.Size(75, 23)
			Me.BtCancel.TabIndex = 2
			Me.BtCancel.Text = "Cancel"
			' 
			' SelectForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(195, 252)
			Me.Controls.Add(Me.BtCancel)
			Me.Controls.Add(Me.BtOk)
			Me.Controls.Add(Me.LBSelect)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.Name = "SelectForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Select Notes"
			CType(Me.LBSelect, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private LBSelect As DevExpress.XtraEditors.ListBoxControl
		Private BtOk As DevExpress.XtraEditors.SimpleButton
		Private BtCancel As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace