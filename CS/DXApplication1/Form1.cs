using DevExpress.Utils;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
       public BindingList<DateTime> specialDays;
        public Form1()
        {
            InitializeComponent();
            specialDays = new BindingList<DateTime>();
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 4));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 22));
            specialDays.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17));
            dateEdit1.Properties.CellStyleProvider = new MyCellStyleProvider();

            gridControl1.DataSource = GetData();
            (gridView1.Columns[2].ColumnEdit as RepositoryItemDateEdit).CellStyleProvider = new MyCellStyleProvider();
            (gridView1.Columns[2].ColumnEdit as RepositoryItemDateEdit).Popup += dateEdit1_Popup;
            (gridView1.Columns[2].ColumnEdit as RepositoryItemDateEdit).CellSize = new Size(50, 50);
            //ContextButton contextButton = new ContextButton();
            //contextButton.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar;
            //contextButton.Id = new System.Guid("add60edd-5f9a-4d98-b09d-f716aaa46999");
            //contextButton.Name = "ContextButton";
            //contextButton.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
           
        }
        private BindingList<Custom> GetData()
        {
            BindingList<Custom> list = new BindingList<Custom>();
            for (int i = 0; i < 10; i++)
                list.Add(new Custom() { ID = i, Name = "Name" + i, Time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17) });
                return list;
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            foreach(DateTime specialDate in specialDays)
            {
                if (specialDate == (DateTime)dateEdit1.EditValue)
                { 
                    dateEdit1.Properties.Buttons[1].Visible = true;
                return;
                }
            }
            dateEdit1.Properties.Buttons[1].Visible = false;

        }
        
        private void dateEdit1_Popup(object sender, EventArgs e)
        {
            PopupDateEditForm popupForm = ((sender as IPopupControl).PopupWindow as PopupDateEditForm);
            if (popupForm.Calendar.ContextButtons.Count > 0)
                popupForm.Calendar.ContextButtons.Clear();
            ContextButton contextButton1 = new ContextButton();
            contextButton1.Alignment = ContextItemAlignment.Center;
            contextButton1.Name = "ContextButton";
            contextButton1.Visibility = ContextItemVisibility.Visible;
            popupForm.Calendar.ContextButtons.Add(contextButton1);
            popupForm.Calendar.ContextButtonClick +=Calendar_ContextButtonClick;
            popupForm.Calendar.ContextButtonCustomize += Calendar_ContextButtonCustomize;
        }

        void Calendar_ContextButtonCustomize(object sender, CalendarContextButtonCustomizeEventArgs e)
        {
            PopupCalendarControl popupCalendarControl = (PopupCalendarControl)sender;
            
           MyCellStyleProvider provider = (MyCellStyleProvider)popupCalendarControl.CellStyleProvider;
           MyCustomCellData data = ((MyCellStyleProvider)popupCalendarControl.CellStyleProvider).GetCell(e.Cell.Date);
            if (data == null || string.IsNullOrEmpty(data.InfoText))
            {
                e.Item.Visibility = ContextItemVisibility.Hidden;
                return;
           }
            e.Item.Tag = data;
            e.Item.Glyph = data.InfoGlyph;
        }

        void Calendar_ContextButtonClick(object sender, ContextItemClickEventArgs e)
        {
            MyCustomCellData data = (MyCustomCellData)e.Item.Tag;
            if (data == null)
                return;
            this.memoEdit1.Text = data.InfoText;
            this.flyoutPanel1.ShowBeakForm(new Point(e.ScreenBounds.X + e.ScreenBounds.Width / 2, e.ScreenBounds.Top - 5));
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Size pictureSize = new Size(16,16);
            if(e.Column == gridColumn3)
            {
                foreach (DateTime specialDate in specialDays)
                {
                    if (specialDate == (DateTime)e.CellValue)
                    {
                        e.Graphics.DrawImage(DXApplication1.Properties.Resources.Column_Priority, new Rectangle(e.Bounds.X + 2, e.Bounds.Y, pictureSize.Width, pictureSize.Height));
                        e.Appearance.DrawString(e.Cache, e.DisplayText, new Rectangle(e.Bounds.X + pictureSize.Width, e.Bounds.Y, e.Bounds.Width - pictureSize.Width, e.Bounds.Height));
                        e.Handled = true;
                    }
                }
                
            }
        }

    }
    public class MyCellStyleProvider : ICalendarCellStyleProvider
    {
        Image image = DXApplication1.Properties.Resources.Column_Priority;
        List<MyCustomCellData> cells;
        protected List<MyCustomCellData> Cells
        {
            get
            {
                if (cells == null)
                    cells = CreateCells();
                return cells;
            }
        }

        protected virtual List<MyCustomCellData> CreateCells()
        {
            List<MyCustomCellData> res = new List<MyCustomCellData>();

            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1), BackColor = Color.FromArgb(255, 209, 240, 253), InfoText = "Mexico City. Talks with Pure Products Inc.", InfoGlyph = image });
            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2), BackColor = Color.FromArgb(255, 209, 240, 253) });

            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 4), SpecialDate = true, InfoText = "INDEPENDENCE DAY" });
            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6), BackColor = Color.FromArgb(255, 229, 253, 177), InfoText = "New York Knicks vs Orlando Magic", InfoGlyph = image });
            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13), BackColor = Color.FromArgb(255, 229, 253, 177) });

            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10), BackColor = Color.FromArgb(255, 255, 228, 239), InfoText = "Call Susanne Guper, New warehouse issues", InfoGlyph = image });
            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16), InfoText = "JOHN\nBIRTHDAY", SpecialDate = true });

            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21), BackColor = Color.FromArgb(255, 255, 228, 239) });
            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 22), InfoText = "MARY\nBIRTHDAY", SpecialDate = true });


            res.Add(new MyCustomCellData() { Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17), BackColor = Color.FromArgb(255, 229, 253, 177), InfoText = "Flatiron Club", InfoGlyph = image });
           
           

            return res;
        }

        public MyCustomCellData GetCell(DateTime date)
        {
            return Cells.FirstOrDefault((c) => c.Date.Date == date.Date);
        }
        void ICalendarCellStyleProvider.UpdateAppearance(CalendarCellStyle cell)
        {
            MyCustomCellData cellInfo = GetCell(cell.Date);
            if (cellInfo == null)
                return;

            cell.Description = cellInfo.Description;
            if (cell.Description != null)
            {
                cell.DescriptionAppearance = (AppearanceObject)cell.Appearance.Clone();
                cell.DescriptionAppearance.Font = new Font(cell.Appearance.Font.FontFamily, 7.0f, FontStyle.Bold);
                cell.DescriptionAppearance.TextOptions.WordWrap = WordWrap.Wrap;
            }
            if (!cellInfo.ForeColor.IsEmpty)
                cell.Appearance.ForeColor = cellInfo.ForeColor;
            if (!cellInfo.BackColor.IsEmpty)
                cell.Appearance.BackColor = cellInfo.BackColor;
            if (cellInfo.SpecialDate)
                cell.Appearance.Font = new Font(cell.Appearance.Font.FontFamily, 7.0f, FontStyle.Bold);
        }
    }
    public class MyCustomCellData
    {
        public DateTime Date { get; set; }
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public Image InfoGlyph { get; set; }
        public string InfoText { get; set; }

        public string Description { get; set; }
        public bool SpecialDate { get; set; }
    }
    public class Custom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
