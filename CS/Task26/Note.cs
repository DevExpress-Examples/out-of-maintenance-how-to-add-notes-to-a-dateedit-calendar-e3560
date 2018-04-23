using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace Task26
{
    public class Note: INotifyPropertyChanged
    {
        DateTime fDate;
        string fName;
        string fText;

        public Note(): this(DateTime.Now) { }

        public Note(DateTime Date) : this(Date, "Unnamed", "") { }

        public Note(DateTime Date, string Name, string Text)
        {
            fDate = Date;
            fName = Name;
            fText = Text;
        }

        public virtual DateTime Date
        {
            get { return fDate; }
            set
            {
                if (value != fDate)
                {
                    fDate = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Date"));
                }
            }
        }

        public virtual string Name
        {
            get { return fName; }
            set
            {
                if (value != fName)
                {
                    fName = value;
                    if (PropertyChanged!=null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public virtual string Text
        {
            get { return fText; }
            set
            {
                if (value != fText)
                {
                    fText = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Text"));
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
