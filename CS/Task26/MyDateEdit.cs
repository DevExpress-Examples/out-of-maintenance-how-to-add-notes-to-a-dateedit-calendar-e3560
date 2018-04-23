using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils;
using DevExpress.Utils.Menu;

namespace Task26
{
    public class MyDateEdit: DateEdit
    {
        
        static MyDateEdit() { RepositoryItemMyDateEdit.RegisterMyDateEdit(); }

        public MyDateEdit()
        {
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            if (Properties.IsVistaDisplay)
                return new VistaPopupMyDateEditForm(this);
            else
                return new PopupMyDateEditForm(this);
        }

        public override string EditorTypeName
        {
            get {return RepositoryItemMyDateEdit.MyDateEditName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyDateEdit Properties
        {
            get { return base.Properties as RepositoryItemMyDateEdit; }
        }

        public new MyDateEditViewInfo ViewInfo
        {
            get { return base.ViewInfo as MyDateEditViewInfo; }
        }

        protected override DXPopupMenu CreateMenu()
        {
            DXPopupMenu Mn = base.CreateMenu();
            DXMenuItem MenuAdd = new DXMenuItem("Add Note...", new EventHandler(OnMenuAdd_Click));
            MenuAdd.BeginGroup = true;
            Mn.Items.Add(MenuAdd);
            return Mn;
        }
        
        protected virtual void OnMenuAdd_Click(object sender, EventArgs e)
        {
            Properties.AddNote(DateTime);
        }

        protected override void OnEditValueChanged()
        {
            base.OnEditValueChanged();
            Properties.CheckNotes();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                if (ViewInfo.NoteIconRect.Contains(e.Location))
                {
                    Properties.OnNoteIconClicked();
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (ViewInfo.NoteIconRect.Contains(e.Location))
            {
                string NotesList = "";
                foreach (Note N in Properties.ActiveNotes)
                {
                    NotesList += N.Date.ToShortTimeString() + ": " + N.Name + '\n';
                }
                ToolTipController.DefaultController.ShowHint(NotesList, "You have " + Properties.ActiveNotes.Count + " active notes!", PointToScreen(e.Location));
            }
        }
    }
}
