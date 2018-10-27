namespace p01._01.RageExpenses
{
    using System;

    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double trashesHeadset = Math.Floor(lostGames / 2.0);
            double trashesMouse = Math.Floor(lostGames / 3.0);
            double trashesKeyboard = Math.Floor(lostGames / 6.0);
            double trashesDisplay = Math.Floor(trashesKeyboard / 2);

            priceHeadset *= trashesHeadset;
            priceMouse *= trashesMouse;
            priceKeyboard *= trashesKeyboard;
            priceDisplay *= trashesDisplay;

            double total = priceHeadset + priceMouse + priceKeyboard + priceDisplay;

            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
