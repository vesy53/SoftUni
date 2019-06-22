namespace p01._01.KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int priceOfEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarell = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
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
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            int countSizeOfBarell = 0;

            while (bulletsStack.Count > 0 &&
                locksQueue.Count > 0)
            {
                int currBullet = bulletsStack.Pop();
                int currLock = locksQueue.Peek();
                countSizeOfBarell++;

                if (currBullet <= currLock)
                {
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (countSizeOfBarell == sizeOfGunBarell &&
                    bulletsStack.Count > 0)
                {
                    countSizeOfBarell = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if (locksQueue.Count == 0)
            {
                int countShotBullets = bullets.Length - bulletsStack.Count;
                int bulletsPrice = countShotBullets * priceOfEachBullet;
                intelligence -= bulletsPrice;

                Console.WriteLine(
                    $"{bulletsStack.Count} bullets left. Earned ${intelligence}");
            }
            else
            {
                Console.WriteLine(
                    $"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}