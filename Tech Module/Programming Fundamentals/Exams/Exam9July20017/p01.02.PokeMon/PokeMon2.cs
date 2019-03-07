namespace p01._02.PokeMon
{
    using System;

    class PokeMon2
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());

            decimal percemtage = power * 0.5m;
            int counter = 0;

            while (power >= distance)
            {
                power -= distance;
                counter++;

                if (power == percemtage && factor > 0)
                {
                    power /= factor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
