using System.ComponentModel.DataAnnotations;

namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime value = DateTime.Now;

            //Console.WriteLine(value.ToString());
            //Console.WriteLine(value.ToShortDateString());
            //Console.WriteLine(value.ToShortTimeString());
            //Console.WriteLine(value.ToLongDateString());
            //Console.WriteLine(value.ToLongTimeString());

            //ADD AND SUBTRACH DAYS AND HOURS
            Console.WriteLine(value.AddDays(2));
            Console.WriteLine(value.AddHours(1));
            Console.WriteLine(value.AddDays(-3));
            Console.WriteLine(value.AddHours(-3));

            DateTime independenceDay = new DateTime(2025, 03, 16);
            Console.WriteLine(independenceDay.ToString());

            //Convert/Parse string to date
            DateTime dob = DateTime.Parse("16/03/1995");
            TimeSpan myAge = DateTime.Now.Subtract(dob);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}