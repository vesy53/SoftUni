namespace p04._01.MatrixShuffling
{
    using System;
    using System.Linq;

    class MatrixShuffling
    {
        static int rows;
        static string[][] matrix;

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            rows = size[0];

            matrix = new string[rows][];

            FillInTheMatrix();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];

                if (tokens.Length == 5 &&
                    command == "swap")
                {
                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    bool isValidFirstElement = IsOutOfTheRange(firstRow, firstCol);
                    bool isValidSecondElement = IsOutOfTheRange(secondRow, secondCol);

                    if (isValidFirstElement &&
                        isValidSecondElement)
                    {
                        ResultInvalidInput();
                        input = Console.ReadLine();

                        continue;
                    }

                    string temp = matrix[firstRow][firstCol];
                    matrix[firstRow][firstCol] = matrix[secondRow][secondCol];
                    matrix[secondRow][secondCol] = temp;

                    PrintResult();
                }
                else
                {
                    ResultInvalidInput();
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintResult()
        {
            foreach (string[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void ResultInvalidInput()
        {
            Console.WriteLine("Invalid input!");
        }

        private static bool IsOutOfTheRange(int row, int col)
        {
            bool isInvalidInput = row < 0 ||
                                  row >= matrix.Length ||
                                  col < 0 ||
                                  col >= matrix[row].Length;

            if (!isInvalidInput)
            {
                return false;
            }

            return true;
        }

        private static void FillInTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                matrix[row] = input;
            }
        }
    }
}
