namespace p05._03.SnakeMoves
{
    using System;
    using System.Collections.Generic;
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

            Queue<char> snakeQueue = new Queue<char>(snake);

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[columns];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    char charToAdd = snakeQueue.Dequeue();

                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(
                string.Join(
                    Environment.NewLine, 
                    matrix.Select(r => string.Join("", r))));
        }
    }
}
