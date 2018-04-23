using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Controls;

namespace Task26
{
    public class VistaPopupMyDateEditForm : VistaPopupDateEditForm
    {
        public VistaPopupMyDateEditForm(MyDateEdit ownerEdit):
            base(ownerEdit)
        {
        }

        public new MyDateEdit OwnerEdit
        {
            get { return base.OwnerEdit as MyDateEdit; }
        }

        protected override DateEditCalendar CreateCalendar()
        {
            return new VistaMyDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }

    }
}