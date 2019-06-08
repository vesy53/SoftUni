namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BombTheBasement
    {
        static char[][] matrix;
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

            matrix = new char[rows][];

            FillTheMatrix(columns);

            BombExplodes();

            NewMethod(rows);

            PrintResult();
        }

        private static void NewMethod(int rows)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == '0')
                    {
                        for (int innerCol = row; innerCol < rows; innerCol++)
                        {
                            char currChar = matrix[innerCol][col];

                            if (currChar == '1')
                            {
                                matrix[row][col] = '1';
                                matrix[innerCol][col] = '0';
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
                        matrix[row][col] = '1';
                    }
                }
            }
        }

        private static bool AffectedCells(int row, int col)
        {
            return 
                Math.Pow((bombRow - row), 2) + Math.Pow((bombColumn - col), 2) <= Math.Pow(radius, 2);
        }

        private static void PrintResult()
        {
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    matrix.Select(r => string.Join("", r))));
        }

        private static void FillTheMatrix(int columns)
        {

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[columns];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = '0';
                }
            }
        }
    }
}
