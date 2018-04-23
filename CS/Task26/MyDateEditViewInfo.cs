using System.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace Task26
{
    public class MyDateEditViewInfo: DateEditViewInfo
    {
        Rectangle fNoteIconRect;

        public Rectangle NoteIconRect
        {
            get { return fNoteIconRect; }
            private set { fNoteIconRect = value; }
        }
        
        public MyDateEditViewInfo(RepositoryItemMyDateEdit item): 
            base(item)
        {
        }

        protected new RepositoryItemMyDateEdit Item
        {
            get { return base.Item as RepositoryItemMyDateEdit; }
        }

        protected override Rectangle CalcMaskBoxRect(Rectangle content, ref Rectangle emptyRect)
        {
            Rectangle MaskBoxRect = base.CalcMaskBoxRect(content, ref emptyRect);
            if (Item.HaveActiveNotes)
                MaskBoxRect.Width -= MaskBoxRect.Height;
            return MaskBoxRect;
        }

        protected virtual Rectangle CalcNoteIconRect()
        {
            if (Item.HaveActiveNotes)
                return new Rectangle(MaskBoxRect.Right, MaskBoxRect.Y, MaskBoxRect.Height, MaskBoxRect.Height);
            else
                return Rectangle.Empty;
        }

        protected override void CalcRects()
        {
            base.CalcRects();
            NoteIconRect = CalcNoteIconRect();
        }
    }
}
