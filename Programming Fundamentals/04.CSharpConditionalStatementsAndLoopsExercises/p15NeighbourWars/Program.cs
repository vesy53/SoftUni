using System;

namespace p15NeighbourWars
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;
            int round = 0;

            while(healthPesho > 0 && healthGosho > 0)
            {
                round++;

                if (round % 2 == 1)
                {
                    healthGosho -= peshosDamage;

                    if (healthGosho > 0)
                    {
                        Console.WriteLine(
                            $"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                }
                else if (round % 2 == 0)
                {
                    healthPesho -= goshosDamage;

                    if (healthPesho > 0)
                    {
                        Console.WriteLine(
                            $"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                }

                if (round % 3 == 0 && healthPesho > 0 && healthGosho > 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
               
            }

            if (healthPesho <= 0 )
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else if (healthGosho <= 0)
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}
