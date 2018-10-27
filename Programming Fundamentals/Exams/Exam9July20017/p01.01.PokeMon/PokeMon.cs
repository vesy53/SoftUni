using System;

namespace p01._01.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());

            decimal percentage = power / 2;
            //decimal percentage = power * 0.5m;
            int count = 0;

            while (true)
            {
                power -= distance;
                count++;

                if (factor != 0)
                {
                     if (power == percentage)
                     {
                         power /= factor;
                     }
                }

                if (power < distance)
                {
                    break;
                }

            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
