namespace p02._01.IndexOfLetters
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefjhijklmnopqrstuvwxyz"
                .ToCharArray();
            string[] letters = Console.ReadLine()
                .ToCharArray()
                .Select(x => x.ToString())
                .ToArray();

            File.WriteAllLines("input.txt", letters);
            File.WriteAllText("output.txt", string.Empty);

            foreach (var letter in letters)
            {
                File.AppendAllText
                (
                    "output.txt",
                    $"{letter} -> " +
                    $"{Array.IndexOf(alphabet, char.Parse(letter))}" +
                    $"{Environment.NewLine}"
                );
            }
        }
    }
}
