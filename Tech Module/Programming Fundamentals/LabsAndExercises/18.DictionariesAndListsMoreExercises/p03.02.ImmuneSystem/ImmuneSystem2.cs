using System;
using System.Collections.Generic;

class ImmuneSystem2
{
    static void Main(string[] args)
    {
        int initialHealth = int.Parse(Console.ReadLine());
        string virus = Console.ReadLine();

        List<string> virusNames = new List<string>();
        int currentHealth = initialHealth;
        bool isDefeat = true;

        while (virus != "end")
        {
            int sum = 0;

            foreach (var element in virus)
            {
                sum += element;
            }

            int virusStrength = sum / 3;
            int timeDefeatInSec = 0;

            if (!virusNames.Contains(virus))
            {
                virusNames.Add(virus);
                timeDefeatInSec = virusStrength * virus.Length;
            }
            else
            {
                timeDefeatInSec = (virusStrength * virus.Length) / 3;
            }

            int minutes = timeDefeatInSec / 60;
            int seconds = timeDefeatInSec % 60;
            currentHealth -= timeDefeatInSec;

            Console.WriteLine($"Virus {virus}: {virusStrength} => {timeDefeatInSec} seconds");

            if (currentHealth <= 0)
            {
                isDefeat = false;
                break;
            }
            else
            {
                Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {currentHealth}");
            }

            currentHealth += currentHealth * 20 / 100;

            if (currentHealth > initialHealth)
            {
                currentHealth = initialHealth;
            }

            virus = Console.ReadLine();
        }

        if (isDefeat)
        {
            Console.WriteLine($"Final Health: {currentHealth}");
        }
        else
        {
            Console.WriteLine("Immune System Defeated.");
        }
    }
}

