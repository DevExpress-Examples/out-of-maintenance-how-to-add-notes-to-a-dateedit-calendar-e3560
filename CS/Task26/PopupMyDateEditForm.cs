using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Controls;

namespace Task26
{
    public class PopupMyDateEditForm: PopupDateEditForm
    {
        public PopupMyDateEditForm(MyDateEdit ownerEdit) : base(ownerEdit)
        {
        }

        public new MyDateEdit OwnerEdit
        {
            get { return base.OwnerEdit as MyDateEdit; }
        }
        
        protected override DateEditCalendar CreateCalendar()
        {
            return new MyDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
        }
    }
}
