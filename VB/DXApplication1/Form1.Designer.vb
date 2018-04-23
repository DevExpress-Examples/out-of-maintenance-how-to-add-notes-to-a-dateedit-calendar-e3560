Namespace DXApplication1
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
            Me.components = New System.ComponentModel.Container()
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.flyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel1.SuspendLayout()
            DirectCast(Me.flyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanelControl1.SuspendLayout()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dateEdit1
            ' 
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(447, 44)
            Me.dateEdit1.Name = "dateEdit1"
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Transparent
            serializableAppearanceObject1.BorderColor = System.Drawing.Color.Transparent
            serializableAppearanceObject1.Options.UseBackColor = True
            serializableAppearanceObject1.Options.UseBorderColor = True
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.Column_Priority, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True) _
            })
            Me.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.CellSize = New System.Drawing.Size(50, 50)
            Me.dateEdit1.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateEdit1.Size = New System.Drawing.Size(247, 20)
            Me.dateEdit1.TabIndex = 0
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("groupbyresource_16x16.png", "images/scheduling/groupbyresource_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/groupbyresource_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "groupbyresource_16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "Column_Priority.png")
            ' 
            ' flyoutPanel1
            ' 
            Me.flyoutPanel1.Controls.Add(Me.flyoutPanelControl1)
            Me.flyoutPanel1.Location = New System.Drawing.Point(447, 175)
            Me.flyoutPanel1.Name = "flyoutPanel1"
            Me.flyoutPanel1.Size = New System.Drawing.Size(150, 150)
            Me.flyoutPanel1.TabIndex = 1
            ' 
            ' flyoutPanelControl1
            ' 
            Me.flyoutPanelControl1.Controls.Add(Me.memoEdit1)
            Me.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flyoutPanelControl1.FlyoutPanel = Me.flyoutPanel1
            Me.flyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.flyoutPanelControl1.Name = "flyoutPanelControl1"
            Me.flyoutPanelControl1.Size = New System.Drawing.Size(150, 150)
            Me.flyoutPanelControl1.TabIndex = 0
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.Location = New System.Drawing.Point(2, 2)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(146, 146)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(387, 475)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "gridColumn1"
            Me.gridColumn1.FieldName = "ID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "gridColumn2"
            Me.gridColumn2.FieldName = "Name"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "gridColumn3"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemDateEdit1
            Me.gridColumn3.FieldName = "Time"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' repositoryItemDateEdit1
            ' 
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True) _
            })
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(703, 475)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.flyoutPanel1)
            Me.Controls.Add(Me.dateEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.dateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.flyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel1.ResumeLayout(False)
            DirectCast(Me.flyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanelControl1.ResumeLayout(False)
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents dateEdit1 As DevExpress.XtraEditors.DateEdit
        Private flyoutPanel1 As DevExpress.Utils.FlyoutPanel
        Private flyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Private imageCollection1 As DevExpress.Utils.ImageCollection

    End Class
End Namespace

