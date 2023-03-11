using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace Date
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 1900;
        }

        public Date(int day, int month, int year)
        {

            this.day = day;
            this.month = month;
            this.year = year;
        }

        //propierties de los miembros
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public bool esBisiesto(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public int obtenerDiasMes()
        {
            switch (month)
            {
                case 2:
                    if (esBisiesto(month))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        public static int obtenerDiasMes(int month, int year)
        {
            switch (month)
            {
                case 2:
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        public enum DiaSemana
        {
            Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, Desconocido,
        }

        public DiaSemana diaSemana()
        {
            DateTime fechaActual = new DateTime(year, month, day);
            DayOfWeek diaSemana = fechaActual.DayOfWeek;
            switch (diaSemana)
            {
                case DayOfWeek.Monday:
                    return DiaSemana.Lunes;
                case DayOfWeek.Tuesday:
                    return DiaSemana.Martes;
                case DayOfWeek.Wednesday:
                    return DiaSemana.Miercoles;
                case DayOfWeek.Thursday:
                    return DiaSemana.Jueves;
                case DayOfWeek.Friday:
                    return DiaSemana.Viernes;
                case DayOfWeek.Saturday:
                    return DiaSemana.Sabado;
                case DayOfWeek.Sunday:
                    return DiaSemana.Domingo;
                default:
                    return DiaSemana.Desconocido;
            }
        }

        public bool esValida()
        {
            if (day > 0 && day <= obtenerDiasMes() && month > 0 && month <= 12 && year >= 1900 && year <= 2050)
            {
                return true;
            }
            return false;
        }

        public string toStringCorta()
        { 
            return JsonSerializer.Serialize(day + "-" + month + "-" + year + "-"); 
        }

        public string toString()
        {
            return JsonSerializer.Serialize( " " + day + " de " + month + " de " + year);
        }

        public int diasTranscurridos()
        {
            int dias = 0;
            for (int a = 1900; a < year; a++)
            {
                dias += esBisiesto(month) ? 366 : 365;
            }
            for (int m = 1; m < month; m++)
            {
                dias += obtenerDiasMes();
            }
            dias += day;
            return dias;
        }

        public int diasTranscurridos2()
        {
            DateTime fechaInicial = new DateTime(1900, 1, 1);
            DateTime fechaActual = new DateTime(year, month, day);
            TimeSpan diferencia = fechaActual - fechaInicial;
            return diferencia.Days;
        }

        public void fechaTrascurrida(long days)
        {
            int year = 1900;
            while (days > 365)
            {
                if (esBisiesto(year))
                {
                    if (days > 366)
                    {
                        days -= 366;
                        year++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    days -= 365;
                    year++;
                }
            }
            this.year = year;
            int month = 1;
            while (days > obtenerDiasMes(month, year))
            {
                days -= obtenerDiasMes(month, year);
                month++;
            }
            this.month = month;
            this.day = (int)days;
        }

        public int diasEntre(Date otraFecha)
        {
            DateTime fechaActual = new DateTime(year, month, day);
            DateTime fechaComparar = new DateTime(otraFecha.year, otraFecha.month, otraFecha.day);
            TimeSpan diferencia = fechaActual - fechaComparar;
            return Math.Abs(diferencia.Days);
        }

        


        public void anterior()
        {
            day--;
            if (day < 1)
            {
                month--;
                if (month < 1)
                {
                    month = 12;
                    year--;
                }
                day = obtenerDiasMes();
            }
        }

        public Date copia()
        {
            return new Date(day, month, year);
        }

        public bool igualQue(Date otraFecha)
        {
            if (day == otraFecha.day && month == otraFecha.month && year == otraFecha.year)
            {
                return true;
            }
            return false;
        }

        public bool menorQue(Date otraFecha)
        {
            if (year < otraFecha.year || (year == otraFecha.year && month < otraFecha.month) || (year == otraFecha.year && month == otraFecha.month && day < otraFecha.day))
            {
                return true;
            }
            return false;
        }

        public bool mayorQue(Date otraFecha)
        {
            if (year > otraFecha.year || (year == otraFecha.year && month > otraFecha.month) || (year == otraFecha.year && month == otraFecha.month && day > otraFecha.day))
            {
                return true;
            }
            return false;
        }
    }
}
