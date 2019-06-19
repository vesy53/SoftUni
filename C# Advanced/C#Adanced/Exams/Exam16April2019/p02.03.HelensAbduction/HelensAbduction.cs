namespace p02._03.HelensAbduction
{
    using System;
    using System.Linq;

    class HelensAbduction
    {
        private static int energy;
        private static int rows;
        private static char[][] matrix;
        private static int parisRow;
        private static int parisCol;
        private static int enemyRow;
        private static int enemyCol;
        private static bool isDead;
        private static bool areWins;

        static void Main(string[] args)
        {
            energy = int.Parse(Console.ReadLine());
            rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];
            parisRow = -1;
            parisCol = -1;
            isDead = false;
            areWins = false;

            FillMatrix();

            while (!isDead &&
                   !areWins)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = commandInfo[0];
                enemyRow = int.Parse(commandInfo[1]);
                enemyCol = int.Parse(commandInfo[2]);

                MovedEnemy();

                MovedParis(command);

                ParisMeetEnemy();

                ParisAndElenaRunAway();

                ParisIsDead();
            }

            PrintResult();

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            Console.WriteLine(
                string.Join(
                    Environment.NewLine,
                    matrix.Select(r => string.Join("", r))));
        }

        private static void PrintResult()
        {
            if (isDead)
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }
            else if (areWins)
            {
                Console.WriteLine(
                    $"Paris has successfully abducted Helen! Energy left: {energy}");
            }
        }

        private static void ParisIsDead()
        {
            if (energy <= 0)
            {
                matrix[parisRow][parisCol] = 'X';
                isDead = true;
            }
        }

        private static void ParisAndElenaRunAway()
        {
            if (matrix[parisRow][parisCol] == 'H')
            {
                matrix[parisRow][parisCol] = '-';
                areWins = true;
            }
        }

        private static void ParisMeetEnemy()
        {
            if (matrix[parisRow][parisCol] == 'S')
            {
                energy -= 2;

                if (energy <= 0)
                {
                    matrix[parisRow][parisCol] = 'X';
                    isDead = true;
                }
                else
                {
                    matrix[parisRow][parisCol] = '-';
                }
            }
        }

        private static void MovedParis(string command)
        {
            matrix[parisRow][parisCol] = '-';

            switch (command)
            {
                case "up":
                    parisRow = parisRow - 1 < 0 ? 
                        parisRow : 
                        parisRow - 1;
                    break;
                case "down":
                    parisRow = parisRow + 1 >= rows ? 
                        parisRow : 
                        parisRow + 1;
                    break;
                case "right":
                    parisCol = parisCol + 1 >= rows ? 
                        parisCol : 
                        parisCol + 1;
                    break;
                case "left":
                    parisCol = parisCol - 1 < 0 ? 
                        parisCol : 
                        parisCol - 1;
                    break;
            }

            energy--;
        }

        private static void MovedEnemy()
        {
            matrix[enemyRow][enemyCol] = 'S';
        }

        private static void FillMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();

                if (matrix[row].Contains('P'))
                {
                    parisRow = row;
                    parisCol = Array.IndexOf(matrix[row], 'P');
                }
            }
        }
    }
}
