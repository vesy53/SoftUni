namespace p05._02.SnakeMoves
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
            char[] snake = Console.ReadLine()
                .ToCharArray();

            int rows = size[0];
            int columns = size[1];

            char[][] matrix = new char[rows][];

            int counter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[columns];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int index = counter % snake.Length;

                    matrix[row][col] = snake[index];

                    counter++;
                }
            }

            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
