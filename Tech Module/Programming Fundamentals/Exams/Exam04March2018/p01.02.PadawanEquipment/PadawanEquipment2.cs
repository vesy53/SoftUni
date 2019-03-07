namespace p01._02.PadawanEquipment
{
    using System;

    class PadawanEquipment2
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double lightsabersMoney = Math.Ceiling(lightsabers * (students * 1.1));
            double robesMoney = robes * students;
            double beltsMoney = belts * (students - students / 6);

            double totalMoney = lightsabersMoney + robesMoney + beltsMoney;

            if (totalMoney > money)
            {
                totalMoney -= money;

                Console.WriteLine(
                    $"Ivan Cho will need {totalMoney:F2}lv more.");
            }
            else
            {
                Console.WriteLine(
                    $"The money is enough - it would cost {totalMoney:F2}lv.");

            }
        }
    }
}
