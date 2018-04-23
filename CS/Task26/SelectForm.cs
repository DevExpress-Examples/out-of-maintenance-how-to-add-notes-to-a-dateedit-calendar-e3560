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
    public partial class SelectForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        public List<Note> SelectNotes(List<Note> Notes)
        {
            Text = "Select Notes";

            List<Note> Res = new List<Note>();

            LBSelect.Items.Clear();
            LBSelect.SelectionMode = SelectionMode.MultiSimple;


            foreach (Note N in Notes)
            {
                LBSelect.Items.Add(N.Name);
            }

            if (ShowDialog() == DialogResult.OK)
            {
                foreach (int i in LBSelect.SelectedIndices)
                {
                    Res.Add(Notes[i]);
                }
            };

            return Res;
        }

        public int SelectNote(List<Note> Notes)
        {
            Text = "Select Note";
            
            LBSelect.Items.Clear();
            LBSelect.SelectionMode = SelectionMode.One;

            foreach (Note N in Notes)
            {
                LBSelect.Items.Add(N.Name);
            }

            if (ShowDialog() == DialogResult.OK)
            {
                return LBSelect.SelectedIndex;
            };
            return -1;
        }
    }
}