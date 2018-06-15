using System;

namespace p03MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeOfContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string addedInternet = Console.ReadLine();
            int monthsForPayment = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (timeOfContract == "one")
            {
                if (typeOfContract == "Small")
                {
                    price = 9.98;
                }
                else if (typeOfContract == "Middle")
                {
                    price = 18.99;
                }
                else if (typeOfContract == "Large")
                {
                    price = 25.98; 
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            else if (timeOfContract == "two")
            {
                if (typeOfContract == "Small")
                {
                    price = 8.58;
                }
                else if (typeOfContract == "Middle")
                {
                    price = 17.09;
                }
                else if (typeOfContract == "Large")
                {
                    price = 23.59;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    price = 31.79;
                }
            }

            if (addedInternet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }              
            }

            if (timeOfContract == "two")
            {
                price -= price * 0.0375;
            }

            price *= monthsForPayment;

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
