namespace _04._02.GroupStage
{
    using System;

    class GroupStage
    {
        static void Main(string[] args)
        {
            string tim = Console.ReadLine();
            int numMatch = int.Parse(Console.ReadLine());

            int totalGoalsScored = 0;
            int totalGoalsReceived = 0;
            int totalPoints = 0;
            int goalDifference = 0;

            for (int i = 0; i < numMatch; i++)
            {
                int goalsScored = int.Parse(Console.ReadLine());
                int goalsReceived = int.Parse(Console.ReadLine());

                if (goalsScored > goalsReceived)
                {
                    totalPoints += 3;
                }
                else if (goalsScored == goalsReceived)
                {
                    totalPoints += 1;
                }

                goalDifference += goalsScored - goalsReceived;

                totalGoalsScored += goalsScored;
                totalGoalsReceived += goalsReceived;
            }

            if (totalGoalsScored >= totalGoalsReceived)
            {
                Console.WriteLine(
                    $"{tim} has finished the group phase with {totalPoints} points.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }
            else if (totalGoalsScored < totalGoalsReceived)
            {
                Console.WriteLine(
                    $"{tim} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }
        }
    }
}
