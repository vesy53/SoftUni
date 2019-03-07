namespace p01._02.RageExpenses
{
    using System;

    class RageExpenses2
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int trashesHeadset = lostGames / 2;
            int trashesMouse = lostGames / 3;
            int trashesKeyboard = lostGames / 6;
            double trashesDisplay = Math.Floor(trashesKeyboard / 2.0);

            priceHeadset *= trashesHeadset;
            priceMouse *= trashesMouse;
            priceKeyboard *= trashesKeyboard;
            priceDisplay *= trashesDisplay;

            double total = priceHeadset + priceMouse + priceKeyboard + priceDisplay;

            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
