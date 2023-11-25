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

            if (_day > GetDaysCount(_year, _month))
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

        public DaysOfWeek GetDayOfWeek()
        {
            int totalDays = (_day + monthCode() + yearCode()) % 7;
            return (DaysOfWeek)totalDays;

        }

        public int weekCode()
        {
            int code = (GetDay() % 7) + monthCode() + yearCode();
            if (IsLeap() && GetMonth() == 1 || GetMonth() == 2)
                return code--;
            return code;

        }

        public int monthCode()
        {
            switch(GetMonth())
            {
                case 1: 
                    return IsLeap() ? 6 : 0;
                case 2: 
                    return IsLeap() ? 2 : 3;
                case 3: 
                    return 3;
                case 4: 
                    return 4;
                case 5: 
                    return 5;
                case 6: 
                    return 6;
                case 7: 
                    return 7;
                case 8: 
                    return 8;
                case 9: 
                    return 9;
                case 10: 
                    return 10;
                case 11: 
                    return 11;
                case 12: 
                    return 12;
                default:
                    return 0; 
            }
        }

        public int yearCode()
        {
            int centuryDigits = _year / 100; //para obtener los digitos del siglo
            int last2yeardigits = _year % 100; // los 2 ultimos digitos del año
            int centuryCode = 0; //codigo que se genera meduante un calculo aplicado solo para el calendaro gregoriano
            //y una regla particular que posee. Dependiendo del resultado de centuryDigits % 4, el resultado le 
            //designa un codigo u otro en base a los 4 años que se necesitan para que sea bisiesto

            switch (centuryDigits % 4)
            {
                case 0:
                    centuryCode = 6;
                    break;
                case 1:
                    centuryCode = 4;
                    break;
                case 2:
                    centuryCode = 2;
                    break;
                case 3:
                    centuryCode = 0;
                    break;
            }
            return (centuryCode + last2yeardigits + (last2yeardigits / 4)) % 7;
        }

        public int GetLeapCountBetween(int val1, int val2)
        {
            //for primero variable para adquirir el count, pasandole isleap (i) y aumentando el contador en el numero de bisiestos
            //en el for tener en cuenta las dos variables que le paso
            int leapCount = 0;
            Datetime datetime = new Datetime();

           
                if (val1 > val2)
                {
                    int temp = val1;
                    val1 = val2;
                    val2 = temp;
                }

                for (int i = val1; i <= val2; i++)
                {
                    if (IsLeap(i))
                    {
                        leapCount++;
                    }
                }
            

            return leapCount;
        }

        public int GetDayOfMonth(int _year, int _month)
        {
            return GetDaysCount(GetYear(), GetMonth());
        }

        public string ToString()
        {
            //si es valida return elementos + signo
            return _year + "-" + _month + "-" + _day + " | " 
                + _hour + ":" + _minute + ":" + _second;
        }

        public static int GetDaysCount(int year, int month)
        {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    return 31;
                else if (month == 4 || month == 6 || month == 5 || month == 9 || month == 11)
                {
                    return 30;
                } 
                else
            return (month == 2 && IsLeap(year)) ? 29 : 28;


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
