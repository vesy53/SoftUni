using System;

namespace p04BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePpoduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            energy *= volume;
            energy /= 100;
            sugar *= volume;
            sugar /= 100;

            Console.WriteLine($"{volume}ml {namePpoduct}:\r\n" +
                $"{energy}kcal, {sugar}g sugars");
        }
    }
}
