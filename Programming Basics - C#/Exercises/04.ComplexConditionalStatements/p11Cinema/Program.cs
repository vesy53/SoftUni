using System;

namespace p11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCinema = Console.ReadLine();
            int numRows = int.Parse(Console.ReadLine());
            int numCols = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (typeCinema == "Premiere")
            {
                price = 12;
            }
            else if (typeCinema == "Normal")
            {
                price = 7.50;
            }
            else if (typeCinema == "Discount")
            {
                price = 5;
            }

            double result = numRows * numCols * price;

            Console.WriteLine($"{result:F2} leva");
        }
    }
}
