namespace p02._01.SquaresInMatrix
{
    using System;
    using System.Linq;

    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];

            char[][] matrix = new char[rows][];

            FillInTheMatrix(matrix);

            int count = 0; 

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    if (EqualSquare(matrix, row, col))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static bool EqualSquare(char[][] matrix, int row, int col)
        {
            return matrix[row][col] == matrix[row][col + 1] &&
                   matrix[row][col] == matrix[row + 1][col] &&
                   matrix[row][col] == matrix[row + 1][col + 1];
        }

        private static void FillInTheMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                // char[] elements = Console.ReadLine()
                //   .Replace(" ", "")
                //   .ToCharArray();

                matrix[row] = elements;
            }
        }
    }
}
