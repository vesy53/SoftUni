using System;

namespace p08CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int countCheese = 0;
            int countTomato = 0;
            int countSalami = 0;
            int countPepper = 0;
            int totalCal = 0;

            for (int i = 1; i <= num; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    countCheese++;
                }
                else if (ingredient == "tomato sauce")
                {
                    countTomato++;
                }
                else if (ingredient == "salami")
                {
                    countSalami++;
                }
                else if (ingredient == "pepper")
                {
                    countPepper++;
                }
            }

            totalCal = 
                countCheese * 500 + countTomato * 150 + countSalami * 600 + countPepper * 50;

            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}
