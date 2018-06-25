using System;

namespace p06TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeDay == "weekday")
                {
                    price = 12;
                }
                else if (typeDay == "weekend")
                {
                    price = 15;
                }
                else if (typeDay == "holiday")
                {
                    price = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeDay == "weekday")
                {
                    price = 18;
                }
                else if (typeDay == "weekend")
                {
                    price = 20;
                }
                else if (typeDay == "holiday")
                {
                    price = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeDay == "weekday")
                {
                    price = 12;
                }
                else if (typeDay == "weekend")
                {
                    price = 15;
                }
                else if (typeDay == "holiday")
                {
                    price = 10;
                }
            }
            else if(age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.WriteLine($"{price}$");
        }
    }
}
