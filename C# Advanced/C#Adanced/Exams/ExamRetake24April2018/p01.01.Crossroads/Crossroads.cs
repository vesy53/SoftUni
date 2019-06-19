namespace p01._01.Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Crossroads
    {
        static void Main(string[] args)
        {
            Queue<string> carsQueue = new Queue<string>();

            int greenLightInSeconds = int.Parse(Console.ReadLine());
            int freeWindowInSeconds = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int passedCars = 0;

            while (command.Equals("END") == false)
            {
                int greenLight = greenLightInSeconds;

                if (command != "green")
                {
                    carsQueue.Enqueue(command);

                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    while (greenLight > 0 &&
                           carsQueue.Any())
                    {
                        string currentCar = carsQueue.Peek();
                        int carLength = currentCar.Length;

                        if (carLength <= greenLight)
                        {
                            carsQueue.Dequeue();
                            greenLight -= carLength;
                            passedCars++;
                        }
                        else if (carLength > greenLight)
                        {
                            //crash
                            string carCrash = currentCar.Substring(greenLight);

                            if (freeWindowInSeconds >= carCrash.Length)
                            {
                                passedCars++;
                                carsQueue.Dequeue();
                                break;
                            }
                            else if (freeWindowInSeconds < currentCar.Length)
                            {
                                carCrash = carCrash.Substring(freeWindowInSeconds);

                                PrintResultOfTheCrash(currentCar, carCrash[0]);
                                return;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            PrintResult(passedCars);
        }

        private static void PrintResult(int passedCars)
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine(
                $"{passedCars} total cars passed the crossroads.");
        }

        static void PrintResultOfTheCrash(string currCar, char carCrash)
        {
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currCar} was hit at {carCrash}.");
        }
    }
}