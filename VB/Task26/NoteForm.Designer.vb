Imports Microsoft.VisualBasic
Imports System
Namespace Task26
	Partial Public Class NoteForm
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
			Me.BtOk = New DevExpress.XtraEditors.SimpleButton()
			Me.BtCancel = New DevExpress.XtraEditors.SimpleButton()
			Me.LbName = New DevExpress.XtraEditors.LabelControl()
			Me.TxName = New DevExpress.XtraEditors.TextEdit()
			Me.LbText = New DevExpress.XtraEditors.LabelControl()
			Me.MMText = New DevExpress.XtraEditors.MemoEdit()
			Me.DtEdDate = New DevExpress.XtraEditors.DateEdit()
			Me.LbDate = New System.Windows.Forms.Label()
			CType(Me.TxName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.MMText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DtEdDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.DtEdDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' BtOk
			' 
			Me.BtOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.BtOk.Location = New System.Drawing.Point(158, 266)
			Me.BtOk.Name = "BtOk"
			Me.BtOk.Size = New System.Drawing.Size(75, 23)
			Me.BtOk.TabIndex = 0
			Me.BtOk.Text = "Ok"
			' 
			' BtCancel
			' 
			Me.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.BtCancel.Location = New System.Drawing.Point(52, 266)
			Me.BtCancel.Name = "BtCancel"
			Me.BtCancel.Size = New System.Drawing.Size(75, 23)
			Me.BtCancel.TabIndex = 1
			Me.BtCancel.Text = "Cancel"
			' 
			' LbName
			' 
			Me.LbName.Location = New System.Drawing.Point(12, 12)
			Me.LbName.Name = "LbName"
			Me.LbName.Size = New System.Drawing.Size(31, 13)
			Me.LbName.TabIndex = 2
			Me.LbName.Text = "Name:"
			' 
			' TxName
			' 
			Me.TxName.Location = New System.Drawing.Point(52, 9)
			Me.TxName.Name = "TxName"
			Me.TxName.Size = New System.Drawing.Size(220, 20)
			Me.TxName.TabIndex = 3
			' 
			' LbText
			' 
			Me.LbText.Location = New System.Drawing.Point(131, 35)
			Me.LbText.Name = "LbText"
			Me.LbText.Size = New System.Drawing.Size(22, 13)
			Me.LbText.TabIndex = 4
			Me.LbText.Text = "Text"
			' 
			' MMText
			' 
			Me.MMText.Location = New System.Drawing.Point(12, 54)
			Me.MMText.Name = "MMText"
			Me.MMText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
			Me.MMText.Properties.WordWrap = False
			Me.MMText.Size = New System.Drawing.Size(260, 167)
			Me.MMText.TabIndex = 5
			' 
			' DtEdDate
			' 
			Me.DtEdDate.EditValue = Nothing
			Me.DtEdDate.Location = New System.Drawing.Point(52, 231)
			Me.DtEdDate.Name = "DtEdDate"
			Me.DtEdDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.DtEdDate.Properties.DisplayFormat.FormatString = "g"
			Me.DtEdDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.DtEdDate.Properties.EditFormat.FormatString = "g"
			Me.DtEdDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.DtEdDate.Properties.Mask.EditMask = "g"
			Me.DtEdDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
			Me.DtEdDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.DtEdDate.Size = New System.Drawing.Size(220, 20)
			Me.DtEdDate.TabIndex = 6
			' 
			' LbDate
			' 
			Me.LbDate.AutoSize = True
			Me.LbDate.Location = New System.Drawing.Point(12, 234)
			Me.LbDate.Name = "LbDate"
			Me.LbDate.Size = New System.Drawing.Size(34, 13)
			Me.LbDate.TabIndex = 7
			Me.LbDate.Text = "Date:"
			' 
			' NoteForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 297)
			Me.Controls.Add(Me.LbDate)
			Me.Controls.Add(Me.DtEdDate)
			Me.Controls.Add(Me.MMText)
			Me.Controls.Add(Me.LbText)
			Me.Controls.Add(Me.TxName)
			Me.Controls.Add(Me.LbName)
			Me.Controls.Add(Me.BtCancel)
			Me.Controls.Add(Me.BtOk)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Name = "NoteForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Note"
			CType(Me.TxName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.MMText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DtEdDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.DtEdDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private BtOk As DevExpress.XtraEditors.SimpleButton
		Private BtCancel As DevExpress.XtraEditors.SimpleButton
		Private LbName As DevExpress.XtraEditors.LabelControl
		Private TxName As DevExpress.XtraEditors.TextEdit
		Private LbText As DevExpress.XtraEditors.LabelControl
		Private MMText As DevExpress.XtraEditors.MemoEdit
		Private DtEdDate As DevExpress.XtraEditors.DateEdit
		Private LbDate As System.Windows.Forms.Label
	End Class
End Namespace