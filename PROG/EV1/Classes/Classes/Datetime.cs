using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    public class Datetime
    {
        private int _day;
        private int _month;
        private int _year;
        private int _hour;
        private int _minute;
        private int _second;

        

        public Datetime()
        {

        }

        public Datetime(int day, int month, int year)
        {
            _day = 1;
            _month = 1;
            _year = 1970;
        }

        public Datetime(int day, int month, int year, int hour, int minute, int second)
        {
            _day = day;
            _month = month;
            _year = year;
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public Datetime Clone()
        {
           return new Datetime(_day, _month, _year, _hour, _minute, _second);
        }

        public bool Equals(Datetime datetime)
        {
            return (_day == datetime._day && _month == datetime._month && _year == datetime._year 
                && _hour == datetime._hour && _minute == datetime._minute && _second == datetime._second);
        }

        public bool IsValid()
        {
            if (_year > 0 && _month > 0 && _day > 0)
            {
                if (_year < int.MaxValue && _month <= 12 && _day <= 31)
                {
                    if (_month == 2)
                    {
                        if (IsLeap(_year))
                        {
                            return _day == 29;
                        }
                        else
                        {
                            return _day == 28;
                        }
                    }
                   return true;
                }
            }
            return false;
        }

        public bool IsLeap()
        {
            return IsLeap(_year);
        }

        public static bool IsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0);
        }
        
        //public int Get
        public void IncrementDays()
        {
            _day++;

            if (_day > GetDaysOfMonth(_year, _month))
            {
                _day = 1;
                _month++;

                if (_month > 12)
                {
                    _month = 1;
                    _year++;
                }
            }
        }

        public void IncrementSeconds()
        {
            _second++;

            if (_second >= 60)
            {
                _second = 0;
                _minute++;

                if (_minute >= 60)
                {
                    _minute = 0;
                    _hour++;

                    if (_hour >= 24)
                    { 
                        _hour = 0;
                        IncrementDays();
                    }
                }
            }
        }

        public DayOfWeek GetDayOfWeek()
        {
            DateTime dateTime = new DateTime(_year, _month, _day);
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return DayOfWeek.Monday;
                case DayOfWeek.Tuesday:
                    return DayOfWeek.Tuesday;
                case DayOfWeek.Wednesday:
                    return DayOfWeek.Wednesday;
                case DayOfWeek.Thursday:
                    return DayOfWeek.Thursday;
                case DayOfWeek.Friday:
                    return DayOfWeek.Friday;
                case DayOfWeek.Saturday:
                    return DayOfWeek.Saturday;
                case DayOfWeek.Sunday:
                    return DayOfWeek.Sunday;
                default:
                    return 0;
            }
        }

        public int GetDaysOfMonth(int _year, int _month)
        {
            if (_month >= 1 && _month <= 12)
            {
                return DateTime.DaysInMonth(_year, _month);
            }
            else
            {
                return -1;
            }
        }

        public string ToString()
        {
            //si es valida return elementos + signo
            return _year.ToString() + "-" + _month.ToString() + "-" + _day.ToString() + " | " 
                + _hour.ToString() + ":" + _minute.ToString() + ":" + _second.ToString();
        }

        public int GetDaysCount(int year, int month)
        {
            //if mes 1, 3 y tal devuelve 31,
            //return IsLeap(year) ? 29 : 28
            if (_day > 0 && _month >= 1 && _month <= 12)
            {
                return DateTime.DaysInMonth(year, month);
            }
            else
            {
                return -1;
            }
        }

        public int GetYear()
        {
            return _year;
        }

        public int GetMonth()
        { 
            return _month; 
        }

        public int GetDay()
        {
            return _day;
        }

        public int GetHour()
        {
            return _hour;
        }
        
        public int GetMinute() 
        {
            return _minute;
        }

        public int GetSecond()
        {
            return _second;
        }

        public void SetDay(int day) 
        {
            _day = day;
        }

        public void SetMonth(int month)
        {
            _month = month;
        }

        public void SetYear(int year)
        {
            _year = year;
        }

        public void SetHour(int hour)
        {
            _hour = hour;
        }

        public void SetMinute(int minute)
        {
            _minute= minute;
        }

        public void SetSecond(int second)
        {
            _second= second;
        }



    }
}
