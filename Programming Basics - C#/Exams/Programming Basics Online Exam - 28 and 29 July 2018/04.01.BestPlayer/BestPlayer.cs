namespace _04._01.BestPlayer
{
    using System;

    class BestPlayer
    {
        static void Main(string[] args)
        {
            string playersName = Console.ReadLine();

            int maxGoals = 0;
            string searchName = string.Empty;

            while (playersName.Equals("END") == false)
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    searchName = playersName;
                }

                if (maxGoals >= 10)
                {
                    break;
                }

                playersName = Console.ReadLine();
            }

            Console.WriteLine($"{searchName} is the best player!");

            if (maxGoals >= 3)
            {
                Console.WriteLine(
                    $"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else if (maxGoals >= 0 || maxGoals < 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
