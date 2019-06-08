namespace _03._01.GameStatistics
{
    using System;

    class GameStatistics
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string playersName = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            else if (minutes < 45)
            {
                Console.WriteLine("First half time.");
            }
            else if (minutes >= 45 && minutes <= 90)
            {
                Console.WriteLine("Second half time.");
            }

            if (minutes >= 1 && minutes <= 10)
            {
                Console.WriteLine($"{playersName} missed a penalty.");

                if (minutes % 2 == 0)
                {
                    Console.WriteLine(
                        $"{playersName} was injured after the penalty.");
                }
            }
            else if (minutes > 10 && minutes <= 35)
            {
                Console.WriteLine($"{playersName} received yellow card.");

                if (minutes % 2 != 0)
                {
                    Console.WriteLine(
                        $"{playersName} got another yellow card.");
                }
            }
            else if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine($"{playersName} SCORED A GOAL !!!");
            }
            else if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine($"{playersName} got a freekick.");

                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{playersName} missed the freekick.");
                }
            }
            else if (minutes > 55 && minutes <= 80)
            {
                Console.WriteLine($"{playersName} missed a shot from corner.");

                if (minutes % 2 != 0)
                {
                    Console.WriteLine(
                        $"{playersName} has been changed with another player.");
                }
            }
            else if (minutes > 80 && minutes <= 90)
            {
                Console.WriteLine($"{playersName} SCORED A GOAL FROM PENALTY !!!");
            }
        }
    }
}
