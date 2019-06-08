namespace p07._01.TrafficJam
{
    using System;
    using System.Collections.Generic;

    class TrafficJam
    {
        static void Main(string[] args)
        {
            int numVehicle = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();
            int countPassedCars = 0;

            while (command.Equals("end") == false)
            {
                if (command.Equals("green"))
                {
                    for (int i = 0; i < numVehicle; i++)
                    {
                        if (queue.Count != 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");

                            countPassedCars++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
        }
    }
}
