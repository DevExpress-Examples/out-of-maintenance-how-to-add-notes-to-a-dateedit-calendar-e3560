Imports Microsoft.VisualBasic
Imports System
Namespace Task26
	Partial Public Class Form1
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject6 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject7 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject8 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject9 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject10 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject11 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject12 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject13 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject14 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject15 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject16 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject17 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject18 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject19 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject20 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject21 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject22 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.myDateEdit1 = New Task26.MyDateEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMyDateEdit1 = New Task26.RepositoryItemMyDateEdit()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.myDateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMyDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myDateEdit1
			' 
			Me.myDateEdit1.EditValue = Nothing
			Me.myDateEdit1.Location = New System.Drawing.Point(12, 12)
			Me.myDateEdit1.Name = "myDateEdit1"
			Me.myDateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons1"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons2"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons3"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons4"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons5"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons6"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons7"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons8"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons9"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject12, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons10"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons11"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject14, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons12"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject15, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons13"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject16, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons14"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject17, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons15"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject18, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons16"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject19, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons17"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject20, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons18"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, "Note Alarm", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 16, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, (CType(resources.GetObject("myDateEdit1.Properties.Buttons19"), System.Drawing.Image)), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject22, "Note Alarm", Nothing, Nothing, False)})
			Me.myDateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			Me.myDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.myDateEdit1.Size = New System.Drawing.Size(349, 20)
			Me.myDateEdit1.TabIndex = 0
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(12, 38)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMyDateEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(349, 235)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Event"
			Me.gridColumn1.FieldName = "Event"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Date"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemMyDateEdit1
			Me.gridColumn2.FieldName = "Date"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' repositoryItemMyDateEdit1
			' 
			Me.repositoryItemMyDateEdit1.AutoHeight = False
			Me.repositoryItemMyDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMyDateEdit1.Name = "repositoryItemMyDateEdit1"
			Me.repositoryItemMyDateEdit1.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True
			Me.repositoryItemMyDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' checkEdit1
			' 
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(10, 279)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "MyDateEdit Vista Calendar"
			Me.checkEdit1.Size = New System.Drawing.Size(351, 19)
			Me.checkEdit1.TabIndex = 2
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(373, 305)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.myDateEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myDateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMyDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myDateEdit1 As MyDateEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyDateEdit1 As RepositoryItemMyDateEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit



	End Class
End Namespace

