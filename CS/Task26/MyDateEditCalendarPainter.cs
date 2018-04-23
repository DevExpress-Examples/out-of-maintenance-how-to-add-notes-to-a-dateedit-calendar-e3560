using System.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Calendar;

namespace Task26
{
    public class MyDateEditCalendarPainter : DateEditPainter
    {
        public MyDateEditCalendarPainter(MyDateEditCalendar calendar)
            : base(calendar)
        {
        }

        public new MyDateEditCalendar Calendar
        {
            get { return base.Calendar as MyDateEditCalendar; }
        }

        public override void DrawDayCellText(DayNumberCellInfo cell, Brush brush)
        {
            base.DrawDayCellText(cell, brush);
            if (Calendar.Properties.HaveNote(cell.Date))
                DrawMarker(cell.Bounds, cell.Graphics);
        }

        protected virtual void DrawMarker(Rectangle Bounds, Graphics G)
        {
            int MarkerWidth = Bounds.Width / 4;
            Point[] Marker = {
                new Point(Bounds.Right - MarkerWidth, Bounds.Bottom),
                new Point(Bounds.Right, Bounds.Bottom - MarkerWidth),
                new Point(Bounds.Right, Bounds.Bottom)
            };
            G.DrawPolygon(Pens.Red, Marker);
        }
    }
}
