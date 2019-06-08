namespace p02._01.TronRacers
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

            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;

            FullTheMatrix(ref firstRow, ref firstCol, ref secondRow, ref secondCol);

            string input = Console.ReadLine();

            while (true)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string firstCommand = tokens[0];
                string secondCommand = tokens[1];

                PlayerMove(firstCommand, ref firstRow, ref firstCol);

                if (matrix[firstRow][firstCol] == '*')
                {
                    matrix[firstRow][firstCol] = 'f';
                }
                else if (matrix[firstRow][firstCol] == 's')
                {
                    PlayerIsDead(firstRow, firstCol);
                    break;
                }

                PlayerMove(secondCommand, ref secondRow, ref secondCol);

                if (matrix[secondRow][secondCol] == '*')
                {
                    matrix[secondRow][secondCol] = 's';
                }
                else if (matrix[secondRow][secondCol] == 'f')
                {
                    PlayerIsDead(secondRow, secondCol);
                    break;
                }

                input = Console.ReadLine();
            }

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void PlayerIsDead(int row, int col)
        {
            matrix[row][col] = 'x';
        }

        private static void PlayerMove(
            string command, 
            ref int row,
            ref int col)
        {
            switch (command)
            {
                case "left":
                    col--;
                    break;
                case "right":
                    col++;
                    break;
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
            }

            if (row == -1)
            {
               row = matrix.Length - 1;
            }
            else if (row == matrix.Length)
            {
                row = 0;
            }

            if (col == -1)
            {
                col = matrix.Length - 1;
            }
            else if (col == matrix[row].Length)
            {
                col = 0;
            }
        }

        private static void FullTheMatrix(
            ref int firstRow,
            ref int firstCol,
            ref int secondRow,
            ref int secondCol)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('f'))
                {
                    firstRow = row;
                    firstCol = Array.IndexOf(matrix[row], 'f');
                }
                else if (matrix[row].Contains('s'))
                {
                    secondRow = row;
                    secondCol = Array.IndexOf(matrix[row], 's');
                }
            }
        }
    }
}
