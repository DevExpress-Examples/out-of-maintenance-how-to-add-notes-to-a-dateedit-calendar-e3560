using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Calendar;
using DevExpress.Utils.Menu;
using DevExpress.Utils;

namespace Task26
{
    public class MyDateEditCalendar : DateEditCalendar
    {
        DateTime fLastHitInfoDate;
        ContextMenu fNoteMenu;
        
        public MyDateEditCalendar(RepositoryItemMyDateEdit item, object editDate)
            : base(item, editDate)
        {
            fLastHitInfoDate = new DateTime();
            fNoteMenu = CreateNoteMenu();
        }

        public new RepositoryItemMyDateEdit Properties
        {
            get { return base.Properties as RepositoryItemMyDateEdit; }
        }

        protected override DateEditPainter CreatePainter()
        {
            return new MyDateEditCalendarPainter(this);
        }

        protected virtual ToolTipController TipController
        {
            get { return ToolTipController.DefaultController; }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CalendarHitInfo HI = GetHitInfo(e);
                if (HI.InfoType == CalendarHitInfoType.MonthNumber)
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            CalendarHitInfo HI = GetHitInfo(e);
            if (HI.InfoType == CalendarHitInfoType.MonthNumber)
            {
                if (HI.HitDate != fLastHitInfoDate)
                {
                    fLastHitInfoDate = HI.HitDate;
                    List<Note> Notes = Properties.GetDateNotes(HI.HitDate);
                    if (Notes.Count > 0)
                    {
                        string NotesList = "";
                        foreach (Note N in Notes)
                        {
                            NotesList += N.Date.ToShortTimeString() + ": " + N.Name + '\n';
                        }
                        TipController.ShowHint(NotesList, HI.HitDate.ToShortDateString() + ": " + Notes.Count + " Notes.", PointToScreen(e.Location));
                        return;
                    }
                    else
                        TipController.HideHint();
                }
            }
            else
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
