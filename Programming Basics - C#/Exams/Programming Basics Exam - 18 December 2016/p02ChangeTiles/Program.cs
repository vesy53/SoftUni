using System;

namespace p02ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double widthOfTheFloor = double.Parse(Console.ReadLine());
            double lengthOfTheFloor = double.Parse(Console.ReadLine());
            double sideOfTheTriangle = double.Parse(Console.ReadLine());
            double heightOfTheTriangle = double.Parse(Console.ReadLine());
            double priceOfOneTile = double.Parse(Console.ReadLine());
            double amountForTheMaster = double.Parse(Console.ReadLine());

            double totalFloor = widthOfTheFloor * lengthOfTheFloor;
            double totalTile = sideOfTheTriangle * heightOfTheTriangle / 2;
            double neededTile = Math.Ceiling(totalFloor / totalTile) + 5;
            double totalMoney = neededTile * priceOfOneTile + amountForTheMaster;

            if (totalMoney <= money)
            {
                money -= totalMoney;

                Console.WriteLine($"{money:F2} lv left.");
            }
            else if (totalMoney > money)
            {
                totalMoney -= money;

                Console.WriteLine($"You'll need {totalMoney:F2} lv more.");
            }
        }
    }
}
