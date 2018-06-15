using System;

namespace p04SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double toys = 0.0;
            double money = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    toys++;
                }
                else if (i % 2 == 0)
                {
                    money += toys * 10;
                    money--;
                }
            }

            double totalToys = toysPrice * toys;
            double result = money + totalToys;

            if (result >= washingMachinePrice)
            {
                result -= washingMachinePrice;

                Console.WriteLine($"Yes! {result:F2}");
            }
            else if (result < washingMachinePrice)
            {
                washingMachinePrice -= result;

                Console.WriteLine($"No! {washingMachinePrice:F2}");
            }

        }
    }
}
