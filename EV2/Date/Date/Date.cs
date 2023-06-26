using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Date
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Date
    {
        private int _day;
        private int _month;
        private int _year;


        public Date()
        {
            _day = 1;
            _month = 1;
            _year = 1900;
        }

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int Day { get { return _day; } set { _day = value; } }
        public int Month { get { return _month; } set { _month = value; } }
        public int Year { get { return _year; } set { _year = value; } }

        public bool IsLeapYear(int Year)
        {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || Year % 400 == 0)
                return true;
            return false;
        }

        public int GetMonthDaysOfData()
        {
            return GetMonthDays(_year, _month);
        }

        public int GetMonthDays(int Year, int Month)
        {
            if (Month == 2 && IsLeapYear(Year))
                return 29;
            else if (Month == 2)
                return 28;
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                return 30;
            else
                return 31;
        }

        //public DaysOfWeek GetDayOfWeek()
        //{
        //    int d = _day;
        //    int m = _month;
        //    int y = _year;

        //    DateTime Date = new DateTime(_day, _month, _year);
            

        //}

        public bool IsValid()
        {
            DateTime minDate = new DateTime(1900, 1, 1);
            DateTime maxDate = new DateTime(2050, 12, 31);
            DateTime dateToCheck = new DateTime(_year, _month, _day);

            return (dateToCheck >= minDate && dateToCheck <= maxDate);

        }

        public string ToStringShort()
        {
            DateTime dateToCheck = new DateTime(_year, _month, _day);
            return dateToCheck.ToString("d");
        }

        public string ToStringLarge()
        {
            DateTime dateToCheck = new DateTime(_year, _month, _day);
            return dateToCheck.ToString("D");
        }

        //public long PassedDays()
        //{
        //    DateTime startDate = new DateTime(1900, 1, 1);
        //    DateTime currentDate = new DateTime(_year, _month, _day);
        //    DateTime passedDays = DateTime currentDate - DateTime startDate;

        //    return passedDays;
        //}

        public void PassedDate(long days)
        {
            
        }

        public int DaysBetween(Date date)
        {
            return 0;
        }

        public void NextDay()
        {
            if (_day == 31)
                {
                    if (_month == 12)
                    {
                        _year++;
                        _month = 1;
                        _day = 1;
                    }
                    else
                    {
                        _month++;
                        _day = GetMonthDays(_year, _month);
                    }
                }
            else
            {
                _day++;
            }
        }

        public void PreviousDay()
        {
            if (_day == 1)
            {
                if (_month == 1)
                {
                    _year--;
                    _month = 12;
                    _day = 31;
                }
                else
                {
                    _month--;
                    _day = GetMonthDays(_year, _month);
                }
            }
            else
            {
                _day--;
            }
        }

        public Date CopyData()
        {
            Date cloneDate = new Date(_day, _month, _year);
            return cloneDate;

        }

        public bool IsEqual(Date date)

        {
            return _day == date.Day && _month == date.Month && _year == date.Year;

        }

        public bool LessThan(Date date)
        {
            if (_year < date.Year)
                return true;
            if (_year == date.Year && _month < date.Month)
                return true;
            if (_year == date.Year && _month == date.Month && _day < date.Day)
                return true;
            return false;
           
        }
        public bool GreaterThan(Date date)

        {
            if (_year > date.Year)
                return true;
            if (_year == date.Year && _month > date.Month)
                return true;
            if (_year == date.Year && _month == date.Month && _day > date.Day)
                return true;
            return false;

        }
    }
}
