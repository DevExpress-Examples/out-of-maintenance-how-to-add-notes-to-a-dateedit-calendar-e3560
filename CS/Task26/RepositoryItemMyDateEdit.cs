using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace Task26
{
   [UserRepositoryItem("RegisterMyDateEdit")]
    public class RepositoryItemMyDateEdit: RepositoryItemDateEdit
    {
        List<Note> fNotes;
        List<Note> fActiveNotes;
        NoteForm fNoteForm;
        SelectForm fSelectForm;
        
       static RepositoryItemMyDateEdit() { RegisterMyDateEdit(); }

        public RepositoryItemMyDateEdit()
        {
            fNotes = new List<Note>();
            fActiveNotes = new List<Note>();
            fSelectForm = new SelectForm();
        }

        public const string MyDateEditName = "MyDateEdit";

       public bool IsVistaDisplay
       {
           get { return IsVistaDisplayMode(); }
       }
       
       public override string EditorTypeName { get { return MyDateEditName; } }
        
        public static void RegisterMyDateEdit()
        {      
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyDateEditName, 
              typeof(MyDateEdit),
              typeof(RepositoryItemMyDateEdit),
              typeof(MyDateEditViewInfo),
              new MyDateEditPainter(),
              true));
        }

        public virtual List<Note> Notes
        {
            get { return fNotes; }
        }

        public virtual List<Note> ActiveNotes
        {
            get { return fActiveNotes; }
        }

        protected virtual DateTime EditorDate
        {
            get
            {
                if (OwnerEdit == null)
                    return new DateTime();
                else
                    return OwnerEdit.DateTime;
            }
        }

        public bool HaveActiveNotes
        {
            get { return ActiveNotes.Count > 0; }
        }

        public virtual List<Note> GetDateNotes(DateTime Date)
        {
            List<Note> Res = new List<Note>();

            foreach (Note N in Notes)
            {
                if (N.Date.Date == Date.Date)
                {
                    Res.Add(N);
                }
            }

            return Res;
        }

       public void AddNote(Note N)
       {
           Notes.Add(N);
           CheckNotes();
       }
       
       public void AddNote()
        {
            AddNote(EditorDate);
        }
       
       public virtual void AddNote(DateTime Date)
       {
           Note NewNote = new Note(Date.Date);
           fNoteForm = new NoteForm(NewNote);
           if (fNoteForm.ShowDialog() == DialogResult.OK)
           {
               Notes.Add(NewNote);
               CheckNotes();
           }
           fNoteForm.Dispose();
       }

        public void EditNote(Note N)
        {
            int Index = Notes.IndexOf(N);
            if (Index >= 0)
                EditNote(Index);
        }
       
       public virtual void EditNote(int Index)
       {
           if ((Index >= 0) && (Index < Notes.Count))
           {
               Note Tmp = Notes[Index];
               fNoteForm = new NoteForm(Tmp);
               if (fNoteForm.ShowDialog() == DialogResult.OK)
               {
                   Notes[Index] = Tmp;
                   CheckNotes();
               }
               fNoteForm.Dispose();
           }
       }

        public virtual void EditNotes(DateTime Date)
        {
            List<Note> LN = GetDateNotes(Date);

            if (LN.Count > 0)
            {
                if (LN.Count == 1)
                {
                    EditNote(LN[0]);
                }
                else
                {
                    int SelIndex = fSelectForm.SelectNote(LN);
                    EditNote(SelIndex);
                }
            }
        }

        public virtual bool HaveNote(DateTime Date)
        {
            foreach (Note N in Notes)
            {
                if (N.Date.Date == Date.Date)
                {
                    return true;
                }
            }
            return false;
        }
       
       public virtual void DeleteNotes(DateTime Date)
        {
            List<Note> LN = GetDateNotes(Date);

            if (LN.Count > 0)
            {
                if (LN.Count == 1)
                {
                    Notes.Remove(LN[0]);
                }
                else
                {
                    List<Note> Selection = fSelectForm.SelectNotes(LN);
                    foreach (Note N in Selection)
                    {
                        if (ActiveNotes.Contains(N))
                            ActiveNotes.Remove(N);
                        Notes.Remove(N);
                    }
                }
                CheckNotes();
            }
        }

        public virtual void CheckNotes()
        {
            List<Note> LN = GetDateNotes(EditorDate);

            for (int i = ActiveNotes.Count-1; i >= 0; i--)
            {
                if (ActiveNotes[i].Date.Date != EditorDate.Date)
                    ActiveNotes.RemoveAt(i);
            }

            foreach (Note N in LN)
            {
                if ((N.Date.Date == EditorDate.Date) && !ActiveNotes.Contains(N))
                {
                    ActiveNotes.Add(N);
                }
            }
        }

       protected internal virtual void OnNoteIconClicked()
       {
           if (ActiveNotes.Count > 0)
           {
               int Index = (ActiveNotes.Count == 1) ? 0 : fSelectForm.SelectNote(ActiveNotes);
               EditNote(ActiveNotes[Index]);
           }
       }

        public override BaseEditViewInfo CreateViewInfo()
        {
            return new MyDateEditViewInfo(this);
        }
       
       public override void Assign(RepositoryItem item)
        {
            BeginUpdate(); 
            try
            {
                base.Assign(item);
                RepositoryItemMyDateEdit source = item as RepositoryItemMyDateEdit;
                if(source == null) return;

                fNotes = source.fNotes;
            }
            finally
            {
                EndUpdate();
            }
        }

       protected override void  Dispose(bool disposing)
       {
 	       base.Dispose(disposing);
           if (disposing)
           {
               fSelectForm.Dispose();
           }
       }
    }
}
