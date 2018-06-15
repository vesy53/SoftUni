using System;

namespace p08TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());


            double commision = -1;
                
            if (sale >= 0 && sale <= 500)
            {
                if (town == "Sofia")
                {
                    commision = 0.05;
                }
                else if (town == "Varna")
                {
                    commision = 0.045;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.055;
                }
            }
            else if (sale > 500 && sale <= 1000)
            {
                if (town == "Sofia")
                {
                    commision = 0.07;
                }
                else if (town == "Varna")
                {
                    commision = 0.075;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.08;
                }
            }
            else if (sale > 1000 && sale<= 10000)
            {
                if (town == "Sofia")
                {
                    commision = 0.08;
                }
                else if (town == "Varna")
                {
                    commision = 0.10;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.12;
                }
            }
            else if (sale > 10000)
            {
                if (town == "Sofia")
                {
                    commision = 0.12;
                }
                else if (town == "Varna")
                {
                    commision = 0.13;
                }
                else if (town == "Plovdiv")
                {
                    commision = 0.145;
                }
            }

            double total = sale * commision;

            if (commision >= 0)
            {
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
