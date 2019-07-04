namespace p03._01.JediGalaxy
{
    using System;
    using System.Linq;

    class JediGalaxy
    {
        private static int[,] matrix;

        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimestions[0];
            int cols = dimestions[1];

            matrix = new int[rows, cols];

            FullTheMatrix();

            string command = Console.ReadLine();

            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] ivoCoordinates = command
                    .Split(new string[] { " " },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evilCoordinates = Console.ReadLine()
                    .Split(new string[] { " " },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                int rowEvil = evilCoordinates[0];
                int colEvil = evilCoordinates[1];

                MoveEvil(ref rowEvil, ref colEvil);

                int rowIvo = ivoCoordinates[0];
                int colIvo = ivoCoordinates[1];

                MoveIvo(ref sum, ref rowIvo, ref colIvo);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static void MoveIvo(
            ref long sum,
            ref int rowIvo, 
            ref int colIvo)
        {
            while (rowIvo >= 0 &&
                   colIvo < matrix.GetLength(1))
            {
                if (IsInTheRange(rowIvo, colIvo))
                {
                    sum += matrix[rowIvo, colIvo];
                }

                rowIvo--;
                colIvo++;
            }
        }

        private static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.GetLength(0) &&
                   col >= 0 &&
                   col < matrix.GetLength(1);
        }

        private static void MoveEvil(
            ref int rowEvil, 
            ref int colEvil)
        {
            while (rowEvil >= 0 &&
                   colEvil >= 0)
            {
                if (IsInTheRange(rowEvil, colEvil))
                {
                    matrix[rowEvil, colEvil] = 0;
                }

                rowEvil--;
                colEvil--;
            }
        }

        private static void FullTheMatrix()
        {
            int value = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
