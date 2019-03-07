using System;
using System.Collections.Generic;
using System.Linq;

class Exercises3
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Exercise> exercises = new List<Exercise>();

        while (input.Equals("go go go") == false)
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

        foreach (var exercise in exercises)
        {
            string topic = exercise.Topic;
            string courseName = exercise.CourseName;
            string judgeLink = exercise.JudgeContestLink;

            Console.WriteLine($"Exercises: {topic}");
            Console.WriteLine
                ($"Problems for exercises and homework for the " +
                $"\"{exercise.CourseName}\" course @ SoftUni.");
            Console.WriteLine(
                $"Check your solutions here: {judgeLink}");

            int count = 1;

            foreach (var problem in exercise.Problems)
            {
                Console.WriteLine($"{count}. {problem}");

                count++;
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