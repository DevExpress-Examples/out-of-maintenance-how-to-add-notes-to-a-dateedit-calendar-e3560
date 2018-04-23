using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Calendar;
using DevExpress.Utils.Menu;
using DevExpress.Utils;

namespace Task26
{
    public class VistaMyDateEditCalendar : VistaDateEditCalendar
    {
        ContextMenu fNoteMenu;

        public VistaMyDateEditCalendar(RepositoryItemMyDateEdit item, object editDate)
            : base(item, editDate)
        {
            fNoteMenu = CreateNoteMenu();
        }

        public new RepositoryItemMyDateEdit Properties
        {
            get { return base.Properties as RepositoryItemMyDateEdit; }
        }

        protected virtual ToolTipController TipController
        {
            get { return ToolTipController.DefaultController; }
        }

        protected override DevExpress.XtraEditors.Drawing.DateEditPainter CreatePainter()
        {
            return new VistaMyDateEditCalendarPainter(this);
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CalendarHitInfo HI = GetHitInfo(e);
                if (HI.InfoType == CalendarHitInfoType.Item)
                {
                    this.DateTime = HI.HitDate;
                    bool NotEmpty = Properties.HaveNote(HI.HitDate);
                    fNoteMenu.MenuItems[1].Enabled = NotEmpty;
                    fNoteMenu.MenuItems[2].Enabled = NotEmpty;
                    fNoteMenu.Show(this, e.Location);
                }
            }
            else
                base.OnMouseUp(e);
        }

        protected override void OnHotObjectChanged(CalendarHitInfo prevInfo, CalendarHitInfo currInfo)
        {
            base.OnHotObjectChanged(prevInfo, currInfo);
            if (currInfo.InfoType == CalendarHitInfoType.Item)
            {
                List<Note> Notes = Properties.GetDateNotes(currInfo.HitDate);
                if (Notes.Count > 0)
                {
                    string NotesList = "";
                    foreach (Note N in Notes)
                    {
                        NotesList += N.Date.ToShortTimeString() + ": " + N.Name + '\n';
                    }
                    TipController.ShowHint(NotesList, currInfo.HitDate.ToShortDateString() + ": " + Notes.Count + " Notes.", PointToScreen(currInfo.Pt));
                    return;
                }
            }
            TipController.HideHint();
        }
        
        protected virtual ContextMenu CreateNoteMenu()
        {
            ContextMenu CM = new ContextMenu();
            CM.MenuItems.Add(new MenuItem("Add Note...", new EventHandler(OnMenuAddNote_Click)));
           
            CM.MenuItems.Add(new MenuItem("Edit...", new EventHandler(OnMenuEditNote_Click)));
            CM.MenuItems.Add(new MenuItem("Delete...", new EventHandler(OnMenuDeleteNote_Click)));

            return CM;
        }

        protected virtual void OnMenuAddNote_Click(object sender, EventArgs e)
        {
            Properties.AddNote(DateTime);
        }

        protected virtual void OnMenuEditNote_Click(object sender, EventArgs e)
        {
            Properties.EditNotes(DateTime);
        }

        protected virtual void OnMenuDeleteNote_Click(object sender, EventArgs e)
        {
            Properties.DeleteNotes(DateTime);
        }
    }
}
