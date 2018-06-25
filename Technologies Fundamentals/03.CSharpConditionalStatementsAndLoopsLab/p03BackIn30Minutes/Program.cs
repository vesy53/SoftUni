using System;

namespace p03BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                hour++;
                minutes -= 60;
            }

            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minutes:0#}");
        }
    }
}
