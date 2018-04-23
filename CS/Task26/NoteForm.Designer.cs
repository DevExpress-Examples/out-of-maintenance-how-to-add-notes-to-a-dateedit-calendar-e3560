namespace Task26
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtOk = new DevExpress.XtraEditors.SimpleButton();
            this.BtCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LbName = new DevExpress.XtraEditors.LabelControl();
            this.TxName = new DevExpress.XtraEditors.TextEdit();
            this.LbText = new DevExpress.XtraEditors.LabelControl();
            this.MMText = new DevExpress.XtraEditors.MemoEdit();
            this.DtEdDate = new DevExpress.XtraEditors.DateEdit();
            this.LbDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEdDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEdDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtOk
            // 
            this.BtOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtOk.Location = new System.Drawing.Point(158, 266);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 0;
            this.BtOk.Text = "Ok";
            // 
            // BtCancel
            // 
            this.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancel.Location = new System.Drawing.Point(52, 266);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 1;
            this.BtCancel.Text = "Cancel";
            // 
            // LbName
            // 
            this.LbName.Location = new System.Drawing.Point(12, 12);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(31, 13);
            this.LbName.TabIndex = 2;
            this.LbName.Text = "Name:";
            // 
            // TxName
            // 
            this.TxName.Location = new System.Drawing.Point(52, 9);
            this.TxName.Name = "TxName";
            this.TxName.Size = new System.Drawing.Size(220, 20);
            this.TxName.TabIndex = 3;
            // 
            // LbText
            // 
            this.LbText.Location = new System.Drawing.Point(131, 35);
            this.LbText.Name = "LbText";
            this.LbText.Size = new System.Drawing.Size(22, 13);
            this.LbText.TabIndex = 4;
            this.LbText.Text = "Text";
            // 
            // MMText
            // 
            this.MMText.Location = new System.Drawing.Point(12, 54);
            this.MMText.Name = "MMText";
            this.MMText.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MMText.Properties.WordWrap = false;
            this.MMText.Size = new System.Drawing.Size(260, 167);
            this.MMText.TabIndex = 5;
            // 
            // DtEdDate
            // 
            this.DtEdDate.EditValue = null;
            this.DtEdDate.Location = new System.Drawing.Point(52, 231);
            this.DtEdDate.Name = "DtEdDate";
            this.DtEdDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEdDate.Properties.DisplayFormat.FormatString = "g";
            this.DtEdDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtEdDate.Properties.EditFormat.FormatString = "g";
            this.DtEdDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtEdDate.Properties.Mask.EditMask = "g";
            this.DtEdDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.DtEdDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtEdDate.Size = new System.Drawing.Size(220, 20);
            this.DtEdDate.TabIndex = 6;
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(12, 234);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(34, 13);
            this.LbDate.TabIndex = 7;
            this.LbDate.Text = "Date:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.DtEdDate);
            this.Controls.Add(this.MMText);
            this.Controls.Add(this.LbText);
            this.Controls.Add(this.TxName);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Note";
            ((System.ComponentModel.ISupportInitialize)(this.TxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEdDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEdDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtOk;
        private DevExpress.XtraEditors.SimpleButton BtCancel;
        private DevExpress.XtraEditors.LabelControl LbName;
        private DevExpress.XtraEditors.TextEdit TxName;
        private DevExpress.XtraEditors.LabelControl LbText;
        private DevExpress.XtraEditors.MemoEdit MMText;
        private DevExpress.XtraEditors.DateEdit DtEdDate;
        private System.Windows.Forms.Label LbDate;
    }
}