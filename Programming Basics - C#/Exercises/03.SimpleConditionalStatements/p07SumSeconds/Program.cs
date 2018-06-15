using System;

namespace p07SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstRacer = double.Parse(Console.ReadLine());
            double secondRacer = double.Parse(Console.ReadLine());
            double thirdRacer = double.Parse(Console.ReadLine());

            double total = firstRacer + secondRacer + thirdRacer;
            double minutes = total / 60;
            double secs = total % 60;
            string secTime = secs.ToString().PadLeft(2, '0');

            if (total >= 0 && total <= 59)
            {
                Console.WriteLine($"0:{secTime}");
            }
            else if (total >= 60 && total <= 119 )
            {
                Console.WriteLine($"1:{secTime}");
            }
            else if (total >= 120 && total <= 179)
            {
                Console.WriteLine($"2:{secTime}");
            }
        }
    }
}
