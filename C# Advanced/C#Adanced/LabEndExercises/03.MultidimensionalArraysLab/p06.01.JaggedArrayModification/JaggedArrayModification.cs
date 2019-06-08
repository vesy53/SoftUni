namespace p06._01.JaggedArrayModification
{
    using System;
    using System.Linq;

    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[size][];

            FillInTheMatrix(jaggedArray);

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 ||
                    row >= jaggedArray.Length ||
                    col < 0 ||
                    col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        jaggedArray[row][col] += value;
                        break;
                    case "Subtract":
                        jaggedArray[row][col] -= value;
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void FillInTheMatrix(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = numbers;
            }
        }
    }
}
