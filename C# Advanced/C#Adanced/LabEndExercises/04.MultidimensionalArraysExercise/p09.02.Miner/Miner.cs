namespace p09._02.Miner
{
    using System;
    using System.Linq;

    class Miner
    {
        static char[][] matrix;
        static int startRow;
        static int startCol;
        static int initialCoals;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            initialCoals = 0;
            matrix = new char[size][];

            FillTheMatrix();

            int countCoals = 0;

            foreach (string command in commands)
            {
                MoveMinior(command);

                if (matrix[startRow][startCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");
                    return;
                }
                else if (matrix[startRow][startCol] == 'c')
                {
                    countCoals++;
                    matrix[startRow][startCol] = '*';

                    if (countCoals == initialCoals)
                    {
                        Console.WriteLine(
                            $"You collected all coals! ({startRow}, {startCol})");
                        return;
                    }
                }
            }

            int remainingCoals = initialCoals - countCoals;

            Console.WriteLine(
                $"{remainingCoals} coals left. ({startRow}, {startCol})");
        }

        private static void MoveMinior(string command)
        {
            switch (command)
            {
                case "up":
                    startRow--;

                    startRow = startRow < 0 ?
                        0 :
                        startRow;
                    break;
                case "right":
                    startCol++;

                    startCol = startCol >= matrix[startRow].Length ?
                        matrix[startRow].Length - 1 :
                        startCol;
                    break;
                case "left":
                    startCol--;

                    startCol = startCol < 0 ?
                        0 :
                        startCol;
                    break;
                case "down":
                    startRow++;
                    startRow = startRow >= matrix.Length ?
                        matrix.Length - 1 :
                        startRow;
                    break;
            }
        }

        private static void FillTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('s'))
                {
                    startRow = row;
                    startCol = Array.IndexOf(matrix[row], 's');
                }

                if (matrix[row].Contains('c'))
                {
                    initialCoals += matrix[row]
                        .Count(m => m.Equals('c'));
                }
            }
        }
    }
}
