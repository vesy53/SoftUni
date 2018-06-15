using System;

namespace p04SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double car = 0.0;
            double minibus = 0.0;
            double smallBus = 0.0;
            double largeBus = 0.0;
            double train = 0.0;
            double total = 0.0;

            for (int i = 1; i <= groups; i++)
            {
                int numPerson = int.Parse(Console.ReadLine());

                total += numPerson;

                if (numPerson <= 5)
                {
                    car += numPerson;
                }
                else if (numPerson >= 6 && numPerson <= 12)
                {
                    minibus += numPerson;
                }
                else if (numPerson >= 13 && numPerson <= 25)
                {
                    smallBus += numPerson;
                }
                else if (numPerson >= 26 && numPerson <= 40)
                {
                    largeBus += numPerson;
                }
                else if (numPerson >= 41)
                {
                    train += numPerson;
                }
            }

            Console.WriteLine($"{car / total * 100:F2}%");
            Console.WriteLine($"{minibus / total * 100:F2}%");
            Console.WriteLine($"{smallBus / total * 100:F2}%");
            Console.WriteLine($"{largeBus / total * 100:F2}%");
            Console.WriteLine($"{(train/ total * 100):F2}%");
        }
    }
}
