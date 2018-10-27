using System;
using System.Linq;
using System.Collections.Generic;

class Exercises2
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Exercise> exercises = new List<Exercise>();

        while (input != "go go go")
        {
            string[] inputTokens = input
                .Split(new string[] { " -> ", ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Exercise newExercises = new Exercise
            {
                Topic = inputTokens[0],
                CourseName = inputTokens[1],
                JudgeContestLink = inputTokens[2],
                Problems = inputTokens.Skip(3).ToList(),
            };

            exercises.Add(newExercises);

            input = Console.ReadLine();
        }

        for (int i = 0; i < exercises.Count; i++)
        {
            string topic = exercises[i].Topic;
            string courseName = exercises[i].CourseName;
            string judgeLink = exercises[i].JudgeContestLink;
            List<string> problems = exercises[i].Problems;

            Console.WriteLine($"Exercises: {topic}");
            Console.WriteLine(
                $"Problems for exercises and homework for " +
                $"the \"{courseName}\" course @ SoftUni.");
            Console.WriteLine
                ($"Check your solutions here: {judgeLink}");

            int index = 1;

            foreach (string problem in problems)
            {
                Console.WriteLine($"{index}. {problem}");

                index++;
            }
        }
    }
}

class Exercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeContestLink { get; set; }
    public List<string> Problems { get; set; }
}