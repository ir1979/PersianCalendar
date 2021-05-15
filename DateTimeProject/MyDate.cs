using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersianDate;

namespace DateTimeProject
{
    class MyDate
    {
        private int day = 1;
        private int month = 1;
        private int year = 1;

        DateTime internalDate = new DateTime(622, 3, 22);   //    1/1/1

        public int Day
        {
            get => day;
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                    updateInternalDate();
                }
                else
                    throw new Exception("day is not in range!");
            }
        }

        public int Month
        {
            get => month;
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                    updateInternalDate();
                }
                else
                    throw new Exception("month is not in range!");
            }
        }


        public int Year 
        {
            get => year;
            set
            {
                if (value >= 1)
                {
                    year = value;
                    updateInternalDate();
                }
                else
                    throw new Exception("Year is not in range!");
            
            }
        }

        public MyDate(int Year = 1, int Month = 1, int Day = 1)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;

            updateInternalDate();

        }


        private void updateInternalDate()
        {
            internalDate = this.ToString().ToEn();
        }

        public override string ToString()
        {
            return Year.ToString() + "/" + Month.ToString() + "/" + Day.ToString();
        }

        //private int ToDays()
        //{
        //    if (Month <= 7)
        //        return (Year - 1) * 365 + (Month - 1) * 31 + Day;
        //    else
        //        return (Year - 1) * 365 + 186 + (Month - 7) * 30 + Day;
        //}


        //private static MyDate ToMyDate(int i)
        //{
        //    int y = i / 365;
        //    int m = (i % 365) / 30;
        //    int d = i - y * 365 - m * 30;

        //    return new MyDate(y, m, d);
        //}

        public static int operator -(MyDate A, MyDate B)
        {
            return (int)(A.internalDate - B.internalDate).TotalDays;
        }


        public static MyDate operator +(MyDate A, int i)
        {
            DateTime newDate = A.internalDate.AddDays(i);

            int y = int.Parse(newDate.ToFa("YYYY"));
            int m = int.Parse(newDate.ToFa("MM"));
            int d = int.Parse(newDate.ToFa("dd"));

            MyDate result = new MyDate(y, m, d);

            return result;
        }

        public static MyDate operator +(int i, MyDate A)
        {
            return A + i;
        }
    }
}
