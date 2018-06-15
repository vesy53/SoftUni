using System;

namespace p14TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            //else if (hours > 23)
            //{
            //    minutes++;
            //    hours -= 24;
            //}

            if (hours >= 24)
            {
                hours = 0;
            }

            string totalMin = minutes.ToString().PadLeft(2, '0');

            Console.WriteLine($"{hours}:{totalMin}");
        }
    }
}
