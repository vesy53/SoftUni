using System;
using System.Linq;

class MirrorImage1
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine()
            .Split()
            .ToArray();
        string command = Console.ReadLine();

        while (command.Equals("Print") == false)
        {
            int index = int.Parse(command);

            for (int i = 0; i < index / 2; i++)
            {
                string temp = numbers[i];
                numbers[i] = numbers[index - 1 - i];
                numbers[index - 1 - i] = temp;
            }

            Array.Reverse(numbers);
            int length = numbers.Length;

            for (int i = 0; i < (length - 1 - index) / 2; i++)
            {
                string temp = numbers[i];
                numbers[i] = numbers[length - index - 2 - i];
                numbers[length - index - 2 - i] = temp;
            }

            Array.Reverse(numbers);

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

