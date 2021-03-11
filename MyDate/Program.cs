using System;

namespace MyDate
{
    class Program
    {
        static void Main(string[] args)
        {


            if (args.Length != 1)
            {
                Console.Error.WriteLine("USAGE: mydate");
                Environment.Exit(1);
            }

            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
            DateTime month = DateTime.Now;
            int day = DateTime.Today.Day;
            string time = DateTime.Now.ToString("h:mm:ss tt");
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            int year = DateTime.Now.Year;
            Console.WriteLine($"{dayOfWeek} {month.ToString("MMM")}  {day} {time} {localZone.Id} {year}");
        }
    }
}
