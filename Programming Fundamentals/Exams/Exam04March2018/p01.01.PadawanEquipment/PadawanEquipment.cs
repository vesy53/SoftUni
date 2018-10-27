namespace p01._01.PadawanEquipment
{
    using System;

    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double totalLightsabers = 
                Math.Ceiling(countStudents + (countStudents * 0.1));

            int freeBelts = 0;

            if (countStudents >= 6)
            {
                freeBelts = countStudents / 6;
            }

            double sumLightsabers = priceLightsabers * totalLightsabers;
            double sumRobes = priceRobes * countStudents;
            double sumBelts = priceBelts * (countStudents - freeBelts);

            double total = sumLightsabers + sumRobes + sumBelts;

            if (total <= amountOfMoney)
            {
                Console.WriteLine(
                    $"The money is enough - it would cost {total:F2}lv.");
            }
            else if (total > amountOfMoney)
            {
                total -= amountOfMoney;

                Console.WriteLine(
                    $"Ivan Cho will need {total:F2}lv more.");
            }
        }
    }
}
