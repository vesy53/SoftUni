namespace p01._02.KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KeyRevolver
    {
        static int priceOfEachBullet;
        static int[] bullets;
        static int intelligence;

        static void Main(string[] args)
        {
            priceOfEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarell = int.Parse(Console.ReadLine());
            bullets = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            intelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            while (true)
            {
                for (int i = 1; i <= sizeOfGunBarell; i++)
                {
                    int currBullet = bulletsStack.Pop();
                    int currLock = locksQueue.Peek();

                    if (currBullet <= currLock)
                    {
                        locksQueue.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }

                    if (sizeOfGunBarell == i &&
                        bulletsStack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                    }

                    PrintResult(bulletsStack, locksQueue);
                }
            }
        }

        private static void PrintResult(
            Stack<int> bulletsStack,
            Queue<int> locksQueue)
        {
            if (locksQueue.Count == 0)
            {
                int countShotBullets = bullets.Length - bulletsStack.Count;
                int bulletsPrice = countShotBullets * priceOfEachBullet;
                intelligence -= bulletsPrice;

                Console.WriteLine(
                    $"{bulletsStack.Count} bullets left. Earned ${intelligence}");
            }
            else if (bulletsStack.Count == 0)
            {
                Console.WriteLine(
                    $"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                return;
            }

            Environment.Exit(0);
        }
    }
}