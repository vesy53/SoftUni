using System;

namespace pr02VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal boudget = decimal.Parse(Console.ReadLine());

            decimal currentBalance = boudget;
            decimal price = 0m;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "OutFall 4")
                {
                    price = 39.99m;
                }
                else if (command == "CS: OG")
                {
                    price = 15.99m;
                }
                else if (command == "Zplinter Zell")
                {
                    price = 19.99m;
                }
                else if (command == "Honored 2")
                {
                    price = 59.99m;
                }
                else if (command == "RoverWatch")
                {
                    price = 29.99m;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    price = 39.99m;
                }
                else if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${boudget - currentBalance:f2}. Remaining: ${currentBalance:f2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                currentBalance -= price;

                if (currentBalance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    currentBalance += price;
                }
                else if (currentBalance >= 0)
                {
                    Console.WriteLine($"Bought {command}");

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
            }
        }
    }
}









