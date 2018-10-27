using System;

namespace p03WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int totalWater = 0;

            for (int i = 0; i < num; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                totalWater += quantity;

                if (totalWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalWater -= quantity;
                }               
            }
                     
            Console.WriteLine(totalWater);                      
        }
    }
}
