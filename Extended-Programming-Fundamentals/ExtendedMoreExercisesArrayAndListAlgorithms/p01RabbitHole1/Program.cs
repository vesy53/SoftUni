using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> obstacles = Console.ReadLine()
            .Split()
            .ToList();
        int initialEnergy = int.Parse(Console.ReadLine());

        int index = 0;
        bool isBomb = false;

        while (initialEnergy > 0)
        {
            string currentObstacle = obstacles[index];
            string[] command = currentObstacle.Split('|');
            string currentCommand = command[0];

            if (currentCommand.Equals("RabbitHole"))
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                return;
            }

            int jump = int.Parse(command[1]);

            switch (currentCommand)
            {
                case "Left":
                    index = Math.Abs(index - jump % obstacles.Count);
                    break;
                case "Right":
                    index += jump % obstacles.Count;
                    break;
                case "Bomb":
                    obstacles.RemoveAt(index);
                    isBomb = true;
                    index = 0;
                    break;
            }

            initialEnergy -= jump;

            if (obstacles.Last() != "RabbitHole")
            {
                obstacles.RemoveAt(obstacles.Count - 1);
            }

            obstacles.Add("Bomb|" + jump);
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

