using System;

namespace p04Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int heightCake = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int totalCake = widthCake * heightCake;
            int takePieces = 0;

            while (command != "STOP")
            {
                takePieces = int.Parse(command);

                if (takePieces > totalCake)
                {
                    break;
                }
                else
                {
                    totalCake -= takePieces;
                }

                command = Console.ReadLine();
            }

            if (takePieces > totalCake)
            {
                takePieces -= totalCake;

                Console.WriteLine(
                    $"No more cake left! You need {takePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalCake} pieces are left.");
            }
            
        }
    }
}
