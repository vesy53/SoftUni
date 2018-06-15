using System;

namespace p01HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double squareMetre = double.Parse(Console.ReadLine());

            double bathroom = smallRoom / 2;
            double secRoom = smallRoom + smallRoom * 0.1;
            double thirdRoom = secRoom + secRoom * 0.1;
            double total = smallRoom + kitchen + bathroom + secRoom + thirdRoom;
            double korridor = total * 0.05;
            total += korridor;
            double totalPrice = total * squareMetre;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
