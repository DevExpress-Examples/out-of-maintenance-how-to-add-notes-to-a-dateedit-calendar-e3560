using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Task26
{
    public partial class NoteForm : DevExpress.XtraEditors.XtraForm
    {
        public NoteForm(Note N)
        {
            InitializeComponent();
            TxName.DataBindings.Add("EditValue", N, "Name");
            MMText.DataBindings.Add("EditValue", N, "Text");
            DtEdDate.DataBindings.Add("DateTime", N, "Date");
        }
    }
}