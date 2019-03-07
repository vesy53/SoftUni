using System;
using System.Linq;

class JapaneseRoulette
{
    static void Main(string[] args)
    {
        int[] bullet = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        string[] players = Console.ReadLine()
            .Split(' ')
            .ToArray();

        int bulletIndex = 0;

        for (int i = 0; i < bullet.Length; i++)
        {
            if (bullet[i] == 1)
            {
                bulletIndex = i;
                break;
            }
        }

        bool isDead = false;

        for (int i = 0; i < players.Length; i++)
        {
            string[] currentPlayers = players[i].Split(',');
            int power = int.Parse(currentPlayers[0]);
            string direction = currentPlayers[1];

            if (direction.Equals("Right"))
            {
                bulletIndex = (bulletIndex + power) % bullet.Length;
            }
            else if (direction.Equals("Left"))
            {
                if (bulletIndex - power < 0)
                {
                    bulletIndex = bullet.Length - Math.Abs(bulletIndex - power) % bullet.Length;
                }
                else
                {
                    bulletIndex = bulletIndex - power;
                }
            }

            if (bulletIndex == 2)
            {
                Console.WriteLine($"Game over! Player {i} is dead.");
                isDead = true;
                break;
            }

            bulletIndex = 
                bulletIndex + 1 == bullet.Length ? 
                0 : 
                bulletIndex + 1;
        }

        if (isDead == false)
        {
            Console.WriteLine("Everybody got lucky!");
        }
    }
}

