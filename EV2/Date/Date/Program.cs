namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(10, 6, 2012);

            Console.WriteLine("El dia de la fecha señalada es: " + date.Day);
            Console.WriteLine("El mes de la fecha señalada es: " + date.Month);
            Console.WriteLine("El año de la fecha señalada es: " + date.Year);

            Console.WriteLine("La fecha completa es: " + "el dia " + date.Day + " del mes " + date.Month + " del año " + date.Year);

            bool isLeapYear = date.IsLeapYear(date.Year);
            Console.WriteLine("Es año bisiesto? " + isLeapYear);

            int monthDays = date.GetMonthDaysOfData();
            Console.WriteLine("Dias que tiene el mes: " + monthDays);

            bool isValid = date.IsValid();
            Console.WriteLine("Es una fecha valida? " + isValid);

            string shortDate = date.ToStringShort();
            Console.WriteLine("Short Date: " + shortDate);

            string largeDate = date.ToStringLarge();
            Console.WriteLine("Short Date: " + largeDate);

            Date copyDate = date.CopyData();
            Console.WriteLine("Copy Date: " + copyDate.Day + "/" + copyDate.Month + "/" + copyDate.Year);

            
            Console.WriteLine("La fecha original es: " + date.Day + "/" + date.Month + "/" + date.Year);
            date.PreviousDay();
            Console.WriteLine("El día anterior es: " + date.Day + "/" + date.Month + "/" + date.Year);

            //int monthDays = date.GetMonthDays(date);
            //Console.WriteLine("El mes " + date.Month + " del año " + date.Year + " tiene " + monthDays + " días.");

            Console.WriteLine("La fecha original es: " + date.Day + "/" + date.Month + "/" + date.Year);
            date.NextDay();
            Console.WriteLine("Día siguiente: " + date.Day + "/" + date.Month + "/" + date.Year);

            Date date1 = new Date(21, 6, 2023);
            Date date2 = new Date(21, 6, 2023);

            bool isEqual = date1.IsEqual(date2);
            Console.WriteLine("Las fechas son iguales: " + isEqual);

            Date date3 = new Date(1, 6, 2023);
            Date date4 = new Date(15, 6, 2023);
            bool isLessThan = date3.LessThan(date4);
            Console.WriteLine("La primera fecha es menor que la segunda fecha: " + isLessThan);

            Date date5 = new Date(21, 6, 2023);
            Date date6 = new Date(15, 6, 2023);
            bool isGreaterThan = date5.GreaterThan(date6);
            Console.WriteLine("La primera fecha es mayor que la segunda fecha: " + isGreaterThan);







        }
    }
}