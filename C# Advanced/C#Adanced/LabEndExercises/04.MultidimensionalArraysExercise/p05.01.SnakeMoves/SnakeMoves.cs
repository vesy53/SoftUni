namespace p05._01.SnakeMoves
{
    using System;
    using System.Linq;

    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string snake = Console.ReadLine();

            int rows = size[0];
            int columns = size[1];

            char[][] matrix = new char[rows][];

            string bigSnake = string.Empty;

            double length = Math
                .Ceiling((double)rows * columns / snake.Length);

            for (int i = 0; i < length; i++)
            {
                bigSnake += snake;
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[columns];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    char currentElement = bigSnake[col];
            
                    matrix[row][col] = currentElement;
                }

                bigSnake = bigSnake.Remove(0, matrix[row].Length);
            }

            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
