using System;
using System.Collections.Generic;
using System.Linq;

class RabbitHole
{
    static void Main(string[] args)
    {
        List<string> obstacles = Console.ReadLine()
            .Split()
            .ToList();
        int initialEnergy = int.Parse(Console.ReadLine());

        int index = 0;
        bool isBomb = false;

        while(initialEnergy > 0)
        {
            string currentObstacle = obstacles[index]; 
            string[] currentObstacleElement = currentObstacle.Split('|');
            string direction = currentObstacleElement[0];
           
            if (direction.Equals("RabbitHole"))
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                return;
            }

            int jump = int.Parse(currentObstacleElement[1]);

            if (direction.Equals("Left"))
            {
                index = Math.Abs(index - jump % obstacles.Count);
            }
            else if (direction.Equals("Right"))
            {
                index += jump % obstacles.Count;
            }
            else if (direction.Equals("Bomb"))
            {
                obstacles.RemoveAt(index);
                isBomb = true;
                index = 0;
            }

            initialEnergy -= jump;

            if (obstacles[obstacles.Count - 1] != "RabbitHole")
            {
                obstacles.RemoveAt(obstacles.Count - 1);
            }

            obstacles.Add(string.Format($"Bomb|{jump}"));
            // obstacles.Add("Bomb|" + energy);
        }

        if (initialEnergy <= 0 && isBomb)
        {
            Console.WriteLine(
                "You are dead due to bomb explosion!");
        }
        else if (initialEnergy <= 0)
        {
            Console.WriteLine(
                "You are tired. You can't continue the mission.");
        }
    }
}

