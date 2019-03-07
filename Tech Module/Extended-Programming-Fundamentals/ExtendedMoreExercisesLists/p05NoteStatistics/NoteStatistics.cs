using System;
using System.Collections.Generic;
using System.Linq;

class NoteStatistics
{
    static void Main(string[] args)
    {
        List<string> notes = new List<string>(new string[]
        {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"
        });

        List<double> inputFrequencies = new List<double>(new double[]
        {
            261.63,
            277.18,
            293.66,
            311.13,
            329.63,
            349.23,
            369.99,
            392.00,
            415.30,
            440.00,
            466.16,
            493.88
        });

        List<double> input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<string> currentNotes = new List<string>();
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();
        double naturalSum = 0.0;
        double sharpsSum = 0.0;
        
        for (int i = 0; i < input.Count; i++)
        {
            int index = inputFrequencies.IndexOf(input[i]);
            string nameNote = notes[index];
            currentNotes.Add(nameNote);

            if (nameNote.Contains("#"))
            {
                sharps.Add(nameNote);
                sharpsSum += input[i];
            }
            else
            {
                naturals.Add(nameNote);
                naturalSum += input[i];
            }

        }

        Console.WriteLine("Notes: " + string.Join(" ", currentNotes));
        Console.WriteLine("Naturals: " + string.Join(", ", naturals));
        Console.WriteLine("Sharps: " + string.Join(", ", sharps));
        Console.WriteLine($"Naturals sum: {naturalSum}");
        Console.WriteLine($"Sharps sum: {sharpsSum}");
    }
}

