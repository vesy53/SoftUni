namespace p11._01.KeyRevolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            int countShootBullets = 0;

            while (bulletsStack.Count != 0 &&
                locksQueue.Count != 0)
            {
                int currentBullet = bulletsStack.Pop();
                int currentLock = locksQueue.Peek();

                if (currentBullet > currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                else if (currentBullet <= currentLock)
                {
                    locksQueue.Dequeue();

                    Console.WriteLine("Bang!");
                }

                countShootBullets++;

                if (countShootBullets % sizeGunBarrel == 0 &&
                    bulletsStack.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locksQueue.Count == 0)
            {
                int bulletsLeft = bulletsStack.Count;

                intelligence -= countShootBullets * priceBullet;

                Console.WriteLine(
                    $"{bulletsLeft} bullets left. Earned ${intelligence}");
            }
            else
            {
                int locksLeft = locksQueue.Count;

                Console.WriteLine(
                    $"Couldn't get through. Locks left: {locksLeft}");
            }
        }
    }
}