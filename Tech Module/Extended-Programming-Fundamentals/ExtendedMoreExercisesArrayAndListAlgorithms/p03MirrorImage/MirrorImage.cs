using System;
using System.Linq;

class MirrorImage
{
    static void Main(string[] args)
    {
       string[] numbers = Console.ReadLine()
            .Split()
            .ToArray();
        string command = Console.ReadLine();

        while (command.Equals("Print") == false)
        {
            int indexToRevers = int.Parse(command);

            for (int i = 0; i < indexToRevers / 2; i++)
            {
                string firstElement = numbers[i];
                string lastElement = numbers[indexToRevers - 1 - i];
            
                numbers[i] = lastElement;
                numbers[indexToRevers - 1 - i] = firstElement;
            }

            int index = 0;
            int length = numbers.Length;
            int endPsition = (length + indexToRevers + 1) / 2;

            for (int i = indexToRevers + 1; i < endPsition; i++)
            {
                string firstElement = numbers[i];
                string lastElement = numbers[length - 1 - index];

                numbers[i] = lastElement;
                numbers[length - 1 - index] = firstElement;
                index++;
            }
            
            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

