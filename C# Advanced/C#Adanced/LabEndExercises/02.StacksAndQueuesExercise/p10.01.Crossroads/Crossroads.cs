namespace p10._01.Crossroads
{
    using System;
    using System.Collections.Generic;

    class Crossroads
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int countPassedCars = 0;
            Queue<string> queue = new Queue<string>();

            while (command.Equals("END") == false)
            {
                if (command == "green")
                {
                    int durationLight = greenLightDuration;

                    while (queue.Count != 0)
                    {
                        string currentCar = queue.Peek();
                        int lengthCar = currentCar.Length;

                        if (durationLight == 0)
                        {
                            break;
                        }
                        else if (durationLight >= lengthCar)
                        {
                            durationLight -= lengthCar;
                            queue.Dequeue();
                            countPassedCars++;
                        }
                        else
                        {
                            int lastLength = durationLight + freeWindowDuration;

                            if (lastLength >= lengthCar)
                            {
                                queue.Dequeue();
                                countPassedCars++;
                                break;
                            }
                            else
                            {
                                string crashedLetter = currentCar
                                    .Substring(lastLength, 1);

                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {crashedLetter}.");

                                return;
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine(
                $"{countPassedCars} total cars passed the crossroads.");
        }
    }
}
