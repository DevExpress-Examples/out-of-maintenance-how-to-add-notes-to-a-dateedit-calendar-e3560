using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace Task26
{
    public partial class Form1 : Form
    {
        DataTable DT;

        public Form1()
        {
            InitializeComponent();

            DT = new DataTable();

            DT.Columns.Add("Event", typeof(string));
            DT.Columns.Add("Date", typeof(DateTime));

            DT.Rows.Add("Meeting", new DateTime(2011, 10, 18));
            DT.Rows.Add("Liza's b-day", new DateTime(2011, 10, 24));
            DT.Rows.Add("Cinema", new DateTime(2011, 10, 30));
            DT.Rows.Add("Halloween", new DateTime(2011, 10, 31));

            gridControl1.DataSource = DT;

            myDateEdit1.DateTime = DateTime.Now;
            myDateEdit1.Properties.AddNote(new Note(DateTime.Now, "Test", "Hello World"));

            repositoryItemMyDateEdit1.AddNote(new Note(new DateTime(2011, 10, 31), "Halloween", "=)"));
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                myDateEdit1.Properties.VistaDisplayMode = DefaultBoolean.True;
                repositoryItemMyDateEdit1.VistaDisplayMode = DefaultBoolean.True;
            }
            else
            {
                myDateEdit1.Properties.VistaDisplayMode = DefaultBoolean.False;
                repositoryItemMyDateEdit1.VistaDisplayMode = DefaultBoolean.False;
            }
        }
    }
}