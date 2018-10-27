using System;
using System.Collections.Generic;
using System.Linq;

class NoteStatistics2
{
    static void Main(string[] args)
    {
        List<double> input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        Dictionary<double, string> notes = new Dictionary<double, string>()
        {
            {261.63, "C" },
            {277.18, "C#" },
            {293.66, "D" },
            {311.13, "D#" },
            {329.63, "E" },
            {349.23, "F" },
            {369.99, "F#" },
            {392.00, "G" },
            {415.30, "G#" },
            {440.00, "A" },
            {466.16, "A#" },
            {493.88,"B" }
        };

        string[] totalNote = new string[input.Count];
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();
        double naturalsSum = 0.0;
        double shaprsSum = 0.0;
        int index = 0;

        foreach(var item in input)
        {
            if (notes.ContainsKey(input[index]))
            {
                totalNote[index] = notes[item];

                if (totalNote[index].Length == 1)
                {
                    naturals.Add(totalNote[index]);
                    naturalsSum += input[index];
                }
                else
                {
                    sharps.Add(totalNote[index]);
                    shaprsSum += input[index];
                }
            }

            index++;
        }

        Console.WriteLine("Notes: " + string.Join(" ", totalNote));
        Console.WriteLine("Naturals: " + string.Join(", ", naturals));
        Console.WriteLine("Sharps: " + string.Join(", ", sharps));
        Console.WriteLine($"Naturals sum: {naturalsSum}");
        Console.WriteLine($"Sharps sum: {shaprsSum}");
    }
}

