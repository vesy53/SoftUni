using System;

namespace p02Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            double numBoxes = double.Parse(Console.ReadLine());
            double numJars = double.Parse(Console.ReadLine());

            double totalLutenitsa = tomatoes / 5;
            double jars = totalLutenitsa / 0.535;
            double boxes = jars / numJars;

            Console.WriteLine(
                $"Total lutenica: {Math.Floor(totalLutenitsa)} kilograms.");

            if (boxes <= numBoxes)
            {
                double totalBoxes = numBoxes - boxes;
                double totalJars = (numBoxes * numJars) - jars;

                Console.WriteLine($"{Math.Floor(totalBoxes)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(totalJars)} more jars needed.");
            }
            else if (boxes > numBoxes)
            {
                boxes -= numBoxes;
                jars -= numBoxes * numJars;

                Console.WriteLine($"{Math.Floor(boxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(jars)} jars left.");
            }
        }
    }
}
