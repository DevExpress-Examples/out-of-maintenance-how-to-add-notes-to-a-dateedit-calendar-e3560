using System.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Calendar;

namespace Task26
{
    class VistaMyDateEditCalendarPainter: VistaDateEditPainter
    {
        public VistaMyDateEditCalendarPainter(VistaMyDateEditCalendar calendar)
            : base(calendar)
        {
        }

        public new VistaMyDateEditCalendar Calendar
        {
            get { return base.Calendar as VistaMyDateEditCalendar; }
        }

        protected override void DrawDayCell(CalendarObjectInfoArgs info, DayNumberCellInfo cell)
        {
            base.DrawDayCell(info, cell);
            if (Calendar.Properties.HaveNote(cell.Date))
                DrawMarker(cell.Bounds, info.Graphics);
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
