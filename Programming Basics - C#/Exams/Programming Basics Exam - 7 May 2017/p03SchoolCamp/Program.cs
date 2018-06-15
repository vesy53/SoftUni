using System;

namespace p03SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNight = int.Parse(Console.ReadLine());

            double price = 0.0;
            string typeSport = "";

            if (season == "Winter")
            {
                if (typeGroup == "girls")
                {
                    price = 9.6;
                    typeSport = "Gymnastics";
                }
                else if (typeGroup == "boys")
                {
                    price = 9.6;
                    typeSport = "Judo";
                }
                else if (typeGroup == "mixed")
                {
                    price = 10;
                    typeSport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "girls")
                {
                    price = 7.2;
                    typeSport = "Athletics";
                }
                else if (typeGroup == "boys")
                {
                    price = 7.2;
                    typeSport = "Tennis";
                }
                else if (typeGroup == "mixed")
                {
                    price = 9.50;
                    typeSport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "girls")
                {
                    price = 15;
                    typeSport = "Volleyball";
                }
                else if (typeGroup == "boys")
                {
                    price = 15;
                    typeSport = "Football";
                }
                else if (typeGroup == "mixed")
                {
                    price = 20;
                    typeSport = "Swimming";
                }
            }

            double totalPrice = numStudents * numNight * price;

            if (numStudents >= 50)
            {
                totalPrice -= totalPrice * 0.5;
            }
            else if (numStudents >= 20 && numStudents < 50)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (numStudents >= 10 && numStudents < 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{typeSport} {totalPrice:F2} lv.");
        }
    }
}
