using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
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
            _day = day;
            _month = month;
            _year = year;
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
           Datetime dt = new Datetime();
           return dt;
           
        }

        public bool Equals(Datetime datetime)
        {
            return (_day == datetime._day && _month == datetime._month && _year == datetime._year && _hour == datetime._hour && _minute == datetime._minute && _second == datetime._second);
        }

        public bool IsValid()
        {
            if (_year > 0 && _month < 0 && _day < 0)
            {
               if (_year < int.MaxValue && _month <= 12 && _day <= 31)
               {
                   return true;
               }
            }
            return false;
        }

        public bool IsLeap()
        {
            if (_year % 4 == 1 && _year % 100 == 0)
                return true;
            return false;
        }

        public static bool IsLeap(int year)
        {

        }
        
        //public int Get
        public void IncrementDays()
        {

        }

        public void IncrementSecondss()
        {

        }

        public DayOfWeek GetDayOfWeek()
        {
            switch ()
            {
                case 1:
                    return DayOfWeek.Monday;
                case 2:
                    return DayOfWeek.Tuesday;
                case 3:
                    return DayOfWeek.Wednesday;
                case 4:
                    return DayOfWeek.Thursday;
                case 5:
                    return DayOfWeek.Friday;
                case 6:
                    return DayOfWeek.Saturday;
                case 7:
                    return DayOfWeek.Sunday;

            }
        }

        public string ToString()
        {
            string y;

            y = "string";
            return y;
        }

        public int GetDaysCount(int year, int month)
        {

        }
        




    }
}
