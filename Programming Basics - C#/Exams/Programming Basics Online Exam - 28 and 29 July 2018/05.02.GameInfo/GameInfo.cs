namespace _05._02.GameInfo
{
    using System;
    using System.Text;

    class GameInfo
    {
        static void Main(string[] args)
        {
            string timsName = Console.ReadLine();
            int numOfMeetingsPlayed = int.Parse(Console.ReadLine());

            double totalTime = 0.0;
            int additionalTime = 0;
            int penalties = 0;

            for (int i = 0; i < numOfMeetingsPlayed; i++)
            {
                int durationOfMeeting = int.Parse(Console.ReadLine());

                totalTime += durationOfMeeting;

                if (durationOfMeeting > 90 && 
                    durationOfMeeting <= 120)
                {
                    additionalTime++;
                }
                else if (durationOfMeeting > 120)
                {
                    penalties++;
                }
            }

            double averageMinutes = totalTime / numOfMeetingsPlayed;

            StringBuilder builder = new StringBuilder();

            builder
                .Append(
                    $"{timsName} has played {totalTime} minutes. ")
                .AppendLine($"Average minutes per game: {averageMinutes:F2}")
                .AppendLine($"Games with penalties: {penalties}")
                .AppendLine($"Games with additional time: {additionalTime}");

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
