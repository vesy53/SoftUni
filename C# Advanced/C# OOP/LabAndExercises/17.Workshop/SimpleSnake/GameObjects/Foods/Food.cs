namespace SimpleSnake.GameObjects.Foods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Food : Point
    {
        private readonly Wall wall;
        private readonly Random random;
        private readonly char foodSymbol;

        protected Food(Wall wall, char foodSymbol, int points)
           : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.FoodPoints = points;

            this.random = new Random();
        }

        public int FoodPoints { get; private set; }

        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY &&
                   snake.LeftX == this.LeftX;
        }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
            this.TopY = this.random.Next(2, this.wall.TopY - 2);

            bool isPointOfSnake = snakeElements
                .Any(x => x.LeftX == this.LeftX &&
                          x.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
                this.TopY = this.random.Next(2, this.wall.TopY - 2);

                isPointOfSnake = snakeElements
                    .Any(x => x.LeftX == this.LeftX &&
                              x.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(this.foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
