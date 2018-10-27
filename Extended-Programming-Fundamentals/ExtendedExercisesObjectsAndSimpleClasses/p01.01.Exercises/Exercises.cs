using System;
using System.Collections.Generic;

class Exercises
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var data = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();

        while (input.Equals("go go go") == false)
        {
            Exercise exercise = ReadExercise(input);

            string topic = exercise.Topic;
            string courseName = exercise.CourseName;
            string judgeContestLink = exercise.JudgeContestLink;
            string[] problems = exercise.Problems;

            if (!data.ContainsKey(topic))
            {
                data.Add(topic, new Dictionary<string, Dictionary<string, List<string>>>());
            }

            if (!data[topic].ContainsKey(courseName))
            {
                data[topic].Add(courseName, new Dictionary<string, List<string>>());
            }

            if (!data[topic][courseName].ContainsKey(judgeContestLink))
            {
                data[topic][courseName].Add(judgeContestLink, new List<string>());
            }

            data[topic][courseName][judgeContestLink].AddRange(problems);

            input = Console.ReadLine();
        }

        foreach (var itemData in data)
        {
            string topic = itemData.Key;
            var abilities = itemData.Value;

            Console.WriteLine($"Exercises: {topic}");
           
            foreach (var ability in abilities)
            {
                string courseName = ability.Key;
                var links = ability.Value;

                Console.WriteLine(
                    $"Problems for exercises and homework for " +
                    $"the \"{courseName}\" course @ SoftUni.");

                foreach (var link in links)
                {
                    string judgeLink = link.Key;
                    List<string> problems = link.Value;

                    int index = 1;

                    Console.WriteLine(
                        $"Check your solutions here: {judgeLink}");

                    foreach (var problem in problems)
                    {
                        Console.WriteLine($"{index}. {problem}");

                        index++;
                    }
                }
            }
        }
    }

    static Exercise ReadExercise(string input)
    {
        string[] inputTokens = input
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);

        Exercise exercise = new Exercise
        {
            Topic = inputTokens[0],
            CourseName = inputTokens[1],
            JudgeContestLink = inputTokens[2],
            Problems = inputTokens[3]
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
        };

        return exercise;
    }
}

class Exercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeContestLink { get; set; }
    public string[] Problems { get; set; }
}