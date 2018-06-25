using System;

namespace p12BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double max = 0.0;
            string findModel = "";

            for (int i = 1; i <= num; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > max)
                {
                    max = volume;
                    findModel = model;
                }
            }

            Console.WriteLine(findModel);
        }
    }
}
