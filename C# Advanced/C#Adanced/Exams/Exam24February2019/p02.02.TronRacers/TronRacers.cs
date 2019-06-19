namespace p02._02.TronRacers
{
    using System;
    using System.Linq;

    class TronRacers
    {
        static char[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            int sizeIndexes = 2;
            int[] firstIndexes = new int[sizeIndexes];
            int[] secondIndexes = new int[sizeIndexes];

            FullTheMatrix(ref firstIndexes, ref secondIndexes);

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string firstCommand = commands[0];
                string secondCommand = commands[1];

                MovePlayer(firstCommand, ref firstIndexes);

                if (matrix[firstIndexes[0]][firstIndexes[1]] == 's')
                {
                    matrix[firstIndexes[0]][firstIndexes[1]] = 'x';
                    break;
                }
                else
                {
                    matrix[firstIndexes[0]][firstIndexes[1]] = 'f';
                }

                MovePlayer(secondCommand, ref secondIndexes);

                if (matrix[secondIndexes[0]][secondIndexes[1]] == 'f')
                {
                    matrix[secondIndexes[0]][secondIndexes[1]] = 'x';
                    break;
                }
                else
                {
                    matrix[secondIndexes[0]][secondIndexes[1]] = 's';
                }
            }

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void MovePlayer(
            string command, 
            ref int[] indexes)
        {
            switch (command)
            {
                case "down":
                    indexes[0]++;
                    break;
                case "up":
                    indexes[0]--;
                    break;
                case "right":
                    indexes[1]++;
                    break;
                case "left":
                    indexes[1]--;
                    break;
            }

            IsOutOfRange(ref indexes);
        }

        private static void IsOutOfRange(ref int[] indexes)
        {
            //row = indexes[0], col = indexes[1]
            if (indexes[0] < 0)
            {
                indexes[0] = matrix.Length - 1;
            }
            else if (indexes[0] > matrix.Length - 1)
            {
                indexes[0] = 0;
            }

            if (indexes[1] < 0)
            {
                indexes[1] = matrix.Length - 1;
            }
            else if (indexes[1] > matrix[indexes[0]].Length - 1)
            {
                indexes[1] = 0;
            }
        }

        private static void FullTheMatrix(
            ref int[] firstIndexes,
            ref int[] secondIndexes)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('f'))
                {
                    firstIndexes[0] = row;
                    firstIndexes[1] = Array.IndexOf(matrix[row], 'f');
                }
                else if (matrix[row].Contains('s'))
                {
                    secondIndexes[0] = row;
                    secondIndexes[1] = Array.IndexOf(matrix[row], 's');
                }
            }
        }
    }
}
