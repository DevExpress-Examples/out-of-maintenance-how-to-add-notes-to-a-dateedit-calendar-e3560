using System.Drawing;
using DevExpress.XtraEditors.Drawing;

namespace Task26
{
    public class MyDateEditPainter: ButtonEditPainter
    {
        Image fNoteIcon;

        public MyDateEditPainter()
            : base()
        {
            try
            {
                fNoteIcon = Image.FromFile("NoteIcon.bmp");
            }
            catch
            {
                fNoteIcon = null;
            }
        }

        public override void Draw(ControlGraphicsInfoArgs info)
        {
            base.Draw(info);
            DrawNoteIcon(info);
        }

        protected virtual void DrawNoteIcon(ControlGraphicsInfoArgs info)
        {
            MyDateEditViewInfo VI = info.ViewInfo as MyDateEditViewInfo;

            if (VI.NoteIconRect != Rectangle.Empty)
                if (fNoteIcon == null)
                {
                    info.Graphics.FillEllipse(Brushes.Red, VI.NoteIconRect);
                }
                else
                    info.Graphics.DrawImage(fNoteIcon, VI.NoteIconRect);
        }
    }
}
