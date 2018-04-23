namespace Task26
{
    partial class SelectForm
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
            this.LBSelect = new DevExpress.XtraEditors.ListBoxControl();
            this.BtOk = new DevExpress.XtraEditors.SimpleButton();
            this.BtCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LBSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // LBSelect
            // 
            this.LBSelect.Location = new System.Drawing.Point(12, 12);
            this.LBSelect.Name = "LBSelect";
            this.LBSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBSelect.Size = new System.Drawing.Size(173, 204);
            this.LBSelect.TabIndex = 0;
            // 
            // BtOk
            // 
            this.BtOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtOk.Location = new System.Drawing.Point(110, 222);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 1;
            this.BtOk.Text = "Ok";
            // 
            // BtCancel
            // 
            this.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancel.Location = new System.Drawing.Point(12, 222);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 2;
            this.BtCancel.Text = "Cancel";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 252);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.LBSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Notes";
            ((System.ComponentModel.ISupportInitialize)(this.LBSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl LBSelect;
        private DevExpress.XtraEditors.SimpleButton BtOk;
        private DevExpress.XtraEditors.SimpleButton BtCancel;
    }
}