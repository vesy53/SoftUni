namespace SimpleSnake.Core
{
    using System;
    using System.Threading;

    using SimpleSnake.Enums;
    using SimpleSnake.GameObjects;

    public class Engine 
    {
        private readonly Wall wall;
        private readonly Snake snake;
        private readonly Point[] pointsOfDirection;

        private Direction direction;

        private double sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            this.wall = wall;
            this.snake = snake;

            this.sleepTime = 100;
            this.pointsOfDirection = new Point[4];
        }

        public void Run()
        {
            this.CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    this.GetNextDirection();
                }

                bool isMoving = this.snake
                    .IsMoving(this.pointsOfDirection[(int)this.direction]);

                if (!isMoving)
                {
                    this.AskUserForRestart();
                }

                this.sleepTime -= 0.01;

                Thread.Sleep((int)sleepTime);
            }
        }

        private void CreateDirections()
        {
            this.pointsOfDirection[0] = new Point(1, 0);    // right
            this.pointsOfDirection[1] = new Point(-1, 0);   // left
            this.pointsOfDirection[2] = new Point(0, 1);    // down
            this.pointsOfDirection[3] = new Point(0, -1);   // up
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                if (this.direction != Direction.Right)
                {
                    this.direction = Direction.Left;
                }
            }
            else if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (this.direction != Direction.Left)
                {
                    this.direction = Direction.Right;
                }
            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (this.direction != Direction.Down)
                {
                    this.direction = Direction.Up;
                }
            }
            else if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (this.direction != Direction.Up)
                {
                    this.direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }

        private void AskUserForRestart()
        {
            int leftX = this.wall.LeftX + 1;
            int topY = 3;

            Console.SetCursorPosition(leftX, topY);
            Console.Write("Would you like to continue? yes/no");
            Console.SetCursorPosition(leftX, topY + 1);

            string input = Console.ReadLine();

            if (input == "yes")
            {
                Console.Clear();
                StartUp.Main();
            }
            else if (input == "no")
            {
                this.StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Game over!");
            Environment.Exit(0);
        }
    }
}
