namespace p06._01.BombTheBasement
{
    using System;
    using System.Linq;

    class BombTheBasement
    {
        static int[][] matrix;
        static int bombRow;
        static int bombColumn;
        static int radius;

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bombParameters = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int columns = size[1];

            bombRow = bombParameters[0];
            bombColumn = bombParameters[1];
            radius = bombParameters[2];

            matrix = new int[rows][];

            FillInTheMatrix(columns);

            BombExplodes();

            FallingDown();

            PrintResult();
        }

        private static void PrintResult()
        {
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void FallingDown()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        for (int i = row; i < matrix.Length; i++)
                        {
                            if (matrix[i][col] == 1)
                            {
                                matrix[row][col] = 1;
                                matrix[i][col] = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void BombExplodes()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (AffectedCells(row, col))
                    {
                        matrix[row][col] = 1;
                    }
                }
            }
        }

        private static bool AffectedCells(int row, int col)
        {
            bool isAffected = 
                Math.Pow((row - bombRow), 2) + Math.Pow((col - bombColumn), 2) <= Math.Pow(radius, 2);

            if (isAffected)
            {
                return true;
            }

            return false;
        }

        private static void FillInTheMatrix(int columns)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[columns];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = 0;
                }
            }
        }
    }
}
